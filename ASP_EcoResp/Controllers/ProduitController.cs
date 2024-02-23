using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using BLL_EcoResp.Entities;
using ASP_EcoResp.Models;
using ASP_EcoResp.Handlers;
using System.Net.Http.Headers;
using System.Reflection;

namespace ASP_EcoResp.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;

        public ProduitController(IProduitRepository<Produit> produitRepository)
        {
            _produitRepository = produitRepository;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            ProduitDetailsViewModel model;
            try
            {
                model = _produitRepository.Get(id).ToDetails();

            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide...";
                return RedirectToAction(nameof(Index));
                
            }
            return View(model);
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProduitCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Aucun formulaire retourné...");
                if (!ModelState.IsValid) throw new Exception();
                int produit_id = _produitRepository.Insert(form.ToBLL());
                TempData["SuccessMessage"] = "Enregistrement effectué avec succès!";
                return RedirectToAction(nameof(Details), new { id = produit_id });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                ProduitEditForm model = _produitRepository.Get(id).ToEditForm();
                if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de produit avec l'identifiant {id}");
                return View(model);
            }
            catch
            { 
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide...";
                return RedirectToAction(nameof(Index));

            }

        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProduitEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                _produitRepository.Update(form.ToBLL());
                TempData["SuccessMessage"] = $"L'enregistrement {id} a été mis à jour.";
                return RedirectToAction(nameof(Details), new { id });
                
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        
        {
            try
            {
                ProduitDeleteForm model = _produitRepository.Get(id).ToDelete();
                if(model is null) throw new InvalidDataException();
                return View(model);
            }
            catch
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide...";
                return RedirectToAction(nameof(Index));
            }
            
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProduitDeleteForm form)
        {
            try
            {
                _produitRepository.Delete(id);
                TempData["SuccessMessage"] = $"L'enrgistrement {id} a été supprimé";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(form);
            }
        }

        public ActionResult Search(SearchHomeForm form)
        {
            try
            {

                IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetBySearchBar(form.Search).Select(d => d.ToListItem());
                return View(model);
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }

        public ActionResult FiltreEcoScore(string? search)
        {
            try
            {

                IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetBySearchBar(search).Select(d => d.ToListItem());
                return View(model);
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }

    }
}
