using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSRN.Controllers
{
    public class RPController : Controller
    {
        // GET: RP
        public ActionResult News()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }

        public ActionResult Discussion()
        {
            return View();
        }
    }
}