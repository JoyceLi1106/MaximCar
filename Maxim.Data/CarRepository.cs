using Maxim.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxim.Data
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _mockRepo;
        public CarRepository()
        {

            _mockRepo = new List<Car>
                {
                    new Car{ Make="Honda",Model = "CRV",Color = "Green", Year = 2016, Price = 23845,TCCRating = 8, HwyMPG = 33 },
                    new Car{ Make="Ford",Model = "Escape",Color = "Red", Year = 2017, Price = 23590,TCCRating = 7.8, HwyMPG = 32 },
                    new Car{ Make="Hyundai",Model = "Sante Fe",Color = "Grey", Year = 2016, Price = 24950,TCCRating = 8, HwyMPG = 27 },
                    new Car{ Make="Mazda",Model = "CX-5",Color = "Red", Year = 2017, Price = 21795,TCCRating = 8, HwyMPG = 35 },
                    new Car{ Make="Subaru",Model = "Forester",Color = "Blue", Year = 2016, Price = 22395,TCCRating = 8.4, HwyMPG = 32 }
                };
        }

        public double AvgMPGByYear(int year)
        {
            return _mockRepo.Where(c => c.Year == year).Average(c => c.HwyMPG);
        }

        public double FuelComsumption(double distance, string make)
        {
            var car = _mockRepo.Where(c => c.Make == make).SingleOrDefault();
            return distance * car.HwyMPG;
        }

        public Car GetBestValueCar()
        {
            return _mockRepo.OrderByDescending(c => c.TCCRating).FirstOrDefault();
        }

        public IEnumerable<Car> GetCarsByAlpha()
        {
            return _mockRepo.OrderBy(c => c.Make).ToList();
        }

        public IEnumerable<Car> GetCarsByPrice()
        {
            return _mockRepo.OrderByDescending(c => c.Price).ToList();
        }

        public IEnumerable<Car> GetNewestCarByOrder()
        {
            return _mockRepo.OrderByDescending(c => c.Year).ToList();
        }

        public Car GetRandomCar()
        {
            var random = new Random();
            var car = _mockRepo.OrderBy(c => random.Next()).FirstOrDefault();
            return car;
        }
    }
}

        