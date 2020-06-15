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
    public partial class CartForm : Form
    {
        public int userId;
        public CartForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ExecuteQuery(string commandText)
        {
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ShowCart()
        {
            string commandText = "SELECT s.ID,a.AccessoryName, s.amount, 'шт. x' as po,s.price,'грн. =' as uah,s.totalsum,'грн.' as sumuah ";
            commandText += "FROM accessory a,shoppingcart s WHERE s.accessoryID=a.ID AND s.userId=" + Convert.ToString(userId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "cart");
            GoodsDataGrid.DataSource = dataset.Tables[0].DefaultView;
            GoodsDataGrid.Columns["ID"].Visible = false;
            GoodsDataGrid.Columns["AccessoryName"].Width = 450;
            GoodsDataGrid.Columns["amount"].Width = 25;
            GoodsDataGrid.Columns["po"].Width = 40;
            GoodsDataGrid.Columns["price"].Width = 50;
            GoodsDataGrid.Columns["uah"].Width = 45;
            GoodsDataGrid.Columns["totalsum"].Width = 50;
            GoodsDataGrid.Columns["sumuah"].Width = 40;
            if (GoodsDataGrid.RowCount == 0)
                TitleLabel.Text = "В кошику немає товарiв";
            else
                TitleLabel.Text = "Перелiк товарiв у кошику";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (GoodsDataGrid.CurrentCell != null)
            {
                int index = GoodsDataGrid.CurrentCell.RowIndex;
                int ID = (int)GoodsDataGrid[0, index].Value;
                DialogResult result = MessageBox.Show("Видалити товар з кошика?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string commandText = "DELETE FROM shoppingcart WHERE ID=" + Convert.ToString(ID);
                    ExecuteQuery(commandText);
                    ShowCart();
                }
            }
            else MessageBox.Show("Не обрано жодного товару у кошику!", "Помилка!", MessageBoxButtons.OK);
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ShowCart();
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Очистити кошик?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string commandText = "DELETE FROM shoppingcart WHERE userID=" + Convert.ToString(userId);
                ExecuteQuery(commandText);
                ShowCart();
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            if (GoodsDataGrid.RowCount == 0)
                MessageBox.Show("В Вашому кошику немає товарiв!", "Помилка", MessageBoxButtons.OK);
            else
            {
                OrderForm orderForm = new OrderForm { userId = this.userId };
                orderForm.ShowDialog();
                if (orderForm.DialogResult == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
