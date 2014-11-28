using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CLOB.ViewModels;
using CLOB.Models;
using System.Web.Mvc;


namespace CLOB.BusinessLogic
{
    public class ObservationBL
    {


        // Background Information

        public BackgroundInformationVM GetBackgrounfInformation(int ID = 0)
        {
            int ObservID = 0;

            if (HttpContext.Current.Session["NewObservation"] == null)
            {
                if (ID != 0)
                {
                    HttpContext.Current.Session["ObservationID"] = ID;
                    ObservID = ID;
                }
                else
                {
                    ObservID = (int)HttpContext.Current.Session["ObservationID"];
                }


                CLOBEntities clob = new CLOBEntities();

                var oi = (from o in clob.CLOB_ObservationBackground
                          where o.ObservationID == ObservID
                          select new BackgroundInformationVM
                          {
                              ClassEndTime = o.ClassEndTime,
                              ClassID = o.ClassID,
                              ClassStartTime = o.ClassStartTime,
                              EndingNumberOfFemales = o.EndingNumberOfFemales,
                              EndingNumberOfMales = o.EndingNumberOfMales,
                              Notes = o.Notes,
                              ObservationDate = o.ObservationDate,
                              ObservationID = o.ObservationID,
                              ObtainedArtifactsCopy = o.ObtainedArtifactsCopy,
                              StartingNumberOfFemales = o.StartingNumberOfFemales,
                              StartingNumberOfMales = o.StartingNumberOfMales,
                              UseInstructionalArtifacts = o.UseInstructionalArtifacts
                          }).FirstOrDefault();


                return oi;
            }

            return new BackgroundInformationVM();

        }

        public void UpdateBackgroundInformation(BackgroundInformationVM biVM)
        {
            CLOBEntities clob = new CLOBEntities();

            int ObservID = 0;

            if (HttpContext.Current.Session["ObservationID"] != null)
            {
                ObservID = (int)HttpContext.Current.Session["ObservationID"];
            }
           

            if (ObservID == 0)
            {
                CLOB_ObservationBackground ob = new CLOB_ObservationBackground
                {
                    UserID = HttpContext.Current.Session["UserID"].ToString(),
                    ObservationDate = DateTime.Now,
                    ClassEndTime = biVM.ClassEndTime,
                    ClassStartTime = biVM.ClassStartTime,
                    StartingNumberOfMales = biVM.StartingNumberOfMales,
                    StartingNumberOfFemales = biVM.StartingNumberOfFemales,
                    EndingNumberOfMales = biVM.EndingNumberOfMales,
                    EndingNumberOfFemales = biVM.EndingNumberOfFemales,
                    ObtainedArtifactsCopy = biVM.ObtainedArtifactsCopy,
                    UseInstructionalArtifacts = biVM.UseInstructionalArtifacts,
                    Notes = biVM.Notes
                };



                clob.CLOB_ObservationBackground.Add(ob);
                clob.SaveChanges();

                HttpContext.Current.Session["ObservationID"] = ob.ObservationID;
                HttpContext.Current.Session.Remove("NewObservation");
                
            }
            else
            {
                var result = clob.CLOB_ObservationBackground.Where(ob => ob.ObservationID == biVM.ObservationID).FirstOrDefault();

                result.ObservationDate = Convert.ToDateTime(biVM.ObservationDateShort);
                result.ClassEndTime = biVM.ClassEndTime;
                result.ClassStartTime = biVM.ClassStartTime;
                result.StartingNumberOfMales = biVM.StartingNumberOfMales;
                result.StartingNumberOfFemales = biVM.StartingNumberOfFemales;
                result.EndingNumberOfMales = biVM.EndingNumberOfMales;
                result.EndingNumberOfFemales = biVM.EndingNumberOfFemales;
                result.ObtainedArtifactsCopy = biVM.ObtainedArtifactsCopy.ToString();
                result.UseInstructionalArtifacts = biVM.UseInstructionalArtifacts.ToString();
                result.Notes = biVM.Notes;

                clob.SaveChanges();
            }
        }



        // Observation Information

