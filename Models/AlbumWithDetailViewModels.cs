using F2022A6AA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class AlbumWithDetailViewModels : AlbumBaseViewModels
	{
        public AlbumWithDetailViewModels()
        {
            Artists = new List<Artist>();
            Tracks = new List<Track>();
            ArtistNames = new List<string>();
            ReleaseDate = DateTime.Now;
        }

        public IEnumerable<string> ArtistNames { get; set; }
        public DateTime ReleaseDate { get; }
        [Display(Name = "Numbers of artists on this album")]
        public IEnumerable<Artist> Artists { get; set; }
        [Display(Name = "Numbers of tracks on this album")]
        public IEnumerable<Track> Tracks { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Album background")]
        public string Background { get; set; }
    }
}