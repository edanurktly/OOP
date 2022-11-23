using EfCore_RelatedData.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore_RelatedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            #region Eager Loading
            //Eager Loading Generate Edilen Sorguya ilişkisel verilerin parca parca eklenmesi ni saglayan
            //ve bunu yaparken de iradeli/istekli bir sekilde yapmamizi saglayan bir yontemdir.
            // var calisanlar = context.Employees.ToList();

            #region Include 
            // Olusturulan sorguya iliskili verileri dahil edilmesini saglayan metotdur
            // 1. Yontem. Include metot una string ifade gecilerek yapilir
            //var calisanlar2 = context.Employees.Include("Orders").ToList();

            //2 Yontem ise

            //var calisanlar3 = context.Employees
            //    .Where(e=> e.Orders.Count>10)
            //    .Include(p=>p.Orders)
            //    .ToList();


            #endregion

            #region ThenInclude
            /*
             ThenInclude urewtilen sorguda include edilen tablolarin iliskili oldugu diger tablolarida 
             Sorguya ekleyebilmek icin kullanilan Metot'tur
            Eger ki include ediln navigation propertisi kolleksiyonel bir yapiya sahipse . 
            o tablodaki iliskili diger verileri getirmeye yarar.
             */


            //var musteriler = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(e => e.OrderDetails)
            //    .ToList();
            #endregion

            //Musterilerin siparisler ,
            //siparislerin detaylari ve detaydaki urunleri getirir
            //var musteriler2 = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(e => e.OrderDetails)
            //    .ThenInclude(p=>p.Product)
            //    .ToList();


            #endregion


            #region 1997 yilida alinmis siparisler ,detaylariyla beraber sorgulayin
            //var sonuclar = context.Orders
            //                        .Where(p => p.OrderDate.Value.Year == 1997)
            //                        .Include(p => p.OrderDetails)
            //                        .ThenInclude(p=>p.Product)
            //                        .ToList();
            //foreach (var item in sonuclar)
            //{
            //    Console.WriteLine(item.OrderId + " " + item.OrderDate + " "+ item.ShipCountry+ " " + item.ShipCity);
            //    foreach (var detay in item.OrderDetails)
            //    {
            //        Console.WriteLine(detay.Product.ProductName + " " + detay.UnitPrice+ " " + detay.Quantity);
            //    }

            //    global::System.Console.WriteLine("---------------------------");
            //}

            #endregion


            #region Musterilerin Siparis Adetleri nedir

            //var musteriler = context.Customers.Include(p=>p.Orders).ToList();   

            //foreach (var musteri in musteriler) 
            //{
            //    global::System.Console.WriteLine(musteri.CompanyName + "   "  + musteri.Country );
            //    var siparisSayisi = musteri.Orders.Count;
            //    global::System.Console.WriteLine("Toplam Siparis Sayisi:"+siparisSayisi);
            //}

            #endregion
            #region Musterilerin Siparis Cirolari nedir ?

            // Query syntax
            //var musteriler = (from cust in context.Customers
            //                 join order in context.Orders on cust.CustomerId equals order.CustomerId
            //                 join dt in context.OrderDetails on order.OrderId equals dt.OrderId
            //                 where order.OrderDate.Value.Year == 1997
            //                 select  cust).ToList();

            //Metot Syntax



            #region Filtered Include
            //Metod Syntax
            //var musteriler2 = context.Customers
            //                    .Include(p => p.Orders.Where(t => t.OrderDate.Value.Year == 1997))
            //                    .ThenInclude(p => p.OrderDetails)
            //                    .ToList();
            //decimal ciro = 0;
            //foreach ( var cust in musteriler2.ToList() ) 
            //{


            //    foreach (var item in cust.Orders)
            //    {
            //        foreach (var item2 in item.OrderDetails)
            //        {
            //            ciro += (item2.UnitPrice * item2.Quantity);

            //        }
            //    }
            //    Console.WriteLine(cust.CustomerId + " "+cust.CompanyName + " "+ cust.Country +" Ciro:" + ciro);

            //    ciro = 0;
            //}


            #endregion

            #region EagerLoadin ile ilgili ek bilgi.

            /*
             Eger Daha onceden calistirilmis sorgumuz hafizada var ise
              EfCore Gerekli iliskileri kurark size include islemi yapmadan verileri sunacaktir.
             */

            //var sipdetay = context.OrderDetails.ToList();
            //var siparisler = context.Orders.ToList();
            //var musteriler = context.Customers.ToList();


            //var sorgu = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(l => l.OrderDetails)
            //    .ToList();

            #endregion


            #region AutoInclude EfCore-6
            /*
             DbContext nesnesi icerisinde gerekli tanimlamalar yapilmalidir.
             */
            // var urunler = context.Products.ToList();

            #endregion

            #region IgnoreAutoInclude

            var urunler = context.Products.IgnoreAutoIncludes().ToList();
            #endregion

            #region Musterilerin siparis Cirolari Nedir?

            #endregion

            #region Kategorilerin Cirolari Nedir?

            var kategoriler = (from cate in context.Categories
                            join Product in context.Products on cate.CategoryId equals Product.CategoryId 

                       join dt in context.OrderDetails on Product.ProductId equals dt.ProductId
                               select cate)
                       .ToList();


            var kategori = context.Categories
                .Include(p => p.Products)
                .ThenInclude(p => p.OrderDetails)
                .ToList();

            decimal ciro = 0;
            foreach ( var item in kategori ) 
            {

                foreach (var item1 in item.Products)
                {
                    foreach (var item2 in item1.OrderDetails)
                    {
                        ciro += (item2.Quantity * item2.UnitPrice);
                    }
                }
                Console.WriteLine("KATEGORİ "+item.CategoryName);
                Console.WriteLine(ciro);
                ciro = 0;
            }


            #endregion

            #region Kargo Firmalarinin Tasidigi Siparis Sayisi Nedir?
           
           // var kargo=context.Shippers.
           //     Include(p=>p.Orders)
           //       .ThenInclude(p => p.OrderDetails)
           //     .ToList();
           //int siparisSayisi = 0;
           // foreach (var item in kargo)
           // {
           //     foreach(var item1 in item.Orders)
           //     {
           //         foreach (var item2 in item1.OrderDetails)
           //         {
           //             siparisSayisi += (item2.Quantity * item2.UnitPrice);
           //         }
           //     }
           //     Console.WriteLine("Sipariş"+ item.CompanyName);
           //     siparisSayisi = 0;
           // }

                                  #endregion

                                  #region Calisanlarin Aldigi Toplam Siparis Sayisi Nedir?

                                  #endregion

                                  #region Calisanlarin Toplam Cirolari Nedir?

                                  #endregion

                                  #region Urunlerin Satis Adetleri ve Cirolari nedir?

                                  #endregion
                                  #endregion
            Console.WriteLine("Hello, World!");
            }
        }
    }
