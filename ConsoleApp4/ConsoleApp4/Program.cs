using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //САМАЯ БОЛЬШАЯ ГРУППА В КЛУБ

            int age = 1;          //возраст предидущего студента
            int newage = 1;       //возраст текущего студента
            int Nos = 0;          // количество студентов в группе
            int maxNos = 0;       // количество студентов в самой большой группе
             
            while (true)
            {
                do
                {
                    Console.WriteLine("Введите возраст проходящего в данный момент студента");
                    newage = int.Parse(Console.ReadLine());

                    if (newage == 0)
                    {
                        Console.WriteLine("Выход: " + maxNos);
                        Console.ReadLine();
                        return;
                    }
                    if (newage != age) break;
                    Nos = Nos + 1;
                 } while (newage ==age);

                if (Nos > maxNos)  maxNos = Nos;
                Nos = 1;
                age = newage;
                


            }
        
        
        
        
        
        
        
        
        }


    }
}
