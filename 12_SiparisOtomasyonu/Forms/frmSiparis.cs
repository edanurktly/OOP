using _12_SiparisOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _12_SiparisOtomasyonu.Forms;

namespace _12_SiparisOtomasyonu.Forms
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            foreach (var item in Form1.Menuler)
            {
                cmbMenu.Items.Add(item);
            }

            foreach (var ex in Form1.Extralar)
            {
                flpExtra.Controls.Add(new CheckBox() { Text = ex.ExtraAdi, Tag = ex });
            }
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis yenisiparis = new Siparis();
            if (radioButton1.Checked)
                yenisiparis.Boyutu = Boyut.Kucuk;
            else if (radioButton2.Checked)
                yenisiparis.Boyutu = Boyut.Orta;
            else
                yenisiparis.Boyutu = Boyut.Buyuk;

            yenisiparis.Adet = (int)nmrAdet.Value;

            yenisiparis.Extralar = new List<Extra>();
            foreach (CheckBox item in flpExtra.Controls)
            {
                if (item.Checked)
                {
                    yenisiparis.Extralar.Add((Extra)item.Tag);
                }
            }

            yenisiparis.SeciliMenu = (_12_SiparisOtomasyonu.Entities.Menu)cmbMenu.SelectedItem;

            yenisiparis.Hesapla();

            Form1.MevcutSiparis.Add(yenisiparis);

            lstSiparisler.Items.Add(yenisiparis);
            TutarHesapla();

            Tools.Temizle(this.Controls);
        }

        private decimal TutarHesapla()
        {
            decimal toplamtutar = 0;

            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lstSiparisler.Items[i];
                toplamtutar += gelen.ToplamTutar;
            }
            lblToplamTutar.Text = toplamtutar.ToString("C2");

            return toplamtutar;

        }

        private void btnSipariTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toplam siparis Ucreti:" + TutarHesapla().ToString("C2")
                + " Satin almaya devam etmek istermisiniz ?", "Siparis Bilgisi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();

            }
            else
            {
                MessageBox.Show("Siparis Iptal edildi");
            }
        }
    }
}
