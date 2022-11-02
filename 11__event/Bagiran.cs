using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__event
{
    public delegate void MetodTipi(object sender);
 public class Bagiran
    {
        public string Ad { get{ return "ali"; }  }
        public event MetodTipi Bagirdim;
        public void HerhangiBirIslemYap()
        {
            Console.WriteLine("heeyt");
            Bagirdim(this);
        }
    }
}
