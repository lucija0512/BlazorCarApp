using CarDetailingDatabase.Models;

namespace CarDetailingDatabase.Data
{
    public interface IWashTypeData
    {
        Task<List<WashTypeModel>> GetWashTypes();
        Task SaveNewWashType(WashTypeModel type);
    }
}