using System;


namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Any value type can be nullable.
            int? num1 = null;
            double? num2 = null;
            bool? reply = null;
            char? a = null;

            //Nullable types can have ordinary values.
            bool? answer = true;
            int? num3 = 5;

            //Nullable type can be cast to regular type.
            int num4 = (int)num3;

            //Assigning default value when non-nullable variable is assigned to nullable with null value.
            char b = a ?? 'a';
            Console.WriteLine(b);
            
            //HasValue() method checks for null
            Console.WriteLine(num2.HasValue);

            //Value() method retrieves value for nullable type
            Console.WriteLine(num3.Value);

            //Adding null to not null produces null
            Console.WriteLine((num1 + num3).HasValue);
            



        }
    }
}
