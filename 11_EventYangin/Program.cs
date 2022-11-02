namespace _11_EventYangin
{
    internal class Program
    {
        public delegate void EventTip(object sender);
        static void Main(string[] args)
        {
            //Kablo yanarsa alarm calar
            //alarm calarsa ıtfaiye gelir
            //alarm calarsa komşular rahatsiz olur
            //alarm calarsa insanlar kacar


            //kablo
            //alarm
            //itfaiye
            //komşu
            //insan

            Kablo kablo = new Kablo();
            Alarm alarm = new Alarm();
            Itfaiye itfaiye = new Itfaiye();
            Komsular komsular = new Komsular();
            Insanlar cemal = new Insanlar("cemal");
            Insanlar ali = new Insanlar("ali");

             kablo.Yandim += alarm.AlarmCal;
            alarm.AlarmCaldi +=itfaiye.MudahaleEt;
            alarm.AlarmCaldi += ali.RahatsizOl;
            alarm.AlarmCaldi += ali.Kac;
            alarm.AlarmCaldi += cemal.RahatsizOl;
            alarm.AlarmCaldi += cemal.Kac;
            alarm.AlarmCaldi += komsular.RahatsizOl;

            kablo.AkimGecir();


            // olaylari Birbirine baglayalim




            Console.WriteLine("Hello, World!");
        }
    }
}
