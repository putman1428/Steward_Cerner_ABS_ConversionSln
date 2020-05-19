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
    public class PersonPersonReltDAL
    {

        public static List<Person> GetNOKs(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            if (personId.Contains(".0000") == false)
                personId = personId + ".0000";

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  related_person_id, related_person_reltn_cd ");
            sb.Append("FROM  PERSON_PERSON_RELTN ");
            sb.Append("WHERE Person_Id = '" + personId + "' ");
            sb.Append("AND person_reltn_type_cd = '1159.0000' ");
            sb.Append("AND active_ind = '1.0000' ");
            //sb.Append("AND end_effective_dt_tm > '" + today + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<Person> noks = LoadPersons(dt);
            return noks;
        }

        public static Person GetMostRecentNOK(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 related_person_id, related_person_reltn_cd ");
            sb.Append("FROM  PERSON_PERSON_RELTN ");
            sb.Append("WHERE Person_Id = '" + personId + "' ");
            sb.Append("AND person_reltn_type_cd = '1159.0000' ");
            sb.Append("AND active_ind = '1.0000' ");
            sb.Append("AND end_effective_dt_tm > '" + today + "' ");
            sb.Append("ORDER BY beg_effective_dt_tm DESC");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            Person nok = null;
            if (dt.Rows.Count > 0)
                nok = LoadPersons(dt.Rows[0]);
            return nok;
        }


        public static List<Person> GetPTNs(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  related_person_id, related_person_reltn_cd ");
            sb.Append("FROM  PERSON_PERSON_RELTN ");
            sb.Append("WHERE Person_Id = '" + personId + "' ");
            sb.Append("AND person_reltn_type_cd = '1152.0000' ");
            sb.Append("AND active_ind = '1.0000' ");
            sb.Append("AND end_effective_dt_tm > '" + today + "' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<Person> noks = LoadPersons(dt);
            return noks;
        }
        public static Person GetMostRecentPTN(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 related_person_id, related_person_reltn_cd ");
            sb.Append("FROM  PERSON_PERSON_RELTN ");
            sb.Append("WHERE Person_Id = '" + personId + "' ");
            sb.Append("AND person_reltn_type_cd = '1152.0000' ");
            sb.Append("AND active_ind = '1.0000' ");
            sb.Append("AND end_effective_dt_tm > '" + today + "' ");
            sb.Append("ORDER BY beg_effective_dt_tm DESC" );

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            Person ptn = null;
            if (dt.Rows.Count > 0)
                ptn = LoadPersons(dt.Rows[0]);
            return ptn;
        }

        public static string GetRelationship(string personId)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            string item = "";
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1  related_person_reltn_cd ");
            sb.Append("FROM  PERSON_PERSON_RELTN ");
            sb.Append("WHERE Person_Id = '" + personId + "' ");
            sb.Append("AND person_reltn_type_cd = '1158.0000' ");
            sb.Append("AND active_ind = '1.0000' ");
            sb.Append("AND end_effective_dt_tm > '" + today + "' ");
            sb.Append("ORDER BY beg_effective_dt_tm DESC");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
                item = dt.Rows[0].ToString();
            return item;
        }
        private static List<Person> LoadPersons(DataTable dt)
        {
            List<Person> persons = new List<Person>();
            foreach(DataRow row in dt.Rows)
            {
                string personId = row["related_person_id"].ToString();
                string relationship = CernerCommon.StripDecimalsForMap(row["related_person_reltn_cd"].ToString());

                Person person = PersonDAL.GetPerson(personId);
                if (person != null)
                {
                    person.Cerner_Relationship = CodeValueDAL.GetCodeValueDisplay(relationship + ".0000");
                    person.RelationShip = CernerMapDAL.GetMap("CERNER_RELATIONSHIP", relationship, relationship);
                    persons.Add(person);
                }
            }
            return persons;
        }

        private static Person LoadPersons(DataRow row)
        {
            string personId = row["related_person_id"].ToString();
            string relationship = CernerCommon.StripDecimalsForMap(row["related_person_reltn_cd"].ToString());

            Person person = PersonDAL.GetPerson(personId);
            if (person != null)
            {
                person.Cerner_Relationship = CodeValueDAL.GetCodeValueDisplay(relationship + ".0000");
                person.RelationShip = CernerMapDAL.GetMap("CERNER_RELATIONSHIP", relationship, relationship);
            }
            return person;
        }
       
    }
}
