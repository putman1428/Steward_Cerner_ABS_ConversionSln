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
    public class ChargeDAL
    {
        public static List<Charge> GetCharges(string encounter_id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  charge_item_id, charge_description, item_extended_price, posted_dt_tm, service_dt_tm, charge_type_cd, item_quantity, payor_id, perf_phys_id, ord_phys_id, posted_id  ");
            sb.Append("FROM  CHARGE ");
            sb.Append("WHERE encntr_id = '" + encounter_id + "' AND process_flg = '100' ");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            List<Charge> charges = new List<Charge>();
            foreach (DataRow row in dt.Rows)
            {
                Charge charge = LoadCharge(row);
                charges.Add(charge);
            }
            return charges;
        }
        private static Charge LoadCharge(DataRow row)
        {
            Charge charge = new Charge();
            charge.Charge_Description = row["charge_description"].ToString();
            charge.Charge_Item_Id = row["charge_item_id"].ToString();
            charge.Item_Extended_Price = row["item_extended_price"].ToString();
            charge.Posted_Dt_Tm = row["posted_dt_tm"].ToString();
            charge.Service_Dt_Tm = row["service_dt_tm"].ToString();
            charge.Charge_Type_Cd = row["charge_type_cd"].ToString();
            charge.Perf_Phy_Id = row["perf_phys_id"].ToString();
            charge.Payor_Id = row["payor_id"].ToString();
            charge.Ord_Phy_Id = row["ord_phys_id"].ToString();
            charge.Quantity = row["item_quantity"].ToString();
            charge.User_Id = row["posted_id"].ToString();
            return charge;
        }
    }
}