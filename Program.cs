using System;
using System.Windows.Forms;

namespace LoginApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public class LoginForm : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(20, 20);

            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(100, 20);

            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(20, 50);

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(100, 50);
            txtPassword.PasswordChar = '*';

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(100, 80);
            btnLogin.Click += BtnLogin_Click;

            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);

            Size = new System.Drawing.Size(300, 150);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }
    }
}