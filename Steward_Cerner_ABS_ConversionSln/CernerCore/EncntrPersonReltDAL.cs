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
    public class EncntrPersonReltDAL
    {
        public static string GetInsuredReltn(string encntr_id)
        {
            string result = "";
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  related_person_reltn_cd ");
            sb.Append("FROM ENCNTR_PERSON_RELTN ");
            sb.Append("WHERE encntr_Id = '" + encntr_id.Replace(".0000", "") + "' ");
            sb.Append("AND person_reltn_type_cd = '1158' ");
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

            foreach (DataRow row in dt.Rows)
            {
                result = row["related_person_reltn_cd"].ToString().Trim();
            }
            return result;
        }
    }
}
