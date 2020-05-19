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
    public class Pft_Trans_AliasDAL
    {
        public static string GetTransAlias(string aliasID)
        {
            string returnVal = "";
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  pft_trans_alias ");
            sb.Append("FROM  PFT_TRANS_ALIAS ");
            sb.Append("WHERE pft_trans_alias_id = '" + aliasID + "' ");
            sb.Append("AND active_ind = '1' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            if(dt.Rows.Count > 0)
                returnVal = dt.Rows[0][0].ToString();
            return returnVal;
        }


    }
}
