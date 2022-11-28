namespace Library_Management_System
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_category_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.Category_Delete_Button = new System.Windows.Forms.Button();
            this.Category_update_button = new System.Windows.Forms.Button();
            this.Category_Create_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_category_aisle = new System.Windows.Forms.TextBox();
            this.textBox_category_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_category_count = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 94;
            this.label3.Text = "Category ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_category_id
            // 
            this.textBox_category_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_category_id.Location = new System.Drawing.Point(141, 137);
            this.textBox_category_id.Multiline = true;
            this.textBox_category_id.Name = "textBox_category_id";
            this.textBox_category_id.Size = new System.Drawing.Size(222, 38);
            this.textBox_category_id.TabIndex = 93;
            this.textBox_category_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1034, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Categories
            // 
            this.dataGridView_Categories.AllowUserToDeleteRows = false;
            this.dataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categories.Location = new System.Drawing.Point(408, 114);
            this.dataGridView_Categories.Name = "dataGridView_Categories";
            this.dataGridView_Categories.ReadOnly = true;
            this.dataGridView_Categories.RowTemplate.Height = 24;
            this.dataGridView_Categories.Size = new System.Drawing.Size(642, 382);
            this.dataGridView_Categories.TabIndex = 89;
            this.dataGridView_Categories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Categories_CellClick);
            // 
            // Category_Delete_Button
            // 
            this.Category_Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Category_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Category_Delete_Button.Location = new System.Drawing.Point(289, 420);
            this.Category_Delete_Button.Name = "Category_Delete_Button";
            this.Category_Delete_Button.Size = new System.Drawing.Size(104, 43);
            this.Category_Delete_Button.TabIndex = 88;
            this.Category_Delete_Button.Text = "Delete";
            this.Category_Delete_Button.UseVisualStyleBackColor = false;
            this.Category_Delete_Button.Click += new System.EventHandler(this.Category_Delete_Button_Click);
            // 
            // Category_update_button
            // 
            this.Category_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Category_update_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_update_button.ForeColor = System.Drawing.Color.Black;
            this.Category_update_button.Location = new System.Drawing.Point(151, 420);
            this.Category_update_button.Name = "Category_update_button";
            this.Category_update_button.Size = new System.Drawing.Size(104, 43);
            this.Category_update_button.TabIndex = 87;
            this.Category_update_button.Text = "Update";
            this.Category_update_button.UseVisualStyleBackColor = false;
            this.Category_update_button.Click += new System.EventHandler(this.Category_update_button_Click);
            // 
            // Category_Create_Button
            // 
            this.Category_Create_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Category_Create_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Create_Button.ForeColor = System.Drawing.Color.Black;
            this.Category_Create_Button.Location = new System.Drawing.Point(20, 420);
            this.Category_Create_Button.Name = "Category_Create_Button";
            this.Category_Create_Button.Size = new System.Drawing.Size(104, 43);
            this.Category_Create_Button.TabIndex = 86;
            this.Category_Create_Button.Text = "Insert";
            this.Category_Create_Button.UseVisualStyleBackColor = false;
            this.Category_Create_Button.Click += new System.EventHandler(this.Category_Create_Button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 40);
            this.label6.TabIndex = 85;
            this.label6.Text = "Count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Aisle Range";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_category_aisle
            // 
            this.textBox_category_aisle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_category_aisle.Location = new System.Drawing.Point(141, 276);
            this.textBox_category_aisle.Multiline = true;
            this.textBox_category_aisle.Name = "textBox_category_aisle";
            this.textBox_category_aisle.Size = new System.Drawing.Size(222, 38);
            this.textBox_category_aisle.TabIndex = 82;
            this.textBox_category_aisle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_category_name
            // 
            this.textBox_category_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_category_name.Location = new System.Drawing.Point(141, 204);
            this.textBox_category_name.Multiline = true;
            this.textBox_category_name.Name = "textBox_category_name";
            this.textBox_category_name.Size = new System.Drawing.Size(222, 38);
            this.textBox_category_name.TabIndex = 81;
            this.textBox_category_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 80;
            this.label1.Text = "Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_category_count
            // 
            this.textBox_category_count.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_category_count.Location = new System.Drawing.Point(141, 340);
            this.textBox_category_count.Multiline = true;
            this.textBox_category_count.Name = "textBox_category_count";
            this.textBox_category_count.Size = new System.Drawing.Size(222, 38);
            this.textBox_category_count.TabIndex = 95;
            this.textBox_category_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1074, 545);
            this.Controls.Add(this.textBox_category_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_category_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Categories);
            this.Controls.Add(this.Category_Delete_Button);
            this.Controls.Add(this.Category_update_button);
            this.Controls.Add(this.Category_Create_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_category_aisle);
            this.Controls.Add(this.textBox_category_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_category_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Categories;
        private System.Windows.Forms.Button Category_Delete_Button;
        private System.Windows.Forms.Button Category_update_button;
        private System.Windows.Forms.Button Category_Create_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_category_aisle;
        private System.Windows.Forms.TextBox textBox_category_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_category_count;
    }
}