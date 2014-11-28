using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLOB.ViewModels
{
    public class ObservationInformationReportVM
    {
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
    }

    public class ObservationNameCountReportVM
    {
        public List<string> Categories { get; set; }
        public List<int> Data { get; set; }
    }

    public class HCFormat
    {
        public string name { get; set; }
    }

    public class HCFormatInt : HCFormat
    {
        public List<int> data { get; set; }
    }

    public class HCFormatString : HCFormat
    {
        public List<string> data { get; set; }
    }

}