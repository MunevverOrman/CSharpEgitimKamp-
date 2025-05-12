using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veri tabanlı ürün kategori bilgi sistemi uygulaması
            Console.WriteLine("***** c# veri tabanlı ürün kategori bilgi sistemi *****");
            Console.WriteLine();

            string tablenumber;

            Console.WriteLine("--------------------------------------------------");

            // kategori seçimi
            Console.WriteLine("1-kategoriler");
            Console.WriteLine("2-ürünler");
            Console.WriteLine("3-siparişler");
            Console.WriteLine("4-çıkış yap");
            Console.Write("lütfen  tablo numarasını giriniz: ");
            tablenumber = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------");

            //veri tabanı işlemleri
            SqlConnection connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
                "integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            //veri tabanındaki verilerin kullanılması (ekranda ilgili bilgileri gösterme)
            foreach (DataRow row in datatable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            connection.Close();

            Console.Read();



        }
    }
}
 