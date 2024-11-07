using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05字符串与整数集合
{
    public partial class Form1 : Form
    {
        SeqString seq = new SeqString();

        public Form1()
        {
            InitializeComponent();
            SeqString _s = new SeqString(textBox1.Text);
            textBox11.Text = Convert.ToString(_s.Length);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            SeqString temp = new SeqString(textBox6.Text);
            textBox7.Text = Convert.ToString(_s.IndexOf(temp));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SeqString s1 = new SeqString(textBox1.Text);
            SeqString s2 = new SeqString(textBox10.Text);
            SeqString s3 = new SeqString();
            s3 = (SeqString)s1.Concat(s2);
            textBox9.Text = Convert.ToString(s3);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            textBox11.Text = Convert.ToString(_s.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            textBox2.Text = Convert.ToString(_s.SubString((int)numericUpDown1.Value, (int)numericUpDown4.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            SeqString temp = new SeqString(textBox5.Text);
            textBox4.Text = Convert.ToString(_s.Insert((int)numericUpDown2.Value, temp));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            textBox3.Text = Convert.ToString(_s.Remove((int)numericUpDown3.Value, (int)numericUpDown5.Value));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeqString _s = new SeqString(textBox1.Text);
            textBox8.Text = Convert.ToString(_s.Clone());
        }
    }
}
