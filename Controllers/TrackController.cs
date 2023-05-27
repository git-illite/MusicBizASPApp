using F2022A6AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Controllers
{
    public class TrackController : Controller
    {
        public Manager m = new Manager();
        // GET: Track
        public ActionResult Index()
        {
            var tracks = m.TrackGetAll();

            return View(tracks);
        }

        // GET: Track/Details/5
        public ActionResult Details(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());

            if (track == null) return HttpNotFound();

            return View(track);
        }

        // GET: Track/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Track/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tracks/Edit/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());

            if (track == null)
                return HttpNotFound();
          
                var form = m.mapper.Map<TrackWithDetailViewModels, TrackEditViewModels>(track);
                return View(form);
           
        }

        // POST: Tracks/Edit/5
        [Authorize(Roles = "Clerk")]
        [HttpPost]
        public ActionResult Edit(int? id, TrackEditViewModels editTrack)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Edit", new { id = editTrack.Id });
         
            try
            {
                if (id.GetValueOrDefault() != editTrack.Id)
                    return RedirectToAction("Index");

                var editedTrack = m.TrackEdit(editTrack);

                if (editedTrack == null)
                    return RedirectToAction("Edit", new { id = editTrack.Id });
               
                    return RedirectToAction("Details", new { id = editTrack.Id });
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Delete/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id)
        {
            var deletedTrack = m.TrackGetById(id.GetValueOrDefault());

            if (deletedTrack == null)  return RedirectToAction("Index");
           
             return View(deletedTrack);           

        }

        // POST: Track/Delete/5
        [HttpPost]
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                m.TrackDelete(id.GetValueOrDefault());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
