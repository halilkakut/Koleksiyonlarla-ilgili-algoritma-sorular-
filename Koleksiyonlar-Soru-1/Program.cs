using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız!!!

            ArrayList numberPrimeList = new ArrayList();
            ArrayList numberNotPrimeList = new ArrayList();
            ArrayList numberList = new ArrayList();
            Console.WriteLine("Klavyeden 20 adet pozitif numeric sayı giriniz:");

            for (int i = 0; i < 20; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 1 || number < 1){
                    Console.WriteLine("Lütfen Pozitif bir Sayı veya 1 den büyük  Girin!");
                }else{
                    numberList.Add(number);
                }
            }
            
            
            for (int i = 0; i < numberList.Count; i++)
            {
                bool prime = true;
                for (int j = 2; j < ((int)numberList[i]); j++)
                {
                    if((int)numberList[i] % j == 0){
                        prime = false;
                        break;
                    }
                    
                }
                if(prime == false){
                    numberNotPrimeList.Add((int)numberList[i]);
                }else{
                    numberPrimeList.Add((int)numberList[i]);
                }
                
            }
           
            numberPrimeList.Reverse();
            Console.WriteLine("***********Asal Sayı Listesi*************");
            foreach (var item in numberPrimeList)
                Console.WriteLine(item);

            numberNotPrimeList.Reverse();
            Console.WriteLine("***********Asal olmayan Sayı Listesi*************");
            foreach (var item in numberNotPrimeList)
                Console.WriteLine(item);

            Console.WriteLine("***********Asal  Sayı dizinin eleman sayısını ve ortalaması *************");
            int numberPrimeListCount = numberPrimeList.Count;
            Console.WriteLine("Asal  Sayı dizinin eleman sayısı:" + numberPrimeListCount);
            int sumPrimeList = 0;
           
            foreach (var item in numberPrimeList)
            {
                sumPrimeList+=(int)item;
            }

            int averagePrimeList = sumPrimeList / numberPrimeListCount;
            Console.WriteLine("Asal  Sayı dizinin ortalaması:" +averagePrimeList);
            

            Console.WriteLine("***********Asal olmayan Sayı dizisinin eleman sayısını ve ortalaması *************");
            int numberNotPrimeListCount = numberNotPrimeList.Count;
            Console.WriteLine("Asal olmayan  Sayı dizinin eleman sayısı:" + numberNotPrimeListCount);
            int sumNotPrimeList = 0;
           
            foreach (var item in numberNotPrimeList)
            {
                sumNotPrimeList+=(int)item;
            }

            int averageNotPrimeList = sumNotPrimeList / numberNotPrimeListCount;
            Console.WriteLine("Asal  Sayı dizinin ortalaması:" +averageNotPrimeList);
        }
    }
}
