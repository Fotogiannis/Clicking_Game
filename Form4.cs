using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergasia_2_monadwn
{
    public partial class Form4 : Form
    {
        List<string> lines = File.ReadLines("file_hard!.txt").ToList();

        public static String s1 = null;
        public static String s2 = null;

        int counter;
        int countDown = 20;
        Random random;
        int randomImage;
        int sum;
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            randomImage = random.Next(1, 7);
            pictureBox1.ImageLocation = "images/Alea_" + randomImage.ToString() + ".png";
            int x1, y1;
            x1 = random.Next(panel1.Width - pictureBox1.Width);
            y1 = random.Next(panel1.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(x1, y1);
            countDown--;
            label3.Text = countDown.ToString();
            if (countDown == 0)
            {
                timer1.Enabled = false;
                pictureBox1.Enabled = false;
                MessageBox.Show("Game Over!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            sum += randomImage;
            label2.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            random = new Random();
            label4.Text = Form1.returnText();
            var max = lines.Max();
            label6.Text = max;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = label4.Text;
            s2 = label2.Text;

            User u1 = new User(s1, s2);

            StreamWriter sw = new StreamWriter("file_hard!.txt", true);
            sw.WriteLine(u1.Score + " " + u1.Name + Environment.NewLine);
            sw.Close();
            MessageBox.Show("Your score is saved ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("file_hard!.txt");
            try
            {
                String s = sr.ReadLine();
                //String sAll = null;
                StringBuilder sb = new StringBuilder();
                while (s != null)
                {
                    //sAll += s + Environment.NewLine;
                    sb.Append(s);
                    sb.Append(Environment.NewLine);
                    s = sr.ReadLine();
                }

                MessageBox.Show(sb.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> lines2 = new List<string>();
            lines = lines.OrderBy(q => q).ToList();
            lines.Reverse();
            lines.RemoveAll(string.IsNullOrWhiteSpace);


            for (int i = 0; i < 3; i++)
            {
                lines2.Add(lines.ElementAt(i));
            }
            var message = string.Join(Environment.NewLine, lines2);
            MessageBox.Show(message);
        }
    }
}
