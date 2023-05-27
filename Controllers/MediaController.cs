using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Controllers
{
    public class MediaController : Controller
    {
        Manager m = new Manager();

        // GET: Media
        public ActionResult Index()
        {
            return RedirectToAction("index", "home");
        }

        [Route("media/{stringId}")]
        public ActionResult Details(string stringId = "")
        {
            var media = m.MediaGetById(stringId);

            if (media == null)
                return HttpNotFound();

            if (media.ContentType != null)
                    return File(media.Content, media.ContentType);

               
            return Content("No media");
            
        }

        [Route("media/{stringId}/download")]
        public ActionResult DetailsDownload(string stringId = "")
        {
            var o = m.MediaGetById(stringId);

            if (o == null)
                return HttpNotFound();
           
                RegistryKey key;
                object value;
                string extension;

                //This code only works on local machine. As this code is given code, I will follow professor codes although it is not working on the Azure.
                key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + o.ContentType, false);
                value = (key == null) ? null : key.GetValue("Extension", null);
                extension = (value == null) ? string.Empty : value.ToString();

                //Following code is works both in Azure and local
                //extension = MimeTypeMap.GetExtension(o.ContentType);

                var contentDisposition = new System.Net.Mime.ContentDisposition
                {
                    FileName = $"media-{stringId}{extension}",
                    Inline = false
                };

                Response.AppendHeader("Content-Disposition", contentDisposition.ToString());
                return File(o.Content, o.ContentType);
            
        }
    }
}