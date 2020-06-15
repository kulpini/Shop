namespace Shop
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.GoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsDataGrid
            // 
            this.GoodsDataGrid.AllowUserToAddRows = false;
            this.GoodsDataGrid.AllowUserToDeleteRows = false;
            this.GoodsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoodsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.GoodsDataGrid.Location = new System.Drawing.Point(12, 45);
            this.GoodsDataGrid.Name = "GoodsDataGrid";
            this.GoodsDataGrid.RowHeadersVisible = false;
            this.GoodsDataGrid.RowHeadersWidth = 51;
            this.GoodsDataGrid.RowTemplate.Height = 30;
            this.GoodsDataGrid.Size = new System.Drawing.Size(844, 246);
            this.GoodsDataGrid.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(9, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(650, 23);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Перелiк товарiв у кошику";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteButton.Location = new System.Drawing.Point(855, 64);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 40);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.FlatAppearance.BorderSize = 0;
            this.EraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EraseButton.ForeColor = System.Drawing.Color.Maroon;
            this.EraseButton.Location = new System.Drawing.Point(855, 110);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(99, 60);
            this.EraseButton.TabIndex = 5;
            this.EraseButton.Text = "очистити кошик";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.FlatAppearance.BorderSize = 0;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellButton.ForeColor = System.Drawing.Color.Maroon;
            this.SellButton.Location = new System.Drawing.Point(855, 187);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(99, 40);
            this.SellButton.TabIndex = 6;
            this.SellButton.Text = "оформити замовлення";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Maroon;
            this.CloseButton.Location = new System.Drawing.Point(862, 251);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(99, 40);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "закрити";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(966, 298);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.GoodsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваш кошик";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodsDataGrid;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button CloseButton;
    }
}