using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(textBox1.Text);
            sayi2 = Convert.ToByte(textBox2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1. Sayı 2 den Büyüktür");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar Birbirine Eşittir");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.Sayı 1den Küçüktür");
            }
        }
    }
}
