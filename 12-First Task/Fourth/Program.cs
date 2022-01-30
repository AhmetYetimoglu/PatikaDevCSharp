using System;
using System.Collections.Generic;
using System.Linq;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız!");
            string cumle = Console.ReadLine().TrimEnd();
            string harfSayisi = cumle.Replace(" ","");
            List<String> kelimeler = cumle.Split(' ').ToList();
            Console.WriteLine($"{kelimeler.Count} adet kelime vardır");
            Console.WriteLine($"{harfSayisi.Length} adet harf vardır");

        }
    }
}
