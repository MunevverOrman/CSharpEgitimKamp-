using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If

            //Console.Write("lütfen şifreyi girin:");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd" )
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, city;
            //Console.Write("lütfen bir başkent girin:");
            //capital = Console.ReadLine();

            //Console.Write("lütfen bir ülke girin:");
            //city = Console.ReadLine();

            //if (capital == "ankara" & city=="türkiye")
            //{
            //    Console.Write("doğru cevap");
            //}
            //else
            //{
            //    Console.Write("yanlış cevap");
            //}

            //int number;
            //Console.Write("lütfen bir sayı girin:");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5 )
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result;
            //result = ("hata");

            //Console.Write("lütfen 1. sınav notunu girin:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sınav notunu girin:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 3. sınav notunu girin:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması :" + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 85)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 85)
            //{
            //    result = "sonuç çok iyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();


            //string city;
            //Console.Write("lütfen şehir girişi yapınız:");
            //city= Console.ReadLine();


            //if (city == "adana" | city == "ankara" | city == "antalya")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adı giriniz:");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}
            #endregion

            #region mood işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.Sayının 2.sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}



            #endregion

            #region  Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}




            #endregion


            #region switch case 

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}


            #endregion


            #region hesap makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("birinci sayıyı girin");
            number1=int.Parse(Console.ReadLine());
            
            Console.Write("ikinci sayıyı girin");
            number2 =int.Parse(Console.ReadLine());

            Console.Write("işlem sembolünü girin");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("toplama işlemi sonucu: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("çıkarma işlemi sonucu: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("çarpma işlemi sonucu: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("bölme işlemi sonucu: " + result);
                    break;
                default:
                    Console.WriteLine("hatalı işlem");
                    break;
            }
      



            #endregion

        }
    }
}
