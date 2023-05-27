using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Models
{
	public class AlbumAddViewModels : AlbumBaseViewModels
	{

		public AlbumAddViewModels()
		{
			ReleaseDate = DateTime.Now;
			Name = "";
		}

		[Required, StringLength(100)]
		public new string Name { get; set; }

		[Display(Name = "URL to Album Image (cover art)"), Required]
		public new string UrlAlbum { get; set; }

		[Display(Name = "Albums's primary genre")]
		public SelectList AlbumGenreList { get; set; }

		[Display(Name = "Artist Name")]
		public string ArtistName { get; set; }


		[DataType(DataType.MultilineText)]
		[Display(Name = "Album Background")]
		public string Background { get; set; }
	}
}