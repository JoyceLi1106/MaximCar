using System;
using System.Collections.Generic;
using System.Text;
using Maxim.Data;
using Maxim.Entities;

namespace Maxim.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public double AvgMPGByYear(int year)
        {
            return _repository.AvgMPGByYear(year);
        }

        public double FuelComsumption(double distance, string make)
        {
            return _repository.FuelComsumption(distance, make);
        }

        public Car GetBestValueCar()
        {
            return _repository.GetBestValueCar();
        }

        public IEnumerable<Car> GetCarsByAlpha()
        {
            return _repository.GetCarsByAlpha();
        }

        public IEnumerable<Car> GetCarsByPrice()
        {
            return _repository.GetCarsByPrice();
        }

        public IEnumerable<Car> GetNewestCarByOrder()
        {
            return _repository.GetNewestCarByOrder();
        }

        public Car GetRandomCar()
        {
            return _repository.GetRandomCar();
        }
    }
}
