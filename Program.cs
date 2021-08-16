using System;
using System.Collections;
using System.Collections.Generic;



namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList() ;
            // liste.Add("Merve") ;
            // liste.Add("22") ;
            // liste.Add(true) ;
            // liste.Add('A') ;

            // //İÇERİDEKİ VERİLERE ERİŞİM

            // Console.WriteLine(liste[1]) ;

            foreach (var item in liste)
            {
                Console.WriteLine(item) ;
            }

            //AdRange
            // string[] renkler = {"Kırmızı","Sarı","Yeşil"} ;
            List<int> sayılar = new List<int> () {2,57,8,98,45} ;

            // liste.AddRange(renkler) ;
            liste.AddRange(sayılar) ;

            foreach (var item in liste)
            {
                Console.WriteLine(item) ;
            }

            //Sort
            Console.WriteLine("***SORT***") ;
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item) ;
            }

            Console.WriteLine("***Binary Search***") ;
            Console.WriteLine(liste.BinarySearch(57)) ;

            Console.WriteLine("***Reverse***") ;
            liste.Reverse() ;
            foreach (var item in liste)
            {
                Console.WriteLine(item) ;
            }

        }
    }
}