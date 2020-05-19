using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestBARConversion.CernerModel;

namespace WestBARConversion.CernerCore
{
    public class CodingDAL
    {
        private static string today = DateTime.Today.ToString("yyyy-MM-dd");
        public static string GetCoding(string encounter_id, string cSys)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT completed_dt_tm ");
            sb.Append("FROM CODING ");
            sb.Append("WHERE encntr_id = '" + encounter_id + "' AND cSys = '" + cSys.Trim() + "'");
            //sb.Append("AND end_effective_dt_tm > '" + today + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            
            return result;
        }
      
    }
}