using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        public int userId;
        static string pathToDB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shop.mdb");
        public string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathToDB;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowGoods(string commandText)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, connection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset, "accessory");
            GoodsDataGrid.DataSource = dataset.Tables[0].DefaultView;
            GoodsDataGrid.Columns["ID"].Visible = false;
            GoodsDataGrid.Columns["AccessoryName"].Width = 550;
            GoodsDataGrid.Columns["price"].Width = 60;
            GoodsDataGrid.Columns["uah"].Width = 60;

        }

        private void ShowCharacteristics(int accessoryID)
        {
            string commandText = "SELECT type,manufacturer,country,image FROM accessory WHERE ID=" + Convert.ToString(accessoryID);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TypeLabel.Text = Convert.ToString(reader[0]);
                ManufacturerLabel.Text = Convert.ToString(reader[1]);
                CountryLabel.Text = Convert.ToString(reader[2]);
                string img = Convert.ToString(reader[3]);
                if (img != "")
                    img = "img\\" + img;
                else
                    img = "img\\no_image.jpg";
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, img);
                accessoryPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void ExecuteQuery(string commandText)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.DialogResult != DialogResult.OK)
                Application.Exit();
            else
            {
                userId = loginForm.userId;
                string commandText = "SELECT UserName FROM account WHERE ID=" + Convert.ToString(userId);
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = commandText;
                UserNameLabel.Text = Convert.ToString(command.ExecuteScalar());
                connection.Close();
                commandText = "SELECT ID, AccessoryName,price, 'грн.' as uah FROM accessory";
                ShowGoods(commandText);
                ShowRecomendation();
                GoodsDataGrid.ClearSelection();
                GoodsDataGrid.Rows[0].Cells[1].Selected = true;
                int ID = (int)GoodsDataGrid[0, 0].Value;
                ShowCharacteristics(ID);
                ShowRating(ID);
            }
        }

        private void ShowRecomendation()
        {
            string commandText = "SELECT a.AccessoryName,a.price,' грн.' as uah FROM accessory a,review r WHERE r.score=5 AND r.accessoryID=a.ID";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, connection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset, "accessory");
            RecomendationDataGrid.DataSource = dataset.Tables[0].DefaultView;
            RecomendationDataGrid.Columns["AccessoryName"].Width = 180;
            RecomendationDataGrid.Columns["price"].Width = 50;
            RecomendationDataGrid.Columns["uah"].Width = 30;
        }

        private void AccountLabel_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm { userId = this.userId};
            accountForm.ShowDialog();
        }

        private void ShowRating(int accessoryID)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img\\nostar.jpg");
            RatingPicture.Image = Image.FromFile(imagePath);
            int scoreCount, scoreSum, rating;
            string commandText = "SELECT count(score) FROM review WHERE accessoryID=" + Convert.ToString(accessoryID);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                scoreCount = Convert.ToInt32(reader[0]);
            }
            else
                scoreCount = 0;
            
            commandText = "SELECT sum(score) FROM review WHERE accessoryID=" + Convert.ToString(accessoryID);
            command = connection.CreateCommand();
            command.CommandText = commandText;
            object sum = command.ExecuteScalar();
            if (sum == DBNull.Value)
                scoreSum = 0;
            else
                scoreSum = Convert.ToInt32(command.ExecuteScalar());
            if (scoreCount == 0)
            {
                rating = 0;
                RatingLabel.Text = "0";
            }
            else
            {
                rating = (int)scoreSum / scoreCount;
                string ratingImage = "img\\" + Convert.ToString(rating) + "star.jpg";
                imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ratingImage);
                RatingPicture.Image = Image.FromFile(imagePath);
                RatingLabel.Text = Convert.ToString(rating);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string commandText = "SELECT ID, AccessoryName,price, 'грн.' as uah FROM accessory";
            if (SearchTextBox.Text != "")
                commandText += " WHERE AccessoryName LIKE '" + SearchTextBox.Text + "%'";
            ShowGoods(commandText);
        }

        private void GoodsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GoodsDataGrid.CurrentCell.RowIndex;
            int ID = (int)GoodsDataGrid[0, index].Value;
            ShowCharacteristics(ID);
            ShowRating(ID);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (GoodsDataGrid.CurrentCell != null)
            {
                int index = GoodsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)GoodsDataGrid[0, index].Value;
                string accessoryName = Convert.ToString(GoodsDataGrid[1, index].Value);
                string accessoryPrice = Convert.ToString(GoodsDataGrid[2, index].Value);
                BuyForm buyForm = new BuyForm();
                buyForm.AccessoryLabel.Text = accessoryName;
                buyForm.PriceLabel.Text = accessoryPrice;
                buyForm.ShowDialog();
                if (buyForm.DialogResult == DialogResult.OK)
                {
                    int amount = (int)buyForm.AmountUpDown.Value;
                    double sum = Convert.ToDouble(buyForm.SumLabel.Text);
                    string commandText = "INSERT INTO shoppingcart (userID,accessoryID,amount,price,totalsum) VALUES (";
                    commandText += userId+","+ID+","+Convert.ToString(amount)+","+accessoryPrice+","+Convert.ToString(sum)+")";
                    ExecuteQuery(commandText);
                    MessageBox.Show("Товар додано до кошика", "", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Не обран товар!", "Помилка!", MessageBoxButtons.OK);
        }

        private void AddReviewLabel_Click(object sender, EventArgs e)
        {
            if (GoodsDataGrid.CurrentCell != null)
            {
                int index = GoodsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)GoodsDataGrid[0, index].Value;
                string accessoryName = Convert.ToString(GoodsDataGrid[1, index].Value);
                AddReviewForm reviewForm = new AddReviewForm { userId = this.userId, accessoryId = ID };
                reviewForm.AccessoryLabel.Text = accessoryName;
                reviewForm.ShowDialog();
                if (reviewForm.DialogResult == DialogResult.OK)
                {
                    ShowCharacteristics(ID);
                    ShowRating(ID);
                    ShowRecomendation();
                }
            }
            else
                MessageBox.Show("Не обран товар!", "Помилка!", MessageBoxButtons.OK);
        }

        private void ShowReviewLabel_Click(object sender, EventArgs e)
        {
            if (GoodsDataGrid.CurrentCell != null)
            {
                int index = GoodsDataGrid.CurrentCell.RowIndex;   
                int ID = (int)GoodsDataGrid[0, index].Value;
                string accessoryName = Convert.ToString(GoodsDataGrid[1, index].Value);
                ReviewsForm reviewsForm = new ReviewsForm { accessoryId = ID };
                reviewsForm.AccessoryLabel.Text = accessoryName;
                reviewsForm.ShowDialog();
            }
            else
                MessageBox.Show("Не обран товар!", "Помилка!", MessageBoxButtons.OK);
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm { userId = this.userId };
            cartForm.ShowDialog();
        }

    }
}
