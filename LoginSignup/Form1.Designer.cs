namespace LoginSignup
{
    partial class Login
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
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnSignup = new Button();
            btnLogin = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(246, 141);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(71, 16);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(247, 194);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(71, 16);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            lblPass.Click += lblPass_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(325, 138);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(201, 23);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(325, 191);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(201, 23);
            txtPass.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(328, 257);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(86, 24);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(437, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 24);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 71);
            label1.TabIndex = 6;
            label1.Text = "Instacram";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.lazy;
            pictureBox1.Location = new Point(234, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnSignup;
        private Button btnLogin;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
