using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Models
{
    public class WashTypeModel
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public TimeSpan ApproximateDuration { get; set; }
    }
}
