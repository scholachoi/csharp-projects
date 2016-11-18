using System;


namespace Enumeration
{
    enum Customer { Adult, Child, Senior, Student, Veteran }
   
    static class Movie
    {
        static decimal CalculatePrice(Customer customer)
        {
            switch (customer)
            {
                case Customer.Adult:
                    return 12.00m;
                    
                case Customer.Child:
                    return 9.00m;
                   
                case Customer.Senior:
                    return 9.50m;
                   
                case Customer.Student:
                    return 11.00m;
                   
                case Customer.Veteran:
                    return 10.00m;
                   
                default:
                    return 12.00m;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Movie.CalculatePrice(Customer.Child));

        }
    }
}
