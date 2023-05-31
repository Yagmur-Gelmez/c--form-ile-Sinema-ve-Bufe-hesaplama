using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaveBufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatoplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            bilet = Convert.ToInt16(textBox1.Text);
            misir = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);
            cay = Convert.ToInt16(textBox4.Text);
            toplam = bilet * 15 + misir * 10 + su * 5 + cay * 5;
            label10.Text = toplam.ToString() + "TL";
            kasatoplam = toplam + kasatoplam;
            label12.Text = kasatoplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
