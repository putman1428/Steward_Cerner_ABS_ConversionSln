using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace ABS_Conversion
{
    public class CDV
    {
        private static string GlobalResult = "|||||||||||||||||||||||||";
        private static string today = DateTime.Today.ToString("yyyyMMdd");
        //dt.Rows[0][""].ToString() + "|" + dt.Rows[0][""].ToString() + "|" + dt.Rows[0][""].ToString() + "|" + dt.Rows[0][""].ToString() + "|" + dt.Rows[0][""].ToString();
        private static string SqlConnectionString()
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = "SHCDSDBP01";
            b.IntegratedSecurity = true;
            b.InitialCatalog = "WestConversionDB";
            return b.ConnectionString;

        }
        public static string GetPerson(string personID, bool zeroExtFile)
        {
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            personID = personID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT PERSON_ID,NAME_LAST,NAME_FIRST,NAME_MIDDLE,BIRTH_DT_TM,SEX_CD,RACE_CD,MARITAL_TYPE_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.PERSON] ");
            sb.Append("WHERE PERSON_ID = '" + personID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["PERSON_ID"].ToString() + "|" + dt.Rows[cnt]["NAME_LAST"].ToString() + "|" + dt.Rows[cnt]["NAME_FIRST"].ToString() + "|" + dt.Rows[cnt]["NAME_MIDDLE"].ToString() + "|" + dt.Rows[cnt]["BIRTH_DT_TM"].ToString() + "|" + dt.Rows[cnt]["SEX_CD"].ToString() + "|" + dt.Rows[cnt]["RACE_CD"].ToString() + "|" + dt.Rows[cnt]["MARITAL_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static string GetPersonAlias(string personID, bool zeroExtFile)
        {
            string result = "";
            string activeInd = "1";
            string typeCd = "18";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            personID = personID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            typeCd = typeCd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Alias,end_effective_dt_tm ");
            sb.Append("FROM  [cerner.Person_Alias] ");
            sb.Append("WHERE PERSON_ID = '" + personID + "' AND ACTIVE_IND = '" + activeInd + "' AND PERSON_ALIAS_TYPE_CD ='" + typeCd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = "";
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["Alias"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }
        public static string GetEncounter(string encID, bool zeroExtFile)
        {
            //ENCOUNTER: ORGANIZATION_ID,ENCNTR_ID,PERSON_ID,REG_DT_TM,DISCH_DT_TM,ENCNTR_TYPE_CD,FINANCIAL_CLASS_CD,LOC_NURSE_UNIT_CD,ARRIVE_DT_TM,
            //ADMIT_TYPE_CD,ENCNTR_TYPE_CD,ADMIT_MODE_CD,ADMIT_SRC_CD,EST_LENGTH_OF_STAY,REASON_FOR_VISIT,DISCH_DISPOSITION_CD,TRIAGE_DT_TM,
            //ACTIVE_IND,END_EFFECTIVE_DT_TM

            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            string result = "";
            string activeInd = "1";
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ORGANIZATION_ID,ENCNTR_ID,PERSON_ID,REG_DT_TM,DISCH_DT_TM,ENCNTR_TYPE_CD,FINANCIAL_CLASS_CD,LOC_NURSE_UNIT_CD,ARRIVE_DT_TM, ");
            sb.Append("ADMIT_TYPE_CD,ENCNTR_TYPE_CD,ADMIT_MODE_CD,ADMIT_SRC_CD,EST_LENGTH_OF_STAY,REASON_FOR_VISIT,DISCH_DISPOSITION_CD,TRIAGE_DT_TM, ");
            sb.Append("ACTIVE_IND,END_EFFECTIVE_DT_TM,INPATIENT_ADMIT_DT_TM ");
            sb.Append("FROM  [cerner.ENCOUNTER] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                //if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                //{
                    result = dt.Rows[cnt]["ORGANIZATION_ID"].ToString() + "|" + dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["PERSON_ID"].ToString() + "|" + dt.Rows[cnt]["REG_DT_TM"].ToString() + "|" + dt.Rows[cnt]["DISCH_DT_TM"].ToString() + "|" + dt.Rows[cnt]["ENCNTR_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["FINANCIAL_CLASS_CD"].ToString() + "|" + dt.Rows[cnt]["LOC_NURSE_UNIT_CD"].ToString() + "|" + dt.Rows[cnt]["ARRIVE_DT_TM"].ToString() + "|" + dt.Rows[cnt]["ADMIT_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ENCNTR_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ADMIT_MODE_CD"].ToString() + "|" + dt.Rows[cnt]["ADMIT_SRC_CD"].ToString() + "|" + dt.Rows[cnt]["EST_LENGTH_OF_STAY"].ToString() + "|" + dt.Rows[cnt]["REASON_FOR_VISIT"].ToString() + "|" + dt.Rows[cnt]["DISCH_DISPOSITION_CD"].ToString() + "|" + dt.Rows[cnt]["TRIAGE_DT_TM"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString() + "|" + dt.Rows[cnt]["INPATIENT_ADMIT_DT_TM"].ToString();
                    break;
                //}
                //cnt = cnt + 1;
            }
            return result;
        }

        public static ArrayList GetENCNTR_PRSNL_RELTN(string encID, bool zeroExtFile)
        {
            //ENCNTR_PRSNL_RELTN: ENCNTR_ID,ACTIVE_IND,ENCNTR_PRSNL_R_CD,PRSNL_PERSON_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM
            ArrayList resList = new ArrayList();
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,ENCNTR_PRSNL_R_CD,PRSNL_PERSON_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.ENCNTR_PRSNL_RELTN] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["ENCNTR_PRSNL_R_CD"].ToString() + "|" + dt.Rows[cnt]["PRSNL_PERSON_ID"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    resList.Add(result);
                }
                cnt = cnt + 1;
            }
            return resList;
        }

        public static Hashtable GetPROCEDURE(string encID, bool zeroExtFile, string hcis, string admDt)
        {
            //PROCEDURE: enctrID,NOMENCLATURE_ID,PROCEDURE_ID,PROC_DT_TM,PROC_PRIORITY,ANESTHESIA_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM
            ArrayList resList = new ArrayList();
            ArrayList newList = new ArrayList();

            ArrayList proc_resList = new ArrayList();
            ArrayList proc_newList = new ArrayList();

            Hashtable hash = new Hashtable();

            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            string result = "";
            string procResult = "";
            
            string activeInd = "1";
            string item = "";
            string[] items;
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,NOMENCLATURE_ID,PROCEDURE_ID,PROC_DT_TM,PROC_PRIORITY,ANESTHESIA_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_PROCEDURE] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "' ");


            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            string pdate = "";
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    if (dt.Rows[cnt]["PROC_PRIORITY"].ToString().Trim() != "0" )
                    {
                        if (dt.Rows[cnt]["PROC_PRIORITY"].ToString().Trim() != "")
                        {
                            pdate = GetCernerDate2(dt.Rows[cnt]["PROC_DT_TM"].ToString(), hcis);
                            if (pdate.Trim() == "")
                                pdate = admDt;
                            result = dt.Rows[cnt]["PROC_PRIORITY"].ToString().PadLeft(10, '0') + '%' + dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["NOMENCLATURE_ID"].ToString() + "|" + dt.Rows[cnt]["PROCEDURE_ID"].ToString() + "|" + dt.Rows[cnt]["PROC_DT_TM"].ToString() + "|" + dt.Rows[cnt]["PROC_PRIORITY"].ToString() + "|" + dt.Rows[cnt]["ANESTHESIA_CD"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                            procResult = pdate + "_" + dt.Rows[cnt]["PROC_PRIORITY"].ToString().PadLeft(10, '0') + '%' + dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["NOMENCLATURE_ID"].ToString() + "|" + dt.Rows[cnt]["PROCEDURE_ID"].ToString() + "|" + dt.Rows[cnt]["PROC_DT_TM"].ToString() + "|" + dt.Rows[cnt]["PROC_PRIORITY"].ToString() + "|" + dt.Rows[cnt]["ANESTHESIA_CD"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                            resList.Add(result);
                            proc_resList.Add(procResult);
                        }
                    }
                }
                cnt = cnt + 1;
            }
            resList.Sort();
            proc_resList.Sort();
            for (int y = 0; y < resList.Count; y++)
            {
                item = resList[y].ToString();
                items = item.Split('%');
                newList.Add(items[1]);
            }
            for (int y = 0; y < proc_resList.Count; y++)
            {
                item = proc_resList[y].ToString();
                items = item.Split('%');
                proc_newList.Add(items[1]);
            }
            hash.Add("PROC", proc_newList);
            hash.Add("CPT", newList);
            return hash;
        }

        public static ArrayList GetNOMENCLATURE(string nomenID, bool zeroExtFile)
        {
            //NOMENCLATURE:  NOMENCLATURE_ID,SOURCE_VOCABULARY_CD,SOURCE_IDENTIFIER,ACTIVE_IND,END_EFFECTIVE_DT_TM
            ArrayList resList = new ArrayList();
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            nomenID = nomenID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT NOMENCLATURE_ID,SOURCE_VOCABULARY_CD,SOURCE_IDENTIFIER,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.NOMENCLATURE] ");
            sb.Append("WHERE NOMENCLATURE_ID = '" + nomenID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["NOMENCLATURE_ID"].ToString() + "|" + dt.Rows[cnt]["SOURCE_VOCABULARY_CD"].ToString() + "|" + dt.Rows[cnt]["SOURCE_IDENTIFIER"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    resList.Add(result);
                }
                cnt = cnt + 1;
            }
            return resList;
        }

        public static ArrayList GetPROC_PRSNL_RELTN(string procID, bool zeroExtFile)
        {
            //PROC_PRSNL_RELTN:  PROCEDURE_ID,PROC_PRSNL_RELTN_CD,PRSNL_PERSON_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM

            ArrayList resultList = new ArrayList();
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            procID = procID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT PROCEDURE_ID,PROC_PRSNL_RELTN_CD,PRSNL_PERSON_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_PROC_PRSNL_RELTN] ");
            sb.Append("WHERE PROCEDURE_ID = '" + procID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["PROCEDURE_ID"].ToString() + "|" + dt.Rows[cnt]["PROC_PRSNL_RELTN_CD"].ToString() + "|" + dt.Rows[cnt]["PRSNL_PERSON_ID"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    resultList.Add(result);
                }
                cnt = cnt + 1;
            }
            return resultList;
        }

        public static ArrayList GetDIAGNOSIS(string encID, bool zeroExtFile)
        {
            //DIAGNOSIS:  ENCNTR_ID,NOMENCLATURE_ID,DIAGNOSIS_ID,DIAG_DT_TM,DIAG_PRIORITY,PRESENT_ON_ADMIT_CD,DIAG_TYPE_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM
            ArrayList newList = new ArrayList();
            ArrayList resultList = new ArrayList();
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            string item = "";
            string[] items;
            int cnt = 0;
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,NOMENCLATURE_ID,DIAGNOSIS_ID,DIAG_DT_TM,DIAG_PRIORITY,PRESENT_ON_ADMIT_CD,DIAG_TYPE_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_DIAGNOSIS] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    if (dt.Rows[cnt]["DIAG_PRIORITY"].ToString().Trim() != "0" )
                    {
                        if (dt.Rows[cnt]["DIAG_PRIORITY"].ToString().Trim() != "")
                        {
                            result = dt.Rows[cnt]["DIAG_PRIORITY"].ToString().PadLeft(10, '0') + '%' + dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["NOMENCLATURE_ID"].ToString() + "|" + dt.Rows[cnt]["DIAGNOSIS_ID"].ToString() + "|" + dt.Rows[cnt]["DIAG_DT_TM"].ToString() + "|" + dt.Rows[cnt]["DIAG_PRIORITY"].ToString() + "|" + dt.Rows[cnt]["PRESENT_ON_ADMIT_CD"].ToString() + "|" + dt.Rows[cnt]["DIAG_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                            resultList.Add(result);
                        }
                    }
                }
                cnt = cnt + 1;
            }
            resultList.Sort();
            for (int y = 0; y < resultList.Count; y++)
            {
                item = resultList[y].ToString();
                items = item.Split('%');
                newList.Add(items[1]);
            }
            return newList;
        }

        public static ArrayList GetDRG(string encID, bool zeroExtFile)
        {
            //DRG:  ENCNTR_ID,NOMENCLATURE_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM

            ArrayList resultList = new ArrayList();
            ArrayList newList = new ArrayList();
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            string item = "";
            string[] items;
            int cnt = 0;
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,NOMENCLATURE_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM,DRG_PRIORITY ");
            sb.Append("FROM  [ABS_DRG] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    if (dt.Rows[cnt]["DRG_PRIORITY"].ToString().Trim() != "0")
                    {
                        if (dt.Rows[cnt]["DRG_PRIORITY"].ToString().Trim() != "")
                        {
                            result = dt.Rows[cnt]["DRG_PRIORITY"].ToString().PadLeft(10, '0') + '%' + dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["NOMENCLATURE_ID"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                            resultList.Add(result);
                            //break;
                        }
                    }
                }
                cnt = cnt + 1;
            }
            resultList.Sort();
            for(int y=0;y<resultList.Count;y++)
            {
                item = resultList[y].ToString();
                items = item.Split('%');
                newList.Add(items[1]);
            }
            //newList.Reverse();
            return newList;
        }

        public static string GetDRG_EXTENSION(string sourceID, bool zeroExtFile)
        {
            //DRG_EXTENSION: SOURCE_IDENTIFIER,DRG_WEIGHT,ACTIVE_IND,END_EFFECTIVE_DT_TM

            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            sourceID = sourceID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT SOURCE_IDENTIFIER,DRG_WEIGHT,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_DRG_EXTENSION] ");
            sb.Append("WHERE SOURCE_IDENTIFIER = '" + sourceID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["SOURCE_IDENTIFIER"].ToString() + "|" + dt.Rows[cnt]["DRG_WEIGHT"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static string GetPRSNL_SPECIALTY_RELTN(string prsnlID, bool zeroExtFile)
        {
            //PRSNL_SPECIALTY_RELTN:  PRSNL_ID,PRIMARY_IND,SPECIALTY_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM

            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            prsnlID = prsnlID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT PRSNL_ID,PRIMARY_IND,SPECIALTY_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_PRSNL_SPECIALTY_RELTN] ");
            sb.Append("WHERE PRSNL_ID = '" + prsnlID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["PRSNL_ID"].ToString() + "|" + dt.Rows[cnt]["PRIMARY_IND"].ToString() + "|" + dt.Rows[cnt]["SPECIALTY_CD"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static string GetPATIENT_EVENT(string encID, string eventType, bool zeroExtFile)
        {
            //PATIENT_EVENT:  ENCNTR_ID,EVENT_TYPE_CD,EVENT_DT_TM,ACTIVE_IND,END_EFFECTIVE_DT_TM
            //EVENT_TYPE_CD.Trim() == "23290115"
            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            eventType = eventType.Replace(".0000", "");
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,EVENT_TYPE_CD,EVENT_DT_TM,ACTIVE_IND ");
            sb.Append("FROM  [ABS_PATIENT_EVENT] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "' AND EVENT_TYPE_CD = '" + eventType + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                result = dt.Rows[0]["ENCNTR_ID"].ToString() + "|" + dt.Rows[0]["EVENT_TYPE_CD"].ToString() + "|" + dt.Rows[0]["EVENT_DT_TM"].ToString() + "|" + dt.Rows[0]["ACTIVE_IND"].ToString();
                break;
            }
            return result;
        }

        public static string GetENCNTR_MOTHER_CHILD_RELTN(string childEncID, bool zeroExtFile)
        {
            //ENCNTR_MOTHER_CHILD_RELTN:  CHILD_ENCNTR_ID,MOTHER_ENCNTR_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM

            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            childEncID = childEncID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CHILD_ENCNTR_ID,MOTHER_ENCNTR_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_ENCNTR_MOTHER_CHILD_RELTN] ");
            sb.Append("WHERE CHILD_ENCNTR_ID = '" + childEncID + "' AND ACTIVE_IND = '" + activeInd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["CHILD_ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["MOTHER_ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }
        public static string GetADDRESS(string personID, string addrType, bool zeroExtFile)
        {
            //ADDRESS:  PARENT_ENTITY_ID,PARENT_ENTITY_NAME,ADDRESS_TYPE_CD,ZIPCODE,ACTIVE_IND,END_EFFECTIVE_DT_TM

            string result = "";
            string activeInd = "1";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            personID = personID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            addrType = addrType.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT PARENT_ENTITY_ID,PARENT_ENTITY_NAME,ADDRESS_TYPE_CD,ZIPCODE,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.ADDRESS] ");
            sb.Append("WHERE PARENT_ENTITY_ID = '" + personID + "' AND ACTIVE_IND = '" + activeInd + "' AND PARENT_ENTITY_NAME = '" + "PERSON" + "' AND ADDRESS_TYPE_CD = '" + addrType + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["PARENT_ENTITY_ID"].ToString() + "|" + dt.Rows[cnt]["PARENT_ENTITY_NAME"].ToString() + "|" + dt.Rows[cnt]["ADDRESS_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ZIPCODE"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static string GetENCNTR_ALIAS(string encID, string aliasTypeCd, bool zeroExtFile)
        {
            //ENCNTR_ALIAS:  ENCNTR_ID,ENCNTR_ALIAS_TYPE_CD,ALIAS,ACTIVE_IND,END_EFFECTIVE_DT_TM
            int cnt = 0;
            int edate = 0;
            string today = DateTime.Today.ToString("yyyyMMdd");
            if (encID == "102927541")
                encID = encID;

            string result = "";
            string activeInd = "1";
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            aliasTypeCd = aliasTypeCd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ENCNTR_ID,ENCNTR_ALIAS_TYPE_CD,ALIAS,ACTIVE_IND,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.ENCNTR_ALIAS] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "' AND ENCNTR_ALIAS_TYPE_CD = '" + aliasTypeCd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["ENCNTR_ID"].ToString() + "|" + dt.Rows[cnt]["ENCNTR_ALIAS_TYPE_CD"].ToString() + "|" + dt.Rows[cnt]["ALIAS"].ToString() + "|" + dt.Rows[cnt]["ACTIVE_IND"].ToString() + "|" + dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static string GetCPTMod(string procID,  bool zeroExtFile)
        {
            //ENCNTR_ALIAS:  ENCNTR_ID,ENCNTR_ALIAS_TYPE_CD,ALIAS,ACTIVE_IND,END_EFFECTIVE_DT_TM
            int cnt = 0;
            int edate = 0;
            string today = DateTime.Today.ToString("yyyyMMdd");
            
            string result = "";
            string activeInd = "1";
            
            procID = procID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT source_identifier,end_effective_dt_tm ");
            sb.Append("FROM  vProcModNomen ");
            sb.Append("WHERE parent_entity_id = '" + procID + "' AND ACTIVE_IND = '" + activeInd + "' AND parent_entity_name = '" + "PROCEDURE" + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = "";
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["END_EFFECTIVE_DT_TM"].ToString()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["source_identifier"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }


        public static string GetPRSNL_ALIAS(string prsnlID, bool zeroExtFile)
        {
            //ENCNTR_ALIAS:  ENCNTR_ID,ENCNTR_ALIAS_TYPE_CD,ALIAS,ACTIVE_IND,END_EFFECTIVE_DT_TM

            string result = "";
            string activeInd = "1";
            string aliasTypeCd = "26026547";
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            
            prsnlID = prsnlID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");
            aliasTypeCd = aliasTypeCd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ALIAS,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.PRSNL_ALIAS] ");
            sb.Append("WHERE PERSON_ID = '" + prsnlID + "' AND ACTIVE_IND = '" + activeInd + "' AND alias_pool_cd = '" + aliasTypeCd + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[0]["ALIAS"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }
        public static Hashtable GetExcludedUsers()
        {
            int cnt = 0;
            Hashtable result = new Hashtable();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT person_id ");
            sb.Append("FROM  [MPIExclusion] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                //result.Add(dt.Rows[cnt]["person_id"].ToString(), "");
                result.Add(row[0].ToString(), "");
                cnt = cnt + 1;
            }
            return result;
        }
        public static List<string> GetDistinctEncounterIds(List<string> organizations)
        {
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT DISTINCT encntr_id ");
            sb.Append("FROM cerner.ENCOUNTER ");
            sb.Append("WHERE active_ind = '1' ");
            sb.Append("AND (encntr_type_cd <> '22282402' ");   //omit clinic
            sb.Append("AND encntr_type_cd <> '20058643' ");    //omit history
            sb.Append("AND encntr_type_cd <> '309313' ");      //omit preAdmit
            sb.Append("AND encntr_type_cd <> '275211155' ");   //omit preClient
            sb.Append("AND encntr_type_cd <> '40161279' ");    //omit PreRecurring
            sb.Append("AND encntr_type_cd <> '4189852' ");     //omit PreReg
            sb.Append("AND encntr_type_cd <> '33151117') ");   //omit ZZPresched 

            StringBuilder sbOrgs = new StringBuilder();
            if (organizations.Count > 0)
            {
                sbOrgs.Append("AND (");
                cnt = 0;
                foreach (string org in organizations)
                {
                    cnt++;
                    sbOrgs.Append(" Organization_id = '" + org + "' ");
                    if (cnt < organizations.Count)
                        sbOrgs.Append(" OR ");
                }
                sbOrgs.Append(") ");
                sb.Append(sbOrgs.ToString());
            }
            sb.Append("ORDER BY encntr_id ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<string> personIds = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                personIds.Add(row[0].ToString());
            }
            return personIds;
        }
        public static List<string> GetOrganizationsToProcess(string hcis)
        {
            string today = DateTime.Today.ToString("yyyyMMdd");
            int cnt = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  organization_id, hcis, facility, mrnPrefix, acctPrefix, cernerPrefix ");
            sb.Append("FROM  MPIOrganization ");
            sb.Append("WHERE hcis = '" + hcis + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<string> orgs = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                //orgs.Add(row["organization_id"].ToString() + ".0000");
                orgs.Add(row["organization_id"].ToString());
            }
            return orgs;
        }
        public static Hashtable GetCLINICAL_EVENT(string encID, bool zeroExtFile)
        {
            string activeInd = "1";
            int cnt = 0;
            Hashtable hash = new Hashtable();
            
            encID = encID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT EVENT_CD,RESULT_VAL ");
            sb.Append("FROM  [ABS_CLINICAL_EVENT] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND EVENT_CD in (" + "'17022118','17022130'" + ")");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            string apgar1 = "";
            string apgar5 = "";
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Rows[cnt]["EVENT_CD"].ToString() == "17022118")
                    apgar1 = dt.Rows[cnt]["RESULT_VAL"].ToString();
                if (dt.Rows[cnt]["EVENT_CD"].ToString() == "17022130")
                    apgar5 = dt.Rows[cnt]["RESULT_VAL"].ToString();
                cnt = cnt + 1;
            }

            hash.Add("apgar1", apgar1);
            hash.Add("apgar5", apgar5);
            return hash;
        }
        public static string GetPersonSuffix(string personID, bool zeroExtFile )
        {
            int cnt = 0;
            string today = DateTime.Today.ToString("yyyyMMdd");
            string result = "";
            string activeInd = "1";

            personID = personID.Replace(".0000", "");
            activeInd = activeInd.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT NAME_SUFFIX,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [cerner.PERSON_NAME] ");
            sb.Append("WHERE PERSON_ID = '" + personID + "' AND ACTIVE_IND = '" + activeInd + "' ");


            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["NAME_SUFFIX"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }
        public static string GetCoding(string encID)
        {
            int cnt = 0;
            string today = DateTime.Today.ToString("yyyyMMdd");
            string result = "";
            string activeInd = "1";

            encID = encID.Replace(".0000", "");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT completed_dt_tm,END_EFFECTIVE_DT_TM ");
            sb.Append("FROM  [ABS_CODING] ");
            sb.Append("WHERE ENCNTR_ID = '" + encID + "' AND ACTIVE_IND = '" + activeInd + "' ");


            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            //result = GlobalResult;
            foreach (DataRow row in dt.Rows)
            {
                if (GetEffDt(dt.Rows[cnt]["end_effective_dt_tm"].ToString().Trim()) > int.Parse(today))
                {
                    result = dt.Rows[cnt]["completed_dt_tm"].ToString();
                    break;
                }
                cnt = cnt + 1;
            }
            return result;
        }

        public static List<string> GetPersonEncounters(string personId, List<string> organizations)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT encntr_id, Person_Id, Encntr_Type_Cd, Encntr_type_class_cd, Inpatient_Admit_Dt_Tm, Reg_Dt_Tm, ");
            sb.Append("Disch_Dt_tm, Loc_Nurse_Unit_Cd, Reason_For_Visit, Disch_Disposition_Cd, Active_Ind, Organization_Id ");
            sb.Append("FROM cerner.ENCOUNTER ");
            sb.Append("WHERE Person_Id = '" + personId + "' AND active_ind = '1' ");
            sb.Append("AND (encntr_type_cd <> '22282402' ");   //omit clinic
            sb.Append("AND encntr_type_cd <> '20058643' ");    //omit history
            sb.Append("AND encntr_type_cd <> '309313' ");      //omit preAdmit
            sb.Append("AND encntr_type_cd <> '275211155' ");   //omit preClient
            sb.Append("AND encntr_type_cd <> '40161279' ");    //omit PreRecurring
            sb.Append("AND encntr_type_cd <> '4189852' ");     //omit PreReg
            sb.Append("AND encntr_type_cd <> '33151117') ");   //omit ZZPresched 

            StringBuilder sbOrgs = new StringBuilder();
            if (organizations.Count > 0)
            {
                sbOrgs.Append("AND (");
                int cnt = 0;
                foreach (string org in organizations)
                {
                    cnt++;
                    sbOrgs.Append(" Organization_id = '" + org + "'");
                    if (cnt < organizations.Count)
                        sbOrgs.Append(" OR ");
                }
                sbOrgs.Append(") ");
                sb.Append(sbOrgs.ToString());
            }


            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<string> encntrIds = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                encntrIds.Add(row["encntr_id"].ToString());
            }
            return encntrIds;
        }

        //MApping-------------------------------------------------------------------------------------------------------------------

        public static Hashtable GetCERNER_DISCHARGE_DISPOSITION()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_DISCHARGE_DISPOSITION] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("DD_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("DD_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_GENDER()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_GENDER] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("SX_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("SX_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_LOCATION()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_LOCATION] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("LC_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("LC_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_MARITALSTATUS()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_MARITALSTATUS] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("MS_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("MS_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_PROVIDER_MAP()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Facility,ProviderNPI,MTMnemonic ");
            sb.Append("FROM  [CERNER_PROVIDER_MAP] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("DR_" + dt.Rows[cnt]["Facility"].ToString().Trim() + "_" + dt.Rows[cnt]["ProviderNPI"].ToString().Trim()) == false)
                {
                    hash.Add("DR_" + dt.Rows[cnt]["Facility"].ToString().Trim() + "_" + dt.Rows[cnt]["ProviderNPI"].ToString().Trim(), dt.Rows[cnt]["MTMnemonic"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_RACE()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_RACE] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("RC_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("RC_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_REGTYPE()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_REGTYPE] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("PS_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("PS_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }
        public static Hashtable GetCERNER_STATE()
        {
            Hashtable hash = new Hashtable();
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CernerCode,MeditechCode ");
            sb.Append("FROM  [CERNER_STATE] ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                if (hash.ContainsKey("PS_" + dt.Rows[cnt]["CernerCode"].ToString().Trim()) == false)
                {
                    hash.Add("ST_" + dt.Rows[cnt]["CernerCode"].ToString().Trim(), dt.Rows[cnt]["MeditechCode"].ToString().Trim());
                }
                cnt = cnt + 1;
            }

            return hash;
        }

        public static string GetMap(string tableName, string cernerCode, string defaultValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MeditechCode FROM " + tableName + " ");
            sb.Append("WHERE CernerCode = '" + cernerCode + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            string result = defaultValue;
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            if (result == "0")
                result = string.Empty;
            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private static int GetEffDt(string dt)
        {
            string dtnum = Huron.HuronRoutines.FormatDate_YYYYMMDD(dt);
            if (Huron.HuronRoutines.IsNumeric(dtnum) == true)
                return int.Parse(dtnum);
            else
                return 0;
        }

        public static DateTime? GetCernerDate(string dateValue, string hcis)
        {
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
            return dt2;
        }
        public static string GetHCISTimeZone(string hcis)
        {
            string result = string.Empty;
            if (hcis == "SHAZ" || hcis == "SHUT")
                result = "US Mountain Standard Time";
            else
                result = "Central Standard Time";

            return result;
        }
        public static DateTime? GetCernerDate(string dateValue)
        {
            DateTime? result = null;
            string item;
            string AMPM = "";
            string[] items;
            if (dateValue.Trim().Length > 0 && dateValue != "null")
            {
                if (dateValue.Contains("AM") == true || dateValue.Contains("PM") == true)
                {
                    DateTime dt = DateTime.Parse(dateValue);
                    if (dateValue.Contains("AM") == true)
                        AMPM = "AM";
                    else if (dateValue.Contains("PM") == true)
                        AMPM = "PM";
                    item = dt.Month.ToString().PadLeft(2, '0') + "/" + dt.Day.ToString().PadLeft(2, '0') + "/" + dt.Year.ToString() + " " + dt.Hour.ToString().PadLeft(2, '0') + ":" + dt.Minute.ToString().PadLeft(2, '0') + ":" + dt.Second.ToString().PadLeft(2, '0') + " " + AMPM;

                    result = DateTime.ParseExact(item, "MM/dd/yyyy HH:mm:ss tt", CultureInfo.CurrentCulture); //DateTime.ParseExact(dateValue, "M/d/yyyy HH:mm:ss tt", CultureInfo.CurrentCulture);
                }
                else if (dateValue.Contains(":") == false)
                    result = DateTime.ParseExact(dateValue, "M/d/yyyy", CultureInfo.CurrentCulture);
                else
                    result = DateTime.ParseExact(dateValue, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture);
            }
            return result;
        }
        public static string GetCernerDate2(string dateValue, string hcis)
        {
            string newdt = "";
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
            {
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
                if (hcis == "SHAZ" || hcis == "SHUT")
                {
                    if (dt2.Value.Hour > 22)
                        newdt = newdt;
                    DateTime dt3 = (DateTime)dt2;
                    //dt3 = dt3.AddHours(3);
                    dt2 = dt3;
                }
                newdt = dt2.Value.Year.ToString() + dt2.Value.Month.ToString().PadLeft(2, '0').Trim() + dt2.Value.Day.ToString().PadLeft(2, '0').Trim();
            }
            return newdt;
        }
        public static string GetCernerTime(string dateValue, string hcis)
        {
            string newdt = "";
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
            {
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
                if (hcis == "SHAZ" || hcis == "SHUT")
                {
                    if (dt2.Value.Hour > 22)
                        newdt = newdt;
                    DateTime dt3 = (DateTime)dt2;
                    //dt3 = dt3.AddHours(3);
                    dt2 = dt3;
                }
                newdt = dt2.Value.Hour.ToString().PadLeft(2, '0').Trim() + dt2.Value.Minute.ToString().PadLeft(2, '0').Trim();
            }
            return newdt;
        }
    }
}