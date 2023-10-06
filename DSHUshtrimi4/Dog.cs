using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHUshtrimi4
{
    public class Dog : Animal
    {
        public Dog(int weight, string name) : base(weight, name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Ham Ham");
        }
    }
}
