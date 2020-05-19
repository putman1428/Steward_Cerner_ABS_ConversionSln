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
    public class TransLogDAL
    {
        public static TransLog GetTransLog(string activity_Id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  activity_id, trans_alias_id, trans_type_cd, trans_reason_cd, trans_type_sub_cd ");
            sb.Append("FROM  TransLog ");
            sb.Append("WHERE activity_id = '" + activity_Id + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            TransLog transLog = null;

            if (dt.Rows.Count > 0)
                transLog = LoadTransLog(dt.Rows[0]);
            return transLog;
        }

        private static TransLog LoadTransLog(DataRow row)
        {
            TransLog transLog = new TransLog();
            transLog.Activity_Id = row["activity_id"].ToString();
            transLog.Trans_Alias_Id = row["trans_alias_id"].ToString();
            transLog.Trans_Reason_Cd = row["trans_Reason_Cd"].ToString();
            transLog.Trans_Type_Cd= row["trans_Type_Cd"].ToString();
            transLog.Trans_Type_Sub_Cd = row["trans_Type_Sub_Cd"].ToString();
            return transLog;
        }
    }
}
