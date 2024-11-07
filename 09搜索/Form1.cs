using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _09搜索.Find;

namespace _09搜索
{
    public partial class Form1 : Form
    {
        int[] a;
        int[] b;
        int[] c;
        Find find = new Find();
        public Form1()
        {
            InitializeComponent();
            a = new int[10] { 53, 78, 65, 17, 87, 9, 81, 45, 23, 67 };
            b = new int[9] { 12, 13, 21, 24, 28, 30, 42, 50, 69 };
            c = new int[10] { 53, 78, 65, 17, 87, 9, 81, 45, 23, 67 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);
            int times = find.SequentialSearch(a, d)+1;
            textBox2.Text = times.ToString() + "次";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox4.Text);
            int times = find.BinarySearch(b, d);
            textBox3.Text = times.ToString() + "次";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();
            foreach(int value in b)
            {
                bst.Insert(value);
            }
            int d = Convert.ToInt32(textBox6.Text);
            int times = bst.Search(d);
            textBox5.Text = times.ToString() + "次";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();
            foreach(int value in b)
            {
                bst.Insert(value);
            }
            textBox7.Text = bst.InOrderTraversal();
        }
    }
}
