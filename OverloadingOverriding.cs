using System;


namespace OverloadingOverriding
{
    class Overloading
    {
        public static void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }

        public static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }

    //Example of overriding a method
    class Customer
    {
        public virtual int BonusPoints()
        {
            return 0;
        }
    }

    class LoyalCustomer : Customer
    {
        public override int BonusPoints()
        {
            return 5;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Overloading.Add(2, 5);
            Overloading.Add("two", "five");
            var customer1 = new LoyalCustomer();
            Console.WriteLine("Customer1 bonus points: " + customer1.BonusPoints());
        }
    }
}

