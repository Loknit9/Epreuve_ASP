﻿using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared_epreuve.Repositories;
using ASP_Epreuve.Handlers;
using Microsoft.AspNetCore.Http;


namespace ASP_Epreuve.Controllers
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
                IEnumerable<MediaListViewModel> model = _mediaRepository.Get().Select(d => d.ToListItem());
                return View(model);
            }

            // GET: MediaController/Details/5
            public ActionResult Details(int id)
            {
                MediaDetailsViewModel model = _mediaRepository.Get(id).ToDetails();
                return View(model);
            }

            // GET: MediaController/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: MediaController/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Create(MediaCreateForm form)
            {
                try
                {
                    if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                    if (!ModelState.IsValid) throw new Exception();
                    int id = _mediaRepository.Insert(form.ToBLL());
                    await form.ImageUrl.SaveFile();
                    return RedirectToAction("Index", "Produit");
                }
                catch
                {
                    return View(form);
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
