using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarsDealer.Models;
using CarsDealer.Repositories;

namespace CarsDealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        //private readonly ICarTypeRepository _carTypeRepository;

        public HomeController(ICarRepository carRepository, ICarTypeRepository carTypeRepository)
        {
            _carRepository = carRepository;
            //_carTypeRepository = carTypeRepository;
        }

        public IActionResult Index()
        {
            List<Car> cars = _carRepository.GetAllCars();
            return View(cars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
