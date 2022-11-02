namespace _11_ArabaKumanda
{
    internal class Araba
    {
        private readonly string _kod;
        public Araba(string kod)
        {
            this._kod = kod;
        }
        public void SinyalAl(string kod)
        {
            if (_kod == kod)
            {
                KapialariAc();
            }
            else
            {
                Console.WriteLine($"Yanlis kumandadan sinyal alindi . Alinan Kod:{kod}");
            }
        }

        private void KapialariAc()
        {
            Console.WriteLine($"Kapilar {_kod} Acildi");
        }
    }

}

