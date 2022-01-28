using System;

namespace Recursive_ve_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive - Öz yinelemeli
            // 3^4 = 3*3*3*3

            int result =1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // Extension Metotlar

            string ifade = "Türkiyenin Başkenti Ankaradır";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,3,6,2,15,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi5 = 5;
            Console.WriteLine(sayi5.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public static class Extensions{
        public static bool CheckSpaces(this string param1)
        {
            return param1.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param1)
        {
            string[] dizi = param1.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param1)
        {
            return param1.ToUpper();
        }

        public static string MakeLowerCase(this string param1)
        {
            return param1.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int öz)
        {
            if(öz<2)
                return sayi;

            return Expo(sayi,öz-1)*sayi;
        }
    }
}
