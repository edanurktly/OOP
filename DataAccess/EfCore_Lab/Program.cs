using EfCore_Lab.Entities;

namespace EfCore_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            //var musteriler = context.Customers.ToList();
            #region Musterilerin Cirolarini Explist Loading ile cikartalim 

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine($"Musteri Adi:{musteri.CompanyName}   Ulke:{musteri.Country} Sehir:{musteri.City}");
            //    context.Entry(musteri).Collection(p => p.Orders).Load();

            //    foreach (var order in musteri.Orders)
            //    {
            //        context.Entry(order).Collection(p => p.OrderDetails).Load();

            //        foreach (var orderdetail in order.OrderDetails)
            //        {
            //            Console.WriteLine("\t\t\t\n");

            //            context.Entry(orderdetail).Reference(p => p.Product).Load();
            //            Console.WriteLine($@"urun :{orderdetail.Product.ProductName} Siparis Adedi:{orderdetail.Quantity}  Fiyat:{orderdetail.UnitPrice} Toplam Tutar:{orderdetail.UnitPrice * orderdetail.Quantity}");
            //        }


            //    }
            //}

            #endregion


            #region Calisanlarin Sipraislere gore cirolarini cikartin 

            var calisanlar= context.Employees.ToList();
            foreach (var calisan in calisanlar)
            {
                Console.WriteLine($"Calisan Adi:{calisan.FirstName} Calisan Soyad:{calisan.LastName} Ulke:{calisan.Country} Sehir:{calisan.City}");
                context.Entry(calisan).Collection(p=>p.Orders).Load();

                foreach (var  order in calisan.Orders)
                {
                    context.Entry(order).Collection(p => p.OrderDetails).Load();

                    foreach(var orderdetail in order.OrderDetails)
                    {
                        Console.WriteLine("\t\t\t\n");
                        context.Entry(orderdetail).Reference(p => p.Product).Load();
                        Console.WriteLine($@"urun :{orderdetail.Product.ProductName} Siparis Adedi:{orderdetail.Quantity}  Fiyat:{orderdetail.UnitPrice} Toplam Tutar:{orderdetail.UnitPrice * orderdetail.Quantity}");
                    }
                }
            }






            /*
 
   Calisan Adi:Nancy Davalio    Ulke : USA Sehir : Newyork
        siparis Tarihi 01.01.1996 olan 1256 numarali siparisin detaylari asagidadir 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
        siparis Tarihi 01.01.1996 olan 1256 numarali siparisin detaylari asagidadir 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
 */
            #endregion




            /*

               Musteri Adi    Ulke : USA Sehir : Newyork
                    siparis Tarihi 01.01.1996 olan 1256 numarali siparisin detaylari asagidadir 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                    siparis Tarihi 01.01.1996 olan 1256 numarali siparisin detaylari asagidadir 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
                            Siparis Verilen Urun : Ekmek     siprais Adedi : 10 Fiyat : 5 Toplam Tutar : 50 indirim : discount :0.9 Indirimli Toplam Tutar : 45 TL 
             */
        }
    }
}