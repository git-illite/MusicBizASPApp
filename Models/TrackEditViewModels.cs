using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class TrackEditViewModels : TrackBaseViewModels
	{

		[Required]
		[Display(Name = "Clip"), DataType(DataType.Upload)]
		public HttpPostedFileBase AudioUpload { get; set; }
	}
}