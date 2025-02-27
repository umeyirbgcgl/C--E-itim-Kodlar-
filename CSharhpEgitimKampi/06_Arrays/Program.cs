using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2,4,6,8
            //Bordo,Mavi,Turuncu,Beyaz
            //Trabzon,Gebze,İstanbul

            //DeğişkenTürü [] diziAdı =new değişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Beyaz";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[3];
            //cities[0] = "Trabzon";
            //cities[1] = "Kocaeli";
            //cities[2] = "İstanbul";
            //Console.WriteLine(cities[0]);a

            //int[] numbers = new int[10];
            //numbers[0] = 62;
            //numbers[1] = 48;
            //numbers[2] = 56;
            //numbers[3] = 10;
            //numbers[7] = 862;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Bordo", "Mavi", "Beyaz","Turuncu","Yeşil","Siyah","Pembe" };

            //for(int i=0;i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //} 

            //int[] numbers = { 61, 55, 41, 30, 6161, 8655, 6155, 4864165, 55648 };

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 61, 55, 758, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i]; 
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Umeyir", "Seray", "Ömer" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 61, 85, 55, 98, 75 };
            //Array.Sort(numbers);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 61, 85, 55, 98, 75 };
            //Array.Reverse(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "Umeyir", "Seray", "Ömer", "Ali" };
            //int index = Array.IndexOf(customers, "Seray");
            // Console.WriteLine(index);  

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "Dizinin En Küçük Elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //for(int i=0;i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);  

            //int[] numbers = { 21, 42, 43, 74, 55, 76, 37, 18, 69, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
