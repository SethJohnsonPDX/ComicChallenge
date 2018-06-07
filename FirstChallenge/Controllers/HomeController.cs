using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comicBooks = FirstChallenge.Models.ComicBookManager.GetComicBooks();
            return View(comicBooks);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var comicBooks = FirstChallenge.Models.ComicBookManager.GetComicBooks();
            var comic = comicBooks.FirstOrDefault(p => p.ComicBookId == id);
            return View(comic);
        }
    }
}