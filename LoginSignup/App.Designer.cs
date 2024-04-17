namespace LoginSignup
{
    partial class App
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            Welcome = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.lazy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 24F);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(73, 14);
            label4.Name = "label4";
            label4.Size = new Size(184, 48);
            label4.TabIndex = 11;
            label4.Text = "Instacram";
            label4.Click += label4_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Location = new Point(20, 87);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(0, 15);
            Welcome.TabIndex = 12;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(56, 96);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(102, 27);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "label1";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(Welcome);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Name = "App";
            Text = "App";
            Load += App_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label Welcome;
        private Label lblWelcome;
    }
}