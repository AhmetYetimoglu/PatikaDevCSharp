using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            string[] kelimeler = Console.ReadLine().TrimEnd().Split(" ");
            int sesliHarfSayisi = 0;
            foreach (var item in kelimeler)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if(item[i]=='a' || item[i]=='e' || item[i]=='ı' || item[i]=='i' || item[i]=='o' || item[i]=='ö' || item[i]=='u' || item[i]=='ü')
                        sesliHarfSayisi++;
                }
            }
            char[] sesliHarfler = new char[sesliHarfSayisi];
            string tekKelime ="";
            int artanIndex = 0;
            foreach (var item in kelimeler)
            {
                tekKelime+=item;
            }
            for (int i = 0; i < tekKelime.Length; i++)
            {
                if(tekKelime[i]=='a' || tekKelime[i]=='e' || tekKelime[i]=='ı' || tekKelime[i]=='i' || tekKelime[i]=='o' || tekKelime[i]=='ö' || tekKelime[i]=='u' || tekKelime[i]=='ü'){
                    sesliHarfler[artanIndex] = tekKelime[i];
                    artanIndex++;
                }
            }
            foreach (var item in sesliHarfler)
            {
                Console.Write(item);
            }
            
        }
    }
}
