using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass
{
   public abstract class BaseHayvan
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        



        //Proper'lerde abstract olarak isaretlenebilir
        public abstract int AyakSayisi { get; set; }

        public abstract string SesCikar();
        public override string ToString()
        {
            return Ad+"  "+ Yas;
        }


    }
}
