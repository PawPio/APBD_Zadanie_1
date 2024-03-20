using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 10, 15, 20, 25}
            double average = CalculateAverage(numbers);
            int max = FindMaxValue(numbers);
            Console.WriteLine("average is equal to: " + average);
            Console.WriteLine("max is equal to: " + max);

            
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
        public static int FindMaxValue(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
    }
}