// See https://aka.ms/new-console-template for more information

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}