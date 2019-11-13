using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Maxim.Entities;

namespace Maxim.Data
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetNewestCarByOrder();
        IEnumerable<Car> GetCarsByAlpha();
        IEnumerable<Car> GetCarsByPrice();
        Car GetBestValueCar();
        double FuelComsumption(double distance, string make);
        Car GetRandomCar();
        double AvgMPGByYear(int year);

    }
}
