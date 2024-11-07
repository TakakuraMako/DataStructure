using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _06树
{
    public partial class Tree : Form
    {
        BinTreeNode<string> D1;
        BinTreeNode<string> B1;
        BinTreeNode<string> G1;
        BinTreeNode<string> E1;
        BinTreeNode<string> H1;
        BinTreeNode<string> I1;
        BinTreeNode<string> F1;
        BinTreeNode<string> C1;
        BinTreeNode<string> A1;
        BinTree<string> tree1;
        public Tree()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            D1 = new BinTreeNode<string>("D");
            B1 = new BinTreeNode<string>("B", D1);
            G1 = new BinTreeNode<string>("G");
            E1 = new BinTreeNode<string>("E", G1);
            H1 = new BinTreeNode<string>("H");
            I1 = new BinTreeNode<string>("I");
            F1 = new BinTreeNode<string>("F", H1, I1);
            C1 = new BinTreeNode<string>("C", E1, F1);
            A1 = new BinTreeNode<string>("A", B1, C1);
            tree1 = new BinTree<string>(A1);
            tree1.Insert(B1, D1, null);
            tree1.Insert(D1, null, null);
            tree1.Insert(C1, E1, F1);
            tree1.Insert(G1, null, null);
            tree1.Insert(F1, H1, I1);
            tree1.Insert(H1, null, null);
            tree1.Insert(I1, null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "A")
            {
                textBox1.Text = "没有双亲";
            }
            else
            {
                BinTreeNode<string> temp = tree1.GetParent(tree1.Search(comboBox1.Text));
                textBox1.Text = temp.Data;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinTreeNode<string> temp = tree1.GetLeftSibling(tree1.Search(comboBox1.Text));
            if(temp != null)
            {
                textBox2.Text = temp.Data;
            }
            else
            {
                textBox2.Text = "空";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinTreeNode<string> temp = tree1.GetRightSibling(tree1.Search(comboBox1.Text));
            if(temp != null)
            {
                textBox3.Text = temp.Data;
            }
            else
            {
                textBox3.Text = "空";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = tree1.PreOrderTraversal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = tree1.MidOrderTraversal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = tree1.PostOrderTraversal();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = tree1.LevelTraversal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;


                D1 = new BinTreeNode<string>("D");
                B1 = new BinTreeNode<string>("B", null, D1);
                G1 = new BinTreeNode<string>("G");
                E1 = new BinTreeNode<string>("E", G1);
                H1 = new BinTreeNode<string>("H");
                I1 = new BinTreeNode<string>("I");
                F1 = new BinTreeNode<string>("F", I1, H1);
                C1 = new BinTreeNode<string>("C", F1, E1);
                A1 = new BinTreeNode<string>("A", C1, B1);
                tree1 = new BinTree<string>(A1);
                tree1.Insert(B1, null, D1);
                tree1.Insert(D1, null, null);
                tree1.Insert(C1, F1, E1);
                tree1.Insert(G1, null, null);
                tree1.Insert(F1, I1, H1);
                tree1.Insert(H1, null, null);
                tree1.Insert(I1, null, null);
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                D1 = new BinTreeNode<string>("D");
                B1 = new BinTreeNode<string>("B", D1);
                G1 = new BinTreeNode<string>("G");
                E1 = new BinTreeNode<string>("E", null, G1);
                H1 = new BinTreeNode<string>("H");
                I1 = new BinTreeNode<string>("I");
                F1 = new BinTreeNode<string>("F", H1, I1);
                C1 = new BinTreeNode<string>("C", E1, F1);
                A1 = new BinTreeNode<string>("A", B1, C1);
                tree1 = new BinTree<string>(A1);
                tree1.Insert(B1, D1, null);
                tree1.Insert(D1, null, null);
                tree1.Insert(C1, E1, F1);
                tree1.Insert(G1, null, null);
                tree1.Insert(F1, H1, I1);
                tree1.Insert(H1, null, null);
                tree1.Insert(I1, null, null);
            }

        }
    }
}
