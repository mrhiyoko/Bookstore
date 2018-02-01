using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.Controllers
{
    [Authorize]
    public class ReviewsController : BaseController
    {
        // GET: Reviews
        public ActionResult Index([Bind(Prefix="Id")]int bookId)
        {
            var book = _db.Books.Find(bookId);

            if (book != null)
            {
                return View(book);
            }
            return HttpNotFound();
        }

        public ActionResult Create(int bookId)
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Review model)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(model);
                _db.SaveChanges();

                return RedirectToAction("Index", new { id = model.BookId });
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.Find(id);

            if(review !=null)
            {
                return View(review);
            }
            return RedirectToAction("Index", "Books");
        }

        [HttpPost]
        public ActionResult Edit([Bind(Exclude="Name")]Review model)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index", new { id = model.BookId });
            }
            return View(model);
        }
        
    }
}