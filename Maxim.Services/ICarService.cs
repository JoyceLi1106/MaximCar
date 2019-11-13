using Maxim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maxim.Services
{
    public interface ICarService
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
