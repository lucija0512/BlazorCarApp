using System.ComponentModel.DataAnnotations;

namespace BlazorCarDetailing.Models
{
    public class DisplayCarModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Ime vlasnika je predugo")]
        public string Owner { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Naziv modela je predug")]
        public string Model { get; set; }
    }
}
