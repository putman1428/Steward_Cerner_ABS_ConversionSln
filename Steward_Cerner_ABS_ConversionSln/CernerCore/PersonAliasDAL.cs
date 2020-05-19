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
    public class PersonAliasDAL
    {
        public static string GetPersonAlias_SSN(string personId)
        {
            string currentDate = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = GetPersonAlias(personId, "18.0000", "683997.0000", "1.0000", currentDate);
            string result = string.Empty;
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            return result;
        }
        public static List<Person_Alias> GetPersonAliasesExceptSSN(string personId)
        {
            if (personId.Contains(".0000") == false)
                personId = personId + ".0000";
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  person_alias_type_cd, alias_pool_Cd, alias ");
            sb.Append("FROM  PERSON_ALIAS ");
            sb.Append("WHERE person_id = '" + personId + "' ");
            sb.Append("AND person_alias_type_cd  <> '18.0000' ");
            sb.Append("AND active_ind = '1.0000' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            List<Person_Alias> aliases = new List<Person_Alias>();
            foreach(DataRow row in dt.Rows)
            {
                Person_Alias pa = LoadPersonAlias(row);
                aliases.Add(pa);
            }
            return aliases;
        }


        private static Person_Alias LoadPersonAlias(DataRow row)
        {
            Person_Alias alias = new Person_Alias();
            alias.Aleas_Pool = CodeValueDAL.GetCodeValueDisplay(row["alias_pool_Cd"].ToString());
            alias.Alias_Type = CodeValueDAL.GetCodeValueDisplay(row["person_alias_type_cd"].ToString());
            alias.Alias = row["alias"].ToString();

            return alias;
        }
        private static DataTable GetPersonAlias(string personId, string aliasTypeCd, string aliasPoolCd, string activeInd, string currentDate)
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand("proc_get_person_alias", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                //exec proc_get_person_Alias @PersonId='12512084.0000', @Alias_Type_Code='18.0000', @Alias_pool_cd = '683997.0000', @Active_Ind='1.0000', @CurrrentDate = '2019-11-25'
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonId", personId);
                cmd.Parameters.AddWithValue("@Alias_Type_Code", aliasTypeCd);
                cmd.Parameters.AddWithValue("@Alias_pool_cd", aliasPoolCd);
                cmd.Parameters.AddWithValue("@Active_Ind", activeInd);
                cmd.Parameters.AddWithValue("@CurrrentDate", currentDate);

                da.Fill(dt);
            }
            return dt;

        }
    }
}
