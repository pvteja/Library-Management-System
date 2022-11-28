namespace Library_Management_System
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dashboard_Close = new System.Windows.Forms.Button();
            this.Books_Button = new System.Windows.Forms.Button();
            this.Patrons_Button = new System.Windows.Forms.Button();
            this.Check_out_Button = new System.Windows.Forms.Button();
            this.Notification_Button = new System.Windows.Forms.Button();
            this.Category_Button = new System.Windows.Forms.Button();
            this.Query_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(221, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 152);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard_Close
            // 
            this.Dashboard_Close.BackColor = System.Drawing.Color.DarkRed;
            this.Dashboard_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Close.ForeColor = System.Drawing.Color.Yellow;
            this.Dashboard_Close.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_Close.Image")));
            this.Dashboard_Close.Location = new System.Drawing.Point(562, 12);
            this.Dashboard_Close.Name = "Dashboard_Close";
            this.Dashboard_Close.Size = new System.Drawing.Size(28, 27);
            this.Dashboard_Close.TabIndex = 2;
            this.Dashboard_Close.UseVisualStyleBackColor = false;
            this.Dashboard_Close.Click += new System.EventHandler(this.Dashboard_Close_Click);
            // 
            // Books_Button
            // 
            this.Books_Button.BackColor = System.Drawing.Color.Teal;
            this.Books_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books_Button.ForeColor = System.Drawing.Color.White;
            this.Books_Button.Location = new System.Drawing.Point(40, 266);
            this.Books_Button.Name = "Books_Button";
            this.Books_Button.Size = new System.Drawing.Size(232, 39);
            this.Books_Button.TabIndex = 3;
            this.Books_Button.Text = "Books Catalog";
            this.Books_Button.UseVisualStyleBackColor = false;
            this.Books_Button.Click += new System.EventHandler(this.Books_Button_Click);
            // 
            // Patrons_Button
            // 
            this.Patrons_Button.BackColor = System.Drawing.Color.Teal;
            this.Patrons_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patrons_Button.ForeColor = System.Drawing.Color.White;
            this.Patrons_Button.Location = new System.Drawing.Point(305, 266);
            this.Patrons_Button.Name = "Patrons_Button";
            this.Patrons_Button.Size = new System.Drawing.Size(232, 39);
            this.Patrons_Button.TabIndex = 4;
            this.Patrons_Button.Text = "Patrons";
            this.Patrons_Button.UseVisualStyleBackColor = false;
            this.Patrons_Button.Click += new System.EventHandler(this.Patrons_Button_Click);
            // 
            // Check_out_Button
            // 
            this.Check_out_Button.BackColor = System.Drawing.Color.Teal;
            this.Check_out_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_out_Button.ForeColor = System.Drawing.Color.White;
            this.Check_out_Button.Location = new System.Drawing.Point(40, 362);
            this.Check_out_Button.Name = "Check_out_Button";
            this.Check_out_Button.Size = new System.Drawing.Size(232, 39);
            this.Check_out_Button.TabIndex = 5;
            this.Check_out_Button.Text = "Check Outs/Holds";
            this.Check_out_Button.UseVisualStyleBackColor = false;
            this.Check_out_Button.Click += new System.EventHandler(this.Check_out_Button_Click);
            // 
            // Notification_Button
            // 
            this.Notification_Button.BackColor = System.Drawing.Color.Teal;
            this.Notification_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_Button.ForeColor = System.Drawing.Color.White;
            this.Notification_Button.Location = new System.Drawing.Point(305, 362);
            this.Notification_Button.Name = "Notification_Button";
            this.Notification_Button.Size = new System.Drawing.Size(232, 39);
            this.Notification_Button.TabIndex = 6;
            this.Notification_Button.Text = "Notifications";
            this.Notification_Button.UseVisualStyleBackColor = false;
            this.Notification_Button.Click += new System.EventHandler(this.Notification_Button_Click);
            // 
            // Category_Button
            // 
            this.Category_Button.BackColor = System.Drawing.Color.Teal;
            this.Category_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Category_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Button.ForeColor = System.Drawing.Color.White;
            this.Category_Button.Location = new System.Drawing.Point(40, 461);
            this.Category_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Category_Button.Name = "Category_Button";
            this.Category_Button.Size = new System.Drawing.Size(232, 39);
            this.Category_Button.TabIndex = 7;
            this.Category_Button.Text = "Categories";
            this.Category_Button.UseVisualStyleBackColor = false;
            this.Category_Button.Click += new System.EventHandler(this.Category_Button_Click);
            // 
            // Query_Button
            // 
            this.Query_Button.BackColor = System.Drawing.Color.Teal;
            this.Query_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Query_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query_Button.ForeColor = System.Drawing.Color.White;
            this.Query_Button.Location = new System.Drawing.Point(305, 461);
            this.Query_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Query_Button.Name = "Query_Button";
            this.Query_Button.Size = new System.Drawing.Size(232, 39);
            this.Query_Button.TabIndex = 8;
            this.Query_Button.Text = "Execute Query";
            this.Query_Button.UseVisualStyleBackColor = false;
            this.Query_Button.Click += new System.EventHandler(this.Query_Button_Click);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(623, 543);
            this.Controls.Add(this.Query_Button);
            this.Controls.Add(this.Category_Button);
            this.Controls.Add(this.Notification_Button);
            this.Controls.Add(this.Check_out_Button);
            this.Controls.Add(this.Patrons_Button);
            this.Controls.Add(this.Books_Button);
            this.Controls.Add(this.Dashboard_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Form";
            this.Text = "Dashboard_Form";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dashboard_Close;
        private System.Windows.Forms.Button Books_Button;
        private System.Windows.Forms.Button Patrons_Button;
        private System.Windows.Forms.Button Check_out_Button;
        private System.Windows.Forms.Button Notification_Button;
        private System.Windows.Forms.Button Category_Button;
        private System.Windows.Forms.Button Query_Button;
    }
}