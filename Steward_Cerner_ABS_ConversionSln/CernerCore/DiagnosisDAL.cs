using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WestBARConversion.CernerCore
{
    public class DiagnosisDAL
    {
        public static List<Diagnosis> GetEncounterAdmitDxs(string encounterId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Select encntr_id, nomenclature_id, diag_type_cd, diag_priority, beg_effective_dt_tm, ");
            sb.Append("active_ind, present_on_admit_cd ");
            sb.Append("FROM DIAGNOSIS ");
            sb.Append("where encntr_Id = '" + encounterId + "' and active_ind = '1' and diag_type_cd = '87' ");
            sb.Append("order by CONVERT(int, diag_priority) ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<Diagnosis> dxs = new List<Diagnosis>();
            foreach(DataRow row in dt.Rows)
            {
                Diagnosis dx = LoadDiagnosis(row);
                if (dx != null)
                {
                    dxs.Add(dx);
                }

            }
            return dxs;
        }

        public static List<Diagnosis> GetEncounterFinalDxs(string encounterId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Select encntr_id, nomenclature_id, diag_type_cd, diag_priority, beg_effective_dt_tm, ");
            sb.Append("active_ind, present_on_admit_cd ");
            sb.Append("FROM DIAGNOSIS ");
            sb.Append("where encntr_Id = '" + encounterId + "' and active_ind = '1' and diag_type_cd = '89' ");
            sb.Append("order by CONVERT(int, diag_priority) ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<Diagnosis> dxs = new List<Diagnosis>();
            foreach (DataRow row in dt.Rows)
            {
                Diagnosis dx = LoadDiagnosis(row);
                if (dx != null)
                {
                    dxs.Add(dx);
                }

            }
            return dxs;
        }

        private static Diagnosis LoadDiagnosis(DataRow row)
        {
            string diagCode = NomenclatureDAL.GetNomenclature_SourceIdentifier(row["nomenclature_id"].ToString());
            string poa = CodeValueDAL.GetCodeValueDisplay(row["present_on_admit_cd"].ToString() + ".0000");
            if (poa == "0")
                poa = string.Empty;

            Diagnosis dx = new Diagnosis();
            dx.DxCode = diagCode;
            dx.GrouperVersion = string.Empty;
            dx.POA = poa;
            return dx;
        }
    }
}