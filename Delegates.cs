using System;


namespace Delegates
{
    //Delegate with no parameters and void return type:
    delegate void MyDelegate();

    class Program
    {
        //Two methods with the same signature & return type as the delegate:
        static void Hello()
        {
            Console.WriteLine("Hello!");
        }

        static void Goodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        //Passing the delegate into a function:
        static void SaySomething(MyDelegate del)
        {
            Console.WriteLine("SaySomething says: ");
            del();
        }

        static void Main(string[] args)
        {
            //Two instances of the delegate, each associated with a different method.
            MyDelegate del1 = Hello;
            MyDelegate del2 = Goodbye;
            
            //del3 is a multicast delegate with del1 and del2 chained together.
            MyDelegate del3 = del1 + del2;

            //Calling the delegate invokes the method associated with it.
            del1();

            //Calling a method with delegate as parameter invokes the method associated with the delegate.
            SaySomething(del2);

            //Calling the multicast delegate invokes both Hello() and Goodbye().
            SaySomething(del3);
        }
    }

}
