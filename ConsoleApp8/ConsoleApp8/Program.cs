// See https://aka.ms/new-console-template for more information
namespace Hello
{
    public class Powerfive
    {
        public static bool[] Testfive(int[] arr)//5라는 소인수를 갖는지 검사하는 클래스
        {
            bool[] arr2 = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 != 0 && arr[i] != 1)
                {
                    arr2[i] = false;
                }
                else
                {
                    arr2[i] = true;
                }
            }
            return arr2;
        }
        public static string[] Onlyfive(int[] arr)//5이외의 소인수를 갖는지 검사하는 클래스
        {
            string[] arr2 = new string[arr.Length];
            bool[] arr3 = Testfive(arr);
            int multicount = 0;
            int k = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr3[i])//true 에 한하여 5이외의 소인수를 갖는지 검사 
                {
                    if (arr[i] > 0)//true일 경우 거듭제곱 횟수 반환 5외의 소인수를 가지면 "log"반환
                    {
                        while (k <= arr[i] / 2)//5이외의 소인수를 하나라도 가지면 즉시 "log"를 반환하고 while문 중단
                        {
                            if ( arr[i] % k == 0 && k%5 != 0 )//5로 나누면 나누어지기 때문에 이떄는 건너 뛰어야 한다
                            {
                                arr2[i] = "log";
                                break;
                            }
                            else
                            {
                                k++;
                            }
                        }
                        if (k == ((arr[i] / 2)+1))//5이외의 소인수를 가지지 않아 while문을 즁단하지 않고 정해진 조건에 의해 끝났으므로 거듭제곱 횟수 반환 
                        {
                            while (arr[i] != 1)
                            {
                                arr[i] = arr[i] / 5;
                                multicount++;
                            }
                            arr2[i] = Convert.ToString(multicount);//문자열 배열이기때문에 숫자를 문자열로 변환
                        }
                        else if(arr[i] == 1)//1은 5의 0승이다 따라서 0을 반환한다
                        {
                            arr2[i] = "0";
                        }
                        
                    }
                    else//0이하의 음수는 밑이 5인log를 써서 표현할수 없다 따라서 "cannot"을 반환
                    {
                        arr2[i] = "cannot";
                    }
                }
                else if(arr[i] > 0)//5를 소인수로 갖지 않으므로 그대로 "log"를 반환 
                {
                    arr2[i] = "log";
                }
                else
                {
                    arr2[i] = "cannot";
                }
                k = 2;
                multicount = 0;
            }
            return arr2;
        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
            int[] array1 = new int[] { 12, 5, 7, 25, 65, 500, 3125, 1 };
            int[] array2 = new int[] { 17, 5, 8, 23, 625, 100, 0, -5 };
            int[] array3 = new int[] { 3, 1, -1, 125, 19, 50, 555, 89 };
            int[] array4 = new int[] { 9, 135, 78125, 250, -25, 875, 15625, 115};
            string[] answer1 = Powerfive.Onlyfive(array1);
            string[] answer2 = Powerfive.Onlyfive(array2);
            string[] answer3 = Powerfive.Onlyfive(array3);
            string[] answer4 = Powerfive.Onlyfive(array4);
            Console.Write("[ ");
            for(int i = 0; i < answer1.Length; i++)
            {
                Console.Write(answer1[i]+" ");//[log, 1, log, 2, log, log, 5, 0]
            }
            Console.WriteLine("]");
            Console.Write("[ ");
            for (int i = 0; i < answer2.Length; i++)
            {
                Console.Write(answer2[i]+" ");//[log, 1, log, log, 4, log, cannot, cannot]
            }
            Console.WriteLine("]");
            Console.Write("[ ");
            for (int i = 0; i < answer3.Length; i++)
            {
                Console.Write(answer3[i]+" ");//[log, 0, cannot, 3, log, log, log, log]
            }
            Console.WriteLine("]");
            Console.Write("[ ");
            for (int i = 0; i < answer4.Length; i++)
            {
                Console.Write(answer4[i] + " ");//[log, log, 7, log, cannot, log, 6, log]
            }
            Console.WriteLine("]");
        }
    }
}