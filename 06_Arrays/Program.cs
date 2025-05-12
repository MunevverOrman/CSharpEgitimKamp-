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
            #region temel dizi örnekleri 

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Bursa";
            //cities[4] = "Antalya";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[3] = 3;
            //numbers[6] = 4;
            //numbers[8] = 5;
            //Console.WriteLine(numbers[5]); //tanımlanmayan bir değerde default gözükür.

            //string[] cities = { "atina", "prag", "ankara" };
            //Console.WriteLine(cities[2]);





            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = { "kırmızı", "mavi", "beyaz", "gri" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 85, 76, 852, 96 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }



            //char[] symbols = { 'a', 'c', '%', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            // Console.WriteLine(symbols[i]);
            //}



            #endregion


            #region dizi metotları 

            //string[] customers = { "ali", "buse","şengül", "ahmet" };
            //int index = Array.IndexOf(customers, "ali");
            //Console.WriteLine(index);

            //int[] numbers= { 1, 2,45,86,98 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() + "dizinin en küçük elemanı:" + numbers.Min()); 



            #endregion


            #region kullanıcıdan dizi oluşturma için veri alma 

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1} .şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = {21,23,45,69,78,76,74,85};

            //Console.WriteLine();
            //Console.WriteLine("çiftt sayılar");
            //Console.WriteLine("------------------------");



            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("tek sayılar");
            //Console.WriteLine("------------------------");


            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            


            #endregion

        }
      }
    }

