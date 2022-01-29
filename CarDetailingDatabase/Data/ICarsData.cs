using CarDetailingDatabase.Models;

namespace CarDetailingDatabase.Data
{
    public interface ICarsData
    {
        Task<List<CarModel>> GetCars();
        Task SaveNewCar(CarModel car);
    }
}