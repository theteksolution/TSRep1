using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CLOB.ViewModels;
using CLOB.Models;

namespace CLOB.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(int ID = 0)
        {

            List<UserObservationVM> lUserOb = new List<UserObservationVM>();

            CLOBEntities clob = new CLOBEntities();

            string sID = ID.ToString();

            if (Session["UserID"] != null)
            {
                sID = Session["UserID"].ToString();
            }

            var obs = from o in clob.CLOB_ObservationBackground
                      where o.UserID == sID
                      select new UserObservationVM { ObservationID = o.ObservationID, ObservationDate = o.ObservationDate };


            foreach (UserObservationVM u in obs)
            {
                lUserOb.Add(u);
            }

            return View(lUserOb);
            
       
        }


        [HttpPost()]
        public ActionResult Login(FormCollection collection)
        {
            Session["UserID"] = 1;

            return RedirectToAction("Index", new { ID = Session["UserID"] });
        }

        //[AcceptVerbs(HttpVerbs.Get)]  
        //public JsonResult Login(string Username, string Password)
        //{
        //    return Json(new { Validated = "OK" } , JsonRequestBehavior.AllowGet);
        //}

    }
}
