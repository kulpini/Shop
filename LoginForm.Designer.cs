namespace Shop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.RegistrationTab = new System.Windows.Forms.TabControl();
            this.LoginTabPage = new System.Windows.Forms.TabPage();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLoginTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailLoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationTabPage = new System.Windows.Forms.TabPage();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistrationTab.SuspendLayout();
            this.LoginTabPage.SuspendLayout();
            this.RegistrationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationTab
            // 
            this.RegistrationTab.Controls.Add(this.LoginTabPage);
            this.RegistrationTab.Controls.Add(this.RegistrationTabPage);
            this.RegistrationTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationTab.Location = new System.Drawing.Point(9, 10);
            this.RegistrationTab.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationTab.Name = "RegistrationTab";
            this.RegistrationTab.SelectedIndex = 0;
            this.RegistrationTab.Size = new System.Drawing.Size(521, 229);
            this.RegistrationTab.TabIndex = 0;
            // 
            // LoginTabPage
            // 
            this.LoginTabPage.Controls.Add(this.RegistrationLabel);
            this.LoginTabPage.Controls.Add(this.label8);
            this.LoginTabPage.Controls.Add(this.LoginButton);
            this.LoginTabPage.Controls.Add(this.PasswordLoginTextBox);
            this.LoginTabPage.Controls.Add(this.label4);
            this.LoginTabPage.Controls.Add(this.label3);
            this.LoginTabPage.Controls.Add(this.label2);
            this.LoginTabPage.Controls.Add(this.EmailLoginTextBox);
            this.LoginTabPage.Controls.Add(this.label1);
            this.LoginTabPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginTabPage.Location = new System.Drawing.Point(4, 29);
            this.LoginTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTabPage.Name = "LoginTabPage";
            this.LoginTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.LoginTabPage.Size = new System.Drawing.Size(513, 196);
            this.LoginTabPage.TabIndex = 0;
            this.LoginTabPage.Text = "ЛОГIН";
            this.LoginTabPage.UseVisualStyleBackColor = true;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RegistrationLabel.Location = new System.Drawing.Point(389, 134);
            this.RegistrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(120, 20);
            this.RegistrationLabel.TabIndex = 8;
            this.RegistrationLabel.Text = "зареєструватися";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(359, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "або";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SandyBrown;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoginButton.Location = new System.Drawing.Point(204, 150);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(107, 33);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "УВIЙТИ";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLoginTextBox
            // 
            this.PasswordLoginTextBox.Location = new System.Drawing.Point(93, 108);
            this.PasswordLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordLoginTextBox.Name = "PasswordLoginTextBox";
            this.PasswordLoginTextBox.Size = new System.Drawing.Size(338, 26);
            this.PasswordLoginTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вхiд до особистого кабiнету";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Якщо Ви зареєстрованi, введiть логiн та пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // EmailLoginTextBox
            // 
            this.EmailLoginTextBox.Location = new System.Drawing.Point(92, 58);
            this.EmailLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailLoginTextBox.Name = "EmailLoginTextBox";
            this.EmailLoginTextBox.Size = new System.Drawing.Size(338, 26);
            this.EmailLoginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "e-mail";
            // 
            // RegistrationTabPage
            // 
            this.RegistrationTabPage.Controls.Add(this.RegistrationButton);
            this.RegistrationTabPage.Controls.Add(this.PasswordRegistrationTextBox);
            this.RegistrationTabPage.Controls.Add(this.label5);
            this.RegistrationTabPage.Controls.Add(this.label6);
            this.RegistrationTabPage.Controls.Add(this.EmailRegistrationTextBox);
            this.RegistrationTabPage.Controls.Add(this.label7);
            this.RegistrationTabPage.Location = new System.Drawing.Point(4, 29);
            this.RegistrationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationTabPage.Name = "RegistrationTabPage";
            this.RegistrationTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.RegistrationTabPage.Size = new System.Drawing.Size(513, 196);
            this.RegistrationTabPage.TabIndex = 1;
            this.RegistrationTabPage.Text = "РЕЄСТРАЦIЯ";
            this.RegistrationTabPage.UseVisualStyleBackColor = true;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.Location = new System.Drawing.Point(182, 148);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(150, 33);
            this.RegistrationButton.TabIndex = 12;
            this.RegistrationButton.Text = "РЕЄСТРАЦIЯ";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordRegistrationTextBox
            // 
            this.PasswordRegistrationTextBox.Location = new System.Drawing.Point(91, 100);
            this.PasswordRegistrationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordRegistrationTextBox.Name = "PasswordRegistrationTextBox";
            this.PasswordRegistrationTextBox.Size = new System.Drawing.Size(338, 26);
            this.PasswordRegistrationTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(2, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Для реєстрацiї введiть Ваш e-mail та пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пароль";
            // 
            // EmailRegistrationTextBox
            // 
            this.EmailRegistrationTextBox.Location = new System.Drawing.Point(90, 50);
            this.EmailRegistrationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailRegistrationTextBox.Name = "EmailRegistrationTextBox";
            this.EmailRegistrationTextBox.Size = new System.Drawing.Size(338, 26);
            this.EmailRegistrationTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SandyBrown;
            this.label7.Location = new System.Drawing.Point(14, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "e-mail";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 246);
            this.Controls.Add(this.RegistrationTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увiйти / Зареєструватися";
            this.RegistrationTab.ResumeLayout(false);
            this.LoginTabPage.ResumeLayout(false);
            this.LoginTabPage.PerformLayout();
            this.RegistrationTabPage.ResumeLayout(false);
            this.RegistrationTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RegistrationTab;
        private System.Windows.Forms.TabPage LoginTabPage;
        private System.Windows.Forms.TextBox PasswordLoginTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailLoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage RegistrationTabPage;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox PasswordRegistrationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailRegistrationTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label label8;
    }
}