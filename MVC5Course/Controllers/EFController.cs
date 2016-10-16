using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;


namespace MVC5Course.Controllers
{
    public class EFController : Controller
    {
        FabricsEntities db = new FabricsEntities();
        // GET: EF
        public ActionResult Index()
        {
            var data = db.Product.Where(
                p => p.ProductName.Contains("White")
                ).Take(10);
            return View(data);
        }

        public ActionResult Create()
        {
            var product = new Product() {
                ProductName = "White Cat",
                Price = 199,
                Active = true,
                Stock = 1999
            };

            db.Product.Add(product);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {
            var product = db.Product.Find(id);
            return View(product);
        }
        public ActionResult Details(int id)
        {
            var product = db.Product.Find(id);
            return View(product);
        }
        
        public ActionResult Delete(int id)
        {
            // Single item delete and it could meet the Exception when the data has relation with other table.
            //var product = db.Product.Find(id);
            //db.Product.Remove(product);
            //db.SaveChanges();
            var pentity = db.Product.Find(id);
            db.OrderLine.RemoveRange(pentity.OrderLine);
            db.Product.Remove(pentity);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Update(int id)
        {
            var data = db.Product.Find(id);
            data.ProductName += "!";
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Add20Percent()
        {
            var data = db.Product;

            foreach (var item in data) {
                if (item.Price.HasValue) {
                    item.Price = item.Price.Value * 1.2m;
                }
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Discount20Percent()
        {
            var data = db.Product;

            foreach (var item in data)
            {
                if (item.Price.HasValue)
                {
                    item.Price = item.Price.Value * 0.8m;
                }
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}