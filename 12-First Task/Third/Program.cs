using System;
using System.Collections.Generic;
using System.Linq;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir pozitif sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n Lütfen {sayi} adet kelime giriniz");
            List<String> kelimeler = Console.ReadLine().TrimEnd().Split(' ').ToList();
            kelimeler.Reverse();
            for (int i = 0; i < kelimeler.Count; i++)
            {
                Console.WriteLine($"kelime{i+1} = " + kelimeler[i]);
            }
        }
    }
}
