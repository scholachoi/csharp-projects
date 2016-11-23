using System;
using System.IO;

namespace ExceptionHandling
{
    
    class Program
    {
        static void Divide()
        {
            Console.Write("Enter a number: ");
            string s = Console.ReadLine();
            double num1 = Convert.ToDouble(s);
            double num2;
            while (true)
            {
                Console.Write("Enter another number that is not zero: ");
                string s2 = Console.ReadLine();
                num2 = Convert.ToDouble(s2);
                if (num2!=0)
                {
                    break;
                }
                Console.WriteLine("Number cannot be zero.");
            }
            double result = num1 / num2;
            Console.WriteLine("{0} divided by {1} is {2}.", num1, num2, result);
        }


        static void Main(string[] args)
        {
            try
            {
                Divide();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                using (StreamWriter log = new StreamWriter("log.txt"))
                {
                    log.WriteLine("{0}  {1}", DateTime.Now.ToString(), e.Message);
                    log.WriteLine("___________________________________________________________");
                }
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        

        }
    }

}
