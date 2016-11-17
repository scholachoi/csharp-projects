using System;


namespace AbstractClassVsInterface
{
//Both abstract class and interface are incomplete and must be implemented by derived type.
//Neither can be instantiated.

    abstract class Animal
    {
        //Abstract class can have non-abstract members that don't have to be implemented in derived class.
        //Abstract class can have fields; interface cannot.
        string name;
        
        //Class members can have access modifiers; interface members cannot (they're public by default).
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
           
        public abstract void MakeNoise();
    }

    //Interface members cannot have any implementation.
    interface IEdible
    {
        bool Edible();
    }

    interface IMoveable
    {
        bool Moveable();
    }

    //A class can inherit multiple interfaces as well as a base class
    //Derived class must implement abstract methods from base class and all interface methods.
    class Cat : Animal, IEdible, IMoveable
    {
        //Must use override to implement abstract method.
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }
        //Interface method does not need override.
        bool IEdible.Edible()
        {
            return false;
        }

        bool IMoveable.Moveable()
        {
            return true;
        }
    }

    //Interface allows simulation of inheritance for struct.
    struct Fruit: IEdible
    {
        bool IEdible.Edible()
        {
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var boo = new Cat();
            boo.MakeNoise();
        }
    }
}
