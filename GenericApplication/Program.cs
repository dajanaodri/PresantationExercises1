using System;
using System.Collections.Generic;

namespace GenericApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaring and initializing an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            // setting values
            for (int c = 0; c < 5; c++)
            {
                intArray[c] = c * 5;
            }

            // retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray[c] + " ");
            }
            Console.WriteLine();
            //-------------------------

            // declaring and initializing a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            // setting values
            for (int c = 0; c < 5; c++)
            {
                charArray[c] = (char)(c + 97);
            }

            // retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray[c] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}