using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodApp
{
    public class MyClass<T> where T : class
    {
        // T must be a reference type
    }
    public class MyStruct<T> where T : struct
    {
        // T must be a value type
    }
    public class MyClassWithParameterlessConstructor<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); // T must have a parameterless constructor
        }
    }
    public class MySubClass<T> where T : SomeBaseClass
    {
        // T must be a subclass of SomeBaseClass
    }

    public class SomeBaseClass
    {
    }
    public class MyClassThatImplementsInterface<T> where T : ISomeInterface
    {
        // T must implement ISomeInterface
    }

    public interface ISomeInterface
    {
    }
    public class MySpecialGenericClass<T> where T : class, ISomeInterface
    {
        // T must be a reference type and implement ISomeInterface
    }
}
