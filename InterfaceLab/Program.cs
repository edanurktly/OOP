namespace InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FaturaMaster faturaMaster = new FaturaMaster();
            faturaMaster.Personel = new Personel() { AdSoyad = "dfna", TcNo = "8451" };
            faturaMaster.Musteri = new Musteri() { AdSoyad = "dnfudn", TcNo = "5421" };
            Urun urun = new Urun()
            {
                Birim = FaturaKesim.Birim.Adet,
                Fiyat = 10,
                UrunAdi = "Ekmek",
                Adet = 5
            };
            

            FaturaMaster fat = new FaturaMaster();
            try
            {
                faturaMaster.FaturaKes();
                fat.FaturaKes();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}