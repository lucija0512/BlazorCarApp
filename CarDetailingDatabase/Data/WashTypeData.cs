using CarDetailingDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Data
{
    public class WashTypeData : IWashTypeData
    {
        private readonly IDatabaseAccess _db;

        public WashTypeData(IDatabaseAccess db)
        {
            _db = db;
        }

        public Task<List<WashTypeModel>> GetWashTypes()
        {
            string sql = "SELECT * FROM wash_type";

            return _db.LoadData<WashTypeModel, dynamic>(sql, new { });
        }

        public Task SaveNewWashType(WashTypeModel type)
        {
            string sql = @"INSERT INTO wash_type (type, description, price, approximateduration) VALUES (@Type, @Description, @Price, @ApproximateDuration)";

            return _db.SaveData(sql, type);
        }
    }
}
