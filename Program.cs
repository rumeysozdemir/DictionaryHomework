using System;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> AdYas = new MyDictionary<int, string>();
            AdYas.Add(15, "Arda");
            AdYas.Add(20, "Beyza");

           
        }

    }
    class MyDictionary <T,U>
    {
        T[] yas;
        U[] ad;
       
        public MyDictionary()
        {
            yas = new T[0];
            ad = new U[0];
        }

        public void Add(T key, U value)
        {
       
           
            T[] tempKeys = yas;
            U[] tempValues = ad;

            yas = new T[yas.Length + 1];
            ad = new U[ad.Length + 1];


            for (int i = 0; i < tempKeys.Length; i++)
            {
                yas[i] = tempKeys[i];
                ad[i] = tempValues[i];
            }

            yas[yas.Length - 1] = key;
            ad[ad.Length - 1] = value;

            Console.ReadLine();

        }

    }

}
