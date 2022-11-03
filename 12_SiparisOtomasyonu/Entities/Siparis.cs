using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyonu.Entities
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyutu { get; set; }

        public List<Extra> Extralar { get; set; }

        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;
            switch (Boyutu)
            {

                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.1m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.2m;
                    break;

            }


            //Extralarin Fiyati hesaplaniyor
            foreach (Extra extra in Extralar)
            {
                ToplamTutar += extra.Fiyat;
            }

            //Kac adet ise toplam tutar onunla carpilir
            ToplamTutar = ToplamTutar * Adet;

        }

    }
}
