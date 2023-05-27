using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class MediaItemAddFormViewModels : MediaItemAddViewModels
	{
		[Required, Display(Name = "Media upload"), DataType(DataType.Upload)]
		public string MediaUpload { get; set; }
	}
}