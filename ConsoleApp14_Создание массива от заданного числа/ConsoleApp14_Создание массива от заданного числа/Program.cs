using System;

namespace ConsoleApp14_Создание_массива_от_заданного_числа
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string text = "Коты  с Крестовского   самые счастливые";
            Console.WriteLine(text);  
           
            OutPut(text);
            //Console.WriteLine(text1);
            
            
            //string text = "Шифр";
            //Console.WriteLine(text);
            //int muv = 3;
            //string untext = Shifr(text, muv);   
            //Console.WriteLine(untext);


            //string text = "Коты с Каменного...";
            //Console.WriteLine(text);
            //string flip = Change(text);
            //Console.WriteLine(flip);

            //double[] mix = {2, -3, -4, 5, 7, -10, -8};
            // foreach(double x in mix) Console.Write(x + " ");
            // Console.ReadLine();

            //double[] neg = CreatNegativ(mix);
            //foreach (double y in neg) Console.Write(y + " ");

            ;


            //int num;
            //int len;

            //Console.WriteLine("Введите начальное значение для массива!");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите длину массива!");
            //len = int.Parse(Console.ReadLine());

            //int[] arr = Create(num, len);
            //foreach (int x in arr) Console.Write( x + " ");

        }


        public static void OutPut(string text)
        {
            string text1 = "";
            text = text + " ";
            for (int c = 0; c < text.Length; c++)
            {
                if (text[c] != ' ')
                    text1 += text[c];
                else
                {
                    Console.WriteLine(text1);
                    text1 = "";
                }
            }
                 
          
            //string unknown = "";
            //for (int c = 0; c < text.Length; c++)
            //{
            //    unknown = unknown + (char)(text[c] + muv);
            //}
            //return unknown; 

            //string flip = "";
            //for(int c = 0; c < text.Length; c++)
            //{
            //    flip = text[c] + flip;
            //}
            //return flip;

            //int numNeg = 0;
            //for (int c = 0; c < mix.Length; c++)
            //{
            //    if (mix[c] < 0)
            //        numNeg++;
            //}

            //double[] neg = new double[numNeg];
            //int d = 0;
            //for (int c = 0; c < mix.Length; c++)
            //{
            //    if (mix[c] < 0)
            //    {
            //        neg[d] = mix[c];
            //        d++;
            //    }
            //}
            //return neg;


            //int[] arr = new int[len];
            //for (int c = 0; c < arr.Length; c++)
            //{
            //    arr[c] = num + 2 * c;
            //}
            //return arr;
        }

    }
}
