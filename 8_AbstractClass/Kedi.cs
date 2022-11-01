using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass
{
    public class Kedi : BaseHayvan
    {
        public override int AyakSayisi { get; set; }
        public override string SesCikar()
        {
            return "miyav";
        }
    }
}
