using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public WebsiteModel Website { get; set; }
        public float Price { get; set; }
        public DateOnly Bought { get; set; }

        public ExpenseModel()
        {
            Website = new WebsiteModel();
        }
    }
}
