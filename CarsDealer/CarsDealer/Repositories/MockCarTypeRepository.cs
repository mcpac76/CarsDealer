using System.Collections.Generic;
using System.Linq;
using CarsDealer.Models;

namespace CarsDealer.Repositories
{
    public class MockCarTypeRepository : ICarTypeRepository
    {
        private List<CarType> _allcarTypes = new List<CarType>
        {
            new CarType
            {
                Id = 1,
                Name = "Micro"
            },
            new CarType
            {
                Id = 2,
                Name = "Sedan"
            },
            new CarType
            {
                Id = 3,
                Name = "Hatchback"
            },
            new CarType
            {
                Id = 4,
                Name = "StationWagon"
            },
            new CarType
            {
                Id = 5,
                Name = "Coupe"
            },
            new CarType
            {
                Id = 6,
                Name = "Roadster"
            },
            new CarType
            {
                Id = 7,
                Name = "Supercar"
            },
            new CarType
            {
                Id = 8,
                Name = "SUV"
            }
        };     
        public List<CarType> GetAllCarTypes()
        {
            return _allcarTypes;
        }

        public CarType GetCarTypeById(int cartypeId)
        {
            return _allcarTypes.FirstOrDefault(x => x.Id == cartypeId);
        }
    }
}
