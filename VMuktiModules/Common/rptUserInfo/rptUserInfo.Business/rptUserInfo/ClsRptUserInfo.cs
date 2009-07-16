/* VMukti 1.0 -- An Open Source Unified Communications Engine
*
* Copyright (C) 2008 - 2009, VMukti Solutions Pvt. Ltd.
*
* Hardik Sanghvi <hardik@vmukti.com>
*
* See http://www.vmukti.com for more information about
* the VMukti project. Please do not directly contact
* any of the maintainers of this project for assistance;
* the project provides a web site, forums and mailing lists
* for your use.

* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.

* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU General Public License for more details.

* You should have received a copy of the GNU General Public License
* along with this program. If not, see <http://www.gnu.org/licenses/>

*/
using System;
using System.Data;
using rptUserInfo.DataAccess;
using rptUserInfo.Common;
using System.Text;
using VMuktiAPI;

namespace rptUserInfo.Business
{
    public class ClsRptUserInfo : ClsBaseObject
    {
        public static StringBuilder sb1;
        #region Fields

        #endregion 

        #region Properties

       

        #endregion 

        #region Methods


        //public override bool MapData(DataRow row)
        //{
        //    try
        //    {
        //    return base.MapData(row);
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.MessageBox.Show(ex.ToString());
        //    }
        //}

        public static StringBuilder CreateTressInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User Is : " + VMuktiAPI.VMuktiInfo.CurrentPeer.DisplayName);
            sb.AppendLine();
            sb.Append("Peer Type is : " + VMuktiAPI.VMuktiInfo.CurrentPeer.CurrPeerType.ToString());
            sb.AppendLine();
            sb.Append("User's SuperNode is : " + VMuktiAPI.VMuktiInfo.CurrentPeer.SuperNodeIP);
            sb.AppendLine();
            sb.Append("User's Machine Ip Address : " + VMuktiAPI.GetIPAddress.ClsGetIP4Address.GetIP4Address());
            sb.AppendLine();
            sb.AppendLine("----------------------------------------------------------------------------------------");
            return sb;
        }

        public static DataSet GetAllUserList()
        {
            try
            {
                //Get all users using rptUserInfo_GetAllUsersByName frunction from rptUserInfo.DataAccess
                return new rptUserInfo.DataAccess.ClsRptUserInfo().rptUserInfo_GetAllUsersByName();
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "VMukti--:--VmuktiModules--:--User Info--:--RptUserInfo--:--RptUserInfo.Presentation--:--ctlRptUserInfo.xaml.cs--:--ctlRptUserInfo(ModulePermissions[] MyPermissions)--");
                ClsException.LogError(ex);
                ClsException.WriteToErrorLogFile(ex);
                System.Text.StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                sb.AppendLine();
                sb.AppendLine("StackTrace : " + ex.StackTrace);
                sb.AppendLine();
                sb.AppendLine("Location : " + ex.Data["My Key"].ToString());
                sb.AppendLine();
                sb1 = CreateTressInfo();
                sb.Append(sb1.ToString());
                VMuktiAPI.ClsLogging.WriteToTresslog(sb);
                return null;
            }
        }

        public static DataSet GetUserInfo(int ID)
        {
            try
            {
                //Get all user infromation using rptUserInfo_GetAllUserDetails function from rptUserInfo.DataAccess
                return new rptUserInfo.DataAccess.ClsRptUserInfo().rptUserInfo_GetAllUserDetails(ID);
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "VMukti--:--VmuktiModules--:--User Info--:--RptUserInfo--:--RptUserInfo.Presentation--:--ctlRptUserInfo.xaml.cs--:--ctlRptUserInfo(ModulePermissions[] MyPermissions)--");
                ClsException.LogError(ex);
                ClsException.WriteToErrorLogFile(ex);
                System.Text.StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                sb.AppendLine();
                sb.AppendLine("StackTrace : " + ex.StackTrace);
                sb.AppendLine();
                sb.AppendLine("Location : " + ex.Data["My Key"].ToString());
                sb.AppendLine();
                sb1 = CreateTressInfo();
                sb.Append(sb1.ToString());
                VMuktiAPI.ClsLogging.WriteToTresslog(sb);
                return null;
            }
            
        }

        public static DataSet GetOnlyLoginInfo(int ID)
        {
            try
            {                
                return new rptUserInfo.DataAccess.ClsRptUserInfo().rptUserInfo_GetUserLoginDetails(ID);
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "VMukti--:--VmuktiModules--:--User Info--:--RptUserInfo--:--RptUserInfo.Presentation--:--ctlRptUserInfo.xaml.cs--:--ctlRptUserInfo(ModulePermissions[] MyPermissions)--");
                ClsException.LogError(ex);
                ClsException.WriteToErrorLogFile(ex);
                System.Text.StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                sb.AppendLine();
                sb.AppendLine("StackTrace : " + ex.StackTrace);
                sb.AppendLine();
                sb.AppendLine("Location : " + ex.Data["My Key"].ToString());
                sb.AppendLine();
                sb1 = CreateTressInfo();
                sb.Append(sb1.ToString());
                VMuktiAPI.ClsLogging.WriteToTresslog(sb);
                return null;
            }         
            
        }
       
        #endregion
               
    }
}
