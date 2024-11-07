using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01线性表
{
    public partial class 实验一_城市 : Form
    {
        SLinkList<string> name_list = new SLinkList<string>();
        SLinkList<double> x_list = new SLinkList<double>();
        SLinkList<double> y_list = new SLinkList<double>();
        public string Show_City()
        {
            string _text = "";
            for (int i = 0; i < name_list.Length; i++)
            {
                _text += name_list[i] + "  " + "（" + Convert.ToString(x_list[i]) + "," + Convert.ToString(y_list[i]) + "）" + Environment.NewLine;
            }
            return _text;
        }
        public 实验一_城市()
        {
            InitializeComponent();
            name_list.InsertAtRear("城市A");
            name_list.InsertAtRear("城市B");
            name_list.InsertAtRear("城市C");
            name_list.InsertAtRear("城市D");
            name_list.InsertAtRear("城市E");
            name_list.InsertAtRear("城市F");
            name_list.InsertAtRear("城市G");
            name_list.InsertAtRear("城市H");
            x_list.InsertAtRear(500);
            y_list.InsertAtRear(500);
            x_list.InsertAtRear(700);
            y_list.InsertAtRear(300);
            x_list.InsertAtRear(600);
            y_list.InsertAtRear(1200);
            x_list.InsertAtRear(100);
            y_list.InsertAtRear(20);
            x_list.InsertAtRear(120);
            y_list.InsertAtRear(400);
            x_list.InsertAtRear(1200);
            y_list.InsertAtRear(190);
            x_list.InsertAtRear(900);
            y_list.InsertAtRear(809);
            x_list.InsertAtRear(20);
            y_list.InsertAtRear(934);
            textBox4.Text = Show_City();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name_list.InsertAtFirst(textBox1.Text);
            x_list.InsertAtFirst(Convert.ToDouble(textBox2.Text));
            y_list.InsertAtFirst(Convert.ToDouble(textBox3.Text));
            textBox4.Text = Show_City();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name_list.InsertAtRear(textBox1.Text);
            x_list.InsertAtRear(Convert.ToDouble(textBox2.Text));
            y_list.InsertAtRear(Convert.ToDouble(textBox3.Text));
            textBox4.Text = Show_City();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown1.Value;
            name_list.Insert(index, textBox1.Text);
            x_list.Insert(index, Convert.ToDouble(textBox2.Text));
            y_list.Insert(index,Convert.ToDouble(textBox3.Text));
            textBox4.Text = Show_City();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown3.Value;
            name_list.Remove(index);
            x_list.Remove(index);
            y_list.Remove(index);
            textBox4.Text = Show_City();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown2.Value;
            name_list[index] = textBox1.Text;
            x_list[index] = Convert.ToDouble(textBox2.Text);
            y_list[index] = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Show_City();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < name_list.Length; i++)
            {
                if(name_list[i] == textBox5.Text)
                {
                    MessageBox.Show(name_list[i] + " " + "(" + x_list[i] + "," + y_list[i] + ")" + Environment.NewLine);
                    break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double D = Convert.ToDouble(textBox8.Text);
            double d = 0;
            double x = Convert.ToDouble(textBox6.Text);
            double y = Convert.ToDouble(textBox7.Text);
            textBox9.Text = "";
            for(int i = 0;i < name_list.Length; i++)
            {
                d = Math.Sqrt(Math.Pow(x_list[i] - x, 2) + Math.Pow(y_list[i] - y, 2));
                if(d <= D)
                {
                    textBox9.Text += "D=" + d.ToString("0.00") + "  " + name_list[i] + " " + "(" + x_list[i] + "," + y_list[i] + ")" + Environment.NewLine;
                }
            }
        }
    }
}
