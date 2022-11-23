using EfCoreQuery.Entities;

namespace EfCoreQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            #region Tablolarla Sorgulama

            #region Standart Sorgulama
            // Method Syntax 

            //var employees = context.Employees;
            //employees.ToList();

            ////Query Syntax 
            ////burasi sorguyu hazirlar
            //var sonuc = from emp in context.Employees select emp;

            //Tlist ise olusan sorguyu database'de calistirir
            //sonuc.ToList().ForEach(p => Console.WriteLine(p.FirstName+ " "+p.LastName)); 

            //foreach(var emp in employees)
            //{
            //    Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //}

            #endregion

            #region Where Sarti

            //Method Yontemi

            //var sonuclar = context.Employees.Where(p=>p.FirstName.Contains("a"));
            //var sonuclar=context.Employees.Where(p=>p.FirstName.Contains("a") p.BirthDate.Value.Year>= 1960);

            //Console.WriteLine("Bir Harf Giriniz");
            //var harf = Console.ReadLine();

            //sonuclar.Where(p => p.FirstName.Contains(harf));

            //Console.WriteLine("Bir Yil Giriniz");
            //var yil = Console.ReadLine();
            //sonuclar.Where(p => p.BirthDate.Value.Year >= int.Parse(yil));

            //@uery Yontemi
            //var sonuc2 = from emp in context.Employees
            //             where emp.FirstName.Contains("a") && emp.BirthDate.Value.Year>=1960
            //             select emp;
            //foreach (var p in sonuclar.ToList())
            //{
            //    Console.WriteLine(p.FirstName + "" + p.LastName);
            //}
            #endregion

            #region OrderBy
            //Normal Order By
            //var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ToList();

            //Birden fazla kolona gore order by calismasi
            var sonuclar2 = context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ThenBy(p=>p.EmployeeId).ToList();

            //Quet Snytax

            //var employees = from emp in context.Employees
            //                orderby emp.FirstName, emp.EmployeeId
            //                select emp;

            //foreach(var p in employees.ToList())
            //{
            //    Console.WriteLine(p.EmployeeId+" "+p.FirstName+" "+p.LastName);
            //}

            #endregion

            #region OrderByDescending

            //Metod yontemi
            var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a")).OrderByDescending(p => p.LastName).ToList();
            // birden fazla kolona gore order by calismasi
            //var sonuclar2=context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ThenBy(p=>p.EmployeeId).ToList();

            //Query SNYTAX

            var employees = from emp in context.Employees
                            orderby emp.FirstName descending
                            select emp;

            foreach(var p in employees.ToList())
            {
                Console.WriteLine(p.EmployeeId+"" + p.FirstName+""+p.LastName);
            }
            #endregion

            #region Tekil Veri Getiren Sorgulama Fonksiyonlari

            //Yapilan sorguda sadece bir tek verinin gelmesini istiyorsak Single yada SingleOrDefault Metodlari kullanilir

            #region Single, SingeOrDefault
            //Single yada SingleAsyn metodlari egerki sorgu sonucunda birden fazla kayit geliyorsa yada hic gelmiyorsa hata firlatir.
            //SingleOrDefault Eger Sorgu neticesinde birden fazla kayit gelirse hata firlatir.Hiz kayit gelmez ise null deger geri doner.
            //try
            //{

            //    var sonuc = context.Employees.Where(p => p.EmployeeId == 1).Single();

            //    var sonuc2 = context.Employees.Where(p => p.FirstName.Contains("a")).SingleOrDefault();

            //    Console.WriteLine(sonuc.FirstName+""+sonuc.LastName);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion





            #region First ve FirstOrDefult
            // Sorguda ki verilerin ilkini getirir.Eger kayit gelmiyorsa hata firlatir.



            //try
            //{
            //    //Bu sorgu duzgun calisir
            //    var sonuc = context.Employees.First(p => p.EmployeeId == 1);
            //    Console.WriteLine(sonuc.FirstName+""+sonuc.LastName);

            //    var sonuc2 = context.Employees.First(p => p.EmployeeId == 100);
            //    Console.WriteLine(sonuc2.FirstName + "" + sonuc2.LastName);

            //    var sonuc3 = context.Employees.First(p => p.EmployeeId > 5);
            //    Console.WriteLine(sonuc3.FirstName + "" + sonuc3.LastName);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Find

            //Find metodu primay key kolonuna gore arama yapar.Dolayısıyla veriye daha hizli erisir.

            var sonuc = context.Employees.Find(3);

            Console.WriteLine(sonuc.FirstName+" "+ sonuc.LastName);

            #region Composite PrimaryKey oldugunda ne yapar?



            #endregion
            #endregion

            #region Last, LastOrDefault
            // Sorguda ki verilerin sonuncusunu getirir.Eger kayit gelmiyorsa hata firlatir
            // Bu sorguda OrderBy Kullanilmasi Zorunludur.

            //var result = context.Employees.OrderBy(p=>p.EmployeeId).Last(p => p.EmployeeId >= 3);
            //Console.WriteLine(result.FirstName+" "+);

            #endregion
            #endregion

            #endregion

            #region Diger sorgulama Fonksiyonlari

            #region Count 
            // Olusturulan sorgularin execute edilmesi neticesinde kac adet satirin elde edilecegini sayisal olarak (int) bize veren fonksiyondur

            //var sonuc1 = (context.Employees.ToList().Count());
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardir");

            #endregion

            #region LongSonuc
            //var sonuc1 = (context.Employees.ToList().LongCount());
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardir");

            #endregion

            #region Any
            //Sorgu sonucunda verinin gelip gelmediginibool turunden geri donen fonksiyondur.
            //var sonuc1 = (context.Employees.Where(p=>p.EmployeeId>10).ToList().Any());
            //Console.WriteLine($"Employee Tablosunda kayit vardir:{sonuc}");


            #endregion

            #region Max ,Min
            //Max verilen kolondaki max degerini getirir

            //var sonuc3 = context.Products.Max(p => p.UnitPrice);
            //Console.WriteLine($"urunler tablosundaki en yüksek fiyat:{sonuc3}");

            //var sonuc4 = context.Products.Max(p => p.UnitPrice);
            //Console.WriteLine($"urunler tablosundaki en düsük fiyat:{sonuc4}");
            #endregion

            #region Distinct
            //Sorgudaki kayitlari tekillestirir
            //var sonuc3 = context.Products.Distinct().ToList();
            //Console.WriteLine($"urunler tablosundaki en yüksek fiyat:{sonuc3}");
            #endregion

            #region sum
            //Vermiş oldugumuz sayisal property'nin toplamini alir.

            //var sonuc2 = context.Products.Sum(p => p.UnitPrice);
            //Console.WriteLine($"Urunler Tablosundaki toplam  ");
            #endregion

            #region Contains

            //like'% %' sorgusu olusturmaya yara
            //var sonuc6 = context.Products
            //    .Where(p => p.ProductName.Contains("a")).ToList().ForEach(p => Console.WriteLine(p.ProductName + " "+ p.UnitPrice));
            #endregion

            #region StartWith, EndWith
            // Like '% %' sorgusu olusturmaya yara
            context.Products
                .Where(p=>p.ProductName.StartsWith("a"))
                .ToList()
                .ForEach(p => Console.WriteLine(p.ProductName+""+ p.UnitPrice));
                Console.WriteLine("************");
            context.Products.Where (P=>P.ProductName.EndsWith("a"))
                .ToList()
                .ForEach(p => Console.WriteLine());

            #endregion

            #region Select 
            //Select Metodu Generate edilecek sorgunun cekilecek kolonlarini ayarlamaiza yarar
            // tek kolon secilecekse
            //var urunler = context.Products.Select(p => p.ProductName).ToList();

            //birden fazla kolon secilecekse
            //context.Products
            //     .Select(p => new { p.ProductName, p.ProductId, p.UnitPrice })
            //     .ToList()
            //    .ForEach(p => Console.WriteLine(p.ProductId + " " + p.ProductName + "" + p.UnitPrice));


            #endregion


            #region Group By 

            // Gruplama yapmaya yarar

            //metod syntax

            //var urunler = context.Products
            //    .GroupBy(p => p.CategoryId)
            //    .Select(group => new
            //    {
            //        CategoriId = group.Key,
            //        count = group.Count(),

            //    }
            //    ).ToList();
            //Console.Clear();

            //foreach(var item in urunler)
            //{
            //    Console.WriteLine(item.CategoriId+ " "+ item.count);
            //}

            //Query Syntax

            var data = (from urun in context.Products
                        group urun by urun.CategoryId
                     into @group
                        select new
                        {
                            CategoryId = @group.Key,
                            Adet = @group.Count(),

                        }).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.CategoryId+
                    " "+item.Adet);
            }
                    #endregion

                     #endregion





            Console.WriteLine("Hello, World!");
        }
    }
}
