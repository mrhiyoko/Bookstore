using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext _db = new ApplicationDbContext();

        protected override void Dispose (bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}