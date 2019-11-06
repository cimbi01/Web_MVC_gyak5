using System.ComponentModel.DataAnnotations;
namespace Validation2_gyak.Models
{
    public class RandomModel
    {
        [Required (ErrorMessage = "Hiányzó adat")]
        [Display (Name ="Név: ")]
        public string Nev { get; set; }
        [Range (minimum: 0, maximum: 5, ErrorMessage = "Nincs a megadott határban (0, 5)")]
        [Display (Name = "Integer:")]
        public int Integer { get; set; }
        [Display (Name = "Character")]
        public char Character { get; set; }
    }
}