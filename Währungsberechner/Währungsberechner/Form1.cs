using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsberechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double eurobetrag;
            int waehrung = 0;

            eurobetrag = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                waehrung = 1;
                label3.Text = "SF";
            }
            if (radioButton2.Checked == true)
            {
                waehrung = 2;
                label3.Text = "US $";
            }
            if (radioButton3.Checked == true)
            {
                waehrung = 3;
                label3.Text = "£";
            }
            if (radioButton4.Checked == true)
            {
                waehrung = 4;
                label3.Text = "kr";
            }
            textBox2.Text = Convert.ToString(umrechnung(eurobetrag, waehrung));


        }

        double umrechnung(double eurobetrag, int waehrung)
        {
            double ausgabe = 0;
            if (waehrung == 1)
            {
                ausgabe = eurobetrag * 0.94;
                
            }
            if (waehrung == 2)
            {
                ausgabe = eurobetrag * 1.08;
            }
            if (waehrung == 3)
            {
                ausgabe = eurobetrag * 0.86;

            }
            if (waehrung == 4)
            {
                ausgabe = eurobetrag * 7.46;
            }
            return ausgabe;
        }
    }
}
