using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //customer-->listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Seray Seven");
            //    Console.WriteLine("Umeyir Bağcıoğlu");
            //    Console.WriteLine("Ömer Bağcıoğlu");
            //    Console.WriteLine("Seray Bağcıoğlu");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void wrtieMethods(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //wrtieMethods("Mehmet");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Umeyir","Bağıcoğlu");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int Result=number1 + number2+number3;
            //    Console.WriteLine(Result);
            //}
            //Sum(1, 5, 9);





            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Seray Seven";
            //}
            //CustomerName();

            //string StudentsCard()
            //{
            //    string name = "Umeyir";
            //    string surname = "Seray";
            //    return name+ " " + surname;
            //}
            //Console.WriteLine(StudentsCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital, string flagColor)
            //{
            //    string cardİnfo = "Ülke: " + countryName + " " + "Başkent: " + capital + " " + "Bayrak Rengi: " + flagColor;
            //    return cardİnfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Ülkenin Başkentini Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Ülkenin Bayrak Renklerini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));



            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(55, 61));
            //Console.WriteLine(Sum(41, 61));
            //Console.WriteLine(Sum(55, 65)); 
            //Console.WriteLine(Sum(41,99));








            #endregion

            #region Örnek Uygulama
            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " " + "İsimli Öğrenci Sınavı Geçti" + " " + "Ortalama: " + result;

                }
                else
                {
                    return student + " " + "İsimli Öğrenci Sınavdan Kaldı!!!!!!" + " " + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Umeyir", 61, 85, 100));
            Console.WriteLine(ExamResult("Seray", 55, 25, 15));



            #endregion



            Console.Read();
        }
    }
}
