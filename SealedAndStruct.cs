using System;

namespace SealedAndStruct
{
    sealed class SealedClass
    { public int x = 5; }

    //Trying to derive from SealedClass will cause error:
    //class DerivedSealed: SealedClass { }
    //Structs cannot be derived either.

    public struct Location
    {
        public string city;
        public string state;
        public int zip;
        public void DisplayLocation()
        {
            Console.WriteLine(city, state, zip);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a sealed class
            var Example = new SealedClass();
            Console.WriteLine(Example.x);
            
            //Instantiating a struct
            Location myLocation;
            myLocation.city = "Portland";
        }
    }
}

