using System;

namespace Find_Maximum_Number_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number Problem!");

            ///UC1- Given 3 Integers find the maximum number
            Console.WriteLine("Enter three numbers to find Maximum Value");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            int maxNumber = MaximumNumberCheck.MaximumNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum number is:" + maxNumber);

            ///UC2- Given 3 Float find the maximum number
            Console.WriteLine("Enter three float numbers to find Maximum Value");
            Double firstFloatValue = Convert.ToDouble(Console.ReadLine());
            Double secondFloatValue = Convert.ToDouble(Console.ReadLine());
            Double thirdFloatValue = Convert.ToDouble(Console.ReadLine());
            Double maxFloatNumber = MaximumNumberCheck.MaximumFloatNumber(firstFloatValue, secondFloatValue, thirdFloatValue);
            Console.WriteLine("Maximum float value is:" + maxFloatNumber);

        }
    }
}
