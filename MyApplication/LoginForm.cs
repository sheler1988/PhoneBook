using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Persistence.DatabaseContext? databaseContext = null;

        private void LoginForm_Load(object sender, EventArgs e)
        {

            databaseContext = new Persistence.DatabaseContext();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton(object sender, EventArgs e)
        {


        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text =
               Infrastructure.Utility.FixText(usernameTextBox.Text);

            passwordTextBox.Text =
                Infrastructure.Utility.FixText(passwordTextBox.Text);

            if (usernameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                var errorMessage = "username and password is required!";
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
            try
            {

                var foundUser = databaseContext.Users
                    .Where(c => c.Username.ToLower() == usernameTextBox.Text.ToLower())
                    .FirstOrDefault();

                if (foundUser == null)
                {
                    var errorMessage = "username and/or password is not correct!";
                    System.Windows.Forms.MessageBox.Show(text: errorMessage);
                    usernameTextBox.Focus();
                    return;
                }

                if (string.Compare(foundUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    var errorMessage = "username and/or password is not correct!";
                    System.Windows.Forms.MessageBox.Show(text: errorMessage);
                    usernameTextBox.Focus();
                    return;
                }
                Hide();
                Infrastructure.Utility.AauthenticatedUser = foundUser;
                var mainForm = new MainForm();
                mainForm.Show();

            }
            catch (Exception)
            {
                databaseContext?.Dispose();
                databaseContext = null;
            }


        }
    }
}
