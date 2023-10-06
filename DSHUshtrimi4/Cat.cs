using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHUshtrimi4
{
    public class Cat : Animal
    {
        public Cat(int weight, string name) : base(weight, name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Cat is moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}
