using System;
using System.Collections;
namespace Huron
{
    /// <summary>
    /// Summary description for Casemix Struct.
    /// </summary>
    public class HuronCaseMixStruct
    {
        private static string GetString(string str, int length)
        {
            str = str.PadRight(length, ' ');
            str = str.Substring(0, length);
            return str;
        }
        public struct HEADER
        {
            private string RECORDTYPE;
            private string TAPEHEADER;
            private string ORIGINATING_MIS;
            private string CREATIONDATE;
            public void Clear()
            {
                RECORDTYPE = "";
                TAPEHEADER = "";
                ORIGINATING_MIS = "";
                CREATIONDATE = "";

            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string TapeHeader
            {
                get { return TAPEHEADER; }
                set { TAPEHEADER = value; }
            }
            public string CreationDate
            {
                get { return CREATIONDATE; }
                set { CREATIONDATE = value; }
            }
            public string OriginatingMIS
            {
                get { return ORIGINATING_MIS; }
                set { ORIGINATING_MIS = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                TAPEHEADER = HuronCaseMixStruct.GetString(TAPEHEADER, 70);
                CREATIONDATE = HuronCaseMixStruct.GetString(CREATIONDATE, 8);
                ORIGINATING_MIS = HuronCaseMixStruct.GetString(ORIGINATING_MIS, 20);
                outRec = RECORDTYPE + TAPEHEADER + CREATIONDATE + ORIGINATING_MIS;
                return outRec;
            }
        }
        public struct DEMOGRAPHIC_DATA
        {
            private string RECORDTYPE;
            private string ACCOUNTNUMBER;
            private string MEDICALRECORDNUMBER;
            private string FACILITY;
            private string ADMPATMRN;
            private string MRIPATMRN;
            private string PATIENTNAME;
            private string ADMITDATE;
            private string ADMITTIME;
            private string SERVICEDATE;
            private string SERVICETTIME;
            private string RESERVATIONDATE;
            private string DISCHARGEDATE;
            private string DISCHARGETIME;
            private string PATIENTSTATUS;
            private string LOCATION;
            private string FINANCIALCLASS;
            private string SEX;
            private string BIRTHDATE;
            private string RACE;
            private string MARITALSTATUS;
            private string ZIPCODE;
            private string SOCSECNUMBER;
            private string MOTHERACCTNBR;
            private string MOTHERADMPATURN;
            private string WEIGHTGRAMS;
            private string ARRIVEDATE;
            private string ARRIVETIME;
            private string SPACEFILL;
            public void Clear()
            {
                RECORDTYPE = "";
                ACCOUNTNUMBER = "";
                MEDICALRECORDNUMBER = "";
                FACILITY = "";
                ADMPATMRN = "";
                MRIPATMRN = "";
                PATIENTNAME = "";
                ADMITDATE = "";
                ADMITTIME = "";
                SERVICEDATE = "";
                SERVICETTIME = "";
                RESERVATIONDATE = "";
                DISCHARGEDATE = "";
                DISCHARGETIME = "";
                PATIENTSTATUS = "";
                LOCATION = "";
                FINANCIALCLASS = "";
                SEX = "";
                BIRTHDATE = "";
                RACE = "";
                MARITALSTATUS = "";
                ZIPCODE = "";
                SOCSECNUMBER = "";
                MOTHERACCTNBR = "";
                MOTHERADMPATURN = "";
                WEIGHTGRAMS = "";
                ARRIVEDATE = "";
                ARRIVETIME = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string AccountNumber
            {
                get { return ACCOUNTNUMBER; }
                set { ACCOUNTNUMBER = value; }
            }
            public string MedicalRecordNumber
            {
                get { return MEDICALRECORDNUMBER; }
                set { MEDICALRECORDNUMBER = value; }
            }
            public string Facility
            {
                get { return FACILITY; }
                set { FACILITY = value; }
            }
            public string AdmPatMrn
            {
                get { return ADMPATMRN; }
                set { ADMPATMRN = value; }
            }
            public string MRIPatMRN
            {
                get { return MRIPATMRN; }
                set { MRIPATMRN = value; }
            }
            public string PatientName
            {
                get { return PATIENTNAME; }
                set { PATIENTNAME = value; }
            }
            public string AdmitDate
            {
                get { return ADMITDATE; }
                set { ADMITDATE = value; }
            }
            public string AdmitTime
            {
                get { return ADMITTIME; }
                set { ADMITTIME = value; }
            }
            public string ServiceDate
            {
                get { return SERVICEDATE; }
                set { SERVICEDATE = value; }
            }
            public string ServiceTime
            {
                get { return SERVICETTIME; }
                set { SERVICETTIME = value; }
            }
            public string ReservationDate
            {
                get { return RESERVATIONDATE; }
                set { RESERVATIONDATE = value; }
            }
            public string DischargeDate
            {
                get { return DISCHARGEDATE; }
                set { DISCHARGEDATE = value; }
            }
            public string DischargeTime
            {
                get { return DISCHARGETIME; }
                set { DISCHARGETIME = value; }
            }
            public string PatientStatus
            {
                get { return PATIENTSTATUS; }
                set { PATIENTSTATUS = value; }
            }
            public string Location
            {
                get { return LOCATION; }
                set { LOCATION = value; }
            }
            public string FinancialClass
            {
                get { return FINANCIALCLASS; }
                set { FINANCIALCLASS = value; }
            }
            public string Sex
            {
                get { return SEX; }
                set { SEX = value; }
            }
            public string Birthdate
            {
                get { return BIRTHDATE; }
                set { BIRTHDATE = value; }
            }
            public string Race
            {
                get { return RACE; }
                set { RACE = value; }
            }
            public string MaritalStatus
            {
                get { return MARITALSTATUS; }
                set { MARITALSTATUS = value; }
            }
            public string ZipCode
            {
                get { return ZIPCODE; }
                set { ZIPCODE = value; }
            }
            public string SocSecNumber
            {
                get { return SOCSECNUMBER; }
                set { SOCSECNUMBER = value; }
            }
            public string MotherAcctNumber
            {
                get { return MOTHERACCTNBR; }
                set { MOTHERACCTNBR = value; }
            }
            public string MotherAdmPatURN
            {
                get { return MOTHERADMPATURN; }
                set { MOTHERADMPATURN = value; }
            }
            public string WeightGrams
            {
                get { return WEIGHTGRAMS; }
                set { WEIGHTGRAMS = value; }
            }
            public string ArriveDate
            {
                get { return ARRIVEDATE; }
                set { ARRIVEDATE = value; }
            }
            public string ArriveTime
            {
                get { return ARRIVETIME; }
                set { ARRIVETIME = value; }
            }
            public string SpaceFill
            {
                get { return SPACEFILL; }
                set { SPACEFILL = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                ACCOUNTNUMBER = HuronCaseMixStruct.GetString(ACCOUNTNUMBER, 12);
                MEDICALRECORDNUMBER = HuronCaseMixStruct.GetString(MEDICALRECORDNUMBER, 12);
                FACILITY = HuronCaseMixStruct.GetString(FACILITY, 10);
                ADMPATMRN = HuronCaseMixStruct.GetString(ADMPATMRN, 25);
                MRIPATMRN = HuronCaseMixStruct.GetString(MRIPATMRN, 25);
                PATIENTNAME = HuronCaseMixStruct.GetString(PATIENTNAME, 30);
                ADMITDATE = HuronCaseMixStruct.GetString(ADMITDATE, 8);
                ADMITTIME = HuronCaseMixStruct.GetString(ADMITTIME, 4);
                SERVICEDATE = HuronCaseMixStruct.GetString(SERVICEDATE, 8);
                SERVICETTIME = HuronCaseMixStruct.GetString(SERVICETTIME, 4);
                RESERVATIONDATE = HuronCaseMixStruct.GetString(RESERVATIONDATE, 8);
                DISCHARGEDATE = HuronCaseMixStruct.GetString(DISCHARGEDATE, 8);
                DISCHARGETIME = HuronCaseMixStruct.GetString(DISCHARGETIME, 4);
                PATIENTSTATUS = HuronCaseMixStruct.GetString(PATIENTSTATUS, 3);
                LOCATION = HuronCaseMixStruct.GetString(LOCATION, 10);
                FINANCIALCLASS = HuronCaseMixStruct.GetString(FINANCIALCLASS, 10);
                SEX = HuronCaseMixStruct.GetString(SEX, 1);
                BIRTHDATE = HuronCaseMixStruct.GetString(BIRTHDATE, 8);
                RACE = HuronCaseMixStruct.GetString(RACE, 10);
                MARITALSTATUS = HuronCaseMixStruct.GetString(MARITALSTATUS, 10);
                ZIPCODE = HuronCaseMixStruct.GetString(ZIPCODE, 10);
                SOCSECNUMBER = HuronCaseMixStruct.GetString(SOCSECNUMBER, 15);
                MOTHERACCTNBR = HuronCaseMixStruct.GetString(MOTHERACCTNBR, 12);
                MOTHERADMPATURN = HuronCaseMixStruct.GetString(MOTHERADMPATURN, 20);
                WEIGHTGRAMS = HuronCaseMixStruct.GetString(WEIGHTGRAMS, 5);
                ARRIVEDATE = HuronCaseMixStruct.GetString(ARRIVEDATE, 8);
                ARRIVETIME = HuronCaseMixStruct.GetString(ARRIVETIME, 4);
                outRec = RECORDTYPE + ACCOUNTNUMBER + MEDICALRECORDNUMBER + FACILITY + ADMPATMRN + MRIPATMRN + PATIENTNAME + ADMITDATE + ADMITTIME + SERVICEDATE + SERVICETTIME + RESERVATIONDATE + DISCHARGEDATE + DISCHARGETIME + PATIENTSTATUS + LOCATION + FINANCIALCLASS + SEX + BIRTHDATE + RACE + MARITALSTATUS + ZIPCODE + SOCSECNUMBER + MOTHERACCTNBR + MOTHERADMPATURN + WEIGHTGRAMS + ARRIVEDATE + ARRIVETIME;
                return outRec;
            }
        }
        public struct REGISTRATION_DATA
        {
            private string RECORDTYPE;
            private string ADMISSIONADMITPRIORITY;
            private string OUTPATIENTARRIVALMODE;
            private string ADMITSOURCE;
            private string ADMITTEDTHROUGHER;
            private string LASTDISCHARGEDATE;
            private string EXPECTEDLENGTHOFSTAY;
            private string REASONFORVISIT;
            private string DISCHARGEDISPOSITION;
            private string WITHIN48HOURSOFADMISSION;
            private string INORORPOSTOP;
            private string AUTOPSYOBTAINED;
            private string MEDICALEXAMINERCASE;
            private string OBSERVATIONPATIENT;
            private string OBSERVATIONDATE;
            private string ERARRDATE;
            private string ERARRTIME;
            private string ERTRIAGEDATE;
            private string ERTRIAGETIME;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                ADMISSIONADMITPRIORITY = "";
                OUTPATIENTARRIVALMODE = "";
                ADMITSOURCE = "";
                ADMITTEDTHROUGHER = "";
                LASTDISCHARGEDATE = "";
                EXPECTEDLENGTHOFSTAY = "";
                REASONFORVISIT = "";
                DISCHARGEDISPOSITION = "";
                WITHIN48HOURSOFADMISSION = "";
                INORORPOSTOP = "";
                AUTOPSYOBTAINED = "";
                MEDICALEXAMINERCASE = "";
                OBSERVATIONPATIENT = "";
                OBSERVATIONDATE = "";
                ERARRDATE = "";
                ERARRTIME = "";
                ERTRIAGEDATE = "";
                ERTRIAGETIME = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string AdmissionAdmitPriority
            {
                get { return ADMISSIONADMITPRIORITY; }
                set { ADMISSIONADMITPRIORITY = value; }
            }
            public string OutpatientArrivalMode
            {
                get { return OUTPATIENTARRIVALMODE; }
                set { OUTPATIENTARRIVALMODE = value; }
            }
            public string AdmitSource
            {
                get { return ADMITSOURCE; }
                set { ADMITSOURCE = value; }
            }
            public string AdmittedThroughER
            {
                get { return ADMITTEDTHROUGHER; }
                set { ADMITTEDTHROUGHER = value; }
            }
            public string LastDischargeDate
            {
                get { return LASTDISCHARGEDATE; }
                set { LASTDISCHARGEDATE = value; }
            }
            public string ExpectedLengthofStay
            {
                get { return EXPECTEDLENGTHOFSTAY; }
                set { EXPECTEDLENGTHOFSTAY = value; }
            }
            public string ReasonforVisit
            {
                get { return REASONFORVISIT; }
                set { REASONFORVISIT = value; }
            }
            public string DischargeDisposition
            {
                get { return DISCHARGEDISPOSITION; }
                set { DISCHARGEDISPOSITION = value; }
            }
            public string Within48HoursofAdmission
            {
                get { return WITHIN48HOURSOFADMISSION; }
                set { WITHIN48HOURSOFADMISSION = value; }
            }
            public string InORorPostOP
            {
                get { return INORORPOSTOP; }
                set { INORORPOSTOP = value; }
            }
            public string AutopsyObtained
            {
                get { return AUTOPSYOBTAINED; }
                set { AUTOPSYOBTAINED = value; }
            }
            public string MedicalExaminerCase
            {
                get { return MEDICALEXAMINERCASE; }
                set { MEDICALEXAMINERCASE = value; }
            }
            public string ObservationPatient
            {
                get { return OBSERVATIONPATIENT; }
                set { OBSERVATIONPATIENT = value; }
            }
            public string ObservationDate
            {
                get { return OBSERVATIONDATE; }
                set { OBSERVATIONDATE = value; }
            }
            public string ERArrDate
            {
                get { return ERARRDATE; }
                set { ERARRDATE = value; }
            }
            public string ERArrTime
            {
                get { return ERARRTIME; }
                set { ERARRTIME = value; }
            }
            public string ERTriageDate
            {
                get { return ERTRIAGEDATE; }
                set { ERTRIAGEDATE = value; }
            }
            public string ERTriageTime
            {
                get { return ERTRIAGETIME; }
                set { ERTRIAGETIME = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                ADMISSIONADMITPRIORITY = HuronCaseMixStruct.GetString(ADMISSIONADMITPRIORITY, 10);
                OUTPATIENTARRIVALMODE = HuronCaseMixStruct.GetString(OUTPATIENTARRIVALMODE, 10);
                ADMITSOURCE = HuronCaseMixStruct.GetString(ADMITSOURCE, 10);
                ADMITTEDTHROUGHER = HuronCaseMixStruct.GetString(ADMITTEDTHROUGHER, 1);
                LASTDISCHARGEDATE = HuronCaseMixStruct.GetString(LASTDISCHARGEDATE, 8);
                EXPECTEDLENGTHOFSTAY = HuronCaseMixStruct.GetString(EXPECTEDLENGTHOFSTAY, 4);
                REASONFORVISIT = HuronCaseMixStruct.GetString(REASONFORVISIT, 50);
                DISCHARGEDISPOSITION = HuronCaseMixStruct.GetString(DISCHARGEDISPOSITION, 10);
                WITHIN48HOURSOFADMISSION = HuronCaseMixStruct.GetString(WITHIN48HOURSOFADMISSION, 1);
                INORORPOSTOP = HuronCaseMixStruct.GetString(INORORPOSTOP, 1);
                AUTOPSYOBTAINED = HuronCaseMixStruct.GetString(AUTOPSYOBTAINED, 1);
                MEDICALEXAMINERCASE = HuronCaseMixStruct.GetString(MEDICALEXAMINERCASE, 1);
                OBSERVATIONPATIENT = HuronCaseMixStruct.GetString(OBSERVATIONPATIENT, 1);
                OBSERVATIONDATE = HuronCaseMixStruct.GetString(OBSERVATIONDATE, 8);
                ERARRDATE = HuronCaseMixStruct.GetString(ERARRDATE, 8);
                ERARRTIME = HuronCaseMixStruct.GetString(ERARRTIME, 4);
                ERTRIAGEDATE = HuronCaseMixStruct.GetString(ERTRIAGEDATE, 8);
                ERTRIAGETIME = HuronCaseMixStruct.GetString(ERTRIAGETIME, 4);
                outRec = RECORDTYPE + ADMISSIONADMITPRIORITY + ADMITSOURCE + OUTPATIENTARRIVALMODE + ADMITTEDTHROUGHER + LASTDISCHARGEDATE + EXPECTEDLENGTHOFSTAY + REASONFORVISIT + DISCHARGEDISPOSITION + WITHIN48HOURSOFADMISSION + INORORPOSTOP + AUTOPSYOBTAINED + MEDICALEXAMINERCASE + OBSERVATIONPATIENT + OBSERVATIONDATE + ERARRDATE + ERARRTIME + ERTRIAGEDATE + ERTRIAGETIME;
                return outRec;
            }
        }
        public struct PROVIDER_DATA
        {
            private string RECORDTYPE;
            private string PRIMARYCAREPHYSICIAN;
            private string PRIMCARESERVICE;
            private string PRIMCARETYPE;
            private string ADMITTINGPHYSICIAN;
            private string ADMPHYSERVICE;
            private string ADMPHYTYPE;
            private string ATTENDINGPHYSICIAN;
            private string ATTENDPHYSERV;
            private string ATTENDPHYTYPE;
            private string FAMILYPHYSICIAN;
            private string FAMPHYSERV;
            private string FAMPHYTYPE;
            private string ERPHYSICIAN;
            private string ERPHYSERV;
            private string ERPHYTYPE;
            private string REFERRINGPHYSICIAN;
            private string REFPHYSERV;
            private string REFPHYTYPE;
            public void Clear()
            {
                RECORDTYPE = "";
                PRIMARYCAREPHYSICIAN = "";
                PRIMCARESERVICE = "";
                PRIMCARETYPE = "";
                ADMITTINGPHYSICIAN = "";
                ADMPHYSERVICE = "";
                ADMPHYTYPE = "";
                ATTENDINGPHYSICIAN = "";
                ATTENDPHYSERV = "";
                ATTENDPHYTYPE = "";
                FAMILYPHYSICIAN = "";
                FAMPHYSERV = "";
                FAMPHYTYPE = "";
                ERPHYSICIAN = "";
                ERPHYSERV = "";
                ERPHYTYPE = "";
                REFERRINGPHYSICIAN = "";
                REFPHYSERV = "";
                REFPHYTYPE = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string PrimaryCarePhysician
            {
                get { return PRIMARYCAREPHYSICIAN; }
                set { PRIMARYCAREPHYSICIAN = value; }
            }
            public string PrimaryCareService
            {
                get { return PRIMCARESERVICE; }
                set { PRIMCARESERVICE = value; }
            }
            public string PrimaryCareType
            {
                get { return PRIMCARETYPE; }
                set { PRIMCARETYPE = value; }
            }
            public string AdmittingPhysician
            {
                get { return ADMITTINGPHYSICIAN; }
                set { ADMITTINGPHYSICIAN = value; }
            }
            public string AdmittingPhysicianService
            {
                get { return ADMPHYSERVICE; }
                set { ADMPHYSERVICE = value; }
            }
            public string AdmittingPhysicianType
            {
                get { return ADMPHYTYPE; }
                set { ADMPHYTYPE = value; }
            }
            public string AttendingPhysician
            {
                get { return ATTENDINGPHYSICIAN; }
                set { ATTENDINGPHYSICIAN = value; }
            }
            public string AttendingPhysicianServ
            {
                get { return ATTENDPHYSERV; }
                set { ATTENDPHYSERV = value; }
            }
            public string AttendingPhysicianType
            {
                get { return ATTENDPHYTYPE; }
                set { ATTENDPHYTYPE = value; }
            }
            public string FamilyPhysician
            {
                get { return FAMILYPHYSICIAN; }
                set { FAMILYPHYSICIAN = value; }
            }
            public string FamilyPhysicianService
            {
                get { return FAMPHYSERV; }
                set { FAMPHYSERV = value; }
            }
            public string FamilyPhysicianType
            {
                get { return FAMPHYTYPE; }
                set { FAMPHYTYPE = value; }
            }
            public string ERPhysician
            {
                get { return ERPHYSICIAN; }
                set { ERPHYSICIAN = value; }
            }
            public string ERPhysicianService
            {
                get { return ERPHYSERV; }
                set { ERPHYSERV = value; }
            }
            public string ERPhysicianType
            {
                get { return ERPHYTYPE; }
                set { ERPHYTYPE = value; }
            }
            public string ReferringPhysician
            {
                get { return REFERRINGPHYSICIAN; }
                set { REFERRINGPHYSICIAN = value; }
            }
            public string ReferringPhysicianService
            {
                get { return REFPHYSERV; }
                set { REFPHYSERV = value; }
            }
            public string ReferringPhysicianType
            {
                get { return REFPHYTYPE; }
                set { REFPHYTYPE = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                PRIMARYCAREPHYSICIAN = HuronCaseMixStruct.GetString(PRIMARYCAREPHYSICIAN, 30);
                PRIMCARESERVICE = HuronCaseMixStruct.GetString(PRIMCARESERVICE, 10);
                PRIMCARETYPE = HuronCaseMixStruct.GetString(PRIMCARETYPE, 10);
                ADMITTINGPHYSICIAN = HuronCaseMixStruct.GetString(ADMITTINGPHYSICIAN, 30);
                ADMPHYSERVICE = HuronCaseMixStruct.GetString(ADMPHYSERVICE, 10);
                ADMPHYTYPE = HuronCaseMixStruct.GetString(ADMPHYTYPE, 10);
                ATTENDINGPHYSICIAN = HuronCaseMixStruct.GetString(ATTENDINGPHYSICIAN, 30);
                ATTENDPHYSERV = HuronCaseMixStruct.GetString(ATTENDPHYSERV, 10);
                ATTENDPHYTYPE = HuronCaseMixStruct.GetString(ATTENDPHYTYPE, 10);
                FAMILYPHYSICIAN = HuronCaseMixStruct.GetString(FAMILYPHYSICIAN, 30);
                FAMPHYSERV = HuronCaseMixStruct.GetString(FAMPHYSERV, 10);
                FAMPHYTYPE = HuronCaseMixStruct.GetString(FAMPHYTYPE, 10);
                ERPHYSICIAN = HuronCaseMixStruct.GetString(ERPHYSICIAN, 30);
                ERPHYSERV = HuronCaseMixStruct.GetString(ERPHYSERV, 10);
                ERPHYTYPE = HuronCaseMixStruct.GetString(ERPHYTYPE, 10);
                REFERRINGPHYSICIAN = HuronCaseMixStruct.GetString(REFERRINGPHYSICIAN, 30);
                REFPHYSERV = HuronCaseMixStruct.GetString(REFPHYSERV, 10);
                REFPHYTYPE = HuronCaseMixStruct.GetString(REFPHYTYPE, 10);
                outRec = RECORDTYPE + PRIMARYCAREPHYSICIAN + PRIMCARESERVICE + PRIMCARETYPE + ADMITTINGPHYSICIAN + ADMPHYSERVICE + ADMPHYTYPE + ATTENDINGPHYSICIAN + ATTENDPHYSERV + ATTENDPHYTYPE + FAMILYPHYSICIAN + FAMPHYSERV + FAMPHYTYPE + ERPHYSICIAN + ERPHYSERV + ERPHYTYPE + REFERRINGPHYSICIAN + REFPHYSERV + REFPHYTYPE;
                return outRec;
            }
        }
        public struct OTHER_PROVIDERS_DATA
        {
            private string RECORDTYPE;
            private string OTHERPROVIDER1;
            private string OTHERPROVIDERSERV1;
            private string OTHERPROVIDERTYPE1;
            private string OTHERPROVIDERDATE1;
            private string OTHERPROVIDER2;
            private string OTHERPROVIDERSERV2;
            private string OTHERPROVIDERTYPE2;
            private string OTHERPROVIDERDATE2;
            private string OTHERPROVIDER3;
            private string OTHERPROVIDERSERV3;
            private string OTHERPROVIDERTYPE3;
            private string OTHERPROVIDERDATE3;
            private string OTHERPROVIDER4;
            private string OTHERPROVIDERSERV4;
            private string OTHERPROVIDERTYPE4;
            private string OTHERPROVIDERDATE4;
            private string OTHERPROVIDER5;
            private string OTHERPROVIDERSERV5;
            private string OTHERPROVIDERTYPE5;
            private string OTHERPROVIDERDATE5;
            public void Clear()
            {
                RECORDTYPE = "";
                OTHERPROVIDER1 = "";
                OTHERPROVIDERSERV1 = "";
                OTHERPROVIDERTYPE1 = "";
                OTHERPROVIDERDATE1 = "";
                OTHERPROVIDER2 = "";
                OTHERPROVIDERSERV2 = "";
                OTHERPROVIDERTYPE2 = "";
                OTHERPROVIDERDATE2 = "";
                OTHERPROVIDER3 = "";
                OTHERPROVIDERSERV3 = "";
                OTHERPROVIDERTYPE3 = "";
                OTHERPROVIDERDATE3 = "";
                OTHERPROVIDER4 = "";
                OTHERPROVIDERSERV4 = "";
                OTHERPROVIDERTYPE4 = "";
                OTHERPROVIDERDATE4 = "";
                OTHERPROVIDER5 = "";
                OTHERPROVIDERSERV5 = "";
                OTHERPROVIDERTYPE5 = "";
                OTHERPROVIDERDATE5 = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string OtherProvider1
            {
                get { return OTHERPROVIDER1; }
                set { OTHERPROVIDER1 = value; }
            }
            public string OtherProviderService1
            {
                get { return OTHERPROVIDERSERV1; }
                set { OTHERPROVIDERSERV1 = value; }
            }
            public string OtherProviderType1
            {
                get { return OTHERPROVIDERTYPE1; }
                set { OTHERPROVIDERTYPE1 = value; }
            }
            public string OtherProviderDate1
            {
                get { return OTHERPROVIDERDATE1; }
                set { OTHERPROVIDERDATE1 = value; }
            }
            public string OtherProvider2
            {
                get { return OTHERPROVIDER2; }
                set { OTHERPROVIDER2 = value; }
            }
            public string OtherProviderService2
            {
                get { return OTHERPROVIDERSERV2; }
                set { OTHERPROVIDERSERV2 = value; }
            }
            public string OtherProviderType2
            {
                get { return OTHERPROVIDERTYPE2; }
                set { OTHERPROVIDERTYPE2 = value; }
            }
            public string OtherProviderDate2
            {
                get { return OTHERPROVIDERDATE2; }
                set { OTHERPROVIDERDATE2 = value; }
            }
            public string OtherProvider3
            {
                get { return OTHERPROVIDER3; }
                set { OTHERPROVIDER3 = value; }
            }
            public string OtherProviderService3
            {
                get { return OTHERPROVIDERSERV3; }
                set { OTHERPROVIDERSERV3 = value; }
            }
            public string OtherProviderType3
            {
                get { return OTHERPROVIDERTYPE3; }
                set { OTHERPROVIDERTYPE3 = value; }
            }
            public string OtherProviderDate3
            {
                get { return OTHERPROVIDERDATE3; }
                set { OTHERPROVIDERDATE3 = value; }
            }
            public string OtherProvider4
            {
                get { return OTHERPROVIDER4; }
                set { OTHERPROVIDER4 = value; }
            }
            public string OtherProviderService4
            {
                get { return OTHERPROVIDERSERV4; }
                set { OTHERPROVIDERSERV4 = value; }
            }
            public string OtherProviderType4
            {
                get { return OTHERPROVIDERTYPE4; }
                set { OTHERPROVIDERTYPE4 = value; }
            }
            public string OtherProviderDate4
            {
                get { return OTHERPROVIDERDATE4; }
                set { OTHERPROVIDERDATE4 = value; }
            }
            public string OtherProvider5
            {
                get { return OTHERPROVIDER5; }
                set { OTHERPROVIDER5 = value; }
            }
            public string OtherProviderService5
            {
                get { return OTHERPROVIDERSERV5; }
                set { OTHERPROVIDERSERV5 = value; }
            }
            public string OtherProviderType5
            {
                get { return OTHERPROVIDERTYPE5; }
                set { OTHERPROVIDERTYPE5 = value; }
            }
            public string OtherProviderDate5
            {
                get { return OTHERPROVIDERDATE5; }
                set { OTHERPROVIDERDATE5 = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                OTHERPROVIDER1 = HuronCaseMixStruct.GetString(OTHERPROVIDER1, 30);
                OTHERPROVIDERSERV1 = HuronCaseMixStruct.GetString(OTHERPROVIDERSERV1, 10);
                OTHERPROVIDERTYPE1 = HuronCaseMixStruct.GetString(OTHERPROVIDERTYPE1, 10);
                OTHERPROVIDERDATE1 = HuronCaseMixStruct.GetString(OTHERPROVIDERDATE1, 8);
                OTHERPROVIDER2 = HuronCaseMixStruct.GetString(OTHERPROVIDER2, 30);
                OTHERPROVIDERSERV2 = HuronCaseMixStruct.GetString(OTHERPROVIDERSERV2, 10);
                OTHERPROVIDERTYPE2 = HuronCaseMixStruct.GetString(OTHERPROVIDERTYPE2, 10);
                OTHERPROVIDERDATE2 = HuronCaseMixStruct.GetString(OTHERPROVIDERDATE2, 8);
                OTHERPROVIDER3 = HuronCaseMixStruct.GetString(OTHERPROVIDER3, 30);
                OTHERPROVIDERSERV3 = HuronCaseMixStruct.GetString(OTHERPROVIDERSERV3, 10);
                OTHERPROVIDERTYPE3 = HuronCaseMixStruct.GetString(OTHERPROVIDERTYPE3, 10);
                OTHERPROVIDERDATE3 = HuronCaseMixStruct.GetString(OTHERPROVIDERDATE3, 8);
                OTHERPROVIDER4 = HuronCaseMixStruct.GetString(OTHERPROVIDER4, 30);
                OTHERPROVIDERSERV4 = HuronCaseMixStruct.GetString(OTHERPROVIDERSERV4, 10);
                OTHERPROVIDERTYPE4 = HuronCaseMixStruct.GetString(OTHERPROVIDERTYPE4, 10);
                OTHERPROVIDERDATE4 = HuronCaseMixStruct.GetString(OTHERPROVIDERDATE4, 8);
                OTHERPROVIDER5 = HuronCaseMixStruct.GetString(OTHERPROVIDER5, 30);
                OTHERPROVIDERSERV5 = HuronCaseMixStruct.GetString(OTHERPROVIDERSERV5, 10);
                OTHERPROVIDERTYPE5 = HuronCaseMixStruct.GetString(OTHERPROVIDERTYPE5, 10);
                OTHERPROVIDERDATE5 = HuronCaseMixStruct.GetString(OTHERPROVIDERDATE5, 8);
                outRec = RECORDTYPE + OTHERPROVIDER1 + OTHERPROVIDERSERV1 + OTHERPROVIDERTYPE1 + OTHERPROVIDERDATE1 + OTHERPROVIDER2 + OTHERPROVIDERSERV2 + OTHERPROVIDERTYPE2 + OTHERPROVIDERDATE2 + OTHERPROVIDER3 + OTHERPROVIDERSERV3 + OTHERPROVIDERTYPE3 + OTHERPROVIDERDATE3 + OTHERPROVIDER4 + OTHERPROVIDERSERV4 + OTHERPROVIDERTYPE4 + OTHERPROVIDERDATE4 + OTHERPROVIDER5 + OTHERPROVIDERSERV5 + OTHERPROVIDERTYPE5 + OTHERPROVIDERDATE5;
                return outRec;
            }
        }
        public struct SERVICES_DATA
        {
            private string RECORDTYPE;
            private string ABSSERVICE1;
            private string SERVICESTARTDATE1;
            private string SERVICEDAYS1;
            private string MAINSERVICE1;

            public void Clear()
            {
                RECORDTYPE = "";
                ABSSERVICE1 = "";
                SERVICESTARTDATE1 = "";
                SERVICEDAYS1 = "";
                MAINSERVICE1 = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string AbsService1
            {
                get { return ABSSERVICE1; }
                set { ABSSERVICE1 = value; }
            }
            public string ServiceStartDate1
            {
                get { return SERVICESTARTDATE1; }
                set { SERVICESTARTDATE1 = value; }
            }
            public string ServiceDays1
            {
                get { return SERVICEDAYS1; }
                set { SERVICEDAYS1 = value; }
            }
            public string MainService1
            {
                get { return MAINSERVICE1; }
                set { MAINSERVICE1 = value; }
            }

            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                ABSSERVICE1 = HuronCaseMixStruct.GetString(ABSSERVICE1, 10);
                SERVICESTARTDATE1 = HuronCaseMixStruct.GetString(SERVICESTARTDATE1, 8);
                SERVICEDAYS1 = HuronCaseMixStruct.GetString(SERVICEDAYS1, 4);
                MAINSERVICE1 = HuronCaseMixStruct.GetString(MAINSERVICE1, 10);
                outRec = RECORDTYPE + ABSSERVICE1 + SERVICESTARTDATE1 + SERVICEDAYS1 + MAINSERVICE1;
                return outRec;
            }
        }

        public struct SPECIAL_CARE_UNITS_DATA
        {
            private string RECORDTYPE;
            private string LOCATIONSTARTDATE1;
            private string LOCATIONSTARTTIME1;
            private string LOCATIONENDDATE1;
            private string LOCATIONENDTIME1;
            private string DAYS1;
            private string SPECIALCAREUNIT1;
            private string LOCATION1;

            public void Clear()
            {
                RECORDTYPE = "";
                LOCATIONSTARTDATE1 = "";
                LOCATIONSTARTTIME1 = "";
                LOCATIONENDDATE1 = "";
                LOCATIONENDTIME1 = "";
                DAYS1 = "";
                SPECIALCAREUNIT1 = "";
                LOCATION1 = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string LocationStartDate1
            {
                get { return LOCATIONSTARTDATE1; }
                set { LOCATIONSTARTDATE1 = value; }
            }
            public string LocationStartTime1
            {
                get { return LOCATIONSTARTTIME1; }
                set { LOCATIONSTARTTIME1 = value; }
            }
            public string LocationEndDate1
            {
                get { return LOCATIONENDDATE1; }
                set { LOCATIONENDDATE1 = value; }
            }
            public string LocationEndTime1
            {
                get { return LOCATIONENDTIME1; }
                set { LOCATIONENDTIME1 = value; }
            }
            public string Days1
            {
                get { return DAYS1; }
                set { DAYS1 = value; }
            }
            public string SpecialCareUnit1
            {
                get { return SPECIALCAREUNIT1; }
                set { SPECIALCAREUNIT1 = value; }
            }
            public string Location1
            {
                get { return LOCATION1; }
                set { LOCATION1 = value; }
            }

            public string GetRecord()
            {
                RECORDTYPE = "";
                LOCATIONSTARTDATE1 = "";
                LOCATIONSTARTTIME1 = "";
                LOCATIONENDDATE1 = "";
                LOCATIONENDTIME1 = "";
                DAYS1 = "";
                SPECIALCAREUNIT1 = "";
                LOCATION1 = "";

                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                LOCATIONSTARTDATE1 = HuronCaseMixStruct.GetString(LOCATIONSTARTDATE1, 10);
                LOCATIONSTARTTIME1 = HuronCaseMixStruct.GetString(LOCATIONSTARTTIME1, 8);
                LOCATIONENDDATE1 = HuronCaseMixStruct.GetString(LOCATIONENDDATE1, 4);
                LOCATIONENDTIME1 = HuronCaseMixStruct.GetString(LOCATIONENDTIME1, 8);
                DAYS1 = HuronCaseMixStruct.GetString(DAYS1, 4);
                SPECIALCAREUNIT1 = HuronCaseMixStruct.GetString(SPECIALCAREUNIT1, 10);
                LOCATION1 = HuronCaseMixStruct.GetString(LOCATION1, 10);
                outRec = RECORDTYPE + LOCATIONSTARTDATE1 + LOCATIONSTARTTIME1 + LOCATIONENDDATE1 + LOCATIONENDTIME1 + DAYS1 + SPECIALCAREUNIT1 + LOCATION1;
                return outRec;
            }
        }

        public struct MATERNITY_NEWBORN_DATA
        {
            private string RECORDTYPE;
            private string LENGTHOFLABOR;
            private string DATEOFDELIVERY;
            private string DELIVERYMETHOD;
            private string NEWBORNADMITSOURCE;
            private string APGAR1MIN;
            private string APGAR5MIN;
            private string VENTILATORDAYS;

            public void Clear()
            {
                RECORDTYPE = "";
                LENGTHOFLABOR = "";
                DATEOFDELIVERY = "";
                DELIVERYMETHOD = "";
                NEWBORNADMITSOURCE = "";
                APGAR1MIN = "";
                APGAR5MIN = "";
                VENTILATORDAYS = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string LengthofLabor
            {
                get { return LENGTHOFLABOR; }
                set { LENGTHOFLABOR = value; }
            }
            public string DateofDelivery
            {
                get { return DATEOFDELIVERY; }
                set { DATEOFDELIVERY = value; }
            }
            public string DeliveryMethod
            {
                get { return DELIVERYMETHOD; }
                set { DELIVERYMETHOD = value; }
            }
            public string NewbornAdmitSource
            {
                get { return NEWBORNADMITSOURCE; }
                set { NEWBORNADMITSOURCE = value; }
            }
            public string APGAR1min
            {
                get { return APGAR1MIN; }
                set { APGAR1MIN = value; }
            }
            public string APGAR5min
            {
                get { return APGAR5MIN; }
                set { APGAR5MIN = value; }
            }
            public string VentilatorDays
            {
                get { return VENTILATORDAYS; }
                set { VENTILATORDAYS = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                LENGTHOFLABOR = HuronCaseMixStruct.GetString(LENGTHOFLABOR, 2);
                DATEOFDELIVERY = HuronCaseMixStruct.GetString(DATEOFDELIVERY, 8);
                DELIVERYMETHOD = HuronCaseMixStruct.GetString(DELIVERYMETHOD, 10);
                NEWBORNADMITSOURCE = HuronCaseMixStruct.GetString(NEWBORNADMITSOURCE, 10);
                APGAR1MIN = HuronCaseMixStruct.GetString(APGAR1MIN, 2);
                APGAR5MIN = HuronCaseMixStruct.GetString(APGAR5MIN, 2);
                VENTILATORDAYS = HuronCaseMixStruct.GetString(VENTILATORDAYS, 3);
                outRec = RECORDTYPE + LENGTHOFLABOR + DATEOFDELIVERY + DELIVERYMETHOD + NEWBORNADMITSOURCE + APGAR1MIN + APGAR5MIN + VENTILATORDAYS;
                return outRec;
            }
        }
        public struct STILLBORN_DATA
        {
            private string RECORDTYPE;
            private string SEX;
            private string BIRTHDATE;
            private string BIRTHTIME;
            private string WEIGHTGRAMS;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                SEX = "";
                BIRTHDATE = "";
                BIRTHTIME = "";
                WEIGHTGRAMS = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string Sex
            {
                get { return SEX; }
                set { SEX = value; }
            }
            public string Birthdate
            {
                get { return BIRTHDATE; }
                set { BIRTHDATE = value; }
            }
            public string Birthtime
            {
                get { return BIRTHTIME; }
                set { BIRTHTIME = value; }
            }
            public string WeightGrams
            {
                get { return WEIGHTGRAMS; }
                set { WEIGHTGRAMS = value; }
            }

            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                SEX = HuronCaseMixStruct.GetString(SEX, 1);
                BIRTHDATE = HuronCaseMixStruct.GetString(BIRTHDATE, 8);
                BIRTHTIME = HuronCaseMixStruct.GetString(BIRTHTIME, 4);
                WEIGHTGRAMS = HuronCaseMixStruct.GetString(WEIGHTGRAMS, 5);
                outRec = RECORDTYPE + SEX + BIRTHDATE + BIRTHTIME + WEIGHTGRAMS;
                return outRec;
            }
        }

        public struct PROCEDURES_DATA
        {
            private string RECORDTYPE;
            private string EPISODENUMBER;
            private string GROUPVERSION;
            private string RCRDATE;
            private string RCRTIME;
            private string PROCEDUREDATE;
            private string PROCEDURECODE;
            private string CRITICALACCESSTYPE;
            private string PRIMARYSURGEON;
            private string ASSISTANTSURGEON;
            private string ANESTHESIADOCTOR;
            private string ANESTHESIATECHNIQUE;
            private string PROCEDURETISSUE;

            public void Clear()
            {
                RECORDTYPE = "";
                EPISODENUMBER = "";
                GROUPVERSION = "";
                RCRDATE = "";
                RCRTIME = "";
                PROCEDUREDATE = "";
                PROCEDURECODE = "";
                CRITICALACCESSTYPE = "";
                PRIMARYSURGEON = "";
                ASSISTANTSURGEON = "";
                ANESTHESIADOCTOR = "";
                ANESTHESIATECHNIQUE = "";
                PROCEDURETISSUE = "";
            }

            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string EpisodeNumber
            {
                get { return EPISODENUMBER; }
                set { EPISODENUMBER = value; }
            }
            public string GroupVersion
            {
                get { return GROUPVERSION; }
                set { GROUPVERSION = value; }
            }
            public string RcrDate
            {
                get { return RCRDATE; }
                set { RCRDATE = value; }
            }
            public string RcrTime
            {
                get { return RCRTIME; }
                set { RCRTIME = value; }
            }
            public string ProcedureDate
            {
                get { return PROCEDUREDATE; }
                set { PROCEDUREDATE = value; }
            }
            public string ProcedureCode
            {
                get { return PROCEDURECODE; }
                set { PROCEDURECODE = value; }
            }
            public string CriticalAccessType
            {
                get { return CRITICALACCESSTYPE; }
                set { CRITICALACCESSTYPE = value; }
            }
            public string PrimarySurgeon
            {
                get { return PRIMARYSURGEON; }
                set { PRIMARYSURGEON = value; }
            }
            public string AssistantSurgeon
            {
                get { return ASSISTANTSURGEON; }
                set { ASSISTANTSURGEON = value; }
            }
            public string AnesthesiaDoctor
            {
                get { return ANESTHESIADOCTOR; }
                set { ANESTHESIADOCTOR = value; }
            }
            public string AnesthesiaTechnique
            {
                get { return ANESTHESIATECHNIQUE; }
                set { ANESTHESIATECHNIQUE = value; }
            }
            public string ProcedureTissue
            {
                get { return PROCEDURETISSUE; }
                set { PROCEDURETISSUE = value; }
            }

            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                EPISODENUMBER = HuronCaseMixStruct.GetString(EPISODENUMBER, 5);
                GROUPVERSION = HuronCaseMixStruct.GetString(GROUPVERSION, 10);
                RCRDATE = HuronCaseMixStruct.GetString(RCRDATE, 8);
                RCRTIME = HuronCaseMixStruct.GetString(RCRTIME, 4);
                PROCEDUREDATE = HuronCaseMixStruct.GetString(PROCEDUREDATE, 8);
                PROCEDURECODE = HuronCaseMixStruct.GetString(PROCEDURECODE, 15);
                CRITICALACCESSTYPE = HuronCaseMixStruct.GetString(CRITICALACCESSTYPE, 4);
                PRIMARYSURGEON = HuronCaseMixStruct.GetString(PRIMARYSURGEON, 30);
                ASSISTANTSURGEON = HuronCaseMixStruct.GetString(ASSISTANTSURGEON, 30);
                ANESTHESIADOCTOR = HuronCaseMixStruct.GetString(ANESTHESIADOCTOR, 20);
                ANESTHESIATECHNIQUE = HuronCaseMixStruct.GetString(ANESTHESIATECHNIQUE, 10);
                PROCEDURETISSUE = HuronCaseMixStruct.GetString(PROCEDURETISSUE, 10);
                outRec = RECORDTYPE + EPISODENUMBER + GROUPVERSION + RCRDATE + RCRTIME + PROCEDUREDATE + PROCEDURECODE + CRITICALACCESSTYPE + PRIMARYSURGEON + ASSISTANTSURGEON + ANESTHESIADOCTOR + ANESTHESIATECHNIQUE + PROCEDURETISSUE;
                return outRec;
            }
        }
        public struct HCPCS_CPT_DATA
        {
            private string RECORDTYPE;
            private string CPTCODE;
            private string CPTDATE;
            private string CPTQTY;
            private string CPTSURGEON;
            private string CPTASSTSURG;
            private string HCPCSCPTSUBCAT;
            private string RCRDATE;
            private string RCRTIME;
            private string CRITICALACCESSTYPE;
            private string CPTMODIFIER;

            public void Clear()
            {
                RECORDTYPE = "";
                CPTCODE = "";
                CPTDATE = "";
                CPTQTY = "";
                CPTSURGEON = "";
                CPTASSTSURG = "";
                HCPCSCPTSUBCAT = "";
                RCRDATE = "";
                RCRTIME = "";
                CRITICALACCESSTYPE = "";
                CPTMODIFIER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string CPTCode
            {
                get { return CPTCODE; }
                set { CPTCODE = value; }
            }
            public string CPTDate
            {
                get { return CPTDATE; }
                set { CPTDATE = value; }
            }
            public string CPTQuantity
            {
                get { return CPTQTY; }
                set { CPTQTY = value; }
            }
            public string CPTSurgeon
            {
                get { return CPTSURGEON; }
                set { CPTSURGEON = value; }
            }
            public string CPTAssistantSurgeon
            {
                get { return CPTASSTSURG; }
                set { CPTASSTSURG = value; }
            }
            public string HCPCSCPTSubCategory
            {
                get { return HCPCSCPTSUBCAT; }
                set { HCPCSCPTSUBCAT = value; }
            }
            public string RcrDate
            {
                get { return RCRDATE; }
                set { RCRDATE = value; }
            }
            public string RcrTime
            {
                get { return RCRTIME; }
                set { RCRTIME = value; }
            }
            public string CriticalAccessType
            {
                get { return CRITICALACCESSTYPE; }
                set { CRITICALACCESSTYPE = value; }
            }
            public string CPTModifier
            {
                get { return CPTMODIFIER; }
                set { CPTMODIFIER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                CPTCODE = HuronCaseMixStruct.GetString(CPTCODE, 10);
                CPTDATE = HuronCaseMixStruct.GetString(CPTDATE, 8);
                CPTQTY = HuronCaseMixStruct.GetString(CPTQTY, 5);
                CPTSURGEON = HuronCaseMixStruct.GetString(CPTSURGEON, 30);
                CPTASSTSURG = HuronCaseMixStruct.GetString(CPTASSTSURG, 30);
                HCPCSCPTSUBCAT = HuronCaseMixStruct.GetString(HCPCSCPTSUBCAT, 10);
                RCRDATE = HuronCaseMixStruct.GetString(RCRDATE, 8);
                RCRTIME = HuronCaseMixStruct.GetString(RCRTIME, 4);
                CRITICALACCESSTYPE = HuronCaseMixStruct.GetString(CRITICALACCESSTYPE, 4);
                CPTMODIFIER = HuronCaseMixStruct.GetString(CPTMODIFIER, 10);
                outRec = RECORDTYPE + CPTCODE + CPTDATE + CPTQTY + CPTSURGEON + CPTASSTSURG + HCPCSCPTSUBCAT + RCRDATE + RCRTIME + CRITICALACCESSTYPE + CPTMODIFIER;
                return outRec;
            }
        }
        public struct REASON_FOR_VISIT_DIAGNOSES_DATA
        {
            private string RECORDTYPE;
            private string ADMITTINGDIAGNOSIS;
            private string ADMMITDXGROUPERVERSION;
            private string ALTADMITTINGDIAGNOSIS;
            private string ALTADMMITDXGROUPERVERSION;
            private string REASONFORVISITDX;
            private string GROUPERVERSION;
            private string RCRDATE;
            private string RCRTIME;
            private ArrayList DXLIST;
            public void Clear()
            {
                RECORDTYPE = "";
                ADMITTINGDIAGNOSIS = "";
                ADMMITDXGROUPERVERSION = "";
                ALTADMITTINGDIAGNOSIS = "";
                ALTADMMITDXGROUPERVERSION = "";
                REASONFORVISITDX = "";
                GROUPERVERSION = "";
                RCRDATE = "";
                RCRTIME = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string AdmittingDiagnosis
            {
                get { return ADMITTINGDIAGNOSIS; }
                set { ADMITTINGDIAGNOSIS = value; }
            }
            public string AdmDxGrouperVersion
            {
                get { return ADMMITDXGROUPERVERSION; }
                set { ADMMITDXGROUPERVERSION = value; }
            }
            public string AltAdmittingDiagnosis
            {
                get { return ALTADMITTINGDIAGNOSIS; }
                set { ALTADMITTINGDIAGNOSIS = value; }
            }
            public string AltAdmDxGrouperVersion
            {
                get { return ALTADMMITDXGROUPERVERSION; }
                set { ALTADMMITDXGROUPERVERSION = value; }
            }
            //public string ReasonForVisitDx
            //{
            //    get { return REASONFORVISITDX; }
            //    set { REASONFORVISITDX = value; }
            //}
            //public string GrouperVersion
            //{
            //    get { return GROUPERVERSION; }
            //    set { GROUPERVERSION = value; }
            //}
            //public string RcrDate
            //{
            //    get { return RCRDATE; }
            //    set { RCRDATE = value; }
            //}
            //public string RcrTime
            //{
            //    get { return RCRTIME; }
            //    set { RCRTIME = value; }
            //}
            public ArrayList DiagnosisList
            {
                get { return DXLIST; }
                set { DXLIST = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                string dx = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                ADMITTINGDIAGNOSIS = HuronCaseMixStruct.GetString(ADMITTINGDIAGNOSIS, 10);
                ADMMITDXGROUPERVERSION = HuronCaseMixStruct.GetString(ADMMITDXGROUPERVERSION, 10);
                ALTADMITTINGDIAGNOSIS = HuronCaseMixStruct.GetString(ALTADMITTINGDIAGNOSIS, 10);
                ALTADMMITDXGROUPERVERSION = HuronCaseMixStruct.GetString(ALTADMMITDXGROUPERVERSION, 10);
                //REASONFORVISITDX = HuronCaseMixStruct.GetString(REASONFORVISITDX, 10);
                //GROUPERVERSION = HuronCaseMixStruct.GetString(GROUPERVERSION, 10);
                //RCRDATE = HuronCaseMixStruct.GetString(RCRDATE, 8);
                //RCRTIME = HuronCaseMixStruct.GetString(RCRTIME, 4);
                for (int num = 0; num < DXLIST.Count; num++)
                {
                    dx = dx + DXLIST[num].ToString();
                }
                outRec = RECORDTYPE + ADMITTINGDIAGNOSIS + ADMMITDXGROUPERVERSION + ALTADMITTINGDIAGNOSIS + ALTADMMITDXGROUPERVERSION + dx;// REASONFORVISITDX + GROUPERVERSION + RCRDATE + RCRTIME;
                return outRec;
            }
        }

        public struct DIAGNOSIS_DATA
        {
            private string RECORDTYPE;
            private string DIAGNOSISEFFECTIVEDATE;
            private string DIAGNOSIS;
            private string DXPRESENTONADMIT;
            private string GROUPERVERSION;
            private string CRITICALACCESSTYPE;
            private string RCRDATE;
            private string RCRTIME;
            private ArrayList DXLIST;
            public void Clear()
            {
                RECORDTYPE = "";
                DIAGNOSISEFFECTIVEDATE = "";
                DIAGNOSIS = "";
                DXPRESENTONADMIT = "";
                GROUPERVERSION = "";
                CRITICALACCESSTYPE = "";
                RCRDATE = "";
                RCRTIME = "";
                DXLIST = new ArrayList();
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string DiagnosisEffectiveDate
            {
                get { return DIAGNOSISEFFECTIVEDATE; }
                set { DIAGNOSISEFFECTIVEDATE = value; }
            }
            public string Diagnosis
            {
                get { return DIAGNOSIS; }
                set { DIAGNOSIS = value; }
            }
            public string DxPresentOnAdmit
            {
                get { return DXPRESENTONADMIT; }
                set { DXPRESENTONADMIT = value; }
            }
            public string CriticalAccessType
            {
                get { return CRITICALACCESSTYPE; }
                set { CRITICALACCESSTYPE = value; }
            }
            public string GrouperVersion
            {
                get { return GROUPERVERSION; }
                set { GROUPERVERSION = value; }
            }
            public string RcrDate
            {
                get { return RCRDATE; }
                set { RCRDATE = value; }
            }
            public string RcrTime
            {
                get { return RCRTIME; }
                set { RCRTIME = value; }
            }
            public ArrayList DiagnosisList
            {
                get { return DXLIST; }
                set { DXLIST = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                string dx = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                //DIAGNOSISEFFECTIVEDATE = HuronCaseMixStruct.GetString(DIAGNOSISEFFECTIVEDATE, 8);
                //DIAGNOSIS = HuronCaseMixStruct.GetString(DIAGNOSIS, 10);
                //DXPRESENTONADMIT = HuronCaseMixStruct.GetString(DXPRESENTONADMIT, 1);
                //GROUPERVERSION = HuronCaseMixStruct.GetString(GROUPERVERSION, 10);
                //CRITICALACCESSTYPE = HuronCaseMixStruct.GetString(CRITICALACCESSTYPE, 4);
                //RCRDATE = HuronCaseMixStruct.GetString(RCRDATE, 8);
                //RCRTIME = HuronCaseMixStruct.GetString(RCRTIME, 4);
                for (int num = 0; num < DXLIST.Count; num++)
                {
                    dx = dx + DXLIST[num].ToString();
                }
                outRec = RECORDTYPE + dx; // DIAGNOSISEFFECTIVEDATE + DIAGNOSIS + DXPRESENTONADMIT + GROUPERVERSION + CRITICALACCESSTYPE + RCRDATE + RCRTIME;
                return outRec;
            }
        }

        public struct STATUSES_DATA
        {
            private string RECORDTYPE;
            private string DRGx;
            private string STDLOS;
            private string DRGSTATUS;
            private string DRGSTATUSDATE;
            private string CODER;
            private string ABSTRACTSTATUS;
            private string ABSTRACTOR;
            private string ABSTRACTSTATUSDATE;
            private string BILLINGSTATUS;
            private string DRGEXPECTEDREIMBURSEMENT;
            private string DRGCOSTWEIGHT;
            private string ALTERNATEDRG;
            private string ALTDRGEXPECTEDREIMBURSEMENT;
            private string ALTDRGCOSTWEIGHT;
            private string SHORTSTAYOUTLIERTHRESHOLD;
            private string IPPSCOMPARABLETHRESHOLD;
            public void Clear()
            {
                RECORDTYPE = "";
                DRGx = "";
                STDLOS = "";
                DRGSTATUS = "";
                DRGSTATUSDATE = "";
                CODER = "";
                ABSTRACTSTATUS = "";
                ABSTRACTOR = "";
                ABSTRACTSTATUSDATE = "";
                BILLINGSTATUS = "";
                DRGEXPECTEDREIMBURSEMENT = "";
                DRGCOSTWEIGHT = "";
                ALTERNATEDRG = "";
                ALTDRGEXPECTEDREIMBURSEMENT = "";
                ALTDRGCOSTWEIGHT = "";
                SHORTSTAYOUTLIERTHRESHOLD = "";
                IPPSCOMPARABLETHRESHOLD = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string DRG
            {
                get { return DRGx; }
                set { DRGx = value; }
            }
            public string StdLOS
            {
                get { return STDLOS; }
                set { STDLOS = value; }
            }
            public string DrgStatus
            {
                get { return DRGSTATUS; }
                set { DRGSTATUS = value; }
            }
            public string Coder
            {
                get { return CODER; }
                set { CODER = value; }
            }
            public string AbstractStatus
            {
                get { return ABSTRACTSTATUS; }
                set { ABSTRACTSTATUS = value; }
            }
            public string Abstractor
            {
                get { return ABSTRACTOR; }
                set { ABSTRACTOR = value; }
            }
            public string AbstractStatusDate
            {
                get { return ABSTRACTSTATUSDATE; }
                set { ABSTRACTSTATUSDATE = value; }
            }
            public string BillingStatus
            {
                get { return BILLINGSTATUS; }
                set { BILLINGSTATUS = value; }
            }
            public string DrgExpectedReimbursement
            {
                get { return DRGEXPECTEDREIMBURSEMENT; }
                set { DRGEXPECTEDREIMBURSEMENT = value; }
            }
            public string DrgCostWeight
            {
                get { return DRGCOSTWEIGHT; }
                set { DRGCOSTWEIGHT = value; }
            }
            public string DrgStatusDate
            {
                get { return DRGSTATUSDATE; }
                set { DRGSTATUSDATE = value; }
            }
            public string AlternateDRG
            {
                get { return ALTERNATEDRG; }
                set { ALTERNATEDRG = value; }
            }
            public string AltDRGExpReimb
            {
                get { return ALTDRGEXPECTEDREIMBURSEMENT; }
                set { ALTDRGEXPECTEDREIMBURSEMENT = value; }
            }
            public string AltDRGCostWeight
            {
                get { return ALTDRGCOSTWEIGHT; }
                set { ALTDRGCOSTWEIGHT = value; }
            }
            public string ShortStayOutlierThreshold
            {
                get { return SHORTSTAYOUTLIERTHRESHOLD; }
                set { SHORTSTAYOUTLIERTHRESHOLD = value; }
            }
            public string IPPComparableThreshold
            {
                get { return IPPSCOMPARABLETHRESHOLD; }
                set { IPPSCOMPARABLETHRESHOLD = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                DRGx = HuronCaseMixStruct.GetString(DRGx, 3);
                STDLOS = HuronCaseMixStruct.GetString(STDLOS, 5);
                DRGSTATUS = HuronCaseMixStruct.GetString(DRGSTATUS, 1);
                DRGSTATUSDATE = HuronCaseMixStruct.GetString(DRGSTATUSDATE, 8);
                CODER = HuronCaseMixStruct.GetString(CODER, 10);
                ABSTRACTSTATUS = HuronCaseMixStruct.GetString(ABSTRACTSTATUS, 1);
                ABSTRACTOR = HuronCaseMixStruct.GetString(ABSTRACTOR, 10);
                ABSTRACTSTATUSDATE = HuronCaseMixStruct.GetString(ABSTRACTSTATUSDATE, 8);
                BILLINGSTATUS = HuronCaseMixStruct.GetString(BILLINGSTATUS, 2);
                DRGEXPECTEDREIMBURSEMENT = HuronCaseMixStruct.GetString(DRGEXPECTEDREIMBURSEMENT, 10);
                DRGCOSTWEIGHT = HuronCaseMixStruct.GetString(DRGCOSTWEIGHT, 10);
                ALTERNATEDRG = HuronCaseMixStruct.GetString(ALTERNATEDRG, 3);
                ALTDRGEXPECTEDREIMBURSEMENT = HuronCaseMixStruct.GetString(ALTDRGEXPECTEDREIMBURSEMENT, 10);
                ALTDRGCOSTWEIGHT = HuronCaseMixStruct.GetString(ALTDRGCOSTWEIGHT, 10);
                SHORTSTAYOUTLIERTHRESHOLD = HuronCaseMixStruct.GetString(SHORTSTAYOUTLIERTHRESHOLD, 10);
                IPPSCOMPARABLETHRESHOLD = HuronCaseMixStruct.GetString(IPPSCOMPARABLETHRESHOLD, 10);
                outRec = RECORDTYPE + DRGx + STDLOS + DRGSTATUS + DRGSTATUSDATE + CODER + ABSTRACTSTATUS + ABSTRACTOR + ABSTRACTSTATUSDATE + BILLINGSTATUS + DRGEXPECTEDREIMBURSEMENT + DRGCOSTWEIGHT + ALTERNATEDRG + ALTDRGEXPECTEDREIMBURSEMENT + ALTDRGCOSTWEIGHT + SHORTSTAYOUTLIERTHRESHOLD + IPPSCOMPARABLETHRESHOLD;
                return outRec;
            }
        }
        public struct PATIENT_CHARGES
        {
            private string RECORDTYPE;
            private string CHARGECATAGORY1;
            private string DOLLARAMOUNT1;
            private string CHARGECATAGORY2;
            private string DOLLARAMOUNT2;
            private string CHARGECATAGORY3;
            private string DOLLARAMOUNT3;
            private string CHARGECATAGORY4;
            private string DOLLARAMOUNT4;
            private string CHARGECATAGORY5;
            private string DOLLARAMOUNT5;
            private string CHARGECATAGORY6;
            private string DOLLARAMOUNT6;
            private string CHARGECATAGORY7;
            private string DOLLARAMOUNT7;
            private string CHARGECATAGORY8;
            private string DOLLARAMOUNT8;
            private string CHARGECATAGORY9;
            private string DOLLARAMOUNT9;
            private string CHARGECATAGORY10;
            private string DOLLARAMOUNT10;
            private string CHARGECATAGORY11;
            private string DOLLARAMOUNT11;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                CHARGECATAGORY1 = "";
                DOLLARAMOUNT1 = "";
                CHARGECATAGORY2 = "";
                DOLLARAMOUNT2 = "";
                CHARGECATAGORY3 = "";
                DOLLARAMOUNT3 = "";
                CHARGECATAGORY4 = "";
                DOLLARAMOUNT4 = "";
                CHARGECATAGORY5 = "";
                DOLLARAMOUNT5 = "";
                CHARGECATAGORY6 = "";
                DOLLARAMOUNT6 = "";
                CHARGECATAGORY7 = "";
                DOLLARAMOUNT7 = "";
                CHARGECATAGORY8 = "";
                DOLLARAMOUNT8 = "";
                CHARGECATAGORY9 = "";
                DOLLARAMOUNT9 = "";
                CHARGECATAGORY10 = "";
                DOLLARAMOUNT10 = "";
                CHARGECATAGORY11 = "";
                DOLLARAMOUNT11 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string ChargeCatagory1
            {
                get { return CHARGECATAGORY1; }
                set { CHARGECATAGORY1 = value; }
            }
            public string DollarAmount1
            {
                get { return DOLLARAMOUNT1; }
                set { DOLLARAMOUNT1 = value; }
            }
            public string ChargeCatagory2
            {
                get { return CHARGECATAGORY2; }
                set { CHARGECATAGORY2 = value; }
            }
            public string DollarAmount2
            {
                get { return DOLLARAMOUNT2; }
                set { DOLLARAMOUNT2 = value; }
            }
            public string ChargeCatagory3
            {
                get { return CHARGECATAGORY3; }
                set { CHARGECATAGORY3 = value; }
            }
            public string DollarAmount3
            {
                get { return DOLLARAMOUNT3; }
                set { DOLLARAMOUNT3 = value; }
            }
            public string ChargeCatagory4
            {
                get { return CHARGECATAGORY4; }
                set { CHARGECATAGORY4 = value; }
            }
            public string DollarAmount4
            {
                get { return DOLLARAMOUNT4; }
                set { DOLLARAMOUNT4 = value; }
            }
            public string ChargeCatagory5
            {
                get { return CHARGECATAGORY5; }
                set { CHARGECATAGORY5 = value; }
            }
            public string DollarAmount5
            {
                get { return DOLLARAMOUNT5; }
                set { DOLLARAMOUNT5 = value; }
            }
            public string ChargeCatagory6
            {
                get { return CHARGECATAGORY6; }
                set { CHARGECATAGORY6 = value; }
            }
            public string DollarAmount6
            {
                get { return DOLLARAMOUNT6; }
                set { DOLLARAMOUNT6 = value; }
            }
            public string ChargeCatagory7
            {
                get { return CHARGECATAGORY7; }
                set { CHARGECATAGORY7 = value; }
            }
            public string DollarAmount7
            {
                get { return DOLLARAMOUNT7; }
                set { DOLLARAMOUNT7 = value; }
            }
            public string ChargeCatagory8
            {
                get { return CHARGECATAGORY8; }
                set { CHARGECATAGORY8 = value; }
            }
            public string DollarAmount8
            {
                get { return DOLLARAMOUNT8; }
                set { DOLLARAMOUNT8 = value; }
            }
            public string ChargeCatagory9
            {
                get { return CHARGECATAGORY9; }
                set { CHARGECATAGORY9 = value; }
            }
            public string DollarAmount9
            {
                get { return DOLLARAMOUNT9; }
                set { DOLLARAMOUNT9 = value; }
            }
            public string ChargeCatagory10
            {
                get { return CHARGECATAGORY10; }
                set { CHARGECATAGORY10 = value; }
            }
            public string DollarAmount10
            {
                get { return DOLLARAMOUNT10; }
                set { DOLLARAMOUNT10 = value; }
            }
            public string ChargeCatagory11
            {
                get { return CHARGECATAGORY11; }
                set { CHARGECATAGORY11 = value; }
            }
            public string DollarAmount11
            {
                get { return DOLLARAMOUNT11; }
                set { DOLLARAMOUNT11 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                CHARGECATAGORY1 = HuronCaseMixStruct.GetString(CHARGECATAGORY1, 10);
                DOLLARAMOUNT1 = HuronCaseMixStruct.GetString(DOLLARAMOUNT1, 7);
                CHARGECATAGORY2 = HuronCaseMixStruct.GetString(CHARGECATAGORY2, 10);
                DOLLARAMOUNT2 = HuronCaseMixStruct.GetString(DOLLARAMOUNT2, 7);
                CHARGECATAGORY3 = HuronCaseMixStruct.GetString(CHARGECATAGORY3, 10);
                DOLLARAMOUNT3 = HuronCaseMixStruct.GetString(DOLLARAMOUNT3, 7);
                CHARGECATAGORY4 = HuronCaseMixStruct.GetString(CHARGECATAGORY4, 10);
                DOLLARAMOUNT4 = HuronCaseMixStruct.GetString(DOLLARAMOUNT4, 7);
                CHARGECATAGORY5 = HuronCaseMixStruct.GetString(CHARGECATAGORY5, 10);
                DOLLARAMOUNT5 = HuronCaseMixStruct.GetString(DOLLARAMOUNT5, 7);
                CHARGECATAGORY6 = HuronCaseMixStruct.GetString(CHARGECATAGORY6, 10);
                DOLLARAMOUNT6 = HuronCaseMixStruct.GetString(DOLLARAMOUNT6, 7);
                CHARGECATAGORY7 = HuronCaseMixStruct.GetString(CHARGECATAGORY7, 10);
                DOLLARAMOUNT7 = HuronCaseMixStruct.GetString(DOLLARAMOUNT7, 7);
                CHARGECATAGORY8 = HuronCaseMixStruct.GetString(CHARGECATAGORY8, 10);
                DOLLARAMOUNT8 = HuronCaseMixStruct.GetString(DOLLARAMOUNT8, 7);
                CHARGECATAGORY9 = HuronCaseMixStruct.GetString(CHARGECATAGORY9, 10);
                DOLLARAMOUNT9 = HuronCaseMixStruct.GetString(DOLLARAMOUNT9, 7);
                CHARGECATAGORY10 = HuronCaseMixStruct.GetString(CHARGECATAGORY10, 10);
                DOLLARAMOUNT10 = HuronCaseMixStruct.GetString(DOLLARAMOUNT10, 7);
                CHARGECATAGORY11 = HuronCaseMixStruct.GetString(CHARGECATAGORY11, 10);
                DOLLARAMOUNT11 = HuronCaseMixStruct.GetString(DOLLARAMOUNT11, 7);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 11);
                outRec = RECORDTYPE + CHARGECATAGORY1 + DOLLARAMOUNT1 + CHARGECATAGORY2 + DOLLARAMOUNT2 + CHARGECATAGORY3 + DOLLARAMOUNT3 + CHARGECATAGORY4 + DOLLARAMOUNT4 + CHARGECATAGORY5 + DOLLARAMOUNT5 + CHARGECATAGORY6 + DOLLARAMOUNT6 + CHARGECATAGORY7 + DOLLARAMOUNT7 + CHARGECATAGORY8 + DOLLARAMOUNT8 + CHARGECATAGORY9 + DOLLARAMOUNT9 + CHARGECATAGORY10 + DOLLARAMOUNT10 + CHARGECATAGORY11 + DOLLARAMOUNT11 + FILLER;
                return outRec;
            }
        }
        public struct INSURANCE_DATA_1_2
        {
            private string RECORDTYPE;
            private string INSURANCECODE1;
            private string INSURANCENAME1;
            private string INSURANCEPOLICYNUMBER1;
            private string INSURANCECODE2;
            private string INSURANCENAME2;
            private string INSURANCEPOLICYNUMBER2;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                INSURANCECODE1 = "";
                INSURANCENAME1 = "";
                INSURANCEPOLICYNUMBER1 = "";
                INSURANCECODE2 = "";
                INSURANCENAME2 = "";
                INSURANCEPOLICYNUMBER2 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string InsuranceCode1
            {
                get { return INSURANCECODE1; }
                set { INSURANCECODE1 = value; }
            }
            public string InsuranceName1
            {
                get { return INSURANCENAME1; }
                set { INSURANCENAME1 = value; }
            }
            public string InsurancePolicyNumber1
            {
                get { return INSURANCEPOLICYNUMBER1; }
                set { INSURANCEPOLICYNUMBER1 = value; }
            }
            public string InsuranceCode2
            {
                get { return INSURANCECODE2; }
                set { INSURANCECODE2 = value; }
            }
            public string InsuranceName2
            {
                get { return INSURANCENAME2; }
                set { INSURANCENAME2 = value; }
            }
            public string InsurancePolicyNumber2
            {
                get { return INSURANCEPOLICYNUMBER2; }
                set { INSURANCEPOLICYNUMBER2 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                INSURANCECODE1 = HuronCaseMixStruct.GetString(INSURANCECODE1, 10);
                INSURANCENAME1 = HuronCaseMixStruct.GetString(INSURANCENAME1, 30);
                INSURANCEPOLICYNUMBER1 = HuronCaseMixStruct.GetString(INSURANCEPOLICYNUMBER1, 30);
                INSURANCECODE2 = HuronCaseMixStruct.GetString(INSURANCECODE2, 10);
                INSURANCENAME2 = HuronCaseMixStruct.GetString(INSURANCENAME2, 30);
                INSURANCEPOLICYNUMBER2 = HuronCaseMixStruct.GetString(INSURANCEPOLICYNUMBER2, 30);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 58);
                outRec = RECORDTYPE + INSURANCECODE1 + INSURANCENAME1 + INSURANCEPOLICYNUMBER1 + INSURANCECODE2 + INSURANCENAME2 + INSURANCEPOLICYNUMBER2 + FILLER;
                return outRec;
            }
        }
        public struct INSURANCE_DATA_3_4
        {
            private string RECORDTYPE;
            private string INSURANCECODE3;
            private string INSURANCENAME3;
            private string INSURANCEPOLICYNUMBER3;
            private string INSURANCECODE4;
            private string INSURANCENAME4;
            private string INSURANCEPOLICYNUMBER4;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                INSURANCECODE3 = "";
                INSURANCENAME3 = "";
                INSURANCEPOLICYNUMBER3 = "";
                INSURANCECODE4 = "";
                INSURANCENAME4 = "";
                INSURANCEPOLICYNUMBER4 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string InsuranceCode3
            {
                get { return INSURANCECODE3; }
                set { INSURANCECODE3 = value; }
            }
            public string InsuranceName3
            {
                get { return INSURANCENAME3; }
                set { INSURANCENAME3 = value; }
            }
            public string InsurancePolicyNumber3
            {
                get { return INSURANCEPOLICYNUMBER3; }
                set { INSURANCEPOLICYNUMBER3 = value; }
            }
            public string InsuranceCode4
            {
                get { return INSURANCECODE4; }
                set { INSURANCECODE4 = value; }
            }
            public string InsuranceName4
            {
                get { return INSURANCENAME4; }
                set { INSURANCENAME4 = value; }
            }
            public string InsurancePolicyNumber4
            {
                get { return INSURANCEPOLICYNUMBER4; }
                set { INSURANCEPOLICYNUMBER4 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                INSURANCECODE3 = HuronCaseMixStruct.GetString(INSURANCECODE3, 10);
                INSURANCENAME3 = HuronCaseMixStruct.GetString(INSURANCENAME3, 30);
                INSURANCEPOLICYNUMBER3 = HuronCaseMixStruct.GetString(INSURANCEPOLICYNUMBER3, 30);
                INSURANCECODE4 = HuronCaseMixStruct.GetString(INSURANCECODE4, 10);
                INSURANCENAME4 = HuronCaseMixStruct.GetString(INSURANCENAME4, 30);
                INSURANCEPOLICYNUMBER4 = HuronCaseMixStruct.GetString(INSURANCEPOLICYNUMBER4, 30);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 58);
                outRec = RECORDTYPE + INSURANCECODE3 + INSURANCENAME3 + INSURANCEPOLICYNUMBER3 + INSURANCECODE4 + INSURANCENAME4 + INSURANCEPOLICYNUMBER4 + FILLER;
                return outRec;
            }
        }
        public struct SPECIAL_STUDIES
        {
            private string RECORDTYPE;
            private string SPECIALSTUDY1;
            private string SPECIALSTUDY2;
            private string SPECIALSTUDY3;
            private string SPECIALSTUDY4;
            private string SPECIALSTUDY5;
            private string SPECIALSTUDY6;
            private string SPECIALSTUDY7;
            private string SPECIALSTUDY8;
            private string SPECIALSTUDY9;
            private string SPECIALSTUDY10;
            private string SPECIALSTUDY11;
            private string SPECIALSTUDY12;
            private string SPECIALSTUDY13;
            private string SPECIALSTUDY14;
            private string SPECIALSTUDY15;
            private string SPECIALSTUDY16;
            private string SPECIALSTUDY17;
            private string SPECIALSTUDY18;
            private string SPECIALSTUDY19;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                SPECIALSTUDY1 = "";
                SPECIALSTUDY2 = "";
                SPECIALSTUDY3 = "";
                SPECIALSTUDY4 = "";
                SPECIALSTUDY5 = "";
                SPECIALSTUDY6 = "";
                SPECIALSTUDY7 = "";
                SPECIALSTUDY8 = "";
                SPECIALSTUDY9 = "";
                SPECIALSTUDY10 = "";
                SPECIALSTUDY11 = "";
                SPECIALSTUDY12 = "";
                SPECIALSTUDY13 = "";
                SPECIALSTUDY14 = "";
                SPECIALSTUDY15 = "";
                SPECIALSTUDY16 = "";
                SPECIALSTUDY17 = "";
                SPECIALSTUDY18 = "";
                SPECIALSTUDY19 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string SpecialStudy1
            {
                get { return SPECIALSTUDY1; }
                set { SPECIALSTUDY1 = value; }
            }
            public string SpecialStudy2
            {
                get { return SPECIALSTUDY2; }
                set { SPECIALSTUDY2 = value; }
            }
            public string SpecialStudy3
            {
                get { return SPECIALSTUDY3; }
                set { SPECIALSTUDY3 = value; }
            }
            public string SpecialStudy4
            {
                get { return SPECIALSTUDY4; }
                set { SPECIALSTUDY4 = value; }
            }
            public string SpecialStudy5
            {
                get { return SPECIALSTUDY5; }
                set { SPECIALSTUDY5 = value; }
            }
            public string SpecialStudy6
            {
                get { return SPECIALSTUDY6; }
                set { SPECIALSTUDY6 = value; }
            }
            public string SpecialStudy7
            {
                get { return SPECIALSTUDY7; }
                set { SPECIALSTUDY7 = value; }
            }
            public string SpecialStudy8
            {
                get { return SPECIALSTUDY8; }
                set { SPECIALSTUDY8 = value; }
            }
            public string SpecialStudy9
            {
                get { return SPECIALSTUDY9; }
                set { SPECIALSTUDY9 = value; }
            }
            public string SpecialStudy10
            {
                get { return SPECIALSTUDY10; }
                set { SPECIALSTUDY10 = value; }
            }
            public string SpecialStudy11
            {
                get { return SPECIALSTUDY11; }
                set { SPECIALSTUDY11 = value; }
            }
            public string SpecialStudy12
            {
                get { return SPECIALSTUDY12; }
                set { SPECIALSTUDY12 = value; }
            }
            public string SpecialStudy13
            {
                get { return SPECIALSTUDY13; }
                set { SPECIALSTUDY13 = value; }
            }
            public string SpecialStudy14
            {
                get { return SPECIALSTUDY14; }
                set { SPECIALSTUDY14 = value; }
            }
            public string SpecialStudy15
            {
                get { return SPECIALSTUDY15; }
                set { SPECIALSTUDY15 = value; }
            }
            public string SpecialStudy16
            {
                get { return SPECIALSTUDY16; }
                set { SPECIALSTUDY16 = value; }
            }
            public string SpecialStudy17
            {
                get { return SPECIALSTUDY17; }
                set { SPECIALSTUDY17 = value; }
            }
            public string SpecialStudy18
            {
                get { return SPECIALSTUDY18; }
                set { SPECIALSTUDY18 = value; }
            }
            public string SpecialStudy19
            {
                get { return SPECIALSTUDY19; }
                set { SPECIALSTUDY19 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                SPECIALSTUDY1 = HuronCaseMixStruct.GetString(SPECIALSTUDY1, 10);
                SPECIALSTUDY2 = HuronCaseMixStruct.GetString(SPECIALSTUDY2, 10);
                SPECIALSTUDY3 = HuronCaseMixStruct.GetString(SPECIALSTUDY3, 10);
                SPECIALSTUDY4 = HuronCaseMixStruct.GetString(SPECIALSTUDY4, 10);
                SPECIALSTUDY5 = HuronCaseMixStruct.GetString(SPECIALSTUDY5, 10);
                SPECIALSTUDY6 = HuronCaseMixStruct.GetString(SPECIALSTUDY6, 10);
                SPECIALSTUDY7 = HuronCaseMixStruct.GetString(SPECIALSTUDY7, 10);
                SPECIALSTUDY8 = HuronCaseMixStruct.GetString(SPECIALSTUDY8, 10);
                SPECIALSTUDY9 = HuronCaseMixStruct.GetString(SPECIALSTUDY9, 10);
                SPECIALSTUDY10 = HuronCaseMixStruct.GetString(SPECIALSTUDY10, 10);
                SPECIALSTUDY11 = HuronCaseMixStruct.GetString(SPECIALSTUDY11, 10);
                SPECIALSTUDY12 = HuronCaseMixStruct.GetString(SPECIALSTUDY12, 10);
                SPECIALSTUDY13 = HuronCaseMixStruct.GetString(SPECIALSTUDY13, 10);
                SPECIALSTUDY14 = HuronCaseMixStruct.GetString(SPECIALSTUDY14, 10);
                SPECIALSTUDY15 = HuronCaseMixStruct.GetString(SPECIALSTUDY15, 10);
                SPECIALSTUDY16 = HuronCaseMixStruct.GetString(SPECIALSTUDY16, 10);
                SPECIALSTUDY17 = HuronCaseMixStruct.GetString(SPECIALSTUDY17, 10);
                SPECIALSTUDY18 = HuronCaseMixStruct.GetString(SPECIALSTUDY18, 10);
                SPECIALSTUDY19 = HuronCaseMixStruct.GetString(SPECIALSTUDY19, 10);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 8);
                outRec = RECORDTYPE + SPECIALSTUDY1 + SPECIALSTUDY2 + SPECIALSTUDY3 + SPECIALSTUDY4 + SPECIALSTUDY5 + SPECIALSTUDY6 + SPECIALSTUDY7 + SPECIALSTUDY8 + SPECIALSTUDY9 + SPECIALSTUDY10 + SPECIALSTUDY11 + SPECIALSTUDY12 + SPECIALSTUDY13 + SPECIALSTUDY14 + SPECIALSTUDY15 + SPECIALSTUDY16 + SPECIALSTUDY17 + SPECIALSTUDY18 + SPECIALSTUDY19 + FILLER;
                return outRec;
            }
        }
        public struct PROJECTS
        {
            private string RECORDTYPE;
            private string PROJECTMNEMONIC;
            private string PROJECTQUERYRESPONSE1;
            private string PROJECTQUERYRESPONSE2;
            private string PROJECTQUERYRESPONSE3;
            private string PROJECTQUERYRESPONSE4;
            private string PROJECTQUERYRESPONSE5;
            private string PROJECTQUERYRESPONSE6;
            private string PROJECTQUERYRESPONSE7;
            private string PROJECTQUERYRESPONSE8;
            private string PROJECTQUERYRESPONSE9;
            private string PROJECTQUERYRESPONSE10;
            private string PROJECTQUERYRESPONSE11;
            private string PROJECTQUERYRESPONSE12;
            private string PROJECTQUERYRESPONSE13;
            private string PROJECTQUERYRESPONSE14;
            private string PROJECTQUERYRESPONSE15;
            private string PROJECTQUERYRESPONSE16;
            private string PROJECTQUERYRESPONSE17;
            private string PROJECTQUERYRESPONSE18;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                PROJECTMNEMONIC = "";
                PROJECTQUERYRESPONSE1 = "";
                PROJECTQUERYRESPONSE2 = "";
                PROJECTQUERYRESPONSE3 = "";
                PROJECTQUERYRESPONSE4 = "";
                PROJECTQUERYRESPONSE5 = "";
                PROJECTQUERYRESPONSE6 = "";
                PROJECTQUERYRESPONSE7 = "";
                PROJECTQUERYRESPONSE8 = "";
                PROJECTQUERYRESPONSE9 = "";
                PROJECTQUERYRESPONSE10 = "";
                PROJECTQUERYRESPONSE11 = "";
                PROJECTQUERYRESPONSE12 = "";
                PROJECTQUERYRESPONSE13 = "";
                PROJECTQUERYRESPONSE14 = "";
                PROJECTQUERYRESPONSE15 = "";
                PROJECTQUERYRESPONSE16 = "";
                PROJECTQUERYRESPONSE17 = "";
                PROJECTQUERYRESPONSE18 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string ProjectMnemonic
            {
                get { return PROJECTMNEMONIC; }
                set { PROJECTMNEMONIC = value; }
            }
            public string ProjectQueryResponse1
            {
                get { return PROJECTQUERYRESPONSE1; }
                set { PROJECTQUERYRESPONSE1 = value; }
            }
            public string ProjectQueryResponse2
            {
                get { return PROJECTQUERYRESPONSE2; }
                set { PROJECTQUERYRESPONSE2 = value; }
            }
            public string ProjectQueryResponse3
            {
                get { return PROJECTQUERYRESPONSE3; }
                set { PROJECTQUERYRESPONSE3 = value; }
            }
            public string ProjectQueryResponse4
            {
                get { return PROJECTQUERYRESPONSE4; }
                set { PROJECTQUERYRESPONSE4 = value; }
            }
            public string ProjectQueryResponse5
            {
                get { return PROJECTQUERYRESPONSE5; }
                set { PROJECTQUERYRESPONSE5 = value; }
            }
            public string ProjectQueryResponse6
            {
                get { return PROJECTQUERYRESPONSE6; }
                set { PROJECTQUERYRESPONSE6 = value; }
            }
            public string ProjectQueryResponse7
            {
                get { return PROJECTQUERYRESPONSE7; }
                set { PROJECTQUERYRESPONSE7 = value; }
            }
            public string ProjectQueryResponse8
            {
                get { return PROJECTQUERYRESPONSE8; }
                set { PROJECTQUERYRESPONSE8 = value; }
            }
            public string ProjectQueryResponse9
            {
                get { return PROJECTQUERYRESPONSE9; }
                set { PROJECTQUERYRESPONSE9 = value; }
            }
            public string ProjectQueryResponse10
            {
                get { return PROJECTQUERYRESPONSE10; }
                set { PROJECTQUERYRESPONSE10 = value; }
            }
            public string ProjectQueryResponse11
            {
                get { return PROJECTQUERYRESPONSE11; }
                set { PROJECTQUERYRESPONSE11 = value; }
            }
            public string ProjectQueryResponse12
            {
                get { return PROJECTQUERYRESPONSE12; }
                set { PROJECTQUERYRESPONSE12 = value; }
            }
            public string ProjectQueryResponse13
            {
                get { return PROJECTQUERYRESPONSE13; }
                set { PROJECTQUERYRESPONSE13 = value; }
            }
            public string ProjectQueryResponse14
            {
                get { return PROJECTQUERYRESPONSE14; }
                set { PROJECTQUERYRESPONSE14 = value; }
            }
            public string ProjectQueryResponse15
            {
                get { return PROJECTQUERYRESPONSE15; }
                set { PROJECTQUERYRESPONSE15 = value; }
            }
            public string ProjectQueryResponse16
            {
                get { return PROJECTQUERYRESPONSE16; }
                set { PROJECTQUERYRESPONSE16 = value; }
            }
            public string ProjectQueryResponse17
            {
                get { return PROJECTQUERYRESPONSE17; }
                set { PROJECTQUERYRESPONSE17 = value; }
            }
            public string ProjectQueryResponse18
            {
                get { return PROJECTQUERYRESPONSE18; }
                set { PROJECTQUERYRESPONSE18 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                PROJECTMNEMONIC = HuronCaseMixStruct.GetString(PROJECTMNEMONIC, 10);
                PROJECTQUERYRESPONSE1 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE1, 10);
                PROJECTQUERYRESPONSE2 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE2, 10);
                PROJECTQUERYRESPONSE3 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE3, 10);
                PROJECTQUERYRESPONSE4 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE4, 10);
                PROJECTQUERYRESPONSE5 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE5, 10);
                PROJECTQUERYRESPONSE6 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE6, 10);
                PROJECTQUERYRESPONSE7 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE7, 10);
                PROJECTQUERYRESPONSE8 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE8, 10);
                PROJECTQUERYRESPONSE9 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE9, 10);
                PROJECTQUERYRESPONSE10 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE10, 10);
                PROJECTQUERYRESPONSE11 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE11, 10);
                PROJECTQUERYRESPONSE12 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE12, 10);
                PROJECTQUERYRESPONSE13 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE13, 10);
                PROJECTQUERYRESPONSE14 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE14, 10);
                PROJECTQUERYRESPONSE15 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE15, 10);
                PROJECTQUERYRESPONSE16 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE16, 10);
                PROJECTQUERYRESPONSE17 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE17, 10);
                PROJECTQUERYRESPONSE18 = HuronCaseMixStruct.GetString(PROJECTQUERYRESPONSE18, 10);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 8);
                outRec = RECORDTYPE + PROJECTMNEMONIC + PROJECTQUERYRESPONSE1 + PROJECTQUERYRESPONSE2 + PROJECTQUERYRESPONSE3 + PROJECTQUERYRESPONSE4 + PROJECTQUERYRESPONSE5 + PROJECTQUERYRESPONSE6 + PROJECTQUERYRESPONSE7 + PROJECTQUERYRESPONSE8 + PROJECTQUERYRESPONSE9 + PROJECTQUERYRESPONSE10 + PROJECTQUERYRESPONSE11 + PROJECTQUERYRESPONSE12 + PROJECTQUERYRESPONSE13 + PROJECTQUERYRESPONSE14 + PROJECTQUERYRESPONSE15 + PROJECTQUERYRESPONSE16 + PROJECTQUERYRESPONSE17 + PROJECTQUERYRESPONSE18 + FILLER;
                return outRec;
            }
        }
        public struct CUSTOMER_DEFINED_SCREEN_QUERIES
        {
            private string RECORDTYPE;
            private string QUERYMNEMONIC1;
            private string QUERYRESPONSE1;
            private string QUERYMNEMONIC2;
            private string QUERYRESPONSE2;
            private string QUERYMNEMONIC3;
            private string QUERYRESPONSE3;
            private string QUERYMNEMONIC4;
            private string QUERYRESPONSE4;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                QUERYMNEMONIC1 = "";
                QUERYRESPONSE1 = "";
                QUERYMNEMONIC2 = "";
                QUERYRESPONSE2 = "";
                QUERYMNEMONIC3 = "";
                QUERYRESPONSE3 = "";
                QUERYMNEMONIC4 = "";
                QUERYRESPONSE4 = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string QueryMnemonic1
            {
                get { return QUERYMNEMONIC1; }
                set { QUERYMNEMONIC1 = value; }
            }
            public string QueryResponse1
            {
                get { return QUERYRESPONSE1; }
                set { QUERYRESPONSE1 = value; }
            }
            public string QueryMnemonic2
            {
                get { return QUERYMNEMONIC2; }
                set { QUERYMNEMONIC2 = value; }
            }
            public string QueryResponse2
            {
                get { return QUERYRESPONSE2; }
                set { QUERYRESPONSE2 = value; }
            }
            public string QueryMnemonic3
            {
                get { return QUERYMNEMONIC3; }
                set { QUERYMNEMONIC3 = value; }
            }
            public string QueryResponse3
            {
                get { return QUERYRESPONSE3; }
                set { QUERYRESPONSE3 = value; }
            }
            public string QueryMnemonic4
            {
                get { return QUERYMNEMONIC4; }
                set { QUERYMNEMONIC4 = value; }
            }
            public string QueryResponse4
            {
                get { return QUERYRESPONSE4; }
                set { QUERYRESPONSE4 = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                QUERYMNEMONIC1 = HuronCaseMixStruct.GetString(QUERYMNEMONIC1, 10);
                QUERYRESPONSE1 = HuronCaseMixStruct.GetString(QUERYRESPONSE1, 30);
                QUERYMNEMONIC2 = HuronCaseMixStruct.GetString(QUERYMNEMONIC2, 10);
                QUERYRESPONSE2 = HuronCaseMixStruct.GetString(QUERYRESPONSE2, 30);
                QUERYMNEMONIC3 = HuronCaseMixStruct.GetString(QUERYMNEMONIC3, 10);
                QUERYRESPONSE3 = HuronCaseMixStruct.GetString(QUERYRESPONSE3, 30);
                QUERYMNEMONIC4 = HuronCaseMixStruct.GetString(QUERYMNEMONIC4, 10);
                QUERYRESPONSE4 = HuronCaseMixStruct.GetString(QUERYRESPONSE4, 30);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 38);
                outRec = RECORDTYPE + QUERYMNEMONIC1 + QUERYRESPONSE1 + QUERYMNEMONIC2 + QUERYRESPONSE2 + QUERYMNEMONIC3 + QUERYRESPONSE3 + QUERYMNEMONIC4 + QUERYRESPONSE4 + FILLER;
                return outRec;
            }
        }
        public struct REASON_FOR_VISIT
        {
            private string RECORDTYPE;
            private string DXREASON;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                DXREASON = "";
                FILLER = "";
            }
            public string DxReason
            {
                get { return DXREASON; }
                set { DXREASON = value; }
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                DXREASON = HuronCaseMixStruct.GetString(DXREASON, 7);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 251);
                outRec = RECORDTYPE + DXREASON + FILLER;
                return outRec;
            }
        }
        public struct TRAILER
        {
            private string RECORDTYPE;
            private string FILLER;
            public void Clear()
            {
                RECORDTYPE = "";
                FILLER = "";
            }
            public string RecordType
            {
                get { return RECORDTYPE; }
                set { RECORDTYPE = value; }
            }
            public string Filler
            {
                get { return FILLER; }
                set { FILLER = value; }
            }
            public string GetRecord()
            {
                string outRec = "";
                RECORDTYPE = HuronCaseMixStruct.GetString(RECORDTYPE, 2);
                FILLER = HuronCaseMixStruct.GetString(FILLER, 248);
                outRec = RECORDTYPE + FILLER;
                return outRec;
            }
        }
    }
}
