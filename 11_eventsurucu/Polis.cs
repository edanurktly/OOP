using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_eventsurucu
{
    internal class Polis:Insan
    {
        public Polis(string ad):base(ad)
        {

        }
        public void HizKontrolEt(int hiz, object tetikleyen)
        {
            if(tetikleyen is Araba)
            {
                if (hiz > 120)
                {
                    Araba araba=(Araba)tetikleyen;
                    araba.ArabaCalisiyorMu = false;
                    Console.WriteLine($"{araba.Plaka} plakali arain {araba.Sofor.Ad} isimli soförüne \n{hiz} km hizla gittiğinden dolayi {Ad} isimli polis tarafindan ceza kesilmiştir... ");
                    
                }
            }
        }
    }
}
