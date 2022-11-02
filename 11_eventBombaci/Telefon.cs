namespace _11_eventBombaci
{
    internal class Telefon
    {
        public event EventTip KelimeKullanildi;
        public Telefon()
        {
        }
      public void Gorusme()
        {
            Console.WriteLine("aloo...");
            string input=Console.ReadLine();

            if(input.Contains("AliVeli4950"))
            {
                KelimeKullanildi();
            }
            else if(input=="kapat")
            {
                return;
            }
            Gorusme();
        }
    }
}