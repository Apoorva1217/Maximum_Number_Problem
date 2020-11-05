using System;


namespace Find_Maximum_Number_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number Problem!");

            int[] intArray = { 11, 17, 22 };
            MaximumNumberCheck<int> maximumNumberCheck = new MaximumNumberCheck<int>(intArray);
            maximumNumberCheck.PrintMaxValue();

            float[] floatArray = { 11.4f, 17.7f, 22.2f };
            MaximumNumberCheck<float> maximumNumberCheck1 = new MaximumNumberCheck<float>(floatArray);
            maximumNumberCheck.PrintMaxValue();

            string[] stringArray = { "Apple","Peach","Banana" };
            MaximumNumberCheck<string> maximumNumberCheck2 = new MaximumNumberCheck<string>(stringArray);
            maximumNumberCheck.PrintMaxValue();
        }
    }
}
