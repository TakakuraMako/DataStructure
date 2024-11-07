using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08排序
{
    public partial class Form1 : Form
    {
        int[] a = { 45, 34, 78, 12, 34, 32, 29, 64, 9, 38, 17 };
        public string Print(int[] a)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                b += Convert.ToString(a[i]) + " ";
            }
            return b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "不排序")
            {
                textBox1.Text = Print(a);
            }
            else if(comboBox1.Text == "直接插入排序")
            {
                int[] c = a;
                Sort.StraightInsertSort(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "希尔排序")
            {
                int[] c = a;
                Sort.ShellInsertSort(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "直接选择排序")
            {
                int[] c = a;
                Sort.StraightSelectSort(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "堆排序")
            {
                int[] c = a;
                Sort.HeapSelectSort(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "冒泡排序")
            {
                int[] c = a;
                Sort.BubbleExchangeSortImproved(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "快速排序")
            {
                int[] c = a;
                Sort.QuickExchangeSortImproved(c);
                textBox1.Text = Print(c);
            }
            else if(comboBox1.Text == "合并排序")
            {
                int[] c = a;
                Sort.MergeSort(c);
                textBox1.Text = Print(c);
            }
        }
    }
}
