using CarsDealer.Models;
using System.Collections.Generic;

namespace CarsDealer.Repositories
{
    public interface ICarTypeRepository
    {
        List<CarType> GetAllCarTypes();
        CarType GetCarTypeById(int cartypeId);
    }
}
