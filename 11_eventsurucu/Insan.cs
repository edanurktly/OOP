using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_eventsurucu
{
    public abstract class Insan
    {


        public string Ad { get; private set; }

        public Insan(string ad)
        {
            Ad = ad;
        }
    }
}
