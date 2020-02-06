using MyGSAwardTracker.Models.Idea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGSAwardTracker.WebMVC.Controllers
{
    [Authorize]
    public class IdeaController : Controller
    {       
        public ActionResult Index()
        {
            var model = new IdeaListItem[0];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}