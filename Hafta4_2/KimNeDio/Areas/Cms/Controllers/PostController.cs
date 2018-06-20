using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimNeDio.Areas.Cms.Controllers
{
    public class PostController : Controller
    {
        // GET: Cms/Post
        public ActionResult Create()
        {
            return View();
        }
    }
}