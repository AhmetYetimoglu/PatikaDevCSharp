using System;
using System.Collections.Generic;

namespace _17_Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(15,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");

            //Dizisinin elemanlarına erişim
            Console.WriteLine("****** Elemanlara Erişim ******");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Deniz Arda"));

            //Remove
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //keys
            Console.WriteLine("****** Keys ******");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);
            
            //values
            Console.WriteLine("****** Values ******");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);
        }
    }
}
