using ADDCART.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADDCART.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            DemoDBEntities db = new DemoDBEntities();
            var data = db.Products.ToList();

            return View(data);
        }

        public ActionResult AddCart(int productId)
        {
            DemoDBEntities db = new DemoDBEntities();
            var cart = new List<Product>();
            var product = db.Products.Find(productId);
            cart.Add(product);
            Session["cart"] = cart;
            return View();
        }
    }
}