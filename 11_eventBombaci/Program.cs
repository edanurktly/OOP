namespace _11_eventBombaci
{
    public delegate void EventTip();
    internal class Program
    {
   
        static void Main(string[] args)
        {
            //Telefon gorusmesinde  "Aliveli4950" kelimesi geçerse bomba patlasin

            Telefon telefon = new Telefon();
            Bomba bomba = new Bomba();
            telefon.KelimeKullanildi += bomba.Patla;


            telefon.Gorusme();


            Console.WriteLine("Hello, World!");
        }
    }
}