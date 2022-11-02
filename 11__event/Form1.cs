using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11__event
{
    public partial class Form1 : Form
    {
        //bir olayin gerceklestigini belirten tetikleyicidir
        //event tetiklendiginde onceden yazilmis kodlar calisacaktir
        //govdesiz metoda benzerler. lakin hamle etme sureci farklidir
        //metod ne yapacagini bildiigmiz ve ne zaman calisacagini bildigimiz durumlarda calisir
        //event te en az iki obje vardir. bir taraf ne yapılacagini bilir 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TepkiGosteren tepkiGosteren = new TepkiGosteren();  
            Bagiran bagiran = new Bagiran();
            bagiran.Bagirdim += tepkiGosteren.TepkiVer;
            bagiran.HerhangiBirIslemYap();


        }
    }
}
