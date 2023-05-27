using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A6AA.Models
{
	public class TrackAddViewModels : TrackBaseViewModels
	{

		[Display(Name = "Album Name")]
		public string AlbumName { get; set; }

		public int AlbumId { get; set; }

		[Display(Name = "Track genre")]
		public SelectList TrackGenreList { get; set; }

		[Required]
		[Display(Name = "Sample Clip"), DataType(DataType.Upload)]
		public HttpPostedFileBase AudioUpload { get; set; }
	}
}