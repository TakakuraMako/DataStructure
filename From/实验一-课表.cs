using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _01线性表
{
    public partial class Form1 : Form
    {
        SLinkList<string> sLinkList_name = new SLinkList<string>();
        SLinkList<string> sLinkList_trait = new SLinkList<string>();
        SLinkList<int> sLinkList_number = new SLinkList<int>();
        CLinkList<string> cLinkList_name = new CLinkList<string>();
        CLinkList<string> cLinkList_trait = new CLinkList<string>();
        CLinkList<int> cLinkList_number = new CLinkList<int>();
        DLinkList<string> dLinkList_name = new DLinkList<string>();
        DLinkList<string> dLinkList_trait = new DLinkList<string>();
        DLinkList<int> dLinkList_number = new DLinkList<int>();
        SeqList<string> seqList_name = new SeqList<string>(10);
        SeqList<string> seqList_trait = new SeqList<string>(10);
        SeqList<int> seqList_number = new SeqList<int>(10);
        public string combine_text(int choose)
        {
            string combine = "";
            if(choose == 1)
            {
                for(int i = 0; i < seqList_name.Length; i++)
                {
                    combine += label1.Text + "：" + seqList_number[i] + " " + label2.Text + "：" + seqList_name[i] + label3.Text + "：" + seqList_trait[i] + Environment.NewLine;
                }
            }else if(choose == 2)
            {
                for(int i = 0; i < cLinkList_name.Length; i++)
                {
                    combine += label1.Text + "：" + cLinkList_number[i] + " " + label2.Text + "：" + cLinkList_name[i] + label3.Text + "：" + cLinkList_trait[i] + Environment.NewLine;
                }
            }
            else if(choose == 3)
            {
                for(int i = 0; i < sLinkList_name.Length; i++)
                {
                    combine += label1.Text + "：" + sLinkList_number[i] + " " + label2.Text + "：" + sLinkList_name[i] + label3.Text + "：" + sLinkList_trait[i] + Environment.NewLine;
                }
            }
            else
            {
                for(int i = 0; i < dLinkList_name.Length; i++)
                {
                    combine += label1.Text + "：" + dLinkList_number[i] + " " + label2.Text + "：" + dLinkList_name[i] + label3.Text + "：" + dLinkList_trait[i] + Environment.NewLine;
                }
            }
            return combine;
        }

        struct Course
        {
            public int number;
            public string name;
            public string trait;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course _course = new Course();
            _course.number = Convert.ToInt32(textBox1.Text);
            _course.name = textBox2.Text;
            _course.trait = comboBox1.Text;
            int index = Convert.ToInt32(numericUpDown1.Value);
            if(radioButton1.Checked == true)
            {
                seqList_name.Insert(index, _course.name);
                seqList_trait.Insert(index, _course.trait);
                seqList_number.Insert(index, _course.number);
                textBox4.Text = combine_text(1);

            }
            else if(radioButton2.Checked == true)
            {
                sLinkList_name.Insert(index, _course.name);
                sLinkList_trait.Insert(index, _course.trait);
                sLinkList_number.Insert(index, _course.number);
                textBox4.Text = combine_text(3);
            }
            else if(radioButton3.Checked == true)
            {
                cLinkList_name.Insert(index, _course.name);
                cLinkList_trait.Insert(index, _course.trait);
                cLinkList_number.Insert(index, _course.number);
                textBox4.Text = combine_text(2);
            }
            else
            {
                dLinkList_name.Insert(index, _course.name);
                dLinkList_trait.Insert(index, _course.trait);
                dLinkList_number.Insert(index, _course.number);
                textBox4.Text = combine_text(4);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(numericUpDown2.Value);
            if(radioButton1.Checked == true)
            {
                seqList_name.Remove(index);
                seqList_trait.Remove(index);
                seqList_number.Remove(index);
                textBox4.Text = combine_text(1);
            }
            else if(radioButton2.Checked == true)
            {
                sLinkList_name.Remove(index);
                sLinkList_trait.Remove(index);
                sLinkList_number.Remove(index);
                textBox4.Text = combine_text(3);
            }
            else if(radioButton3.Checked == true)
            {
                cLinkList_name.Remove(index);
                cLinkList_trait.Remove(index);
                cLinkList_number.Remove(index);
                textBox4.Text = combine_text(2);
            }
            else
            {
                dLinkList_name.Remove(index);
                dLinkList_trait.Remove(index);
                dLinkList_number.Remove(index);
                textBox4.Text = combine_text(4);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "课程序号")
            {
                if(radioButton1.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < seqList_number.Length; i++)
                    {
                        if(seqList_number[i]== Convert.ToInt32(textBox3.Text))
                        {
                            _text += label1.Text + "：" + seqList_number[i] + "," + label2.Text + "：" + seqList_name[i] + "," + label3.Text + "：" + seqList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton2.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < sLinkList_number.Length; i++)
                    {
                        if(sLinkList_number[i] == Convert.ToInt32(textBox3.Text))
                        {
                            _text += label1.Text + "：" + sLinkList_number[i] + "," + label2.Text + "：" + sLinkList_name[i] + "," + label3.Text + "：" + sLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton3.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < cLinkList_number.Length; i++)
                    {
                        if(cLinkList_number[i] == Convert.ToInt32(textBox3.Text))
                        {
                            _text += label1.Text + "：" + cLinkList_number[i] + "," + label2.Text + "：" + cLinkList_name[i] + "," + label3.Text + "：" + cLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else
                {
                    string _text = "";
                    for(int i = 0; i < dLinkList_number.Length; i++)
                    {
                        if(dLinkList_number[i] == Convert.ToInt32(textBox3.Text))
                        {
                            _text += label1.Text + "：" + dLinkList_number[i] + "," + label2.Text + "：" + dLinkList_name[i] + "," + label3.Text + "：" + dLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
            }
            else if(comboBox2.Text == "课程名称")
            {
                if(radioButton1.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < seqList_name.Length; i++)
                    {
                        if(seqList_name[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + seqList_number[i] + "," + label2.Text + "：" + seqList_name[i] + "," + label3.Text + "：" + seqList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton2.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < sLinkList_name.Length; i++)
                    {
                        if(sLinkList_name[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + sLinkList_number[i] + "," + label2.Text + "：" + sLinkList_name[i] + "," + label3.Text + "：" + sLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton3.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < cLinkList_name.Length; i++)
                    {
                        if(cLinkList_name[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + cLinkList_number[i] + "," + label2.Text + "：" + cLinkList_name[i] + "," + label3.Text + "：" + cLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    string _text = "";
                    for(int i = 0; i < dLinkList_name.Length; i++)
                    {
                        if(dLinkList_name[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + dLinkList_number[i] + "," + label2.Text + "：" + dLinkList_name[i] + "," + label3.Text + "：" + dLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
            }
            else
            {
                if(radioButton1.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < seqList_trait.Length; i++)
                    {
                        if(seqList_trait[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + seqList_number[i] + "," + label2.Text + "：" + seqList_name[i] + "," + label3.Text + "：" + seqList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton2.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < sLinkList_trait.Length; i++)
                    {
                        if(sLinkList_trait[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + sLinkList_number[i] + "," + label2.Text + "：" + sLinkList_name[i] + "," + label3.Text + "：" + sLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
                else if(radioButton3.Checked == true)
                {
                    string _text = "";
                    for(int i = 0; i < cLinkList_trait.Length; i++)
                    {
                        if(cLinkList_trait[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + cLinkList_number[i] + "," + label2.Text + "：" + cLinkList_name[i] + "," + label3.Text + "：" + cLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    string _text = "";
                    for(int i = 0; i < dLinkList_trait.Length; i++)
                    {
                        if(dLinkList_trait[i] == textBox3.Text)
                        {
                            _text += label1.Text + "：" + dLinkList_number[i] + "," + label2.Text + "：" + dLinkList_name[i] + "," + label3.Text + "：" + dLinkList_trait[i] + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(_text);
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seqList_name.Clear();
            seqList_trait.Clear();
            seqList_number.Clear();
            sLinkList_name.Clear();
            sLinkList_trait.Clear();
            sLinkList_number.Clear();
            dLinkList_name.Clear();
            dLinkList_trait.Clear();
            dLinkList_number.Clear();
            cLinkList_name.Clear();
            cLinkList_trait.Clear();
            cLinkList_number.Clear();
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
