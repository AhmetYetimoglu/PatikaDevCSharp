using System;

namespace _19_Struct
{
    class Program
    {
        // Struct ile Class arasındaki önemli farklardan biri Constructor'dır.
        // Struct ile boş bir constructur oluşturulamaz. Class'ta oluşturulur.
        // Eğer Class içindeki değişkenlere değer atanmadıysa o değişkenlere initial değer atanır ve işlem görür.
        // Structa ise değişkenlere değer atanmadığı zaman initial değer almazlar.
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            
            Console.WriteLine("Class Alan Hesabı : {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            
            Console.WriteLine("Struct Alan Hesabı : {0}",dikdortgen_struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        
        }
    }
}
