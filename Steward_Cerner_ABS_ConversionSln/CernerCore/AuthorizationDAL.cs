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
    public class AuthorizationDAL
    {
        public static Authorization GetAuthorizations(string encounter_id, string health_plan_id, int authNbr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  auth_nbr, CERT_STATUS_CD, [AUTH_OBTAINED_DT_TM], AUTH_EXPIRE_DT_TM ");
            sb.Append("FROM  [AUTHORIZATION] ");
            sb.Append("WHERE encntr_id = '" + encounter_id + "' AND health_plan_id = '" + health_plan_id + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            List<Authorization> auths = new List<Authorization>();
            foreach (DataRow row in dt.Rows)
            {
                Authorization auth = LoadAuthorization(row);
                auths.Add(auth);
            }
            Authorization authOut = new Authorization();
            if(authNbr < auths.Count)
                authOut = auths[authNbr];
            return authOut;
        }
        private static Authorization LoadAuthorization(DataRow row)
        {
            Authorization auth = new Authorization();
            auth.Authorization_Nbr = row["auth_nbr"].ToString();
            auth.Authorization_EffDate = row["AUTH_OBTAINED_DT_TM"].ToString();
            auth.Authorization_ExpDate = row["AUTH_EXPIRE_DT_TM"].ToString();
            auth.Authorization_Status = row["CERT_STATUS_CD"].ToString();
            
            return auth;
        }
    }
}