using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    public class Person
    {
        public int Age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
