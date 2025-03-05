using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int pertama;
        private int kedua;

        private void button15_Click(object sender, EventArgs e)
        {

                pertama = 1;
                label1.Text = "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
                pertama = 2;
                label1.Text = "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
                pertama = 3;
                label1.Text = "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
                pertama = 4;
                label1.Text = "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {
                pertama = 5;
                label1.Text = "5";
        }

        private void button20_Click(object sender, EventArgs e)
        {
                pertama = 6;
                label1.Text = "6";
        }

        private void button21_Click(object sender, EventArgs e)
        {
                pertama = 7;
                label1.Text = "7";
        }

        private void button22_Click(object sender, EventArgs e)
        {
                pertama = 8;
                label1.Text = "8";
        }

        private void button23_Click(object sender, EventArgs e)
        {
                pertama = 9;
                label1.Text = label1.Text + "9";
        }

        private void button25_Click(object sender, EventArgs e)
        {
                pertama = 0;
                label1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
                kedua = pertama;
                pertama = 0;
                label1.Text = Convert.ToString(kedua) + " + ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int hasil = pertama + kedua;
            label1.Text = Convert.ToString(hasil);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
