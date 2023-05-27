using F2022A6AA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class TrackBaseViewModels
	{
        public TrackBaseViewModels()
        {
            Albums = new List<Album>();
        }

        [Required]
        public int Id { get; set; }

        [StringLength(40)]
        [Display(Name = "Clerk who helps with album tasks")]
        public string Clerk { get; set; }

        [Display(Name = "Composer name (comma-separated)")]
        public string Composers { get; set; } 

        [StringLength(30)]
        [Display(Name = "Track genre")]
        public string Genre { get; set; } 

        [Required, StringLength(60), Display(Name = "Track name")]
        public string Name { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        

    }
}