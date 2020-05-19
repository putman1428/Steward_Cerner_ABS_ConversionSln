using System;
using System.Collections;
namespace Huron
{
    /// <summary>
    /// Summary description for Casemix Struct.
    /// </summary>
    public class HuronCernerStruct
    {
        private static string GetString(string str, int length)
        {
            str = str.PadRight(length, ' ');
            str = str.Substring(0, length);
            return str;
        }
        public struct ENCOUNTER
        {
            private string ENCNTR_IDx;
            private string PERSON_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string CREATE_DT_TMx;
            private string CREATE_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string ENCNTR_CLASS_CDx;
            private string ENCNTR_TYPE_CDx;
            private string ENCNTR_TYPE_CLASS_CDx;
            private string ENCNTR_STATUS_CDx;
            private string PRE_REG_DT_TMx;
            private string PRE_REG_PRSNL_IDx;
            private string REG_DT_TMx;
            private string REG_PRSNL_IDx;
            private string EST_ARRIVE_DT_TMx;
            private string EST_DEPART_DT_TMx;
            private string ARRIVE_DT_TMx;
            private string DEPART_DT_TMx;
            private string ADMIT_TYPE_CDx;
            private string ADMIT_SRC_CDx;
            private string ADMIT_MODE_CDx;
            private string ADMIT_WITH_MEDICATION_CDx;
            private string REFERRING_COMMENTx;
            private string DISCH_DISPOSITION_CDx;
            private string DISCH_TO_LOCTN_CDx;
            private string PREADMIT_NBRx;
            private string PREADMIT_TESTING_CDx;
            private string READMIT_CDx;
            private string ACCOMMODATION_CDx;
            private string ACCOMMODATION_REQUEST_CDx;
            private string ALT_RESULT_DEST_CDx;
            private string AMBULATORY_COND_CDx;
            private string COURTESY_CDx;
            private string DIET_TYPE_CDx;
            private string ISOLATION_CDx;
            private string MED_SERVICE_CDx;
            private string RESULT_DEST_CDx;
            private string CONFID_LEVEL_CDx;
            private string VIP_CDx;
            private string NAME_LAST_KEYx;
            private string NAME_FIRST_KEYx;
            private string NAME_FULL_FORMATTEDx;
            private string NAME_LASTx;
            private string NAME_FIRSTx;
            private string NAME_PHONETICx;
            private string SEX_CDx;
            private string BIRTH_DT_CDx;
            private string BIRTH_DT_TMx;
            private string SPECIES_CDx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string LOCATION_CDx;
            private string LOC_FACILITY_CDx;
            private string LOC_BUILDING_CDx;
            private string LOC_NURSE_UNIT_CDx;
            private string LOC_ROOM_CDx;
            private string LOC_BED_CDx;
            private string DISCH_DT_TMx;
            private string GUARANTOR_TYPE_CDx;
            private string LOC_TEMP_CDx;
            private string ORGANIZATION_IDx;
            private string REASON_FOR_VISITx;
            private string ENCNTR_FINANCIAL_IDx;
            private string NAME_FIRST_SYNONYM_IDx;
            private string FINANCIAL_CLASS_CDx;
            private string BBD_PROCEDURE_CDx;
            private string INFO_GIVEN_BYx;
            private string SAFEKEEPING_CDx;
            private string TRAUMA_CDx;
            private string TRIAGE_CDx;
            private string TRIAGE_DT_TMx;
            private string VISITOR_STATUS_CDx;
            private string VALUABLES_CDx;
            private string SECURITY_ACCESS_CDx;
            private string REFER_FACILITY_CDx;
            private string TRAUMA_DT_TMx;
            private string ACCOMP_BY_CDx;
            private string ACCOMMODATION_REASON_CDx;
            private string CHART_COMPLETE_DT_TMx;
            private string ZERO_BALANCE_DT_TMx;
            private string ARCHIVE_DT_TM_ESTx;
            private string ARCHIVE_DT_TM_ACTx;
            private string PURGE_DT_TM_ESTx;
            private string PURGE_DT_TM_ACTx;
            private string ENCNTR_COMPLETE_DT_TMx;
            private string PA_CURRENT_STATUS_CDx;
            private string PA_CURRENT_STATUS_DT_TMx;
            private string PARENT_RET_CRITERIA_IDx;
            private string SERVICE_CATEGORY_CDx;
            private string CONTRACT_STATUS_CDx;
            private string EST_LENGTH_OF_STAYx;
            private string ALT_LVL_CARE_CDx;
            private string ASSIGN_TO_LOC_DT_TMx;
            private string PROGRAM_SERVICE_CDx;
            private string SPECIALTY_UNIT_CDx;
            private string MENTAL_HEALTH_DT_TMx;
            private string MENTAL_HEALTH_CDx;
            private string DOC_RCVD_DT_TMx;
            private string REFERRAL_RCVD_DT_TMx;
            private string ALT_LVL_CARE_DT_TMx;
            private string ALC_DECOMP_DT_TMx;
            private string REGION_CDx;
            private string SITTER_REQUIRED_CDx;
            private string ALC_REASON_CDx;
            private string PLACEMENT_AUTH_PRSNL_IDx;
            private string PATIENT_CLASSIFICATION_CDx;
            private string MENTAL_CATEGORY_CDx;
            private string PSYCHIATRIC_STATUS_CDx;
            private string INPATIENT_ADMIT_DT_TMx;
            private string RESULT_ACCUMULATION_DT_TMx;
            private string PREGNANCY_STATUS_CDx;
            private string INITIAL_CONTACT_DT_TMx;
            private string ONSET_DT_TMx;
            private string LAST_MENSTRUAL_PERIOD_DT_TMx;
            private string EXPECTED_DELIVERY_DT_TMx;
            private string ABN_STATUS_CDx;
            private string LEVEL_OF_SERVICE_CDx;
            private string PLACE_OF_SVC_ADMIT_DT_TMx;
            private string PLACE_OF_SVC_TYPE_CDx;
            private string PLACE_OF_SVC_ORG_IDx;
            private string LAST_UTC_TSx;
            private string EST_FINANCIAL_RESP_AMTx;
            private string REFERRAL_SOURCE_CDx;
            private string ADMIT_DECISION_DT_TMx;
            private string ACCIDENT_RELATED_INDx;
            private string DISCH_PRSNL_IDx;
            private string PAYMENT_COLLECTION_STATUS_CDx;
            private string ORDER_SOURCE_CDx;
            private string ADMIT_EARLY_INDx;
            private string TREATMENT_PHASE_CDx;
            private string KIOSK_QUEUE_NBR_TXTx;
            private string KIOSK_QUEUE_NBR_DT_TMx;
            private string CLU_SUBKEY1_FLAGx;
            private string REFER_TO_UNIT_STAFF_CDx;
            private string LODGER_CDx;
            private string COMPLETE_REG_DT_TMx;
            private string COMPLETE_REG_PRSNL_IDx;
            private string CLERGY_VISIT_CDx;
            private string CLIENT_ORGANIZATION_IDx;
            private string PERSON_PLAN_PROFILE_TYPE_CDx;
            private string MILITARY_SERVICE_RELATED_CDx;
            private string INCIDENT_CDx;
            private string ED_REFERRAL_SOURCE_CDx;
            private string INST_IDx;

