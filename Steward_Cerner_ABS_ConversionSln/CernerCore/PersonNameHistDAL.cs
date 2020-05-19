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
    public class PersonNameHistDAL
    {
        public static List<Person_Name_Hist> GetPersonNameHist(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT pn.name_full name_full, pn.name_type_cd name_type_cd, cv.display display, ");
            sb.Append("pn.name_last, pn.name_first, pn.name_middle ");
            sb.Append("FROM  PERSON_NAME_HIST pn ");
            sb.Append("JOIN CODE_VALUE cv on pn.name_type_cd = cv.code_value ");
            sb.Append("WHERE pn.person_id = '" + personId + "' ");
            sb.Append("AND pn.active_ind = '1.0000' ");
            //sb.Append("AND pn.end_effective_dt_tm > '"+ today + "' ");


            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            List<Person_Name_Hist> names = new List<Person_Name_Hist>();
            foreach (DataRow row in dt.Rows)
            {
                Person_Name_Hist name = LoadName(row);
                names.Add(name);
            }
            return names;
        }

        private static Person_Name_Hist LoadName(DataRow row)
        {
            Person_Name_Hist name = new Person_Name_Hist();
            name.Name_Full = row["name_full"].ToString();
            name.Name_Type_Cd = row["display"].ToString();
            name.Name_Last = row["name_last"].ToString();
            name.Name_First = row["name_first"].ToString();
            name.Name_Middle = row["name_middle"].ToString();
            return name;
        }
    }
}
