using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class TrackAudioViewModels
	{
		public int Id { get; set; }
		public byte[] Media { get; set; }
		public string MediaContentType { get; set; }
	}
}