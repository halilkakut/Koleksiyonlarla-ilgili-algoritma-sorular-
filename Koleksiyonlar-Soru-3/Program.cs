using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız");

            Console.WriteLine("Lütfen Bir Cümle Giriniz:");
            string cumle = Console.ReadLine().ToLower();
            char[] sesli = {'a','e','ı','i','o','ö','u','ü'}; 
            List<char> sesliHarfler = new List<char>();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cumle[i] == sesli[j])
                    {
                        sesliHarfler.Add(cumle[i]);
                    }
                }
            }

            sesliHarfler.Sort();
            Console.WriteLine("Sesli Harflerin Sıralanmış Hali");
            sesliHarfler.ForEach(x=>Console.WriteLine(x));


        }
    }
}
