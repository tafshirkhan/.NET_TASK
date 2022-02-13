using NewsTask.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsTask.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            BookDBEntities db = new BookDBEntities();
            var data = db.Books.ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book b)
        {
            if (ModelState.IsValid)
            {
                BookDBEntities db = new BookDBEntities();
                db.Books.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(b);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            BookDBEntities db = new BookDBEntities();
            var newsId = (from n in db.Books where n.Id == id select n).FirstOrDefault();
            return View(newsId);
        }

        [HttpPost]
        public ActionResult Edit(Book b)
        {
            BookDBEntities db = new BookDBEntities();
            var news = (from n in db.Books where n.Id == b.Id select n).FirstOrDefault();
            db.Entry(news).CurrentValues.SetValues(b);
            db.SaveChanges();
            return RedirectToAction("Index");
            //return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            BookDBEntities db = new BookDBEntities();
            var newsId = (from n in db.Books where n.Id == id select n).FirstOrDefault();
            db.Books.Remove(newsId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index(string searching)
        {
            BookDBEntities db = new BookDBEntities();
            var data = db.Books.Where(x => x.Categorry.Contains(searching) || searching == null).ToList();
            return View(data);

        }
    }
}