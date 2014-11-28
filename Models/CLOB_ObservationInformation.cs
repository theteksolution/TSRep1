//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLOB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLOB_ObservationInformation
    {
        public int ObservationInformationID { get; set; }
        public int ObservationID { get; set; }
        public string UserID { get; set; }
        public string LessonEventName { get; set; }
        public Nullable<int> AcknowledgeCount { get; set; }
        public Nullable<int> SolicitCount { get; set; }
        public Nullable<int> ApplyCount { get; set; }
        public Nullable<int> CorrectCount { get; set; }
        public Nullable<int> DirectionsCount { get; set; }
        public Nullable<int> ExplainCount { get; set; }
        public Nullable<int> FactsCount { get; set; }
        public Nullable<int> ForeshadowCount { get; set; }
        public Nullable<int> GiveInfoCount { get; set; }
        public Nullable<int> ItineraryCount { get; set; }
        public Nullable<int> MetaCount { get; set; }
        public Nullable<int> NewAndOldCount { get; set; }
        public Nullable<int> PraiseCount { get; set; }
        public Nullable<int> ProceduralCount { get; set; }
        public Nullable<int> ReflectCount { get; set; }
        public Nullable<int> RephraseCount { get; set; }
        public Nullable<int> SituateCount { get; set; }
        public Nullable<int> SuggestCount { get; set; }
        public Nullable<int> SummarizeCount { get; set; }
        public Nullable<int> ThinkAloudCount { get; set; }
        public string ClassActivityCode { get; set; }
        public string ClassOrganizationCode { get; set; }
        public string Notes { get; set; }
        public string StudentDisengagementCode { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> LastEdit { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
    }
}