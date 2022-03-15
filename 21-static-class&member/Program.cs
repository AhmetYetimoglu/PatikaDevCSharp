using System;

namespace _21_static_class_member
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","yılmaz","ik");

            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonuuc {0}",Islemler.topla(100,200));
            Console.WriteLine("Çıkarma islemi sonuuc {0}",Islemler.cikar(1000,200));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }
    }  
    static class  Islemler
    {
        public static long topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }        
    }
}
