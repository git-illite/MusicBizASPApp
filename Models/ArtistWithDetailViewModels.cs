using F2022A6AA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class ArtistWithDetailViewModels :ArtistBaseViewModels
	{
        public ArtistWithDetailViewModels()
        {
            Albums = new List<Album>();
            //AlbumNames = new List<string>();
            BirthOrStartDate = DateTime.Now;
        }

        public IEnumerable<Album> Albums { get; set; }

        public string ArtistName { get; set; }

        public IEnumerable<string> AlbumNames { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Artist portrayal")]
        public string Portrayal { get; set; }
    }
}