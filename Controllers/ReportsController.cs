using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CLOB.Models;
using CLOB.ViewModels;
using System.Reflection;
using System.Linq.Dynamic;
namespace CLOB.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/

        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult Chart1()
        {
            
           CLOBEntities clob = new CLOBEntities();

          
           var z = (from c in clob.GetObservationInfoCounts()
                  select new 
                          {
                              c.AcknowledgeCount,
                              c.ApplyCount,
                              c.CorrectCount,
                              c.DirectionsCount,
                              c.ExplainCount,
                              c.FactsCount,
                              c.ForeshadowCount,
                              c.GiveInfoCount,
                              c.ItineraryCount,
                              c.MetaCount,
                              c.NewAndOldCount,
                              c.PraiseCount,
                              c.ProceduralCount,
                              c.ReflectCount,
                              c.RephraseCount,
                              c.SituateCount,
                              c.SolicitCount,
                              c.SuggestCount,
                              c.SummarizeCount,
                              c.ThinkAloudCount
                          }).FirstOrDefault();

           if (z != null)
           {
               List<HCFormat> hcf = new List<HCFormat>();

               HCFormatInt hcfi = new HCFormatInt();
               hcfi.name = "Counts";
               hcfi.data = new List<int>();

               hcfi.data.Add((int)z.AcknowledgeCount);
               hcfi.data.Add((int)z.ApplyCount);
               hcfi.data.Add((int)z.CorrectCount);
               hcfi.data.Add((int)z.DirectionsCount);
               hcfi.data.Add((int)z.ExplainCount);
               hcfi.data.Add((int)z.FactsCount);
               hcfi.data.Add((int)z.ForeshadowCount);
               hcfi.data.Add((int)z.GiveInfoCount);
               hcfi.data.Add((int)z.ItineraryCount);
               hcfi.data.Add((int)z.MetaCount);
               hcfi.data.Add((int)z.NewAndOldCount);
               hcfi.data.Add((int)z.PraiseCount);
               hcfi.data.Add((int)z.ProceduralCount);
               hcfi.data.Add((int)z.ReflectCount);
               hcfi.data.Add((int)z.RephraseCount);
               hcfi.data.Add((int)z.SituateCount);
               hcfi.data.Add((int)z.SolicitCount);
               hcfi.data.Add((int)z.SuggestCount);
               hcfi.data.Add((int)z.SummarizeCount);
               hcfi.data.Add((int)z.ThinkAloudCount);

               hcf.Add(hcfi);
               HCFormatString hcfs = new HCFormatString();
               hcfs.name = "CountNames";
               hcfs.data = new List<string>();

               hcfs.data.Add("Acknowledge");
               hcfs.data.Add("Apply");
               hcfs.data.Add("Correct");
               hcfs.data.Add("Directions");
               hcfs.data.Add("Explain");
               hcfs.data.Add("Facts");
               hcfs.data.Add("Foreshadow");
               hcfs.data.Add("GiveInfo");
               hcfs.data.Add("Itinerary");
               hcfs.data.Add("Meta");
               hcfs.data.Add("NewAndOld");
               hcfs.data.Add("Praise");
               hcfs.data.Add("Procedural");
               hcfs.data.Add("Reflect");
               hcfs.data.Add("Rephrase");
               hcfs.data.Add("Situate");
               hcfs.data.Add("Solicit");
               hcfs.data.Add("Suggest");
               hcfs.data.Add("Summarize");
               hcfs.data.Add("ThinkAloud");
               hcf.Add(hcfs);




               //List<int> lCoords = new List<int>() { 2,4,5,6,8};
               return Json(hcf, JsonRequestBehavior.AllowGet);

           }
           else
           {
               List<HCFormat> hcf = new List<HCFormat>();

               HCFormatInt hcfi = new HCFormatInt();
               hcfi.name = "Counts";
               hcfi.data = new List<int>();

               hcfi.data.Add(3);
              

               hcf.Add(hcfi);
               HCFormatString hcfs = new HCFormatString();
               hcfs.name = "CountNames";
               hcfs.data = new List<string>();

               hcfs.data.Add("None");
              
               hcf.Add(hcfs);

               //List<int> lCoords = new List<int>() { 2,4,5,6,8};
               return Json(hcf, JsonRequestBehavior.AllowGet);

           }

        }

    }
}
