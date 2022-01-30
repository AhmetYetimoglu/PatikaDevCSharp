using System;
using System.Collections.Generic;
using System.Linq;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif iki sayı giriniz");
            Console.Write("Birinci sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("İkinci sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Lütfen {sayi1} adet sayı giriniz.");
            List<int> sayilar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(p => Convert.ToInt32(p)).ToList();

            for (int i = 0; i < sayilar.Count; i++)
            {
                if((sayilar[i]==sayi2) || (sayilar[i]%sayi2==0))
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
        }
    }
}
