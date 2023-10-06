using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{

    // Child class
    class Car : Vehicle
    {
        public Car(string power, int rpm, int numberOfCylinders)
        {
            Power = power;
            RPM = rpm;
            NumberOfCylinders = numberOfCylinders;
        }
        public override void Engine()
        {
            Console.WriteLine("Car Engine Information:");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"RPM: {RPM}");
            Console.WriteLine($"Number of Cylinders: {NumberOfCylinders}");
        }
    }
}
