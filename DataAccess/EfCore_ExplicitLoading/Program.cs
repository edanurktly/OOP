using EfCore_ExplicitLoading.Entities;

namespace EfCore_ExplicitLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            var urun = context.Products.FirstOrDefault
                (p => p.ProductId == 1);
            /*
             Explicit Loading: olusturulan sorguya eklenecek verilerin sartlara bagli olarak, ihtiyaclara istinaden yüklenmesi olayini gerceklestiren bir yaklasimdir.
             */

            /*
             Buarada baska kodalr oldugunun farzedelim
             */

            //gere bulunan entity'nin daha sonrasinda siparislerini istersek eger asagidaki gibi bir calisma yapmamiz gerekir.

            //if (urun.ProductId== "Nancy")
            //{
            //    var siparisleri = context.OrdersDetails.Where(o => o.ProductId == 1).ToList();
            //     foreach(var item in siparisleri)
            //    {
            //        Console.WriteLine(item.OrderId+" "+item.UnitPrice+" "+item.Quantity);
            //    }
            //}

            #region Referans

            //Exlicit Yaklasimda iliskisel olarak sorguya eklenmek istenen tablonun navigation propert'si eger ki tekil ise referans metodu kullanin. Sonrasinda Load Etmeyi unutmayin.
            //context.Entry(urun).Reference(p=>p.Category).Load();
            //context.Entry(urun).Reference(p => p.Supplier).Load();



            //Console.WriteLine(urun.Category.CategoryName+" "+ urun.Supplier.ContactName);


            #endregion

            #region Collection Oldugu Durumlarda
            //Exlicit Yaklasimda iliskisel olarak sorguya eklenmek istenen tablonun navigation propert'si eger ki cogul /ICollection ise referans metodu kullanin.Collection Metodu kullanilir.Sonrasinda Load Etmeyi unutmayin.

            //not:Entry giris demek

            //context.Entry(urun).Collection(p=>p.OrderDetails).Load();

            //foreach (var  orderDetail in urun.OrderDetails.ToList())
            //{
            //    Console.WriteLine("Fiyat: "+orderDetail.UnitPrice+" Adet:"+orderDetail.Quantity);
            //}
            #endregion

            #region Collection,lar uzerinde Aggregate Operator uygulamak

            //var kayitsayisi= context.Entry(urun).Collection(p => p.OrderDetails).Query().Count();

            // var ciro = context.Entry(urun).Collection(p => p.OrderDetails).Query().Sum(p=>p.Quantity*p.UnitPrice);


            // Console.WriteLine("Kayit Sayisi "+kayitsayisi+ "Ciro "+ciro.ToString("C2"));

            #endregion

            #region Collection'lara Filtre Uygulamak
            //50 dolardan yuksek olan urunlerin satis cirosu

            //var sonuc = context.Entry(urun).Collection(p => p.OrderDetails).Query().Where(p => p.Quantity > 5).Sum(p => p.Quantity * p.UnitPrice);
            //Console.WriteLine("Sonuc:" +sonuc);
            #endregion
         
            









            Console.WriteLine("Hello, World!");
        }
    }
}