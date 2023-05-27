using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A6AA.Models
{
	public class TrackWithDetailViewModels : TrackBaseViewModels
	{
        [Display(Name = "Sample Clip")]
        public string MediaUrl
        {
            get
            {
                return $"/audio/{Id}";
            }
        }
    }
}