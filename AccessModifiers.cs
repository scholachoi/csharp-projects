using System;

namespace AccessModifiers
{
    public class Person
    {
        //protected internal can be accessed outside the assembly (in a derived class)
        protected internal string name;
        //internal can not be accessed outside the assembly
        internal char sex;
        //protected is accessible in derived class if access occurs through the derived class type
        protected int age;
        //protected and private members need public methods to access them outside of the class
        public int Age
        {
           get { return age; }
            set { age = value; }
        }
        private string race;
        public string Race
        {
            get { return race; }
            set { race = value; }
        }    
    }

    public class Student : Person
    { 
        
        static void Main(string[] args)
        {
            var sally = new Person
            {
                name = "Sally",
                sex = 'F',
                Age = 33,
                Race = "other"
            };

            //Derived class can access public, protected internal, internal, and protected members of base class
            var johnny = new Student
            {
                name = "Johnny",
                sex = 'M',
                age = 29,
                Race = "black"
            };
            

        }
    }
}

