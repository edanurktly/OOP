namespace _10_Delegate
{
    internal class Program
    {

        /*
         Delegate: Metodları temsil eden yapilardir.

        örnek tanimlama
        <Erisim_Belirteci> delegate  <Temsil_Edilen_Metodun_Geri_Donus_Tipi>
           public delegate    int  hesaplayici (int a,int b)
         */
        public delegate void hesaplayici(int a, int b);

        static void Main(string[] args)
        {

            hesaplayici test = Topla;
            test += deneme;
            test += Cikar;
            test += Carp;
            test += Bolme;
            test -= deneme;
            ExternalMetod externalMetod = new ExternalMetod();
            test += externalMetod.TestMeod;
            test.Invoke(10, 5);

            Console.WriteLine("Hello, World!");
        }

        public static void deneme(int a, int b)
        {

        }
        public static void Topla(int a, int b)
        {
            Console.WriteLine(a + b); 
        }

        public static void Cikar(int a, int b) => Console.WriteLine("fark:"+(a - b)); 

        public static void Carp(int a, int b)
        {
            Console.WriteLine("CARPIM:" +(a * b));
        }
        public static void Bolme(int a, int b)
        {
            Console.WriteLine("bolme:"+(a/b));
           

        }
    }
}