using F2022A6AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        Manager m = new Manager();
        [Authorize(Roles = "Executive, Coordinator, Clerk, Staff")]
        public ActionResult Index()
        {
            var objects = m.ArtistGetAll();
            return View(objects);
        }

        // GET: Artist/Details/5
        public ActionResult Details(int? id)
        {
            if (!id.HasValue) return HttpNotFound();

            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if (artist == null) return HttpNotFound();

            return View(artist);
        }

        [Authorize(Roles = "Executive")]
        public ActionResult Create()
        {
            var artist = new ArtistAddViewModels();

            artist.Executive = User.Identity.Name;
            artist.ArtistGenreList = new SelectList(m.GenreGetAll(), "Name", "Name");

            return View(artist);
        }

        // POST: Artist/Create
        [Authorize(Roles = "Executive")]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(ArtistAddViewModels newItem)
        {
            // Validate the input
            if (!ModelState.IsValid)
            {
                return View(newItem);
            }

            //check for script tag for real world project

            // Process the input
            var addedItem = m.ArtistAdd(newItem);

            if (addedItem == null)
                return View(newItem);

          
                return RedirectToAction("Details", new { id = addedItem.Id });
           
        }

        [Authorize(Roles = "Coordinator"), Route("artists/{id}/addalbum")]
        public ActionResult AddAlbum(int? id)
        {
            if (!id.HasValue) return HttpNotFound();

            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if (artist == null) return HttpNotFound();

            var albumAdd = new AlbumAddViewModels();
            //albumAdd.Id = artist.Id;
            albumAdd.ArtistName = artist.Name;
            albumAdd.AlbumGenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
            
            return View(albumAdd);

        }

        [Authorize(Roles = "Coordinator"), Route("artists/{id}/addalbum")]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddAlbum(AlbumAddViewModels newAlbum)
        {
            try
            {
                // TODO: Add insert logic here

                if (!ModelState.IsValid)
                    return View(newAlbum);

                var addedAlbum = m.AlbumAdd(newAlbum);

                if (addedAlbum == null)
                    return View(newAlbum);


                    return RedirectToAction("Details", "Album", new { id = addedAlbum.Id });             

            }
            catch
            {
                return View(newAlbum);
            }
        }

        [Authorize(Roles = "Executive, Coordinator"), Route("artists/{id}/addmedia")]
        public ActionResult AddMedia(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if (artist == null)
                return HttpNotFound();

                var mediaForm = new MediaItemAddFormViewModels();

                mediaForm.ArtistId = artist.Id;
                mediaForm.ArtistName = artist.Name;

                return View(mediaForm);

        }

        [HttpPost]
        [Authorize(Roles = "Executive, Coordinator"), Route("artists/{id}/addmedia")]
        public ActionResult AddMedia(int? id, MediaItemAddViewModels newMedia)
        {
            try
            {
                if (!ModelState.IsValid && id.GetValueOrDefault() == newMedia.ArtistId)
                    return View(newMedia);

                var artistWithMedia = m.ArtistMediaAdd(newMedia);

                if (artistWithMedia == null)
                    return View(newMedia);


                    return RedirectToAction("details", "artist", new { id = artistWithMedia.Id });
               

            }
            catch
            {
                return View();
            }

        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Artist/Edit/5
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

        // GET: Artist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Artist/Delete/5
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
