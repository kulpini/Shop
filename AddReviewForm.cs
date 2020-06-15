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
    public partial class AddReviewForm : Form
    {
        public int userId;
        public int accessoryId;
        public AddReviewForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void AddReviewButton_Click(object sender, EventArgs e)
        {
            if (ScoreComboBox.Text == "")
                MessageBox.Show("Виберiть Вашу оцiнку!", "Помилка", MessageBoxButtons.OK);
            else
            {
                string commandText = "INSERT INTO review (userID,accessoryID,score,review,reviewdate) VALUES ("+Convert.ToString(userId)+",";
                commandText += Convert.ToString(accessoryId) + "," + ScoreComboBox.Text + ",'" + ReviewRichText.Text + "','"+ Convert.ToString(DateTime.Today) + "')";
                MainForm form = new MainForm();
                OleDbConnection connection = new OleDbConnection(form.connectionString);
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = commandText;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ваш вiдгук збережено!", "", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
