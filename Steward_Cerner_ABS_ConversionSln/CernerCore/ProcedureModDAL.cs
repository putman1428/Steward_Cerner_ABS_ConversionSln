using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WestBARConversion.CernerCore
{
    public class ProcedureModDAL
    {
        public static List<ProcedureMod> GetEncounterProcedureMods(string procId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Select nomenclature_id from PROC_MODIFIER ");
            sb.Append("where parent_entity_id = '" + procId + "' and active_ind = '1' and parent_entity_name = 'PROCEDURE' ");
            
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(GlobalSettings.SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            List<ProcedureMod> procs = new List<ProcedureMod>();
            foreach (DataRow row in dt.Rows)
            {
                ProcedureMod proc = LoadProcedureMod(row);
                if (proc != null)
                {
                    procs.Add(proc);
                }

            }
            return procs;
        }

        private static ProcedureMod LoadProcedureMod(DataRow row)
        {
            ProcedureMod proc = new ProcedureMod();
            proc.NomenID = row["nomenclature_id"].ToString();
            proc.ProcMod = NomenclatureDAL.GetNomenclature_SourceIdentifier(row["nomenclature_id"].ToString());
            return proc;
        }
    }
}
