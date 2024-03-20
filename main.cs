using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 10, 15, 20, 25}
            double average = CalculateAverage(numbers);
            Console.WriteLine("average is equal to: " + average);
        }
        public static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += sum;
            }

            return (double)sum / numbers.length;
        } 
    }
}