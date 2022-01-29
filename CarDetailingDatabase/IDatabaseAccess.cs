using Microsoft.Extensions.Configuration;

namespace CarDetailingDatabase
{
    public interface IDatabaseAccess
    {
        IConfiguration _config { get; }
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}