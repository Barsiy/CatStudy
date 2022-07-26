using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сумма ряда

            double x;   //Вводимое число
            double sum = 0; // значение выражение
            int zn = 1;     //для хран знака
            int step = 1;   //для степени

            Console.WriteLine("Введите число");
            x = double.Parse(Console.ReadLine());

            for (int c = 2; c <= 6; c++, step--)

            {
                sum = sum + zn*c*Math.Pow(x, step);
                zn = -zn;
            }

            Console.WriteLine("Значение равно"  + sum);
            Console.ReadLine();

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //double x = 0;     //вводимое пользователем число
            //double sum = 6;   // сумма ряда
            //int n = -1;       //переменная для хранения знака
            //double p = 1;     //переменная для хранения числа в степени, вычисленное на предидущем шаге

            //Console.WriteLine("Введите вещественное число");
            //x = double.Parse(Console.ReadLine());

            //for (int c = 5; c >= 2; c--)
            //{
            //    p= p * x;
            //    sum = sum + n * c * p;
            //    n = -n;
            //}
            //Console.WriteLine("Сумма ряда равна:" + sum);
            //Console.ReadLine();


        }
    }
}
