using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class MediaItemAddViewModels
	{
        public MediaItemAddViewModels()
        {
            Timestamp = DateTime.Now;

            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            StringId = string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        [Required]
        public string StringId { get; set; }
        [Required, Display(Name = "Descriptive caption")]

        public int ArtistId { get; set; }

        public string ArtistName { get; set; }
        [Required, Display(Name = "Description")]
        public string Caption { get; set; }

        public DateTime Timestamp { get; set; }

        public string ContentType { get; set; }

        [Required]
        public HttpPostedFileBase MediaUpload { get; set; }
    }
}