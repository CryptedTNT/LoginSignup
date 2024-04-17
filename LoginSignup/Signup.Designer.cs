namespace LoginSignup
{
    partial class Signup
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
            txtUser = new TextBox();
            txtCPass = new TextBox();
            txtPass = new TextBox();
            btnSignup = new Button();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F);
            label1.Location = new Point(286, 143);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F);
            label2.Location = new Point(283, 182);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F);
            label3.Location = new Point(222, 220);
            label3.Name = "label3";
            label3.Size = new Size(135, 16);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(360, 142);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(126, 23);
            txtUser.TabIndex = 3;
            // 
            // txtCPass
            // 
            txtCPass.Location = new Point(360, 219);
            txtCPass.Name = "txtCPass";
            txtCPass.PasswordChar = '•';
            txtCPass.Size = new Size(126, 23);
            txtCPass.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(360, 181);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(126, 23);
            txtPass.TabIndex = 5;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(432, 285);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(100, 28);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(286, 9);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(275, 71);
            label4.TabIndex = 7;
            label4.Text = "Instacram";
            // 
            // button1
            // 
            button1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(305, 285);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 8;
            button1.Text = "Go back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnSignup);
            Controls.Add(txtPass);
            Controls.Add(txtCPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtCPass;
        private TextBox txtPass;
        private Button btnSignup;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
    }
}