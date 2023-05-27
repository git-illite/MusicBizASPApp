using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class AlbumBaseViewModels
	{
        [Required]
        public int Id { get; set; }

        [Display(Name = "Coordinator Who Looks after the album")]
        public string Coordinator { get; set; }

        [StringLength(30)]
        [Display(Name = "Album's primary genre")]
        public string Genre { get; set; }

        [StringLength(40)]
        [Display(Name = "Album Name")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Album cover art")]
        public string UrlAlbum { get; set; }

    }
}