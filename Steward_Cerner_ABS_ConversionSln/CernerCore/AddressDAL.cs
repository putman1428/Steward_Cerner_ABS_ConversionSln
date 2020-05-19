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
    public class AddressDAL
    {
        public static Address GetHomeAddress(string personId)
        {
            DataTable dt = GetAddress(personId, "756.0000");
            Address address = null;
            if (dt.Rows.Count > 0)
                address = LoadAddress(dt.Rows[0]);
            return address;
        }
        public static Address GetEmailAddress(string personId)
        {
            DataTable dt = GetAddress(personId, "755.0000");
            Address address = null;
            if (dt.Rows.Count > 0)
                address = LoadAddress(dt.Rows[0]);
            return address;
        }
        public static Address GetAddress_Org(string orgId)
        {
            DataTable dt = GetAddress_Org(orgId, "754.0000");
            Address address = null;
            if (dt.Rows.Count > 0)
                address = LoadAddress(dt.Rows[0]);
            return address;
        }
        private static DataTable GetAddress(string personId, string addressTypeCd)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  street_addr, street_addr2, city, state_cd, zipcode, country_cd ");
            sb.Append("FROM  ADDRESS ");
            sb.Append("WHERE parent_entity_id = '" + personId + "' ");
            sb.Append("AND parent_entity_name = 'PERSON' ");
            sb.Append("AND Address_type_cd = '" + addressTypeCd + "' ");
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
            return dt;
        }
        private static DataTable GetAddress_Org(string orgId, string addressTypeCd)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  street_addr, street_addr2, city, state_cd, zipcode, country_cd ");
            sb.Append("FROM  ADDRESS ");
            sb.Append("WHERE parent_entity_id = '" + orgId + "' ");
            sb.Append("AND parent_entity_name = 'ORGANIZATION' ");
            sb.Append("AND Address_type_cd = '" + addressTypeCd + "' ");
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
            return dt;
        }
        private static Address LoadAddress(DataRow row)
        {
            Address address = new Address();
            address.Street_Addr = row["street_addr"].ToString();
            address.Street_Addr2 = row["street_addr2"].ToString();
            address.Street_Addr2 = row["street_addr2"].ToString();
            address.City = row["city"].ToString();
            address.Country = row["country_cd"].ToString();

            string stateCd = CernerCommon.StripDecimalsForMap(row["state_cd"].ToString());
            address.State_Cd = CernerMapDAL.GetMap("CERNER_STATE", stateCd, stateCd);
            address.ZipCode = row["zipcode"].ToString();
            return address;
        }
    }
}
