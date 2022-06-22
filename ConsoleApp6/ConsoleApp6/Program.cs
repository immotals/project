// See https://aka.ms/new-console-template for more information
namespace Hello
{
    public class Parent
    {
        public int Id;
    }
    class Child : Parent
    {
        public Child(int id)
        {
            this.Id = id;
  
        }
        public void Printchar(int id)
        {
            for (int i = 0; i < id; i++)
            {
                Console.Write("*");
            }
        }
        public void DisplayValue(int id)
        {
            Console.WriteLine("* 의 반복횟수은 {0}회 입니다", id);
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            Child id = new Child(13);
            int k=id.Id;
            id.Printchar(k);
            Console.WriteLine("\n"+k);
            id.DisplayValue(k);
        }
    }
}