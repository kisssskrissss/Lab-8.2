using System;
using System.IO;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Numbers.txt";
            Random ran = new Random();
            using (StreamWriter sw = new StreamWriter(path, false)) 
            {
                for (int i =0; i<10; i++)
                {
                    sw.WriteLine(ran.Next(0,10));
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path)) 
            {
                for (int i = 0; i < 10; i++)
                {
                    int k = Convert.ToInt32(sr.ReadLine());
                    s += k;
                }
            }
            Console.WriteLine( s );
            Console.ReadKey();
        }
    }
}
