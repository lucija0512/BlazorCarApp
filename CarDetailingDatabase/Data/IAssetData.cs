using CarDetailingDatabase.Models;

namespace CarDetailingDatabase.Data
{
    public interface IAssetData
    {
        Task<List<AssetType>> GetAssetTypes();
        Task<List<AssetModel>> GetAssets();
        Task SaveNewAsset(AssetModel asset);
    }
}