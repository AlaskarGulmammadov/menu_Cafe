namespace menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox8 = new ComboBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(559, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "cafeMOOD";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkGoldenrod;
            listBox1.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = SystemColors.InactiveBorder;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Location = new Point(29, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 625);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 35);
            label2.TabIndex = 2;
            label2.Text = "Menyu";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBox8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(865, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 625);
            panel1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 436);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(410, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(410, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(410, 142);
            label11.Name = "label11";
            label11.Size = new Size(166, 35);
            label11.TabIndex = 20;
            label11.Text = "Porsiyon sayı";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Cursor = Cursors.WaitCursor;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 534);
            button1.Name = "button1";
            button1.Size = new Size(185, 56);
            button1.TabIndex = 19;
            button1.Text = "Sifarişi təsdiqlə";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(410, 378);
            label7.Name = "label7";
            label7.Size = new Size(167, 35);
            label7.TabIndex = 17;
            label7.Text = "Şirniyyat sayı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(410, 253);
            label8.Name = "label8";
            label8.Size = new Size(104, 35);
            label8.TabIndex = 15;
            label8.Text = "İçki sayı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(410, 136);
            label9.Name = "label9";
            label9.Size = new Size(0, 35);
            label9.TabIndex = 13;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Dönər çörəkdə(50qr)", "Dönər çörəkdə(100qr)", "Dönər lavaşda(50qr)", "Dönər Lavaşda(100qr)", "Plov üstü Dönər(150qr)" });
            comboBox8.Location = new Point(410, 70);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(204, 28);
            comboBox8.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(410, 15);
            label10.Name = "label10";
            label10.Size = new Size(175, 35);
            label10.TabIndex = 11;
            label10.Text = "Ana yeməklər";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Magnolya", "Napoleon", "Paxlava (Az)", "Paxlava (Tr)" });
            comboBox4.Location = new Point(13, 435);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(204, 28);
            comboBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 378);
            label6.Name = "label6";
            label6.Size = new Size(148, 35);
            label6.TabIndex = 9;
            label6.Text = "Şirniyyatlar";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Çay", "Kola", "Fanta", "Su", "Smoothie", "Milkshake" });
            comboBox3.Location = new Point(13, 312);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(204, 28);
            comboBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 253);
            label5.Name = "label5";
            label5.Size = new Size(85, 35);
            label5.TabIndex = 7;
            label5.Text = "İçkilər";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 197);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 28);
            comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(128, 35);
            label4.TabIndex = 5;
            label4.Text = "Rezerv no";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 15);
            label3.Name = "label3";
            label3.Size = new Size(117, 35);
            label3.TabIndex = 3;
            label3.Text = "Masa No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1615, 797);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox8;
        private Label label10;
        private ComboBox comboBox4;
        private Label label6;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label11;
    }
}