            public void Clear()
            {
                ENCNTR_IDx = "";
                PERSON_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                CREATE_DT_TMx = "";
                CREATE_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                ENCNTR_CLASS_CDx = "";
                ENCNTR_TYPE_CDx = "";
                ENCNTR_TYPE_CLASS_CDx = "";
                ENCNTR_STATUS_CDx = "";
                PRE_REG_DT_TMx = "";
                PRE_REG_PRSNL_IDx = "";
                REG_DT_TMx = "";
                REG_PRSNL_IDx = "";
                EST_ARRIVE_DT_TMx = "";
                EST_DEPART_DT_TMx = "";
                ARRIVE_DT_TMx = "";
                DEPART_DT_TMx = "";
                ADMIT_TYPE_CDx = "";
                ADMIT_SRC_CDx = "";
                ADMIT_MODE_CDx = "";
                ADMIT_WITH_MEDICATION_CDx = "";
                REFERRING_COMMENTx = "";
                DISCH_DISPOSITION_CDx = "";
                DISCH_TO_LOCTN_CDx = "";
                PREADMIT_NBRx = "";
                PREADMIT_TESTING_CDx = "";
                READMIT_CDx = "";
                ACCOMMODATION_CDx = "";
                ACCOMMODATION_REQUEST_CDx = "";
                ALT_RESULT_DEST_CDx = "";
                AMBULATORY_COND_CDx = "";
                COURTESY_CDx = "";
                DIET_TYPE_CDx = "";
                ISOLATION_CDx = "";
                MED_SERVICE_CDx = "";
                RESULT_DEST_CDx = "";
                CONFID_LEVEL_CDx = "";
                VIP_CDx = "";
                NAME_LAST_KEYx = "";
                NAME_FIRST_KEYx = "";
                NAME_FULL_FORMATTEDx = "";
                NAME_LASTx = "";
                NAME_FIRSTx = "";
                NAME_PHONETICx = "";
                SEX_CDx = "";
                BIRTH_DT_CDx = "";
                BIRTH_DT_TMx = "";
                SPECIES_CDx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                LOCATION_CDx = "";
                LOC_FACILITY_CDx = "";
                LOC_BUILDING_CDx = "";
                LOC_NURSE_UNIT_CDx = "";
                LOC_ROOM_CDx = "";
                LOC_BED_CDx = "";
                DISCH_DT_TMx = "";
                GUARANTOR_TYPE_CDx = "";
                LOC_TEMP_CDx = "";
                ORGANIZATION_IDx = "";
                REASON_FOR_VISITx = "";
                ENCNTR_FINANCIAL_IDx = "";
                NAME_FIRST_SYNONYM_IDx = "";
                FINANCIAL_CLASS_CDx = "";
                BBD_PROCEDURE_CDx = "";
                INFO_GIVEN_BYx = "";
                SAFEKEEPING_CDx = "";
                TRAUMA_CDx = "";
                TRIAGE_CDx = "";
                TRIAGE_DT_TMx = "";
                VISITOR_STATUS_CDx = "";
                VALUABLES_CDx = "";
                SECURITY_ACCESS_CDx = "";
                REFER_FACILITY_CDx = "";
                TRAUMA_DT_TMx = "";
                ACCOMP_BY_CDx = "";
                ACCOMMODATION_REASON_CDx = "";
                CHART_COMPLETE_DT_TMx = "";
                ZERO_BALANCE_DT_TMx = "";
                ARCHIVE_DT_TM_ESTx = "";
                ARCHIVE_DT_TM_ACTx = "";
                PURGE_DT_TM_ESTx = "";
                PURGE_DT_TM_ACTx = "";
                ENCNTR_COMPLETE_DT_TMx = "";
                PA_CURRENT_STATUS_CDx = "";
                PA_CURRENT_STATUS_DT_TMx = "";
                PARENT_RET_CRITERIA_IDx = "";
                SERVICE_CATEGORY_CDx = "";
                CONTRACT_STATUS_CDx = "";
                EST_LENGTH_OF_STAYx = "";
                ALT_LVL_CARE_CDx = "";
                ASSIGN_TO_LOC_DT_TMx = "";
                PROGRAM_SERVICE_CDx = "";
                SPECIALTY_UNIT_CDx = "";
                MENTAL_HEALTH_DT_TMx = "";
                MENTAL_HEALTH_CDx = "";
                DOC_RCVD_DT_TMx = "";
                REFERRAL_RCVD_DT_TMx = "";
                ALT_LVL_CARE_DT_TMx = "";
                ALC_DECOMP_DT_TMx = "";
                REGION_CDx = "";
                SITTER_REQUIRED_CDx = "";
                ALC_REASON_CDx = "";
                PLACEMENT_AUTH_PRSNL_IDx = "";
                PATIENT_CLASSIFICATION_CDx = "";
                MENTAL_CATEGORY_CDx = "";
                PSYCHIATRIC_STATUS_CDx = "";
                INPATIENT_ADMIT_DT_TMx = "";
                RESULT_ACCUMULATION_DT_TMx = "";
                PREGNANCY_STATUS_CDx = "";
                INITIAL_CONTACT_DT_TMx = "";
                ONSET_DT_TMx = "";
                LAST_MENSTRUAL_PERIOD_DT_TMx = "";
                EXPECTED_DELIVERY_DT_TMx = "";
                ABN_STATUS_CDx = "";
                LEVEL_OF_SERVICE_CDx = "";
                PLACE_OF_SVC_ADMIT_DT_TMx = "";
                PLACE_OF_SVC_TYPE_CDx = "";
                PLACE_OF_SVC_ORG_IDx = "";
                LAST_UTC_TSx = "";
                EST_FINANCIAL_RESP_AMTx = "";
                REFERRAL_SOURCE_CDx = "";
                ADMIT_DECISION_DT_TMx = "";
                ACCIDENT_RELATED_INDx = "";
                DISCH_PRSNL_IDx = "";
                PAYMENT_COLLECTION_STATUS_CDx = "";
                ORDER_SOURCE_CDx = "";
                ADMIT_EARLY_INDx = "";
                TREATMENT_PHASE_CDx = "";
                KIOSK_QUEUE_NBR_TXTx = "";
                KIOSK_QUEUE_NBR_DT_TMx = "";
                CLU_SUBKEY1_FLAGx = "";
                REFER_TO_UNIT_STAFF_CDx = "";
                LODGER_CDx = "";
                COMPLETE_REG_DT_TMx = "";
                COMPLETE_REG_PRSNL_IDx = "";
                CLERGY_VISIT_CDx = "";
                CLIENT_ORGANIZATION_IDx = "";
                PERSON_PLAN_PROFILE_TYPE_CDx = "";
                MILITARY_SERVICE_RELATED_CDx = "";
                INCIDENT_CDx = "";
                ED_REFERRAL_SOURCE_CDx = "";
                INST_IDx = "";
            }

            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string CREATE_DT_TM
            {
                get { return CREATE_DT_TMx; }
                set { CREATE_DT_TMx = value; }
            }
            public string CREATE_PRSNL_ID
            {
                get { return CREATE_PRSNL_IDx; }
                set { CREATE_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string ENCNTR_CLASS_CD
            {
                get { return ENCNTR_CLASS_CDx; }
                set { ENCNTR_CLASS_CDx = value; }
            }
            public string ENCNTR_TYPE_CD
            {
                get { return ENCNTR_TYPE_CDx; }
                set { ENCNTR_TYPE_CDx = value; }
            }
            public string ENCNTR_TYPE_CLASS_CD
            {
                get { return ENCNTR_TYPE_CLASS_CDx; }
                set { ENCNTR_TYPE_CLASS_CDx = value; }
            }
            public string ENCNTR_STATUS_CD
            {
                get { return ENCNTR_STATUS_CDx; }
                set { ENCNTR_STATUS_CDx = value; }
            }
            public string PRE_REG_DT_TM
            {
                get { return PRE_REG_DT_TMx; }
                set { PRE_REG_DT_TMx = value; }
            }
            public string PRE_REG_PRSNL_ID
            {
                get { return PRE_REG_PRSNL_IDx; }
                set { PRE_REG_PRSNL_IDx = value; }
            }
            public string REG_DT_TM
            {
                get { return REG_DT_TMx; }
                set { REG_DT_TMx = value; }
            }
            public string REG_PRSNL_ID
            {
                get { return REG_PRSNL_IDx; }
                set { REG_PRSNL_IDx = value; }
            }
            public string EST_ARRIVE_DT_TM
            {
                get { return EST_ARRIVE_DT_TMx; }
                set { EST_ARRIVE_DT_TMx = value; }
            }
            public string EST_DEPART_DT_TM
            {
                get { return EST_DEPART_DT_TMx; }
                set { EST_DEPART_DT_TMx = value; }
            }
            public string ARRIVE_DT_TM
            {
                get { return ARRIVE_DT_TMx; }
                set { ARRIVE_DT_TMx = value; }
            }
            public string DEPART_DT_TM
            {
                get { return DEPART_DT_TMx; }
                set { DEPART_DT_TMx = value; }
            }
            public string ADMIT_TYPE_CD
            {
                get { return ADMIT_TYPE_CDx; }
                set { ADMIT_TYPE_CDx = value; }
            }
            public string ADMIT_SRC_CD
            {
                get { return ADMIT_SRC_CDx; }
                set { ADMIT_SRC_CDx = value; }
            }
            public string ADMIT_MODE_CD
            {
                get { return ADMIT_MODE_CDx; }
                set { ADMIT_MODE_CDx = value; }
            }
            public string ADMIT_WITH_MEDICATION_CD
            {
                get { return ADMIT_WITH_MEDICATION_CDx; }
                set { ADMIT_WITH_MEDICATION_CDx = value; }
            }
            public string REFERRING_COMMENT
            {
                get { return REFERRING_COMMENTx; }
                set { REFERRING_COMMENTx = value; }
            }
            public string DISCH_DISPOSITION_CD
            {
                get { return DISCH_DISPOSITION_CDx; }
                set { DISCH_DISPOSITION_CDx = value; }
            }
            public string DISCH_TO_LOCTN_CD
            {
                get { return DISCH_TO_LOCTN_CDx; }
                set { DISCH_TO_LOCTN_CDx = value; }
            }
            public string PREADMIT_NBR
            {
                get { return PREADMIT_NBRx; }
                set { PREADMIT_NBRx = value; }
            }
            public string PREADMIT_TESTING_CD
            {
                get { return PREADMIT_TESTING_CDx; }
                set { PREADMIT_TESTING_CDx = value; }
            }
            public string READMIT_CD
            {
                get { return READMIT_CDx; }
                set { READMIT_CDx = value; }
            }
            public string ACCOMMODATION_CD
            {
                get { return ACCOMMODATION_CDx; }
                set { ACCOMMODATION_CDx = value; }
            }
            public string ACCOMMODATION_REQUEST_CD
            {
                get { return ACCOMMODATION_REQUEST_CDx; }
                set { ACCOMMODATION_REQUEST_CDx = value; }
            }
            public string ALT_RESULT_DEST_CD
            {
                get { return ALT_RESULT_DEST_CDx; }
                set { ALT_RESULT_DEST_CDx = value; }
            }
            public string AMBULATORY_COND_CD
            {
                get { return AMBULATORY_COND_CDx; }
                set { AMBULATORY_COND_CDx = value; }
            }
            public string COURTESY_CD
            {
                get { return COURTESY_CDx; }
                set { COURTESY_CDx = value; }
            }
            public string DIET_TYPE_CD
            {
                get { return DIET_TYPE_CDx; }
                set { DIET_TYPE_CDx = value; }
            }
            public string ISOLATION_CD
            {
                get { return ISOLATION_CDx; }
                set { ISOLATION_CDx = value; }
            }
            public string MED_SERVICE_CD
            {
                get { return MED_SERVICE_CDx; }
                set { MED_SERVICE_CDx = value; }
            }
            public string RESULT_DEST_CD
            {
                get { return RESULT_DEST_CDx; }
                set { RESULT_DEST_CDx = value; }
            }
            public string CONFID_LEVEL_CD
            {
                get { return CONFID_LEVEL_CDx; }
                set { CONFID_LEVEL_CDx = value; }
            }
            public string VIP_CD
            {
                get { return VIP_CDx; }
                set { VIP_CDx = value; }
            }
            public string NAME_LAST_KEY
            {
                get { return NAME_LAST_KEYx; }
                set { NAME_LAST_KEYx = value; }
            }
            public string NAME_FIRST_KEY
            {
                get { return NAME_FIRST_KEYx; }
                set { NAME_FIRST_KEYx = value; }
            }
            public string NAME_FULL_FORMATTED
            {
                get { return NAME_FULL_FORMATTEDx; }
                set { NAME_FULL_FORMATTEDx = value; }
            }
            public string NAME_LAST
            {
                get { return NAME_LASTx; }
                set { NAME_LASTx = value; }
            }
            public string NAME_FIRST
            {
                get { return NAME_FIRSTx; }
                set { NAME_FIRSTx = value; }
            }
            public string NAME_PHONETIC
            {
                get { return NAME_PHONETICx; }
                set { NAME_PHONETICx = value; }
            }
            public string SEX_CD
            {
                get { return SEX_CDx; }
                set { SEX_CDx = value; }
            }
            public string BIRTH_DT_CD
            {
                get { return BIRTH_DT_CDx; }
                set { BIRTH_DT_CDx = value; }
            }
            public string BIRTH_DT_TM
            {
                get { return BIRTH_DT_TMx; }
                set { BIRTH_DT_TMx = value; }
            }
            public string SPECIES_CD
            {
                get { return SPECIES_CDx; }
                set { SPECIES_CDx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string LOCATION_CD
            {
                get { return LOCATION_CDx; }
                set { LOCATION_CDx = value; }
            }
            public string LOC_FACILITY_CD
            {
                get { return LOC_FACILITY_CDx; }
                set { LOC_FACILITY_CDx = value; }
            }
            public string LOC_BUILDING_CD
            {
                get { return LOC_BUILDING_CDx; }
                set { LOC_BUILDING_CDx = value; }
            }
            public string LOC_NURSE_UNIT_CD
            {
                get { return LOC_NURSE_UNIT_CDx; }
                set { LOC_NURSE_UNIT_CDx = value; }
            }
            public string LOC_ROOM_CD
            {
                get { return LOC_ROOM_CDx; }
                set { LOC_ROOM_CDx = value; }
            }
            public string LOC_BED_CD
            {
                get { return LOC_BED_CDx; }
                set { LOC_BED_CDx = value; }
            }
            public string DISCH_DT_TM
            {
                get { return DISCH_DT_TMx; }
                set { DISCH_DT_TMx = value; }
            }
            public string GUARANTOR_TYPE_CD
            {
                get { return GUARANTOR_TYPE_CDx; }
                set { GUARANTOR_TYPE_CDx = value; }
            }
            public string LOC_TEMP_CD
            {
                get { return LOC_TEMP_CDx; }
                set { LOC_TEMP_CDx = value; }
            }
            public string ORGANIZATION_ID
            {
                get { return ORGANIZATION_IDx; }
                set { ORGANIZATION_IDx = value; }
            }
            public string REASON_FOR_VISIT
            {
                get { return REASON_FOR_VISITx; }
                set { REASON_FOR_VISITx = value; }
            }
            public string ENCNTR_FINANCIAL_ID
            {
                get { return ENCNTR_FINANCIAL_IDx; }
                set { ENCNTR_FINANCIAL_IDx = value; }
            }
            public string NAME_FIRST_SYNONYM_ID
            {
                get { return NAME_FIRST_SYNONYM_IDx; }
                set { NAME_FIRST_SYNONYM_IDx = value; }
            }
            public string FINANCIAL_CLASS_CD
            {
                get { return FINANCIAL_CLASS_CDx; }
                set { FINANCIAL_CLASS_CDx = value; }
            }
            public string BBD_PROCEDURE_CD
            {
                get { return BBD_PROCEDURE_CDx; }
                set { BBD_PROCEDURE_CDx = value; }
            }
            public string INFO_GIVEN_BY
            {
                get { return INFO_GIVEN_BYx; }
                set { INFO_GIVEN_BYx = value; }
            }
            public string SAFEKEEPING_CD
            {
                get { return SAFEKEEPING_CDx; }
                set { SAFEKEEPING_CDx = value; }
            }
            public string TRAUMA_CD
            {
                get { return TRAUMA_CDx; }
                set { TRAUMA_CDx = value; }
            }
            public string TRIAGE_CD
            {
                get { return TRIAGE_CDx; }
                set { TRIAGE_CDx = value; }
            }
            public string TRIAGE_DT_TM
            {
                get { return TRIAGE_DT_TMx; }
                set { TRIAGE_DT_TMx = value; }
            }
            public string VISITOR_STATUS_CD
            {
                get { return VISITOR_STATUS_CDx; }
                set { VISITOR_STATUS_CDx = value; }
            }
            public string VALUABLES_CD
            {
                get { return VALUABLES_CDx; }
                set { VALUABLES_CDx = value; }
            }
            public string SECURITY_ACCESS_CD
            {
                get { return SECURITY_ACCESS_CDx; }
                set { SECURITY_ACCESS_CDx = value; }
            }
            public string REFER_FACILITY_CD
            {
                get { return REFER_FACILITY_CDx; }
                set { REFER_FACILITY_CDx = value; }
            }
            public string TRAUMA_DT_TM
            {
                get { return TRAUMA_DT_TMx; }
                set { TRAUMA_DT_TMx = value; }
            }
            public string ACCOMP_BY_CD
            {
                get { return ACCOMP_BY_CDx; }
                set { ACCOMP_BY_CDx = value; }
            }
            public string ACCOMMODATION_REASON_CD
            {
                get { return ACCOMMODATION_REASON_CDx; }
                set { ACCOMMODATION_REASON_CDx = value; }
            }
            public string CHART_COMPLETE_DT_TM
            {
                get { return CHART_COMPLETE_DT_TMx; }
                set { CHART_COMPLETE_DT_TMx = value; }
            }
            public string ZERO_BALANCE_DT_TM
            {
                get { return ZERO_BALANCE_DT_TMx; }
                set { ZERO_BALANCE_DT_TMx = value; }
            }
            public string ARCHIVE_DT_TM_EST
            {
                get { return ARCHIVE_DT_TM_ESTx; }
                set { ARCHIVE_DT_TM_ESTx = value; }
            }
            public string ARCHIVE_DT_TM_ACT
            {
                get { return ARCHIVE_DT_TM_ACTx; }
                set { ARCHIVE_DT_TM_ACTx = value; }
            }
            public string PURGE_DT_TM_EST
            {
                get { return PURGE_DT_TM_ESTx; }
                set { PURGE_DT_TM_ESTx = value; }
            }
            public string PURGE_DT_TM_ACT
            {
                get { return PURGE_DT_TM_ACTx; }
                set { PURGE_DT_TM_ACTx = value; }
            }
            public string ENCNTR_COMPLETE_DT_TM
            {
                get { return ENCNTR_COMPLETE_DT_TMx; }
                set { ENCNTR_COMPLETE_DT_TMx = value; }
            }
            public string PA_CURRENT_STATUS_CD
            {
                get { return PA_CURRENT_STATUS_CDx; }
                set { PA_CURRENT_STATUS_CDx = value; }
            }
            public string PA_CURRENT_STATUS_DT_TM
            {
                get { return PA_CURRENT_STATUS_DT_TMx; }
                set { PA_CURRENT_STATUS_DT_TMx = value; }
            }
            public string PARENT_RET_CRITERIA_ID
            {
                get { return PARENT_RET_CRITERIA_IDx; }
                set { PARENT_RET_CRITERIA_IDx = value; }
            }
            public string SERVICE_CATEGORY_CD
            {
                get { return SERVICE_CATEGORY_CDx; }
                set { SERVICE_CATEGORY_CDx = value; }
            }
            public string CONTRACT_STATUS_CD
            {
                get { return CONTRACT_STATUS_CDx; }
                set { CONTRACT_STATUS_CDx = value; }
            }
            public string EST_LENGTH_OF_STAY
            {
                get { return EST_LENGTH_OF_STAYx; }
                set { EST_LENGTH_OF_STAYx = value; }
            }
            public string ALT_LVL_CARE_CD
            {
                get { return ALT_LVL_CARE_CDx; }
                set { ALT_LVL_CARE_CDx = value; }
            }
            public string ASSIGN_TO_LOC_DT_TM
            {
                get { return ASSIGN_TO_LOC_DT_TMx; }
                set { ASSIGN_TO_LOC_DT_TMx = value; }
            }
            public string PROGRAM_SERVICE_CD
            {
                get { return PROGRAM_SERVICE_CDx; }
                set { PROGRAM_SERVICE_CDx = value; }
            }
            public string SPECIALTY_UNIT_CD
            {
                get { return SPECIALTY_UNIT_CDx; }
                set { SPECIALTY_UNIT_CDx = value; }
            }
            public string MENTAL_HEALTH_DT_TM
            {
                get { return MENTAL_HEALTH_DT_TMx; }
                set { MENTAL_HEALTH_DT_TMx = value; }
            }
            public string MENTAL_HEALTH_CD
            {
                get { return MENTAL_HEALTH_CDx; }
                set { MENTAL_HEALTH_CDx = value; }
            }
            public string DOC_RCVD_DT_TM
            {
                get { return DOC_RCVD_DT_TMx; }
                set { DOC_RCVD_DT_TMx = value; }
            }
            public string REFERRAL_RCVD_DT_TM
            {
                get { return REFERRAL_RCVD_DT_TMx; }
                set { REFERRAL_RCVD_DT_TMx = value; }
            }
            public string ALT_LVL_CARE_DT_TM
            {
                get { return ALT_LVL_CARE_DT_TMx; }
                set { ALT_LVL_CARE_DT_TMx = value; }
            }
            public string ALC_DECOMP_DT_TM
            {
                get { return ALC_DECOMP_DT_TMx; }
                set { ALC_DECOMP_DT_TMx = value; }
            }
            public string REGION_CD
            {
                get { return REGION_CDx; }
                set { REGION_CDx = value; }
            }
            public string SITTER_REQUIRED_CD
            {
                get { return SITTER_REQUIRED_CDx; }
                set { SITTER_REQUIRED_CDx = value; }
            }
            public string ALC_REASON_CD
            {
                get { return ALC_REASON_CDx; }
                set { ALC_REASON_CDx = value; }
            }
            public string PLACEMENT_AUTH_PRSNL_ID
            {
                get { return PLACEMENT_AUTH_PRSNL_IDx; }
                set { PLACEMENT_AUTH_PRSNL_IDx = value; }
            }
            public string PATIENT_CLASSIFICATION_CD
            {
                get { return PATIENT_CLASSIFICATION_CDx; }
                set { PATIENT_CLASSIFICATION_CDx = value; }
            }
            public string MENTAL_CATEGORY_CD
            {
                get { return MENTAL_CATEGORY_CDx; }
                set { MENTAL_CATEGORY_CDx = value; }
            }
            public string PSYCHIATRIC_STATUS_CD
            {
                get { return PSYCHIATRIC_STATUS_CDx; }
                set { PSYCHIATRIC_STATUS_CDx = value; }
            }
            public string INPATIENT_ADMIT_DT_TM
            {
                get { return INPATIENT_ADMIT_DT_TMx; }
                set { INPATIENT_ADMIT_DT_TMx = value; }
            }
            public string RESULT_ACCUMULATION_DT_TM
            {
                get { return RESULT_ACCUMULATION_DT_TMx; }
                set { RESULT_ACCUMULATION_DT_TMx = value; }
            }
            public string PREGNANCY_STATUS_CD
            {
                get { return PREGNANCY_STATUS_CDx; }
                set { PREGNANCY_STATUS_CDx = value; }
            }
            public string INITIAL_CONTACT_DT_TM
            {
                get { return INITIAL_CONTACT_DT_TMx; }
                set { INITIAL_CONTACT_DT_TMx = value; }
            }
            public string ONSET_DT_TM
            {
                get { return ONSET_DT_TMx; }
                set { ONSET_DT_TMx = value; }
            }
            public string LAST_MENSTRUAL_PERIOD_DT_TM
            {
                get { return LAST_MENSTRUAL_PERIOD_DT_TMx; }
                set { LAST_MENSTRUAL_PERIOD_DT_TMx = value; }
            }
            public string EXPECTED_DELIVERY_DT_TM
            {
                get { return EXPECTED_DELIVERY_DT_TMx; }
                set { EXPECTED_DELIVERY_DT_TMx = value; }
            }
            public string ABN_STATUS_CD
            {
                get { return ABN_STATUS_CDx; }
                set { ABN_STATUS_CDx = value; }
            }
            public string LEVEL_OF_SERVICE_CD
            {
                get { return LEVEL_OF_SERVICE_CDx; }
                set { LEVEL_OF_SERVICE_CDx = value; }
            }
            public string PLACE_OF_SVC_ADMIT_DT_TM
            {
                get { return PLACE_OF_SVC_ADMIT_DT_TMx; }
                set { PLACE_OF_SVC_ADMIT_DT_TMx = value; }
            }
            public string PLACE_OF_SVC_TYPE_CD
            {
                get { return PLACE_OF_SVC_TYPE_CDx; }
                set { PLACE_OF_SVC_TYPE_CDx = value; }
            }
            public string PLACE_OF_SVC_ORG_ID
            {
                get { return PLACE_OF_SVC_ORG_IDx; }
                set { PLACE_OF_SVC_ORG_IDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string EST_FINANCIAL_RESP_AMT
            {
                get { return EST_FINANCIAL_RESP_AMTx; }
                set { EST_FINANCIAL_RESP_AMTx = value; }
            }
            public string REFERRAL_SOURCE_CD
            {
                get { return REFERRAL_SOURCE_CDx; }
                set { REFERRAL_SOURCE_CDx = value; }
            }
            public string ADMIT_DECISION_DT_TM
            {
                get { return ADMIT_DECISION_DT_TMx; }
                set { ADMIT_DECISION_DT_TMx = value; }
            }
            public string ACCIDENT_RELATED_IND
            {
                get { return ACCIDENT_RELATED_INDx; }
                set { ACCIDENT_RELATED_INDx = value; }
            }
            public string DISCH_PRSNL_ID
            {
                get { return DISCH_PRSNL_IDx; }
                set { DISCH_PRSNL_IDx = value; }
            }
            public string PAYMENT_COLLECTION_STATUS_CD
            {
                get { return PAYMENT_COLLECTION_STATUS_CDx; }
                set { PAYMENT_COLLECTION_STATUS_CDx = value; }
            }
            public string ORDER_SOURCE_CD
            {
                get { return ORDER_SOURCE_CDx; }
                set { ORDER_SOURCE_CDx = value; }
            }
            public string ADMIT_EARLY_IND
            {
                get { return ADMIT_EARLY_INDx; }
                set { ADMIT_EARLY_INDx = value; }
            }
            public string TREATMENT_PHASE_CD
            {
                get { return TREATMENT_PHASE_CDx; }
                set { TREATMENT_PHASE_CDx = value; }
            }
            public string KIOSK_QUEUE_NBR_TXT
            {
                get { return KIOSK_QUEUE_NBR_TXTx; }
                set { KIOSK_QUEUE_NBR_TXTx = value; }
            }
            public string KIOSK_QUEUE_NBR_DT_TM
            {
                get { return KIOSK_QUEUE_NBR_DT_TMx; }
                set { KIOSK_QUEUE_NBR_DT_TMx = value; }
            }
            public string CLU_SUBKEY1_FLAG
            {
                get { return CLU_SUBKEY1_FLAGx; }
                set { CLU_SUBKEY1_FLAGx = value; }
            }
            public string REFER_TO_UNIT_STAFF_CD
            {
                get { return REFER_TO_UNIT_STAFF_CDx; }
                set { REFER_TO_UNIT_STAFF_CDx = value; }
            }
            public string LODGER_CD
            {
                get { return LODGER_CDx; }
                set { LODGER_CDx = value; }
            }
            public string COMPLETE_REG_DT_TM
            {
                get { return COMPLETE_REG_DT_TMx; }
                set { COMPLETE_REG_DT_TMx = value; }
            }
            public string COMPLETE_REG_PRSNL_ID
            {
                get { return COMPLETE_REG_PRSNL_IDx; }
                set { COMPLETE_REG_PRSNL_IDx = value; }
            }
            public string CLERGY_VISIT_CD
            {
                get { return CLERGY_VISIT_CDx; }
                set { CLERGY_VISIT_CDx = value; }
            }
            public string CLIENT_ORGANIZATION_ID
            {
                get { return CLIENT_ORGANIZATION_IDx; }
                set { CLIENT_ORGANIZATION_IDx = value; }
            }
            public string PERSON_PLAN_PROFILE_TYPE_CD
            {
                get { return PERSON_PLAN_PROFILE_TYPE_CDx; }
                set { PERSON_PLAN_PROFILE_TYPE_CDx = value; }
            }
            public string MILITARY_SERVICE_RELATED_CD
            {
                get { return MILITARY_SERVICE_RELATED_CDx; }
                set { MILITARY_SERVICE_RELATED_CDx = value; }
            }
            public string INCIDENT_CD
            {
                get { return INCIDENT_CDx; }
                set { INCIDENT_CDx = value; }
            }
            public string ED_REFERRAL_SOURCE_CD
            {
                get { return ED_REFERRAL_SOURCE_CDx; }
                set { ED_REFERRAL_SOURCE_CDx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //ENCOUNTER: ORGANIZATION_ID,ENCNTR_ID,PERSON_ID,REG_DT_TM,DISCH_DT_TM,ENCNTR_TYPE_CD,FINANCIAL_CLASS_CD,LOC_NURSE_UNIT_CD,ARRIVE_DT_TM,
                //ADMIT_TYPE_CD,ENCNTR_TYPE_CD,ADMIT_MODE_CD,ADMIT_SRC_CD,EST_LENGTH_OF_STAY,REASON_FOR_VISIT,DISCH_DISPOSITION_CD,TRIAGE_DT_TM,
                //ACTIVE_IND,END_EFFECTIVE_DT_TM

                string[] recs = i_record.Split('|');
                ORGANIZATION_IDx = recs[0].Trim();
                ENCNTR_IDx = recs[1].Trim();
                PERSON_IDx = recs[2].Trim();
                REG_DT_TMx = recs[3].Trim();
                DISCH_DT_TMx = recs[4].Trim();
                ENCNTR_TYPE_CDx = recs[5].Trim();
                FINANCIAL_CLASS_CDx = recs[6].Trim();
                LOC_NURSE_UNIT_CDx = recs[7].Trim();
                ARRIVE_DT_TMx = recs[8].Trim();
                ADMIT_TYPE_CDx = recs[9].Trim();
                ENCNTR_TYPE_CDx = recs[10].Trim();
                ADMIT_MODE_CDx = recs[11].Trim();
                ADMIT_SRC_CDx = recs[12].Trim();
                EST_LENGTH_OF_STAYx = recs[13].Trim();
                REASON_FOR_VISITx = recs[14].Trim();
                DISCH_DISPOSITION_CDx = recs[15].Trim();
                TRIAGE_DT_TMx = recs[16].Trim();
                ACTIVE_INDx = recs[17].Trim();
                END_EFFECTIVE_DT_TMx = recs[18].Trim();
                INPATIENT_ADMIT_DT_TMx = recs[19].Trim();


                //ENCNTR_IDx = recs[0].Trim();
                //PERSON_IDx = recs[1].Trim();
                ////UPDT_CNTx = recs[2].Trim();
                ////UPDT_DT_TMx = recs[3].Trim();
                ////UPDT_IDx = recs[4].Trim();
                ////UPDT_TASKx = recs[5].Trim();
                ////UPDT_APPLCTXx = recs[6].Trim();
                //ACTIVE_INDx = recs[7].Trim();
                ////ACTIVE_STATUS_CDx = recs[8].Trim();
                ////ACTIVE_STATUS_DT_TMx = recs[9].Trim();
                ////ACTIVE_STATUS_PRSNL_IDx = recs[10].Trim();
                //CREATE_DT_TMx = recs[11].Trim();
                //CREATE_PRSNL_IDx = recs[12].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[13].Trim();
                //END_EFFECTIVE_DT_TMx = recs[14].Trim();
                //ENCNTR_CLASS_CDx = recs[15].Trim();
                //ENCNTR_TYPE_CDx = recs[16].Trim();
                //ENCNTR_TYPE_CLASS_CDx = recs[17].Trim();
                //ENCNTR_STATUS_CDx = recs[18].Trim();
                //PRE_REG_DT_TMx = recs[19].Trim();
                //PRE_REG_PRSNL_IDx = recs[20].Trim();
                //REG_DT_TMx = recs[21].Trim();
                //REG_PRSNL_IDx = recs[22].Trim();
                //EST_ARRIVE_DT_TMx = recs[23].Trim();
                //EST_DEPART_DT_TMx = recs[24].Trim();
                //ARRIVE_DT_TMx = recs[25].Trim();
                //DEPART_DT_TMx = recs[26].Trim();
                //ADMIT_TYPE_CDx = recs[27].Trim();
                //ADMIT_SRC_CDx = recs[28].Trim();
                //ADMIT_MODE_CDx = recs[29].Trim();
                //ADMIT_WITH_MEDICATION_CDx = recs[30].Trim();
                //REFERRING_COMMENTx = recs[31].Trim();
                //DISCH_DISPOSITION_CDx = recs[32].Trim();
                //DISCH_TO_LOCTN_CDx = recs[33].Trim();
                //PREADMIT_NBRx = recs[34].Trim();
                //PREADMIT_TESTING_CDx = recs[35].Trim();
                //READMIT_CDx = recs[36].Trim();
                //ACCOMMODATION_CDx = recs[37].Trim();
                //ACCOMMODATION_REQUEST_CDx = recs[38].Trim();
                //ALT_RESULT_DEST_CDx = recs[39].Trim();
                //AMBULATORY_COND_CDx = recs[40].Trim();
                ////COURTESY_CDx = recs[41].Trim();
                ////DIET_TYPE_CDx = recs[42].Trim();
                ////ISOLATION_CDx = recs[43].Trim();
                //MED_SERVICE_CDx = recs[44].Trim();
                //RESULT_DEST_CDx = recs[45].Trim();
                //CONFID_LEVEL_CDx = recs[46].Trim();
                //VIP_CDx = recs[47].Trim();
                ////NAME_LAST_KEYx = recs[48].Trim();
                ////NAME_FIRST_KEYx = recs[49].Trim();
                ////NAME_FULL_FORMATTEDx = recs[50].Trim();
                ////NAME_LASTx = recs[51].Trim();
                ////NAME_FIRSTx = recs[52].Trim();
                ////NAME_PHONETICx = recs[53].Trim();
                //SEX_CDx = recs[54].Trim();
                //BIRTH_DT_CDx = recs[55].Trim();
                //BIRTH_DT_TMx = recs[56].Trim();
                ////SPECIES_CDx = recs[57].Trim();
                ////DATA_STATUS_CDx = recs[58].Trim();
                ////DATA_STATUS_DT_TMx = recs[59].Trim();
                ////DATA_STATUS_PRSNL_IDx = recs[60].Trim();
                ////CONTRIBUTOR_SYSTEM_CDx = recs[61].Trim();
                //LOCATION_CDx = recs[62].Trim();
                //LOC_FACILITY_CDx = recs[63].Trim();
                //LOC_BUILDING_CDx = recs[64].Trim();
                //LOC_NURSE_UNIT_CDx = recs[65].Trim();
                //LOC_ROOM_CDx = recs[66].Trim();
                //LOC_BED_CDx = recs[67].Trim();
                //DISCH_DT_TMx = recs[68].Trim();
                //GUARANTOR_TYPE_CDx = recs[69].Trim();
                //LOC_TEMP_CDx = recs[70].Trim();
                //ORGANIZATION_IDx = recs[71].Trim();
                //REASON_FOR_VISITx = recs[72].Trim();
                //ENCNTR_FINANCIAL_IDx = recs[73].Trim();
                //NAME_FIRST_SYNONYM_IDx = recs[74].Trim();
                //FINANCIAL_CLASS_CDx = recs[75].Trim();
                ////BBD_PROCEDURE_CDx = recs[76].Trim();
                ////INFO_GIVEN_BYx = recs[77].Trim();
                ////SAFEKEEPING_CDx = recs[78].Trim();
                //TRAUMA_CDx = recs[79].Trim();
                //TRIAGE_CDx = recs[80].Trim();
                //TRIAGE_DT_TMx = recs[81].Trim();
                //VISITOR_STATUS_CDx = recs[82].Trim();
                ////VALUABLES_CDx = recs[83].Trim();
                ////SECURITY_ACCESS_CDx = recs[84].Trim();
                //REFER_FACILITY_CDx = recs[85].Trim();
                //TRAUMA_DT_TMx = recs[86].Trim();
                //ACCOMP_BY_CDx = recs[87].Trim();
                //ACCOMMODATION_REASON_CDx = recs[88].Trim();
                ////CHART_COMPLETE_DT_TMx = recs[89].Trim();
                ////ZERO_BALANCE_DT_TMx = recs[90].Trim();
                ////ARCHIVE_DT_TM_ESTx = recs[91].Trim();
                ////ARCHIVE_DT_TM_ACTx = recs[92].Trim();
                ////PURGE_DT_TM_ESTx = recs[93].Trim();
                ////PURGE_DT_TM_ACTx = recs[94].Trim();
                //ENCNTR_COMPLETE_DT_TMx = recs[95].Trim();
                //PA_CURRENT_STATUS_CDx = recs[96].Trim();
                //PA_CURRENT_STATUS_DT_TMx = recs[97].Trim();
                //PARENT_RET_CRITERIA_IDx = recs[98].Trim();
                //SERVICE_CATEGORY_CDx = recs[99].Trim();
                //CONTRACT_STATUS_CDx = recs[100].Trim();
                //EST_LENGTH_OF_STAYx = recs[101].Trim();
                //ALT_LVL_CARE_CDx = recs[102].Trim();
                ////ASSIGN_TO_LOC_DT_TMx = recs[103].Trim();
                ////PROGRAM_SERVICE_CDx = recs[104].Trim();
                ////SPECIALTY_UNIT_CDx = recs[105].Trim();
                ////MENTAL_HEALTH_DT_TMx = recs[106].Trim();
                ////MENTAL_HEALTH_CDx = recs[107].Trim();
                ////DOC_RCVD_DT_TMx = recs[108].Trim();
                ////REFERRAL_RCVD_DT_TMx = recs[109].Trim();
                ////ALT_LVL_CARE_DT_TMx = recs[110].Trim();
                ////ALC_DECOMP_DT_TMx = recs[111].Trim();
                //REGION_CDx = recs[112].Trim();
                ////SITTER_REQUIRED_CDx = recs[113].Trim();
                ////ALC_REASON_CDx = recs[114].Trim();
                ////PLACEMENT_AUTH_PRSNL_IDx = recs[115].Trim();
                ////PATIENT_CLASSIFICATION_CDx = recs[116].Trim();
                ////MENTAL_CATEGORY_CDx = recs[117].Trim();
                ////PSYCHIATRIC_STATUS_CDx = recs[118].Trim();
                //INPATIENT_ADMIT_DT_TMx = recs[119].Trim();
                ////RESULT_ACCUMULATION_DT_TMx = recs[120].Trim();
                ////PREGNANCY_STATUS_CDx = recs[121].Trim();
                ////INITIAL_CONTACT_DT_TMx = recs[122].Trim();
                ////ONSET_DT_TMx = recs[123].Trim();
                //LAST_MENSTRUAL_PERIOD_DT_TMx = recs[124].Trim();
                //EXPECTED_DELIVERY_DT_TMx = recs[125].Trim();
                //ABN_STATUS_CDx = recs[126].Trim();
                //LEVEL_OF_SERVICE_CDx = recs[127].Trim();
                //PLACE_OF_SVC_ADMIT_DT_TMx = recs[128].Trim();
                //PLACE_OF_SVC_TYPE_CDx = recs[129].Trim();
                //PLACE_OF_SVC_ORG_IDx = recs[130].Trim();
                ////LAST_UTC_TSx = recs[131].Trim();
                ////EST_FINANCIAL_RESP_AMTx = recs[132].Trim();
                ////REFERRAL_SOURCE_CDx = recs[133].Trim();
                ////ADMIT_DECISION_DT_TMx = recs[134].Trim();
                ////ACCIDENT_RELATED_INDx = recs[135].Trim();
                ////DISCH_PRSNL_IDx = recs[136].Trim();
                ////PAYMENT_COLLECTION_STATUS_CDx = recs[137].Trim();
                ////ORDER_SOURCE_CDx = recs[138].Trim();
                ////ADMIT_EARLY_INDx = recs[139].Trim();
                ////TREATMENT_PHASE_CDx = recs[140].Trim();
                ////KIOSK_QUEUE_NBR_TXTx = recs[141].Trim();
                ////KIOSK_QUEUE_NBR_DT_TMx = recs[142].Trim();
                ////CLU_SUBKEY1_FLAGx = recs[143].Trim();
                ////REFER_TO_UNIT_STAFF_CDx = recs[144].Trim();
                ////LODGER_CDx = recs[145].Trim();
                //COMPLETE_REG_DT_TMx = recs[146].Trim();
                //COMPLETE_REG_PRSNL_IDx = recs[147].Trim();
                ////CLERGY_VISIT_CDx = recs[148].Trim();
                //CLIENT_ORGANIZATION_IDx = recs[149].Trim();
                ////PERSON_PLAN_PROFILE_TYPE_CDx = recs[150].Trim();
                ////MILITARY_SERVICE_RELATED_CDx = recs[151].Trim();
                ////INCIDENT_CDx = recs[152].Trim();
                //ED_REFERRAL_SOURCE_CDx = recs[153].Trim();
                ////INST_IDx = recs[154].Trim();
            }
        }
        public struct CODE_VALUE
        {
            private string CODE_VALUEx;
            private string CODE_SETx;
            private string CDF_MEANINGx;
            private string DISPLAYx;
            private string DISPLAY_KEYx;
            private string DESCRIPTIONx;
            private string DEFINITIONx;
            private string COLLATION_SEQx;
            private string ACTIVE_TYPE_CDx;
            private string ACTIVE_INDx;
            private string ACTIVE_DT_TMx;
            private string INACTIVE_DT_TMx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_CNTx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string BEGIN_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string CKIx;
            private string DISPLAY_KEY_NLSx;
            private string CONCEPT_CKIx;
            private string DISPLAY_KEY_A_NLSx;
            private string LAST_UTC_TSx;
            private string CLU_SUBKEY1_FLAGx;
            private string INST_IDx;

            public void Clear()
            {
                CODE_VALUEx = "";
                CODE_SETx = "";
                CDF_MEANINGx = "";
                DISPLAYx = "";
                DISPLAY_KEYx = "";
                DESCRIPTIONx = "";
                DEFINITIONx = "";
                COLLATION_SEQx = "";
                ACTIVE_TYPE_CDx = "";
                ACTIVE_INDx = "";
                ACTIVE_DT_TMx = "";
                INACTIVE_DT_TMx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_CNTx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                BEGIN_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                CKIx = "";
                DISPLAY_KEY_NLSx = "";
                CONCEPT_CKIx = "";
                DISPLAY_KEY_A_NLSx = "";
                LAST_UTC_TSx = "";
                CLU_SUBKEY1_FLAGx = "";
                INST_IDx = "";
            }

            public string CODE_VALUE_VAL
            {
                get { return CODE_VALUEx; }
                set { CODE_VALUEx = value; }
            }
            public string CODE_SET
            {
                get { return CODE_SETx; }
                set { CODE_SETx = value; }
            }
            public string CDF_MEANING
            {
                get { return CDF_MEANINGx; }
                set { CDF_MEANINGx = value; }
            }
            public string DISPLAY
            {
                get { return DISPLAYx; }
                set { DISPLAYx = value; }
            }
            public string DISPLAY_KEY
            {
                get { return DISPLAY_KEYx; }
                set { DISPLAY_KEYx = value; }
            }
            public string DESCRIPTION
            {
                get { return DESCRIPTIONx; }
                set { DESCRIPTIONx = value; }
            }
            public string DEFINITION
            {
                get { return DEFINITIONx; }
                set { DEFINITIONx = value; }
            }
            public string COLLATION_SEQ
            {
                get { return COLLATION_SEQx; }
                set { COLLATION_SEQx = value; }
            }
            public string ACTIVE_TYPE_CD
            {
                get { return ACTIVE_TYPE_CDx; }
                set { ACTIVE_TYPE_CDx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_DT_TM
            {
                get { return ACTIVE_DT_TMx; }
                set { ACTIVE_DT_TMx = value; }
            }
            public string INACTIVE_DT_TM
            {
                get { return INACTIVE_DT_TMx; }
                set { INACTIVE_DT_TMx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string BEGIN_EFFECTIVE_DT_TM
            {
                get { return BEGIN_EFFECTIVE_DT_TMx; }
                set { BEGIN_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string CKI
            {
                get { return CKIx; }
                set { CKIx = value; }
            }
            public string DISPLAY_KEY_NLS
            {
                get { return DISPLAY_KEY_NLSx; }
                set { DISPLAY_KEY_NLSx = value; }
            }
            public string CONCEPT_CKI
            {
                get { return CONCEPT_CKIx; }
                set { CONCEPT_CKIx = value; }
            }
            public string DISPLAY_KEY_A_NLS
            {
                get { return DISPLAY_KEY_A_NLSx; }
                set { DISPLAY_KEY_A_NLSx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string CLU_SUBKEY1_FLAG
            {
                get { return CLU_SUBKEY1_FLAGx; }
                set { CLU_SUBKEY1_FLAGx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                string[] recs = i_record.Split('|');
                CODE_VALUEx = recs[0].Trim();
                CODE_SETx = recs[1].Trim();
                CDF_MEANINGx = recs[2].Trim();
                DISPLAYx = recs[3].Trim();
                DISPLAY_KEYx = recs[4].Trim();
                DESCRIPTIONx = recs[5].Trim();
                DEFINITIONx = recs[6].Trim();
                COLLATION_SEQx = recs[7].Trim();
                ACTIVE_TYPE_CDx = recs[8].Trim();
                ACTIVE_INDx = recs[9].Trim();
                ACTIVE_DT_TMx = recs[10].Trim();
                INACTIVE_DT_TMx = recs[11].Trim();
                UPDT_DT_TMx = recs[12].Trim();
                UPDT_IDx = recs[13].Trim();
                UPDT_CNTx = recs[14].Trim();
                UPDT_TASKx = recs[15].Trim();
                UPDT_APPLCTXx = recs[16].Trim();
                BEGIN_EFFECTIVE_DT_TMx = recs[17].Trim();
                END_EFFECTIVE_DT_TMx = recs[18].Trim();
                DATA_STATUS_CDx = recs[19].Trim();
                DATA_STATUS_DT_TMx = recs[20].Trim();
                DATA_STATUS_PRSNL_IDx = recs[21].Trim();
                ACTIVE_STATUS_PRSNL_IDx = recs[22].Trim();
                CKIx = recs[23].Trim();
                DISPLAY_KEY_NLSx = recs[24].Trim();
                CONCEPT_CKIx = recs[25].Trim();
                DISPLAY_KEY_A_NLSx = recs[26].Trim();
                LAST_UTC_TSx = recs[27].Trim();
                CLU_SUBKEY1_FLAGx = recs[28].Trim();
                INST_IDx = recs[29].Trim();
            }

        }
        public struct DIAGNOSIS
        {
            private string DIAGNOSIS_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string PERSON_IDx;
            private string ENCNTR_IDx;
            private string NOMENCLATURE_IDx;
            private string DIAG_DT_TMx;
            private string DIAG_TYPE_CDx;
            private string DIAGNOSTIC_CATEGORY_CDx;
            private string DIAG_PRIORITYx;
            private string DIAG_PRSNL_IDx;
            private string DIAG_PRSNL_NAMEx;
            private string DIAG_CLASS_CDx;
            private string CONFID_LEVEL_CDx;
            private string ATTESTATION_DT_TMx;
            private string REFERENCE_NBRx;
            private string SEG_UNIQUE_KEYx;
            private string DIAG_FTDESCx;
            private string MOD_NOMENCLATURE_IDx;
            private string SVC_CAT_HIST_IDx;
            private string DIAG_NOTEx;
            private string CONDITIONAL_QUAL_CDx;
            private string CLINICAL_SERVICE_CDx;
            private string CONFIRMATION_STATUS_CDx;
            private string CLASSIFICATION_CDx;
            private string SEVERITY_CLASS_CDx;
            private string CERTAINTY_CDx;
            private string PROBABILITYx;
            private string DIAGNOSIS_DISPLAYx;
            private string SEVERITY_FTDESCx;
            private string LONG_BLOB_IDx;
            private string RANKING_CDx;
            private string SEVERITY_CDx;
            private string DIAGNOSIS_GROUPx;
            private string CLINICAL_DIAG_PRIORITYx;
            private string ENCNTR_SLICE_IDx;
            private string PRESENT_ON_ADMIT_CDx;
            private string HAC_INDx;
            private string LATERALITY_CDx;
            private string ORIGINATING_NOMENCLATURE_IDx;
            private string LAST_UTC_TSx;
            private string CLU_SUBKEY1_FLAGx;
            private string INST_IDx;

            public void Clear()
            {
                DIAGNOSIS_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                PERSON_IDx = "";
                ENCNTR_IDx = "";
                NOMENCLATURE_IDx = "";
                DIAG_DT_TMx = "";
                DIAG_TYPE_CDx = "";
                DIAGNOSTIC_CATEGORY_CDx = "";
                DIAG_PRIORITYx = "";
                DIAG_PRSNL_IDx = "";
                DIAG_PRSNL_NAMEx = "";
                DIAG_CLASS_CDx = "";
                CONFID_LEVEL_CDx = "";
                ATTESTATION_DT_TMx = "";
                REFERENCE_NBRx = "";
                SEG_UNIQUE_KEYx = "";
                DIAG_FTDESCx = "";
                MOD_NOMENCLATURE_IDx = "";
                SVC_CAT_HIST_IDx = "";
                DIAG_NOTEx = "";
                CONDITIONAL_QUAL_CDx = "";
                CLINICAL_SERVICE_CDx = "";
                CONFIRMATION_STATUS_CDx = "";
                CLASSIFICATION_CDx = "";
                SEVERITY_CLASS_CDx = "";
                CERTAINTY_CDx = "";
                PROBABILITYx = "";
                DIAGNOSIS_DISPLAYx = "";
                SEVERITY_FTDESCx = "";
                LONG_BLOB_IDx = "";
                RANKING_CDx = "";
                SEVERITY_CDx = "";
                DIAGNOSIS_GROUPx = "";
                CLINICAL_DIAG_PRIORITYx = "";
                ENCNTR_SLICE_IDx = "";
                PRESENT_ON_ADMIT_CDx = "";
                HAC_INDx = "";
                LATERALITY_CDx = "";
                ORIGINATING_NOMENCLATURE_IDx = "";
                LAST_UTC_TSx = "";
                CLU_SUBKEY1_FLAGx = "";
                INST_IDx = "";
            }

            public string DIAGNOSIS_ID
            {
                get { return DIAGNOSIS_IDx; }
                set { DIAGNOSIS_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string NOMENCLATURE_ID
            {
                get { return NOMENCLATURE_IDx; }
                set { NOMENCLATURE_IDx = value; }
            }
            public string DIAG_DT_TM
            {
                get { return DIAG_DT_TMx; }
                set { DIAG_DT_TMx = value; }
            }
            public string DIAG_TYPE_CD
            {
                get { return DIAG_TYPE_CDx; }
                set { DIAG_TYPE_CDx = value; }
            }
            public string DIAGNOSTIC_CATEGORY_CD
            {
                get { return DIAGNOSTIC_CATEGORY_CDx; }
                set { DIAGNOSTIC_CATEGORY_CDx = value; }
            }
            public string DIAG_PRIORITY
            {
                get { return DIAG_PRIORITYx; }
                set { DIAG_PRIORITYx = value; }
            }
            public string DIAG_PRSNL_ID
            {
                get { return DIAG_PRSNL_IDx; }
                set { DIAG_PRSNL_IDx = value; }
            }
            public string DIAG_PRSNL_NAME
            {
                get { return DIAG_PRSNL_NAMEx; }
                set { DIAG_PRSNL_NAMEx = value; }
            }
            public string DIAG_CLASS_CD
            {
                get { return DIAG_CLASS_CDx; }
                set { DIAG_CLASS_CDx = value; }
            }
            public string CONFID_LEVEL_CD
            {
                get { return CONFID_LEVEL_CDx; }
                set { CONFID_LEVEL_CDx = value; }
            }
            public string ATTESTATION_DT_TM
            {
                get { return ATTESTATION_DT_TMx; }
                set { ATTESTATION_DT_TMx = value; }
            }
            public string REFERENCE_NBR
            {
                get { return REFERENCE_NBRx; }
                set { REFERENCE_NBRx = value; }
            }
            public string SEG_UNIQUE_KEY
            {
                get { return SEG_UNIQUE_KEYx; }
                set { SEG_UNIQUE_KEYx = value; }
            }
            public string DIAG_FTDESC
            {
                get { return DIAG_FTDESCx; }
                set { DIAG_FTDESCx = value; }
            }
            public string MOD_NOMENCLATURE_ID
            {
                get { return MOD_NOMENCLATURE_IDx; }
                set { MOD_NOMENCLATURE_IDx = value; }
            }
            public string SVC_CAT_HIST_ID
            {
                get { return SVC_CAT_HIST_IDx; }
                set { SVC_CAT_HIST_IDx = value; }
            }
            public string DIAG_NOTE
            {
                get { return DIAG_NOTEx; }
                set { DIAG_NOTEx = value; }
            }
            public string CONDITIONAL_QUAL_CD
            {
                get { return CONDITIONAL_QUAL_CDx; }
                set { CONDITIONAL_QUAL_CDx = value; }
            }
            public string CLINICAL_SERVICE_CD
            {
                get { return CLINICAL_SERVICE_CDx; }
                set { CLINICAL_SERVICE_CDx = value; }
            }
            public string CONFIRMATION_STATUS_CD
            {
                get { return CONFIRMATION_STATUS_CDx; }
                set { CONFIRMATION_STATUS_CDx = value; }
            }
            public string CLASSIFICATION_CD
            {
                get { return CLASSIFICATION_CDx; }
                set { CLASSIFICATION_CDx = value; }
            }
            public string SEVERITY_CLASS_CD
            {
                get { return SEVERITY_CLASS_CDx; }
                set { SEVERITY_CLASS_CDx = value; }
            }
            public string CERTAINTY_CD
            {
                get { return CERTAINTY_CDx; }
                set { CERTAINTY_CDx = value; }
            }
            public string PROBABILITY
            {
                get { return PROBABILITYx; }
                set { PROBABILITYx = value; }
            }
            public string DIAGNOSIS_DISPLAY
            {
                get { return DIAGNOSIS_DISPLAYx; }
                set { DIAGNOSIS_DISPLAYx = value; }
            }
            public string SEVERITY_FTDESC
            {
                get { return SEVERITY_FTDESCx; }
                set { SEVERITY_FTDESCx = value; }
            }
            public string LONG_BLOB_ID
            {
                get { return LONG_BLOB_IDx; }
                set { LONG_BLOB_IDx = value; }
            }
            public string RANKING_CD
            {
                get { return RANKING_CDx; }
                set { RANKING_CDx = value; }
            }
            public string SEVERITY_CD
            {
                get { return SEVERITY_CDx; }
                set { SEVERITY_CDx = value; }
            }
            public string DIAGNOSIS_GROUP
            {
                get { return DIAGNOSIS_GROUPx; }
                set { DIAGNOSIS_GROUPx = value; }
            }
            public string CLINICAL_DIAG_PRIORITY
            {
                get { return CLINICAL_DIAG_PRIORITYx; }
                set { CLINICAL_DIAG_PRIORITYx = value; }
            }
            public string ENCNTR_SLICE_ID
            {
                get { return ENCNTR_SLICE_IDx; }
                set { ENCNTR_SLICE_IDx = value; }
            }
            public string PRESENT_ON_ADMIT_CD
            {
                get { return PRESENT_ON_ADMIT_CDx; }
                set { PRESENT_ON_ADMIT_CDx = value; }
            }
            public string HAC_IND
            {
                get { return HAC_INDx; }
                set { HAC_INDx = value; }
            }
            public string LATERALITY_CD
            {
                get { return LATERALITY_CDx; }
                set { LATERALITY_CDx = value; }
            }
            public string ORIGINATING_NOMENCLATURE_ID
            {
                get { return ORIGINATING_NOMENCLATURE_IDx; }
                set { ORIGINATING_NOMENCLATURE_IDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string CLU_SUBKEY1_FLAG
            {
                get { return CLU_SUBKEY1_FLAGx; }
                set { CLU_SUBKEY1_FLAGx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //DIAGNOSIS:  ENCNTR_ID,NOMENCLATURE_ID,DIAGNOSIS_ID,DIAG_DT_TM,DIAG_PRIORITY,PRESENT_ON_ADMIT_CD,DIAG_TYPE_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                ENCNTR_IDx = recs[0].Trim();
                NOMENCLATURE_IDx = recs[1].Trim();
                DIAGNOSIS_IDx = recs[2].Trim();
                DIAG_DT_TMx = recs[3].Trim();
                DIAG_PRIORITYx = recs[4].Trim();
                PRESENT_ON_ADMIT_CDx = recs[5].Trim();
                DIAG_TYPE_CDx = recs[6].Trim();
                ACTIVE_INDx = recs[7].Trim();
                END_EFFECTIVE_DT_TMx = recs[8].Trim();



                //DIAGNOSIS_IDx = recs[0].Trim();
                //UPDT_CNTx = recs[1].Trim();
                //UPDT_DT_TMx = recs[2].Trim();
                //UPDT_IDx = recs[3].Trim();
                //UPDT_TASKx = recs[4].Trim();
                //UPDT_APPLCTXx = recs[5].Trim();
                //ACTIVE_INDx = recs[6].Trim();
                //ACTIVE_STATUS_CDx = recs[7].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[8].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[9].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[10].Trim();
                //END_EFFECTIVE_DT_TMx = recs[11].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[12].Trim();
                //PERSON_IDx = recs[13].Trim();
                //ENCNTR_IDx = recs[14].Trim();
                //NOMENCLATURE_IDx = recs[15].Trim();
                //DIAG_DT_TMx = recs[16].Trim();
                //DIAG_TYPE_CDx = recs[17].Trim();
                //DIAGNOSTIC_CATEGORY_CDx = recs[18].Trim();
                //DIAG_PRIORITYx = recs[19].Trim();
                //DIAG_PRSNL_IDx = recs[20].Trim();
                //DIAG_PRSNL_NAMEx = recs[21].Trim();
                //DIAG_CLASS_CDx = recs[22].Trim();
                //CONFID_LEVEL_CDx = recs[23].Trim();
                //ATTESTATION_DT_TMx = recs[24].Trim();
                //REFERENCE_NBRx = recs[25].Trim();
                //SEG_UNIQUE_KEYx = recs[26].Trim();
                //DIAG_FTDESCx = recs[27].Trim();
                //MOD_NOMENCLATURE_IDx = recs[28].Trim();
                //SVC_CAT_HIST_IDx = recs[29].Trim();
                //DIAG_NOTEx = recs[30].Trim();
                //CONDITIONAL_QUAL_CDx = recs[31].Trim();
                //CLINICAL_SERVICE_CDx = recs[32].Trim();
                //CONFIRMATION_STATUS_CDx = recs[33].Trim();
                //CLASSIFICATION_CDx = recs[34].Trim();
                //SEVERITY_CLASS_CDx = recs[35].Trim();
                //CERTAINTY_CDx = recs[36].Trim();
                //PROBABILITYx = recs[37].Trim();
                //DIAGNOSIS_DISPLAYx = recs[38].Trim();
                //SEVERITY_FTDESCx = recs[39].Trim();
                //LONG_BLOB_IDx = recs[40].Trim();
                //RANKING_CDx = recs[41].Trim();
                //SEVERITY_CDx = recs[42].Trim();
                //DIAGNOSIS_GROUPx = recs[43].Trim();
                //CLINICAL_DIAG_PRIORITYx = recs[44].Trim();
                //ENCNTR_SLICE_IDx = recs[45].Trim();
                //PRESENT_ON_ADMIT_CDx = recs[46].Trim();
                //HAC_INDx = recs[47].Trim();
                //LATERALITY_CDx = recs[48].Trim();
                //ORIGINATING_NOMENCLATURE_IDx = recs[49].Trim();
                //LAST_UTC_TSx = recs[50].Trim();
                //CLU_SUBKEY1_FLAGx = recs[51].Trim();
                //INST_IDx = recs[52].Trim();
            }

        }
        public struct DRG
        {
            private string DRG_IDx;
            private string PERSON_IDx;
            private string ENCNTR_IDx;
            private string NOMENCLATURE_IDx;
            private string DRG_PAYMENTx;
            private string OUTLIER_DAYSx;
            private string OUTLIER_COSTx;
            private string OUTLIER_REIMBURSEMENT_COSTx;
            private string DRG_PRIORITYx;
            private string GROUPER_CDx;
            private string DRG_PAYOR_CDx;
            private string CREATE_DT_TMx;
            private string CREATE_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string SVC_CAT_HIST_IDx;
            private string MDC_CDx;
            private string RISK_OF_MORTALITY_CDx;
            private string SEVERITY_OF_ILLNESS_CDx;
            private string SOURCE_VOCABULARY_CDx;
            private string MDC_APR_CDx;
            private string COMORBIDITY_CDx;
            private string ENCNTR_SLICE_IDx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                DRG_IDx = "";
                PERSON_IDx = "";
                ENCNTR_IDx = "";
                NOMENCLATURE_IDx = "";
                DRG_PAYMENTx = "";
                OUTLIER_DAYSx = "";
                OUTLIER_COSTx = "";
                OUTLIER_REIMBURSEMENT_COSTx = "";
                DRG_PRIORITYx = "";
                GROUPER_CDx = "";
                DRG_PAYOR_CDx = "";
                CREATE_DT_TMx = "";
                CREATE_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                SVC_CAT_HIST_IDx = "";
                MDC_CDx = "";
                RISK_OF_MORTALITY_CDx = "";
                SEVERITY_OF_ILLNESS_CDx = "";
                SOURCE_VOCABULARY_CDx = "";
                MDC_APR_CDx = "";
                COMORBIDITY_CDx = "";
                ENCNTR_SLICE_IDx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string DRG_ID
            {
                get { return DRG_IDx; }
                set { DRG_IDx = value; }
            }
            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string NOMENCLATURE_ID
            {
                get { return NOMENCLATURE_IDx; }
                set { NOMENCLATURE_IDx = value; }
            }
            public string DRG_PAYMENT
            {
                get { return DRG_PAYMENTx; }
                set { DRG_PAYMENTx = value; }
            }
            public string OUTLIER_DAYS
            {
                get { return OUTLIER_DAYSx; }
                set { OUTLIER_DAYSx = value; }
            }
            public string OUTLIER_COST
            {
                get { return OUTLIER_COSTx; }
                set { OUTLIER_COSTx = value; }
            }
            public string OUTLIER_REIMBURSEMENT_COST
            {
                get { return OUTLIER_REIMBURSEMENT_COSTx; }
                set { OUTLIER_REIMBURSEMENT_COSTx = value; }
            }
            public string DRG_PRIORITY
            {
                get { return DRG_PRIORITYx; }
                set { DRG_PRIORITYx = value; }
            }
            public string GROUPER_CD
            {
                get { return GROUPER_CDx; }
                set { GROUPER_CDx = value; }
            }
            public string DRG_PAYOR_CD
            {
                get { return DRG_PAYOR_CDx; }
                set { DRG_PAYOR_CDx = value; }
            }
            public string CREATE_DT_TM
            {
                get { return CREATE_DT_TMx; }
                set { CREATE_DT_TMx = value; }
            }
            public string CREATE_PRSNL_ID
            {
                get { return CREATE_PRSNL_IDx; }
                set { CREATE_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string SVC_CAT_HIST_ID
            {
                get { return SVC_CAT_HIST_IDx; }
                set { SVC_CAT_HIST_IDx = value; }
            }
            public string MDC_CD
            {
                get { return MDC_CDx; }
                set { MDC_CDx = value; }
            }
            public string RISK_OF_MORTALITY_CD
            {
                get { return RISK_OF_MORTALITY_CDx; }
                set { RISK_OF_MORTALITY_CDx = value; }
            }
            public string SEVERITY_OF_ILLNESS_CD
            {
                get { return SEVERITY_OF_ILLNESS_CDx; }
                set { SEVERITY_OF_ILLNESS_CDx = value; }
            }
            public string SOURCE_VOCABULARY_CD
            {
                get { return SOURCE_VOCABULARY_CDx; }
                set { SOURCE_VOCABULARY_CDx = value; }
            }
            public string MDC_APR_CD
            {
                get { return MDC_APR_CDx; }
                set { MDC_APR_CDx = value; }
            }
            public string COMORBIDITY_CD
            {
                get { return COMORBIDITY_CDx; }
                set { COMORBIDITY_CDx = value; }
            }
            public string ENCNTR_SLICE_ID
            {
                get { return ENCNTR_SLICE_IDx; }
                set { ENCNTR_SLICE_IDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //DRG:  ENCNTR_ID,NOMENCLATURE_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                ENCNTR_IDx = recs[0].Trim();
                NOMENCLATURE_IDx = recs[1].Trim();
                ACTIVE_INDx = recs[2].Trim();
                END_EFFECTIVE_DT_TMx = recs[3].Trim();


                //DRG_IDx = recs[0].Trim();
                //PERSON_IDx = recs[1].Trim();
                //ENCNTR_IDx = recs[2].Trim();
                //NOMENCLATURE_IDx = recs[3].Trim();
                //DRG_PAYMENTx = recs[4].Trim();
                //OUTLIER_DAYSx = recs[5].Trim();
                //OUTLIER_COSTx = recs[6].Trim();
                //OUTLIER_REIMBURSEMENT_COSTx = recs[7].Trim();
                //DRG_PRIORITYx = recs[8].Trim();
                //GROUPER_CDx = recs[9].Trim();
                //DRG_PAYOR_CDx = recs[10].Trim();
                //CREATE_DT_TMx = recs[11].Trim();
                //CREATE_PRSNL_IDx = recs[12].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[13].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[14].Trim();
                //END_EFFECTIVE_DT_TMx = recs[15].Trim();
                //UPDT_CNTx = recs[16].Trim();
                //UPDT_DT_TMx = recs[17].Trim();
                //UPDT_IDx = recs[18].Trim();
                //UPDT_TASKx = recs[19].Trim();
                //UPDT_APPLCTXx = recs[20].Trim();
                //ACTIVE_INDx = recs[21].Trim();
                //ACTIVE_STATUS_CDx = recs[22].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[23].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[24].Trim();
                //SVC_CAT_HIST_IDx = recs[25].Trim();
                //MDC_CDx = recs[26].Trim();
                //RISK_OF_MORTALITY_CDx = recs[27].Trim();
                //SEVERITY_OF_ILLNESS_CDx = recs[28].Trim();
                //SOURCE_VOCABULARY_CDx = recs[29].Trim();
                //MDC_APR_CDx = recs[30].Trim();
                //COMORBIDITY_CDx = recs[31].Trim();
                //ENCNTR_SLICE_IDx = recs[32].Trim();
                //LAST_UTC_TSx = recs[33].Trim();
                //INST_IDx = recs[34].Trim();
            }

        }
        public struct DRG_EXTENSION
        {
            private string SOURCE_VOCABULARY_CDx;
            private string SOURCE_IDENTIFIERx;
            private string DRG_CATEGORYx;
            private string MDC_CDx;
            private string GMLOSx;
            private string AMLOSx;
            private string DRG_WEIGHTx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string SEVERITY_OF_ILLNESS_CDx;
            private string TRANSFER_RULE_INDx;
            private string LAST_UTC_TSx;

            public void Clear()
            {
                SOURCE_VOCABULARY_CDx = "";
                SOURCE_IDENTIFIERx = "";
                DRG_CATEGORYx = "";
                MDC_CDx = "";
                GMLOSx = "";
                AMLOSx = "";
                DRG_WEIGHTx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                SEVERITY_OF_ILLNESS_CDx = "";
                TRANSFER_RULE_INDx = "";
                LAST_UTC_TSx = "";
            }

            public string SOURCE_VOCABULARY_CD
            {
                get { return SOURCE_VOCABULARY_CDx; }
                set { SOURCE_VOCABULARY_CDx = value; }
            }
            public string SOURCE_IDENTIFIER
            {
                get { return SOURCE_IDENTIFIERx; }
                set { SOURCE_IDENTIFIERx = value; }
            }
            public string DRG_CATEGORY
            {
                get { return DRG_CATEGORYx; }
                set { DRG_CATEGORYx = value; }
            }
            public string MDC_CD
            {
                get { return MDC_CDx; }
                set { MDC_CDx = value; }
            }
            public string GMLOS
            {
                get { return GMLOSx; }
                set { GMLOSx = value; }
            }
            public string AMLOS
            {
                get { return AMLOSx; }
                set { AMLOSx = value; }
            }
            public string DRG_WEIGHT
            {
                get { return DRG_WEIGHTx; }
                set { DRG_WEIGHTx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string SEVERITY_OF_ILLNESS_CD
            {
                get { return SEVERITY_OF_ILLNESS_CDx; }
                set { SEVERITY_OF_ILLNESS_CDx = value; }
            }
            public string TRANSFER_RULE_IND
            {
                get { return TRANSFER_RULE_INDx; }
                set { TRANSFER_RULE_INDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }

            public void SetRecord(string i_record)
            {
                //DRG_EXTENSION: SOURCE_IDENTIFIER,DRG_WEIGHT,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                SOURCE_IDENTIFIERx = recs[0].Trim();
                DRG_WEIGHTx = recs[1].Trim();
                ACTIVE_INDx = recs[2].Trim();
                END_EFFECTIVE_DT_TMx = recs[3].Trim();



                //SOURCE_VOCABULARY_CDx = recs[0].Trim();
                //SOURCE_IDENTIFIERx = recs[1].Trim();
                //DRG_CATEGORYx = recs[2].Trim();
                //MDC_CDx = recs[3].Trim();
                //GMLOSx = recs[4].Trim();
                //AMLOSx = recs[5].Trim();
                //DRG_WEIGHTx = recs[6].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[7].Trim();
                //END_EFFECTIVE_DT_TMx = recs[8].Trim();
                //UPDT_CNTx = recs[9].Trim();
                //UPDT_DT_TMx = recs[10].Trim();
                //UPDT_IDx = recs[11].Trim();
                //UPDT_TASKx = recs[12].Trim();
                //UPDT_APPLCTXx = recs[13].Trim();
                //ACTIVE_INDx = recs[14].Trim();
                //ACTIVE_STATUS_CDx = recs[15].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[16].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[17].Trim();
                //SEVERITY_OF_ILLNESS_CDx = recs[18].Trim();
                //TRANSFER_RULE_INDx = recs[19].Trim();
                //LAST_UTC_TSx = recs[20].Trim();
            }

        }
        public struct ENCNTR_ALIAS
        {
            private string ENCNTR_ALIAS_IDx;
            private string ENCNTR_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ALIAS_POOL_CDx;
            private string ENCNTR_ALIAS_TYPE_CDx;
            private string ALIASx;
            private string ENCNTR_ALIAS_SUB_TYPE_CDx;
            private string CHECK_DIGITx;
            private string CHECK_DIGIT_METHOD_CDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string ASSIGN_AUTHORITY_SYS_CDx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                ENCNTR_ALIAS_IDx = "";
                ENCNTR_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ALIAS_POOL_CDx = "";
                ENCNTR_ALIAS_TYPE_CDx = "";
                ALIASx = "";
                ENCNTR_ALIAS_SUB_TYPE_CDx = "";
                CHECK_DIGITx = "";
                CHECK_DIGIT_METHOD_CDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                ASSIGN_AUTHORITY_SYS_CDx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string ENCNTR_ALIAS_ID
            {
                get { return ENCNTR_ALIAS_IDx; }
                set { ENCNTR_ALIAS_IDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ALIAS_POOL_CD
            {
                get { return ALIAS_POOL_CDx; }
                set { ALIAS_POOL_CDx = value; }
            }
            public string ENCNTR_ALIAS_TYPE_CD
            {
                get { return ENCNTR_ALIAS_TYPE_CDx; }
                set { ENCNTR_ALIAS_TYPE_CDx = value; }
            }
            public string ALIAS
            {
                get { return ALIASx; }
                set { ALIASx = value; }
            }
            public string ENCNTR_ALIAS_SUB_TYPE_CD
            {
                get { return ENCNTR_ALIAS_SUB_TYPE_CDx; }
                set { ENCNTR_ALIAS_SUB_TYPE_CDx = value; }
            }
            public string CHECK_DIGIT
            {
                get { return CHECK_DIGITx; }
                set { CHECK_DIGITx = value; }
            }
            public string CHECK_DIGIT_METHOD_CD
            {
                get { return CHECK_DIGIT_METHOD_CDx; }
                set { CHECK_DIGIT_METHOD_CDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string ASSIGN_AUTHORITY_SYS_CD
            {
                get { return ASSIGN_AUTHORITY_SYS_CDx; }
                set { ASSIGN_AUTHORITY_SYS_CDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //ENCNTR_ALIAS:  ENCNTR_ID,ENCNTR_ALIAS_TYPE_CD,ALIAS,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');

                ENCNTR_IDx = recs[0].Trim();
                ENCNTR_ALIAS_TYPE_CDx = recs[1].Trim();
                ALIASx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();
                END_EFFECTIVE_DT_TMx = recs[4].Trim();



                //ENCNTR_ALIAS_IDx = recs[0].Trim();
                //ENCNTR_IDx = recs[1].Trim();
                //UPDT_CNTx = recs[2].Trim();
                //UPDT_DT_TMx = recs[3].Trim();
                //UPDT_IDx = recs[4].Trim();
                //UPDT_TASKx = recs[5].Trim();
                //UPDT_APPLCTXx = recs[6].Trim();
                //ACTIVE_INDx = recs[7].Trim();
                //ACTIVE_STATUS_CDx = recs[8].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[9].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[10].Trim();
                //ALIAS_POOL_CDx = recs[11].Trim();
                //ENCNTR_ALIAS_TYPE_CDx = recs[12].Trim();
                //ALIASx = recs[13].Trim();
                //ENCNTR_ALIAS_SUB_TYPE_CDx = recs[14].Trim();
                //CHECK_DIGITx = recs[15].Trim();
                //CHECK_DIGIT_METHOD_CDx = recs[16].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[17].Trim();
                //END_EFFECTIVE_DT_TMx = recs[18].Trim();
                //DATA_STATUS_CDx = recs[19].Trim();
                //DATA_STATUS_DT_TMx = recs[20].Trim();
                //DATA_STATUS_PRSNL_IDx = recs[21].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[22].Trim();
                //ASSIGN_AUTHORITY_SYS_CDx = recs[23].Trim();
                //LAST_UTC_TSx = recs[24].Trim();
                //INST_IDx = recs[25].Trim();
            }

        }
        public struct ENCNTR_MOTHER_CHILD_RELTN
        {
            private string ENCNTR_MOTHER_CHILD_RELTN_IDx;
            private string MOTHER_ENCNTR_IDx;
            private string CHILD_ENCNTR_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ACTIVE_STATUS_CDx;
            private string UPDT_IDx;
            private string UPDT_DT_TMx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string UPDT_CNTx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                ENCNTR_MOTHER_CHILD_RELTN_IDx = "";
                MOTHER_ENCNTR_IDx = "";
                CHILD_ENCNTR_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ACTIVE_STATUS_CDx = "";
                UPDT_IDx = "";
                UPDT_DT_TMx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                UPDT_CNTx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string ENCNTR_MOTHER_CHILD_RELTN_ID
            {
                get { return ENCNTR_MOTHER_CHILD_RELTN_IDx; }
                set { ENCNTR_MOTHER_CHILD_RELTN_IDx = value; }
            }
            public string MOTHER_ENCNTR_ID
            {
                get { return MOTHER_ENCNTR_IDx; }
                set { MOTHER_ENCNTR_IDx = value; }
            }
            public string CHILD_ENCNTR_ID
            {
                get { return CHILD_ENCNTR_IDx; }
                set { CHILD_ENCNTR_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //ENCNTR_MOTHER_CHILD_RELTN:  CHILD_ENCNTR_ID,MOTHER_ENCNTR_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                CHILD_ENCNTR_IDx = recs[0].Trim();
                MOTHER_ENCNTR_IDx = recs[1].Trim();
                ACTIVE_INDx = recs[2].Trim();
                END_EFFECTIVE_DT_TMx = recs[3].Trim();

                //ENCNTR_MOTHER_CHILD_RELTN_IDx = recs[0].Trim();
                //MOTHER_ENCNTR_IDx = recs[1].Trim();
                //CHILD_ENCNTR_IDx = recs[2].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[3].Trim();
                //END_EFFECTIVE_DT_TMx = recs[4].Trim();
                //ACTIVE_INDx = recs[5].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[6].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[7].Trim();
                //ACTIVE_STATUS_CDx = recs[8].Trim();
                //UPDT_IDx = recs[9].Trim();
                //UPDT_DT_TMx = recs[10].Trim();
                //UPDT_TASKx = recs[11].Trim();
                //UPDT_APPLCTXx = recs[12].Trim();
                //UPDT_CNTx = recs[13].Trim();
                //LAST_UTC_TSx = recs[14].Trim();
                //INST_IDx = recs[15].Trim();
            }     
        }
        public struct ENCNTR_PRSNL_RELTN
        {
            private string ENCNTR_PRSNL_RELTN_IDx;
            private string PRSNL_PERSON_IDx;
            private string ENCNTR_PRSNL_R_CDx;
            private string ENCNTR_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string FREE_TEXT_CDx;
            private string FT_PRSNL_NAMEx;
            private string MANUAL_CREATE_INDx;
            private string MANUAL_CREATE_BY_IDx;
            private string MANUAL_CREATE_DT_TMx;
            private string MANUAL_INACT_INDx;
            private string MANUAL_INACT_BY_IDx;
            private string MANUAL_INACT_DT_TMx;
            private string PRIORITY_SEQx;
            private string INTERNAL_SEQx;
            private string EXPIRATION_INDx;
            private string NOTIFICATION_CDx;
            private string EXPIRE_DT_TMx;
            private string TRANSACTION_DT_TMx;
            private string ACTIVITY_DT_TMx;
            private string ENCNTR_TYPE_CDx;
            private string LAST_UTC_TSx;
            private string CLU_SUBKEY1_FLAGx;
            private string INST_IDx;

            public void Clear()
            {
                ENCNTR_PRSNL_RELTN_IDx = "";
                PRSNL_PERSON_IDx = "";
                ENCNTR_PRSNL_R_CDx = "";
                ENCNTR_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                FREE_TEXT_CDx = "";
                FT_PRSNL_NAMEx = "";
                MANUAL_CREATE_INDx = "";
                MANUAL_CREATE_BY_IDx = "";
                MANUAL_CREATE_DT_TMx = "";
                MANUAL_INACT_INDx = "";
                MANUAL_INACT_BY_IDx = "";
                MANUAL_INACT_DT_TMx = "";
                PRIORITY_SEQx = "";
                INTERNAL_SEQx = "";
                EXPIRATION_INDx = "";
                NOTIFICATION_CDx = "";
                EXPIRE_DT_TMx = "";
                TRANSACTION_DT_TMx = "";
                ACTIVITY_DT_TMx = "";
                ENCNTR_TYPE_CDx = "";
                LAST_UTC_TSx = "";
                CLU_SUBKEY1_FLAGx = "";
                INST_IDx = "";
            }

            public string ENCNTR_PRSNL_RELTN_ID
            {
                get { return ENCNTR_PRSNL_RELTN_IDx; }
                set { ENCNTR_PRSNL_RELTN_IDx = value; }
            }
            public string PRSNL_PERSON_ID
            {
                get { return PRSNL_PERSON_IDx; }
                set { PRSNL_PERSON_IDx = value; }
            }
            public string ENCNTR_PRSNL_R_CD
            {
                get { return ENCNTR_PRSNL_R_CDx; }
                set { ENCNTR_PRSNL_R_CDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string FREE_TEXT_CD
            {
                get { return FREE_TEXT_CDx; }
                set { FREE_TEXT_CDx = value; }
            }
            public string FT_PRSNL_NAME
            {
                get { return FT_PRSNL_NAMEx; }
                set { FT_PRSNL_NAMEx = value; }
            }
            public string MANUAL_CREATE_IND
            {
                get { return MANUAL_CREATE_INDx; }
                set { MANUAL_CREATE_INDx = value; }
            }
            public string MANUAL_CREATE_BY_ID
            {
                get { return MANUAL_CREATE_BY_IDx; }
                set { MANUAL_CREATE_BY_IDx = value; }
            }
            public string MANUAL_CREATE_DT_TM
            {
                get { return MANUAL_CREATE_DT_TMx; }
                set { MANUAL_CREATE_DT_TMx = value; }
            }
            public string MANUAL_INACT_IND
            {
                get { return MANUAL_INACT_INDx; }
                set { MANUAL_INACT_INDx = value; }
            }
            public string MANUAL_INACT_BY_ID
            {
                get { return MANUAL_INACT_BY_IDx; }
                set { MANUAL_INACT_BY_IDx = value; }
            }
            public string MANUAL_INACT_DT_TM
            {
                get { return MANUAL_INACT_DT_TMx; }
                set { MANUAL_INACT_DT_TMx = value; }
            }
            public string PRIORITY_SEQ
            {
                get { return PRIORITY_SEQx; }
                set { PRIORITY_SEQx = value; }
            }
            public string INTERNAL_SEQ
            {
                get { return INTERNAL_SEQx; }
                set { INTERNAL_SEQx = value; }
            }
            public string EXPIRATION_IND
            {
                get { return EXPIRATION_INDx; }
                set { EXPIRATION_INDx = value; }
            }
            public string NOTIFICATION_CD
            {
                get { return NOTIFICATION_CDx; }
                set { NOTIFICATION_CDx = value; }
            }
            public string EXPIRE_DT_TM
            {
                get { return EXPIRE_DT_TMx; }
                set { EXPIRE_DT_TMx = value; }
            }
            public string TRANSACTION_DT_TM
            {
                get { return TRANSACTION_DT_TMx; }
                set { TRANSACTION_DT_TMx = value; }
            }
            public string ACTIVITY_DT_TM
            {
                get { return ACTIVITY_DT_TMx; }
                set { ACTIVITY_DT_TMx = value; }
            }
            public string ENCNTR_TYPE_CD
            {
                get { return ENCNTR_TYPE_CDx; }
                set { ENCNTR_TYPE_CDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string CLU_SUBKEY1_FLAG
            {
                get { return CLU_SUBKEY1_FLAGx; }
                set { CLU_SUBKEY1_FLAGx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //ENCNTR_PRSNL_RELTN: ENCNTR_ID,ENCNTR_PRSNL_R_CD,PRSNL_PERSON_ID,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                ENCNTR_IDx = recs[0].Trim();
                ENCNTR_PRSNL_R_CDx = recs[1].Trim();
                PRSNL_PERSON_IDx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();
                END_EFFECTIVE_DT_TMx = recs[4].Trim();


                //ENCNTR_PRSNL_RELTN_IDx = recs[0].Trim();
                //PRSNL_PERSON_IDx = recs[1].Trim();
                //ENCNTR_PRSNL_R_CDx = recs[2].Trim();
                //ENCNTR_IDx = recs[3].Trim();
                ////UPDT_CNTx = recs[4].Trim();
                ////UPDT_DT_TMx = recs[5].Trim();
                ////UPDT_IDx = recs[6].Trim();
                ////UPDT_TASKx = recs[7].Trim();
                ////UPDT_APPLCTXx = recs[8].Trim();
                //ACTIVE_INDx = recs[4].Trim();
                ////ACTIVE_STATUS_CDx = recs[10].Trim();
                ////ACTIVE_STATUS_DT_TMx = recs[11].Trim();
                ////ACTIVE_STATUS_PRSNL_IDx = recs[12].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[5].Trim();
                //END_EFFECTIVE_DT_TMx = recs[6].Trim();
                ////DATA_STATUS_CDx = recs[15].Trim();
                ////DATA_STATUS_DT_TMx = recs[16].Trim();
                ////DATA_STATUS_PRSNL_IDx = recs[17].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[7].Trim();
                ////FREE_TEXT_CDx = recs[19].Trim();
                ////FT_PRSNL_NAMEx = recs[20].Trim();
                ////MANUAL_CREATE_INDx = recs[21].Trim();
                ////MANUAL_CREATE_BY_IDx = recs[22].Trim();
                ////MANUAL_CREATE_DT_TMx = recs[23].Trim();
                ////MANUAL_INACT_INDx = recs[24].Trim();
                ////MANUAL_INACT_BY_IDx = recs[25].Trim();
                ////MANUAL_INACT_DT_TMx = recs[26].Trim();
                //PRIORITY_SEQx = recs[8].Trim();
                //INTERNAL_SEQx = recs[9].Trim();
                //EXPIRATION_INDx = recs[10].Trim();
                ////NOTIFICATION_CDx = recs[30].Trim();
                //EXPIRE_DT_TMx = recs[11].Trim();
                //TRANSACTION_DT_TMx = recs[12].Trim();
                //ACTIVITY_DT_TMx = recs[13].Trim();
                //ENCNTR_TYPE_CDx = recs[14].Trim();
                ////LAST_UTC_TSx = recs[35].Trim();
                ////CLU_SUBKEY1_FLAGx = recs[36].Trim();
                ////INST_IDx = recs[37].Trim();
            }

        }
        public struct NOMENCLATURE
        {
            private string NOMENCLATURE_IDx;
            private string PRINCIPLE_TYPE_CDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string SOURCE_STRINGx;
            private string SOURCE_IDENTIFIERx;
            private string STRING_IDENTIFIERx;
            private string STRING_STATUS_CDx;
            private string TERM_IDx;
            private string LANGUAGE_CDx;
            private string SOURCE_VOCABULARY_CDx;
            private string NOM_VER_GRP_IDx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string SHORT_STRINGx;
            private string MNEMONICx;
            private string CONCEPT_IDENTIFIERx;
            private string CONCEPT_SOURCE_CDx;
            private string STRING_SOURCE_CDx;
            private string VOCAB_AXIS_CDx;
            private string PRIMARY_VTERM_INDx;
            private string SOURCE_STRING_KEYCAPx;
            private string CMTIx;
            private string PRIMARY_CTERM_INDx;
            private string CONCEPT_CKIx;
            private string DISALLOWED_INDx;
            private string SOURCE_IDENTIFIER_KEYCAPx;
            private string SOURCE_STRING_KEYCAP_A_NLSx;
            private string LAST_UTC_TSx;

            public void Clear()
            {
                NOMENCLATURE_IDx = "";
                PRINCIPLE_TYPE_CDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                SOURCE_STRINGx = "";
                SOURCE_IDENTIFIERx = "";
                STRING_IDENTIFIERx = "";
                STRING_STATUS_CDx = "";
                TERM_IDx = "";
                LANGUAGE_CDx = "";
                SOURCE_VOCABULARY_CDx = "";
                NOM_VER_GRP_IDx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                SHORT_STRINGx = "";
                MNEMONICx = "";
                CONCEPT_IDENTIFIERx = "";
                CONCEPT_SOURCE_CDx = "";
                STRING_SOURCE_CDx = "";
                VOCAB_AXIS_CDx = "";
                PRIMARY_VTERM_INDx = "";
                SOURCE_STRING_KEYCAPx = "";
                CMTIx = "";
                PRIMARY_CTERM_INDx = "";
                CONCEPT_CKIx = "";
                DISALLOWED_INDx = "";
                SOURCE_IDENTIFIER_KEYCAPx = "";
                SOURCE_STRING_KEYCAP_A_NLSx = "";
                LAST_UTC_TSx = "";
            }

            public string NOMENCLATURE_ID
            {
                get { return NOMENCLATURE_IDx; }
                set { NOMENCLATURE_IDx = value; }
            }
            public string PRINCIPLE_TYPE_CD
            {
                get { return PRINCIPLE_TYPE_CDx; }
                set { PRINCIPLE_TYPE_CDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string SOURCE_STRING
            {
                get { return SOURCE_STRINGx; }
                set { SOURCE_STRINGx = value; }
            }
            public string SOURCE_IDENTIFIER
            {
                get { return SOURCE_IDENTIFIERx; }
                set { SOURCE_IDENTIFIERx = value; }
            }
            public string STRING_IDENTIFIER
            {
                get { return STRING_IDENTIFIERx; }
                set { STRING_IDENTIFIERx = value; }
            }
            public string STRING_STATUS_CD
            {
                get { return STRING_STATUS_CDx; }
                set { STRING_STATUS_CDx = value; }
            }
            public string TERM_ID
            {
                get { return TERM_IDx; }
                set { TERM_IDx = value; }
            }
            public string LANGUAGE_CD
            {
                get { return LANGUAGE_CDx; }
                set { LANGUAGE_CDx = value; }
            }
            public string SOURCE_VOCABULARY_CD
            {
                get { return SOURCE_VOCABULARY_CDx; }
                set { SOURCE_VOCABULARY_CDx = value; }
            }
            public string NOM_VER_GRP_ID
            {
                get { return NOM_VER_GRP_IDx; }
                set { NOM_VER_GRP_IDx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string SHORT_STRING
            {
                get { return SHORT_STRINGx; }
                set { SHORT_STRINGx = value; }
            }
            public string MNEMONIC
            {
                get { return MNEMONICx; }
                set { MNEMONICx = value; }
            }
            public string CONCEPT_IDENTIFIER
            {
                get { return CONCEPT_IDENTIFIERx; }
                set { CONCEPT_IDENTIFIERx = value; }
            }
            public string CONCEPT_SOURCE_CD
            {
                get { return CONCEPT_SOURCE_CDx; }
                set { CONCEPT_SOURCE_CDx = value; }
            }
            public string STRING_SOURCE_CD
            {
                get { return STRING_SOURCE_CDx; }
                set { STRING_SOURCE_CDx = value; }
            }
            public string VOCAB_AXIS_CD
            {
                get { return VOCAB_AXIS_CDx; }
                set { VOCAB_AXIS_CDx = value; }
            }
            public string PRIMARY_VTERM_IND
            {
                get { return PRIMARY_VTERM_INDx; }
                set { PRIMARY_VTERM_INDx = value; }
            }
            public string SOURCE_STRING_KEYCAP
            {
                get { return SOURCE_STRING_KEYCAPx; }
                set { SOURCE_STRING_KEYCAPx = value; }
            }
            public string CMTI
            {
                get { return CMTIx; }
                set { CMTIx = value; }
            }
            public string PRIMARY_CTERM_IND
            {
                get { return PRIMARY_CTERM_INDx; }
                set { PRIMARY_CTERM_INDx = value; }
            }
            public string CONCEPT_CKI
            {
                get { return CONCEPT_CKIx; }
                set { CONCEPT_CKIx = value; }
            }
            public string DISALLOWED_IND
            {
                get { return DISALLOWED_INDx; }
                set { DISALLOWED_INDx = value; }
            }
            public string SOURCE_IDENTIFIER_KEYCAP
            {
                get { return SOURCE_IDENTIFIER_KEYCAPx; }
                set { SOURCE_IDENTIFIER_KEYCAPx = value; }
            }
            public string SOURCE_STRING_KEYCAP_A_NLS
            {
                get { return SOURCE_STRING_KEYCAP_A_NLSx; }
                set { SOURCE_STRING_KEYCAP_A_NLSx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }

            public void SetRecord(string i_record)
            {
                //NOMENCLATURE:  NOMENCLATURE_ID,SOURCE_VOCABULARY_CD,SOURCE_IDENTIFIER,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                NOMENCLATURE_IDx = recs[0].Trim();
                SOURCE_VOCABULARY_CDx = recs[1].Trim();
                SOURCE_IDENTIFIERx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();
                END_EFFECTIVE_DT_TMx = recs[4].Trim();



                //NOMENCLATURE_IDx = recs[0].Trim();
                //PRINCIPLE_TYPE_CDx = recs[1].Trim();
                //UPDT_CNTx = recs[2].Trim();
                //UPDT_DT_TMx = recs[3].Trim();
                //UPDT_IDx = recs[4].Trim();
                //UPDT_TASKx = recs[5].Trim();
                //UPDT_APPLCTXx = recs[6].Trim();
                //ACTIVE_INDx = recs[7].Trim();
                //ACTIVE_STATUS_CDx = recs[8].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[9].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[10].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[11].Trim();
                //END_EFFECTIVE_DT_TMx = recs[12].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[13].Trim();
                //SOURCE_STRINGx = recs[14].Trim();
                //SOURCE_IDENTIFIERx = recs[15].Trim();
                //STRING_IDENTIFIERx = recs[16].Trim();
                //STRING_STATUS_CDx = recs[17].Trim();
                //TERM_IDx = recs[18].Trim();
                //LANGUAGE_CDx = recs[19].Trim();
                //SOURCE_VOCABULARY_CDx = recs[20].Trim();
                //NOM_VER_GRP_IDx = recs[21].Trim();
                //DATA_STATUS_CDx = recs[22].Trim();
                //DATA_STATUS_DT_TMx = recs[23].Trim();
                //DATA_STATUS_PRSNL_IDx = recs[24].Trim();
                //SHORT_STRINGx = recs[25].Trim();
                //MNEMONICx = recs[26].Trim();
                //CONCEPT_IDENTIFIERx = recs[27].Trim();
                //CONCEPT_SOURCE_CDx = recs[28].Trim();
                //STRING_SOURCE_CDx = recs[29].Trim();
                //VOCAB_AXIS_CDx = recs[30].Trim();
                //PRIMARY_VTERM_INDx = recs[31].Trim();
                //SOURCE_STRING_KEYCAPx = recs[32].Trim();
                //CMTIx = recs[33].Trim();
                //PRIMARY_CTERM_INDx = recs[34].Trim();
                //CONCEPT_CKIx = recs[35].Trim();
                //DISALLOWED_INDx = recs[36].Trim();
                //SOURCE_IDENTIFIER_KEYCAPx = recs[37].Trim();
                //SOURCE_STRING_KEYCAP_A_NLSx = recs[38].Trim();
                //LAST_UTC_TSx = recs[39].Trim();
            }

        }
        public struct ORGANIZATION
        {
            private string ORGANIZATION_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string ORG_NAMEx;
            private string ORG_NAME_KEYx;
            private string FEDERAL_TAX_ID_NBRx;
            private string ORG_STATUS_CDx;
            private string FT_ENTITY_IDx;
            private string FT_ENTITY_NAMEx;
            private string ORG_CLASS_CDx;
            private string ORG_NAME_KEY_NLSx;
            private string CONTRIBUTOR_SOURCE_CDx;
            private string LOGICAL_DOMAIN_IDx;
            private string ORG_NAME_KEY_A_NLSx;
            private string LAST_UTC_TSx;
            private string EXTERNAL_INDx;
            private string INST_IDx;

            public void Clear()
            {
                ORGANIZATION_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                ORG_NAMEx = "";
                ORG_NAME_KEYx = "";
                FEDERAL_TAX_ID_NBRx = "";
                ORG_STATUS_CDx = "";
                FT_ENTITY_IDx = "";
                FT_ENTITY_NAMEx = "";
                ORG_CLASS_CDx = "";
                ORG_NAME_KEY_NLSx = "";
                CONTRIBUTOR_SOURCE_CDx = "";
                LOGICAL_DOMAIN_IDx = "";
                ORG_NAME_KEY_A_NLSx = "";
                LAST_UTC_TSx = "";
                EXTERNAL_INDx = "";
                INST_IDx = "";
            }

            public string ORGANIZATION_ID
            {
                get { return ORGANIZATION_IDx; }
                set { ORGANIZATION_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string ORG_NAME
            {
                get { return ORG_NAMEx; }
                set { ORG_NAMEx = value; }
            }
            public string ORG_NAME_KEY
            {
                get { return ORG_NAME_KEYx; }
                set { ORG_NAME_KEYx = value; }
            }
            public string FEDERAL_TAX_ID_NBR
            {
                get { return FEDERAL_TAX_ID_NBRx; }
                set { FEDERAL_TAX_ID_NBRx = value; }
            }
            public string ORG_STATUS_CD
            {
                get { return ORG_STATUS_CDx; }
                set { ORG_STATUS_CDx = value; }
            }
            public string FT_ENTITY_ID
            {
                get { return FT_ENTITY_IDx; }
                set { FT_ENTITY_IDx = value; }
            }
            public string FT_ENTITY_NAME
            {
                get { return FT_ENTITY_NAMEx; }
                set { FT_ENTITY_NAMEx = value; }
            }
            public string ORG_CLASS_CD
            {
                get { return ORG_CLASS_CDx; }
                set { ORG_CLASS_CDx = value; }
            }
            public string ORG_NAME_KEY_NLS
            {
                get { return ORG_NAME_KEY_NLSx; }
                set { ORG_NAME_KEY_NLSx = value; }
            }
            public string CONTRIBUTOR_SOURCE_CD
            {
                get { return CONTRIBUTOR_SOURCE_CDx; }
                set { CONTRIBUTOR_SOURCE_CDx = value; }
            }
            public string LOGICAL_DOMAIN_ID
            {
                get { return LOGICAL_DOMAIN_IDx; }
                set { LOGICAL_DOMAIN_IDx = value; }
            }
            public string ORG_NAME_KEY_A_NLS
            {
                get { return ORG_NAME_KEY_A_NLSx; }
                set { ORG_NAME_KEY_A_NLSx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string EXTERNAL_IND
            {
                get { return EXTERNAL_INDx; }
                set { EXTERNAL_INDx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                string[] recs = i_record.Split('|');
                ORGANIZATION_IDx = recs[0].Trim();
                UPDT_CNTx = recs[1].Trim();
                UPDT_DT_TMx = recs[2].Trim();
                UPDT_IDx = recs[3].Trim();
                UPDT_TASKx = recs[4].Trim();
                UPDT_APPLCTXx = recs[5].Trim();
                ACTIVE_INDx = recs[6].Trim();
                ACTIVE_STATUS_CDx = recs[7].Trim();
                ACTIVE_STATUS_DT_TMx = recs[8].Trim();
                ACTIVE_STATUS_PRSNL_IDx = recs[9].Trim();
                BEG_EFFECTIVE_DT_TMx = recs[10].Trim();
                END_EFFECTIVE_DT_TMx = recs[11].Trim();
                DATA_STATUS_CDx = recs[12].Trim();
                DATA_STATUS_DT_TMx = recs[13].Trim();
                DATA_STATUS_PRSNL_IDx = recs[14].Trim();
                CONTRIBUTOR_SYSTEM_CDx = recs[15].Trim();
                ORG_NAMEx = recs[16].Trim();
                ORG_NAME_KEYx = recs[17].Trim();
                FEDERAL_TAX_ID_NBRx = recs[18].Trim();
                ORG_STATUS_CDx = recs[19].Trim();
                FT_ENTITY_IDx = recs[20].Trim();
                FT_ENTITY_NAMEx = recs[21].Trim();
                ORG_CLASS_CDx = recs[22].Trim();
                ORG_NAME_KEY_NLSx = recs[23].Trim();
                CONTRIBUTOR_SOURCE_CDx = recs[24].Trim();
                LOGICAL_DOMAIN_IDx = recs[25].Trim();
                ORG_NAME_KEY_A_NLSx = recs[26].Trim();
                LAST_UTC_TSx = recs[27].Trim();
                EXTERNAL_INDx = recs[28].Trim();
                INST_IDx = recs[29].Trim();
            }
        }
        public struct PATIENT_EVENT
        {
            private string PATIENT_EVENT_IDx;
            private string PERSON_IDx;
            private string ENCNTR_IDx;
            private string EVENT_TYPE_CDx;
            private string EVENT_DT_TMx;
            private string TRANSACTION_DT_TMx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                PATIENT_EVENT_IDx = "";
                PERSON_IDx = "";
                ENCNTR_IDx = "";
                EVENT_TYPE_CDx = "";
                EVENT_DT_TMx = "";
                TRANSACTION_DT_TMx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string PATIENT_EVENT_ID
            {
                get { return PATIENT_EVENT_IDx; }
                set { PATIENT_EVENT_IDx = value; }
            }
            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string EVENT_TYPE_CD
            {
                get { return EVENT_TYPE_CDx; }
                set { EVENT_TYPE_CDx = value; }
            }
            public string EVENT_DT_TM
            {
                get { return EVENT_DT_TMx; }
                set { EVENT_DT_TMx = value; }
            }
            public string TRANSACTION_DT_TM
            {
                get { return TRANSACTION_DT_TMx; }
                set { TRANSACTION_DT_TMx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //PATIENT_EVENT:  ENCNTR_ID,EVENT_TYPE_CD,EVENT_DT_TM,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                PATIENT_EVENT_IDx = recs[0].Trim();
                EVENT_TYPE_CDx = recs[1].Trim();
                EVENT_DT_TMx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();

                //PATIENT_EVENT_IDx = recs[0].Trim();
                //PERSON_IDx = recs[1].Trim();
                //ENCNTR_IDx = recs[2].Trim();
                //EVENT_TYPE_CDx = recs[3].Trim();
                //EVENT_DT_TMx = recs[4].Trim();
                //TRANSACTION_DT_TMx = recs[5].Trim();
                //UPDT_CNTx = recs[6].Trim();
                //UPDT_DT_TMx = recs[7].Trim();
                //UPDT_IDx = recs[8].Trim();
                //UPDT_TASKx = recs[9].Trim();
                //UPDT_APPLCTXx = recs[10].Trim();
                //ACTIVE_INDx = recs[11].Trim();
                //ACTIVE_STATUS_CDx = recs[12].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[13].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[14].Trim();
                //LAST_UTC_TSx = recs[15].Trim();
                //INST_IDx = recs[16].Trim();
            }
        }
        public struct PATIENT_EVENT_DETAIL
        {
            private string PATIENT_EVENT_DETAIL_IDx;
            private string PATIENT_EVENT_IDx;
            private string PE_VALUE_MEANINGx;
            private string PE_VALUE_DT_TMx;
            private string PE_VALUE_NUMERICx;
            private string PE_VALUE_STRINGx;
            private string PE_VALUE_CDx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ACTIVE_STATUS_CDx;
            private string UPDT_CNTx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string UPDT_DT_TMx;
            private string PE_VALUE_IDx;
            private string PE_VALUE_NAMEx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                PATIENT_EVENT_DETAIL_IDx = "";
                PATIENT_EVENT_IDx = "";
                PE_VALUE_MEANINGx = "";
                PE_VALUE_DT_TMx = "";
                PE_VALUE_NUMERICx = "";
                PE_VALUE_STRINGx = "";
                PE_VALUE_CDx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ACTIVE_STATUS_CDx = "";
                UPDT_CNTx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                UPDT_DT_TMx = "";
                PE_VALUE_IDx = "";
                PE_VALUE_NAMEx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string PATIENT_EVENT_DETAIL_ID
            {
                get { return PATIENT_EVENT_DETAIL_IDx; }
                set { PATIENT_EVENT_DETAIL_IDx = value; }
            }
            public string PATIENT_EVENT_ID
            {
                get { return PATIENT_EVENT_IDx; }
                set { PATIENT_EVENT_IDx = value; }
            }
            public string PE_VALUE_MEANING
            {
                get { return PE_VALUE_MEANINGx; }
                set { PE_VALUE_MEANINGx = value; }
            }
            public string PE_VALUE_DT_TM
            {
                get { return PE_VALUE_DT_TMx; }
                set { PE_VALUE_DT_TMx = value; }
            }
            public string PE_VALUE_NUMERIC
            {
                get { return PE_VALUE_NUMERICx; }
                set { PE_VALUE_NUMERICx = value; }
            }
            public string PE_VALUE_STRING
            {
                get { return PE_VALUE_STRINGx; }
                set { PE_VALUE_STRINGx = value; }
            }
            public string PE_VALUE_CD
            {
                get { return PE_VALUE_CDx; }
                set { PE_VALUE_CDx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string PE_VALUE_ID
            {
                get { return PE_VALUE_IDx; }
                set { PE_VALUE_IDx = value; }
            }
            public string PE_VALUE_NAME
            {
                get { return PE_VALUE_NAMEx; }
                set { PE_VALUE_NAMEx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                string[] recs = i_record.Split('|');
                PATIENT_EVENT_DETAIL_IDx = recs[0].Trim();
                PATIENT_EVENT_IDx = recs[1].Trim();
                PE_VALUE_MEANINGx = recs[2].Trim();
                PE_VALUE_DT_TMx = recs[3].Trim();
                PE_VALUE_NUMERICx = recs[4].Trim();
                PE_VALUE_STRINGx = recs[5].Trim();
                PE_VALUE_CDx = recs[6].Trim();
                ACTIVE_INDx = recs[7].Trim();
                ACTIVE_STATUS_DT_TMx = recs[8].Trim();
                ACTIVE_STATUS_PRSNL_IDx = recs[9].Trim();
                ACTIVE_STATUS_CDx = recs[10].Trim();
                UPDT_CNTx = recs[11].Trim();
                UPDT_IDx = recs[12].Trim();
                UPDT_TASKx = recs[13].Trim();
                UPDT_APPLCTXx = recs[14].Trim();
                UPDT_DT_TMx = recs[15].Trim();
                PE_VALUE_IDx = recs[16].Trim();
                PE_VALUE_NAMEx = recs[17].Trim();
                LAST_UTC_TSx = recs[18].Trim();
                INST_IDx = recs[19].Trim();
            }
        }
        public struct PERSON
        {
            private string PERSON_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string CREATE_DT_TMx;
            private string CREATE_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string PERSON_TYPE_CDx;
            private string NAME_LAST_KEYx;
            private string NAME_FIRST_KEYx;
            private string NAME_FULL_FORMATTEDx;
            private string AUTOPSY_CDx;
            private string BIRTH_DT_CDx;
            private string BIRTH_DT_TMx;
            private string CONCEPTION_DT_TMx;
            private string CAUSE_OF_DEATHx;
            private string DECEASED_CDx;
            private string DECEASED_DT_TMx;
            private string ETHNIC_GRP_CDx;
            private string LANGUAGE_CDx;
            private string MARITAL_TYPE_CDx;
            private string PURGE_OPTION_CDx;
            private string RACE_CDx;
            private string RELIGION_CDx;
            private string SEX_CDx;
            private string SEX_AGE_CHANGE_INDx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string LANGUAGE_DIALECT_CDx;
            private string NAME_LASTx;
            private string NAME_FIRSTx;
            private string NAME_PHONETICx;
            private string LAST_ENCNTR_DT_TMx;
            private string SPECIES_CDx;
            private string CONFID_LEVEL_CDx;
            private string VIP_CDx;
            private string NAME_FIRST_SYNONYM_IDx;
            private string CITIZENSHIP_CDx;
            private string VET_MILITARY_STATUS_CDx;
            private string MOTHER_MAIDEN_NAMEx;
            private string NATIONALITY_CDx;
            private string FT_ENTITY_NAMEx;
            private string FT_ENTITY_IDx;
            private string NAME_MIDDLE_KEYx;
            private string NAME_MIDDLEx;
            private string NAME_FIRST_PHONETICx;
            private string NAME_LAST_PHONETICx;
            private string NAME_LAST_KEY_NLSx;
            private string NAME_FIRST_KEY_NLSx;
            private string NAME_MIDDLE_KEY_NLSx;
            private string MILITARY_RANK_CDx;
            private string MILITARY_BASE_LOCATIONx;
            private string MILITARY_SERVICE_CDx;
            private string DECEASED_SOURCE_CDx;
            private string CAUSE_OF_DEATH_CDx;
            private string BIRTH_TZx;
            private string BIRTH_PREC_FLAGx;
            private string ABS_BIRTH_x;

            public void Clear()
            {
                PERSON_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                CREATE_DT_TMx = "";
                CREATE_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                PERSON_TYPE_CDx = "";
                NAME_LAST_KEYx = "";
                NAME_FIRST_KEYx = "";
                NAME_FULL_FORMATTEDx = "";
                AUTOPSY_CDx = "";
                BIRTH_DT_CDx = "";
                BIRTH_DT_TMx = "";
                CONCEPTION_DT_TMx = "";
                CAUSE_OF_DEATHx = "";
                DECEASED_CDx = "";
                DECEASED_DT_TMx = "";
                ETHNIC_GRP_CDx = "";
                LANGUAGE_CDx = "";
                MARITAL_TYPE_CDx = "";
                PURGE_OPTION_CDx = "";
                RACE_CDx = "";
                RELIGION_CDx = "";
                SEX_CDx = "";
                SEX_AGE_CHANGE_INDx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                LANGUAGE_DIALECT_CDx = "";
                NAME_LASTx = "";
                NAME_FIRSTx = "";
                NAME_PHONETICx = "";
                LAST_ENCNTR_DT_TMx = "";
                SPECIES_CDx = "";
                CONFID_LEVEL_CDx = "";
                VIP_CDx = "";
                NAME_FIRST_SYNONYM_IDx = "";
                CITIZENSHIP_CDx = "";
                VET_MILITARY_STATUS_CDx = "";
                MOTHER_MAIDEN_NAMEx = "";
                NATIONALITY_CDx = "";
                FT_ENTITY_NAMEx = "";
                FT_ENTITY_IDx = "";
                NAME_MIDDLE_KEYx = "";
                NAME_MIDDLEx = "";
                NAME_FIRST_PHONETICx = "";
                NAME_LAST_PHONETICx = "";
                NAME_LAST_KEY_NLSx = "";
                NAME_FIRST_KEY_NLSx = "";
                NAME_MIDDLE_KEY_NLSx = "";
                MILITARY_RANK_CDx = "";
                MILITARY_BASE_LOCATIONx = "";
                MILITARY_SERVICE_CDx = "";
                DECEASED_SOURCE_CDx = "";
                CAUSE_OF_DEATH_CDx = "";
                BIRTH_TZx = "";
                BIRTH_PREC_FLAGx = "";
                ABS_BIRTH_x = "";
            }

            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string CREATE_DT_TM
            {
                get { return CREATE_DT_TMx; }
                set { CREATE_DT_TMx = value; }
            }
            public string CREATE_PRSNL_ID
            {
                get { return CREATE_PRSNL_IDx; }
                set { CREATE_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string PERSON_TYPE_CD
            {
                get { return PERSON_TYPE_CDx; }
                set { PERSON_TYPE_CDx = value; }
            }
            public string NAME_LAST_KEY
            {
                get { return NAME_LAST_KEYx; }
                set { NAME_LAST_KEYx = value; }
            }
            public string NAME_FIRST_KEY
            {
                get { return NAME_FIRST_KEYx; }
                set { NAME_FIRST_KEYx = value; }
            }
            public string NAME_FULL_FORMATTED
            {
                get { return NAME_FULL_FORMATTEDx; }
                set { NAME_FULL_FORMATTEDx = value; }
            }
            public string AUTOPSY_CD
            {
                get { return AUTOPSY_CDx; }
                set { AUTOPSY_CDx = value; }
            }
            public string BIRTH_DT_CD
            {
                get { return BIRTH_DT_CDx; }
                set { BIRTH_DT_CDx = value; }
            }
            public string BIRTH_DT_TM
            {
                get { return BIRTH_DT_TMx; }
                set { BIRTH_DT_TMx = value; }
            }
            public string CONCEPTION_DT_TM
            {
                get { return CONCEPTION_DT_TMx; }
                set { CONCEPTION_DT_TMx = value; }
            }
            public string CAUSE_OF_DEATH
            {
                get { return CAUSE_OF_DEATHx; }
                set { CAUSE_OF_DEATHx = value; }
            }
            public string DECEASED_CD
            {
                get { return DECEASED_CDx; }
                set { DECEASED_CDx = value; }
            }
            public string DECEASED_DT_TM
            {
                get { return DECEASED_DT_TMx; }
                set { DECEASED_DT_TMx = value; }
            }
            public string ETHNIC_GRP_CD
            {
                get { return ETHNIC_GRP_CDx; }
                set { ETHNIC_GRP_CDx = value; }
            }
            public string LANGUAGE_CD
            {
                get { return LANGUAGE_CDx; }
                set { LANGUAGE_CDx = value; }
            }
            public string MARITAL_TYPE_CD
            {
                get { return MARITAL_TYPE_CDx; }
                set { MARITAL_TYPE_CDx = value; }
            }
            public string PURGE_OPTION_CD
            {
                get { return PURGE_OPTION_CDx; }
                set { PURGE_OPTION_CDx = value; }
            }
            public string RACE_CD
            {
                get { return RACE_CDx; }
                set { RACE_CDx = value; }
            }
            public string RELIGION_CD
            {
                get { return RELIGION_CDx; }
                set { RELIGION_CDx = value; }
            }
            public string SEX_CD
            {
                get { return SEX_CDx; }
                set { SEX_CDx = value; }
            }
            public string SEX_AGE_CHANGE_IND
            {
                get { return SEX_AGE_CHANGE_INDx; }
                set { SEX_AGE_CHANGE_INDx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string LANGUAGE_DIALECT_CD
            {
                get { return LANGUAGE_DIALECT_CDx; }
                set { LANGUAGE_DIALECT_CDx = value; }
            }
            public string NAME_LAST
            {
                get { return NAME_LASTx; }
                set { NAME_LASTx = value; }
            }
            public string NAME_FIRST
            {
                get { return NAME_FIRSTx; }
                set { NAME_FIRSTx = value; }
            }
            public string NAME_PHONETIC
            {
                get { return NAME_PHONETICx; }
                set { NAME_PHONETICx = value; }
            }
            public string LAST_ENCNTR_DT_TM
            {
                get { return LAST_ENCNTR_DT_TMx; }
                set { LAST_ENCNTR_DT_TMx = value; }
            }
            public string SPECIES_CD
            {
                get { return SPECIES_CDx; }
                set { SPECIES_CDx = value; }
            }
            public string CONFID_LEVEL_CD
            {
                get { return CONFID_LEVEL_CDx; }
                set { CONFID_LEVEL_CDx = value; }
            }
            public string VIP_CD
            {
                get { return VIP_CDx; }
                set { VIP_CDx = value; }
            }
            public string NAME_FIRST_SYNONYM_ID
            {
                get { return NAME_FIRST_SYNONYM_IDx; }
                set { NAME_FIRST_SYNONYM_IDx = value; }
            }
            public string CITIZENSHIP_CD
            {
                get { return CITIZENSHIP_CDx; }
                set { CITIZENSHIP_CDx = value; }
            }
            public string VET_MILITARY_STATUS_CD
            {
                get { return VET_MILITARY_STATUS_CDx; }
                set { VET_MILITARY_STATUS_CDx = value; }
            }
            public string MOTHER_MAIDEN_NAME
            {
                get { return MOTHER_MAIDEN_NAMEx; }
                set { MOTHER_MAIDEN_NAMEx = value; }
            }
            public string NATIONALITY_CD
            {
                get { return NATIONALITY_CDx; }
                set { NATIONALITY_CDx = value; }
            }
            public string FT_ENTITY_NAME
            {
                get { return FT_ENTITY_NAMEx; }
                set { FT_ENTITY_NAMEx = value; }
            }
            public string FT_ENTITY_ID
            {
                get { return FT_ENTITY_IDx; }
                set { FT_ENTITY_IDx = value; }
            }
            public string NAME_MIDDLE_KEY
            {
                get { return NAME_MIDDLE_KEYx; }
                set { NAME_MIDDLE_KEYx = value; }
            }
            public string NAME_MIDDLE
            {
                get { return NAME_MIDDLEx; }
                set { NAME_MIDDLEx = value; }
            }
            public string NAME_FIRST_PHONETIC
            {
                get { return NAME_FIRST_PHONETICx; }
                set { NAME_FIRST_PHONETICx = value; }
            }
            public string NAME_LAST_PHONETIC
            {
                get { return NAME_LAST_PHONETICx; }
                set { NAME_LAST_PHONETICx = value; }
            }
            public string NAME_LAST_KEY_NLS
            {
                get { return NAME_LAST_KEY_NLSx; }
                set { NAME_LAST_KEY_NLSx = value; }
            }
            public string NAME_FIRST_KEY_NLS
            {
                get { return NAME_FIRST_KEY_NLSx; }
                set { NAME_FIRST_KEY_NLSx = value; }
            }
            public string NAME_MIDDLE_KEY_NLS
            {
                get { return NAME_MIDDLE_KEY_NLSx; }
                set { NAME_MIDDLE_KEY_NLSx = value; }
            }
            public string MILITARY_RANK_CD
            {
                get { return MILITARY_RANK_CDx; }
                set { MILITARY_RANK_CDx = value; }
            }
            public string MILITARY_BASE_LOCATION
            {
                get { return MILITARY_BASE_LOCATIONx; }
                set { MILITARY_BASE_LOCATIONx = value; }
            }
            public string MILITARY_SERVICE_CD
            {
                get { return MILITARY_SERVICE_CDx; }
                set { MILITARY_SERVICE_CDx = value; }
            }
            public string DECEASED_SOURCE_CD
            {
                get { return DECEASED_SOURCE_CDx; }
                set { DECEASED_SOURCE_CDx = value; }
            }
            public string CAUSE_OF_DEATH_CD
            {
                get { return CAUSE_OF_DEATH_CDx; }
                set { CAUSE_OF_DEATH_CDx = value; }
            }
            public string BIRTH_TZ
            {
                get { return BIRTH_TZx; }
                set { BIRTH_TZx = value; }
            }
            public string BIRTH_PREC_FLAG
            {
                get { return BIRTH_PREC_FLAGx; }
                set { BIRTH_PREC_FLAGx = value; }
            }
            public string ABS_BIRTH_
            {
                get { return ABS_BIRTH_x; }
                set { ABS_BIRTH_x = value; }
            }

            public void SetRecord(string i_record)
            {
                //PERSON_ID,NAME_LAST,NAME_FIRST,NAME_MIDDLE,BIRTH_DT_TM,SEX_CD,RACE_CD,MARITAL_TYPE_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM ");

                string[] recs = i_record.Split('|');
                PERSON_IDx = recs[0].Trim();
                NAME_LASTx = recs[1].Trim();
                NAME_FIRSTx = recs[2].Trim();
                NAME_MIDDLEx = recs[3].Trim();
                BIRTH_DT_TMx = recs[4].Trim();
                SEX_CDx = recs[5].Trim();
                RACE_CDx = recs[6].Trim();
                MARITAL_TYPE_CDx = recs[7].Trim();
                ACTIVE_INDx = recs[8].Trim();
                END_EFFECTIVE_DT_TMx = recs[9].Trim();


                //PERSON_IDx = recs[0].Trim();
                //UPDT_CNTx = recs[1].Trim();
                //UPDT_DT_TMx = recs[2].Trim();
                //UPDT_IDx = recs[3].Trim();
                //UPDT_TASKx = recs[4].Trim();
                //UPDT_APPLCTXx = recs[5].Trim();
                //ACTIVE_INDx = recs[6].Trim();
                //ACTIVE_STATUS_CDx = recs[7].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[8].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[9].Trim();
                //CREATE_DT_TMx = recs[10].Trim();
                //CREATE_PRSNL_IDx = recs[11].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[12].Trim();
                //END_EFFECTIVE_DT_TMx = recs[13].Trim();
                //PERSON_TYPE_CDx = recs[14].Trim();
                //NAME_LAST_KEYx = recs[15].Trim();
                //NAME_FIRST_KEYx = recs[16].Trim();
                //NAME_FULL_FORMATTEDx = recs[17].Trim();
                //AUTOPSY_CDx = recs[18].Trim();
                //BIRTH_DT_CDx = recs[19].Trim();
                //BIRTH_DT_TMx = recs[20].Trim();
                //CONCEPTION_DT_TMx = recs[21].Trim();
                //CAUSE_OF_DEATHx = recs[22].Trim();
                //DECEASED_CDx = recs[23].Trim();
                //DECEASED_DT_TMx = recs[24].Trim();
                //ETHNIC_GRP_CDx = recs[25].Trim();
                //LANGUAGE_CDx = recs[26].Trim();
                //MARITAL_TYPE_CDx = recs[27].Trim();
                //PURGE_OPTION_CDx = recs[28].Trim();
                //RACE_CDx = recs[29].Trim();
                //RELIGION_CDx = recs[30].Trim();
                //SEX_CDx = recs[31].Trim();
                //SEX_AGE_CHANGE_INDx = recs[32].Trim();
                //DATA_STATUS_CDx = recs[33].Trim();
                //DATA_STATUS_DT_TMx = recs[34].Trim();
                //DATA_STATUS_PRSNL_IDx = recs[35].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[36].Trim();
                //LANGUAGE_DIALECT_CDx = recs[37].Trim();
                //NAME_LASTx = recs[38].Trim();
                //NAME_FIRSTx = recs[39].Trim();
                //NAME_PHONETICx = recs[40].Trim();
                //LAST_ENCNTR_DT_TMx = recs[41].Trim();
                //SPECIES_CDx = recs[42].Trim();
                //CONFID_LEVEL_CDx = recs[43].Trim();
                //VIP_CDx = recs[44].Trim();
                //NAME_FIRST_SYNONYM_IDx = recs[45].Trim();
                //CITIZENSHIP_CDx = recs[46].Trim();
                //VET_MILITARY_STATUS_CDx = recs[47].Trim();
                //MOTHER_MAIDEN_NAMEx = recs[48].Trim();
                //NATIONALITY_CDx = recs[49].Trim();
                //FT_ENTITY_NAMEx = recs[50].Trim();
                //FT_ENTITY_IDx = recs[51].Trim();
                //NAME_MIDDLE_KEYx = recs[52].Trim();
                //NAME_MIDDLEx = recs[53].Trim();
                //NAME_FIRST_PHONETICx = recs[54].Trim();
                //NAME_LAST_PHONETICx = recs[55].Trim();
                //NAME_LAST_KEY_NLSx = recs[56].Trim();
                //NAME_FIRST_KEY_NLSx = recs[57].Trim();
                //NAME_MIDDLE_KEY_NLSx = recs[58].Trim();
                //MILITARY_RANK_CDx = recs[59].Trim();
                //MILITARY_BASE_LOCATIONx = recs[60].Trim();
                //MILITARY_SERVICE_CDx = recs[61].Trim();
                //DECEASED_SOURCE_CDx = recs[62].Trim();
                //CAUSE_OF_DEATH_CDx = recs[63].Trim();
                //BIRTH_TZx = recs[64].Trim();
                //BIRTH_PREC_FLAGx = recs[65].Trim();
                //ABS_BIRTH_x = recs[66].Trim();
            }
        }
        public struct PERSON_ALIAS
        {
            private string PERSON_ALIAS_IDx;
            private string PERSON_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ALIAS_POOL_CDx;
            private string PERSON_ALIAS_TYPE_CDx;
            private string ALIASx;
            private string PERSON_ALIAS_SUB_TYPE_CDx;
            private string CHECK_DIGITx;
            private string CHECK_DIGIT_METHOD_CDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string VISIT_SEQ_NBRx;
            private string HEALTH_CARD_PROVINCEx;
            private string HEALTH_CARD_VER_CODEx;
            private string ASSIGN_AUTHORITY_SYS_CDx;
            private string HEALTH_CARD_ISSUE_DT_TMx;
            private string HEALTH_CARD_EXPIRY_DT_TMx;
            private string HEALTH_CARD_TYPEx;
            private string PERSON_ALIAS_STATUS_CDx;
            private string LAST_UTC_TSx;
            private string ALIAS_EXPIRY_DT_TMx;
            private string PERSON_ALIAS_RECORD_STATUS_CDx;
            private string INST_IDx;

            public void Clear()
            {
                PERSON_ALIAS_IDx = "";
                PERSON_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ALIAS_POOL_CDx = "";
                PERSON_ALIAS_TYPE_CDx = "";
                ALIASx = "";
                PERSON_ALIAS_SUB_TYPE_CDx = "";
                CHECK_DIGITx = "";
                CHECK_DIGIT_METHOD_CDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                VISIT_SEQ_NBRx = "";
                HEALTH_CARD_PROVINCEx = "";
                HEALTH_CARD_VER_CODEx = "";
                ASSIGN_AUTHORITY_SYS_CDx = "";
                HEALTH_CARD_ISSUE_DT_TMx = "";
                HEALTH_CARD_EXPIRY_DT_TMx = "";
                HEALTH_CARD_TYPEx = "";
                PERSON_ALIAS_STATUS_CDx = "";
                LAST_UTC_TSx = "";
                ALIAS_EXPIRY_DT_TMx = "";
                PERSON_ALIAS_RECORD_STATUS_CDx = "";
                INST_IDx = "";
            }

            public string PERSON_ALIAS_ID
            {
                get { return PERSON_ALIAS_IDx; }
                set { PERSON_ALIAS_IDx = value; }
            }
            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ALIAS_POOL_CD
            {
                get { return ALIAS_POOL_CDx; }
                set { ALIAS_POOL_CDx = value; }
            }
            public string PERSON_ALIAS_TYPE_CD
            {
                get { return PERSON_ALIAS_TYPE_CDx; }
                set { PERSON_ALIAS_TYPE_CDx = value; }
            }
            public string ALIAS
            {
                get { return ALIASx; }
                set { ALIASx = value; }
            }
            public string PERSON_ALIAS_SUB_TYPE_CD
            {
                get { return PERSON_ALIAS_SUB_TYPE_CDx; }
                set { PERSON_ALIAS_SUB_TYPE_CDx = value; }
            }
            public string CHECK_DIGIT
            {
                get { return CHECK_DIGITx; }
                set { CHECK_DIGITx = value; }
            }
            public string CHECK_DIGIT_METHOD_CD
            {
                get { return CHECK_DIGIT_METHOD_CDx; }
                set { CHECK_DIGIT_METHOD_CDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string VISIT_SEQ_NBR
            {
                get { return VISIT_SEQ_NBRx; }
                set { VISIT_SEQ_NBRx = value; }
            }
            public string HEALTH_CARD_PROVINCE
            {
                get { return HEALTH_CARD_PROVINCEx; }
                set { HEALTH_CARD_PROVINCEx = value; }
            }
            public string HEALTH_CARD_VER_CODE
            {
                get { return HEALTH_CARD_VER_CODEx; }
                set { HEALTH_CARD_VER_CODEx = value; }
            }
            public string ASSIGN_AUTHORITY_SYS_CD
            {
                get { return ASSIGN_AUTHORITY_SYS_CDx; }
                set { ASSIGN_AUTHORITY_SYS_CDx = value; }
            }
            public string HEALTH_CARD_ISSUE_DT_TM
            {
                get { return HEALTH_CARD_ISSUE_DT_TMx; }
                set { HEALTH_CARD_ISSUE_DT_TMx = value; }
            }
            public string HEALTH_CARD_EXPIRY_DT_TM
            {
                get { return HEALTH_CARD_EXPIRY_DT_TMx; }
                set { HEALTH_CARD_EXPIRY_DT_TMx = value; }
            }
            public string HEALTH_CARD_TYPE
            {
                get { return HEALTH_CARD_TYPEx; }
                set { HEALTH_CARD_TYPEx = value; }
            }
            public string PERSON_ALIAS_STATUS_CD
            {
                get { return PERSON_ALIAS_STATUS_CDx; }
                set { PERSON_ALIAS_STATUS_CDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string ALIAS_EXPIRY_DT_TM
            {
                get { return ALIAS_EXPIRY_DT_TMx; }
                set { ALIAS_EXPIRY_DT_TMx = value; }
            }
            public string PERSON_ALIAS_RECORD_STATUS_CD
            {
                get { return PERSON_ALIAS_RECORD_STATUS_CDx; }
                set { PERSON_ALIAS_RECORD_STATUS_CDx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                string[] recs = i_record.Split('|');
                PERSON_ALIAS_IDx = recs[0].Trim();
                PERSON_IDx = recs[1].Trim();
                UPDT_CNTx = recs[2].Trim();
                UPDT_DT_TMx = recs[3].Trim();
                UPDT_IDx = recs[4].Trim();
                UPDT_TASKx = recs[5].Trim();
                UPDT_APPLCTXx = recs[6].Trim();
                ACTIVE_INDx = recs[7].Trim();
                ACTIVE_STATUS_CDx = recs[8].Trim();
                ACTIVE_STATUS_DT_TMx = recs[9].Trim();
                ACTIVE_STATUS_PRSNL_IDx = recs[10].Trim();
                ALIAS_POOL_CDx = recs[11].Trim();
                PERSON_ALIAS_TYPE_CDx = recs[12].Trim();
                ALIASx = recs[13].Trim();
                PERSON_ALIAS_SUB_TYPE_CDx = recs[14].Trim();
                CHECK_DIGITx = recs[15].Trim();
                CHECK_DIGIT_METHOD_CDx = recs[16].Trim();
                BEG_EFFECTIVE_DT_TMx = recs[17].Trim();
                END_EFFECTIVE_DT_TMx = recs[18].Trim();
                DATA_STATUS_CDx = recs[19].Trim();
                DATA_STATUS_DT_TMx = recs[20].Trim();
                DATA_STATUS_PRSNL_IDx = recs[21].Trim();
                CONTRIBUTOR_SYSTEM_CDx = recs[22].Trim();
                VISIT_SEQ_NBRx = recs[23].Trim();
                HEALTH_CARD_PROVINCEx = recs[24].Trim();
                HEALTH_CARD_VER_CODEx = recs[25].Trim();
                ASSIGN_AUTHORITY_SYS_CDx = recs[26].Trim();
                HEALTH_CARD_ISSUE_DT_TMx = recs[27].Trim();
                HEALTH_CARD_EXPIRY_DT_TMx = recs[28].Trim();
                HEALTH_CARD_TYPEx = recs[29].Trim();
                PERSON_ALIAS_STATUS_CDx = recs[30].Trim();
                LAST_UTC_TSx = recs[31].Trim();
                ALIAS_EXPIRY_DT_TMx = recs[32].Trim();
                PERSON_ALIAS_RECORD_STATUS_CDx = recs[33].Trim();
                INST_IDx = recs[34].Trim();
            }
        }
        public struct PROC_PRSNL_RELTN
        {
            private string PROC_PRSNL_RELTN_IDx;
            private string PRSNL_PERSON_IDx;
            private string PROC_PRSNL_RELTN_CDx;
            private string PROCEDURE_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string FREE_TEXT_CDx;
            private string FT_PRSNL_NAMEx;
            private string PROC_PRSNL_FT_INDx;
            private string PROC_FT_PRSNLx;
            private string LAST_UTC_TSx;

            public void Clear()
            {
                PROC_PRSNL_RELTN_IDx = "";
                PRSNL_PERSON_IDx = "";
                PROC_PRSNL_RELTN_CDx = "";
                PROCEDURE_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                FREE_TEXT_CDx = "";
                FT_PRSNL_NAMEx = "";
                PROC_PRSNL_FT_INDx = "";
                PROC_FT_PRSNLx = "";
                LAST_UTC_TSx = "";
            }

            public string PROC_PRSNL_RELTN_ID
            {
                get { return PROC_PRSNL_RELTN_IDx; }
                set { PROC_PRSNL_RELTN_IDx = value; }
            }
            public string PRSNL_PERSON_ID
            {
                get { return PRSNL_PERSON_IDx; }
                set { PRSNL_PERSON_IDx = value; }
            }
            public string PROC_PRSNL_RELTN_CD
            {
                get { return PROC_PRSNL_RELTN_CDx; }
                set { PROC_PRSNL_RELTN_CDx = value; }
            }
            public string PROCEDURE_ID
            {
                get { return PROCEDURE_IDx; }
                set { PROCEDURE_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string FREE_TEXT_CD
            {
                get { return FREE_TEXT_CDx; }
                set { FREE_TEXT_CDx = value; }
            }
            public string FT_PRSNL_NAME
            {
                get { return FT_PRSNL_NAMEx; }
                set { FT_PRSNL_NAMEx = value; }
            }
            public string PROC_PRSNL_FT_IND
            {
                get { return PROC_PRSNL_FT_INDx; }
                set { PROC_PRSNL_FT_INDx = value; }
            }
            public string PROC_FT_PRSNL
            {
                get { return PROC_FT_PRSNLx; }
                set { PROC_FT_PRSNLx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }

            public void SetRecord(string i_record)
            {
                //PROCEDURE_ID,PROC_PRSNL_RELTN_CD,PRSNL_PERSON_ID,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                PROCEDURE_IDx = recs[0].Trim();
                PROC_PRSNL_RELTN_CDx = recs[1].Trim();
                PRSNL_PERSON_IDx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();
                END_EFFECTIVE_DT_TMx = recs[4].Trim();


            //    PROC_PRSNL_RELTN_IDx = recs[0].Trim();
            //    PRSNL_PERSON_IDx = recs[1].Trim();
            //    PROC_PRSNL_RELTN_CDx = recs[2].Trim();
            //    PROCEDURE_IDx = recs[3].Trim();
            //    UPDT_CNTx = recs[4].Trim();
            //    UPDT_DT_TMx = recs[5].Trim();
            //    UPDT_IDx = recs[6].Trim();
            //    UPDT_TASKx = recs[7].Trim();
            //    UPDT_APPLCTXx = recs[8].Trim();
            //    ACTIVE_INDx = recs[9].Trim();
            //    ACTIVE_STATUS_CDx = recs[10].Trim();
            //    ACTIVE_STATUS_DT_TMx = recs[11].Trim();
            //    ACTIVE_STATUS_PRSNL_IDx = recs[12].Trim();
            //    BEG_EFFECTIVE_DT_TMx = recs[13].Trim();
            //    END_EFFECTIVE_DT_TMx = recs[14].Trim();
            //    CONTRIBUTOR_SYSTEM_CDx = recs[15].Trim();
            //    FREE_TEXT_CDx = recs[16].Trim();
            //    FT_PRSNL_NAMEx = recs[17].Trim();
            //    PROC_PRSNL_FT_INDx = recs[18].Trim();
            //    PROC_FT_PRSNLx = recs[19].Trim();
            //    LAST_UTC_TSx = recs[20].Trim();
            }
        }
        public struct PROCEDURE
        {
            private string PROCEDURE_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string ENCNTR_IDx;
            private string NOMENCLATURE_IDx;
            private string PROC_DT_TMx;
            private string PROC_PRIORITYx;
            private string PROC_FUNC_TYPE_CDx;
            private string PROC_MINUTESx;
            private string CONSENT_CDx;
            private string DIAG_NOMENCLATURE_IDx;
            private string REFERENCE_NBRx;
            private string SEG_UNIQUE_KEYx;
            private string MOD_NOMENCLATURE_IDx;
            private string ANESTHESIA_CDx;
            private string ANESTHESIA_MINUTESx;
            private string TISSUE_TYPE_CDx;
            private string SVC_CAT_HIST_IDx;
            private string PROC_LOC_CDx;
            private string PROC_LOC_FT_INDx;
            private string PROC_FT_LOCx;
            private string PROC_FT_DT_TM_INDx;
            private string PROC_FT_TIME_FRAMEx;
            private string COMMENT_INDx;
            private string LONG_TEXT_IDx;
            private string PROC_FTDESCx;
            private string PROCEDURE_NOTEx;
            private string GENERIC_VAL_CDx;
            private string RANKING_CDx;
            private string CLINICAL_SERVICE_CDx;
            private string DGVP_INDx;
            private string ENCNTR_SLICE_IDx;
            private string PROC_DT_TM_PREC_FLAGx;
            private string PROC_TYPE_FLAGx;
            private string SUPPRESS_NARRATIVE_INDx;
            private string PROC_DT_TM_PREC_CDx;
            private string UNITS_OF_SERVICEx;
            private string LATERALITY_CDx;
            private string LAST_UTC_TSx;

            public void Clear()
            {
                PROCEDURE_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                ENCNTR_IDx = "";
                NOMENCLATURE_IDx = "";
                PROC_DT_TMx = "";
                PROC_PRIORITYx = "";
                PROC_FUNC_TYPE_CDx = "";
                PROC_MINUTESx = "";
                CONSENT_CDx = "";
                DIAG_NOMENCLATURE_IDx = "";
                REFERENCE_NBRx = "";
                SEG_UNIQUE_KEYx = "";
                MOD_NOMENCLATURE_IDx = "";
                ANESTHESIA_CDx = "";
                ANESTHESIA_MINUTESx = "";
                TISSUE_TYPE_CDx = "";
                SVC_CAT_HIST_IDx = "";
                PROC_LOC_CDx = "";
                PROC_LOC_FT_INDx = "";
                PROC_FT_LOCx = "";
                PROC_FT_DT_TM_INDx = "";
                PROC_FT_TIME_FRAMEx = "";
                COMMENT_INDx = "";
                LONG_TEXT_IDx = "";
                PROC_FTDESCx = "";
                PROCEDURE_NOTEx = "";
                GENERIC_VAL_CDx = "";
                RANKING_CDx = "";
                CLINICAL_SERVICE_CDx = "";
                DGVP_INDx = "";
                ENCNTR_SLICE_IDx = "";
                PROC_DT_TM_PREC_FLAGx = "";
                PROC_TYPE_FLAGx = "";
                SUPPRESS_NARRATIVE_INDx = "";
                PROC_DT_TM_PREC_CDx = "";
                UNITS_OF_SERVICEx = "";
                LATERALITY_CDx = "";
                LAST_UTC_TSx = "";
            }

            public string PROCEDURE_ID
            {
                get { return PROCEDURE_IDx; }
                set { PROCEDURE_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string ENCNTR_ID
            {
                get { return ENCNTR_IDx; }
                set { ENCNTR_IDx = value; }
            }
            public string NOMENCLATURE_ID
            {
                get { return NOMENCLATURE_IDx; }
                set { NOMENCLATURE_IDx = value; }
            }
            public string PROC_DT_TM
            {
                get { return PROC_DT_TMx; }
                set { PROC_DT_TMx = value; }
            }
            public string PROC_PRIORITY
            {
                get { return PROC_PRIORITYx; }
                set { PROC_PRIORITYx = value; }
            }
            public string PROC_FUNC_TYPE_CD
            {
                get { return PROC_FUNC_TYPE_CDx; }
                set { PROC_FUNC_TYPE_CDx = value; }
            }
            public string PROC_MINUTES
            {
                get { return PROC_MINUTESx; }
                set { PROC_MINUTESx = value; }
            }
            public string CONSENT_CD
            {
                get { return CONSENT_CDx; }
                set { CONSENT_CDx = value; }
            }
            public string DIAG_NOMENCLATURE_ID
            {
                get { return DIAG_NOMENCLATURE_IDx; }
                set { DIAG_NOMENCLATURE_IDx = value; }
            }
            public string REFERENCE_NBR
            {
                get { return REFERENCE_NBRx; }
                set { REFERENCE_NBRx = value; }
            }
            public string SEG_UNIQUE_KEY
            {
                get { return SEG_UNIQUE_KEYx; }
                set { SEG_UNIQUE_KEYx = value; }
            }
            public string MOD_NOMENCLATURE_ID
            {
                get { return MOD_NOMENCLATURE_IDx; }
                set { MOD_NOMENCLATURE_IDx = value; }
            }
            public string ANESTHESIA_CD
            {
                get { return ANESTHESIA_CDx; }
                set { ANESTHESIA_CDx = value; }
            }
            public string ANESTHESIA_MINUTES
            {
                get { return ANESTHESIA_MINUTESx; }
                set { ANESTHESIA_MINUTESx = value; }
            }
            public string TISSUE_TYPE_CD
            {
                get { return TISSUE_TYPE_CDx; }
                set { TISSUE_TYPE_CDx = value; }
            }
            public string SVC_CAT_HIST_ID
            {
                get { return SVC_CAT_HIST_IDx; }
                set { SVC_CAT_HIST_IDx = value; }
            }
            public string PROC_LOC_CD
            {
                get { return PROC_LOC_CDx; }
                set { PROC_LOC_CDx = value; }
            }
            public string PROC_LOC_FT_IND
            {
                get { return PROC_LOC_FT_INDx; }
                set { PROC_LOC_FT_INDx = value; }
            }
            public string PROC_FT_LOC
            {
                get { return PROC_FT_LOCx; }
                set { PROC_FT_LOCx = value; }
            }
            public string PROC_FT_DT_TM_IND
            {
                get { return PROC_FT_DT_TM_INDx; }
                set { PROC_FT_DT_TM_INDx = value; }
            }
            public string PROC_FT_TIME_FRAME
            {
                get { return PROC_FT_TIME_FRAMEx; }
                set { PROC_FT_TIME_FRAMEx = value; }
            }
            public string COMMENT_IND
            {
                get { return COMMENT_INDx; }
                set { COMMENT_INDx = value; }
            }
            public string LONG_TEXT_ID
            {
                get { return LONG_TEXT_IDx; }
                set { LONG_TEXT_IDx = value; }
            }
            public string PROC_FTDESC
            {
                get { return PROC_FTDESCx; }
                set { PROC_FTDESCx = value; }
            }
            public string PROCEDURE_NOTE
            {
                get { return PROCEDURE_NOTEx; }
                set { PROCEDURE_NOTEx = value; }
            }
            public string GENERIC_VAL_CD
            {
                get { return GENERIC_VAL_CDx; }
                set { GENERIC_VAL_CDx = value; }
            }
            public string RANKING_CD
            {
                get { return RANKING_CDx; }
                set { RANKING_CDx = value; }
            }
            public string CLINICAL_SERVICE_CD
            {
                get { return CLINICAL_SERVICE_CDx; }
                set { CLINICAL_SERVICE_CDx = value; }
            }
            public string DGVP_IND
            {
                get { return DGVP_INDx; }
                set { DGVP_INDx = value; }
            }
            public string ENCNTR_SLICE_ID
            {
                get { return ENCNTR_SLICE_IDx; }
                set { ENCNTR_SLICE_IDx = value; }
            }
            public string PROC_DT_TM_PREC_FLAG
            {
                get { return PROC_DT_TM_PREC_FLAGx; }
                set { PROC_DT_TM_PREC_FLAGx = value; }
            }
            public string PROC_TYPE_FLAG
            {
                get { return PROC_TYPE_FLAGx; }
                set { PROC_TYPE_FLAGx = value; }
            }
            public string SUPPRESS_NARRATIVE_IND
            {
                get { return SUPPRESS_NARRATIVE_INDx; }
                set { SUPPRESS_NARRATIVE_INDx = value; }
            }
            public string PROC_DT_TM_PREC_CD
            {
                get { return PROC_DT_TM_PREC_CDx; }
                set { PROC_DT_TM_PREC_CDx = value; }
            }
            public string UNITS_OF_SERVICE
            {
                get { return UNITS_OF_SERVICEx; }
                set { UNITS_OF_SERVICEx = value; }
            }
            public string LATERALITY_CD
            {
                get { return LATERALITY_CDx; }
                set { LATERALITY_CDx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }

            public void SetRecord(string i_record)
            {
                //PROCEDURE: enctrID,NOMENCLATURE_ID,PROCEDURE_ID,PROC_DT_TM,PROC_PRIORITY,ANESTHESIA_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');
                ENCNTR_IDx = recs[0].Trim();
                NOMENCLATURE_IDx = recs[1].Trim();
                PROCEDURE_IDx = recs[2].Trim();
                PROC_DT_TMx = recs[3].Trim();
                PROC_PRIORITYx = recs[4].Trim();
                ANESTHESIA_CDx = recs[5].Trim();
                ACTIVE_INDx = recs[6].Trim();
                END_EFFECTIVE_DT_TMx = recs[7].Trim();

                //PROCEDURE_IDx = recs[0].Trim();
                //UPDT_CNTx = recs[1].Trim();
                //UPDT_DT_TMx = recs[2].Trim();
                //UPDT_IDx = recs[3].Trim();
                //UPDT_TASKx = recs[4].Trim();
                //UPDT_APPLCTXx = recs[5].Trim();
                //ACTIVE_INDx = recs[6].Trim();
                //ACTIVE_STATUS_CDx = recs[7].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[8].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[9].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[10].Trim();
                //END_EFFECTIVE_DT_TMx = recs[11].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[12].Trim();
                //ENCNTR_IDx = recs[13].Trim();
                //NOMENCLATURE_IDx = recs[14].Trim();
                //PROC_DT_TMx = recs[15].Trim();
                //PROC_PRIORITYx = recs[16].Trim();
                //PROC_FUNC_TYPE_CDx = recs[17].Trim();
                //PROC_MINUTESx = recs[18].Trim();
                //CONSENT_CDx = recs[19].Trim();
                //DIAG_NOMENCLATURE_IDx = recs[20].Trim();
                //REFERENCE_NBRx = recs[21].Trim();
                //SEG_UNIQUE_KEYx = recs[22].Trim();
                //MOD_NOMENCLATURE_IDx = recs[23].Trim();
                //ANESTHESIA_CDx = recs[24].Trim();
                //ANESTHESIA_MINUTESx = recs[25].Trim();
                //TISSUE_TYPE_CDx = recs[26].Trim();
                //SVC_CAT_HIST_IDx = recs[27].Trim();
                //PROC_LOC_CDx = recs[28].Trim();
                //PROC_LOC_FT_INDx = recs[29].Trim();
                //PROC_FT_LOCx = recs[30].Trim();
                //PROC_FT_DT_TM_INDx = recs[31].Trim();
                //PROC_FT_TIME_FRAMEx = recs[32].Trim();
                //COMMENT_INDx = recs[33].Trim();
                //LONG_TEXT_IDx = recs[34].Trim();
                //PROC_FTDESCx = recs[35].Trim();
                //PROCEDURE_NOTEx = recs[36].Trim();
                //GENERIC_VAL_CDx = recs[37].Trim();
                //RANKING_CDx = recs[38].Trim();
                //CLINICAL_SERVICE_CDx = recs[39].Trim();
                //DGVP_INDx = recs[40].Trim();
                //ENCNTR_SLICE_IDx = recs[41].Trim();
                //PROC_DT_TM_PREC_FLAGx = recs[42].Trim();
                //PROC_TYPE_FLAGx = recs[43].Trim();
                //SUPPRESS_NARRATIVE_INDx = recs[44].Trim();
                //PROC_DT_TM_PREC_CDx = recs[45].Trim();
                //UNITS_OF_SERVICEx = recs[46].Trim();
                //LATERALITY_CDx = recs[47].Trim();
                //LAST_UTC_TSx = recs[48].Trim();
            }
        }
        public struct PRSNL_SPECIALTY_RELTN
        {
            private string PRSNL_SPECIALTY_RELTN_IDx;
            private string ORIG_PRSNL_SPECIALTY_RELTN_IDx;
            private string PRSNL_IDx;
            private string SPECIALTY_CDx;
            private string PRIMARY_INDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string ACTIVE_INDx;
            private string UPDT_IDx;
            private string UPDT_DT_TMx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string UPDT_CNTx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                PRSNL_SPECIALTY_RELTN_IDx = "";
                ORIG_PRSNL_SPECIALTY_RELTN_IDx = "";
                PRSNL_IDx = "";
                SPECIALTY_CDx = "";
                PRIMARY_INDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                ACTIVE_INDx = "";
                UPDT_IDx = "";
                UPDT_DT_TMx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                UPDT_CNTx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string PRSNL_SPECIALTY_RELTN_ID
            {
                get { return PRSNL_SPECIALTY_RELTN_IDx; }
                set { PRSNL_SPECIALTY_RELTN_IDx = value; }
            }
            public string ORIG_PRSNL_SPECIALTY_RELTN_ID
            {
                get { return ORIG_PRSNL_SPECIALTY_RELTN_IDx; }
                set { ORIG_PRSNL_SPECIALTY_RELTN_IDx = value; }
            }
            public string PRSNL_ID
            {
                get { return PRSNL_IDx; }
                set { PRSNL_IDx = value; }
            }
            public string SPECIALTY_CD
            {
                get { return SPECIALTY_CDx; }
                set { SPECIALTY_CDx = value; }
            }
            public string PRIMARY_IND
            {
                get { return PRIMARY_INDx; }
                set { PRIMARY_INDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //PRSNL_SPECIALTY_RELTN:  PRSNL_ID,PRIMARY_IND,SPECIALTY_CD,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');

                PRSNL_IDx = recs[0].Trim();
                PRIMARY_INDx = recs[1].Trim();
                SPECIALTY_CDx = recs[2].Trim();
                ACTIVE_INDx = recs[3].Trim();
                END_EFFECTIVE_DT_TMx = recs[4].Trim();

                //PRSNL_SPECIALTY_RELTN_IDx = recs[0].Trim();
                //ORIG_PRSNL_SPECIALTY_RELTN_IDx = recs[1].Trim();
                //PRSNL_IDx = recs[2].Trim();
                //SPECIALTY_CDx = recs[3].Trim();
                //PRIMARY_INDx = recs[4].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[5].Trim();
                //END_EFFECTIVE_DT_TMx = recs[6].Trim();
                //ACTIVE_INDx = recs[7].Trim();
                //UPDT_IDx = recs[8].Trim();
                //UPDT_DT_TMx = recs[9].Trim();
                //UPDT_TASKx = recs[10].Trim();
                //UPDT_APPLCTXx = recs[11].Trim();
                //UPDT_CNTx = recs[12].Trim();
                //LAST_UTC_TSx = recs[13].Trim();
                //INST_IDx = recs[14].Trim();
            }
        }
        public struct PRSNL
        {
            private string PERSON_IDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string CREATE_PRSNL_IDx;
            private string CREATE_DT_TMx;
            private string NAME_LAST_KEYx;
            private string NAME_FIRST_KEYx;
            private string PRSNL_TYPE_CDx;
            private string NAME_FULL_FORMATTEDx;
            private string PASSWORDx;
            private string EMAILx;
            private string PHYSICIAN_INDx;
            private string POSITION_CDx;
            private string DEPARTMENT_CDx;
            private string FREE_TEXT_INDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string SECTION_CDx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string NAME_LASTx;
            private string NAME_FIRSTx;
            private string USERNAMEx;
            private string FT_ENTITY_NAMEx;
            private string FT_ENTITY_IDx;
            private string PRIM_ASSIGN_LOC_CDx;
            private string LOG_ACCESS_INDx;
            private string LOG_LEVELx;
            private string NAME_LAST_KEY_NLSx;
            private string NAME_FIRST_KEY_NLSx;
            private string PHYSICIAN_STATUS_CDx;
            private string LOGICAL_DOMAIN_GRP_IDx;
            private string LOGICAL_DOMAIN_IDx;
            private string NAME_LAST_KEY_A_NLSx;
            private string NAME_FIRST_KEY_A_NLSx;
            private string LAST_UTC_TSx;
            private string EXTERNAL_INDx;
            private string INST_IDx;

            public void Clear()
            {
                PERSON_IDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                CREATE_PRSNL_IDx = "";
                CREATE_DT_TMx = "";
                NAME_LAST_KEYx = "";
                NAME_FIRST_KEYx = "";
                PRSNL_TYPE_CDx = "";
                NAME_FULL_FORMATTEDx = "";
                PASSWORDx = "";
                EMAILx = "";
                PHYSICIAN_INDx = "";
                POSITION_CDx = "";
                DEPARTMENT_CDx = "";
                FREE_TEXT_INDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                SECTION_CDx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                NAME_LASTx = "";
                NAME_FIRSTx = "";
                USERNAMEx = "";
                FT_ENTITY_NAMEx = "";
                FT_ENTITY_IDx = "";
                PRIM_ASSIGN_LOC_CDx = "";
                LOG_ACCESS_INDx = "";
                LOG_LEVELx = "";
                NAME_LAST_KEY_NLSx = "";
                NAME_FIRST_KEY_NLSx = "";
                PHYSICIAN_STATUS_CDx = "";
                LOGICAL_DOMAIN_GRP_IDx = "";
                LOGICAL_DOMAIN_IDx = "";
                NAME_LAST_KEY_A_NLSx = "";
                NAME_FIRST_KEY_A_NLSx = "";
                LAST_UTC_TSx = "";
                EXTERNAL_INDx = "";
                INST_IDx = "";
            }

            public string PERSON_ID
            {
                get { return PERSON_IDx; }
                set { PERSON_IDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string CREATE_PRSNL_ID
            {
                get { return CREATE_PRSNL_IDx; }
                set { CREATE_PRSNL_IDx = value; }
            }
            public string CREATE_DT_TM
            {
                get { return CREATE_DT_TMx; }
                set { CREATE_DT_TMx = value; }
            }
            public string NAME_LAST_KEY
            {
                get { return NAME_LAST_KEYx; }
                set { NAME_LAST_KEYx = value; }
            }
            public string NAME_FIRST_KEY
            {
                get { return NAME_FIRST_KEYx; }
                set { NAME_FIRST_KEYx = value; }
            }
            public string PRSNL_TYPE_CD
            {
                get { return PRSNL_TYPE_CDx; }
                set { PRSNL_TYPE_CDx = value; }
            }
            public string NAME_FULL_FORMATTED
            {
                get { return NAME_FULL_FORMATTEDx; }
                set { NAME_FULL_FORMATTEDx = value; }
            }
            public string PASSWORD
            {
                get { return PASSWORDx; }
                set { PASSWORDx = value; }
            }
            public string EMAIL
            {
                get { return EMAILx; }
                set { EMAILx = value; }
            }
            public string PHYSICIAN_IND
            {
                get { return PHYSICIAN_INDx; }
                set { PHYSICIAN_INDx = value; }
            }
            public string POSITION_CD
            {
                get { return POSITION_CDx; }
                set { POSITION_CDx = value; }
            }
            public string DEPARTMENT_CD
            {
                get { return DEPARTMENT_CDx; }
                set { DEPARTMENT_CDx = value; }
            }
            public string FREE_TEXT_IND
            {
                get { return FREE_TEXT_INDx; }
                set { FREE_TEXT_INDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string SECTION_CD
            {
                get { return SECTION_CDx; }
                set { SECTION_CDx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string NAME_LAST
            {
                get { return NAME_LASTx; }
                set { NAME_LASTx = value; }
            }
            public string NAME_FIRST
            {
                get { return NAME_FIRSTx; }
                set { NAME_FIRSTx = value; }
            }
            public string USERNAME
            {
                get { return USERNAMEx; }
                set { USERNAMEx = value; }
            }
            public string FT_ENTITY_NAME
            {
                get { return FT_ENTITY_NAMEx; }
                set { FT_ENTITY_NAMEx = value; }
            }
            public string FT_ENTITY_ID
            {
                get { return FT_ENTITY_IDx; }
                set { FT_ENTITY_IDx = value; }
            }
            public string PRIM_ASSIGN_LOC_CD
            {
                get { return PRIM_ASSIGN_LOC_CDx; }
                set { PRIM_ASSIGN_LOC_CDx = value; }
            }
            public string LOG_ACCESS_IND
            {
                get { return LOG_ACCESS_INDx; }
                set { LOG_ACCESS_INDx = value; }
            }
            public string LOG_LEVEL
            {
                get { return LOG_LEVELx; }
                set { LOG_LEVELx = value; }
            }
            public string NAME_LAST_KEY_NLS
            {
                get { return NAME_LAST_KEY_NLSx; }
                set { NAME_LAST_KEY_NLSx = value; }
            }
            public string NAME_FIRST_KEY_NLS
            {
                get { return NAME_FIRST_KEY_NLSx; }
                set { NAME_FIRST_KEY_NLSx = value; }
            }
            public string PHYSICIAN_STATUS_CD
            {
                get { return PHYSICIAN_STATUS_CDx; }
                set { PHYSICIAN_STATUS_CDx = value; }
            }
            public string LOGICAL_DOMAIN_GRP_ID
            {
                get { return LOGICAL_DOMAIN_GRP_IDx; }
                set { LOGICAL_DOMAIN_GRP_IDx = value; }
            }
            public string LOGICAL_DOMAIN_ID
            {
                get { return LOGICAL_DOMAIN_IDx; }
                set { LOGICAL_DOMAIN_IDx = value; }
            }
            public string NAME_LAST_KEY_A_NLS
            {
                get { return NAME_LAST_KEY_A_NLSx; }
                set { NAME_LAST_KEY_A_NLSx = value; }
            }
            public string NAME_FIRST_KEY_A_NLS
            {
                get { return NAME_FIRST_KEY_A_NLSx; }
                set { NAME_FIRST_KEY_A_NLSx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string EXTERNAL_IND
            {
                get { return EXTERNAL_INDx; }
                set { EXTERNAL_INDx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                string[] recs = i_record.Split('|');
                PERSON_IDx = recs[0].Trim();
                UPDT_CNTx = recs[1].Trim();
                UPDT_DT_TMx = recs[2].Trim();
                UPDT_IDx = recs[3].Trim();
                UPDT_TASKx = recs[4].Trim();
                UPDT_APPLCTXx = recs[5].Trim();
                ACTIVE_INDx = recs[6].Trim();
                ACTIVE_STATUS_CDx = recs[7].Trim();
                ACTIVE_STATUS_DT_TMx = recs[8].Trim();
                ACTIVE_STATUS_PRSNL_IDx = recs[9].Trim();
                CREATE_PRSNL_IDx = recs[10].Trim();
                CREATE_DT_TMx = recs[11].Trim();
                NAME_LAST_KEYx = recs[12].Trim();
                NAME_FIRST_KEYx = recs[13].Trim();
                PRSNL_TYPE_CDx = recs[14].Trim();
                NAME_FULL_FORMATTEDx = recs[15].Trim();
                PASSWORDx = recs[16].Trim();
                EMAILx = recs[17].Trim();
                PHYSICIAN_INDx = recs[18].Trim();
                POSITION_CDx = recs[19].Trim();
                DEPARTMENT_CDx = recs[20].Trim();
                FREE_TEXT_INDx = recs[21].Trim();
                BEG_EFFECTIVE_DT_TMx = recs[22].Trim();
                END_EFFECTIVE_DT_TMx = recs[23].Trim();
                SECTION_CDx = recs[24].Trim();
                DATA_STATUS_CDx = recs[25].Trim();
                DATA_STATUS_DT_TMx = recs[26].Trim();
                DATA_STATUS_PRSNL_IDx = recs[27].Trim();
                CONTRIBUTOR_SYSTEM_CDx = recs[28].Trim();
                NAME_LASTx = recs[29].Trim();
                NAME_FIRSTx = recs[30].Trim();
                USERNAMEx = recs[31].Trim();
                FT_ENTITY_NAMEx = recs[32].Trim();
                FT_ENTITY_IDx = recs[33].Trim();
                PRIM_ASSIGN_LOC_CDx = recs[34].Trim();
                LOG_ACCESS_INDx = recs[35].Trim();
                LOG_LEVELx = recs[36].Trim();
                NAME_LAST_KEY_NLSx = recs[37].Trim();
                NAME_FIRST_KEY_NLSx = recs[38].Trim();
                PHYSICIAN_STATUS_CDx = recs[39].Trim();
                LOGICAL_DOMAIN_GRP_IDx = recs[40].Trim();
                LOGICAL_DOMAIN_IDx = recs[41].Trim();
                NAME_LAST_KEY_A_NLSx = recs[42].Trim();
                NAME_FIRST_KEY_A_NLSx = recs[43].Trim();
                LAST_UTC_TSx = recs[44].Trim();
                EXTERNAL_INDx = recs[45].Trim();
                INST_IDx = recs[46].Trim();
            }
        }
        public struct Address
        {
            private string ADDRESS_IDx;
            private string PARENT_ENTITY_NAMEx;
            private string PARENT_ENTITY_IDx;
            private string ADDRESS_TYPE_CDx;
            private string UPDT_CNTx;
            private string UPDT_DT_TMx;
            private string UPDT_IDx;
            private string UPDT_TASKx;
            private string UPDT_APPLCTXx;
            private string ACTIVE_INDx;
            private string ACTIVE_STATUS_CDx;
            private string ACTIVE_STATUS_DT_TMx;
            private string ACTIVE_STATUS_PRSNL_IDx;
            private string ADDRESS_FORMAT_CDx;
            private string BEG_EFFECTIVE_DT_TMx;
            private string END_EFFECTIVE_DT_TMx;
            private string CONTACT_NAMEx;
            private string RESIDENCE_TYPE_CDx;
            private string COMMENT_TXTx;
            private string STREET_ADDRx;
            private string STREET_ADDR2x;
            private string STREET_ADDR3x;
            private string STREET_ADDR4x;
            private string CITYx;
            private string STATEx;
            private string STATE_CDx;
            private string ZIPCODEx;
            private string ZIP_CODE_GROUP_CDx;
            private string POSTAL_BARCODE_INFOx;
            private string COUNTYx;
            private string COUNTY_CDx;
            private string COUNTRYx;
            private string COUNTRY_CDx;
            private string RESIDENCE_CDx;
            private string MAIL_STOPx;
            private string DATA_STATUS_CDx;
            private string DATA_STATUS_DT_TMx;
            private string DATA_STATUS_PRSNL_IDx;
            private string ADDRESS_TYPE_SEQx;
            private string BEG_EFFECTIVE_MM_DDx;
            private string END_EFFECTIVE_MM_DDx;
            private string CONTRIBUTOR_SYSTEM_CDx;
            private string OPERATION_HOURSx;
            private string LONG_TEXT_IDx;
            private string ADDRESS_INFO_STATUS_CDx;
            private string PRIMARY_CARE_CDx;
            private string DISTRICT_HEALTH_CDx;
            private string ZIPCODE_KEYx;
            private string POSTAL_IDENTIFIERx;
            private string POSTAL_IDENTIFIER_KEYx;
            private string SOURCE_IDENTIFIERx;
            private string CITY_CDx;
            private string VALIDATION_EXPIRE_DT_TMx;
            private string LAST_UTC_TSx;
            private string INST_IDx;

            public void Clear()
            {
                ADDRESS_IDx = "";
                PARENT_ENTITY_NAMEx = "";
                PARENT_ENTITY_IDx = "";
                ADDRESS_TYPE_CDx = "";
                UPDT_CNTx = "";
                UPDT_DT_TMx = "";
                UPDT_IDx = "";
                UPDT_TASKx = "";
                UPDT_APPLCTXx = "";
                ACTIVE_INDx = "";
                ACTIVE_STATUS_CDx = "";
                ACTIVE_STATUS_DT_TMx = "";
                ACTIVE_STATUS_PRSNL_IDx = "";
                ADDRESS_FORMAT_CDx = "";
                BEG_EFFECTIVE_DT_TMx = "";
                END_EFFECTIVE_DT_TMx = "";
                CONTACT_NAMEx = "";
                RESIDENCE_TYPE_CDx = "";
                COMMENT_TXTx = "";
                STREET_ADDRx = "";
                STREET_ADDR2x = "";
                STREET_ADDR3x = "";
                STREET_ADDR4x = "";
                CITYx = "";
                STATEx = "";
                STATE_CDx = "";
                ZIPCODEx = "";
                ZIP_CODE_GROUP_CDx = "";
                POSTAL_BARCODE_INFOx = "";
                COUNTYx = "";
                COUNTY_CDx = "";
                COUNTRYx = "";
                COUNTRY_CDx = "";
                RESIDENCE_CDx = "";
                MAIL_STOPx = "";
                DATA_STATUS_CDx = "";
                DATA_STATUS_DT_TMx = "";
                DATA_STATUS_PRSNL_IDx = "";
                ADDRESS_TYPE_SEQx = "";
                BEG_EFFECTIVE_MM_DDx = "";
                END_EFFECTIVE_MM_DDx = "";
                CONTRIBUTOR_SYSTEM_CDx = "";
                OPERATION_HOURSx = "";
                LONG_TEXT_IDx = "";
                ADDRESS_INFO_STATUS_CDx = "";
                PRIMARY_CARE_CDx = "";
                DISTRICT_HEALTH_CDx = "";
                ZIPCODE_KEYx = "";
                POSTAL_IDENTIFIERx = "";
                POSTAL_IDENTIFIER_KEYx = "";
                SOURCE_IDENTIFIERx = "";
                CITY_CDx = "";
                VALIDATION_EXPIRE_DT_TMx = "";
                LAST_UTC_TSx = "";
                INST_IDx = "";
            }

            public string ADDRESS_ID
            {
                get { return ADDRESS_IDx; }
                set { ADDRESS_IDx = value; }
            }
            public string PARENT_ENTITY_NAME
            {
                get { return PARENT_ENTITY_NAMEx; }
                set { PARENT_ENTITY_NAMEx = value; }
            }
            public string PARENT_ENTITY_ID
            {
                get { return PARENT_ENTITY_IDx; }
                set { PARENT_ENTITY_IDx = value; }
            }
            public string ADDRESS_TYPE_CD
            {
                get { return ADDRESS_TYPE_CDx; }
                set { ADDRESS_TYPE_CDx = value; }
            }
            public string UPDT_CNT
            {
                get { return UPDT_CNTx; }
                set { UPDT_CNTx = value; }
            }
            public string UPDT_DT_TM
            {
                get { return UPDT_DT_TMx; }
                set { UPDT_DT_TMx = value; }
            }
            public string UPDT_ID
            {
                get { return UPDT_IDx; }
                set { UPDT_IDx = value; }
            }
            public string UPDT_TASK
            {
                get { return UPDT_TASKx; }
                set { UPDT_TASKx = value; }
            }
            public string UPDT_APPLCTX
            {
                get { return UPDT_APPLCTXx; }
                set { UPDT_APPLCTXx = value; }
            }
            public string ACTIVE_IND
            {
                get { return ACTIVE_INDx; }
                set { ACTIVE_INDx = value; }
            }
            public string ACTIVE_STATUS_CD
            {
                get { return ACTIVE_STATUS_CDx; }
                set { ACTIVE_STATUS_CDx = value; }
            }
            public string ACTIVE_STATUS_DT_TM
            {
                get { return ACTIVE_STATUS_DT_TMx; }
                set { ACTIVE_STATUS_DT_TMx = value; }
            }
            public string ACTIVE_STATUS_PRSNL_ID
            {
                get { return ACTIVE_STATUS_PRSNL_IDx; }
                set { ACTIVE_STATUS_PRSNL_IDx = value; }
            }
            public string ADDRESS_FORMAT_CD
            {
                get { return ADDRESS_FORMAT_CDx; }
                set { ADDRESS_FORMAT_CDx = value; }
            }
            public string BEG_EFFECTIVE_DT_TM
            {
                get { return BEG_EFFECTIVE_DT_TMx; }
                set { BEG_EFFECTIVE_DT_TMx = value; }
            }
            public string END_EFFECTIVE_DT_TM
            {
                get { return END_EFFECTIVE_DT_TMx; }
                set { END_EFFECTIVE_DT_TMx = value; }
            }
            public string CONTACT_NAME
            {
                get { return CONTACT_NAMEx; }
                set { CONTACT_NAMEx = value; }
            }
            public string RESIDENCE_TYPE_CD
            {
                get { return RESIDENCE_TYPE_CDx; }
                set { RESIDENCE_TYPE_CDx = value; }
            }
            public string COMMENT_TXT
            {
                get { return COMMENT_TXTx; }
                set { COMMENT_TXTx = value; }
            }
            public string STREET_ADDR
            {
                get { return STREET_ADDRx; }
                set { STREET_ADDRx = value; }
            }
            public string STREET_ADDR2
            {
                get { return STREET_ADDR2x; }
                set { STREET_ADDR2x = value; }
            }
            public string STREET_ADDR3
            {
                get { return STREET_ADDR3x; }
                set { STREET_ADDR3x = value; }
            }
            public string STREET_ADDR4
            {
                get { return STREET_ADDR4x; }
                set { STREET_ADDR4x = value; }
            }
            public string CITY
            {
                get { return CITYx; }
                set { CITYx = value; }
            }
            public string STATE
            {
                get { return STATEx; }
                set { STATEx = value; }
            }
            public string STATE_CD
            {
                get { return STATE_CDx; }
                set { STATE_CDx = value; }
            }
            public string ZIPCODE
            {
                get { return ZIPCODEx; }
                set { ZIPCODEx = value; }
            }
            public string ZIP_CODE_GROUP_CD
            {
                get { return ZIP_CODE_GROUP_CDx; }
                set { ZIP_CODE_GROUP_CDx = value; }
            }
            public string POSTAL_BARCODE_INFO
            {
                get { return POSTAL_BARCODE_INFOx; }
                set { POSTAL_BARCODE_INFOx = value; }
            }
            public string COUNTY
            {
                get { return COUNTYx; }
                set { COUNTYx = value; }
            }
            public string COUNTY_CD
            {
                get { return COUNTY_CDx; }
                set { COUNTY_CDx = value; }
            }
            public string COUNTRY
            {
                get { return COUNTRYx; }
                set { COUNTRYx = value; }
            }
            public string COUNTRY_CD
            {
                get { return COUNTRY_CDx; }
                set { COUNTRY_CDx = value; }
            }
            public string RESIDENCE_CD
            {
                get { return RESIDENCE_CDx; }
                set { RESIDENCE_CDx = value; }
            }
            public string MAIL_STOP
            {
                get { return MAIL_STOPx; }
                set { MAIL_STOPx = value; }
            }
            public string DATA_STATUS_CD
            {
                get { return DATA_STATUS_CDx; }
                set { DATA_STATUS_CDx = value; }
            }
            public string DATA_STATUS_DT_TM
            {
                get { return DATA_STATUS_DT_TMx; }
                set { DATA_STATUS_DT_TMx = value; }
            }
            public string DATA_STATUS_PRSNL_ID
            {
                get { return DATA_STATUS_PRSNL_IDx; }
                set { DATA_STATUS_PRSNL_IDx = value; }
            }
            public string ADDRESS_TYPE_SEQ
            {
                get { return ADDRESS_TYPE_SEQx; }
                set { ADDRESS_TYPE_SEQx = value; }
            }
            public string BEG_EFFECTIVE_MM_DD
            {
                get { return BEG_EFFECTIVE_MM_DDx; }
                set { BEG_EFFECTIVE_MM_DDx = value; }
            }
            public string END_EFFECTIVE_MM_DD
            {
                get { return END_EFFECTIVE_MM_DDx; }
                set { END_EFFECTIVE_MM_DDx = value; }
            }
            public string CONTRIBUTOR_SYSTEM_CD
            {
                get { return CONTRIBUTOR_SYSTEM_CDx; }
                set { CONTRIBUTOR_SYSTEM_CDx = value; }
            }
            public string OPERATION_HOURS
            {
                get { return OPERATION_HOURSx; }
                set { OPERATION_HOURSx = value; }
            }
            public string LONG_TEXT_ID
            {
                get { return LONG_TEXT_IDx; }
                set { LONG_TEXT_IDx = value; }
            }
            public string ADDRESS_INFO_STATUS_CD
            {
                get { return ADDRESS_INFO_STATUS_CDx; }
                set { ADDRESS_INFO_STATUS_CDx = value; }
            }
            public string PRIMARY_CARE_CD
            {
                get { return PRIMARY_CARE_CDx; }
                set { PRIMARY_CARE_CDx = value; }
            }
            public string DISTRICT_HEALTH_CD
            {
                get { return DISTRICT_HEALTH_CDx; }
                set { DISTRICT_HEALTH_CDx = value; }
            }
            public string ZIPCODE_KEY
            {
                get { return ZIPCODE_KEYx; }
                set { ZIPCODE_KEYx = value; }
            }
            public string POSTAL_IDENTIFIER
            {
                get { return POSTAL_IDENTIFIERx; }
                set { POSTAL_IDENTIFIERx = value; }
            }
            public string POSTAL_IDENTIFIER_KEY
            {
                get { return POSTAL_IDENTIFIER_KEYx; }
                set { POSTAL_IDENTIFIER_KEYx = value; }
            }
            public string SOURCE_IDENTIFIER
            {
                get { return SOURCE_IDENTIFIERx; }
                set { SOURCE_IDENTIFIERx = value; }
            }
            public string CITY_CD
            {
                get { return CITY_CDx; }
                set { CITY_CDx = value; }
            }
            public string VALIDATION_EXPIRE_DT_TM
            {
                get { return VALIDATION_EXPIRE_DT_TMx; }
                set { VALIDATION_EXPIRE_DT_TMx = value; }
            }
            public string LAST_UTC_TS
            {
                get { return LAST_UTC_TSx; }
                set { LAST_UTC_TSx = value; }
            }
            public string INST_ID
            {
                get { return INST_IDx; }
                set { INST_IDx = value; }
            }

            public void SetRecord(string i_record)
            {
                //PARENT_ENTITY_ID,PARENT_ENTITY_NAME,ADDRESS_TYPE_CD,ZIPCODE,ACTIVE_IND,END_EFFECTIVE_DT_TM
                string[] recs = i_record.Split('|');

                PARENT_ENTITY_IDx = recs[0].Trim();
                PARENT_ENTITY_NAMEx = recs[1].Trim();
                ADDRESS_TYPE_CDx = recs[2].Trim();
                ZIPCODEx = recs[3].Trim();
                ACTIVE_INDx = recs[4].Trim();
                END_EFFECTIVE_DT_TMx = recs[5].Trim();



                //ADDRESS_IDx = recs[0].Trim();
                //PARENT_ENTITY_NAMEx = recs[1].Trim();
                //PARENT_ENTITY_IDx = recs[2].Trim();
                //ADDRESS_TYPE_CDx = recs[3].Trim();
                //UPDT_CNTx = recs[4].Trim();
                //UPDT_DT_TMx = recs[5].Trim();
                //UPDT_IDx = recs[6].Trim();
                //UPDT_TASKx = recs[7].Trim();
                //UPDT_APPLCTXx = recs[8].Trim();
                //ACTIVE_INDx = recs[9].Trim();
                //ACTIVE_STATUS_CDx = recs[10].Trim();
                //ACTIVE_STATUS_DT_TMx = recs[11].Trim();
                //ACTIVE_STATUS_PRSNL_IDx = recs[12].Trim();
                //ADDRESS_FORMAT_CDx = recs[13].Trim();
                //BEG_EFFECTIVE_DT_TMx = recs[14].Trim();
                //END_EFFECTIVE_DT_TMx = recs[15].Trim();
                //CONTACT_NAMEx = recs[16].Trim();
                //RESIDENCE_TYPE_CDx = recs[17].Trim();
                //COMMENT_TXTx = recs[18].Trim();
                //STREET_ADDRx = recs[19].Trim();
                //STREET_ADDR2x = recs[20].Trim();
                //STREET_ADDR3x = recs[21].Trim();
                //STREET_ADDR4x = recs[22].Trim();
                //CITYx = recs[23].Trim();
                //STATEx = recs[24].Trim();
                //STATE_CDx = recs[25].Trim();
                //ZIPCODEx = recs[26].Trim();
                //ZIP_CODE_GROUP_CDx = recs[27].Trim();
                //POSTAL_BARCODE_INFOx = recs[28].Trim();
                //COUNTYx = recs[29].Trim();
                //COUNTY_CDx = recs[30].Trim();
                //COUNTRYx = recs[31].Trim();
                //COUNTRY_CDx = recs[32].Trim();
                //RESIDENCE_CDx = recs[33].Trim();
                //MAIL_STOPx = recs[34].Trim();
                //DATA_STATUS_CDx = recs[35].Trim();
                //DATA_STATUS_DT_TMx = recs[36].Trim();
                //DATA_STATUS_PRSNL_IDx = recs[37].Trim();
                //ADDRESS_TYPE_SEQx = recs[38].Trim();
                //BEG_EFFECTIVE_MM_DDx = recs[39].Trim();
                //END_EFFECTIVE_MM_DDx = recs[40].Trim();
                //CONTRIBUTOR_SYSTEM_CDx = recs[41].Trim();
                //OPERATION_HOURSx = recs[42].Trim();
                //LONG_TEXT_IDx = recs[43].Trim();
                //ADDRESS_INFO_STATUS_CDx = recs[44].Trim();
                //PRIMARY_CARE_CDx = recs[45].Trim();
                //DISTRICT_HEALTH_CDx = recs[46].Trim();
                //ZIPCODE_KEYx = recs[47].Trim();
                //POSTAL_IDENTIFIERx = recs[48].Trim();
                //POSTAL_IDENTIFIER_KEYx = recs[49].Trim();
                //SOURCE_IDENTIFIERx = recs[50].Trim();
                //CITY_CDx = recs[51].Trim();
                //VALIDATION_EXPIRE_DT_TMx = recs[52].Trim();
                //LAST_UTC_TSx = recs[53].Trim();
                //INST_IDx = recs[54].Trim();
            }

        }
    }
}
