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
    public class Health_PlanDAL
    {
        public static string HealthPlanName(string healthPlanID)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  Plan_Name ");
            sb.Append("FROM  Health_Plan ");
            sb.Append("WHERE Health_Plan_Id = '" + healthPlanID.Replace(".0000", "") + "' ");
            sb.Append("AND active_ind = '1' ");
            //sb.Append("AND end_effective_dt_tm > '" + today + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            string result = string.Empty;
            if (dt.Rows.Count > 0)
            {
                result = dt.Rows[0]["Plan_Name"].ToString();
            }
            return result;
        }
    }
}