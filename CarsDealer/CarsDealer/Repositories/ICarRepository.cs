using CarsDealer.Models;
using System.Collections.Generic;

namespace CarsDealer.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
        Car GetCarById(int carId);
        int AddCar(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);
    }
}
