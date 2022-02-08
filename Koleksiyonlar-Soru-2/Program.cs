using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
            // (Array sınıfını kullanarak yazınız.)
            List<int> liste = new List<int>();
            liste = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(p=> Convert.ToInt32(p)).ToList();
            liste.Sort();
            int[] sayilar = liste.ToArray();
            int[] ilkUc = new int[3];
            int[] sonUc = new int[3];
            for(int i = 0; i<3; i++)
            {
                ilkUc[i] = sayilar[i];
            }
            for (int i = 0; i < 3; i++)
            {
                sonUc[i] = sayilar[(sayilar.Count())-(1+i)];
            }
            double ilkUcOrtalama = ilkUc.Average();
            double sonUcOrtalama = sonUc.Average();
            int ilkUcToplamSayi = 0;
            int sonUcToplamSayi = 0;
            foreach (var item in ilkUc)
            {
                ilkUcToplamSayi+=item;
            }
            foreach (var item in sonUc)
            {
                sonUcToplamSayi+=item;
            }
            Console.WriteLine($"en küçük üç sayının toplamları: {ilkUcToplamSayi} ve en küçük üç sayının toplamlarının ortalamaları: {ilkUcOrtalama}");
            Console.WriteLine($"en büyük üç sayının toplamları: {sonUcToplamSayi} ve en büyük üç sayının toplamlarının ortalamaları: {sonUcOrtalama}");
        }
    }
}
