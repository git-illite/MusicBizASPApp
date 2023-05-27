using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class ArtistWithMediaInfoViewModels : ArtistWithDetailViewModels
	{
		public ArtistWithMediaInfoViewModels()
		{
			MediaItems = new List<MediaItemBaseViewModels>();
		}

		public IEnumerable<MediaItemBaseViewModels> MediaItems { get; set; }
	}
}