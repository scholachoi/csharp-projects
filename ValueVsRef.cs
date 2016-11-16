using System;


namespace ValueVsReference
{
    class Student
    {
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int is a value type. Assigning a new variable name creates a copy, separate from original.
            //Changing the value of y does not affect x.
            int x = 5;
            int y = x;
            y = 7;
            Console.WriteLine(y);
            Console.WriteLine(x);

            //Object is a reference type. Assigning a new name points to the same data. 
            //Changing s2 changes s1.
            var s1 = new Student();
            s1.name = "Sally";
            Student s2 = s1;
            s2.name = "Johnny";
            Console.WriteLine(s1.name);
            Console.WriteLine(s2.name);
        }
    }
}
