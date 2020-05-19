using Huron;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ABS_Conversion
{
    public class Casemix
    {
        private static ConversionForm frm;

        #region Cerner Input/Output Files
        private static DataIO fCODE_VALUE = new DataIO();
        //private static DataIO fENCOUNTER = new DataIO();
        //private static DataIO fDIAGNOSIS = new DataIO();
        //private static DataIO fDRG = new DataIO();
        //private static DataIO fDRG_EXTENSION = new DataIO();
        //private static DataIO fENCNTR_ALIAS = new DataIO();
        //private static DataIO fENCNTR_MOTHER_CHILD_RELTN = new DataIO();
        //private static DataIO fENCNTR_PRSNL_RELTN = new DataIO();
        //private static DataIO fNOMENCLATURE = new DataIO();
        //private static DataIO fORGANIZATION = new DataIO();
        //private static DataIO fPATIENT_EVENT = new DataIO();
        //private static DataIO fPATIENT_EVENT_DETAIL = new DataIO();
        //private static DataIO fPERSON = new DataIO();
        //private static DataIO fPERSON_ALIAS = new DataIO();
        //private static DataIO fPROC_PRSNL_RELTN = new DataIO();
        //private static DataIO fPROCEDURE = new DataIO();
        //private static DataIO fPRSNL = new DataIO();
        //private static DataIO fPRSNL_SPECIALTY_RELTN = new DataIO();
        //private static DataIO fADDRESS = new DataIO();

        private static DataIO fCASE_2017 = new DataIO();
        private static DataIO fCASE_2018 = new DataIO();
        private static DataIO fCASE_2019 = new DataIO();
        private static DataIO fCASE_2020 = new DataIO();
        #endregion Cerner Input/Output Files

        #region CaseMix Structs
        private static HuronCaseMixStruct.HEADER MTRecord00;
        private static HuronCaseMixStruct.DEMOGRAPHIC_DATA MTRecord01;
        private static HuronCaseMixStruct.REGISTRATION_DATA MTRecord02;
        private static HuronCaseMixStruct.PROVIDER_DATA MTRecord03;
        private static HuronCaseMixStruct.OTHER_PROVIDERS_DATA MTRecord04;
        private static HuronCaseMixStruct.SERVICES_DATA MTRecord05;
        private static HuronCaseMixStruct.SPECIAL_CARE_UNITS_DATA MTRecord06;
        private static HuronCaseMixStruct.MATERNITY_NEWBORN_DATA MTRecord07;
        private static HuronCaseMixStruct.STILLBORN_DATA MTRecord08;
        private static HuronCaseMixStruct.PROCEDURES_DATA MTRecord09;
        private static HuronCaseMixStruct.HCPCS_CPT_DATA MTRecord10;
        private static HuronCaseMixStruct.REASON_FOR_VISIT_DIAGNOSES_DATA MTRecord11;
        private static HuronCaseMixStruct.DIAGNOSIS_DATA MTRecord12;
        private static HuronCaseMixStruct.STATUSES_DATA MTRecord13;
        private static HuronCaseMixStruct.TRAILER MTRecord99;
        #endregion CaseMix Structs

        #region Cerner Structs
        private static HuronCernerStruct.CODE_VALUE CERN_CODE_VALUE;
        private static HuronCernerStruct.DIAGNOSIS CERN_DIAGNOSIS;
        private static HuronCernerStruct.DRG CERN_DRG;
        private static HuronCernerStruct.DRG_EXTENSION CERN_DRG_EXTENSION;
        private static HuronCernerStruct.ENCNTR_ALIAS CERN_ENCNTR_ALIAS;
        private static HuronCernerStruct.ENCNTR_MOTHER_CHILD_RELTN CERN_ENCNTR_MOTHER_CHILD_RELTN;
        private static HuronCernerStruct.ENCNTR_PRSNL_RELTN CERN_ENCNTR_PRSNL_RELTN;
        private static HuronCernerStruct.ENCOUNTER CERN_ENCOUNTER;
        private static HuronCernerStruct.NOMENCLATURE CERN_NOMENCLATURE;
        private static HuronCernerStruct.ORGANIZATION CERN_ORGANIZATION;
        private static HuronCernerStruct.PATIENT_EVENT CERN_PATIENT_EVENT;
        private static HuronCernerStruct.PATIENT_EVENT_DETAIL CERN_PATIENT_EVENT_DETAIL;
        private static HuronCernerStruct.PERSON CERN_PERSON;
        private static HuronCernerStruct.PERSON_ALIAS CERN_PERSON_ALIAS;
        private static HuronCernerStruct.PROCEDURE CERN_PROCEDURE;
        private static HuronCernerStruct.PROC_PRSNL_RELTN CERN_PROC_PRSNL_RELTN;
        private static HuronCernerStruct.PRSNL CERN_PRSNL;
        private static HuronCernerStruct.PRSNL_SPECIALTY_RELTN CERN_PRSNL_SPECIALTY_RELTN;
        private static HuronCernerStruct.Address CERN_ADDRESS;
        #endregion Cerner Structs

        private static string global_InputFileLoc = "";
        private static string global_OutputFileLoc = "";
        private static Hashtable global_OrgHash;
        private static Hashtable global_CodeValue;
        private static string global_AdmDate = "";
        private static string global_GrouperVersion = "";
        private static string global_hcis = "";
        private static Hashtable global_Map;
        private static string global_FacilityCd = "";
        private static string global_AdmitSource = "";
        private static Hashtable _globalAcctHash;
        public static void CreateCasemix(ConversionForm f, string hcis, string facilities, string inputFileLoc, string outputFileLoc)
        {
            int count = 0;
            string timein = "";
            string timeout = "";
            DateTime inDate;

            #region Test Code1
            int convert = 0;
            int convert2 = 0;
            int notconvert = 0;
            int notconvert2 = 0;
            int convert3 = 0;
            string dt = "";
            string dt2 = "";
            string dt3 = "";
            
            string encTYpe = "";
            string line = "";
            string person_ID = "";
            string rec = "";
            string[] recs;
            bool eof = false;
            _globalAcctHash = new Hashtable();


            //DateTime inDate = new DateTime();
            //DataIO outIO = new DataIO();
            //outIO.OpenFile(@"E:\Huron\Output\AccountsNotFound.txt", DataIO.IO.OUTPUT);

            //DataIO outIO2 = new DataIO();
            //outIO2.OpenFile(@"E:\Huron\Output\AccountsInFound.txt", DataIO.IO.OUTPUT);

            //DataIO fPERSON = new DataIO();
            //fPERSON.OpenFile(@"E:\Huron\Input\SHAZ_MPI_Patient_List.txt", DataIO.IO.INPUT);

            ////------------------------------------------------------------------
            DataIO fACCTS = new DataIO();
            fACCTS.OpenFile(@"E:\Huron\Input\MPIAccounts.txt", DataIO.IO.INPUT);

            while (eof == false)
            {
                fACCTS.ReadRecord();
                rec = fACCTS.RecordData;
                if (rec == "END OF FILE")
                    break;
                else
                {
                    if (_globalAcctHash.Contains(rec.Trim()) == false)
                    {
                        _globalAcctHash.Add(rec.Trim(), "");
                    }

                }

            }
            ////------------------------------------------------------------------
            #endregion Test Code1

            frm = f;
            global_InputFileLoc = inputFileLoc;
            global_OutputFileLoc = outputFileLoc;
            bool stop = false;
            InitializeCase(hcis);
            CreateCase00Record(hcis);
            timein = DateTime.Now.ToLongTimeString();

            List<string> organizations = GetOrganizationInformation(hcis, facilities);
            List<string> encounterIds = CDV.GetDistinctEncounterIds(organizations);
            Hashtable hashInvalidPersonID = CDV.GetExcludedUsers();

            #region Load MPI Data
            //while (eof == false)
            //{
            //    fPERSON.ReadRecord();
            //    person_ID = fPERSON.RecordData;

            //    if (person_ID == "END OF FILE")
            //        break;
            //    else
            //    {
            #endregion Load MPI Data

            foreach (string encounterId in encounterIds)
            {
                #region Test Individual Account
                //string enc = "99246146.0000";
                //string returnRec = CDV.GetEncounter(enc.Trim(), true);
                //if (CERN_ENCOUNTER.ENCNTR_ID.Trim() == "125734714.0000")
                //    stop = true;
                #endregion Test Individual Account

                string returnRec = CDV.GetEncounter(encounterId.Trim(), true);
                
                CERN_ENCOUNTER.Clear();
                CERN_ENCOUNTER.SetRecord(returnRec);
                
                if (hashInvalidPersonID.ContainsKey(CERN_ENCOUNTER.PERSON_ID.Replace(".0000", "")) == false)
                {
                    dt = CERN_ENCOUNTER.REG_DT_TM.Trim();//.PadRight(10, ' ').Substring(0, 4);
                    dt2 = CERN_ENCOUNTER.INPATIENT_ADMIT_DT_TM.Trim();//if (dt == "2010" || dt == "2011" || dt == "2012" || dt == "2013" || dt == "2014" || dt == "2015" || dt == "2016" || dt == "2017")

                    //if (HuronRoutines.IsDate(dt) == true)
                    //{
                    //    inDate = DateTime.Parse(dt);
                    //    if (inDate >= DateTime.Parse("2018-01-01") && inDate <= DateTime.Parse("2018-06-01"))// Jan 1, 2018 through June 1, 2018"))
                            line = CreateCase01Record(hcis);
                        convert = convert + 1;
                    //}
                    


                    #region Old Test Code
                    //List<string> encounterIds = CDV.GetPersonEncounters(person_ID, organizations);
                    //convert2 = convert2 + encounterIds.Count();


                    //dt = CERN_ENCOUNTER.REG_DT_TM.Trim();//.PadRight(10, ' ').Substring(0, 4);
                    //dt2 = CERN_ENCOUNTER.INPATIENT_ADMIT_DT_TM.Trim();
                    //dt3 = CERN_ENCOUNTER.DISCH_DT_TM.Trim();
                    //encTYpe = CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim();

                    //recs = line.Split('\t');
                    //if (acctList.Contains(recs[0]) == false)
                    //    outIO.WriteRecord(line + '\t' + dt + '\t' + dt2 + '\t' + dt3);

                    //outIO2.WriteRecord(line);


                    //if (dt.Trim() == "" && dt2.Trim() == "" && dt3.Trim() == "")
                    ////    if (HuronRoutines.IsDate(dt) == true || HuronRoutines.IsDate(dt2) == true)
                    //{
                    //    notconvert2 = notconvert2 + 1;
                    //    //
                    //    //outIO.WriteRecordNoCriteria(line + '\t' + encTYpe + '\t' + dt + '\t' + dt2 + '\t' + dt3);
                    //}
                    //else if (dt.Trim() != "")
                    //{
                    //    convert = convert + 1;
                    //}
                    //else if (dt2.Trim() != "")
                    //{
                    //    convert = convert + 1;
                    //}
                    //else if (dt3.Trim() != "")
                    //{
                    //    convert = convert + 1;
                    //}
                    ////else if (encTYpe.Trim() == "276161159.0000" || encTYpe.Trim() == "3012539.0000" || encTYpe.Trim() == "309309.0000")
                    ////{
                    ////    if (HuronRoutines.IsDate(dt3) == true)
                    ////    {
                    ////        convert = convert + 1;
                    ////        //line = CreateCase01Record(hcis);
                    ////        //outIO.WriteRecordNoCriteria(line + '\t' + encTYpe + '\t' + dt + '\t' + dt2 + '\t' + dt3);
                    ////    }
                    ////    else
                    ////    {
                    ////        notconvert2 = notconvert2 + 1;
                    ////        //outIO.WriteRecordNoCriteria("DNC" + '\t' + CERN_ENCOUNTER.ENCNTR_ID.Trim() + '\t' + encTYpe + '\t' + CERN_ENCOUNTER.ORGANIZATION_ID.Trim() + '\t' + dt + '\t' + dt2 + '\t' + dt3);
                    ////    }
                    ////}
                    //else
                    //{
                    //    notconvert = notconvert + 1;
                    //    //outIO.WriteRecordNoCriteria("DNC" + '\t' + CERN_ENCOUNTER.ENCNTR_ID.Trim() + '\t' + encTYpe + '\t' + CERN_ENCOUNTER.ORGANIZATION_ID.Trim() + '\t' + dt + '\t' + dt2 + '\t' + dt3);
                    //}
                    #endregion Old Test Code

                    if (count % 10 == 0)
                        frm.DisplayResults(hcis + " - " + count.ToString() + "  " + timein);
                    count++;
                    
                }
            }
            CreateCase99Record();
            timeout = DateTime.Now.ToLongTimeString();
            frm.DisplayResults(hcis + " - " + count.ToString() + "  " + timein + " to " + timeout);
        }
        private static void InitializeCase(string hcis)
        {
            DataIO.OpenSQLDatabase("SHCDSDBP01", "WestConversionDB");

            #region CaseMix Structs
            MTRecord00 = new HuronCaseMixStruct.HEADER();
            MTRecord01 = new HuronCaseMixStruct.DEMOGRAPHIC_DATA();
            MTRecord02 = new HuronCaseMixStruct.REGISTRATION_DATA();
            MTRecord03 = new HuronCaseMixStruct.PROVIDER_DATA();
            MTRecord04 = new HuronCaseMixStruct.OTHER_PROVIDERS_DATA();
            MTRecord05 = new HuronCaseMixStruct.SERVICES_DATA();
            MTRecord06 = new HuronCaseMixStruct.SPECIAL_CARE_UNITS_DATA();
            MTRecord07 = new HuronCaseMixStruct.MATERNITY_NEWBORN_DATA();
            MTRecord08 = new HuronCaseMixStruct.STILLBORN_DATA();
            MTRecord09 = new HuronCaseMixStruct.PROCEDURES_DATA();
            MTRecord10 = new HuronCaseMixStruct.HCPCS_CPT_DATA();
            MTRecord11 = new HuronCaseMixStruct.REASON_FOR_VISIT_DIAGNOSES_DATA();
            MTRecord12 = new HuronCaseMixStruct.DIAGNOSIS_DATA();
            MTRecord13 = new HuronCaseMixStruct.STATUSES_DATA();
            MTRecord99 = new HuronCaseMixStruct.TRAILER();
            #endregion CaseMix Structs

            #region Cerner Structs
            CERN_CODE_VALUE = new HuronCernerStruct.CODE_VALUE();
            CERN_DIAGNOSIS = new HuronCernerStruct.DIAGNOSIS();
            CERN_DRG = new HuronCernerStruct.DRG();
            CERN_DRG_EXTENSION = new HuronCernerStruct.DRG_EXTENSION();
            CERN_ENCNTR_ALIAS = new HuronCernerStruct.ENCNTR_ALIAS();
            CERN_ENCNTR_MOTHER_CHILD_RELTN = new HuronCernerStruct.ENCNTR_MOTHER_CHILD_RELTN();
            CERN_ENCNTR_PRSNL_RELTN = new HuronCernerStruct.ENCNTR_PRSNL_RELTN();
            CERN_ENCOUNTER = new HuronCernerStruct.ENCOUNTER();
            CERN_NOMENCLATURE = new HuronCernerStruct.NOMENCLATURE();
            CERN_ORGANIZATION = new HuronCernerStruct.ORGANIZATION();
            CERN_PATIENT_EVENT = new HuronCernerStruct.PATIENT_EVENT();
            CERN_PATIENT_EVENT_DETAIL = new HuronCernerStruct.PATIENT_EVENT_DETAIL();
            CERN_PERSON = new HuronCernerStruct.PERSON();
            CERN_PERSON_ALIAS = new HuronCernerStruct.PERSON_ALIAS();
            CERN_PROCEDURE = new HuronCernerStruct.PROCEDURE();
            CERN_PROC_PRSNL_RELTN = new HuronCernerStruct.PROC_PRSNL_RELTN();
            CERN_PRSNL = new HuronCernerStruct.PRSNL();
            CERN_PRSNL_SPECIALTY_RELTN = new HuronCernerStruct.PRSNL_SPECIALTY_RELTN();
            CERN_ADDRESS = new HuronCernerStruct.Address();
            #endregion Cerner Structs

            #region Cerner Input Files
            //fENCOUNTER.OpenFile(global_InputFileLoc + "ENCOUNTER_NEW_AZ.txt", DataIO.IO.INPUT);
            //fDIAGNOSIS.OpenFile(global_InputFileLoc + "DIAGNOSIS_NEW.txt", DataIO.IO.INPUT);
            //fDRG.OpenFile(global_InputFileLoc + "DRG_NEW.txt", DataIO.IO.INPUT);
            //fDRG_EXTENSION.OpenFile(global_InputFileLoc + "DRG_EXTENSION_NEW.txt", DataIO.IO.INPUT);
            //fENCNTR_ALIAS.OpenFile(global_InputFileLoc + "ENCNTR_ALIAS_NEW2.txt", DataIO.IO.INPUT);
            //fENCNTR_MOTHER_CHILD_RELTN.OpenFile(global_InputFileLoc + "ENCNTR_MOTHER_CHILD_RELTN_NEW.txt", DataIO.IO.INPUT);
            //fENCNTR_PRSNL_RELTN.OpenFile(global_InputFileLoc + "ENCNTR_PRSNL_RELTN_NEW2.txt", DataIO.IO.INPUT);
            //fNOMENCLATURE.OpenFile(global_InputFileLoc + "NOMENCLATURE_NEW.txt", DataIO.IO.INPUT);
            //fORGANIZATION.OpenFile(global_InputFileLoc + "ORGANIZATION_NEW.txt", DataIO.IO.INPUT);
            //fPATIENT_EVENT.OpenFile(global_InputFileLoc + "PATIENT_EVENT_NEW.txt", DataIO.IO.INPUT);
            //fPATIENT_EVENT_DETAIL.OpenFile(global_InputFileLoc + "PATIENT_EVENT_DETAIL_NEW.txt", DataIO.IO.INPUT);
            //fPERSON.OpenFile(global_InputFileLoc + "PERSON_NEW.txt", DataIO.IO.INPUT);
            //fPERSON_ALIAS.OpenFile(global_InputFileLoc + "PERSON_ALIAS_NEW2.txt", DataIO.IO.INPUT);
            //fPROC_PRSNL_RELTN.OpenFile(global_InputFileLoc + "PROC_PRSNL_RELTN_NEW.txt", DataIO.IO.INPUT);
            //fPROCEDURE.OpenFile(global_InputFileLoc + "PROCEDURE_NEW.txt", DataIO.IO.INPUT);
            //fPRSNL.OpenFile(global_InputFileLoc + "PRSNL_NEW.txt", DataIO.IO.INPUT);
            //fPRSNL_SPECIALTY_RELTN.OpenFile(global_InputFileLoc + "PRSNL_SPECIALTY_RELTN_NEW.txt", DataIO.IO.INPUT);
            //fADDRESS.OpenFile(global_InputFileLoc + "ADDRESS_NEW.txt", DataIO.IO.INPUT);

            //fDIAGNOSIS.Index(frm, "WestConversionDB", "ABS_DIAGNOSIS", "", "", "14", "", "");
            //fDRG_EXTENSION.Index(frm, "WestConversionDB", "ABS_DRG_EXTENSION", "", "", "1", "", "");
            //fDRG.Index(frm, "WestConversionDB", "ABS_DRG", "", "", "2", "", "");
            //fENCNTR_ALIAS.Index(frm, "WestConversionDB", "ABS_ENCNTR_ALIAS", "", "", "1", "", "");
            //fENCNTR_MOTHER_CHILD_RELTN.Index(frm, "WestConversionDB", "ABS_MOTHER_CHILD_RELTN", "", "", "2", "", "");
            //fENCNTR_PRSNL_RELTN.Index(frm, "WestConversionDB", "ABS_ENCNTR_PRSNL_RELTN", "", "", "3", "", "");
            //fNOMENCLATURE.Index(frm, "WestConversionDB", "ABS_NOMENCLATURE", "", "", "0", "", "");
            //fORGANIZATION.Index(frm, "WestConversionDB", "ABS_ORGANIZATION", "", "", "0", "", "");
            //fPATIENT_EVENT.Index(frm, "WestConversionDB", "ABS_PATIENT_EVENT", "", "", "2", "", "");
            //fPATIENT_EVENT_DETAIL.Index(frm, "WestConversionDB", "ABS_PATIENT_EVENT_DETAIL", "", "", "0", "", "");
            //fPERSON.Index(frm, "WestConversionDB", "ABS_PERSON", "", "", "0", "", "");
            //fPERSON_ALIAS.Index(frm, "WestConversionDB", "ABS_PERSON_ALIAS", "", "", "1", "", "");
            //fPROC_PRSNL_RELTN.Index(frm, "WestConversionDB", "ABS_PROC_PRSNL_RELTN", "", "", "3", "", "");
            //fPROCEDURE.Index(frm, "WestConversionDB", "ABS_PROCEDURE", "", "", "13", "", "");
            //fPRSNL_SPECIALTY_RELTN.Index(frm, "WestConversionDB", "ABS_PRSNL_SPECIALTY_RELTN", "", "", "2", "", "");
            //fADDRESS.Index(frm, "WestConversionDB", "ABS_ADDRESS", "", "", "2", "", "");

            //fDIAGNOSIS.SetRecordLength(10000);
            //fDRG.SetRecordLength(10000);
            //fDRG_EXTENSION.SetRecordLength(10000);
            //fENCNTR_ALIAS.SetRecordLength(10000);
            //fENCNTR_MOTHER_CHILD_RELTN.SetRecordLength(10000);
            //fENCNTR_PRSNL_RELTN.SetRecordLength(10000);
            //fNOMENCLATURE.SetRecordLength(10000);
            //fORGANIZATION.SetRecordLength(10000);
            //fPATIENT_EVENT.SetRecordLength(10000);
            //fPATIENT_EVENT_DETAIL.SetRecordLength(10000);
            //fPERSON.SetRecordLength(10000);
            //fPERSON_ALIAS.SetRecordLength(10000);
            //fPROC_PRSNL_RELTN.SetRecordLength(10000);
            //fPROCEDURE.SetRecordLength(10000);
            //fADDRESS.SetRecordLength(10000);
            //fPRSNL_SPECIALTY_RELTN.SetRecordLength(10000);
            #endregion Cerner Input Files

            fCASE_2017.OpenFile(global_OutputFileLoc + hcis.ToUpper() + "_ABS_2017.txt", DataIO.IO.OUTPUT);
            fCASE_2018.OpenFile(global_OutputFileLoc + hcis.ToUpper() + "_ABS_2018.txt", DataIO.IO.OUTPUT);
            fCASE_2019.OpenFile(global_OutputFileLoc + hcis.ToUpper() + "_ABS_2019.txt", DataIO.IO.OUTPUT);
            fCASE_2020.OpenFile(global_OutputFileLoc + hcis.ToUpper() + "_ABS_2020.txt", DataIO.IO.OUTPUT);

            LoadCodeValue();
            LoadMapping();
        }

        private static void CreateCase00Record(string hcis)
        {
            MTRecord00.Clear();
            MTRecord00.RecordType = "00";
            MTRecord00.TapeHeader = "Case Mix Conversion for " + hcis + " " + DateTime.Now.ToString("yyyyMMdd");
            MTRecord00.CreationDate = DateTime.Now.ToString("yyyyMMdd");
            fCASE_2017.WriteRecord(MTRecord00.GetRecord());
            fCASE_2018.WriteRecord(MTRecord00.GetRecord());
            fCASE_2019.WriteRecord(MTRecord00.GetRecord());
            fCASE_2020.WriteRecord(MTRecord00.GetRecord());
        }

        private static string CreateCase01Record(string hcis)
        {
            string person_rec = "";
            string acctPrefix = "";
            string mrnPrefix = "";
            string facility = "";
            string loc = "";
            string acctNumber = "";
            string procdt = "";
            string[] items;
            Hashtable procCPTHash = new Hashtable();

            if (global_OrgHash.Contains(CERN_ENCOUNTER.ORGANIZATION_ID.Trim()) == true)
            {
                items = global_OrgHash[CERN_ENCOUNTER.ORGANIZATION_ID.Trim()].ToString().Split('|');
                facility = items[0].Trim(); mrnPrefix = items[1].Trim(); acctPrefix = items[2].Trim();
            }
            global_hcis = hcis;
            MTRecord01.Clear();
            MTRecord01.RecordType = "01";
            acctNumber = GetEncounterAlias(CERN_ENCOUNTER.ENCNTR_ID.Trim());
            if (acctNumber.Length > 2)
                acctNumber = acctNumber.Substring(2);
            MTRecord01.AccountNumber = acctPrefix + acctNumber.PadLeft(10, '0');

            if (_globalAcctHash.Contains(MTRecord01.AccountNumber) == true)
            {
                string stop = "";
                if (MTRecord01.AccountNumber == "ZV0000022020")
                    stop = "Y";
                MTRecord01.MedicalRecordNumber = mrnPrefix + CERN_ENCOUNTER.PERSON_ID.Replace(".0000", "").Trim().PadLeft(8, '0');
                MTRecord01.Facility = facility;
                global_FacilityCd = facility;
                if (CERN_ENCOUNTER.REG_DT_TM.Trim() == "")
                {
                    MTRecord01.AdmitDate = GetCernerDate2(CERN_ENCOUNTER.DISCH_DT_TM.Trim(), hcis);
                    global_AdmDate = GetCernerDate2(CERN_ENCOUNTER.DISCH_DT_TM.Trim(), hcis);
                }
                else
                {
                    MTRecord01.AdmitDate = GetCernerDate2(CERN_ENCOUNTER.REG_DT_TM.Trim(), hcis);
                    global_AdmDate = GetCernerDate2(CERN_ENCOUNTER.REG_DT_TM.Trim(), hcis);
                }
                MTRecord01.AdmitTime = GetCernerTime(CERN_ENCOUNTER.REG_DT_TM.Trim(), hcis);
                MTRecord01.DischargeDate = GetCernerDate2(CERN_ENCOUNTER.DISCH_DT_TM.Trim(), hcis);
                MTRecord01.DischargeTime = GetCernerTime(CERN_ENCOUNTER.DISCH_DT_TM.Trim(), hcis);
                MTRecord01.PatientStatus = GMV("PS", CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim().Replace(".0000", ""), "CernerCode");
                MTRecord01.FinancialClass = CERN_ENCOUNTER.FINANCIAL_CLASS_CD.Trim().Replace(".0000", "");
                if (global_CodeValue.ContainsKey(CERN_ENCOUNTER.LOC_NURSE_UNIT_CD.Replace(".0000", "").Trim()) == true)
                {
                    loc = global_CodeValue[CERN_ENCOUNTER.LOC_NURSE_UNIT_CD.Replace(".0000", "").Trim()].ToString();
                    MTRecord01.Location = GMV("LC", loc.Trim(), "CernerCode");
                }
                MTRecord01.ArriveDate = GetCernerDate2(CERN_ENCOUNTER.ARRIVE_DT_TM.Trim(), hcis);
                MTRecord01.ArriveTime = GetCernerTime(CERN_ENCOUNTER.ARRIVE_DT_TM.Trim(), hcis);
                MTRecord01.MotherAcctNumber = GetMotherAcctNumber(CERN_ENCOUNTER.ENCNTR_ID.Trim().Trim().Replace(".0000", ""), CERN_ENCOUNTER.ADMIT_TYPE_CD.Trim().Trim().Replace(".0000", ""), CERN_ENCOUNTER.ORGANIZATION_ID.Trim().Trim());
                SetGrouperVersion(GetCernerDate(CERN_ENCOUNTER.DISCH_DT_TM.Trim(), hcis));

                person_rec = GetPersonRecord(CERN_ENCOUNTER.PERSON_ID);
                CERN_PERSON.Clear();
                CERN_PERSON.SetRecord(person_rec);
                string name = CERN_PERSON.NAME_LAST.Trim() + "," + CERN_PERSON.NAME_FIRST.Trim() + " " + CERN_PERSON.NAME_MIDDLE.Trim() + " " + GetNameSuffix(CERN_PERSON.PERSON_ID);
                MTRecord01.PatientName = name.Trim().Replace("  ", " ");
                if (MTRecord01.PatientName.Trim() == "" || MTRecord01.PatientName.Trim() == ",")
                    MTRecord01.PatientName = "NAME,UNKNOWN";
                MTRecord01.Birthdate = GetCernerDate2(CERN_PERSON.BIRTH_DT_TM.Trim(), hcis);
                MTRecord01.Sex = GMV("SX", CERN_PERSON.SEX_CD.Trim().Replace(".0000", ""), "CernerCode");
                MTRecord01.Race = GMV("RC", CERN_PERSON.RACE_CD.Trim().Replace(".0000", ""), "CernerCode");
                MTRecord01.MaritalStatus = GMV("MS", CERN_PERSON.MARITAL_TYPE_CD.Trim().Replace(".0000", ""), "CernerCode");
                MTRecord01.ZipCode = GetZipCode(CERN_PERSON.PERSON_ID.Trim());
                MTRecord01.SocSecNumber = GetSSN(CERN_PERSON.PERSON_ID.Trim());
                WriteRecord(MTRecord01.GetRecord());
                if (MTRecord01.PatientStatus == "RCR")
                {
                    WriteRecord(("23" + MTRecord01.AdmitDate + MTRecord01.AdmitTime).PadRight(183, ' '));
                }
                string admpriority = CreateCase02Record();
                CreateCase03Record(CERN_ENCOUNTER.ENCNTR_ID.Trim());
                if (admpriority.Trim() == "670841")
                    CreateCase07Record(CERN_ENCOUNTER.ENCNTR_ID.Trim());
                procCPTHash = GetProcedures(CERN_ENCOUNTER.ENCNTR_ID.Trim(), MTRecord01.AdmitDate);
                List<CernerProcedure> procList = (List<CernerProcedure>)procCPTHash["PROC"];
                List<CernerProcedure> cptList = (List<CernerProcedure>)procCPTHash["CPT"];
                procdt = CreateCase09Record(procList);
                CreateCase10Record(cptList);
                List<CernerDiagnosis> dxList = GetDiagnosis(CERN_ENCOUNTER.ENCNTR_ID.Trim());
                CreateCase11Record(dxList);
                CreateCase12Record(dxList, procdt, MTRecord01.AdmitDate);
                List<CernerDRG> drgList = GetDRG(CERN_ENCOUNTER.ENCNTR_ID.Trim());
                CreateCase13Record(drgList, CERN_ENCOUNTER.ENCNTR_ID.Trim());
            }
            return "";
            //return MTRecord01.AccountNumber + '\t' + facility + '\t' + CERN_ENCOUNTER.ENCNTR_ID.Trim() + '\t' + CERN_ENCOUNTER.ORGANIZATION_ID.Trim();
        }
        private static string CreateCase02Record()
        {
            MTRecord02.Clear();
            MTRecord02.RecordType = "02";
            if (CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim().Replace(".0000", "") == "309308" || CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim() == "279088653" || CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim() == "24083578" || CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim() == "309312")
            {
                MTRecord02.AdmissionAdmitPriority = CERN_ENCOUNTER.ADMIT_TYPE_CD.Trim().Replace(".0000", "");
            }
            MTRecord02.OutpatientArrivalMode = CERN_ENCOUNTER.ADMIT_MODE_CD.Trim().Replace(".0000", "");
            MTRecord02.AdmitSource = CERN_ENCOUNTER.ADMIT_SRC_CD.Trim().Replace(".0000", "");
            MTRecord02.ExpectedLengthofStay = CERN_ENCOUNTER.EST_LENGTH_OF_STAY.Trim().Replace(".0000", "");
            MTRecord02.AdmittedThroughER = "";
            MTRecord02.ERArrDate = "";
            MTRecord02.AutopsyObtained = "";
            MTRecord02.MedicalExaminerCase = "";
            MTRecord02.Within48HoursofAdmission = "";
            MTRecord02.ReasonforVisit = CERN_ENCOUNTER.REASON_FOR_VISIT.Trim();
            MTRecord02.DischargeDisposition = GMV("DD", CERN_ENCOUNTER.DISCH_DISPOSITION_CD.Trim().Replace(".0000", ""), "CernerCode");
            if (CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim().Replace(".0000", "") == "309312")
            {
                MTRecord02.ObservationPatient = "Y";
                MTRecord02.ObservationDate = GetObservationDate(CERN_ENCOUNTER.ENCNTR_ID.Trim());
            }
            if (CERN_ENCOUNTER.ENCNTR_TYPE_CD.Trim().Replace(".0000", "") == "309310")
            {
                MTRecord02.ERArrDate = GetCernerDate2(CERN_ENCOUNTER.ARRIVE_DT_TM.Trim(), global_hcis);
                MTRecord02.ERArrTime = GetCernerTime(CERN_ENCOUNTER.ARRIVE_DT_TM.Trim(), global_hcis);
                MTRecord02.ERTriageDate = GetCernerDate2(CERN_ENCOUNTER.TRIAGE_DT_TM.Trim(), global_hcis);
                MTRecord02.ERTriageTime = GetCernerTime(CERN_ENCOUNTER.TRIAGE_DT_TM.Trim(), global_hcis);
            }
            WriteRecord(MTRecord02.GetRecord());
            global_AdmitSource = MTRecord02.AdmitSource;
            return MTRecord02.AdmissionAdmitPriority;
        }
        private static void CreateCase03Record(string encID)
        {
            MTRecord03.Clear();
            MTRecord03.RecordType = "03";

            ArrayList returnList = CDV.GetENCNTR_PRSNL_RELTN(encID.Trim(), true);

            for (int x = 0; x < returnList.Count; x++)
            {
                CERN_ENCNTR_PRSNL_RELTN.Clear();
                CERN_ENCNTR_PRSNL_RELTN.SetRecord(returnList[x].ToString());

                #region Primary and Family Physician (Currently not set)
                //if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim() == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim() == "1116")
                //{
                //    MTRecord03.PrimaryCarePhysician = CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim();
                //    MTRecord03.PrimaryCareService = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                //    MTRecord03.PrimaryCareType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim();
                //}
                //else if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim() == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim() == "1116")
                //{
                //    MTRecord03.FamilyPhysician = CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim();
                //    MTRecord03.FamilyPhysicianService = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                //    MTRecord03.FamilyPhysicianType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim();
                //}
                #endregion Primary and Family Physician (Currently not set)
                if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim().Replace(".0000", "") == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "") == "1116")
                {
                    MTRecord03.AdmittingPhysician = GMV_PROV("DR", global_FacilityCd, CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim().Replace(".0000", ""), "Z.CONVPROV");
                    MTRecord03.AdmittingPhysicianService = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    MTRecord03.AdmittingPhysicianType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "");
                }
                else if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim().Replace(".0000", "") == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "") == "1119")
                {
                    MTRecord03.AttendingPhysician = GMV_PROV("DR", global_FacilityCd, CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim().Replace(".0000", ""), "Z.CONVPROV");
                    MTRecord03.AttendingPhysicianServ = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    MTRecord03.AttendingPhysicianType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "");
                }
                else if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim().Replace(".0000", "") == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "") == "3362683")
                {
                    MTRecord03.ERPhysician = GMV_PROV("DR", global_FacilityCd, CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim().Replace(".0000", ""), "Z.CONVPROV");
                    MTRecord03.ERPhysicianService = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    MTRecord03.ERPhysicianType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "");
                }
                else if (CERN_ENCNTR_PRSNL_RELTN.ACTIVE_IND.Trim().Replace(".0000", "") == "1" && CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "") == "1126")
                {
                    MTRecord03.ReferringPhysician = GMV_PROV("DR", global_FacilityCd, CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim().Replace(".0000", ""), "Z.CONVPROV");
                    MTRecord03.ReferringPhysicianService = GetPrimaryCareService(CERN_ENCNTR_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    MTRecord03.ReferringPhysicianType = CERN_ENCNTR_PRSNL_RELTN.ENCNTR_PRSNL_R_CD.Trim().Replace(".0000", "");
                }

            }
            WriteRecord(MTRecord03.GetRecord());
        }

        private static void CreateCase07Record(string encID)
        {
            MTRecord07.Clear();
            MTRecord07.RecordType = "07";
            MTRecord07.NewbornAdmitSource = global_AdmitSource;
            Hashtable hash = CDV.GetCLINICAL_EVENT(encID.Trim(), false);
            if (hash.ContainsKey("apgar1") == true)
                MTRecord07.APGAR1min = hash["apgar1"].ToString();
            if (hash.ContainsKey("apgar5") == true)
                MTRecord07.APGAR5min = hash["apgar5"].ToString();
            WriteRecord(MTRecord07.GetRecord());
        }
        private static void CreateCase08Record()
        {

        }
        private static string CreateCase09Record(List<CernerProcedure> procList)
        {
            bool first = true;
            int epNbr = 0;
            string oldDate = "";
            string firstProcDt = "";
            
            MTRecord09.Clear();
            MTRecord09.RecordType = "09";
            
            foreach (CernerProcedure proc in procList)
            {
                if (proc.ProcedureType == "PROCEDURE")
                {
                    if (oldDate != proc.ProcedureDateTime.Trim())
                    {
                        epNbr = epNbr + 1;
                        MTRecord09.EpisodeNumber = epNbr.ToString();
                    }
                    MTRecord09.ProcedureDate = proc.ProcedureDateTime.Trim();
                    if (first == true)
                    {
                        firstProcDt = MTRecord09.ProcedureDate;
                        first = false;
                    }
                    MTRecord09.ProcedureCode = proc.ProcCode.Trim();
                    MTRecord09.PrimarySurgeon = GMV_PROV("DR", global_FacilityCd, proc.PrimarySurgeon.Trim(), "Z.CONVPROV"); //proc.PrimarySurgeon.Trim();
                    MTRecord09.AssistantSurgeon = GMV_PROV("DR", global_FacilityCd, proc.AssitantSurgeon.Trim(), "Z.CONVPROV"); //proc.AssitantSurgeon.Trim();
                    MTRecord09.AnesthesiaDoctor = GMV_PROV("DR", global_FacilityCd, proc.AnesthPhysician.Trim(), "Z.CONVPROV"); //proc.AnesthPhysician.Trim();
                    if (proc.AnesthTechnique.Trim() == "0")
                        MTRecord09.AnesthesiaTechnique = "";
                    else
                        MTRecord09.AnesthesiaTechnique = proc.AnesthTechnique.Trim();
                    MTRecord09.GroupVersion = global_GrouperVersion;
                    WriteRecord(MTRecord09.GetRecord());
                    MTRecord09.EpisodeNumber = "";
                    oldDate = proc.ProcedureDateTime.Trim();
                }
            }


            //foreach (CernerProcedure proc in procList)
            //{
            //    if (proc.ProcedureType == "PROCEDURE")
            //    {
            //        if (oldDate != proc.ProcedureDateTime.Trim())
            //        {
            //            epNbr = epNbr + 1;
            //            MTRecord09.EpisodeNumber = epNbr.ToString();
            //        }
            //        MTRecord09.ProcedureDate = proc.ProcedureDateTime.Trim();
            //        if(first == true)
            //        {
            //            firstProcDt = MTRecord09.ProcedureDate;
            //            first = false;
            //        }
            //        MTRecord09.ProcedureCode = proc.ProcCode.Trim();
            //        MTRecord09.PrimarySurgeon = GMV_PROV("DR", global_FacilityCd, proc.PrimarySurgeon.Trim(), "Z.CONVPROV"); //proc.PrimarySurgeon.Trim();
            //        MTRecord09.AssistantSurgeon = GMV_PROV("DR", global_FacilityCd, proc.AssitantSurgeon.Trim(), "Z.CONVPROV"); //proc.AssitantSurgeon.Trim();
            //        MTRecord09.AnesthesiaDoctor = GMV_PROV("DR", global_FacilityCd, proc.AnesthPhysician.Trim(), "Z.CONVPROV"); //proc.AnesthPhysician.Trim();
            //        if (proc.AnesthTechnique.Trim() == "0")
            //            MTRecord09.AnesthesiaTechnique = "";
            //        else
            //            MTRecord09.AnesthesiaTechnique = proc.AnesthTechnique.Trim();
            //        MTRecord09.GroupVersion = global_GrouperVersion;
            //        WriteRecord(MTRecord09.GetRecord());
            //        MTRecord09.EpisodeNumber = "";
            //        oldDate = proc.ProcedureDateTime.Trim();
            //    }
            //}
            return firstProcDt;
        }
        private static void CreateCase10Record(List<CernerProcedure> procList)
        {
            MTRecord10.Clear();
            MTRecord10.RecordType = "10";
            foreach (CernerProcedure proc in procList)
            {
                if (proc.ProcedureType == "HCPCSCPT")
                {
                    MTRecord10.CPTCode = proc.ProcCode.Trim();
                    MTRecord10.CPTDate = proc.ProcedureDateTime.Trim();
                    MTRecord10.CPTSurgeon = GMV_PROV("DR", global_FacilityCd, proc.PrimarySurgeon.Trim(), "Z.CONVPROV"); //proc.PrimarySurgeon.Trim();
                    MTRecord10.CPTAssistantSurgeon = GMV_PROV("DR", global_FacilityCd, proc.AssitantSurgeon.Trim(), "Z.CONVPROV"); //proc.AssitantSurgeon.Trim();
                    MTRecord10.CPTModifier = proc.Modifier.Trim();
                    WriteRecord(MTRecord10.GetRecord());
                }
            }
        }
        private static void CreateCase11Record(List<CernerDiagnosis> dxList)
        {
            int nbr = 0;
            bool first = true;
            bool second = true;
            string record = "";
            ArrayList list = new ArrayList();
            MTRecord11.Clear();
            MTRecord11.RecordType = "11";
            foreach (CernerDiagnosis dx in dxList)
            {
                if (dx.DxType == "Reason For Visit")
                {
                    if (nbr > 0)
                        nbr = nbr;
                    //MTRecord11.ReasonForVisitDx = dx.DxCode.Trim();
                    //MTRecord11.GrouperVersion = global_GrouperVersion;
                    record = dx.DxCode.Trim().PadRight(10,' ') + global_GrouperVersion.PadRight(10, ' ') + "".PadRight(12, ' ');
                    list.Add(record);
                    nbr = nbr + 1;
                }
                if (dx.DxType == "Admitting Diagnosis" || dx.DxType == "Admitting")
                {
                    if (first == true)
                    {
                        MTRecord11.AdmittingDiagnosis = dx.DxCode.Trim();
                        MTRecord11.AdmDxGrouperVersion = global_GrouperVersion;
                        first = false;
                    }
                    else if(first == false)
                    {
                        MTRecord11.AltAdmittingDiagnosis = dx.DxCode.Trim();
                        MTRecord11.AltAdmDxGrouperVersion = global_GrouperVersion;
                        second = false;
                    }
                }
            }
            MTRecord11.DiagnosisList = list;
            WriteRecord(MTRecord11.GetRecord());
        }
        private static void CreateCase12Record(List<CernerDiagnosis> dxList, string procDt, string admDt)
        {
            bool skip = false;
            string dxDt = "";
            string dxCd = "";
            string poa = "";
            string record = "";
            ArrayList list = new ArrayList();

            MTRecord12.Clear();
            MTRecord12.RecordType = "12";
            MTRecord12.GrouperVersion = global_GrouperVersion;
            foreach (CernerDiagnosis dx in dxList)
            {
                if (dx.DxType == "Reason For Visit" || dx.DxType == "Admitting Diagnosis" || dx.DxType == "Admitting")
                    skip = true;
                else
                {
                    //if (dx.DxDateTime.Trim() == "")
                    //{
                    //    if (procDt.Trim() == "")
                    //        dxDt = admDt;
                    //    else
                    //        dxDt = procDt;
                    //}
                    //else
                    dxDt = admDt;// dx.DxDateTime.PadRight(8, ' ').Substring(0, 8);
                    dxCd = dx.DxCode.PadRight(10, ' ').Substring(0, 10);
                    poa = dx.PresentOnAdmit.PadRight(10, ' ').Substring(0, 1);
                    record = dxDt + dxCd + poa;
                    list.Add(record.PadRight(45, ' '));
                }
                skip = false;
            }
            MTRecord12.DiagnosisList = list;
            if (list.Count > 0)
                WriteRecord(MTRecord12.GetRecord());
        }
        private static void CreateCase13Record(List<CernerDRG> drgList, string encID)
        {
            int x = 0;
            string sts = "";
            Hashtable nomenHash = new Hashtable();
            MTRecord13.Clear();
            MTRecord13.RecordType = "13";
            sts = GetCodingStatus(encID);
            foreach (CernerDRG drg in drgList)
            {
                
                    nomenHash = GetNomenclature(CERN_DRG.NOMENCLATURE_ID.Trim(), "DRG");
                    MTRecord13.DRG = drg.DRGCode.Trim();
                    MTRecord13.DrgStatus = sts;
                    MTRecord13.AbstractStatus = sts;
                    MTRecord13.DrgExpectedReimbursement = "";
                    MTRecord13.DrgCostWeight = drg.DRGCostWeight;
                
                    MTRecord13.AlternateDRG = drg.DRGAlternate.Trim();
                    MTRecord13.AltDRGCostWeight = "";
                    break;
               
            }
            WriteRecord(MTRecord13.GetRecord());
        }
        private static void CreateCase17Record()
        {

        }
        private static void CreateCase19Record()
        {

        }
        private static void CreateCase99Record()
        {
            MTRecord99.Clear();
            MTRecord99.RecordType = "99";
            fCASE_2017.WriteRecord(MTRecord99.GetRecord());
            fCASE_2018.WriteRecord(MTRecord99.GetRecord());
            fCASE_2019.WriteRecord(MTRecord99.GetRecord());
            fCASE_2020.WriteRecord(MTRecord99.GetRecord());
        }
        public static void WriteRecord(string record)
        {
            global_AdmDate = global_AdmDate.PadRight(8, ' ');
            if (global_AdmDate.StartsWith("2020") == true)
                fCASE_2020.WriteRecord(record);
            else if (global_AdmDate.StartsWith("2019") == true)
                fCASE_2019.WriteRecord(record);
            else if (global_AdmDate.StartsWith("2018") == true)
                fCASE_2018.WriteRecord(record);
            else
                fCASE_2017.WriteRecord(record);
        }
        public static void LoadCodeValue()
        {
            bool eof = false;
            string recCV = "";
            string[] recs;
            int count = 0;
            int nbr = 0;
            DataIO fI1 = new DataIO();
            global_CodeValue = new Hashtable();
            fI1.OpenFile(global_InputFileLoc + "CODE_VALUE_NEW.txt", DataIO.IO.INPUT);
            while (eof == false)
            {
                fI1.ReadRecord_All();
                recCV = fI1.RecordData;
                if (recCV == "END OF FILE")
                    break;
                else
                {
                    recs = recCV.Split('|');
                    count = recs.Length;
                    if (count == 30)
                    {
                        CERN_CODE_VALUE.Clear();
                        CERN_CODE_VALUE.SetRecord(recCV);

                        if (CERN_CODE_VALUE.CODE_SET.Trim().Replace(".0000", "") == "400" || CERN_CODE_VALUE.CODE_SET.Trim().Replace(".0000", "") == "4002009" || CERN_CODE_VALUE.CODE_SET.Trim().Replace(".0000", "") == "17" || CERN_CODE_VALUE.CODE_SET.Trim().Replace(".0000", "") == "220")
                        //400 - Codeset for procedure ICD, HCPCS, and CPT data 
                        //17 - Dx Type|
                        //4002009 - POA
                        //220 - Nurse Location
                        {
                            if (CERN_CODE_VALUE.CODE_SET.Trim().Replace(".0000", "") == "220")
                                global_CodeValue.Add(CERN_CODE_VALUE.CODE_VALUE_VAL.Trim().Replace(".0000", ""), CERN_CODE_VALUE.DISPLAY_KEY.Trim());
                            else
                                global_CodeValue.Add(CERN_CODE_VALUE.CODE_VALUE_VAL.Trim().Replace(".0000", ""), CERN_CODE_VALUE.DISPLAY.Trim());
                        }

                    }
                    nbr = nbr + 1;
                }
            }
            fI1.CloseFile();
        }
        public static void LoadMapping()
        {
            global_Map = new Hashtable();
            Hashtable returnHash = new Hashtable();

            returnHash = CDV.GetCERNER_DISCHARGE_DISPOSITION();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_GENDER();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_LOCATION();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_MARITALSTATUS();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_PROVIDER_MAP();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_RACE();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_STATE();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

            returnHash = CDV.GetCERNER_REGTYPE();
            foreach (string x in returnHash.Keys)
            {
                global_Map.Add(x, returnHash[x].ToString());
            }

        }
        public static string GMV(string mapType, string cernerCd, string defaultVal)
        {
            cernerCd = cernerCd.Replace(".0000", "");
            if (global_Map.ContainsKey(mapType + "_" + cernerCd) == true)
                return global_Map[mapType + "_" + cernerCd].ToString();
            else
            {
                if (defaultVal == "CernerCode")
                    return cernerCd;
                else
                    return defaultVal;
            }
        }
        public static string GMV_PROV(string mapType, string fac, string prsnlID, string defaultVal)
        {
            string npi = "";
            if (prsnlID == "" || prsnlID == "0" || prsnlID == "0.00")
                return "";
            npi = CDV.GetPRSNL_ALIAS(prsnlID, true);
            if (npi != "")
            {
                if (global_Map.ContainsKey(mapType + "_" + fac + "_" + npi) == true)
                    return global_Map[mapType + "_" + fac + "_" + npi].ToString();
                else
                    return defaultVal;
            }
            return "";
        }
        public static string SqlConnectionString()
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = "SHCDSDBP01";
            b.IntegratedSecurity = true;
            b.InitialCatalog = "WestConversionDB";
            return b.ConnectionString;

        }

        private List<string> GetOrganizations(string hcis)
        {
            List<string> orgs = new List<string>();
            orgs = CDV.GetOrganizationsToProcess(hcis);
            return orgs;
        }
        public static List<string> GetOrganizationInformation(string hcis, string facilities)
        {
            global_OrgHash = new Hashtable();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT  organization_id, hcis, facility, mrnPrefix, acctPrefix, cernerPrefix ");
            sb.Append("FROM  MPIOrganization ");
            sb.Append("WHERE hcis = '" + hcis + "' AND facility IN (" + facilities + ")");

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(SqlConnectionString()))
            using (var cmd = new SqlCommand(sb.ToString(), conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            List<string> orgs = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                //global_OrgHash.Add(row["organization_id"].ToString() + ".0000", row["facility"].ToString().Trim() + "|" + row["mrnPrefix"].ToString().Trim() + "|" + row["acctPrefix"].ToString().Trim() + "|" + row["cernerPrefix"].ToString().Trim());
                //orgs.Add(row["organization_id"].ToString() + ".0000");

                global_OrgHash.Add(row["organization_id"].ToString(), row["facility"].ToString().Trim() + "|" + row["mrnPrefix"].ToString().Trim() + "|" + row["acctPrefix"].ToString().Trim() + "|" + row["cernerPrefix"].ToString().Trim());
                orgs.Add(row["organization_id"].ToString());
            }
            return orgs;
        }
        private static string GetPersonRecord(string personID)
        {
            string returnVal = CDV.GetPerson(personID.Trim(), true);
            return returnVal;
        }

        private static string GetEncounterAlias(string encntrID)
        {
            string returnVal = "";
            string returnRec = CDV.GetENCNTR_ALIAS(encntrID.Trim(), "1077", true);
            CERN_ENCNTR_ALIAS.Clear();
            CERN_ENCNTR_ALIAS.SetRecord(returnRec);
            returnVal = CERN_ENCNTR_ALIAS.ALIAS.Trim();
            return returnVal;
        }

        private static string GetZipCode(string personID)
        {
            string returnVal = "";
            string returnRec = CDV.GetADDRESS(personID.Trim(), "756", true);
            CERN_ADDRESS.Clear();
            CERN_ADDRESS.SetRecord(returnRec);
            returnVal = CERN_ADDRESS.ZIPCODE.Trim();//HuronRoutines.FormatZip(CERN_ADDRESS.ZIPCODE.Trim());
            return returnVal;
        }

        private static string GetMotherAcctNumber(string encntrID, string admType, string orgID)
        {
            string returnVal = "";
            string motherEncID = "";
            string acctNbr = "";
            string acctPrefix = "";
            string[] items;
            if (admType == "670841")
            {
                string returnRec = CDV.GetENCNTR_MOTHER_CHILD_RELTN(encntrID, false);
                CERN_ENCNTR_MOTHER_CHILD_RELTN.Clear();
                CERN_ENCNTR_MOTHER_CHILD_RELTN.SetRecord(returnRec);
                motherEncID = CERN_ENCNTR_MOTHER_CHILD_RELTN.MOTHER_ENCNTR_ID.Trim();
                acctNbr = GetEncounterAlias(motherEncID);
                if (acctNbr != "")
                {
                    acctNbr = acctNbr.Substring(2);
                    acctNbr = acctNbr.PadLeft(10, '0');
                }
                if (global_OrgHash.Contains(orgID.Trim()) == true)
                {
                    items = global_OrgHash[orgID].ToString().Split('|');
                    acctPrefix = items[2].Trim();
                }
            }
            returnVal = acctPrefix + acctNbr;
            return returnVal;
        }

        private static string GetObservationDate(string encntrID)
        {
            string returnVal = "";
            string returnRec = CDV.GetPATIENT_EVENT(encntrID.Trim(), "23290115", false);
            CERN_PATIENT_EVENT.Clear();
            CERN_PATIENT_EVENT.SetRecord(returnRec);
            returnVal = GetCernerDate2(CERN_PATIENT_EVENT.EVENT_DT_TM.Trim(), global_hcis);
            return returnVal;
        }
        private static string GetSSN(string personID)
        {
            string returnVal = "";
            string returnRec = CDV.GetPersonAlias(personID.Trim(), true);
            if (returnRec.Distinct().Count() > 1 && returnRec != "999999999")
                returnRec.PadLeft(9, '0');
            else
                returnRec = "";
            return returnRec;
        }
        private static string GetPrimaryCareService(string prsnlID)
        {
            string returnVal = "";
            string returnRec = CDV.GetPRSNL_SPECIALTY_RELTN(prsnlID.Trim(), false);
            CERN_PRSNL_SPECIALTY_RELTN.Clear();
            CERN_PRSNL_SPECIALTY_RELTN.SetRecord(returnRec);
            returnVal = CERN_PRSNL_SPECIALTY_RELTN.SPECIALTY_CD.Trim();
            return returnVal;
        }
        private static Hashtable GetProcedures(string encntrID, string admDt)
        {
            bool convert = true;
            Hashtable outHash = new Hashtable();
            Hashtable nomenHash = new Hashtable();
            Hashtable nomenHashMod = new Hashtable();
            Hashtable phyHash = new Hashtable();

            List<CernerProcedure> procs = new List<CernerProcedure>();
            List<CernerProcedure> cpts = new List<CernerProcedure>();

            Hashtable returnHash = CDV.GetPROCEDURE(encntrID.Trim(), false,global_hcis,global_AdmDate);

            ArrayList returnList = (ArrayList)returnHash["PROC"];
            ArrayList returnListCPT = (ArrayList)returnHash["CPT"];
            for (int x = 0; x < returnList.Count; x++)
            {
                CERN_PROCEDURE.Clear();
                CERN_PROCEDURE.SetRecord(returnList[x].ToString());

                convert = true;
                CernerProcedure proc = new CernerProcedure();
                nomenHash = GetNomenclature(CERN_PROCEDURE.NOMENCLATURE_ID.Trim(), "PROCEDURE");
                nomenHashMod = GetNomenclature(CERN_PROCEDURE.MOD_NOMENCLATURE_ID.Trim(), "PROCMOD");
                phyHash = GetProcPhysicians(CERN_PROCEDURE.PROCEDURE_ID.Trim());
                proc.ProcCode = nomenHash["PROCCD"].ToString().Trim();
                proc.GrouperVersion = "";
                proc.PrimarySurgeon = phyHash["PRIMSURG"].ToString().Trim();

                if (CERN_PROCEDURE.PROC_DT_TM.Trim() == "")
                    proc.ProcedureDateTime = admDt;
                else
                    proc.ProcedureDateTime = GetCernerDate2(CERN_PROCEDURE.PROC_DT_TM.Trim(), global_hcis);
                proc.ProcedurePriority = CERN_PROCEDURE.PROC_PRIORITY.Trim().PadLeft(4, '0');
                proc.AnesthPhysician = phyHash["ANESTHPHY"].ToString().Trim();
                proc.AssitantSurgeon = phyHash["ASSISTSURG"].ToString().Trim();
                proc.AnesthTechnique = CERN_PROCEDURE.ANESTHESIA_CD.Trim();
                if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("ICD"))
                    proc.ProcedureType = "PROCEDURE";
                else if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("CPT"))
                    proc.ProcedureType = "HCPCSCPT";
                else if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("HCPCS"))
                    proc.ProcedureType = "HCPCSCPT";
                else
                {
                    convert = false;
                    proc.ProcedureType = "";
                }
                proc.Modifier = nomenHashMod["PROCMOD"].ToString().Trim();

                if (convert == true)
                {
                    procs.Add(proc);
                }
                nomenHash.Clear();
                nomenHashMod.Clear();
                phyHash.Clear();
            }

            //CPT-----------------------------------------------------------------------------------------------------------------

            for (int x = 0; x < returnListCPT.Count; x++)
            {
                CERN_PROCEDURE.Clear();
                CERN_PROCEDURE.SetRecord(returnListCPT[x].ToString());

                convert = true;
                CernerProcedure cpt = new CernerProcedure();
                nomenHash = GetNomenclature(CERN_PROCEDURE.NOMENCLATURE_ID.Trim(), "PROCEDURE");
                nomenHashMod = GetNomenclature(CERN_PROCEDURE.MOD_NOMENCLATURE_ID.Trim(), "PROCMOD");
                phyHash = GetProcPhysicians(CERN_PROCEDURE.PROCEDURE_ID.Trim());
                cpt.ProcCode = nomenHash["PROCCD"].ToString().Trim();
                cpt.GrouperVersion = "";
                cpt.PrimarySurgeon = phyHash["PRIMSURG"].ToString().Trim();

                if (CERN_PROCEDURE.PROC_DT_TM.Trim() == "")
                    cpt.ProcedureDateTime = admDt;
                else
                    cpt.ProcedureDateTime = GetCernerDate2(CERN_PROCEDURE.PROC_DT_TM.Trim(), global_hcis);
                cpt.ProcedurePriority = CERN_PROCEDURE.PROC_PRIORITY.Trim().PadLeft(4, '0');
                cpt.AnesthPhysician = phyHash["ANESTHPHY"].ToString().Trim();
                cpt.AssitantSurgeon = phyHash["ASSISTSURG"].ToString().Trim();
                cpt.AnesthTechnique = CERN_PROCEDURE.ANESTHESIA_CD.Trim();
                if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("ICD"))
                    cpt.ProcedureType = "PROCEDURE";
                else if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("CPT"))
                    cpt.ProcedureType = "HCPCSCPT";
                else if (nomenHash["PROCDESC"].ToString().Trim().StartsWith("HCPCS"))
                    cpt.ProcedureType = "HCPCSCPT";
                else
                {
                    convert = false;
                    cpt.ProcedureType = "";
                }
                if (cpt.ProcedureType == "HCPCSCPT")
                    cpt.Modifier = CDV.GetCPTMod(CERN_PROCEDURE.PROCEDURE_ID, false);// nomenHashMod["PROCMOD"].ToString().Trim();
                else
                    cpt.Modifier = "";

                if (convert == true)
                {
                    cpts.Add(cpt);
                }
                nomenHash.Clear();
                nomenHashMod.Clear();
                phyHash.Clear();
            }
            //procs = procs.OrderBy(i => i.ProcedurePriority).ToList();
            outHash.Add("PROC", procs);
            outHash.Add("CPT", cpts);
            return outHash;
        }
        private static Hashtable GetNomenclature(string nomenID, string type)
        {

            bool found = false;
            Hashtable returnHash = new Hashtable();
            if (nomenID != "0")
            {
                ArrayList returnList = CDV.GetNOMENCLATURE(nomenID.Trim(), false);
                for (int x = 0; x < returnList.Count; x++)
                {
                    CERN_NOMENCLATURE.Clear();
                    CERN_NOMENCLATURE.SetRecord(returnList[x].ToString());
                    if (CERN_NOMENCLATURE.ACTIVE_IND.Trim() == "1")
                    {
                        if (type == "PROCEDURE")
                        {
                            if (CERN_NOMENCLATURE.SOURCE_IDENTIFIER.Trim().Length < 10)
                            {
                                returnHash.Add("TYPE", CERN_NOMENCLATURE.SOURCE_VOCABULARY_CD.Trim());
                                returnHash.Add("PROCCD", CERN_NOMENCLATURE.SOURCE_IDENTIFIER.Trim());
                                if (global_CodeValue.ContainsKey(CERN_NOMENCLATURE.SOURCE_VOCABULARY_CD.Trim()) == true)
                                {
                                    returnHash.Add("PROCDESC", global_CodeValue[CERN_NOMENCLATURE.SOURCE_VOCABULARY_CD.Trim()].ToString().Trim());
                                }
                                found = true;
                            }
                            else
                                found = false;
                        }
                        else if (type == "PROCMOD")
                        {
                            //if (found == true)
                                returnHash.Add("PROCMOD", CERN_NOMENCLATURE.SOURCE_IDENTIFIER.Trim());
                        }
                        else if (type == "DIAGNOSIS")
                        {
                            returnHash.Add("DIAGNOSIS", CERN_NOMENCLATURE.SOURCE_IDENTIFIER.Trim());
                        }
                        else if (type == "DRG")
                        {
                            returnHash.Add("DRG", CERN_NOMENCLATURE.SOURCE_IDENTIFIER.Trim());
                        }
                    }
                }
            }
            if (type == "PROCEDURE")
            {
                if (returnHash.Contains("TYPE") == false)
                    returnHash.Add("TYPE", "");
                if (returnHash.Contains("PROCCD") == false)
                    returnHash.Add("PROCCD", "");
                if (returnHash.Contains("PROCDESC") == false)
                    returnHash.Add("PROCDESC", "");
            }
            else if (type == "PROCMOD")
            {
                if (returnHash.Contains("PROCMOD") == false)
                    returnHash.Add("PROCMOD", "");
            }
            else if (type == "DIAGNOSIS")
            {
                if (returnHash.Contains("DIAGNOSIS") == false)
                    returnHash.Add("DIAGNOSIS", "");
            }
            else if (type == "DRG")
            {
                if (returnHash.Contains("DRG") == false)
                    returnHash.Add("DRG", "");
            }
            return returnHash;
        }
        private static Hashtable GetProcPhysicians(string procID)
        {
            Hashtable returnHash = new Hashtable();

            ArrayList returnList = CDV.GetPROC_PRSNL_RELTN(procID.Trim(), false);

            for (int x = 0; x < returnList.Count; x++)
            {
                CERN_PROC_PRSNL_RELTN.Clear();
                CERN_PROC_PRSNL_RELTN.SetRecord(returnList[x].ToString());
                if (CERN_PROC_PRSNL_RELTN.ACTIVE_IND.Trim() == "1")
                {
                    if (CERN_PROC_PRSNL_RELTN.PROC_PRSNL_RELTN_CD == "1209")
                        returnHash.Add("PRIMSURG", CERN_PROC_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    else if (CERN_PROC_PRSNL_RELTN.PROC_PRSNL_RELTN_CD == "1347951279")
                        returnHash.Add("ASSISTSURG", CERN_PROC_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                    else if (CERN_PROC_PRSNL_RELTN.PROC_PRSNL_RELTN_CD == "1207")
                        returnHash.Add("ANESTHPHY", CERN_PROC_PRSNL_RELTN.PRSNL_PERSON_ID.Trim());
                }
            }

            if (returnHash.Contains("PRIMSURG") == false)
                returnHash.Add("PRIMSURG", "");
            if (returnHash.Contains("ASSISTSURG") == false)
                returnHash.Add("ASSISTSURG", "");
            if (returnHash.Contains("ANESTHPHY") == false)
                returnHash.Add("ANESTHPHY", "");
            return returnHash;
        }
        private static List<CernerDiagnosis> GetDiagnosis(string enctrID)
        {
            Hashtable nomenHash = new Hashtable();
            List<CernerDiagnosis> dxs = new List<CernerDiagnosis>();

            ArrayList returnList = CDV.GetDIAGNOSIS(enctrID.Trim(), false);

            for (int x = 0; x < returnList.Count; x++)
            {
                CERN_DIAGNOSIS.Clear();
                CERN_DIAGNOSIS.SetRecord(returnList[x].ToString());
                if (CERN_DIAGNOSIS.ACTIVE_IND.Trim() == "1")
                {
                    CernerDiagnosis dx = new CernerDiagnosis();
                    nomenHash = GetNomenclature(CERN_DIAGNOSIS.NOMENCLATURE_ID.Trim(), "DIAGNOSIS");
                    dx.DiagnosisId = CERN_DIAGNOSIS.DIAGNOSIS_ID.Trim();
                    dx.GrouperVersion = "";
                    dx.DxCode = nomenHash["DIAGNOSIS"].ToString().Trim();
                    dx.DxDateTime = HuronRoutines.FormatDT(CERN_DIAGNOSIS.DIAG_DT_TM.Trim(), "date");
                    dx.DxPriority = CERN_DIAGNOSIS.DIAG_PRIORITY.Trim().PadLeft(4, '0');
                    if (global_CodeValue.ContainsKey(CERN_DIAGNOSIS.PRESENT_ON_ADMIT_CD.Trim()) == true)
                        dx.PresentOnAdmit = GePOA(global_CodeValue[CERN_DIAGNOSIS.PRESENT_ON_ADMIT_CD.Trim()].ToString().Trim());
                    else
                        dx.PresentOnAdmit = "";
                    if (global_CodeValue.ContainsKey(CERN_DIAGNOSIS.DIAG_TYPE_CD.Trim()) == true)
                        dx.DxType = global_CodeValue[CERN_DIAGNOSIS.DIAG_TYPE_CD.Trim()].ToString().Trim();
                    else
                        dx.DxType = "";
                    dxs.Add(dx);
                    nomenHash.Clear();
                }
            }
            //dxs = dxs.OrderBy(i => i.DxPriority).ToList();
            return dxs;
        }
        private static string GePOA(string item)
        {
            if (item == "1")
                return "E";
            else if(item == "Y")
                return "Y";
            else if (item == "N")
                return "N";
            else if (item == "U")
                return "U";
            else if (item == "W")
                return "W";
            else
                return "";
        }
            private static List<CernerDRG> GetDRG(string enctrID)
        {
            string altDrg = "";
            string altDRGWeight = "";
            ArrayList newlist = new ArrayList();
            Hashtable nomenHash = new Hashtable();
            Hashtable drgExtHash = new Hashtable();
            List<CernerDRG> drgs = new List<CernerDRG>();

            ArrayList returnList = CDV.GetDRG(enctrID.Trim(), false);

            if(returnList.Count > 1)
            {
                CERN_DRG.Clear();
                CERN_DRG.SetRecord(returnList[1].ToString());

                CernerDRG drg = new CernerDRG();
                nomenHash = GetNomenclature(CERN_DRG.NOMENCLATURE_ID.Trim(), "DRG");
                drgExtHash = GetDRGExtension(nomenHash["DRG"].ToString().Trim());

                altDrg = nomenHash["DRG"].ToString().Trim();
                altDRGWeight = drgExtHash["DRGCOST"].ToString().Trim();
                nomenHash.Clear();
            }

            if(returnList.Count > 0)
            {
                CERN_DRG.Clear();
                CERN_DRG.SetRecord(returnList[0].ToString());
                
                CernerDRG drg = new CernerDRG();
                nomenHash = GetNomenclature(CERN_DRG.NOMENCLATURE_ID.Trim(), "DRG");
                drgExtHash = GetDRGExtension(nomenHash["DRG"].ToString().Trim());
                drg.DRGId = CERN_DRG.DRG_ID.Trim();
                drg.DRGCode = nomenHash["DRG"].ToString().Trim();
                drg.DRGDate = "";// HuronRoutines.FormatDT(CERN_DIAGNOSIS.DIAG_DT_TM.Trim(), "date");
                drg.DRGCostWeight = drgExtHash["DRGCOST"].ToString().Trim();
                drg.DRGAlternate = altDrg;
                drgs.Add(drg);
                nomenHash.Clear();
            }
            //drgs = drgs.OrderByDescending(i => i.DRGDate).ToList();
            return drgs;
        }
        private static Hashtable GetDRGExtension(string sourceCd)
        {
            string drgCostWght = "";
            string expReimb = "";
            Hashtable returnHash = new Hashtable();
            string returnRec = CDV.GetDRG_EXTENSION(sourceCd.Trim(), false);
            CERN_DRG_EXTENSION.Clear();
            CERN_DRG_EXTENSION.SetRecord(returnRec);
            drgCostWght = CERN_DRG_EXTENSION.DRG_WEIGHT;

            if (returnHash.Contains("DRGCOST") == false)
                returnHash.Add("DRGCOST", drgCostWght);
            return returnHash;
        }
        private static string GetCodingStatus(string encntrID)
        {
            string returnVal = "";

            string compDt = CDV.GetCoding(encntrID);
            if (compDt == "" || compDt == "null")
                returnVal = "I";
            else
                returnVal = "F";
            return returnVal;
        }
        private static string GetNameSuffix(string personID)
        {
            string returnVal = "";
            returnVal = CDV.GetPersonSuffix(personID,true);
            return returnVal;
        }
        private static string GetPatStatus(string sts)
        {
            string returnVal = "";
            string inVal = "275211141,278957611,309310,309308,276161159,279088653,309312,309311,309309,19962820,3012539,309314,24083578,278957619,4053630,634622,400,33548035,40161267,19962609,33536035";
            string outVal = "REF,CLI,ER,IN,ER,IN,INO,SDC,CLI,CLI,CLI,RCR,IN,CLI,CLI,CLI,CLI,CLI,CLI,CLI,CLI";
            string[] recs = inVal.Split(',');
            string[] outRecs = outVal.Split(',');
            for (int i = 0; i < recs.Length; i++)
            {
                if (recs[i] == sts)
                {
                    returnVal = outRecs[i];
                    break;
                }
            }
            return returnVal;
        }
        private static void SetGrouperVersion(DateTime? dischargeDate)
        {
            if (dischargeDate >= new DateTime(2015, 10, 01) && dischargeDate <= new DateTime(2016, 9, 30))
                global_GrouperVersion = "33";
            else if (dischargeDate >= new DateTime(2016, 10, 1) && dischargeDate <= new DateTime(2017, 9, 30))
                global_GrouperVersion = "34";
            else if (dischargeDate >= new DateTime(2017, 10, 1) && dischargeDate <= new DateTime(2018, 9, 30))
                global_GrouperVersion = "35";
            else if (dischargeDate >= new DateTime(2018, 10, 1) && dischargeDate <= new DateTime(2019, 9, 30))
                global_GrouperVersion = "36";
            else if (dischargeDate >= new DateTime(2019, 10, 1) && dischargeDate <= new DateTime(2020, 9, 30))
                global_GrouperVersion = "37";
        }
        public static DateTime? GetCernerDate(string dateValue, string hcis)
        {
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
            return dt2;
        }
        public static string GetHCISTimeZone(string hcis)
        {
            string result = string.Empty;
            if (hcis == "SHAZ" || hcis == "SHUT")
                result = "US Mountain Standard Time";
            else
                result = "Central Standard Time";

            return result;
        }
        public static DateTime? GetCernerDate(string dateValue)
        {
            string AMPM = "";
            string item = "";
            DateTime? result = null;
            if (dateValue.Trim().Length > 0 && dateValue != "null")
            {
                if (dateValue.Contains("AM") == true || dateValue.Contains("PM") == true)
                {
                    DateTime dt = DateTime.Parse(dateValue);
                    if (dateValue.Contains("AM") == true)
                        AMPM = "AM";

                    else if (dateValue.Contains("PM") == true)
                    {
                        AMPM = "PM";
                        if (dt.Hour >= 21)
                            item = item;
                    }
                    item = dt.Month.ToString().PadLeft(2, '0') + "/" + dt.Day.ToString().PadLeft(2, '0') + "/" + dt.Year.ToString() + " " + dt.Hour.ToString().PadLeft(2, '0') + ":" + dt.Minute.ToString().PadLeft(2, '0') + ":" + dt.Second.ToString().PadLeft(2, '0') + " " + AMPM;

                    result = DateTime.ParseExact(item, "MM/dd/yyyy HH:mm:ss tt", CultureInfo.CurrentCulture);
                    //result = DateTime.ParseExact(dateValue, "M/d/yyyy H:m:s tt", CultureInfo.CurrentCulture); //DateTime.ParseExact(dateValue, "M/d/yyyy HH:mm:ss tt", CultureInfo.CurrentCulture);
                }
                else if (dateValue.Contains(":") == false)
                    result = DateTime.ParseExact(dateValue, "M/d/yyyy", CultureInfo.CurrentCulture);
                else
                    result = DateTime.ParseExact(dateValue, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture);
            }
            return result;
        }
        public static string GetCernerDate2(string dateValue, string hcis)
        {
            string newdt = "";
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
            {
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
                if (hcis == "SHAZ" || hcis == "SHUT")
                {
                    if (dt2.Value.Hour > 22)
                        newdt = newdt;
                    DateTime dt3 = (DateTime)dt2;
                    //dt3 = dt3.AddHours(3);
                    dt2 = dt3;
                }
                newdt = dt2.Value.Year.ToString() + dt2.Value.Month.ToString().PadLeft(2, '0').Trim() + dt2.Value.Day.ToString().PadLeft(2, '0').Trim();
            }
            return newdt;
        }
        public static string GetCernerTime(string dateValue, string hcis)
        {
            string newdt = "";
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = GetCernerDate(dateValue);
            if (dt.HasValue)
            {

                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
                if (hcis == "SHAZ" || hcis == "SHUT")
                {
                    if (dt2.Value.Hour > 22)
                        newdt = newdt;
                    DateTime dt3 = (DateTime)dt2;
                    //dt3 = dt3.AddHours(3);
                    dt2 = dt3;
                }
                newdt = dt2.Value.Hour.ToString().PadLeft(2, '0').Trim() + dt2.Value.Minute.ToString().PadLeft(2, '0').Trim();
            }
            return newdt;
        }

        //internal static DateTime? GetCernerDateWithTZ(string dateValue, string hcis, string tz)
        //{
        //    DateTime? dt2 = null;
        //    if (tz.Trim().Length > 0 && tz.Trim() != ".0000")
        //    {
        //        string timeZone = CernerMapDAL.GetMap("CERNER_TIMEZONE", tz, string.Empty);
        //        //if (timeZone.Trim().Length == 0)
        //        //    timeZone = "UTC";

        //        TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
        //        DateTime? dt = GetCernerDate(dateValue);
        //        if (dt.HasValue)
        //            dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
        //    }
        //    else
        //    {
        //        string timeZone = GetHCISTimeZone(hcis);
        //        TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
        //        DateTime? dt = GetCernerDate(dateValue);
        //        if (dt.HasValue)
        //            dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
        //    }
        //    return dt2;

        //}

    }
}