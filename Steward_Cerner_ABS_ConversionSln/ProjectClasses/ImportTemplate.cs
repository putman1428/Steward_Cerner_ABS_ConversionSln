using System;
using System.IO;
using System.Data;
using System.Linq;
namespace ABS_Conversion
{
    public class ImportTemplate
    {
        public static DataTable IndexTable()
        {
            DataTable tbl = new DataTable("IMPORT");
            tbl.Columns.Add("RecPosition", typeof(decimal));
            tbl.Columns.Add("PrimaryVal", typeof(string));
            tbl.Columns.Add("SecondaryVal", typeof(string));
            return tbl;
        }
        
    }

}