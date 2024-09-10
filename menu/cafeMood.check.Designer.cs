namespace menu
{
    partial class cafeMood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(676, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 36);
            label1.TabIndex = 0;
            label1.Text = "Sifarişiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(100, 72);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Masa no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(522, 75);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // cafeMood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1615, 797);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cafeMood";
            Text = "cafeMood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}