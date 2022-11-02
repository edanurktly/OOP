using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11__event
{
    public class TepkiGosteren
    {
        public void TepkiVer(object sender)
        {
            Bagiran kim = (Bagiran)sender;
            MessageBox.Show($"{kim.Ad} Ne bagırıyorsun");
        }
    }
}
