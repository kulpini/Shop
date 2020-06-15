using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class AccountForm : Form
    {
        public int userId;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            string commandText = "SELECT UserName,phone,city FROM account WHERE ID="+Convert.ToString(userId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = Convert.ToString(reader[0]);
                PhoneTextBox.Text = Convert.ToString(reader[1]);
                CityTextBox.Text = Convert.ToString(reader[2]);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string commandText = "UPDATE account SET UserName = '"+NameTextBox.Text+"', phone ='"+ PhoneTextBox.Text;
            commandText += "', city = '" + CityTextBox.Text + "' WHERE ID=" + Convert.ToString(userId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Змiни збереженi", "Особистий кабiнет", MessageBoxButtons.OK);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
