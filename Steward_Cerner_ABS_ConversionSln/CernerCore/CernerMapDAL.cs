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
    public class CernerMapDAL
    {
        public static string GetMap(string tableName, string cernerCode, string defaultValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MeditechCode FROM " + tableName + " ");
            sb.Append("WHERE CernerCode = '" + cernerCode + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            string result = defaultValue;
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            return result;
        }
    }
}
