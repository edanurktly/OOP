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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Menuler.Add(new Entities.Menu() { MenuAdi = txtMenu.Text, Fiyat = nmFiyat.Value });
            Tools.Temizle(this.Controls);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
