namespace Library_Management_System
{
    partial class Execute_Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Execute_Query));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_execute_query = new System.Windows.Forms.DataGridView();
            this.Execute_Query_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_query = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_query1 = new System.Windows.Forms.Button();
            this.button_query2 = new System.Windows.Forms.Button();
            this.button_query3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_execute_query)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1081, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_execute_query
            // 
            this.dataGridView_execute_query.AllowUserToDeleteRows = false;
            this.dataGridView_execute_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_execute_query.Location = new System.Drawing.Point(44, 504);
            this.dataGridView_execute_query.Name = "dataGridView_execute_query";
            this.dataGridView_execute_query.ReadOnly = true;
            this.dataGridView_execute_query.RowTemplate.Height = 24;
            this.dataGridView_execute_query.Size = new System.Drawing.Size(1023, 143);
            this.dataGridView_execute_query.TabIndex = 105;
            // 
            // Execute_Query_Button
            // 
            this.Execute_Query_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Execute_Query_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute_Query_Button.ForeColor = System.Drawing.Color.Black;
            this.Execute_Query_Button.Location = new System.Drawing.Point(963, 412);
            this.Execute_Query_Button.Name = "Execute_Query_Button";
            this.Execute_Query_Button.Size = new System.Drawing.Size(104, 43);
            this.Execute_Query_Button.TabIndex = 102;
            this.Execute_Query_Button.Text = "Execute";
            this.Execute_Query_Button.UseVisualStyleBackColor = false;
            this.Execute_Query_Button.Click += new System.EventHandler(this.Execute_Query_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 96;
            this.label1.Text = "Execute Query for Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_query
            // 
            this.richTextBox_query.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_query.Location = new System.Drawing.Point(44, 368);
            this.richTextBox_query.Name = "richTextBox_query";
            this.richTextBox_query.Size = new System.Drawing.Size(913, 121);
            this.richTextBox_query.TabIndex = 107;
            this.richTextBox_query.Text = "Enter Query";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 52);
            this.label2.TabIndex = 108;
            this.label2.Text = "List of Patrons who have been issued with Books";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 52);
            this.label3.TabIndex = 109;
            this.label3.Text = "Display Category Names and Books";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 52);
            this.label4.TabIndex = 110;
            this.label4.Text = "Display name& Author of the books in the category of CATE002 which are published " +
    "after 2020";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_query1
            // 
            this.button_query1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_query1.Location = new System.Drawing.Point(597, 125);
            this.button_query1.Name = "button_query1";
            this.button_query1.Size = new System.Drawing.Size(163, 35);
            this.button_query1.TabIndex = 111;
            this.button_query1.Text = "Query1";
            this.button_query1.UseVisualStyleBackColor = true;
            this.button_query1.Click += new System.EventHandler(this.button_query1_Click);
            // 
            // button_query2
            // 
            this.button_query2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_query2.Location = new System.Drawing.Point(597, 203);
            this.button_query2.Name = "button_query2";
            this.button_query2.Size = new System.Drawing.Size(163, 35);
            this.button_query2.TabIndex = 112;
            this.button_query2.Text = "Query2";
            this.button_query2.UseVisualStyleBackColor = true;
            this.button_query2.Click += new System.EventHandler(this.button_query2_Click);
            // 
            // button_query3
            // 
            this.button_query3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_query3.Location = new System.Drawing.Point(597, 280);
            this.button_query3.Name = "button_query3";
            this.button_query3.Size = new System.Drawing.Size(163, 35);
            this.button_query3.TabIndex = 113;
            this.button_query3.Text = "Query3";
            this.button_query3.UseVisualStyleBackColor = true;
            this.button_query3.Click += new System.EventHandler(this.button_query3_Click);
            // 
            // Execute_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1125, 668);
            this.Controls.Add(this.button_query3);
            this.Controls.Add(this.button_query2);
            this.Controls.Add(this.button_query1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_query);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_execute_query);
            this.Controls.Add(this.Execute_Query_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Execute_Query";
            this.Text = "Execute_Query";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_execute_query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_execute_query;
        private System.Windows.Forms.Button Execute_Query_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_query1;
        private System.Windows.Forms.Button button_query2;
        private System.Windows.Forms.Button button_query3;
    }
}