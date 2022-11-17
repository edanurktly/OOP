using System.Numerics;
using System.Runtime.CompilerServices;

namespace Genel_Tekrar
{
    internal class Program
    {

        struct Kisi
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string description { get; set; }
        }
        public interface Iinterface
        {
            void test();
        }
        class A
        {

        }
        struct Person:Iinterface
        {
            public void test()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {

            #region Struct ile Class Arasındaki Farklar

            //Struct(Yapi): birbiriyle iliskili degiskenlerin bir isim altinda toplanmasina verilen isimdir.
            //Struc baska bir structa kalitim veremez.
            //structlar ancak interfacelerden kalitim alabilirler.
            //Structlar Stackte tutulur 64Kb siniri vardir.
            #endregion

            #region Erisim Belirtecleri

            //public:Her taraftan ulasılabilir
            //private:sadece class icerisinden ulasilabilir
            //protected:Instance alindiginda ulasilamaz ancak miras verilen yerlerden ulasilabilir
            //Internal: Programın calistigi assembly 
            //protected ınternal: sadece tanımladıgı sınıfta ya da o sınıfı miras  alan sınıflardan erişilebilirç
            //ayrıca tanımlanan aynı proje içerisinde olma şartı yoktur.Protecteddan farkı budurEğer erişim belirleyici belirtilmemişse, sınıflar internaldır.

            //privatedı özel durumlarda kullan!

            #endregion

            #region Dlegate
            //Delegeler, metodların adreslerini dolayısıyla metodların kendilerini tutabilen, nişaret edebilen yapılardır.
            //not: metodlar da bellekte olusan ve bellek adresleri olan yapılardır.
            //delegeler referans tipli yapılardır.yani nesne olusturulabilirler
            //simdi bir delege yapısı nasıl olur bakalım
            //[erisim belirleyici] delege [geri dönüs tipi] (eger varsa parametre)
            //ornek 
                #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}