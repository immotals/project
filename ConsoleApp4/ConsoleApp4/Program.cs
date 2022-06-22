// See https://aka.ms/new-console-template for more information
namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k = 6;
            char c = '*';
            for (int i=1; i <= k; i++)
            {
                for(int j=i; j < k; j++) {
                    Console.Write(" "); 
                }
                for (int n = 1; n <= 2*i-1; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
