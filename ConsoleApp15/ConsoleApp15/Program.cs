using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            string s = "";

            if(CombainNum(num, 3, 5, ref s))
                Console.WriteLine(1+ s);  
            else
                Console.WriteLine("Не составить!");

            
        }
            
        





        public static bool CombainNum(int num, int A, int B, ref string answer)
        {
            int oldNum = num;
            string oldanswer = answer;
            //пробуем деление
            if(num % B == 0)
            {
                num = num / B;
                answer = "*" + B.ToString() + answer;
                if(num == 1) return true;
                else
                {
                    num = oldNum; answer = oldanswer;   
                }

            }   //пробуем вычитание
        if(num - A >= 1)
            {
                num = num - A;
                answer = "*" + A.ToString() + answer;
                if(num == 1) return true;
                else
                    return CombainNum(num, A, B, ref answer);
            }

            else return false;
        }

    }
    



}
