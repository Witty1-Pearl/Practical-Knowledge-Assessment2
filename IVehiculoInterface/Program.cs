using System;

namespace IVehiculoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
             IVehiculo car = new Car();


             car.Drive("wheels");
             car.Refuel("pump");
        }
    }
}
