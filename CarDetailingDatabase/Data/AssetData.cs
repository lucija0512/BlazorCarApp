using CarDetailingDatabase.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Data
{
    public class AssetData : IAssetData
    {
        private readonly IDatabaseAccess _db;

        public AssetData(IDatabaseAccess db)
        {
            _db = db;
        }

        public Task<List<AssetType>> GetAssetTypes() 
        {
            string sql = "SELECT * FROM asset_type";

            return _db.LoadData<AssetType, dynamic>(sql, new { });
        }

        public async Task<List<AssetModel>> GetAssets()
        {
            string connectionString = _db._config.GetConnectionString(_db.ConnectionStringName);
            string sql = "SELECT * FROM asset JOIN asset_type ON asset.asset_type_id = asset_type.id";

            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<AssetModel, AssetType, AssetModel>(sql,
                    (a, t) => { a.Type = t; return a; },
                    splitOn: "Id");

                return data.ToList();
            }
        }

        public Task SaveNewAsset(AssetModel asset)
        {
            string sql = @"INSERT INTO asset (name, price, asset_type_id) VALUES (@Name, @Price, @TypeId)";

            return _db.SaveData(sql, new { Name = asset.Name, Price = asset.Price, TypeId = asset.Type.Id});
        }
    }
}
