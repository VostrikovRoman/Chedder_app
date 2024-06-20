namespace Chedder_app
{
    partial class SignIn_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn_form));
            pictureBox1 = new PictureBox();
            login = new TextBox();
            password = new TextBox();
            sign_in_button = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sign_in_button.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_2;
            pictureBox1.Location = new Point(553, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(881, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(247, 233, 217);
            login.Font = new Font("Lucida Sans", 40F, FontStyle.Bold);
            login.ForeColor = Color.FromArgb(36, 36, 36);
            login.Location = new Point(587, 631);
            login.Name = "login";
            login.PlaceholderText = "логин";
            login.Size = new Size(820, 86);
            login.TabIndex = 2;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(247, 233, 217);
            password.Font = new Font("Lucida Sans", 40F, FontStyle.Bold);
            password.ForeColor = Color.FromArgb(36, 36, 36);
            password.Location = new Point(587, 744);
            password.Name = "password";
            password.PlaceholderText = "пароль";
            password.Size = new Size(820, 86);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            // 
            // sign_in_button
            // 
            sign_in_button.BackColor = Color.FromArgb(238, 190, 29);
            sign_in_button.Controls.Add(label2);
            sign_in_button.Cursor = Cursors.Hand;
            sign_in_button.Location = new Point(722, 890);
            sign_in_button.Name = "sign_in_button";
            sign_in_button.Size = new Size(568, 99);
            sign_in_button.TabIndex = 3;
            sign_in_button.Click += sign_in_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Lucida Sans", 40F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(94, 21, 4);
            label2.Location = new Point(170, 9);
            label2.Name = "label2";
            label2.Size = new Size(224, 76);
            label2.TabIndex = 2;
            label2.Text = "Войти";
            label2.Click += sign_in_button_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1024, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(10, 27);
            textBox3.TabIndex = 1;
            // 
            // SignIn_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 129, 17);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(sign_in_button);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1078);
            Name = "SignIn_form";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SignIn_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sign_in_button.ResumeLayout(false);
            sign_in_button.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox login;
        private TextBox password;
        private Panel sign_in_button;
        private Label label2;
        private TextBox textBox3;
    }
}