using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WestBARConversion.CernerCore
{
    public class Encntr_Condition_CodeDAL
    {
        public static List<string> GetConditionCodes(string encounterId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select condition_cd from Encntr_Condition_Code ");
            sb.Append("where encntr_Id = '" + encounterId.Replace(".0000","") + "' and active_ind = '1' ");
            sb.Append("order by sequence  ");
            
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<string> condCodes = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string codes = row["condition_cd"].ToString();
                for(int i=0;i<codes.Length;i=i+2)
                {
                    string code = codes.Substring(i, 2);
                    condCodes.Add(code);
                }

            }
            return condCodes;
        }
    }
}

