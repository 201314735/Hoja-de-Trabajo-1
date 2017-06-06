using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja_de_Trabajo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double catetoO;
            double catetoA;
            double hipotenusa;

            label5.Text ="";
            hipotenusa = 0;

            catetoO = Convert.ToDouble(textBox1.Text);
            catetoA = Convert.ToDouble(textBox2.Text);

            hipotenusa = Math.Sqrt((catetoO*catetoO)+(catetoA*catetoA));

            label5.Text = Convert.ToString(hipotenusa);


        }
    }
}
