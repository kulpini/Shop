using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class LoginForm : Form
    {
        public int userId;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ((EmailLoginTextBox.Text == "") || (PasswordLoginTextBox.Text == ""))
                MessageBox.Show("Не введено логiн або пароль", "Помилка!", MessageBoxButtons.OK);
            else
            {
                string login = EmailLoginTextBox.Text;
                string password = PasswordLoginTextBox.Text;
                string commandText = "SELECT ID FROM account WHERE email = '" + login + "' AND password ='" + password + "'";
                MainForm form = new MainForm();
                OleDbConnection connection = new OleDbConnection(form.connectionString);
                OleDbCommand command = new OleDbCommand(commandText, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    userId = (int)reader[0];
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Невiрна комбiнацiя логiна/пароля", "Помилка!", MessageBoxButtons.OK);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if ((EmailRegistrationTextBox.Text == "") || (PasswordRegistrationTextBox.Text == ""))
                MessageBox.Show("Не введено логiн або пароль", "Помилка!", MessageBoxButtons.OK);
            else
            {
                string login = EmailRegistrationTextBox.Text;
                string password = PasswordRegistrationTextBox.Text;
                string commandText = "INSERT INTO [account]([email], [password]) VALUES ('"+login+"','"+ password + "')";
                MainForm form = new MainForm();
                OleDbConnection connection = new OleDbConnection(form.connectionString);
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = commandText;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ваш акаунт зареєстровано. \nТепер Ви можете увiйти пiд своим логiном та паролем", "Реєстрацiя акаунта", MessageBoxButtons.OK);
                RegistrationTab.SelectTab("LoginTabPage");
            }
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationTab.SelectTab("RegistrationTabPage");
        }
    }
}
