using System;

namespace _20_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }

        class Ogrenci
        {
            private string isim;
            private string soyad;
            private int ogrenciNo;
            private int sinif;

            // public string Isim1 { get => isim; set => isim = value; }
            public string Isim 
            {
                 get {return isim;} 
                 set {isim = value;}
            }

            public string Soyad { get => soyad; set => soyad = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
            public int Sinif 
            { 
                get => sinif; 
                set {
                    if(value<=1)
                    {
                        Console.WriteLine("Sınıf En AZ 1 Olabilir!");
                        value = 1;
                    }
                    else
                        sinif = value;
                    }
            }

            public Ogrenci(){}

            public Ogrenci(string isim, string soyad, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyad = soyad;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("******Öğrenci Bilgileri******");
                Console.WriteLine("Öğrenci Adı: {0}",this.Isim);
                Console.WriteLine("Öğrenci Soyadı: {0}",this.Soyad);
                Console.WriteLine("Öğrenci NO: {0}",this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıfı: {0}",this.Sinif);
            }
            
            public void SinifAtlat()
            {
                this.Sinif = this.Sinif+1;
            }
            public void SinifDusur()
            {
                this.Sinif = this.Sinif-1;
            }

        }
    }
}
