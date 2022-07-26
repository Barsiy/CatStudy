using System;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = "Привет";
            string unres = Upper(res);
            foreach (char c in unres) Console.Write(c); 
            

        }
    
    public static string Upper(string res)
         
        {
            string upres = "";
            
            for (int c = 0; c < res.Length; c++)
            {
                upres = res[c].ToString() + upres;
            }
            return upres; 
        }
    
    }
}
