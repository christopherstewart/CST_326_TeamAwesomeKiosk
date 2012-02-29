using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwesomeKiosk.Controllers
{
    public class ApplicantController : Controller
    {
        //
        // GET: /Applicant/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JobSelect()
        {
            return View();
        }
        public ActionResult PersonalInfo()
        {
            return View();
        }
        public ActionResult Questions()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
    }
}
