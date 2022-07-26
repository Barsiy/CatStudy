using System;
using System.Collections.Generic;

namespace ConsoleApp22
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<int> res = SearchNum(100000, 999999);

            foreach (var item in res)
            {
                Console.WriteLine($"Найденные числа: {item}");
            }





        }


        public static List<int> SearchNum(int start, int end)

        {
            
            List<int> revNums = new List<int>();   
            //int temp, left, rev;



            for (int c = start; c <= end; c++)

            {
                int rev = 0;
                rev = Revers(c);
                if(rev == c * 4)
                {
                    revNums.Add(rev);
                }
                
            }

            
            return revNums;
        }
        
        public static int Revers(int num)
        {
            string temp = "";
            temp = num.ToString();
            char[] nums = temp.ToCharArray();
            temp = "";
            
            for (int i = nums.Length - 1; i > -1; i--)
            {
                temp = temp + nums[i];
            }

            return Convert.ToInt32(temp);
        }
        
    
    
    }
    }
