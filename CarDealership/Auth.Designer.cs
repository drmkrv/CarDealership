namespace CarDealership
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.VisiblePassBtn = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(97, 317);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(177, 28);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.loginLabel.Location = new System.Drawing.Point(93, 227);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 22);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(93, 292);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 22);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LogLabel
            // 
            this.LogLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Mont Heavy DEMO", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.Location = new System.Drawing.Point(142, 152);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(87, 37);
            this.LogLabel.TabIndex = 4;
            this.LogLabel.Text = "Вход";
            // 
            // LogInButton
            // 
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.LogInButton.Location = new System.Drawing.Point(97, 390);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(177, 49);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.Color.Black;
            this.RegButton.Location = new System.Drawing.Point(97, 441);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(177, 32);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // VisiblePassBtn
            // 
            this.VisiblePassBtn.BackgroundImage = global::CarDealership.Properties.Resources.passInvis;
            this.VisiblePassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisiblePassBtn.Location = new System.Drawing.Point(280, 317);
            this.VisiblePassBtn.Name = "VisiblePassBtn";
            this.VisiblePassBtn.Size = new System.Drawing.Size(28, 28);
            this.VisiblePassBtn.TabIndex = 7;
            this.VisiblePassBtn.UseVisualStyleBackColor = true;
            this.VisiblePassBtn.Click += new System.EventHandler(this.VisiblePassBtn_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(97, 252);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(177, 28);
            this.loginTextBox.TabIndex = 0;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 511);
            this.Controls.Add(this.VisiblePassBtn);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.RegButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 550);
            this.MinimumSize = new System.Drawing.Size(390, 550);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button VisiblePassBtn;
        private System.Windows.Forms.TextBox loginTextBox;
    }
}