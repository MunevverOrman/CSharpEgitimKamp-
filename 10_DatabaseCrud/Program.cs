using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori ekleme işlemi
            ////CRUD->Create - Read - Update - Delete

            Console.WriteLine("***** Menü İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            //#region Veri Tabanına Kategori Ekleme

            //Console.Write("eklenecek kategori adı: ");
            //string categoryname = Console.ReadLine();

            //SqlConnection Connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
            //    "integrated security = true");
            //Connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", Connection);
            //command.Parameters.AddWithValue("@p1", categoryname);
            //command.ExecuteNonQuery();
            //Connection.Close();

            //Console.Write("kategori eklendi");

            #endregion

            #region Veri Tabanına Ürün Ekleme

            // string productName;
            // decimal productPrice;
            // bool productStatus;

            // Console.Write("eklenecek ürün adı: ");
            // productName = Console.ReadLine();
            // Console.Write("ürün fiyatı: ");
            // productPrice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
            //     "integrated security = true");
            //connection.Open();

            // SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) " +
            //     "values (@productName, @productPrice, @productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();
            // connection.Close();

            // Console.Write("ürün eklendi");

            #endregion

            #region Veri Tabanından Ürün Listeleme

            //SqlConnection connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
            //  "integrated security = true"); //bağlantı oluşturuldu
            //connection.Open(); //bağlantı açıldı
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //sorgu yazıldı
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //köprü oluşturuldu
            //DataTable dataTable= new DataTable(); // tablo oluşturuldu
            //adapter.Fill(dataTable); //tablo içi dolduruldu

            //foreach (DataRow row in dataTable.Rows) //tablonun sütunları çekildi
            //{
            //    foreach (var item in row.ItemArray) //sütunlar içindeki veriler alındı
            //    {
            //        Console.Write(item.ToString() + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme

            //Console.Write("Silinecek ürün: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
            //  "integrated security = true"); 
            //connection.Open(); 
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün Silindi");

            #endregion

            #region Ürün Güncelleme

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek Ürün Fİyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("data source= DESKTOP-I05VV5A; initial catalog = EğitimKampiDB; " +
             "integrated security = true"); 
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName," +
                "ProductPrice = @productPrice Where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün Güncellendi");

            #endregion

            Console.Read();
        }
    }
}
