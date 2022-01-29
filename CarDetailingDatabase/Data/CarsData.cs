using CarDetailingDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Data
{
    public class CarsData : ICarsData
    {
        private readonly IDatabaseAccess _db;

        public CarsData(IDatabaseAccess db)
        {
            _db = db;
        }

        public Task<List<CarModel>> GetCars()
        {
            string sql = "SELECT * FROM car";

            return _db.LoadData<CarModel, dynamic>(sql, new { });
        }

        public Task SaveNewCar(CarModel car)
        {
            string sql = @"INSERT INTO Car (Owner, Model) VALUES (@Owner, @Model)";

            return _db.SaveData(sql, car);
        }
    }
}
