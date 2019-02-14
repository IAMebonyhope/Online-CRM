using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IWOnlineCRM.Controllers
{
    public class TicketController : Controller
    {

        public ActionResult New()
        {
            return View();
        }

        public ActionResult All()
        {
            return View();
        }

        public ActionResult AssignedTo()
        {
            return View();
        }

        public ActionResult CreatedBy()
        {
            return View(); 
        }

        public ActionResult Edit(string TicketID)
        {
            return View();
        }
    }
}