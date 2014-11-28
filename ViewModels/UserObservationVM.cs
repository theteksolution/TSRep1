using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLOB.ViewModels
{
    public class UserObservationVM
    {
        public int ObservationID { get; set; }
        public DateTime ObservationDate { get; set; }

        public string ObservationDateShort
        {
            get
            {
                return ObservationDate.ToShortDateString();
            }
        }
    }
}