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
    
    public partial class CLOB_ObservationBackground
    {
        public int ObservationID { get; set; }
        public string UserID { get; set; }
        public int StartingNumberOfFemales { get; set; }
        public int EndingNumberOfFemales { get; set; }
        public int StartingNumberOfMales { get; set; }
        public int EndingNumberOfMales { get; set; }
        public string ObtainedArtifactsCopy { get; set; }
        public string UseInstructionalArtifacts { get; set; }
        public string ClassID { get; set; }
        public DateTime ObservationDate { get; set; }
        public string ClassStartTime { get; set; }
        public string ClassEndTime { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> LastEdit { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
    }
}