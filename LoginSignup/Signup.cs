using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSignup
{
    public partial class Signup : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text;
            string password = txtPass.Text;
            string cpassword = txtCPass.Text;
            if (password.Length >= 8)
            {

                if (password == cpassword)
                {
                    Username = username;
                    Password = password;
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Signup successful!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password do not match. Please try again!");
                    txtPass.Clear();
                    txtCPass.Clear();
                }
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input a charecter or fill up all information!");
            }
            else
            {
                MessageBox.Show("Username or password must be 8 characters!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
