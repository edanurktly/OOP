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
        public override string ToString()
        {
            if (Extralar.Count < 1)
            {
                return $"{SeciliMenu.MenuAdi} Menu x{Adet} ,{Boyutu.ToString()} ,Toplam {ToplamTutar.ToString("C2")} ";
            }
            else
            {
                string str = null;
                string extralar = null;
                foreach (Extra item in Extralar)
                {
                    extralar += item.ExtraAdi + ",";
                }
                extralar = extralar.Trim(','); // En sondaki , isaretini silmek icin gerekli 


                return $"{SeciliMenu.MenuAdi} Menu x{Adet} ,{Boyutu.ToString()} ,Extralar :{extralar} Toplam {ToplamTutar.ToString("C2")} ";

            }
        }

    }
}
