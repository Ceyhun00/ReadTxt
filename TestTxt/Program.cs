using System;
using System.IO;

namespace TestTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();

        }
        //string path = "C:\SomeDir\hta.txt";
        public static void ReadFile()
        {
            Console.WriteLine("Укажите путь до файла Пример- C:\\");
            var way = Console.ReadLine();
            Console.WriteLine("Укажите имя  файла");
            var name = Console.ReadLine();
            var path = way + name;
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
