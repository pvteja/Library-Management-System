namespace Library_Management_System
{
    partial class Patrons_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patrons_Accounts));
            this.textBox_pat_acc_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Patrons = new System.Windows.Forms.DataGridView();
            this.Patrons_Delete_Button = new System.Windows.Forms.Button();
            this.Patrons_update_button = new System.Windows.Forms.Button();
            this.Patrons_insert_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pat_dob = new System.Windows.Forms.TextBox();
            this.textBox_pat_email = new System.Windows.Forms.TextBox();
            this.textBox_patron_name = new System.Windows.Forms.TextBox();
            this.textBox_patron_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_active = new System.Windows.Forms.RadioButton();
            this.radioButton_inactive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patrons)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_pat_acc_id
            // 
            this.textBox_pat_acc_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pat_acc_id.Location = new System.Drawing.Point(121, 147);
            this.textBox_pat_acc_id.Multiline = true;
            this.textBox_pat_acc_id.Name = "textBox_pat_acc_id";
            this.textBox_pat_acc_id.Size = new System.Drawing.Size(222, 38);
            this.textBox_pat_acc_id.TabIndex = 36;
            this.textBox_pat_acc_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "AccountID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1056, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Patrons
            // 
            this.dataGridView_Patrons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patrons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_Patrons.Location = new System.Drawing.Point(406, 96);
            this.dataGridView_Patrons.Name = "dataGridView_Patrons";
            this.dataGridView_Patrons.RowTemplate.Height = 24;
            this.dataGridView_Patrons.Size = new System.Drawing.Size(642, 382);
            this.dataGridView_Patrons.TabIndex = 33;
            this.dataGridView_Patrons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Patrons_CellClick_1);
            // 
            // Patrons_Delete_Button
            // 
            this.Patrons_Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Patrons_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patrons_Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Patrons_Delete_Button.Location = new System.Drawing.Point(296, 476);
            this.Patrons_Delete_Button.Name = "Patrons_Delete_Button";
            this.Patrons_Delete_Button.Size = new System.Drawing.Size(104, 43);
            this.Patrons_Delete_Button.TabIndex = 32;
            this.Patrons_Delete_Button.Text = "Delete";
            this.Patrons_Delete_Button.UseVisualStyleBackColor = false;
            this.Patrons_Delete_Button.Click += new System.EventHandler(this.Patrons_Delete_Button_Click);
            // 
            // Patrons_update_button
            // 
            this.Patrons_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Patrons_update_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patrons_update_button.ForeColor = System.Drawing.Color.Black;
            this.Patrons_update_button.Location = new System.Drawing.Point(159, 476);
            this.Patrons_update_button.Name = "Patrons_update_button";
            this.Patrons_update_button.Size = new System.Drawing.Size(104, 43);
            this.Patrons_update_button.TabIndex = 31;
            this.Patrons_update_button.Text = "Update";
            this.Patrons_update_button.UseVisualStyleBackColor = false;
            this.Patrons_update_button.Click += new System.EventHandler(this.Patrons_update_button_Click);
            // 
            // Patrons_insert_Button
            // 
            this.Patrons_insert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Patrons_insert_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patrons_insert_Button.ForeColor = System.Drawing.Color.Black;
            this.Patrons_insert_Button.Location = new System.Drawing.Point(30, 476);
            this.Patrons_insert_Button.Name = "Patrons_insert_Button";
            this.Patrons_insert_Button.Size = new System.Drawing.Size(104, 43);
            this.Patrons_insert_Button.TabIndex = 30;
            this.Patrons_insert_Button.Text = "Insert";
            this.Patrons_insert_Button.UseVisualStyleBackColor = false;
            this.Patrons_insert_Button.Click += new System.EventHandler(this.Patrons_insert_Button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 53);
            this.label5.TabIndex = 28;
            this.label5.Text = "DOB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 51);
            this.label3.TabIndex = 26;
            this.label3.Text = "Patron Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "PatronID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_pat_dob
            // 
            this.textBox_pat_dob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pat_dob.Location = new System.Drawing.Point(121, 323);
            this.textBox_pat_dob.Multiline = true;
            this.textBox_pat_dob.Name = "textBox_pat_dob";
            this.textBox_pat_dob.Size = new System.Drawing.Size(222, 38);
            this.textBox_pat_dob.TabIndex = 23;
            this.textBox_pat_dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_pat_email
            // 
            this.textBox_pat_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pat_email.Location = new System.Drawing.Point(121, 264);
            this.textBox_pat_email.Multiline = true;
            this.textBox_pat_email.Name = "textBox_pat_email";
            this.textBox_pat_email.Size = new System.Drawing.Size(222, 38);
            this.textBox_pat_email.TabIndex = 22;
            this.textBox_pat_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_patron_name
            // 
            this.textBox_patron_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patron_name.Location = new System.Drawing.Point(121, 206);
            this.textBox_patron_name.Multiline = true;
            this.textBox_patron_name.Name = "textBox_patron_name";
            this.textBox_patron_name.Size = new System.Drawing.Size(222, 38);
            this.textBox_patron_name.TabIndex = 21;
            this.textBox_patron_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_patron_id
            // 
            this.textBox_patron_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patron_id.Location = new System.Drawing.Point(121, 93);
            this.textBox_patron_id.Multiline = true;
            this.textBox_patron_id.Name = "textBox_patron_id";
            this.textBox_patron_id.Size = new System.Drawing.Size(222, 38);
            this.textBox_patron_id.TabIndex = 20;
            this.textBox_patron_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patron Accounts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_active
            // 
            this.radioButton_active.AutoSize = true;
            this.radioButton_active.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_active.Location = new System.Drawing.Point(121, 400);
            this.radioButton_active.Name = "radioButton_active";
            this.radioButton_active.Size = new System.Drawing.Size(86, 27);
            this.radioButton_active.TabIndex = 37;
            this.radioButton_active.TabStop = true;
            this.radioButton_active.Text = "Active";
            this.radioButton_active.UseVisualStyleBackColor = true;
            // 
            // radioButton_inactive
            // 
            this.radioButton_inactive.AutoSize = true;
            this.radioButton_inactive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_inactive.Location = new System.Drawing.Point(243, 400);
            this.radioButton_inactive.Name = "radioButton_inactive";
            this.radioButton_inactive.Size = new System.Drawing.Size(99, 27);
            this.radioButton_inactive.TabIndex = 38;
            this.radioButton_inactive.TabStop = true;
            this.radioButton_inactive.Text = "Inactive";
            this.radioButton_inactive.UseVisualStyleBackColor = true;
            this.radioButton_inactive.CheckedChanged += new System.EventHandler(this.radioButton_inactive_CheckedChanged);
            // 
            // Patrons_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.radioButton_inactive);
            this.Controls.Add(this.radioButton_active);
            this.Controls.Add(this.textBox_pat_acc_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Patrons);
            this.Controls.Add(this.Patrons_Delete_Button);
            this.Controls.Add(this.Patrons_update_button);
            this.Controls.Add(this.Patrons_insert_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_pat_dob);
            this.Controls.Add(this.textBox_pat_email);
            this.Controls.Add(this.textBox_patron_name);
            this.Controls.Add(this.textBox_patron_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patrons_Accounts";
            this.Text = "Patrons_Accounts";
            this.Load += new System.EventHandler(this.Patrons_Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patrons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pat_acc_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Patrons;
        private System.Windows.Forms.Button Patrons_Delete_Button;
        private System.Windows.Forms.Button Patrons_update_button;
        private System.Windows.Forms.Button Patrons_insert_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pat_dob;
        private System.Windows.Forms.TextBox textBox_pat_email;
        private System.Windows.Forms.TextBox textBox_patron_name;
        private System.Windows.Forms.TextBox textBox_patron_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_active;
        private System.Windows.Forms.RadioButton radioButton_inactive;
    }
}