using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        // Private array to store the elements of type T
        private T[] array;

        // Constructor to initialize the array with a given size
        public MyGenericArray(int size)
        {
            // Create a new array of type T with the specified size
            array = new T[size];
        }

        // Indexer allows easy access to array elements using []
        public T this[int index]
        {
            // Getter returns the value at the specified index
            get { return array[index]; }

            // Setter sets the value at the specified index
            set { array[index] = value; }
        }
    }
}
