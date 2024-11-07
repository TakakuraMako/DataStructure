namespace _05字符串与整数集合
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "集合A";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "移出集合";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "加入集合";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "集合B";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "移出集合";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 36);
            this.button4.TabIndex = 1;
            this.button4.Text = "加入集合";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "A交B";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "A的补";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(25, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "A差B";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "A并B";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "集合元素的最大个数为80";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(25, 486);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 29);
            this.button9.TabIndex = 10;
            this.button9.Text = "相等？";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(25, 521);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 29);
            this.button10.TabIndex = 9;
            this.button10.Text = "子集？";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "集合A";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(799, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(799, 25);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(799, 25);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(799, 25);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "集合B";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(210, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(799, 25);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(210, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(799, 25);
            this.textBox6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "集合A交B";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(210, 343);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(799, 25);
            this.textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(210, 312);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(799, 25);
            this.textBox8.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "集合A并B";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(210, 439);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(799, 25);
            this.textBox9.TabIndex = 25;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(210, 408);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(799, 25);
            this.textBox10.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "集合A差B";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(210, 525);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(799, 54);
            this.textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(210, 494);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(799, 25);
            this.textBox12.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "集合A的补";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            79,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(157, 25);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(16, 35);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            79,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(157, 25);
            this.numericUpDown2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 591);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "整数集合上机实验";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}