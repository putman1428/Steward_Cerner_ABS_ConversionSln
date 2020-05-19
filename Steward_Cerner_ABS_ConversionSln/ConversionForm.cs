using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Huron;
using System.Collections;

namespace ABS_Conversion
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }
        public void DisplayResults(string status)
        {
            lblStatus.Text = status;
            lblStatus.Refresh();
            Application.DoEvents();
        }
        public void RemoveUnreadableCharacters(string input, string output)
        {
            string dnw = "";
            int nbr = 0;
            long fileCnt = 0;
            FileStream ifs = new FileStream(input, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(ifs);
            FileStream ofs = new FileStream(output, FileMode.Create);
            BinaryWriter w = new BinaryWriter(ofs);
            fileCnt = ifs.Length;
            try
            {
                for (long h = 0; h <= fileCnt; h++)
                {
                    nbr = (int)r.ReadByte();
                    if (nbr == 9 || nbr == 10 || nbr == 13)
                        w.Write((char)nbr);
                    else if (nbr == 34)
                        dnw = "N";
                    else if (nbr >= 32 && nbr <= 126)
                        w.Write((char)nbr);
                    else
                        w.Write(' ');
                    if (h % 1000000 == 0)
                        DisplayResults(input + " - " + h.ToString());
                }
            }
            catch
            {

            }
            w.Flush();
            w.Close();
            r.Close();
            ifs.Close();
            ofs.Close();
            DisplayResults("COMPLETE");
        }

        public void RemoveUnreadableCharacters2(string input, string output)
        {
            string dnw = "";
            int nbr = 0;
            long fileCnt = 0;
            FileStream ifs = new FileStream(input, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(ifs);
            FileStream ofs = new FileStream(output, FileMode.Create);
            BinaryWriter w = new BinaryWriter(ofs);
            fileCnt = ifs.Length;
            try
            {
                for (long h = 0; h <= fileCnt; h++)
                {
                    nbr = (int)r.ReadByte();
                    if (nbr == 9 || nbr == 10 || nbr == 13)
                        w.Write(nbr.ToString() + " ");
                    else if (nbr == 34)
                        dnw = "N";
                    else if (nbr >= 32 && nbr <= 126)
                        w.Write(nbr.ToString() + " ");
                    else
                        w.Write(' ');
                    if (h % 1000000 == 0)
                        DisplayResults(input + " - " + h.ToString());
                }
            }
            catch
            {

            }
            w.Flush();
            w.Close();
            r.Close();
            ifs.Close();
            ofs.Close();
            DisplayResults("COMPLETE");
        }

        private void btnConvertABS_Click(object sender, EventArgs e)
        {
            ////for (int i = 2016; i < 2017; i++) //start 10/1/year thru 9/30/next year
            //for (int i = 2007; i >= 1990; i--) //start 10/1/year thru 9/30/next year
            //{
            //    Convert_DAR_ABS_Class abs = new Convert_DAR_ABS_Class();
            //    //////DateTime fromDate = new DateTime(1990, 10, 1);

            //    ////DateTime fromDate = new DateTime(i, 10, 1);
            //    ////DateTime thruDate = new DateTime(i + 1, 9, 30);

            //    //This one
            //    DateTime fromDate = new DateTime(i - 1, 10, 1);
            //    DateTime thruDate = new DateTime(i, 9, 30);

            //    //DateTime fromDate = new DateTime(i - 1, 5, 1);
            //    //DateTime thruDate = new DateTime(i, 9, 1);

            //    // DateTime fromDate = new DateTime(i - 1, 10, 1);
            //    //DateTime thruDate = new DateTime(i, 4, 30);

            //    abs.Convert_DAR_ABS(fromDate, thruDate, "RockledgeHistory");
            //    abs.Convert_DAR_ABS(fromDate, thruDate, "SebastianHistory");
            //    abs.Convert_DAR_ABS(fromDate, thruDate, "MelbourneHistory");

            //Casemix.CreateCasemix(this, "SHAZ", "'MVHX','SBHX','TSHX','SLHX'", @"P:\ABS_CONVERSION\INPUT\", @"P:\ABS_CONVERSION\OUTPUT\");
            Casemix.CreateCasemix(this, "SHAZ", "'MVHX','SBHX','TSHX','SLHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            string f = "";
            string l = "";
            string mrn = "";
            StreamWriter w = new StreamWriter(@"C:\Users\jp287\Documents\Data\MelbourneHistory_ABS__2016.txt");
            using (StreamReader sr = new StreamReader(@"E:\MPIConversion\DAR\MelbourneHistory_ABS__2016.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Substring(0, 2) == "01")
                    {
                        f = line.Substring(0, 16);
                        mrn = line.Substring(16, 10);
                        l = line.Substring(26);
                        mrn = mrn.Substring(2, 8).PadRight(10, ' ');
                        mrn = mrn.Substring(0, 10);
                        w.WriteLine(f + mrn + l);
                    }
                    else
                        w.WriteLine(line);
                    num++;
                    if (num % 100 == 0)
                    {
                        lblStatus.Text = num.ToString();
                        Application.DoEvents();
                    }
                }
                w.Flush();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnScrubFiles_Click(object sender, EventArgs e)
        {
            string location = @"P:\CernerFiles_MT_Migration\ABS_CONVERSION\INPUT\";
            //RemoveUnreadableCharacters(location + "ENCOUNTER.csv", location + "ENCOUNTER_NEW.txt");
            //RemoveUnreadableCharacters(location + "DIAGNOSIS.csv", location + "DIAGNOSIS_NEW.txt");
            //RemoveUnreadableCharacters(location + "DRG.csv", location + "DRG_NEW.txt");
            //RemoveUnreadableCharacters(location + "DRG_EXTENSION.csv", location + "DRG_EXTENSION_NEW.txt");
            //RemoveUnreadableCharacters(location + "ENCNTR_ALIAS.csv", location + "ENCNTR_ALIAS_NEW.txt");
            //RemoveUnreadableCharacters(location + "ENCNTR_MOTHER_CHILD_RELTN.csv", location + "ENCNTR_MOTHER_CHILD_RELTN_NEW.txt");
            //RemoveUnreadableCharacters(location + "ENCNTR_PRSNL_RELTN.csv", location + "ENCNTR_PRSNL_RELTN_NEW.txt");
            //RemoveUnreadableCharacters(location + "NOMENCLATURE.csv", location + "NOMENCLATURE_NEW.txt");
            //RemoveUnreadableCharacters(location + "ORGANIZATION.csv", location + "ORGANIZATION_NEW.txt");
            //RemoveUnreadableCharacters(location + "PATIENT_EVENT.csv", location + "PATIENT_EVENT_NEW.txt");
            //RemoveUnreadableCharacters(location + "PATIENT_EVENT_DETAIL.csv", location + "PATIENT_EVENT_DETAIL_NEW.txt");
            RemoveUnreadableCharacters2(location + "PERSON.csv", location + "PERSON_NEWx.txt");
            //RemoveUnreadableCharacters(location + "PERSON_ALIAS.csv", location + "PERSON_ALIAS_NEW.txt");
            //RemoveUnreadableCharacters(location + "PROC_PRSNL_RELTN.csv", location + "PROC_PRSNL_RELTN_NEW.txt");
            //RemoveUnreadableCharacters(location + "PROCEDURE.csv", location + "PROCEDURE_NEW.txt");
            //RemoveUnreadableCharacters(location + "PRSNL.csv", location + "PRSNL_NEW.txt");
            //RemoveUnreadableCharacters(location + "PRSNL_SPECIALTY_RELTN.csv", location + "PRSNL_SPECIALTY_RELTN_NEW.txt");
            //RemoveUnreadableCharacters(location + "ADDRESS.csv", location + "ADDRESS_NEW.txt");
            //RemoveUnreadableCharacters(location + "Code_Value.csv", location + "Code_Value_NEW.txt");
        }

        private void btnCreateCernerStructs_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            bool isSub = false;
            string rec = "";
            string fld = "";
            string size = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"C:\HSM\Steward\Input\StructInput.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"C:\HSM\Steward\Input\Structoutput.txt", DataIO.IO.OUTPUT);
            //fI1.ReadRecord();
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    cntr++;
                    recs = rec.Split('\t');
                    //if (recs[0].Trim().Contains(".") == true)
                    //    isSub = true;
                    //else
                    //    isSub = false;
                    //if (isSub == true)
                    //    lst.Add(recs[3].Trim().Replace('/', '_') + '\t' + recs[1].Trim() + '\t' + "Y");
                    //else
                    lst.Add(recs[0].Trim());
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            string[] items;
            char par = (char)34;
            for (int y = 0; y < lst.Count; y++)
            {
                items = lst[y].ToString().Split('\t');
                fO.WriteRecordNoCriteria("private string " + items[0].Trim().ToUpper() + "x;");
            }

            fO.WriteRecordNoCriteria("");
            fO.WriteRecordNoCriteria("public void Clear()");
            fO.WriteRecordNoCriteria("{");
            for (int y = 0; y < lst.Count; y++)
            {
                items = lst[y].ToString().Split('\t');
                fO.WriteRecordNoCriteria("    " + items[0].Trim().ToUpper() + "x = " + par + par + ";");
            }
            fO.WriteRecordNoCriteria("}");
            fO.WriteRecordNoCriteria("");
            for (int y = 0; y < lst.Count; y++)
            {
                items = lst[y].ToString().Split('\t');
                fO.WriteRecordNoCriteria("public string " + items[0].Trim());
                fO.WriteRecordNoCriteria("{");
                fO.WriteRecordNoCriteria("    get { return " + items[0].Trim().ToUpper() + "x; }");
                fO.WriteRecordNoCriteria("    set { " + items[0].Trim().ToUpper() + "x = value; }");
                fO.WriteRecordNoCriteria("}");
            }
            string flds = "";
            fO.WriteRecordNoCriteria("");
            fO.WriteRecordNoCriteria("public void SetRecord(string i_record)");
            fO.WriteRecordNoCriteria("{");
            fO.WriteRecordNoCriteria("    string[] recs = i_record.Split('|');");
            for (int y = 0; y < lst.Count; y++)
            {
                items = lst[y].ToString().Split('\t');
                fO.WriteRecordNoCriteria("    " + items[0].Trim().ToUpper() + "x = recs[" + y.ToString() + "].Trim();");
            }
            //fO.WriteRecordNoCriteria("    outRec = " + flds);
            //fO.WriteRecordNoCriteria("    return outRec;");
            fO.WriteRecordNoCriteria("}");
        }

        private void btnRedEncntrAlias(object sender, EventArgs e)
        {

        }

        private void btnRedEncntrPrsnl(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Input\ENCNTR_PRSNL_RELTN_NEW.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"E:\Huron\Input\ENCNTR_PRSNL_RELTN_NEW2.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    cntr++;
                    recs = rec.Split('|');
                    record = recs[0].Trim() + "|" + recs[1].Trim() + "|" + recs[2].Trim() + "|" + recs[3].Trim() + "|" + recs[9].Trim() + "|" + recs[13].Trim() + "|" + recs[14].Trim() + "|" + recs[18].Trim() + "|" + recs[27].Trim() + "|" + recs[28].Trim() + "|" + recs[29].Trim() + "|" + recs[31].Trim() + "|" + recs[32].Trim() + "|" + recs[33].Trim() + "|" + recs[34].Trim();
                    fO.WriteRecordNoCriteria(record);
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
        }

        private void btnRedPersonAlias_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Input\PERSON_ALIAS_NEW.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"E:\Huron\Input\PERSON_ALIAS_NEW2.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    cntr++;
                    recs = rec.Split('|');
                    if(recs[12].Trim() == "10" || recs[12].Trim() == "18")
                    //    record = recs[0].Trim() + "|" + recs[1].Trim() + "|" + recs[7].Trim() + "|" + recs[11].Trim() + "|" + recs[12].Trim() + "|" + recs[13].Trim() + "|" + recs[17].Trim() + "|" + recs[18].Trim();
                        fO.WriteRecordNoCriteria(rec);
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
        }

        private void btnEncAliasRed_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Input\ENCNTR_ALIAS_NEW.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"E:\Huron\Input\ENCNTR_ALIAS_NEW2.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    cntr++;
                    recs = rec.Split('|');
                    if (recs[12].Trim() == "1077")
                        //    record = recs[0].Trim() + "|" + recs[1].Trim() + "|" + recs[7].Trim() + "|" + recs[11].Trim() + "|" + recs[12].Trim() + "|" + recs[13].Trim() + "|" + recs[17].Trim() + "|" + recs[18].Trim();
                        fO.WriteRecordNoCriteria(rec);
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string AZ = "|3108362|3110566|3168093|3108361|3110565|3108359|3110564|3168088|3108360|3168091|3222168|3222158|4135812|";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Input\ENCOUNTER_NEW.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"E:\Huron\Input\ENCOUNTER_NEW_AZ.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord_All();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    cntr++;
                    recs = rec.Split('|');
                    if (recs.Length == 155)
                    {
                        if (AZ.Contains("|" + recs[71].Trim() + "|"))
                            //    record = recs[0].Trim() + "|" + recs[1].Trim() + "|" + recs[7].Trim() + "|" + recs[11].Trim() + "|" + recs[12].Trim() + "|" + recs[13].Trim() + "|" + recs[17].Trim() + "|" + recs[18].Trim();
                            fO.WriteRecordNoCriteria(rec);
                    }
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            //fI1.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2017.txt", DataIO.IO.INPUT);
            //fI2.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2018.txt", DataIO.IO.INPUT);
            //fI3.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2019.txt", DataIO.IO.INPUT);
            //fI4.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2020.txt", DataIO.IO.INPUT);
            fI5.OpenFile(@"P:\TempFiles\MPIVisitRecCount.txt", DataIO.IO.INPUT);
            //fO.OpenFile(@"P:\TempFiles\TestRecCount2.txt", DataIO.IO.OUTPUT);
            //fO2.OpenFile(@"P:\TempFiles\DupRec2.txt", DataIO.IO.OUTPUT);

            while (eof == false)
            {
                fI5.ReadRecord();
                rec = fI5.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "02")
                    {
                        if (hash.ContainsKey(rec.Substring(14, 12)) == false)
                            hash.Add(rec.Substring(14, 12), "");
                        else
                        rec = rec;
                    }
                    

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }

            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        if (hash.Contains(rec.Substring(2, 12)) == false)
                            fO2.WriteRecordNoCriteria("2017_" + rec);
                        
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI2.ReadRecord();
                rec = fI2.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        if (hash.Contains(rec.Substring(2, 12)) == false)
                            fO2.WriteRecordNoCriteria("2018_" + rec);
                        
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI3.ReadRecord();
                rec = fI3.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        if (hash.Contains(rec.Substring(2, 12)) == false)
                            fO2.WriteRecordNoCriteria("2019_" + rec);
                        
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI4.ReadRecord();
                rec = fI4.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        if (hash.Contains(rec.Substring(2, 12)) == false)
                            fO2.WriteRecordNoCriteria("2020_" + rec);
                        
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            
            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }
    

        private void btnConvertABS_UT_Click(object sender, EventArgs e)
        {
            Casemix.CreateCasemix(this, "SHUT", "'DHHX','JVHX','JWHX','MPHX','LAHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
        }

        private void btnConvertABS_TX_Click(object sender, EventArgs e)
        {
            //Need to see if GLHX belongs to Tx
            Casemix.CreateCasemix(this, "SHTX-P3", "'WHHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
        }
        private void btnConvertABS_TXTX_Click(object sender, EventArgs e)
        {
            Casemix.CreateCasemix(this, "SHTX-P3", "'ODHX','WDHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
        }
        private void btnTxUt_Click(object sender, EventArgs e)
        {
            Casemix.CreateCasemix(this, "SHTX-P3", "'GLHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
        }
        private void btnTx2_Click(object sender, EventArgs e)
        {
            Casemix.CreateCasemix(this, "SHTX-P4", "'STHX','SWHX','JMHX','JHHX'", @"E:\Huron\Input\", @"E:\Huron\Output\Casemix\");
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fO = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"P:\TempFiles\MPI_SHAZ_20200218.2013.1.txt", DataIO.IO.INPUT);
            fI2.OpenFile(@"P:\TempFiles\MPI_SHAZ_20200218.2013.2.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"P:\TempFiles\MPIVisitRecCount.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if(rec.Substring(0,2) == "02")
                        fO.WriteRecordNoCriteria(rec);

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI2.ReadRecord();
                rec = fI2.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "02")
                        fO.WriteRecordNoCriteria(rec);

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cntr = 0;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;

            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();
            //int cntr = 0;
            fI1.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2017.txt", DataIO.IO.INPUT);
            fI2.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2018.txt", DataIO.IO.INPUT);
            fI3.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2019.txt", DataIO.IO.INPUT);
            fI4.OpenFile(@"E:\Huron\Output\Casemix\SHAZ_ABS_2020.txt", DataIO.IO.INPUT);
            //fI5.OpenFile(@"P:\TempFiles\MPIVisitRecCount.txt", DataIO.IO.INPUT);
            //fO.OpenFile(@"P:\TempFiles\TestRecCount.txt", DataIO.IO.OUTPUT);
            //fO2.OpenFile(@"P:\TempFiles\DupRec.txt", DataIO.IO.OUTPUT);
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        cntr = cntr + 1;
                        num1 = num1 + 1;
                        //if(hash.Contains(rec.Substring(2, 12)) == true)
                        //    fO2.WriteRecordNoCriteria("2017_" + rec);
                        //else
                        //    hash.Add(rec.Substring(2, 12), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI2.ReadRecord();
                rec = fI2.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        cntr = cntr + 1;
                        num2 = num2 + 1;
                        //if (hash.Contains(rec.Substring(2, 12)) == true)
                        //    fO2.WriteRecordNoCriteria("2018_" + rec);
                        //else
                        //    hash.Add(rec.Substring(2, 12), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI3.ReadRecord();
                rec = fI3.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        cntr = cntr + 1;
                        num3 = num3 + 1;
                        //if (hash.Contains(rec.Substring(2, 12)) == true)
                        //    fO2.WriteRecordNoCriteria("2019_" + rec);
                        //else
                        //    hash.Add(rec.Substring(2, 12), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI4.ReadRecord();
                rec = fI4.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        cntr = cntr + 1;
                        num4 = num4 + 1;
                        //if (hash.Contains(rec.Substring(2, 12)) == true)
                        //    fO2.WriteRecordNoCriteria("2020_" + rec);
                        //else
                        //    hash.Add(rec.Substring(2, 12), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            //while (eof == false)
            //{
            //    fI5.ReadRecord();
            //    rec = fI5.RecordData;
            //    if (rec == "END OF FILE")
            //        break;
            //    else
            //    {
            //        if (rec.Substring(0, 2) == "02")
            //        {
            //            if (hash.ContainsKey(rec.Substring(14, 12)) == false)
            //                fO.WriteRecordNoCriteria(rec);
            //        }

            //    }
            //    count++;
            //    if (count % 100 == 0)
            //        DisplayResults(count.ToString());
            //}
            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Output\CMAccounts.txt", DataIO.IO.INPUT);
            fI5.OpenFile(@"P:\TempFiles\MPIVisitRecCount.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"P:\TempFiles\TestRecCount2.txt", DataIO.IO.OUTPUT);
            fO2.OpenFile(@"P:\TempFiles\DupRec2.txt", DataIO.IO.OUTPUT);

            while (eof == false)
            {
                fI5.ReadRecord();
                rec = fI5.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "02")
                    {
                        if (hash.ContainsKey(rec.Substring(14, 12)) == false)
                            hash.Add(rec.Substring(14, 12), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    recs = rec.Split('\t');
                        if (hash.Contains(recs[0].Trim()) == false)
                            fO2.WriteRecordNoCriteria(rec);

                    

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            

            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Input\MPI_SHAZ_20200218.2013.1.txt", DataIO.IO.INPUT);
            fI5.OpenFile(@"E:\Huron\Input\MPI_SHAZ_20200218.2013.2.txt", DataIO.IO.INPUT);
            fO.OpenFile(@"E:\Huron\Input\MPIAccounts.txt", DataIO.IO.OUTPUT);
            
            while (eof == false)
            {
                fI5.ReadRecord();
                rec = fI5.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "02")
                    {
                        fO.WriteRecordNoCriteria(rec.Substring(14,12));
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "02")
                    {
                        fO.WriteRecordNoCriteria(rec.Substring(14, 12));
                    }
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }


            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();

            fI1.OpenFile(@"E:\Huron\Output\AccountsInFound.txt", DataIO.IO.INPUT);
            fI5.OpenFile(@"E:\Huron\Input\MPIAccounts.txt", DataIO.IO.INPUT);
            //fO.OpenFile(@"P:\TempFiles\TestRecCount2.txt", DataIO.IO.OUTPUT);
            //fO2.OpenFile(@"P:\TempFiles\DupRec2.txt", DataIO.IO.OUTPUT);

            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    recs = rec.Split('\t');
                    if (hash.Contains(recs[0].Trim()) == false)
                    {
                        
                            hash.Add(recs[0].Trim(), "");
                    }

                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            while (eof == false)
            {
                fI5.ReadRecord();
                rec = fI5.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    
                    if (hash.Contains(rec.Trim()) == false)
                        record = record;



                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }


            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int cntr = 1;
            int count = 0;
            int num = 0;
            bool eof = false;
            bool newpat = true;
            string rec = "";
            string[] recs;
            string record = "";
            DataIO fI1 = new DataIO();
            DataIO fI2 = new DataIO();
            DataIO fI3 = new DataIO();
            DataIO fI4 = new DataIO();
            DataIO fI5 = new DataIO();
            DataIO fO = new DataIO();
            DataIO fO2 = new DataIO();
            Hashtable hash = new Hashtable();
            Hashtable hashC = new Hashtable();
            ArrayList lst = new ArrayList();
            string oldpat = "";
            string epNbr = "";
            string epdt = "";
            string oldepNbr = "";
            string stop = "";
            string acct = "";
            string oldepnbr = "";
            fI1.OpenFile(@"E:\Huron\Output\Casemix\SHTX_LA_ABS_2018.txt", DataIO.IO.INPUT);
            //fO.OpenFile(@"E:\Huron\Output\Casemix\ProcError.txt", DataIO.IO.OUTPUT);

            while (eof == false)
            {
                fI1.ReadRecord();
                rec = fI1.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (rec.Substring(0, 2) == "01")
                    {
                        acct = rec.Substring(2, 24).Trim();
                    }
                    if (rec.Substring(0, 2) == "09")
                    {
                        if (rec.Substring(2, 5).Trim() != "")
                            newpat = true;
                        //else
                        //    newpat = false;
                        if (newpat == true)
                        {
                            epNbr = rec.Substring(2, 5).Trim();
                            epdt = rec.Substring(29, 8).Trim();
                            if(epNbr.Trim() == "")
                                stop = "Y";
                            if (epdt.Trim() == "")
                                stop = "Y";
                            newpat = false;

                            if (epNbr != "1")
                            {
                                if (int.Parse(rec.Substring(2, 5).Trim()) - 1 != int.Parse(oldepnbr))
                                    stop = "Y";
                            }
                            if (rec.Substring(2, 5).Trim() != "")
                                oldepnbr = rec.Substring(2, 5).Trim();
                        }
                        else
                        {
                            //if (rec.Substring(2, 5).Trim() != "")
                            //{
                            //    if (int.Parse(rec.Substring(2, 5).Trim()) - 1 != int.Parse(epNbr))
                            //        stop = "Y";
                            //}
                            if (rec.Substring(2, 5).Trim() == "")
                            {
                                if (rec.Substring(29, 8).Trim() != epdt)
                                    stop = "Y";
                            }
                        }
                    }
                    else
                        newpat = true;
                }
                count++;
                if (count % 100 == 0)
                    DisplayResults(count.ToString());
            }
            
            lblStatus.Text = count.ToString();
            Application.DoEvents();
        }
    }
}
