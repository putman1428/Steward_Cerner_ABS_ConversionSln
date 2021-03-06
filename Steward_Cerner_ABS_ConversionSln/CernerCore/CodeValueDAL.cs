﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WestBARConversion.CernerCore
{
    public class CodeValueDAL
    {
        public static string GetCodeValueDisplay(string codeValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Display FROM CODE_VALUE ");
            sb.Append("WHERE Code_Value = '" + codeValue + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            string result = string.Empty;
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            return result;
        }

        public static string GetCodeValueDisplay_Key(string codeValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Display_Key FROM CODE_VALUE ");
            sb.Append("WHERE Code_Value = '" + codeValue + "'");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            string result = string.Empty;
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            return result;
        }
    }
}
