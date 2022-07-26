using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ТЕКСТОВАЯ ЗАПИСЬ ЧИСЛА

            int num;           //входное число
            float a;           //для извлечения единиц и десятков числа
            int un;            //единицы введенного числа
            int dec;           //десятки введенного числа
            string su = "";    //текстовое описание единиц
            string sd = "";     //текстовое описание десятков
        
            Console.WriteLine("Введите число от 1 до 99");
            if(int.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("Вы ввели не число");
                Console.ReadLine();
                return;
            }
            if(num < 1 || num >99)
            {

                Console.WriteLine("Вы ввели некоректное число");
                Console.ReadLine();
                return;
            }
            if(num >= 10 && num <20)
            {
                Console.WriteLine($"ВХОД:{num}.ВЫХОД: ");
                switch (num)
                {
                    case 10: Console.WriteLine("десять");
                        return;
                    case 11: Console.WriteLine("одиннадцать");
                        return;
                    case 12: Console.WriteLine("двенадцать");
                        return;
                    case 13: Console.WriteLine("тринадцать");
                        return;
                    case 14: Console.WriteLine("четырнадцать");
                        return;
                    case 15: Console.WriteLine("пятнадцать");
                        return;
                    case 16: Console.WriteLine("шестнадцать");
                        return;
                    case 17: Console.WriteLine("семнадцать");
                        return;
                    case 18: Console.WriteLine("восемнадцать");
                        return;
                    case 19:Console.WriteLine("девятнадцать");
                        return;
                 }

            }
            un = Convert.ToInt32((float)num % 10);
            dec = num / 10;
            switch (un)
            {
                case 1: su = "один";
                    break;
                case 2: su = "два";
                    break;
                case 3: su = "три";
                    break;
                case 4: su = "четыре";
                    break;
                case 5: su = "пять";
                    break;
                case 6: su = "шесть";
                    break;
                case 7: su = "семь";
                    break;
                case 8: su = "восемь";
                    break;
                case 9: su = "девять";
                    break;
            }
            switch (dec)
            {
                case 2: sd = "двадцать";
                    break;
                case 3: sd = "тридцать";
                    break;
                case 4: sd = "сорок";
                    break;
                case 5: sd = "пятьдесят";
                    break;
                case 6: sd = "шестьдесят";
                    break;
                case 7: sd = "семьдесят";
                    break;
                case 8: sd = "восемьдесят";
                    break;
                case 9: sd = "девяносто";
                    break;
            }
            Console.WriteLine($"ВХОД:{num}.ВЫХОД: {sd} {su}.");
            Console.ReadLine();






        }



    }
}
