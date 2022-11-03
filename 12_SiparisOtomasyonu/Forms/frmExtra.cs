using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_SiparisOtomasyonu.Forms
{
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }

        private void frmExtra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Extralar.Add(new Entities.Extra() { ExtraAdi = txtExtra.Text, Fiyat = nmFiyat.Value });
            Tools.Temizle(this.Controls);
        }
    }
}
