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
    
    public partial class CLOB_ObservationsAnswers
    {
        public int ObservationAnswersID { get; set; }
        public int ObservationID { get; set; }
        public int POQID { get; set; }
        public int UserID { get; set; }
        public string POQType { get; set; }
        public string Answer { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> LastEdit { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
    }
}