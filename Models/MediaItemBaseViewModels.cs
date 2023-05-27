using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class MediaItemBaseViewModels
	{
        public MediaItemBaseViewModels()
        {
            Timestamp = DateTime.Now;

            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            StringId = string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        public int MediaId { get; set; }

        [Required]
        public string StringId { get; set; }

        [Required]
        public string Caption { get; set; }
        public DateTime Timestamp { get; set; }

        public string ContentType { get; set; }
    }
}