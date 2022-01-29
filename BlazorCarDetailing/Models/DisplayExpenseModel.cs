using CarDetailingDatabase.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorCarDetailing.Models
{
    public class DisplayExpenseModel
    {
        public int Id { get; set; }
        [Required]
        public WebsiteModel Website { get; set; }
        [Required]
        public float Price { get; set; }
        public DateOnly Bought { get; set; }


        public DisplayExpenseModel()
        {
            Website = new WebsiteModel();
        }
    }
}
