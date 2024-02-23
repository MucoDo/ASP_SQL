using ASP_EcoResp.Handlers;
using ASP_EcoResp.Models;
using BLL_EcoResp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace ASP_EcoResp.Controllers
{
    public class MediaController : Controller
    {

        private readonly IMediaRepository<Media> _mediaRepository;

        public MediaController(IMediaRepository<Media> mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        // GET: MediaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MediaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MediaCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Aucun formulaire retourné...");
                if (!ModelState.IsValid) throw new Exception();
                int media_id = _mediaRepository.Insert(form.ToBLL());
                TempData["SuccessMessage"] = "Enregistrement effectué avec succès!";
                return RedirectToAction(nameof(Details), new { id = media_id });
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
