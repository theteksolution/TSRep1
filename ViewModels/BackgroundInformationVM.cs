using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLOB.ViewModels
{
    public class BackgroundInformationVM
    {
        public int ObservationID { get; set; }
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


        public string ObservationDateShort
        {
            get
            {
                return ObservationDate.ToShortDateString();
            }
            set
            {
                ObservationDate = Convert.ToDateTime(value);
            }
        }

        public bool ObtainedArtifactsCopyValue
        {
            get 
            {
                if (ObtainedArtifactsCopy != null)
                {
                    return Boolean.Parse(ObtainedArtifactsCopy);
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UseInstructionalArtifactsValue
        {
            get 
            {
                if (UseInstructionalArtifacts != null)
                {
                    return Boolean.Parse(UseInstructionalArtifacts);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}