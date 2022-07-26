using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp17
{
    internal class Program
    {
        public   static List<string>[] hashtable;
        
        
        static void Main(string[] args)
        {
            hashtable = new List<string>[256];


        //string text;
        //Console.WriteLine("Введите фамилию");
        //text = Console.ReadLine();
        //byte kode;
        //kode = GetHash(text);
        //Console.WriteLine(kode);
    }

        public static byte GetHash(string text)
        {
           byte kode = 0;
           
                foreach (char c in text)
                    kode = (byte)(kode + c);
            
            return kode;    
            
            

        }

        public static void CreateFolder(string starttext)
        {
            string temp;
            temp = Path.GetFileName(starttext);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ' + "+ " + temp));
            Console.ForegroundColor = ConsoleColor.White;

            //вывод имен файлов
            foreach (string s in Directory.GetFiles(starttext))
            {
                temp = Path.GetFileName(s);
               
            }

            // обход вложенных папок
            foreach (string s in Directory.GetDirectories(starttext))
            {
                CreateFolder(s);
            }
        }

    }
    
    
    
    
    }

