using CarDetailingDatabase.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorCarDetailing.Models
{
    public class DisplayAssetModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public AssetType Type { get; set; }

        public DisplayAssetModel()
        {
            Type = new AssetType();
        }
    }
}
