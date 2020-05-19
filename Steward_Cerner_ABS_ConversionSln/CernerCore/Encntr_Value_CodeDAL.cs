using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WestBARConversion.CernerModel;

namespace WestBARConversion.CernerCore
{
    public class Encntr_Value_CodeDAL
    {
        public static List<Value_Code> GetEncounterValueCodes(string encounterId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select value_cd, amount ");
            sb.Append("FROM ENCNTR_VALUE_CODE ");
            sb.Append("where encntr_Id = '" + encounterId.Replace(".0000", "") + "' and active_ind = '1' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<Value_Code> codes = new List<Value_Code>();
            foreach (DataRow row in dt.Rows)
            {
                Value_Code code = LoadValueCode(row);
                if (code != null)
                    codes.Add(code);

            }
            return codes;
        }

        private static Value_Code LoadValueCode(DataRow row)
        {
            Value_Code code = new Value_Code();
            code.ValueCode = row["value_cd"].ToString();
            string amt = row["amount"].ToString();
            if (amt.Trim().Length > 0)
                code.ValueAmount = Convert.ToDecimal(amt);
            return code;
        }
    }
}
