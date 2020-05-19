using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WestBARConversion.CernerModel;

namespace WestBARConversion.CernerCore
{
    public class Encntr_Occurrence_CodeDAL
    {
        public static List<Occurrence_Code> GetOccurrence_Codes(string encounterId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select occurrence_cd, occurrence_dt_tm ");
            sb.Append("FROM ENCNTR_OCCURRENCE_CODE ");
            sb.Append("where encntr_Id = '" + encounterId.Replace(".0000", "") + "' and active_ind = '1' ");
            //sb.Append("order by CONVERT(int, diag_priority) ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<Occurrence_Code> codes = new List<Occurrence_Code>();
            foreach (DataRow row in dt.Rows)
            {
                Occurrence_Code code = LoadOccurrenceCodes(row);
                if (code != null)
                    codes.Add(code);

            }
            return codes;
        }

        private static Occurrence_Code LoadOccurrenceCodes(DataRow row)
        {
            Occurrence_Code code = new Occurrence_Code();
            code.OccurrenceCode = row["occurrence_cd"].ToString();
            code.OccurrenceDate = CernerCommon.ConvertDateString(row["occurrence_dt_tm"].ToString());
            return code;
        }
    }
}