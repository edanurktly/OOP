using _8_AbstractClass.MuzikAletleri;

namespace _8_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateri yamahaDavul = new Bateri();

            yamahaDavul.Marka = "Yamaha";
            Console.WriteLine(yamahaDavul.AkortEt());
            Gitar fender =new Gitar();
            fender.Marka = "fender";
            Console.WriteLine(fender.AkortEt());
            Muzisyen ali=new Muzisyen();
            ali.Adi = "ALİ";
            ali.Soyadi = "yilmaz";
            ali.CaldigiMuzikAleti = new Gitar();
            ali.CaldigiMuzikAleti = new Bateri();
            ali.CaldigiMuzikAleti = new Piyano();

            Console.WriteLine("Hello, word");
        }
    }
}