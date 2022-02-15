using ADDCART.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
            if(Session["cart"] == null)
            {
                List<Product> cart = new List<Product>();
                var product = db.Products.Find(productId);

                cart.Add(new Product()
                {
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Product> cart = (List<Product>)Session["cart"];
                var product = db.Products.Find(productId);
                cart.Add(new Product()
                {
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price
                });

                //foreach(var pro in cart)
                //{

                //    if (pro.productId == productId)
                //    {
                //        int old = (int)product.Quantity;

                //        cart.Remove(pro);

                //        cart.Add(new Product()
                //        { 

                //            Name = product.Name,
                //            Quantity = old + 1
                //        });
                //        break;

                //    }
                //    else
                //    {
                //        cart.Add(new Product()
                //        {
                //            Name = product.Name,
                //            Quantity = 1
                //        });
                //    }
                //}

                Session["cart"] = cart;

            }

            return Redirect("Index");
        }

       
        public ActionResult CheckOut()
        {

           
            DemoDBEntities db = new DemoDBEntities();
            return View();

        }

    }
}