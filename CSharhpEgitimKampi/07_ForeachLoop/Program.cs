using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach (1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //In
            //Listenin koleksiyonu veya Dizinin adı

            //string[] cities = { "milano", "roma", "münih", "varşova", "trabzon", "gebze" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 41, 61, 55, 654564, 1335, 4884 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 41, 61, 55, 654564, 1335, 4884 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 41, 61, 55, 654564, 1335, 4884 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total +=i ;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıftaki öğrenci sayısını kull. alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaçtane öğrenci var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentsName=new string[studentCount];
            //double[] studentsExamAvg=new double[studentCount];

            //for(int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.Öğrencinin ismini giriniz: ");
            //    studentsName[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi
            //    for(int j=0; j < 3; j++)
            //    {
            //        Console.Write($"{studentsName[i]} adlı öğrencinin{j + 1}.sınav notunu girinz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value;//not toplama

            //    }
            //    Console.WriteLine();

            //    studentsExamAvg[i] = totalExamResult / 3;
            //}
            ////Sınav ortalamaları    
            //for(int i=0;i<studentCount;i++)
               
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentsName[i]} adlı öğrencinin ortalaması: {studentsExamAvg[i]}");

            //    //öğrencilerin ortalaması ve geçip kalma durumu
            //    if (studentsExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentsName[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentsName[i]} adlı öğrenci dersi geçemedi!!");
            //    }
            //    Console.WriteLine("------------------------------");
            //}





            #endregion




            Console.Read();

        }
    }
}
