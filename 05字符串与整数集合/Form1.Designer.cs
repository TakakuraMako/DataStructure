namespace _05字符串与整数集合
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "写入字符串";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "This is a test string.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "该串的长度为：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "取子串";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "StartIndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 25);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "新串";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(523, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 25);
            this.textBox3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "StartIndex";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "删除子串";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "新串";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "新串";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(523, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 25);
            this.textBox4.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "子串";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "StartIndex";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "插入子串";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 25);
            this.textBox5.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "匹配模式";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "模式串";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 283);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(105, 25);
            this.textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(354, 280);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(105, 25);
            this.textBox7.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "位置";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(122, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(152, 25);
            this.textBox8.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "得到拷贝串";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "连接串";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(482, 397);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(251, 25);
            this.textBox9.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(439, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "新串";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(272, 397);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(136, 25);
            this.textBox10.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "写入另一个串";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(512, 25);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(34, 25);
            this.textBox11.TabIndex = 37;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(213, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 25);
            this.numericUpDown1.TabIndex = 38;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(212, 150);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(93, 25);
            this.numericUpDown2.TabIndex = 39;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(212, 215);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(93, 25);
            this.numericUpDown3.TabIndex = 40;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(364, 82);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(93, 25);
            this.numericUpDown4.TabIndex = 41;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(364, 213);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(93, 25);
            this.numericUpDown5.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "串实验";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
    }
}