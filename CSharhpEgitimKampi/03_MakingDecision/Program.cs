using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen Şifreyi Giriniz: ");

            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //country = Console.ReadLine();
            //Console.Write("Şehiri Giriniz: ");
            //capital = Console.ReadLine();

            //if (country == "ankara" & capital == "türkiye")
            //{
            //    Console.WriteLine("Verileri Doğru Girdiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Hatalı!!!");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("Sayı Doğru!");
            //}
            //else {
            //    Console.WriteLine("Sayı Hatalı");
            //        }


            //int exam1, exam2, exam3, avarege;
            //string result = "Hata!";
            //Console.Write("Sınav1: "); 
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //avarege = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalaması: " + avarege);

            //if (avarege > 0 & avarege <= 50)
            //{
            //    result = "Vasat!";
            //}
            //if (avarege > 51 & avarege <= 80)
            //{
            //    result = "Ortalama";
            //}
            //if (avarege > 80)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine("Sınav Sonucunuz: " + result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();
            //if (city == "Gebze" | city == "Trabzon" | city == "Bursa")  
            //{
            //    Console.WriteLine("Girilen Şehir Mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Şehir Mevcut Değil");
            //}
            //string username;
            //Console.Write("Lütfen Bir Kullanıcı Adı Giriniz: ");
            //username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu Kullanıcı kabul edilemez!");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz!");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //    Console.WriteLine(result);

            //Console.Write("1.Sayıyı Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya Bölümünden Kalan: " + result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if(number%2==0 )
            //{
            //    Console.Write("Sayı çifttir!");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir!");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları 
            //char team;
            //Console.Write("Lütfen Takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team == 'G'|team== 'g')
            //{
            //    Console.Write("galatasaray");
            //}if(team == 'T' | team == 't')
            //{
            //    Console.Write("TRABZONSPOR");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.Write("beşiktaş");
            //}





            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** UmeyirSeray Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzallar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");                    
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçim: ");
            //menuItem= Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3-Tantuni");
            //    Console.WriteLine("4-İskender");
            //    Console.WriteLine("5-Kayseri Yağlaması");
            //    Console.WriteLine("----------Ana Yemekler----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tavuk Suyu Çorbası");
            //    Console.WriteLine("2-Mercimek Çorbası");
            //    Console.WriteLine("3-Kelle Paça Çorbası");
            //    Console.WriteLine("4-Tarhana Çorbası");
            //    Console.WriteLine("5-Yoğurt Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mozarellalı Pizza");
            //    Console.WriteLine("2-Jambonlu Pizza");
            //    Console.WriteLine("3-Sucuk Sever Pizza");
            //    Console.WriteLine("4-Karışık Pizza");               
            //    Console.WriteLine("----------Pizzalar----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-SU");
            //    Console.WriteLine("4-Sprite");
            //    Console.WriteLine("----------İçecekler----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Waffle");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine("4-Orman Meyveli Pasta");
            //    Console.WriteLine("----------Tatlılar----------");

            //    Console.WriteLine();

            //}



            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapını: ");
            //int mountNumber=int.Parse(Console.ReadLine());

            //switch (mountNumber) 
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı veri girişi!!"); break;
            //}





            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2=int.Parse(Console.ReadLine());

            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': 
                    result=number1 + number2; 
                    Console.WriteLine("Toplam: "+result); break;

                case '-':
                    result = number2 - number1;
                    Console.WriteLine("Kalan: " + result); break;
                 
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result); break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result); break;
                    
                    default:Console.WriteLine("Hatalı Sembol Girişi Yaptınız!!!"); break;
            }
           



            #endregion

            Console.Read();
        }
    }
}
