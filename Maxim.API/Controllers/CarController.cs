using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxim.Entities;
using Maxim.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maxim.API.DTO;

namespace Maxim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("{year}/AvgMPG")]
        public double AvgMPGByYear(int year)
        {
            var car = _carService.AvgMPGByYear(year);
            return car;
        }

        [HttpPost]
        [Route("FuelComsumption")]
        public double FuelComsumption([FromBody]CalculationInput calculationInput)
        {
            var car = _carService.FuelComsumption(calculationInput.Distance,calculationInput.Make);
            return car; 
        }

        [HttpGet]
        [Route("BestValueCar")]
        public Car GetBestValueCar()
        {
            var car = _carService.GetBestValueCar();
            return car; 
        }

        [HttpGet]
        [Route("Alpha")]
        public IEnumerable<Car> GetCarsByAlpha()
        {
            var car = _carService.GetCarsByAlpha();
            return car;
        }

        [HttpGet]
        [Route("Price")]
        public IEnumerable<Car> GetCarsByPrice()
        {
            var car = _carService.GetCarsByPrice();
            return car; 
        }

        [HttpGet]
        [Route("NewestCar")]
        public IEnumerable<Car> GetNewestCarByOrder()
        {
            var car = _carService.GetNewestCarByOrder();
            return car;
        }

        [HttpGet]
        [Route("Random")]
        public Car GetRandomCar()
        {
            var car = _carService.GetRandomCar();
            return car;
        }

    }
}