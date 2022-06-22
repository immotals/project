// See https://aka.ms/new-console-template for more information
namespace Hello
{
    public class Program
    {
        static void PRINTCHAR(int x,  int y)
        {
            char a = '*';
            char b = ' ';
            for (int i = 1; i < x; i++)
            {
                Console.Write(b);
            }
            for (int i = 0; i < y; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            PRINTCHAR(5, 1);
            PRINTCHAR(4, 3);
            PRINTCHAR(3, 5);
            PRINTCHAR(2, 7);
            PRINTCHAR(1, 9);
        }
    }
}