using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04数组与稀疏矩阵
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string _text = textBox1.Text;
            string text = "";
            for(int x = 0; x < _text.Length; x++)
            {
                if(_text[x] < '0' || _text[x] > '9')
                {
                    continue;
                }
                text += _text[x];
            }
            int rows = Convert.ToInt32(Math.Sqrt(text.Length));
            int cols = rows;
            IMatrix<double> a = new SparseMatrix(rows, cols);
            int i = 0;
            for(int r = 0; r < Math.Sqrt(text.Length); r++)
            {
                for(int c = 0; c < Math.Sqrt(text.Length); c++)
                {
                    if(text[i] != '0')
                    {
                        a[r, c] = Convert.ToInt32(text[i]) - '0';
                    }
                    i++;
                }
            }
            SparseMatrix T = (SparseMatrix)a.Transpose();
            textBox8.Text = a.ToString();
            textBox7.Text = T.ToString();
            SparseMatrix add = T.Add((SparseMatrix)a);
            textBox6.Text = add.ToString();
            SparseMatrix multiply = (SparseMatrix)a.Multiply(T);
            textBox5.Text = multiply.ToString();
            string text2 = "";
            string text3 = "";
            string text4 = "";
            for(int r2 = 0; r2 < rows; r2++) 
            {
                for(int c2 = 0; c2 < cols; c2++)
                {
                    text2 += T[r2, c2] + " ";
                    text3 += add[r2, c2] + " ";
                    text4 += multiply[r2, c2] + " ";
                }
                text2 += Environment.NewLine;
                text3 += Environment.NewLine;
                text4 += Environment.NewLine;
            }
            textBox2.Text = text2;
            textBox3.Text = text3;
            textBox4.Text = text4;
        }
    }
}
