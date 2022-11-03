using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_SiparisOtomasyonu
{
    public class Tools
    {
        public static void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox check = (CheckBox)item;
                    check.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton radioButtonradio = (RadioButton)item;
                    if (radioButtonradio.Text == "Kucuk")
                        radioButtonradio.Checked = true;
                    else
                        radioButtonradio.Checked = false;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown upDown = (NumericUpDown)item;
                    upDown.Value = 1;


                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flow = (FlowLayoutPanel)item;
                    Temizle(flow.Controls);
                }
                else if (item is ComboBox)
                {
                    ComboBox combo = (ComboBox)item;
                    combo.SelectedIndex = 0;

                }


            }
        }
    }
}

        
    
