using ASP_Epreuve.Handlers;
using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_epreuve.Repositories;
using System.Reflection;

namespace ASP_Epreuve.Controllers
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

        public ActionResult FiltreNomProduit(string searchNom)
        {
            if (!string.IsNullOrEmpty(searchNom))
            {
                IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetByName(searchNom).Select(d => d.ToListItem());
                return View(model);
            }
            else
            {
                // Si pas de recherche afficher toute la liste des produits
                IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
                return View(model);
            }
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            ProduitDetailViewModel model = _produitRepository.Get(id).ToDetails();
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
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id  = _produitRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
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
                ProduitEditForm model = _produitRepository.Get(id).Update();
                if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de produit avec l'identifiant {id}");
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProduitEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                form.Id_Produit = id;
                _produitRepository.Update(form.ToBLL());
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
                ProduitDeleteViewModel model = _produitRepository.Get(id).Delete();
                if (model is null) throw new InvalidDataException();
                return View(model);
            }

            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide.";
                return RedirectToAction(nameof(Index));
            }
           
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProduitDeleteViewModel model)
        {
            try
            {
                _produitRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
