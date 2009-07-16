// ZipNameTransform.cs
//
// Copyright 2005 John Reilly
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// Linking this library statically or dynamically with other modules is
// making a combined work based on this library.  Thus, the terms and
// conditions of the GNU General Public License cover the whole
// combination.
// 
// As a special exception, the copyright holders of this library give you
// permission to link this library with independent modules to produce an
// executable, regardless of the license terms of these independent
// modules, and to copy and distribute the resulting executable under
// terms of your choice, provided that you also meet, for each linked
// independent module, the terms and conditions of the license of that
// module.  An independent module is a module which is not derived from
// or based on this library.  If you modify this library, you may extend
// this exception to your version of the library, but you are not
// obligated to do so.  If you do not wish to do so, delete this
// exception statement from your version.


using System;
using System.IO;

using VMukti.ZipUnzip.Core;

namespace VMukti.ZipUnzip.Zip
{
	/// <summary>
	/// ZipNameTransform transforms names as per the Zip file naming convention.
	/// </summary>
	/// <remarks>The use of absolute names is supported although its use is not valid 
	/// according to Zip naming conventions, and should not be used if maximum compatability is desired.</remarks>
	public class ZipNameTransform : INameTransform
	{
		#region Constructors
		/// <summary>
		/// Initialize a new instance of <see cref="ZipNameTransform"></see>
		/// </summary>
		public ZipNameTransform()
		{
			relativePath_ = true;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="ZipNameTransform"></see>
		/// </summary>
		/// <param name="trimPrefix">The string to trim from front of paths if found.</param>
		public ZipNameTransform(string trimPrefix)
		{
			relativePath_ = true;
			trimPrefix_ = trimPrefix;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="ZipNameTransform"></see>
		/// </summary>
		/// <param name="useRelativePaths">If true relative paths are created, 
		/// if false absolute paths are created. </param>
		/// <remarks>
		/// Absolute paths are not compatible with the Zip specification although
		/// archivers can create them.  If maximum compatability is important
		/// always user relative paths.
		/// </remarks>
		public ZipNameTransform(bool useRelativePaths)
		{
			relativePath_ = useRelativePaths;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="ZipNameTransform"></see>
		/// </summary>
		/// <param name="useRelativePaths">If true relative paths are created, 
		/// if false absolute paths are created. </param>
		/// <param name="trimPrefix">The string to trim from front of paths if found.</param>
		/// <remarks>
		/// Absolute paths are not compatible with the Zip specification. If maximum compatability is important
		/// always use relative paths.
		/// </remarks>
		public ZipNameTransform(bool useRelativePaths, string trimPrefix)
		{
			trimPrefix_ = trimPrefix;
			relativePath_ = useRelativePaths;
		}
		
		#endregion
		/// <summary>
		/// Static constructor.
		/// </summary>
		static ZipNameTransform()
		{
			char[] invalidPathChars;
#if NET_VER_1
			invalidPathChars = Path.InvalidPathChars;
#else
			invalidPathChars = Path.GetInvalidPathChars();
#endif
			int howMany = invalidPathChars.Length + 2;

			InvalidEntryCharsRelaxed = new char[howMany];
			Array.Copy(invalidPathChars, 0, InvalidEntryCharsRelaxed, 0, invalidPathChars.Length);
			InvalidEntryCharsRelaxed[howMany - 1] = '*';
			InvalidEntryCharsRelaxed[howMany - 2] = '?';

			howMany = invalidPathChars.Length + 4; 
			InvalidEntryChars = new char[howMany];
			Array.Copy(invalidPathChars, 0, InvalidEntryChars, 0, invalidPathChars.Length);
			InvalidEntryChars[howMany - 1] = ':';
			InvalidEntryChars[howMany - 2] = '\\';
			InvalidEntryChars[howMany - 3] = '*';
			InvalidEntryChars[howMany - 4] = '?';

		}

		/// <summary>
		/// Transform a directory name according to the Zip file naming conventions.
		/// </summary>
		/// <param name="name">The directory name to transform.</param>
		/// <returns>The transformed name.</returns>
		public string TransformDirectory(string name)
		{
			name = TransformFile(name);
			if (name.Length > 0) {
				if ( !name.EndsWith("/") ) {
					name += "/";
				}
			}
			else if ( !relativePath_ ) {
				name = "/";
			}
			else {
				throw new ZipException("Cannot have empty directory name");
			}
			return name;
		}
		
		/// <summary>
		/// Transform a file name according to the Zip file naming conventions.
		/// </summary>
		/// <param name="name">The file name to transform.</param>
		/// <returns>The transformed name.</returns>
		public string TransformFile(string name)
		{
			if (name != null) {
				if ( (trimPrefix_ != null) && (name.IndexOf(trimPrefix_) == 0) ) {
					name = name.Substring(trimPrefix_.Length);
				}
				
				if (Path.IsPathRooted(name) == true) {
					// NOTE:
					// for UNC names...  \\machine\share\zoom\beet.txt gives \zoom\beet.txt
					name = name.Substring(Path.GetPathRoot(name).Length);
				}
				
				name = name.Replace(@"\", "/");

				if ( relativePath_ ) {
					while ( (name.Length > 0) && (name[0] == '/')) {
						name = name.Remove(0, 1);
					}
				} else {
					if ( (name.Length > 0) && (name[0] != '/')) {
						name = name.Insert(0, "/");
					}
				}
			}
			else {
				name = string.Empty;
			}
			return name;
		}
		
		/// <summary>
		/// Get/set the path prefix to be trimmed from paths if present.
		/// </summary>
		public string TrimPrefix
		{
			get { return trimPrefix_; }
			set { trimPrefix_ = value; }
		}

		/// <summary>
		/// Test a name to see if it is a valid name for a zip entry.
		/// </summary>
		/// <param name="name">The name to test.</param>
		/// <param name="relaxed">If true checking is relaxed about windows file names and absolute paths.</param>
		/// <returns>Returns true if the name is a valid zip name; false otherwise.</returns>
		/// <remarks>Zip path names are actually in unix format,
		/// and should only contain relative paths.
		/// This means that any path stored should not contain a drive or
		/// device letter, or a leading slash.  All slashes should forward slashes '/'.
		/// An empty name is valid for a file where the input comes from standard input.
		/// A null name is not considered valid.
		/// </remarks>
		public static bool IsValidName(string name, bool relaxed)
		{
			bool result = (name != null);

			if ( result ) {
				if ( relaxed ) {
					result = name.IndexOfAny(InvalidEntryCharsRelaxed) < 0;
				}
				else {
					result = 
						(name.IndexOfAny(InvalidEntryChars) < 0) &&
						(name.IndexOf('/') != 0);
				}
			}

			return result;
		}

		/// <summary>
		/// Test a name to see if it is a valid name for a zip entry.
		/// </summary>
		/// <param name="name">The name to test.</param>
		/// <returns>Returns true if the name is a valid zip name; false otherwise.</returns>
		/// <remarks>Zip path names are actually in unix format,
		/// and should only contain relative paths if a path is present.
		/// This means that the path stored should not contain a drive or
		/// device letter, or a leading slash.  All slashes should forward slashes '/'.
		/// An empty name is valid where the input comes from standard input.
		/// A null name is not considered valid.
		/// </remarks>
		public static bool IsValidName(string name)
		{
			bool result = 
				(name != null) &&
				(name.IndexOfAny(InvalidEntryChars) < 0) &&
				(name.IndexOf('/') != 0)
				;
			return result;
		}

		#region Instance Fields
		string trimPrefix_;
		bool relativePath_;
		#endregion
		#region Class Fields
		static readonly char[] InvalidEntryChars;
		static readonly char[] InvalidEntryCharsRelaxed;
		#endregion
	}
}
