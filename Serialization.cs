using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Serialization
{
    [Serializable]
    class Cat
    {
        public string name;
        public int age;
        public void Init(string name, int age)
        //Use of "this" keyword to differentiate members from parameters
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Serialize(Cat obj)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("BinFile.bin", FileMode.Create, FileAccess.ReadWrite);
            try
            {
                formatter.Serialize(stream, obj);
                Console.WriteLine("Writing to bin file...");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize: " + e.Message);
            }
            finally
            {
                stream.Close();
            }
        }

        static void Deserialize(Cat obj)
        {
            Stream stream = new FileStream("BinFile.bin", FileMode.Open, FileAccess.ReadWrite);
            IFormatter formatter = new BinaryFormatter();
            try
            {
                obj = (Cat)formatter.Deserialize(stream);
                Console.WriteLine("Converting back to original...");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to deserialize: " + e.Message);
            }
            finally
            {
                stream.Close();
            }
        }
        static void Main(string[] args)
        {
            Cat boo = new Cat();
            boo.Init("Boo", 18);
            Serialize(boo);
            Thread.Sleep(2000);
            Deserialize(boo);
            Console.WriteLine("Cat name: {0} \nAge: {1}", boo.name, boo.age);
        }
    }

}
