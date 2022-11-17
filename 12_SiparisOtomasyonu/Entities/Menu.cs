using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyonu.Entities
{
    public class Menu
    {

        public string MenuAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return MenuAdi + "  Menu";
        }
    }
}
