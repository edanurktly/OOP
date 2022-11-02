namespace _11_eventsurucu
{
    public delegate void EventTip(int a ,object sender);
    internal class Program
    {
        static void Main(string[] args)
        {
            //hizlanan bir araç 120km yi geçince polis söföre ceza kessin
            //araba gaza basinca hizlansin

            Araba araba = new Araba("34 ABC 45", 180);
            Polis polis = new Polis("GUVEN KAYA");
            Sofor sofor = new Sofor("ALİ YİLMAZ");
            araba.HareketEdiyorum += polis.HizKontrolEt;
            sofor.GazaBastim += araba.Calis;

            sofor.GazaBas();

            Console.ReadLine();
        }
    }
}


