using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLOB.ViewModels
{
    public class ObservationInformationVM
    {
        public int ObservationInformationID { get; set; }
        public int ObservationID { get; set; }
        public int AcknowledgeCount { get; set; }
        public int ApplyCount { get; set; }
        public int CorrectCount { get; set; }
        public int DirectionsCount { get; set; }
        public int ExplainCount { get; set; }
        public int FactsCount { get; set; }
        public int ForeshadowCount { get; set; }
        public int GiveInfoCount { get; set; }
        public int ItineraryCount { get; set; }
        public int MetaCount { get; set; }
        public int NewAndOldCount { get; set; }
        public int PraiseCount { get; set; }
        public int ProceduralCount { get; set; }
        public int ReflectCount { get; set; }
        public int RephraseCount { get; set; }
        public int SolicitCount { get; set; }
        public int SituateCount { get; set; }
        public int SuggestCount { get; set; }
        public int SummarizeCount { get; set; }
        public int ThinkAloudCount { get; set; }
        public string ClassActivityCode { get; set; }
        public string ClassOrganizationCode { get; set; }
        public string StudentDisengagementCode { get; set; }
        public SelectList ClassActivityCodeList { get; set; }
        public SelectList ClassOrganizationCodeList { get; set; }
        public SelectList StudentDisengagementCodeList { get; set; }
        public string Notes { get; set; }


        public void BuildCodeLists()
        {
            List<SelectListItem> slActivityCodes = new List<SelectListItem>();
            List<SelectListItem> slClassOrganizationCodes = new List<SelectListItem>();
            List<SelectListItem> slStudentEngagementCodes = new List<SelectListItem>();


            slActivityCodes.Add(new SelectListItem { Text = "INST", Value = "INST" });
            slActivityCodes.Add(new SelectListItem { Text = "MODL", Value = "MODL" });
            slActivityCodes.Add(new SelectListItem { Text = "DISC", Value = "DISC" });
            slActivityCodes.Add(new SelectListItem { Text = "DEMO", Value = "DEMO" });
            slActivityCodes.Add(new SelectListItem { Text = "READ", Value = "READ" });
            slActivityCodes.Add(new SelectListItem { Text = "SIM", Value = "SIM" });
            slActivityCodes.Add(new SelectListItem { Text = "PRES", Value = "PRES" });
            slActivityCodes.Add(new SelectListItem { Text = "WRIT", Value = "WRIT" });
            slActivityCodes.Add(new SelectListItem { Text = "HANDS", Value = "HANDS" });
            slActivityCodes.Add(new SelectListItem { Text = "LIT", Value = "LIT" });
            slActivityCodes.Add(new SelectListItem { Text = "FIELD", Value = "FIELD" });
            slActivityCodes.Add(new SelectListItem { Text = "ASMT", Value = "ASMT" });
            slActivityCodes.Add(new SelectListItem { Text = "SEC", Value = "SEC" });
            slActivityCodes.Add(new SelectListItem { Text = "STN", Value = "STN" });

            this.ClassActivityCodeList = new SelectList(slActivityCodes, "Text", "Value", ClassActivityCode );


            slClassOrganizationCodes.Add(new SelectListItem { Text = "I", Value = "I" });
            slClassOrganizationCodes.Add(new SelectListItem { Text = "P", Value = "P" });
            slClassOrganizationCodes.Add(new SelectListItem { Text = "G", Value = "G" });
            slClassOrganizationCodes.Add(new SelectListItem { Text = "W", Value = "W" });

            this.ClassOrganizationCodeList = new SelectList(slClassOrganizationCodes, "Text", "Value", ClassOrganizationCode );


            slStudentEngagementCodes.Add(new SelectListItem { Text = "NONE", Value = "NONE" });
            slStudentEngagementCodes.Add(new SelectListItem { Text = "FEW", Value = "FEW" });
            slStudentEngagementCodes.Add(new SelectListItem { Text = "HALF", Value = "HALF" });
            slStudentEngagementCodes.Add(new SelectListItem { Text = "MOST", Value = "MOST" });
            slStudentEngagementCodes.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
            slStudentEngagementCodes.Add(new SelectListItem { Text = "NA", Value = "NA" });

            this.StudentDisengagementCodeList = new SelectList(slStudentEngagementCodes, "Text", "Value", StudentDisengagementCode ); 

        }
    }
}