        public ObservationInformationVM GetObservationInformation()
        {

            int ObservID = 0;

            if (HttpContext.Current.Session["ObservationID"] != null)
            {
                ObservID = (int)HttpContext.Current.Session["ObservationID"];
            }


            ObservationInformationVM odVM = new ObservationInformationVM();

            CLOBEntities clob = new CLOBEntities();

            var obs = from o in clob.CLOB_ObservationInformation
                      where o.ObservationID == ObservID
                      select o;
            if (obs.Count() > 0)
            {
                odVM.AcknowledgeCount = (int)obs.First().AcknowledgeCount;
                odVM.ApplyCount = (int)obs.First().ApplyCount;
                odVM.CorrectCount = (int)obs.First().CorrectCount;
                odVM.DirectionsCount = (int)obs.First().DirectionsCount;
                odVM.ExplainCount = (int)obs.First().ExplainCount;
                odVM.FactsCount = (int)obs.First().FactsCount;
                odVM.ForeshadowCount = (int)obs.First().ForeshadowCount;
                odVM.GiveInfoCount = (int)obs.First().GiveInfoCount;
                odVM.ItineraryCount = (int)obs.First().ItineraryCount;
                odVM.MetaCount = (int)obs.First().MetaCount;
                odVM.NewAndOldCount = (int)obs.First().NewAndOldCount;
                odVM.Notes = obs.First().Notes;
                odVM.PraiseCount = (int)obs.First().PraiseCount;
                odVM.ProceduralCount = (int)obs.First().ProceduralCount;
                odVM.ReflectCount = (int)obs.First().ReflectCount;
                odVM.RephraseCount = (int)obs.First().RephraseCount;
                odVM.SituateCount = (int)obs.First().SituateCount;
                odVM.SolicitCount = (int)obs.First().SolicitCount;
                odVM.SuggestCount = (int)obs.First().SuggestCount;
                odVM.SummarizeCount = (int)obs.First().SummarizeCount;
                odVM.ThinkAloudCount = (int)obs.First().ThinkAloudCount;
                odVM.ObservationInformationID = (int)obs.First().ObservationInformationID;
                odVM.StudentDisengagementCode = obs.First().StudentDisengagementCode;
                odVM.ClassOrganizationCode = obs.First().ClassOrganizationCode;
                odVM.ClassActivityCode = obs.First().ClassActivityCode;
            }

            odVM.BuildCodeLists();

            return odVM;
        }



        public void UpdateObservationInformation(ObservationInformationVM oiVM)
        {
            int ObservID = 0;

            if (HttpContext.Current.Session["ObservationID"] != null)
            {
                ObservID = (int)HttpContext.Current.Session["ObservationID"];
            }

            
            CLOBEntities clob = new CLOBEntities();

            if (oiVM.ObservationInformationID == 0)
            {
                CLOB_ObservationInformation oi = new CLOB_ObservationInformation
                {
                    ObservationID = ObservID,
                    UserID = HttpContext.Current.Session["UserID"].ToString(),
                    AcknowledgeCount = oiVM.AcknowledgeCount,
                    ApplyCount = oiVM.ApplyCount,
                    ClassActivityCode = oiVM.ClassActivityCode,
                    ClassOrganizationCode = oiVM.ClassOrganizationCode,
                    CorrectCount = oiVM.CorrectCount,
                    DateAdded = DateTime.Now,
                    DirectionsCount = oiVM.DirectionsCount,
                    ExplainCount = oiVM.ExplainCount,
                    FactsCount = oiVM.FactsCount,
                    ForeshadowCount = oiVM.ForeshadowCount,
                    GiveInfoCount = oiVM.GiveInfoCount,
                    ItineraryCount = oiVM.ItineraryCount,
                    MetaCount = oiVM.MetaCount,
                    NewAndOldCount = oiVM.NewAndOldCount,
                    Notes = oiVM.Notes,
                    PraiseCount = oiVM.PraiseCount,
                    ProceduralCount = oiVM.ProceduralCount,
                    ReflectCount = oiVM.ReflectCount,
                    RephraseCount = oiVM.RephraseCount,
                    SituateCount = oiVM.SituateCount,
                    SolicitCount = oiVM.SolicitCount,
                    StudentDisengagementCode = oiVM.StudentDisengagementCode,
                    SuggestCount = oiVM.SuggestCount,
                    SummarizeCount = oiVM.SummarizeCount,
                    ThinkAloudCount = oiVM.ThinkAloudCount
                };

                clob.CLOB_ObservationInformation.Add(oi);
                clob.SaveChanges();
            }
            else
            {
                var result = clob.CLOB_ObservationInformation.Where(ob => ob.ObservationInformationID == oiVM.ObservationInformationID).FirstOrDefault();

                 result.AcknowledgeCount = oiVM.AcknowledgeCount;
                 result.ApplyCount = oiVM.ApplyCount;
                 result.ClassActivityCode = oiVM.ClassActivityCode;
                 result.ClassOrganizationCode = oiVM.ClassOrganizationCode;
                 result.CorrectCount = oiVM.CorrectCount;
                 result.DateAdded = DateTime.Now;
                 result.DirectionsCount = oiVM.DirectionsCount;
                 result.ExplainCount = oiVM.ExplainCount;
                 result.FactsCount = oiVM.FactsCount;
                 result.ForeshadowCount = oiVM.ForeshadowCount;
                 result.GiveInfoCount = oiVM.GiveInfoCount;
                 result.ItineraryCount = oiVM.ItineraryCount;
                 result.MetaCount = oiVM.MetaCount;
                 result.NewAndOldCount = oiVM.NewAndOldCount;
                 result.Notes = oiVM.Notes;
                 result.PraiseCount = oiVM.PraiseCount;
                 result.ProceduralCount = oiVM.ProceduralCount;
                 result.ReflectCount = oiVM.ReflectCount;
                 result.RephraseCount = oiVM.RephraseCount;
                 result.SituateCount = oiVM.SituateCount;
                 result.SolicitCount = oiVM.SolicitCount;
                 result.StudentDisengagementCode = oiVM.StudentDisengagementCode;
                 result.SuggestCount = oiVM.SuggestCount;
                 result.SummarizeCount = oiVM.SummarizeCount;
                 result.ThinkAloudCount = oiVM.ThinkAloudCount;

                 clob.SaveChanges();

            }
        }



