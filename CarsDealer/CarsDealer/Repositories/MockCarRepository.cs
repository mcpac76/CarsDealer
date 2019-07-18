using System.Collections.Generic;
using System.Linq;
using CarsDealer.Models;

namespace CarsDealer.Repositories
{
    public class MockCarRepository : ICarRepository
    {
        private readonly ICarTypeRepository _carTypeRepository;

        public MockCarRepository(ICarTypeRepository carTypeRepository)
        {
            _carTypeRepository = carTypeRepository;
        }

        private List<Car> _allCars = new List<Car>
        {
              new Car { Id=1, Make= "Ford", Model= "Mustang", Year= 2016, Mileage= "34 000 km", EngineSize= "4 900 cm3", FuelType= "Benzyna", Power= "421 KM", Description= "Mam do sprzedania Mustanga 5.0 GT V8 421KM. Kupiony w Polskim SALONIE FORDA w Opolu jako NOWY w kwietniu 2016", Price = 160000, PhotoUrl="/images/fordMustang.jpg", MiniPhotoUrl="/images/fordMustangmini.jpg", CarType = new CarType{ Id = 5, Name = "Coupe"} },
              new Car { Id=2, Make= "Audi", Model= "S5", Year= 2013, Mileage= "112 000 km", EngineSize= "3 000 cm3", FuelType= "Benzyna", Power= "280 KM", Description="Do sprzedania Audi S5 z 2013 roku. Jestem właścicielem tego samochodu od ponad dwóch lat.", Price = 115000, PhotoUrl="/images/audiS5.jpg", MiniPhotoUrl="/images/audis5mini.jpg", CarType = new CarType{ Id = 5, Name = "Coupe"}},
              new Car { Id=3, Make= "BMW", Model= "X4", Year= 2017, Mileage= "4 300 km", EngineSize= "1 995 cm3", FuelType= "Diesel", Power= "190 KM", Description="BMV X4 20d xDrive. Samochód krajowy. Samochód serwisowany. Wystawiamy fakturę VAT 23%. Samochód bezwypadkowy. I właściciel.", Price = 194000, PhotoUrl="/images/bmvx4.jpg", MiniPhotoUrl="/images/bmvx4mini.jpg", CarType = new CarType{ Id = 8, Name = "SUV"} },
              new Car { Id=4, Make= "Chevrolet", Model= "Corvette", Year= 1972, Mileage= "28 000 km", EngineSize= "5 700 cm3", FuelType= "Benzyna", Power = "300 KM", Description="Corvetta jest w świetnym stanie wizualnym i mechanicznym. Oczywiście jest ZAREJESTROWANA i ubezpieczona w PL.", Price = 90000, PhotoUrl="/images/chevroletCorvete.jpg", MiniPhotoUrl="/images/chevroletCorvetemini.jpg", CarType = new CarType{ Id = 7, Name = "Supercar"} },
              new Car { Id=5, Make= "Nissan", Model= "Skyline", Year= 1995, Mileage= "144 000 km", EngineSize= "2 500 cm3", FuelType= "Benzyna", Power = "410 KM", Description="Na sprzedaż trafia moja perełka Nissan Skyline R33.Auto z Japonii sprowadzone do Szwecji, gdzie było przez wiele lat modyfikowane, uczestniczyło w zlotach, zdobywało nagrody, samochód sponsorowany latami przez Sonax Sweden.", Price = 120000, PhotoUrl="/images/nissan.jpg", MiniPhotoUrl="/images/nissanmini.jpg", CarType = new CarType{ Id = 5, Name = "Coupe"} },
              new Car { Id=6, Make= "Jaguar", Model= "ZX", Year= 2006, Mileage= "78000 km", EngineSize= "5 000 cm3", FuelType= "Benzyna", Power = "510 KM", Description="Przedstawiam Państwu wyjątkowe auto jakim jest Jaguar XKR, a zwłaszcza ten egzemplarz. Jaguar XKR to ikona światowej i brytyjskiem motoryzacji, a przede wszystkim kontynuator legendarnego już Jaguara E-typa, przez wielu uważany za najpiękniejsze auto w historii motoryzacji.", Price = 200000, PhotoUrl="/images/jaguar.jpg", MiniPhotoUrl="/images/jaguarmini.jpg", CarType = new CarType{ Id = 7, Name = "Supercar"} },
              new Car { Id=7, Make= "BMW", Model= "330i", Year= 2015, Mileage= "23000 km", EngineSize= "2500 cm3",FuelType= "Benzyna", Power= "280 KM", Description= "Super fajny", Price= 98000, PhotoUrl="/images/bmw3.jpg", MiniPhotoUrl="/images/bmw3mini.jpg", CarType = new CarType{ Id = 2, Name = "Sedan"} },
              new Car { Id=8, Make= "AUDI", Model= "A6", Year= 2017, Mileage= "13000 km", EngineSize= "3000 cm3",FuelType= "Diesel", Power= "313 KM", Description= "Super oferta", Price= 168000, PhotoUrl="/images/audia6.jpg", MiniPhotoUrl="/images/audia6mini.jpg", CarType = new CarType{ Id = 2, Name = "Sedan"} }
        };

        public int AddCar(Car car)
        {
            var maxId = _allCars.Select(x => x.Id).Max();
            car.Id = maxId + 1;
            car.CarType = _carTypeRepository.GetCarTypeById(car.CarTypeId);
            _allCars.Add(car);
            return car.Id;
        }

        public void DeleteCar(Car car)
        {
            var existingCar = _allCars.FirstOrDefault(x => x.Id == car.Id);
            _allCars.Remove(existingCar);
        }

        public void EditCar(Car car)
        {
            var existingCar = _allCars.FirstOrDefault(x => x.Id == car.Id);
            _allCars.Remove(existingCar);
            car.CarType = _carTypeRepository.GetCarTypeById(car.CarTypeId);
            _allCars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return _allCars;
        }

        public Car GetCarById(int carId)
        {
            return _allCars.FirstOrDefault(s => s.Id == carId);
        }
    }
}
