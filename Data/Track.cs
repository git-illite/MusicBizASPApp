using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F2022A6AA.Data
{
	public class Track
	{
		public Track()
		{
			Albums = new List<Album>();
		}

		public int Id { get; set; }

		[Required, StringLength(200)]
		public string Name { get; set; }

		// Simple comma-separated string of all the track's composers
		[Required, StringLength(500)]
		public string Composers { get; set; }

		[Required]
		public string Genre { get; set; }

		// User name who added/edited the track
		[Required, StringLength(200)]
		public string Clerk { get; set; }

		public ICollection<Album> Albums { get; set; }

		[StringLength(200)]
		public string MediaContentType { get; set; }
		public byte[] Media { get; set; }
	}
}