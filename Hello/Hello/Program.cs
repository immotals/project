using System;
using static System.Console;//Console단어를 생략(코드길이줄어둠)
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                WriteLine("윤년");
            else
                WriteLine("평년");
            if (DateTime.IsLeapYear(year))
                WriteLine("윤년");
            else
                WriteLine("평년");
        }
    }
}