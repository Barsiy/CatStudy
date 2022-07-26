using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp19
{
    internal class Program
    
    
    {
        public static Queue<string> que = new Queue<string>();
        static void Main(string[] args)
        {
           
             List<string> vs = new List<string> { "A", "B", "C", "D", "E", "I", "F", "J", "K", "L"};
            
            
            
            
            
             Console.WriteLine($"Выручка за день составила: {KountSumm()}" );    
        }


        public static int KountSumm()
        {
            Stack<int> kass = new Stack<int>(); 
            Random rand = new Random();
            while (que.Count > 0)
            {
                que.Dequeue();
                int coffe;
                coffe = rand.Next(1, 3);
                kass.Push(coffe * 100);
            }
            int sum = 0;
            foreach (var item in kass)
            {
                sum = sum + item;
            }
            return sum;

        }
    }
}
