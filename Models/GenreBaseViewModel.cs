using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class GenreBaseViewModel
	{
		[Required]
		public int Id { get; set; }
		[Required, StringLength(30)]
		public string Name { get; set; }
	}
}