       // Post Observation Questions

        public List<PostObservationVM> BuildPostObservationVM(string POType)
        {
            int ObservID = 0;

            if (HttpContext.Current.Session["ObservationID"] != null)
            {
                ObservID = (int)HttpContext.Current.Session["ObservationID"];
            }
            
            List<PostObservationVM> lPostObservations = new List<PostObservationVM>();

            CLOBEntities clob = new CLOBEntities();

            var po = from q in clob.CLOB_PostObservationQuestions
                     where q.POQType == POType
                      join a in clob.CLOB_ObservationsAnswers 
                      on q.POQID equals a.POQID into AnswerGroup
                      select new 
                      { 
                          q.POQID, 
                          q.SubSection, 
                          q.QuestionText, 
                          q.QuestionType,
                          Answer = (from a in AnswerGroup 
                                   where a.ObservationID == ObservID 
                                   select a.Answer).FirstOrDefault()
                      };


            //var po = from a in clob.CLOB_ObservationsAnswers
            //          where a.ObservationID == ObservID 
            //          join q in clob.CLOB_PostObservationQuestions
            //          on a.POQID equals q.POQID
            //          select new { q.POQID, q.SubSection, q.QuestionText, q.QuestionType, a.Answer  };

            foreach (var q in po)
            {
                lPostObservations.Add(new PostObservationVM { POQID = q.POQID, QuestionText = q.QuestionText, SubSection = q.SubSection, QuestionType = q.QuestionType, Answer = q.Answer });
            }

            return lPostObservations;

        }

        public void UpdatePostObservation(FormCollection collection)
        {
            int ObservID = 0;
            string sPOQType = collection["POQType"].ToString();

            if (HttpContext.Current.Session["ObservationID"] != null)
            {
                ObservID = (int)HttpContext.Current.Session["ObservationID"];
            }
            
            CLOBEntities clob = new CLOBEntities();

            // rather than update eeach row record, delete and rewrite

            var del = from c in clob.CLOB_ObservationsAnswers
                      where c.ObservationID == ObservID && c.POQType == sPOQType 
                      select c;
            foreach (var a in del)
            {
                clob.CLOB_ObservationsAnswers.Remove(a);
            }
            
            clob.SaveChanges();


            foreach (var key in collection.AllKeys)
            {
                if (key.StartsWith("a"))
                {
                    int iID = Convert.ToInt32(key.Replace("a", ""));

                    CLOB_ObservationsAnswers oa = new CLOB_ObservationsAnswers();
                    if (collection[key] == "true,false")
                    {
                        oa.Answer = "true";
                    }
                    else
                    {
                        oa.Answer = collection[key].ToString();
                    }

                    oa.POQID = iID;
                    oa.POQType = sPOQType;
                    oa.ObservationID = ObservID;

                    clob.CLOB_ObservationsAnswers.Add(oa);
                    clob.SaveChanges();

                }

            }
        }
    }
}