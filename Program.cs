using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(@"D:\Visual Studio\C#\SystemIO3\mojaDatoteka.txt");

            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();        //moramo zaustaviti StreamWriter jer je on u loop-u pa bi nam crash-ao

            StreamReader sr = new StreamReader(@"D:\Visual Studio\C#\SystemIO3\mojaDatoteka.txt");

            while (!sr.EndOfStream)  //trebamo ovaj while samom za SR jer on nezna kada tocno stati
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            Console.ReadKey();
        }
    }
}
