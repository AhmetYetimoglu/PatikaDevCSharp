using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            int y;
            for (int x = 0; x < 20; x++)
            {   
                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    while (sayi<0)
                    {
                        Console.WriteLine("Sayı 0 dan küçük olamaz!!");
                        break;
                    }
                    if(sayi == 1 || sayi==0)
                    {
                        asalOlmayan.Add(sayi);
                    }
                    if(sayi>=2)
                    {
                        for (y = 2; y < sayi; y++)
                        {
                            if(x%y == 0)
                            {
                                asalOlmayan.Add(sayi);
                                break;
                            }
                        }
                        if (y == sayi)
                        {
                            asal.Add(y);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Girilen değer sayı olmalıdır!!");
                }
            }
        
            Console.WriteLine("*****Asal Sayılar*****");
            int asalSayiToplami = 0;
            foreach (int item in asal)
            {
                asalSayiToplami +=item;
            }
            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
                Console.Write(item+" ");
            }
            double asalSayiOrtalama = Convert.ToDouble(asalSayiToplami)/Convert.ToDouble(asal.Count);
            Console.WriteLine();
            Console.WriteLine("Elemanların Ortalaması : "+asalSayiOrtalama);
            Console.WriteLine("Eleman Sayısı : "+asal.Count);
            Console.WriteLine();

            Console.WriteLine("*****Asal Olmayan Sayılar*****");
            int asalOlmayanSayiToplami = 0;
            foreach (int item in asalOlmayan)
            {
                asalOlmayanSayiToplami +=item;
            }
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            foreach (var item in asalOlmayan)
            {
                Console.Write(item+" ");
            }
            double asalOlmayanSayiOrtalama = Convert.ToDouble(asalOlmayanSayiToplami)/Convert.ToDouble(asalOlmayan.Count);
            Console.WriteLine();
            Console.WriteLine("Elemanların Ortalaması : "+asalOlmayanSayiOrtalama);
            Console.WriteLine("Eleman Sayısı : "+asalOlmayan.Count);
        }
    }
}
