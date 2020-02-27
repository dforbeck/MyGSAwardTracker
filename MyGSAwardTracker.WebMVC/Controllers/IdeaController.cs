using Microsoft.AspNet.Identity;
using MyGSAwardTracker.Models.Idea;
using MyGSAwardTracker.Services;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IdeaService(userId);
            var model = service.GetIdeas();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IdeaCreate model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateIdeaService();

            if (service.CreateIdea(model))
            {
                TempData["SaveResult"] = "Your Idea was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Idea could not be created.");

            return View(model);           
        }

        public ActionResult Details(int id)
        {
            var svc = CreateIdeaService();
            var model = svc.GetIdeaById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateIdeaService();
            var detail = service.GetIdeaById(id);
            var model =
                new IdeaEdit
                {
                    IdeaId = detail.IdeaId,
                    IdeaTitle = detail.IdeaTitle,
                    IdeaDescription = detail.IdeaDescription
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IdeaEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.IdeaId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateIdeaService();

            if (service.UpdateIdea(model))
            {
                TempData["SaveResult"] = "Your Idea was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Idea could not be updated.")

            return View();
        }



        private IdeaService CreateIdeaService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IdeaService(userId);
            return service;
        }
    }
}