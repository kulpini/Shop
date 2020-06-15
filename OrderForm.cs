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
    public partial class OrderForm : Form
    {
        
        public int userId;
        public OrderForm()
        {
            InitializeComponent();
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

        private void MakeOrder()
        {
            int accessoryId, amount;
            double price, totalsum;
            string commandText = "SELECT accessoryID,amount,price,totalsum FROM shoppingcart WHERE userID="+Convert.ToString(userId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { 
                accessoryId = Convert.ToInt32(reader[0]);
                amount = Convert.ToInt32(reader[1]);
                price = Convert.ToDouble(reader[2]);
                totalsum = Convert.ToDouble(reader[3]);
                commandText = "INSERT INTO sale (userID,accessoryID,amount,price,ordersum,saledate) VALUES (";
                commandText += Convert.ToString(userId) + "," + Convert.ToString(accessoryId) + "," + Convert.ToString(amount);
                commandText +=","+Convert.ToString(price)+","+Convert.ToString(totalsum)+",'"+ Convert.ToString(DateTime.Today) + "')";
                ExecuteQuery(commandText);
            }
        }

        private void ClearCart(int ID)
        {
            string commandText = "DELETE FROM shoppingcart WHERE userID="+Convert.ToString(ID);
            ExecuteQuery(commandText);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            int orderSum;
            string commandText = "SELECT sum(totalsum) FROM shoppingcart WHERE userID="+Convert.ToString(userId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            object sum = command.ExecuteScalar();
            if (sum == DBNull.Value)
                orderSum = 0;
            else
                orderSum = Convert.ToInt32(command.ExecuteScalar());
            OrderSumLabel.Text = Convert.ToString(orderSum);
            connection.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
                MessageBox.Show("Введiть ПIБ отримувача!", "Помилка", MessageBoxButtons.OK);
            else if (CityTextBox.Text == "")
                MessageBox.Show("Введiть мiсто доставки!", "Помилка", MessageBoxButtons.OK);
            else if (PhoneTextBox.Text == "")
                MessageBox.Show("Введiть контактний телефон!", "Помилка", MessageBoxButtons.OK);
            else
            {
                MakeOrder();
                ClearCart(userId);
                MessageBox.Show("Ваше замовлення прийнято.\nНезабаром з Вами зв`яжеться наш менеджер.", "Дякуємо за покупку", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
