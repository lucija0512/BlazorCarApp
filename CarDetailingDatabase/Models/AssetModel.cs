using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Models
{
    public class AssetModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public AssetType Type{ get; set; }

        public AssetModel()
        {
            Type = new AssetType();
        }
    }
}
