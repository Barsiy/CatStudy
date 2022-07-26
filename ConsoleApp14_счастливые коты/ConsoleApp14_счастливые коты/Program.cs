using System;

namespace ConsoleApp14_счастливые_коты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 2, 13, 4, 5, 6, 71, 8, 45, 23 }; //запись массива в обратную сторону
            {
                foreach ( int x in num) Console.Write(x+ " ");
            Console.ReadLine();
          
            int[] oppoz = Change(num);
            foreach (int x in oppoz) Console.Write(x + " ");

            //int[] numCats = {150, 200, 500000, 15};  
            //int[] numFood = {15, 150,   55000, 80};
            //string[] NameIsland = { "Каменный", "Петровский", "Крестовский", "Елагин" };
            //int maxind;
            //maxind = HappyCat(numCats, numFood);
            //Console.WriteLine("Остров, где живут самые счастливые коты " + NameIsland[maxind]);





        }


        public static int[] Change(int[] num)   //запись массива в обратную сторону
        {
            int[] op = new int[num.Length];
            for(int c = 0, d= num.Length-1; c < num.Length; c++, d--)
            {
                op[c] = num [d];
            }
            return op;   
            
           
            
            
            //int[] norm = new int[numCats.Length];

            //for (int c = 0; c < numCats.Length; c++)
            //{
            //    norm[c] = numFood[c] / numCats[c];
            //}

            //int max = norm[0];
            //int index = 0;

            //for (int c = 0; c < norm.Length; c++)
            //{
            //    if (norm[c] > max)
            //    {
            //        max = norm[c];
            //        index = c;
            //    }
            //}
            //return index;



        }
    
    
    }
}
