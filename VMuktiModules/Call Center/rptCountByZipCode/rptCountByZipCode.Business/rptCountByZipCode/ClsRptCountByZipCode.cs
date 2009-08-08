/* VMukti 2.0 -- An Open Source Video Communications Suite
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

using rptCountByZipCode.DataAccess;
using rptCountByZipCode.Common;
using System.Text;
using VMuktiAPI;

namespace rptCountByZipCode.Business
{
    public class ClsRptCountByZipCode : ClsBaseObject
    {
        public static StringBuilder sb1;
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
        #region Fields

        #endregion 

        #region Properties

       

        #endregion 

        #region Methods

        public override bool MapData(DataRow row)
        {
            try
            {

                return base.MapData(row);
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--MapData(DataRow row)--");
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
                return false;

            }
        }
      // Function to get campiagn from the list 
        public static DataSet GetAllCampaign()
        {
            try
            {
                return new rptCountByZipCode.DataAccess.ClsRptCountByZipCodeDataService().rptCountByZipCode_GetAllCampaign();
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--GetAllCampaign()--");
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

        // Function to get campiagnID from the list 
        public static DataSet GetAllListOfCampaign(int CampaignID)
        {
            try
            {
                return new rptCountByZipCode.DataAccess.ClsRptCountByZipCodeDataService().rptCountByZipCode_GetAllListByCapmID(CampaignID);
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--GetAllListOfCampaign(int CampaignID)--");
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

        // Function to retrive data from the store procedure

        public static DataSet GetCountByZipCode(int ListID,DateTime strtDate,DateTime endDate)
        {
            try
            {
                return new rptCountByZipCode.DataAccess.ClsRptCountByZipCodeDataService().rptCountByZipCode_GetCountByZipCode(ListID,strtDate,endDate);
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--GetCountByZipCode(int ListID)--");
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

        public static void Delete(int QuesID)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--Delete(int QuesID)--");
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
            }
            
            //Delete(QuesID, null);
        }

        public static void Delete(int QuesID, IDbTransaction txn)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--Delete(int QuesID, IDbTransaction txn)--");
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
            }

            //new ScriptDesigner.DataAccess.ClsQuestionAnsDataService(txn).Options_Delete(QuesID);
        }

        public void Save()
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--Save()--");
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
            }
            //Save(null);
        }

        public void Save(IDbTransaction txn)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.Data.Add("My Key", "CtlRole()--VMukti--:--VmuktiModules--:--Call Center--:--rptCountByZipCode--:--rptCountByZipCode.Business--:--ClsRptCountByZipCode.cs--:--Save(IDbTransaction txn)--");
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
            }
            //new ScriptDesigner.DataAccess.ClsQuestionAnsDataService(txn).Options_Save(_ID, _OptionName, _Description, _QuestionID, _ActionQuestionID);
        }

        #endregion 
    }
}
