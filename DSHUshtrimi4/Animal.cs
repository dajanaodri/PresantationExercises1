using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHUshtrimi4
{
    public abstract class Animal
    {
        private int _weight;
        private string _name;

        public Animal(int weight, string name)
        {
            this._weight = weight;
            this._name = name;
        }

        public abstract void Speak();
        public abstract void Move();

        public override string ToString()
        {
            return "Weight: " + _weight + ", Name: " + _name;
        }

    }

}
