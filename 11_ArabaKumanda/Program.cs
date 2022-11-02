namespace _11_ArabaKumanda
{
    internal class Program
    {
        public delegate void EventHandler();
        public delegate void EventTusaBasildi(string kod);

        static void Main(string[] args)
        {
            //Kumanda acma tusuna basilsa arabanin kapıları acılın
            //eğer baska bir kumanda tarafindan basıldı ise işlem yapmasın
            //yani birden çok kumanda olabilir birden çok anahtar tusa basma durumu olacak
            //arac sadece birisinde tepki verecek


            //1.Faz:Anahtar tusuna basılır ise kapıları açma eylemi gerçekleştirilir.


            Araba araba = new Araba("bmw123");
            Kumanda kumanda = new Kumanda("bmw123");
            Kumanda sahteKumanda = new Kumanda("TofasSerce");
            kumanda.AcmaTusunaBasildi += araba.SinyalAl;
            sahteKumanda.AcmaTusunaBasildi += araba.SinyalAl;
            sahteKumanda.TusaBas();
            kumanda.TusaBas();






            Console.WriteLine("Hello, World!");
        }
    }
}