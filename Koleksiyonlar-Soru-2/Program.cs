using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[20];
           
            for (int i = 0; i < 20; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numberArray[i] = number;
            }

            List<int> numberList = new List<int>(numberArray);
            numberList.Sort();
            
            List<int> minThreeNumbers = new List<int>(); 
            int sumMinThreeNumber = 0;
            for (int i = 0; i < 3; i++)
            {
                minThreeNumbers.Add(numberList[i]);
                sumMinThreeNumber += numberList[i];
            }
            Console.WriteLine("****** Minumum 3 Sayı ******");
            minThreeNumbers.ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("*********** En Küçük 3 tane sayı ortalama**********");
            int averageMinNumber = sumMinThreeNumber / 3;
            Console.WriteLine("Minumum Sayıların ortalaması : " +averageMinNumber);


            numberList.Reverse();
            List<int> max3Numbers = new List<int>();
            int sumMaxThreeNumber = 0;
            for (int i = 0; i < 3; i++)
            {
                max3Numbers.Add(numberList[i]);
                sumMaxThreeNumber += numberList[i];
            }
            Console.WriteLine("****** En Büyük  3 Sayı ******");
            max3Numbers.ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("*********** En Büyük 3 tane sayı ortalama**********");
            int averageMaxNumber = sumMaxThreeNumber / 3;
            Console.WriteLine("Minumum Sayıların ortalaması : " +averageMaxNumber);

            // max3Numbers.Clear();
            // minThreeNumbers.Clear();
        }
    }
}
