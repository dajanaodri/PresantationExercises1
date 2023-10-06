using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    // Base class
    class Vehicle
    {
        public string Power { get; set; }
        public int RPM { get; set; }
        public int NumberOfCylinders { get; set; }

        public virtual void Engine()
        {
            Console.WriteLine("Base Engine Information:");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"RPM: {RPM}");
            Console.WriteLine($"Number of Cylinders: {NumberOfCylinders}");
        }
    }

}
