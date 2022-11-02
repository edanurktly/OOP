using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Araba
{
    public enum vites
    {
        otomatik=1,
        YarıOtomatik,
        manuel
    }
    public abstract class BaseAraba
    {
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }


    }
}
