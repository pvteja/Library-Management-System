namespace Library_Management_System
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_User_ID = new System.Windows.Forms.TextBox();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.UserId_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.New_User_button = new System.Windows.Forms.Button();
            this.Login_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(216, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 106);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_User_ID
            // 
            this.Login_User_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_User_ID.ForeColor = System.Drawing.Color.Black;
            this.Login_User_ID.Location = new System.Drawing.Point(325, 150);
            this.Login_User_ID.Multiline = true;
            this.Login_User_ID.Name = "Login_User_ID";
            this.Login_User_ID.Size = new System.Drawing.Size(237, 39);
            this.Login_User_ID.TabIndex = 2;
            this.Login_User_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_Password
            // 
            this.Login_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password.ForeColor = System.Drawing.Color.Black;
            this.Login_Password.Location = new System.Drawing.Point(325, 237);
            this.Login_Password.Multiline = true;
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(237, 39);
            this.Login_Password.TabIndex = 3;
            this.Login_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserId_label
            // 
            this.UserId_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId_label.ForeColor = System.Drawing.Color.Yellow;
            this.UserId_label.Location = new System.Drawing.Point(218, 154);
            this.UserId_label.Name = "UserId_label";
            this.UserId_label.Size = new System.Drawing.Size(81, 35);
            this.UserId_label.TabIndex = 4;
            this.UserId_label.Text = "Admin ID";
            this.UserId_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_label
            // 
            this.Password_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.Yellow;
            this.Password_label.Location = new System.Drawing.Point(201, 237);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(98, 35);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password";
            this.Password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(224, 316);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(132, 53);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // New_User_button
            // 
            this.New_User_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.New_User_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New_User_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_User_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_User_button.ForeColor = System.Drawing.Color.White;
            this.New_User_button.Location = new System.Drawing.Point(430, 316);
            this.New_User_button.Name = "New_User_button";
            this.New_User_button.Size = new System.Drawing.Size(132, 53);
            this.New_User_button.TabIndex = 7;
            this.New_User_button.Text = "New Admin";
            this.New_User_button.UseVisualStyleBackColor = false;
            this.New_User_button.Click += new System.EventHandler(this.New_User_Click);
            // 
            // Login_Close
            // 
            this.Login_Close.BackColor = System.Drawing.Color.Teal;
            this.Login_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Close.ForeColor = System.Drawing.Color.Green;
            this.Login_Close.Image = ((System.Drawing.Image)(resources.GetObject("Login_Close.Image")));
            this.Login_Close.Location = new System.Drawing.Point(754, 12);
            this.Login_Close.Name = "Login_Close";
            this.Login_Close.Size = new System.Drawing.Size(25, 27);
            this.Login_Close.TabIndex = 9;
            this.Login_Close.UseVisualStyleBackColor = false;
            this.Login_Close.Click += new System.EventHandler(this.Login_Close_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_Close);
            this.Controls.Add(this.New_User_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserId_label);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_User_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_User_ID;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.Label UserId_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button New_User_button;
        private System.Windows.Forms.Button Login_Close;
    }
}