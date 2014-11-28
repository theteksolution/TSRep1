using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLOB.ViewModels
{
   
    public class PostObservationVM
    {
        public int POQID { get; set; }
        public string POQType { get; set; }
        public string SubSection { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string Answer { get; set; }
        public int DisplayOrder { get; set; }

        public bool AnswerValue
        {
            get
            {
                if (Answer != null)
                {
                    return Boolean.Parse(Answer);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}