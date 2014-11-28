using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CLOB.ViewModels;
using CLOB.Models;
using CLOB.BusinessLogic;
namespace CLOB.Controllers
{
    public class ObservationController : Controller
    {
        //
        // GET: /Observation/

       

        public ActionResult NewObservation()
        {
            //create new class id/observation ID

            Session.Remove("ObservationID");

            Session["NewObservation"] = true;

            return RedirectToAction("BackgroundInformation"); 
        }


        public ActionResult Index()
        {
            return View();
        }




        public ActionResult BackgroundInformation(int ID = 0)
        {
            ObservationBL obBL = new ObservationBL();

            return View(obBL.GetBackgrounfInformation(ID));
        }



        [HttpPost()]
        public ActionResult BackgroundInformation(BackgroundInformationVM biVM)
        {

            ObservationBL obBL = new ObservationBL();
            obBL.UpdateBackgroundInformation(biVM);

            return View(obBL.GetBackgrounfInformation());
        }

       

        public ActionResult ObservationDetail()
        {

            ObservationBL obBL = new ObservationBL();

            return View(obBL.GetObservationInformation());
        }

        [HttpPost()]
        public ActionResult ObservationDetail(ObservationInformationVM odVM)
        {
            ObservationBL obBL = new ObservationBL();

            obBL.UpdateObservationInformation(odVM);

            return View(obBL.GetObservationInformation());
        }

        public ActionResult StudentDirected()
        {
            ObservationBL oBL = new ObservationBL();

            ViewBag.POQType = "Student";

            return View(oBL.BuildPostObservationVM("Student"));
        }

        [HttpPost()]
        public ActionResult StudentDirected(FormCollection collection)
        {

            ObservationBL oBL = new ObservationBL();

            oBL.UpdatePostObservation(collection);

            ViewBag.POQType = "Student";

            return View(oBL.BuildPostObservationVM("Student"));
        }


        public ActionResult TeacherDirected()
        {
            ObservationBL oBL = new ObservationBL();

            ViewBag.POQType = "Teacher";

            return View(oBL.BuildPostObservationVM("Teacher"));
        }


        [HttpPost()]
        public ActionResult TeacherDirected(FormCollection collection)
        {
            ObservationBL oBL = new ObservationBL();

            oBL.UpdatePostObservation(collection);

            ViewBag.POQType = "Teacher";

            return View(oBL.BuildPostObservationVM("Teacher"));
        }

        public ActionResult ScienceContent()
        {
            ObservationBL oBL = new ObservationBL();

            ViewBag.POQType = "Science";

            return View(oBL.BuildPostObservationVM("Science"));
        }


        [HttpPost()]
        public ActionResult ScienceContent(FormCollection collection)
        {
            ObservationBL oBL = new ObservationBL();

            oBL.UpdatePostObservation(collection);

            ViewBag.POQType = "Science";

            return View(oBL.BuildPostObservationVM("Science"));

        }
        
         

        public ActionResult LeadershipPractices()
        {
            ObservationBL oBL = new ObservationBL();

            ViewBag.POQType = "Leadership";

            return View(oBL.BuildPostObservationVM("Leadership"));
        }


        [HttpPost()]
        public ActionResult LeadershipPractices(FormCollection collection)
        {
            ObservationBL oBL = new ObservationBL();

            oBL.UpdatePostObservation(collection);

            ViewBag.POQType = "Leadership";

            return View(oBL.BuildPostObservationVM("Leadership"));

        }
    }
}
