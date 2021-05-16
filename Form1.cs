using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergasia_2_monadwn
{
    public partial class Form1 : Form
    {
        public static String text;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Form2 form2= new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        public static String returnText()
        {
            return text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }
    }
}
