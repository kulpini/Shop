namespace Shop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CartButton = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingPicture = new System.Windows.Forms.PictureBox();
            this.ShowReviewLabel = new System.Windows.Forms.Label();
            this.AddReviewLabel = new System.Windows.Forms.Label();
            this.accessoryPictureBox = new System.Windows.Forms.PictureBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.RecomendationDataGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecomendationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 52);
            this.panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(339, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(37, 37);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(68, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 26);
            this.SearchTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фiльтр";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CartButton);
            this.panel2.Controls.Add(this.AccountLabel);
            this.panel2.Controls.Add(this.UserNameLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(944, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 52);
            this.panel2.TabIndex = 2;
            // 
            // CartButton
            // 
            this.CartButton.FlatAppearance.BorderSize = 0;
            this.CartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButton.Image = ((System.Drawing.Image)(resources.GetObject("CartButton.Image")));
            this.CartButton.Location = new System.Drawing.Point(328, 8);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(38, 38);
            this.CartButton.TabIndex = 4;
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // AccountLabel
            // 
            this.AccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountLabel.Location = new System.Drawing.Point(204, 8);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(123, 17);
            this.AccountLabel.TabIndex = 3;
            this.AccountLabel.Text = "особистий кабiнет ";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountLabel.Click += new System.EventHandler(this.AccountLabel_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(10, 25);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(317, 17);
            this.UserNameLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ласкаво просимо, ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.RecomendationDataGrid);
            this.panel3.Controls.Add(this.RatingLabel);
            this.panel3.Controls.Add(this.RatingPicture);
            this.panel3.Controls.Add(this.ShowReviewLabel);
            this.panel3.Controls.Add(this.AddReviewLabel);
            this.panel3.Controls.Add(this.accessoryPictureBox);
            this.panel3.Controls.Add(this.BuyButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CountryLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ManufacturerLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TypeLabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.GoodsDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 556);
            this.panel3.TabIndex = 1;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RatingLabel.Location = new System.Drawing.Point(984, 357);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(17, 18);
            this.RatingLabel.TabIndex = 13;
            this.RatingLabel.Text = "0";
            // 
            // RatingPicture
            // 
            this.RatingPicture.Location = new System.Drawing.Point(848, 357);
            this.RatingPicture.Name = "RatingPicture";
            this.RatingPicture.Size = new System.Drawing.Size(120, 32);
            this.RatingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RatingPicture.TabIndex = 12;
            this.RatingPicture.TabStop = false;
            // 
            // ShowReviewLabel
            // 
            this.ShowReviewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowReviewLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowReviewLabel.Location = new System.Drawing.Point(789, 392);
            this.ShowReviewLabel.Name = "ShowReviewLabel";
            this.ShowReviewLabel.Size = new System.Drawing.Size(104, 17);
            this.ShowReviewLabel.TabIndex = 11;
            this.ShowReviewLabel.Text = "вiдгуки";
            this.ShowReviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowReviewLabel.Click += new System.EventHandler(this.ShowReviewLabel_Click);
            // 
            // AddReviewLabel
            // 
            this.AddReviewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddReviewLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddReviewLabel.Location = new System.Drawing.Point(899, 392);
            this.AddReviewLabel.Name = "AddReviewLabel";
            this.AddReviewLabel.Size = new System.Drawing.Size(104, 17);
            this.AddReviewLabel.TabIndex = 4;
            this.AddReviewLabel.Text = "додати вiдгук";
            this.AddReviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddReviewLabel.Click += new System.EventHandler(this.AddReviewLabel_Click);
            // 
            // accessoryPictureBox
            // 
            this.accessoryPictureBox.Location = new System.Drawing.Point(788, 6);
            this.accessoryPictureBox.Name = "accessoryPictureBox";
            this.accessoryPictureBox.Size = new System.Drawing.Size(228, 227);
            this.accessoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accessoryPictureBox.TabIndex = 10;
            this.accessoryPictureBox.TabStop = false;
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.SandyBrown;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyButton.Location = new System.Drawing.Point(788, 509);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(114, 35);
            this.BuyButton.TabIndex = 9;
            this.BuyButton.Text = "купити";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(789, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "рейтинг";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CountryLabel.Location = new System.Drawing.Point(787, 337);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(0, 15);
            this.CountryLabel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(818, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "страна виробництва";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ManufacturerLabel.Location = new System.Drawing.Point(787, 295);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(0, 15);
            this.ManufacturerLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(818, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "виробник";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TypeLabel.Location = new System.Drawing.Point(787, 253);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(0, 15);
            this.TypeLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(834, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "тип";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GoodsDataGrid.Location = new System.Drawing.Point(12, 18);
            this.GoodsDataGrid.Name = "GoodsDataGrid";
            this.GoodsDataGrid.RowHeadersVisible = false;
            this.GoodsDataGrid.RowHeadersWidth = 51;
            this.GoodsDataGrid.RowTemplate.Height = 50;
            this.GoodsDataGrid.Size = new System.Drawing.Size(770, 430);
            this.GoodsDataGrid.TabIndex = 1;
            this.GoodsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDataGrid_CellClick);
            // 
            // RecomendationDataGrid
            // 
            this.RecomendationDataGrid.AllowUserToAddRows = false;
            this.RecomendationDataGrid.AllowUserToDeleteRows = false;
            this.RecomendationDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecomendationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecomendationDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RecomendationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecomendationDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecomendationDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecomendationDataGrid.Location = new System.Drawing.Point(1033, 81);
            this.RecomendationDataGrid.Name = "RecomendationDataGrid";
            this.RecomendationDataGrid.RowHeadersVisible = false;
            this.RecomendationDataGrid.RowHeadersWidth = 51;
            this.RecomendationDataGrid.RowTemplate.Height = 80;
            this.RecomendationDataGrid.Size = new System.Drawing.Size(277, 463);
            this.RecomendationDataGrid.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(1030, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Рекомендованi товари:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1318, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iнтернет-магазин компьютерного обладнання та комплектуючих";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecomendationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GoodsDataGrid;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.PictureBox accessoryPictureBox;
        private System.Windows.Forms.Label AddReviewLabel;
        private System.Windows.Forms.Label ShowReviewLabel;
        private System.Windows.Forms.PictureBox RatingPicture;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.DataGridView RecomendationDataGrid;
        private System.Windows.Forms.Label label7;
    }
}

