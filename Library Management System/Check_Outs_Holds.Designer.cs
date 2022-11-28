namespace Library_Management_System
{
    partial class Check_Outs_Holds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Outs_Holds));
            this.radioButton_retrurn_no = new System.Windows.Forms.RadioButton();
            this.radioButton_retrun_yes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Check_Holds = new System.Windows.Forms.DataGridView();
            this.CheckOut_Delete_Button = new System.Windows.Forms.Button();
            this.Checkout_update_button = new System.Windows.Forms.Button();
            this.CheckOut_Create_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_patron_acc_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_end_coh = new System.Windows.Forms.DateTimePicker();
            this.textBox_checkout_isbn = new System.Windows.Forms.TextBox();
            this.dateTimePicker_start_coh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Check_Holds)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_retrurn_no
            // 
            this.radioButton_retrurn_no.AutoSize = true;
            this.radioButton_retrurn_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_retrurn_no.Location = new System.Drawing.Point(243, 364);
            this.radioButton_retrurn_no.Name = "radioButton_retrurn_no";
            this.radioButton_retrurn_no.Size = new System.Drawing.Size(55, 27);
            this.radioButton_retrurn_no.TabIndex = 57;
            this.radioButton_retrurn_no.TabStop = true;
            this.radioButton_retrurn_no.Text = "No";
            this.radioButton_retrurn_no.UseVisualStyleBackColor = true;
            // 
            // radioButton_retrun_yes
            // 
            this.radioButton_retrun_yes.AutoSize = true;
            this.radioButton_retrun_yes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_retrun_yes.Location = new System.Drawing.Point(121, 364);
            this.radioButton_retrun_yes.Name = "radioButton_retrun_yes";
            this.radioButton_retrun_yes.Size = new System.Drawing.Size(60, 27);
            this.radioButton_retrun_yes.TabIndex = 56;
            this.radioButton_retrun_yes.TabStop = true;
            this.radioButton_retrun_yes.Text = "Yes";
            this.radioButton_retrun_yes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 44);
            this.label7.TabIndex = 54;
            this.label7.Text = "Satrt Date/Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1038, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Check_Holds
            // 
            this.dataGridView_Check_Holds.AllowUserToDeleteRows = false;
            this.dataGridView_Check_Holds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Check_Holds.Location = new System.Drawing.Point(405, 118);
            this.dataGridView_Check_Holds.Name = "dataGridView_Check_Holds";
            this.dataGridView_Check_Holds.ReadOnly = true;
            this.dataGridView_Check_Holds.RowTemplate.Height = 24;
            this.dataGridView_Check_Holds.Size = new System.Drawing.Size(642, 382);
            this.dataGridView_Check_Holds.TabIndex = 52;
            this.dataGridView_Check_Holds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Check_Holds_CellClick);
            // 
            // CheckOut_Delete_Button
            // 
            this.CheckOut_Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CheckOut_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.CheckOut_Delete_Button.Location = new System.Drawing.Point(283, 440);
            this.CheckOut_Delete_Button.Name = "CheckOut_Delete_Button";
            this.CheckOut_Delete_Button.Size = new System.Drawing.Size(104, 43);
            this.CheckOut_Delete_Button.TabIndex = 51;
            this.CheckOut_Delete_Button.Text = "Delete";
            this.CheckOut_Delete_Button.UseVisualStyleBackColor = false;
            this.CheckOut_Delete_Button.Click += new System.EventHandler(this.CheckOut_Delete_Button_Click);
            // 
            // Checkout_update_button
            // 
            this.Checkout_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Checkout_update_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout_update_button.ForeColor = System.Drawing.Color.Black;
            this.Checkout_update_button.Location = new System.Drawing.Point(157, 440);
            this.Checkout_update_button.Name = "Checkout_update_button";
            this.Checkout_update_button.Size = new System.Drawing.Size(104, 43);
            this.Checkout_update_button.TabIndex = 50;
            this.Checkout_update_button.Text = "Update";
            this.Checkout_update_button.UseVisualStyleBackColor = false;
            this.Checkout_update_button.Click += new System.EventHandler(this.Patrons_update_button_Click);
            // 
            // CheckOut_Create_Button
            // 
            this.CheckOut_Create_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CheckOut_Create_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_Create_Button.ForeColor = System.Drawing.Color.Black;
            this.CheckOut_Create_Button.Location = new System.Drawing.Point(18, 440);
            this.CheckOut_Create_Button.Name = "CheckOut_Create_Button";
            this.CheckOut_Create_Button.Size = new System.Drawing.Size(104, 43);
            this.CheckOut_Create_Button.TabIndex = 49;
            this.CheckOut_Create_Button.Text = "Insert";
            this.CheckOut_Create_Button.UseVisualStyleBackColor = false;
            this.CheckOut_Create_Button.Click += new System.EventHandler(this.CheckOut_Create_Button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "Return";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "ISBN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 51);
            this.label3.TabIndex = 45;
            this.label3.Text = "End Date/Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Patron Acc_ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_patron_acc_id
            // 
            this.textBox_patron_acc_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patron_acc_id.Location = new System.Drawing.Point(120, 115);
            this.textBox_patron_acc_id.Multiline = true;
            this.textBox_patron_acc_id.Name = "textBox_patron_acc_id";
            this.textBox_patron_acc_id.Size = new System.Drawing.Size(222, 38);
            this.textBox_patron_acc_id.TabIndex = 40;
            this.textBox_patron_acc_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 39;
            this.label1.Text = "Check Outs & Holds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_end_coh
            // 
            this.dateTimePicker_end_coh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_end_coh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end_coh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end_coh.Location = new System.Drawing.Point(121, 236);
            this.dateTimePicker_end_coh.Name = "dateTimePicker_end_coh";
            this.dateTimePicker_end_coh.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker_end_coh.TabIndex = 58;
            this.dateTimePicker_end_coh.TabStop = false;
            this.dateTimePicker_end_coh.Value = new System.DateTime(2022, 11, 25, 12, 18, 14, 0);
            // 
            // textBox_checkout_isbn
            // 
            this.textBox_checkout_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_checkout_isbn.Location = new System.Drawing.Point(120, 286);
            this.textBox_checkout_isbn.Multiline = true;
            this.textBox_checkout_isbn.Name = "textBox_checkout_isbn";
            this.textBox_checkout_isbn.Size = new System.Drawing.Size(222, 38);
            this.textBox_checkout_isbn.TabIndex = 42;
            this.textBox_checkout_isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker_start_coh
            // 
            this.dateTimePicker_start_coh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_start_coh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start_coh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start_coh.Location = new System.Drawing.Point(121, 184);
            this.dateTimePicker_start_coh.Name = "dateTimePicker_start_coh";
            this.dateTimePicker_start_coh.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker_start_coh.TabIndex = 59;
            this.dateTimePicker_start_coh.TabStop = false;
            // 
            // Check_Outs_Holds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1082, 556);
            this.Controls.Add(this.dateTimePicker_start_coh);
            this.Controls.Add(this.dateTimePicker_end_coh);
            this.Controls.Add(this.radioButton_retrurn_no);
            this.Controls.Add(this.radioButton_retrun_yes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Check_Holds);
            this.Controls.Add(this.CheckOut_Delete_Button);
            this.Controls.Add(this.Checkout_update_button);
            this.Controls.Add(this.CheckOut_Create_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_checkout_isbn);
            this.Controls.Add(this.textBox_patron_acc_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_Outs_Holds";
            this.Text = "Check_Outs_Holds";
            this.Load += new System.EventHandler(this.Check_Outs_Holds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Check_Holds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_retrurn_no;
        private System.Windows.Forms.RadioButton radioButton_retrun_yes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Check_Holds;
        private System.Windows.Forms.Button CheckOut_Delete_Button;
        private System.Windows.Forms.Button Checkout_update_button;
        private System.Windows.Forms.Button CheckOut_Create_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_patron_acc_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_coh;
        private System.Windows.Forms.TextBox textBox_checkout_isbn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_coh;
    }
}