using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Controllers
{
    public class AudioController : Controller
    {
        // GET: Audio
        Manager m = new Manager();
        public ActionResult Index()
        {
            return View("Index","Home");
        }

        // GET: Audio/Details/5
        [Route("audio/{id}")]
        public ActionResult Details(int? id)
        {
            var track = m.TrackAudioGetById(id.GetValueOrDefault());

            if (track == null)
                return HttpNotFound();
            if(track.MediaContentType == null)
                return RedirectToAction("Details", new { id = track.Id });

            return File(track.Media, track.MediaContentType);
           
        }

        // GET: Audio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Audio/Create
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

        // GET: Audio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Audio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Audio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Audio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
