using System;
using System.IO;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Введите путь к папке");
            path = Console.ReadLine();
            ShowFiles(path, 1);
        }
    
    
    public static void ShowFiles(string folder, int level)
        {
            string temp;
            temp = Path.GetFileName(folder);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', level * 3) + "+ " + temp);
            Console.ForegroundColor= ConsoleColor.White;
           
            //вывод имен файлов
            foreach (string s in Directory.GetFiles(folder))
            {
                temp = Path.GetFileName(s);
                Console.WriteLine(new string('.', level * 3) + "      - " + temp);
            }

            // обход вложенных папок
            foreach(string s  in Directory.GetDirectories(folder))
            {
                ShowFiles(s, level + 1);
            }
        }
    
    }
}
