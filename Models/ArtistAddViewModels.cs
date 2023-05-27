using F2022A6AA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Models
{
	public class ArtistAddViewModels :ArtistBaseViewModels
	{
		public ArtistAddViewModels()
		{
			BirthOrStartDate = DateTime.Now;
			Albums = new List<Album>();		
		}

		
		[Display(Name = "URL to Artist Photo"), Required]
		public new string UrlArtist { get; set; }

		[Display(Name = "Artist's primary genre")]
		public SelectList ArtistGenreList { get; set; }

		public IEnumerable<Album> Albums { get; set; }

		[DataType(DataType.MultilineText)]
		[Display(Name = "Artist portrayal")]
		public string Portrayal { get; set; }
	}
}