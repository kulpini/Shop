namespace Shop
{
    partial class ReviewsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsForm));
            this.AccessoryLabel = new System.Windows.Forms.Label();
            this.ReviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ReviewDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccessoryLabel
            // 
            this.AccessoryLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessoryLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.AccessoryLabel.Location = new System.Drawing.Point(3, 9);
            this.AccessoryLabel.Name = "AccessoryLabel";
            this.AccessoryLabel.Size = new System.Drawing.Size(793, 23);
            this.AccessoryLabel.TabIndex = 1;
            this.AccessoryLabel.Text = "label1";
            this.AccessoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewRichTextBox
            // 
            this.ReviewRichTextBox.Location = new System.Drawing.Point(530, 90);
            this.ReviewRichTextBox.Name = "ReviewRichTextBox";
            this.ReviewRichTextBox.Size = new System.Drawing.Size(247, 348);
            this.ReviewRichTextBox.TabIndex = 2;
            this.ReviewRichTextBox.Text = "";
            // 
            // ReviewDataGrid
            // 
            this.ReviewDataGrid.AllowUserToAddRows = false;
            this.ReviewDataGrid.AllowUserToDeleteRows = false;
            this.ReviewDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReviewDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReviewDataGrid.Location = new System.Drawing.Point(6, 46);
            this.ReviewDataGrid.Name = "ReviewDataGrid";
            this.ReviewDataGrid.RowHeadersVisible = false;
            this.ReviewDataGrid.RowTemplate.Height = 35;
            this.ReviewDataGrid.Size = new System.Drawing.Size(447, 392);
            this.ReviewDataGrid.TabIndex = 3;
            this.ReviewDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewDataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(527, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оцiнка: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(611, 46);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(87, 23);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Оцiнка: ";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReviewDataGrid);
            this.Controls.Add(this.ReviewRichTextBox);
            this.Controls.Add(this.AccessoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вiдгуки покупцiв про товар";
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label AccessoryLabel;
        private System.Windows.Forms.RichTextBox ReviewRichTextBox;
        private System.Windows.Forms.DataGridView ReviewDataGrid;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ScoreLabel;
    }
}