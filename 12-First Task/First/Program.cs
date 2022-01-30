using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lütfen {sayi} adet sayı giriniz.");
            List<int> sayilar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(p => Convert.ToInt32(p)).ToList();
            for (int i = 0; i < sayilar.Count; i++)
            {
                if(sayilar[i]%2 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
        }
    }
}
