namespace Shop
{
    partial class AddReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReviewForm));
            this.AccessoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReviewRichText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreComboBox = new System.Windows.Forms.ComboBox();
            this.AddReviewButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccessoryLabel
            // 
            this.AccessoryLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessoryLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.AccessoryLabel.Location = new System.Drawing.Point(12, 9);
            this.AccessoryLabel.Name = "AccessoryLabel";
            this.AccessoryLabel.Size = new System.Drawing.Size(680, 23);
            this.AccessoryLabel.TabIndex = 0;
            this.AccessoryLabel.Text = "label1";
            this.AccessoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваша оцiнка:";
            // 
            // ReviewRichText
            // 
            this.ReviewRichText.Location = new System.Drawing.Point(25, 112);
            this.ReviewRichText.Name = "ReviewRichText";
            this.ReviewRichText.Size = new System.Drawing.Size(571, 213);
            this.ReviewRichText.TabIndex = 2;
            this.ReviewRichText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вiдгук:";
            // 
            // ScoreComboBox
            // 
            this.ScoreComboBox.FormattingEnabled = true;
            this.ScoreComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ScoreComboBox.Location = new System.Drawing.Point(124, 60);
            this.ScoreComboBox.Name = "ScoreComboBox";
            this.ScoreComboBox.Size = new System.Drawing.Size(61, 21);
            this.ScoreComboBox.TabIndex = 4;
            // 
            // AddReviewButton
            // 
            this.AddReviewButton.BackColor = System.Drawing.Color.SandyBrown;
            this.AddReviewButton.FlatAppearance.BorderSize = 0;
            this.AddReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReviewButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddReviewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddReviewButton.Location = new System.Drawing.Point(602, 112);
            this.AddReviewButton.Name = "AddReviewButton";
            this.AddReviewButton.Size = new System.Drawing.Size(90, 51);
            this.AddReviewButton.TabIndex = 5;
            this.AddReviewButton.Text = "Залишити вiдгук";
            this.AddReviewButton.UseVisualStyleBackColor = false;
            this.AddReviewButton.Click += new System.EventHandler(this.AddReviewButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(602, 274);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 51);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 335);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddReviewButton);
            this.Controls.Add(this.ScoreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReviewRichText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccessoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати вiдгук про товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label AccessoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ReviewRichText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ScoreComboBox;
        private System.Windows.Forms.Button AddReviewButton;
        private System.Windows.Forms.Button CloseButton;
    }
}