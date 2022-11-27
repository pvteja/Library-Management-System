namespace Library_Management_System
{
    partial class Notifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.dateTimePicker_sent_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Notifications = new System.Windows.Forms.DataGridView();
            this.Notify_Delete_Button = new System.Windows.Forms.Button();
            this.Notify_update_button = new System.Windows.Forms.Button();
            this.Notify_Create_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_notifications_isbn = new System.Windows.Forms.TextBox();
            this.textBox_notification_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_notify_patron_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_notify_message = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notifications)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_sent_date
            // 
            this.dateTimePicker_sent_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_sent_date.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_sent_date.Location = new System.Drawing.Point(140, 251);
            this.dateTimePicker_sent_date.Name = "dateTimePicker_sent_date";
            this.dateTimePicker_sent_date.Size = new System.Drawing.Size(222, 27);
            this.dateTimePicker_sent_date.TabIndex = 76;
            this.dateTimePicker_sent_date.TabStop = false;
            this.dateTimePicker_sent_date.ValueChanged += new System.EventHandler(this.dateTimePicker_sent_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 44);
            this.label7.TabIndex = 72;
            this.label7.Text = "Sent Date/Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1033, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 71;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Notifications
            // 
            this.dataGridView_Notifications.AllowUserToDeleteRows = false;
            this.dataGridView_Notifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notifications.Location = new System.Drawing.Point(407, 126);
            this.dataGridView_Notifications.Name = "dataGridView_Notifications";
            this.dataGridView_Notifications.ReadOnly = true;
            this.dataGridView_Notifications.RowTemplate.Height = 24;
            this.dataGridView_Notifications.Size = new System.Drawing.Size(642, 382);
            this.dataGridView_Notifications.TabIndex = 70;
            this.dataGridView_Notifications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Notifications_CellClick);
            // 
            // Notify_Delete_Button
            // 
            this.Notify_Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Notify_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify_Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Notify_Delete_Button.Location = new System.Drawing.Point(284, 487);
            this.Notify_Delete_Button.Name = "Notify_Delete_Button";
            this.Notify_Delete_Button.Size = new System.Drawing.Size(104, 43);
            this.Notify_Delete_Button.TabIndex = 69;
            this.Notify_Delete_Button.Text = "Delete";
            this.Notify_Delete_Button.UseVisualStyleBackColor = false;
            this.Notify_Delete_Button.Click += new System.EventHandler(this.Notify_Delete_Button_Click);
            // 
            // Notify_update_button
            // 
            this.Notify_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Notify_update_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify_update_button.ForeColor = System.Drawing.Color.Black;
            this.Notify_update_button.Location = new System.Drawing.Point(158, 487);
            this.Notify_update_button.Name = "Notify_update_button";
            this.Notify_update_button.Size = new System.Drawing.Size(104, 43);
            this.Notify_update_button.TabIndex = 68;
            this.Notify_update_button.Text = "Update";
            this.Notify_update_button.UseVisualStyleBackColor = false;
            this.Notify_update_button.Click += new System.EventHandler(this.Notify_update_button_Click);
            // 
            // Notify_Create_Button
            // 
            this.Notify_Create_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Notify_Create_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify_Create_Button.ForeColor = System.Drawing.Color.Black;
            this.Notify_Create_Button.Location = new System.Drawing.Point(19, 487);
            this.Notify_Create_Button.Name = "Notify_Create_Button";
            this.Notify_Create_Button.Size = new System.Drawing.Size(104, 43);
            this.Notify_Create_Button.TabIndex = 67;
            this.Notify_Create_Button.Text = "Insert";
            this.Notify_Create_Button.UseVisualStyleBackColor = false;
            this.Notify_Create_Button.Click += new System.EventHandler(this.Notify_Create_Button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 40);
            this.label6.TabIndex = 66;
            this.label6.Text = "Message";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "ISBN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "NotifyID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_notifications_isbn
            // 
            this.textBox_notifications_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_notifications_isbn.Location = new System.Drawing.Point(140, 307);
            this.textBox_notifications_isbn.Multiline = true;
            this.textBox_notifications_isbn.Name = "textBox_notifications_isbn";
            this.textBox_notifications_isbn.Size = new System.Drawing.Size(222, 38);
            this.textBox_notifications_isbn.TabIndex = 62;
            this.textBox_notifications_isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_notification_email
            // 
            this.textBox_notification_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_notification_email.Location = new System.Drawing.Point(140, 148);
            this.textBox_notification_email.Multiline = true;
            this.textBox_notification_email.Name = "textBox_notification_email";
            this.textBox_notification_email.Size = new System.Drawing.Size(222, 38);
            this.textBox_notification_email.TabIndex = 61;
            this.textBox_notification_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 60;
            this.label1.Text = "Notifications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_notify_patron_id
            // 
            this.textBox_notify_patron_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_notify_patron_id.Location = new System.Drawing.Point(140, 207);
            this.textBox_notify_patron_id.Multiline = true;
            this.textBox_notify_patron_id.Name = "textBox_notify_patron_id";
            this.textBox_notify_patron_id.Size = new System.Drawing.Size(222, 38);
            this.textBox_notify_patron_id.TabIndex = 77;
            this.textBox_notify_patron_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Patron ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox_notify_message
            // 
            this.richTextBox_notify_message.Location = new System.Drawing.Point(140, 358);
            this.richTextBox_notify_message.Name = "richTextBox_notify_message";
            this.richTextBox_notify_message.Size = new System.Drawing.Size(222, 76);
            this.richTextBox_notify_message.TabIndex = 79;
            this.richTextBox_notify_message.Text = "";
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1065, 577);
            this.Controls.Add(this.richTextBox_notify_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_notify_patron_id);
            this.Controls.Add(this.dateTimePicker_sent_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Notifications);
            this.Controls.Add(this.Notify_Delete_Button);
            this.Controls.Add(this.Notify_update_button);
            this.Controls.Add(this.Notify_Create_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_notifications_isbn);
            this.Controls.Add(this.textBox_notification_email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_sent_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Notifications;
        private System.Windows.Forms.Button Notify_Delete_Button;
        private System.Windows.Forms.Button Notify_update_button;
        private System.Windows.Forms.Button Notify_Create_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_notifications_isbn;
        private System.Windows.Forms.TextBox textBox_notification_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_notify_patron_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_notify_message;
    }
}