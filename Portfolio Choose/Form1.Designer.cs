namespace Portfolio_Choose
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.riskCheckBox1 = new System.Windows.Forms.CheckBox();
            this.riskCheckBox2 = new System.Windows.Forms.CheckBox();
            this.riskCheckBox3 = new System.Windows.Forms.CheckBox();
            this.riskCheckBox4 = new System.Windows.Forms.CheckBox();
            this.fluidityCheckBox1 = new System.Windows.Forms.CheckBox();
            this.fluidityCheckBox2 = new System.Windows.Forms.CheckBox();
            this.fluidityCheckBox3 = new System.Windows.Forms.CheckBox();
            this.demandListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ratioText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.demandListAddButton = new System.Windows.Forms.Button();
            this.demandListMinusButton = new System.Windows.Forms.Button();
            this.devidedAmountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "风险偏好";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.Location = new System.Drawing.Point(612, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.Location = new System.Drawing.Point(16, 26);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(86, 21);
            this.amount.TabIndex = 3;
            this.amount.Text = "总资金量";
            // 
            // amountTextBox
            // 
            this.amountTextBox.AccessibleDescription = "";
            this.amountTextBox.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amountTextBox.Location = new System.Drawing.Point(12, 64);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(246, 71);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.Tag = "";
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "万";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "流动性";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // riskCheckBox1
            // 
            this.riskCheckBox1.AutoSize = true;
            this.riskCheckBox1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.riskCheckBox1.Location = new System.Drawing.Point(15, 44);
            this.riskCheckBox1.Name = "riskCheckBox1";
            this.riskCheckBox1.Size = new System.Drawing.Size(76, 23);
            this.riskCheckBox1.TabIndex = 7;
            this.riskCheckBox1.Text = "高风险";
            this.riskCheckBox1.UseVisualStyleBackColor = true;
            this.riskCheckBox1.CheckedChanged += new System.EventHandler(this.riskCheckBox1_CheckedChanged);
            // 
            // riskCheckBox2
            // 
            this.riskCheckBox2.AutoSize = true;
            this.riskCheckBox2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.riskCheckBox2.Location = new System.Drawing.Point(15, 84);
            this.riskCheckBox2.Name = "riskCheckBox2";
            this.riskCheckBox2.Size = new System.Drawing.Size(92, 23);
            this.riskCheckBox2.TabIndex = 8;
            this.riskCheckBox2.Text = "中等风险";
            this.riskCheckBox2.UseVisualStyleBackColor = true;
            this.riskCheckBox2.CheckedChanged += new System.EventHandler(this.riskCheckBox2_CheckedChanged);
            // 
            // riskCheckBox3
            // 
            this.riskCheckBox3.AutoSize = true;
            this.riskCheckBox3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.riskCheckBox3.Location = new System.Drawing.Point(15, 125);
            this.riskCheckBox3.Name = "riskCheckBox3";
            this.riskCheckBox3.Size = new System.Drawing.Size(76, 23);
            this.riskCheckBox3.TabIndex = 9;
            this.riskCheckBox3.Text = "低风险";
            this.riskCheckBox3.UseVisualStyleBackColor = true;
            this.riskCheckBox3.CheckedChanged += new System.EventHandler(this.riskCheckBox3_CheckedChanged);
            // 
            // riskCheckBox4
            // 
            this.riskCheckBox4.AutoSize = true;
            this.riskCheckBox4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.riskCheckBox4.Location = new System.Drawing.Point(15, 166);
            this.riskCheckBox4.Name = "riskCheckBox4";
            this.riskCheckBox4.Size = new System.Drawing.Size(140, 23);
            this.riskCheckBox4.TabIndex = 10;
            this.riskCheckBox4.Text = "无风险固定收益";
            this.riskCheckBox4.UseVisualStyleBackColor = true;
            this.riskCheckBox4.CheckedChanged += new System.EventHandler(this.riskCheckBox4_CheckedChanged);
            // 
            // fluidityCheckBox1
            // 
            this.fluidityCheckBox1.AutoSize = true;
            this.fluidityCheckBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fluidityCheckBox1.Location = new System.Drawing.Point(23, 48);
            this.fluidityCheckBox1.Name = "fluidityCheckBox1";
            this.fluidityCheckBox1.Size = new System.Drawing.Size(50, 29);
            this.fluidityCheckBox1.TabIndex = 11;
            this.fluidityCheckBox1.Text = "高";
            this.fluidityCheckBox1.UseVisualStyleBackColor = true;
            this.fluidityCheckBox1.CheckedChanged += new System.EventHandler(this.fluidityCheckBox1_CheckedChanged);
            // 
            // fluidityCheckBox2
            // 
            this.fluidityCheckBox2.AutoSize = true;
            this.fluidityCheckBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fluidityCheckBox2.Location = new System.Drawing.Point(23, 100);
            this.fluidityCheckBox2.Name = "fluidityCheckBox2";
            this.fluidityCheckBox2.Size = new System.Drawing.Size(50, 29);
            this.fluidityCheckBox2.TabIndex = 12;
            this.fluidityCheckBox2.Text = "中";
            this.fluidityCheckBox2.UseVisualStyleBackColor = true;
            this.fluidityCheckBox2.CheckedChanged += new System.EventHandler(this.fluidityCheckBox2_CheckedChanged);
            // 
            // fluidityCheckBox3
            // 
            this.fluidityCheckBox3.AutoSize = true;
            this.fluidityCheckBox3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fluidityCheckBox3.Location = new System.Drawing.Point(23, 156);
            this.fluidityCheckBox3.Name = "fluidityCheckBox3";
            this.fluidityCheckBox3.Size = new System.Drawing.Size(50, 29);
            this.fluidityCheckBox3.TabIndex = 13;
            this.fluidityCheckBox3.Text = "低";
            this.fluidityCheckBox3.UseVisualStyleBackColor = true;
            this.fluidityCheckBox3.CheckedChanged += new System.EventHandler(this.fluidityCheckBox3_CheckedChanged);
            // 
            // demandListBox
            // 
            this.demandListBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.demandListBox.FormattingEnabled = true;
            this.demandListBox.ItemHeight = 21;
            this.demandListBox.Location = new System.Drawing.Point(0, 0);
            this.demandListBox.Name = "demandListBox";
            this.demandListBox.Size = new System.Drawing.Size(418, 403);
            this.demandListBox.TabIndex = 14;
            this.demandListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "配置比例";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(7, 44);
            this.vScrollBar1.Maximum = 20;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(48, 147);
            this.vScrollBar1.TabIndex = 16;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // ratioText
            // 
            this.ratioText.AccessibleDescription = "";
            this.ratioText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ratioText.Location = new System.Drawing.Point(71, 47);
            this.ratioText.Name = "ratioText";
            this.ratioText.ReadOnly = true;
            this.ratioText.Size = new System.Drawing.Size(34, 29);
            this.ratioText.TabIndex = 17;
            this.ratioText.Tag = "";
            this.ratioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ratioText.TextChanged += new System.EventHandler(this.ratioText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "%";
            // 
            // demandListAddButton
            // 
            this.demandListAddButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.demandListAddButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.demandListAddButton.Location = new System.Drawing.Point(24, 430);
            this.demandListAddButton.Name = "demandListAddButton";
            this.demandListAddButton.Size = new System.Drawing.Size(140, 76);
            this.demandListAddButton.TabIndex = 19;
            this.demandListAddButton.Text = "新增";
            this.demandListAddButton.UseVisualStyleBackColor = true;
            this.demandListAddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // demandListMinusButton
            // 
            this.demandListMinusButton.Font = new System.Drawing.Font("宋体", 12F);
            this.demandListMinusButton.Location = new System.Drawing.Point(211, 430);
            this.demandListMinusButton.Name = "demandListMinusButton";
            this.demandListMinusButton.Size = new System.Drawing.Size(149, 76);
            this.demandListMinusButton.TabIndex = 20;
            this.demandListMinusButton.Text = "删除";
            this.demandListMinusButton.UseVisualStyleBackColor = true;
            this.demandListMinusButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // devidedAmountTextBox
            // 
            this.devidedAmountTextBox.AccessibleDescription = "";
            this.devidedAmountTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devidedAmountTextBox.Location = new System.Drawing.Point(71, 127);
            this.devidedAmountTextBox.Name = "devidedAmountTextBox";
            this.devidedAmountTextBox.ReadOnly = true;
            this.devidedAmountTextBox.Size = new System.Drawing.Size(73, 29);
            this.devidedAmountTextBox.TabIndex = 21;
            this.devidedAmountTextBox.Tag = "";
            this.devidedAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.devidedAmountTextBox.TextChanged += new System.EventHandler(this.devidedAmountTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "万";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.amountTextBox);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(219, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 202);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.riskCheckBox1);
            this.panel2.Controls.Add(this.riskCheckBox2);
            this.panel2.Controls.Add(this.riskCheckBox3);
            this.panel2.Controls.Add(this.riskCheckBox4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(219, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 202);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.fluidityCheckBox1);
            this.panel3.Controls.Add(this.fluidityCheckBox2);
            this.panel3.Controls.Add(this.fluidityCheckBox3);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(392, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 202);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.vScrollBar1);
            this.panel4.Controls.Add(this.ratioText);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.devidedAmountTextBox);
            this.panel4.Location = new System.Drawing.Point(219, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 230);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.demandListBox);
            this.panel5.Controls.Add(this.demandListAddButton);
            this.panel5.Controls.Add(this.demandListMinusButton);
            this.panel5.Location = new System.Drawing.Point(578, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 539);
            this.panel5.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "1.请输入总计投资金额";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 291);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 60);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "2.请输入风险偏好\r\n 及流动性需求";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(3, 555);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(201, 69);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "3.请输入该种需求对应产品的配置比例";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 119);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(39, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 119);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1008, 722);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "国泰君安嘉兴营业部-资产配置条件选择";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox riskCheckBox1;
        private System.Windows.Forms.CheckBox riskCheckBox2;
        private System.Windows.Forms.CheckBox riskCheckBox3;
        private System.Windows.Forms.CheckBox riskCheckBox4;
        private System.Windows.Forms.CheckBox fluidityCheckBox1;
        private System.Windows.Forms.CheckBox fluidityCheckBox2;
        private System.Windows.Forms.CheckBox fluidityCheckBox3;
        private System.Windows.Forms.ListBox demandListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox ratioText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button demandListAddButton;
        private System.Windows.Forms.Button demandListMinusButton;
        private System.Windows.Forms.TextBox devidedAmountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

