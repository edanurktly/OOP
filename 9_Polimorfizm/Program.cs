using _9_Polimorfizm.AlanHesabi;
using _9_Polimorfizm.Emlak;
using _9_Polimorfizm.Personeller;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alan


            //    Kare kare = new Kare();
            //    kare.Kenar = 5;
            //    Dikdortgen dikdortgen = new Dikdortgen();
            //    dikdortgen.KisaKenar = 5;
            //    dikdortgen.UzunKenar = 15;
            //    Console.WriteLine("Dikdörtgen Alani:" + dikdortgen.Alan());

            //    Console.WriteLine("kare alani:" + kare.Alan());
            //    Daire daire = new Daire();
            //    daire.YariCap = 5;
            //    Console.WriteLine("Daire alani:" + daire.Alan());
            #endregion



            //#region Maas Hesabi

            //Sekreter ayse = new Sekreter()
            //{
            //    Ad = "ayse",
            //    Soyad = "kaya",
            //    EgitimDurumu = EgitimDurumu.lise
            //};

            //Yazilim ali = new Yazilim()
            //{
            //    Ad = "ali",
            //    Soyad = "yilmaz",
            //    EgitimDurumu = EgitimDurumu.yükseklisans,
            //    Seviye = Seviye.orta

            //};

            //ItMuduru fatma = new ItMuduru()
            //{
            //    Ad = "fatma",
            //    Soyad = "kısa",
            //    EgitimDurumu = EgitimDurumu.yükseklisans,
            //    Seviye = Seviye.orta
            //};

            //     Console.WriteLine("Sekreter  Maasi"+ayse.MaasHesapla());
            //    Console.WriteLine("Orta Yazilimci  Maasi" + ali.MaasHesapla());
            //    Console.WriteLine("Orta Yazilimci  Maasi" + fatma.MaasHesapla());



            //#endregion

            #region Emlak Kira Hesaplama

            KonutDaire daire = new KonutDaire(Kimden.Emlakcidan, 90, 3)
            {
                BinaYasi = 5,
                EmlakTipi = EmlakTipi.daire,
                EsyaliMi = true,
                SiteIcerisindemi = true,
                OdaSayisi = 3
            };

            double kira = daire.KiraHesapla();
            Console.WriteLine("Olusan Kira:" + kira);

            Residance res = new Residance(Kimden.Emlakcidan, 90, 5, 2000)
            {
                BinaYasi = 5,
                EmlakTipi = EmlakTipi.daire,
                EsyaliMi = true,
                SiteIcerisindemi = true,
                OdaSayisi = 3,

            };

            Console.WriteLine("Residance icin olusan Kira:" + res.KiraHesapla());




            #endregion


        }
    }
    }