using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gyak5.Validation.Models
{
    public class Diak
    {
        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage ="6 betűs legyen a neved")]
        [Display (Name ="Név")]
        public string Nev { get; set; }
        [Required]
        [Range (0, 500, ErrorMessage ="Nem lehet ennyi pontod")]
        [Display(Name ="Pontszám")]
        public int PontSzam { get; set; }
    }
}