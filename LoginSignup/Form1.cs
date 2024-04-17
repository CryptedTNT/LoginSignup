namespace LoginSignup
{
    public partial class Login : Form
    {
        public string username;
        private string password;
        public Login()
        {
            InitializeComponent();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "admin" &&  pass == "admin123") 
            {
                MessageBox.Show("Login successful!");
                var app = new App(txtUser.Text);
                this.Hide();
                app.Show();
            }
            else if (user == username && pass == password)
            {
                MessageBox.Show("Login successful!");
                var app = new App(txtUser.Text);
                this.Hide();
                app.Show();
            }
            else if (user != username || pass != password)
            {
                MessageBox.Show("Username or password is incorrect. Please try again!");
                txtUser.Clear();
                txtPass.Clear();
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var signup2 = new Signup();
            signup2.ShowDialog();

            if (signup2.DialogResult == DialogResult.OK)
            {
                username = signup2.Username;
                password = signup2.Password;    
            }
        }
    }
}
