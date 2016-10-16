using MVC5Course.Models;
using MVC5Course.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ClientContribution2Controller : Controller
    {
        private FabricsEntities db = new FabricsEntities();
        // GET: ClientContribution2
        public ActionResult Index()
        {

            var vw_cc = db.vw_ClientContribution.Take(10);

            return View(vw_cc);
        }

        //use Sql Query Command to get Data
        public ActionResult ClientContribution2(string keyword="mary")
        {
            var data = db.Database.SqlQuery<ClientContributionModel>(@"　
	        SELECT
                c.ClientId,
                c.FirstName,
                c.LastName,
                    (SELECT SUM(o.OrderTotal)
                     FROM[dbo].[Order] o
                    WHERE o.ClientId = c.ClientId) as OrderTotal
            FROM
            [dbo].[Client] as c where c.FirstName Like @p0", keyword
         );
            return View(data);
        }

        // use Sql StoreProcedure
        public ActionResult ClientContribution3(string keyword)
        {
            return View(db.usp_GetClientContribution(keyword));
        }
    }
}