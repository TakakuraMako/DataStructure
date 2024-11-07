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
    public partial class Form2 : Form
    {
        IntSet A = new IntSet(80);
        IntSet B = new IntSet(80);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint a = (uint)numericUpDown1.Value;
            A.Insert(a);
            textBox2.Text = A.GetElements();
            textBox1.Text = A.GetBitString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uint a = (uint)numericUpDown1.Value;
            A.Remove(a);
            textBox2.Text = A.GetElements();
            textBox1.Text = A.GetBitString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uint b = (uint)numericUpDown2.Value;
            B.Insert(b);
            textBox3.Text = B.GetElements();
            textBox4.Text = B.GetBitString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uint b = (uint)numericUpDown2.Value;
            B.Remove(b);
            textBox3.Text = B.GetElements();
            textBox4.Text = B.GetBitString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IntSet C = A.Intersect(B);
            textBox5.Text = C.GetElements();
            textBox6.Text = C.GetBitString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IntSet C = A.Union(B);
            textBox7.Text = C.GetElements();
            textBox8.Text = C.GetBitString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IntSet C = A.DiffSet(B);
            textBox9.Text = C.GetElements();
            textBox10.Text = C.GetBitString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntSet C = A.Complement();
            textBox11.Text = C.GetElements(); ;
            textBox12.Text = C.GetBitString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IntSet C = A.Union(B);
            IntSet D = A.Intersect(B);
            if(C.GetBitString()==D.GetBitString())
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string c = A.GetBitString(); 
            string d = B.GetBitString();
            int flag = 0;
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i] < d[i])
                {
                    flag++;
                    break;
                }
            }
            if(flag == 0)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
