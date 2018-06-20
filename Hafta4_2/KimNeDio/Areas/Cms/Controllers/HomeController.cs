using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimNeDio.Areas.Cms.Controllers
{
    public class HomeController : Controller
    {
        // GET: Cms/Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult NotificationPartial()
        {
            return PartialView();
        }

        public PartialViewResult AuthorMessagePartial()
        {
            return PartialView();
        }

        public ActionResult AuthorListPartial()
        {
            return PartialView();
        }

        public ActionResult LatestPostsPartial()
        {
            return PartialView();
        }

        public PartialViewResult LatestCommentsPartial()
        {
            return PartialView();
        }
    }
}