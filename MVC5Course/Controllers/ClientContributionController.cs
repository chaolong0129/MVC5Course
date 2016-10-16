using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ClientContributionController : Controller
    {
        private FabricsEntities db = new FabricsEntities();
        // GET: ClientContribution
        public ActionResult Index()
        {
            var vw_cc = db.vw_ClientContribution.Take(10);
            
            return View(vw_cc);
        }
    }
}