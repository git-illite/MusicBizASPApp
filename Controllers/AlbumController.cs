using F2022A6AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Controllers
{
    public class AlbumController : Controller
    {
        public Manager m = new Manager();
        // GET: Album
        [Authorize(Roles = "Executive, Coordinator, Clerk, Staff")]
        public ActionResult Index()
        {
            var albums = m.AlbumGetAll();
            return View(albums);
        }

        // GET: Album/Details/5
        [Authorize(Roles = "Executive, Coordinator, Clerk, Staff")]
        public ActionResult Details(int? id)
        {
            if (!id.HasValue) return HttpNotFound();

            var album = m.AlbumGetById(id.GetValueOrDefault());

            if (album == null) return HttpNotFound();

            return View(album);


        }

        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        public ActionResult AddTrack(int? id)
        {
            AlbumWithDetailViewModels album = m.AlbumGetById(id ?? 0);

            if (album == null)
                return HttpNotFound();

            var track = new TrackAddViewModels();
            track.AlbumName = album.Name;
            track.AlbumId = album.Id;
            track.TrackGenreList = new SelectList(m.GenreGetAll(), "Name", "Name");

            return View(track);
        }

        // POST: Album/{id}/AddTrack
        [HttpPost]
        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        [ValidateInput(false)]
        public ActionResult AddTrack(TrackAddViewModels newTrack)
        {
            if (!ModelState.IsValid)
                return View(newTrack);
            try
            {
                var addedTrack = m.TrackAdd(newTrack);
                if (addedTrack == null)
                    return View(newTrack);
                else
                    return RedirectToAction("Details", "Track", new { id = addedTrack.Id });
            }
            catch
            {
                return View(newTrack);
            }
        }
            // GET: Album/Edit/5
            public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
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

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
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
