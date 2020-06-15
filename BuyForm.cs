using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class BuyForm : Form
    {
        public int accessoryId;
        public BuyForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CountSum()
        {
            double price = Convert.ToDouble(PriceLabel.Text);
            int amount = (int)AmountUpDown.Value;
            double sum = price * amount;
            SumLabel.Text = Convert.ToString(sum);
        }

        private void AmountUpDown_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            CountSum();
        }
    }
}
