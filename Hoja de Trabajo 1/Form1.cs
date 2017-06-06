﻿using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;
            palabra = palabra.ToLower();

            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜ";
            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUU";
            for (int v = 0; v < sinsignos.Length; v++)
            {
                string i = consignos.Substring(v, 1);
                string j = sinsignos.Substring(v, 1);
                palabra = palabra.Replace(i, j);
            }

            label5.Text = "";

            if (palabra.Contains("a") && palabra.Contains("e") && palabra.Contains("i") && palabra.Contains("o") && palabra.Contains("u"))
            {

                label5.Text = "CUMPLE";
            }

            else { 

                label5.Text = "NO CUMPLE";

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] cadena1 = textBox1.Text.ToCharArray();
            char[] cadena2 = textBox2.Text.ToCharArray();

            Array.Reverse(cadena1);
            Array.Reverse(cadena2);

            string nuevac1 = new string(cadena1);
            string nuevac2 = new string(cadena2);

            label5.Text = nuevac1 + " " + nuevac2+"_201314735";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(textBox1.Text);
            int X = Convert.ToInt32(textBox2.Text);
            int B = Convert.ToInt32(textBox3.Text);
            int Y = (B*X)/A;

            label5.Text = Convert.ToString(Y);


        }
    }
}
