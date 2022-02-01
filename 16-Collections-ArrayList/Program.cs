using System;
using System.Collections;
using System.Collections.Generic;

namespace _16_Collections_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namepsace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisinde verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("****** Add RANGE ******");
            string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayılar = new List<int>(){1,8,7,7,9,92,53};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search

            Console.WriteLine("****** Binary Search ******");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            
            //Clear
            liste.Clear();
        }
    }
}
