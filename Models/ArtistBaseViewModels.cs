using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class ArtistBaseViewModels
	{
        [Required]
        public int Id { get; set; }


        [StringLength(40), Display(Name = "Artist name or stage name"), Required]
        public string Name { get; set; }

        [StringLength(40), Display(Name = "If applicable, artist's birth name")]
        public string BirthName { get; set; }

        [Display(Name = "Birth date, or start date"), Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthOrStartDate { get; set; }

        [StringLength(40), Display(Name = "Executive who looks after this artist")]
        public string Executive { get; set; }

        [StringLength(40), Display(Name = "Artist's primary genre")]
        public string Genre { get; set; }

        [Display(Name = "Artist Photo"), Required]
        public string UrlArtist { get; set; }
    }
}