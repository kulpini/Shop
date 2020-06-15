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
    public partial class ReviewsForm : Form
    {
        public int accessoryId;
        public ReviewsForm()
        {
            InitializeComponent();
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            string commandText = "SELECT r.reviewdate, a.UserName, r.score, r.review FROM account a,review r WHERE a.ID=r.userID and r.accessoryID=" + Convert.ToString(accessoryId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, connection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset, "accessory");
            ReviewDataGrid.DataSource = dataset.Tables[0].DefaultView;
            ReviewDataGrid.Columns["reviewdate"].Width = 130;
            ReviewDataGrid.Columns["UserName"].Width = 250;
            ReviewDataGrid.Columns["score"].Visible = false;
            ReviewDataGrid.Columns["review"].Visible = false;
            int index = ReviewDataGrid.CurrentCell.RowIndex;
            ScoreLabel.Text = Convert.ToString(ReviewDataGrid[2, index].Value);
            ReviewRichTextBox.Text = Convert.ToString(ReviewDataGrid[3, index].Value);
        }

        private void ReviewDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ReviewDataGrid.CurrentCell.RowIndex;
            ScoreLabel.Text = Convert.ToString(ReviewDataGrid[2, index].Value);
            ReviewRichTextBox.Text = Convert.ToString(ReviewDataGrid[3, index].Value);
        }
    }
}
