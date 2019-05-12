using System;
using System.Drawing;
using System.Windows.Forms;

namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(151, 111, 131);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
            this.BackColor = Color.FromArgb(10, 121, 131);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && (radioButton1.Checked || radioButton2.Checked))
            {
                if (trackBar1.Value >= 50)
                {
                    MessageBox.Show("yOU CAN ALREADY DRINK BEER WITH YOUR FATHER");
                }
                else if (trackBar1.Value >= 18 && trackBar1.Value <= 25)
                {
                    MessageBox.Show("Welcome to Mak");
                }
                else if (trackBar1.Value >= 1 && trackBar1.Value <= 6)
                {
                    MessageBox.Show("In our years, I was played in the sand");
                }
                else if (trackBar1.Value >= 10 && trackBar1.Value <= 18)
                {
                    MessageBox.Show("How are things at school?");
                }
                tabControl1.SelectTab(1);
                progressBar1.Increment(34);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(33);
            tabControl1.SelectTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                progressBar1.Increment(33);
                tabControl1.SelectTab(3);
            }
            else
            {
                MessageBox.Show("you must write");
            }
        }
    }
}