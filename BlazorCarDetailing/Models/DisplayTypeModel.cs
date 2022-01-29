using System.ComponentModel.DataAnnotations;

namespace BlazorCarDetailing.Models
{
    public class DisplayTypeModel
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public TimeSpan ApproximateDuration { get; set; }
    }
}
