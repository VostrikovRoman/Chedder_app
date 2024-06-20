namespace Chedder_app
{
    partial class Kitchen_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen_form));
            label1 = new Label();
            panel1 = new Panel();
            back_btn = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_btn).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 208, 172);
            label1.Location = new Point(814, 53);
            label1.Name = "label1";
            label1.Size = new Size(278, 95);
            label1.TabIndex = 0;
            label1.Text = "Кухня";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 129, 17);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 178);
            panel1.TabIndex = 2;
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.Image = Properties.Resources.backward_1;
            back_btn.Location = new Point(45, 948);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(104, 99);
            back_btn.SizeMode = PictureBoxSizeMode.Zoom;
            back_btn.TabIndex = 10;
            back_btn.TabStop = false;
            back_btn.Click += back_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 233, 217);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(270, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 330);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 233, 217);
            panel2.Location = new Point(270, 600);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 330);
            panel2.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(247, 233, 217);
            panel4.Location = new Point(740, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 330);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(247, 233, 217);
            panel5.Location = new Point(740, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(430, 330);
            panel5.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 233, 217);
            panel8.Location = new Point(1210, 600);
            panel8.Name = "panel8";
            panel8.Size = new Size(430, 330);
            panel8.TabIndex = 17;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(247, 233, 217);
            panel9.Location = new Point(1210, 231);
            panel9.Name = "panel9";
            panel9.Size = new Size(430, 330);
            panel9.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(94, 21, 4);
            label2.Location = new Point(137, 12);
            label2.Name = "label2";
            label2.Size = new Size(141, 48);
            label2.TabIndex = 1;
            label2.Text = "Кухня";
            // 
            // Kitchen_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 208, 172);
            ClientSize = new Size(1918, 1078);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(back_btn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1078);
            Name = "Kitchen_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)back_btn).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox back_btn;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Label label2;
    }
}