using System;
using System.Collections.Generic;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> YasAd= new MyDictionary<int, string>();
            
            YasAd.Add(15, "Arda");
            YasAd.Add(20, "Beyza");

            var ad = YasAd.Adlar;
            var yas = YasAd.Yaslar;   //  \n = alt alta yazdırıyor \t = yan yana yazdırıyor.

            for (int i = 0; i < ad.Length; i++)
            {
                Console.WriteLine($"Ad: {ad[i]} \t Yas:{yas[i]}");

            }

            //foreach (var ad in YasAd.Adlar)
            //{
            //    Console.WriteLine("Ad: " + ad);
            //}
            //foreach (var yas in YasAd.Yaslar)
            //{
            //    Console.WriteLine("Yaş: " + yas);
            //}
        }


    }
    class MyDictionary <T,U>
    {
         T[] yaslar;
         U[] adlar;
        


    public MyDictionary()
        {
            yaslar = new T[0];
            adlar = new U[0];
        }

        public void Add(T yas, U ad)
        {
       
           
            T[] tempArray = yaslar;
            yaslar = new T[yaslar.Length + 1];

            U[] tempArray2 = adlar;

            adlar = new U[adlar.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                yaslar[i] = tempArray[i];
               
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                adlar[i] = tempArray2[i];
            }

            yaslar[yaslar.Length - 1] = yas;
            adlar[adlar.Length - 1] = ad;

            
            

        }



        public int Length
        {
            get { return yaslar.Length; }
        }
        public int Length1
        {
            get { return adlar.Length; }
        }

        public T[] Yaslar
        {
            get { return yaslar; }
        }
        public U[] Adlar
        {
            get { return adlar; }
        }


    }

}
