using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F2022A6AA.Data
{
	public class Artist
	{
		public Artist()
		{
			BirthName = "";
			BirthOrStartDate = DateTime.Now.AddYears(-20);
			Albums = new List<Album>();
		}

		public int Id { get; set; }

		// For an individual, can be birth name, or a stage/performer name
		// For a duo/band/group/orchestra, will typically be a stage/performer name
		[Required, StringLength(100)]
		public string Name { get; set; }

		// For an individual, a birth name
		[StringLength(100)]
		public string BirthName { get; set; }

		// For an individual, a birth date
		// For all others, can be the date the artist started working together
		public DateTime BirthOrStartDate { get; set; }

		// Get from Apple iTunes Preview, Amazon, or Wikipedia
		[Required, StringLength(512)]
		public string UrlArtist { get; set; }

		[Required]
		public string Genre { get; set; }

		// User name who looks after this artist
		[Required, StringLength(200)]
		public string Executive { get; set; }

		public ICollection<Album> Albums { get; set; }

		public string Portrayal { get; set; }
	}
}