using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            // Console.OutputEncoding = System.Text.Encoding.Unicode;
            // double number;
            // number = 5.61;
            // Console.WriteLine(number);  

            // Console.WriteLine("***** Fiyat Listesi *****");
            // Console.WriteLine();

            // double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            // applePrice = 14.80;
            // orangePrice =12.30;
            // strawberryPrice = 15.20;
            // patatoPrice = 18;
            // tomatoPrice = 19.13;

            // Console.WriteLine("----- Elma Birim Fiyatı:" + applePrice + "₺");
            // Console.WriteLine("----- Portakal Birim Fiyatı:" + orangePrice + "₺");
            // Console.WriteLine("----- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            // Console.WriteLine("----- Patates Birim Fiyatı:" + patatoPrice + "₺");
            // Console.WriteLine("----- Domates Birim Fiyatı:" + tomatoPrice + "₺");
            // Console.WriteLine("-------------------------------------------------------");
            // double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            // appleGram = 1.230;
            // orangeGram = 1.380;
            // strawberryGram = 0.805;
            // patatoGram = 2.200;
            // tomatoGram = 2.250;



            // double appleTotalPrice = appleGram * applePrice;
            // Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice + "₺");
            // double orangeTotalPrice = orangeGram * orangePrice;
            // Console.WriteLine("Portakalın Toplam Fiyatı: " + orangeTotalPrice + "₺");
            // double strawberryTotalPrice = strawberryGram * strawberryPrice;
            // Console.WriteLine("Çileğin Toplam Fiyatı: " + strawberryTotalPrice + "₺");
            // double patatoTotalPrice = patatoGram * patatoPrice;
            // Console.WriteLine("Patatesin Toplam Fiyatı: " + patatoTotalPrice + "₺");
            // double tomatoTotalPrice = tomatoGram * tomatoPrice;
            // Console.WriteLine("Domatesin Toplam Fiyatı: " + tomatoTotalPrice + "₺");
            // Console.WriteLine("--------------------------------------------------------");

            // double toplamFiyat;
            // toplamFiyat = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Ürünlerin Toplam Fiyatı: "+toplamFiyat);






            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity;
            //int passangerAge, passangerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine("Yolcu Bilgileri: " + passangerName + " " + passangerSurname + "/" + passangerDistrict
            //    + " " + passangerCity + "/" + passangerAge + "/" + passangerIdentityNumber);






            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Döüşümler
            ////ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 5200;
            //computerPrice = 10000;
            //chairPrice = 1000;
            //tvPrice = 8500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount =int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------");
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.Write("Sepetinizin Toplam Tutarı: " + totalPrice + "TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Sonucu Ortalamanız: " + result);





            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
             


            #endregion
            Console.Read();
        }
    }
}
