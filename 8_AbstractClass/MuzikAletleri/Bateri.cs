using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.MuzikAletleri
{
    internal class Bateri : MuzikAleti
    {
        public override string Cal()
        {
            return "Bateri sesi";
        }

        public override string AkortEt()
        {
           return "bateri akor edildi";
;        }
    }
}
