// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void SumAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
            Console.WriteLine("합: " + sum);
            Console.WriteLine("평균: " + avg);
        }
        static void Main(string[] args)
        {
            int[] arr = { 25, 125, 78125, 625, 5 };
            SumAvg(arr);
        }
    }
}