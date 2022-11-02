using static _11_ArabaKumanda.Program;

namespace _11_ArabaKumanda
{
    internal class Kumanda
    {
        private readonly string _kod;
        public Kumanda(string kod)
        {
            this._kod = kod;
        }
        public event EventTusaBasildi AcmaTusunaBasildi;
        public void TusaBas()
        {
            Console.WriteLine($"{_kod} kodlu kumandaya basildi");
            AcmaTusunaBasildi(_kod);
        }
    }
}