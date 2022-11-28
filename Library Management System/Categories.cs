using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Categories : Form
    {

        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        DataBaseControl sql = new DataBaseControl();
        int indexRow;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection_string))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Category", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView_Categories.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Category_Create_Button_Click(object sender, EventArgs e)
        {

            sql.Param("@categoryid", textBox_category_id.Text);
            sql.Param("@name", textBox_category_name.Text);
            sql.Param("@aisle", textBox_category_aisle.Text);
            sql.Param("@count", textBox_category_count.Text);
            sql.query("insert into Category (CategoryID,Name, Aisle, Books_Count) values(@categoryid,@name,@aisle,@count)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("New Data Entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Categories_Load(sender, e);
        }

        private void dataGridView_Categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView_Categories.Rows[indexRow];
            textBox_category_id.Text = row.Cells[0].Value.ToString();
            textBox_category_name.Text = row.Cells[1].Value.ToString();
            textBox_category_aisle.Text = row.Cells[2].Value.ToString();
            textBox_category_count.Text = row.Cells[3].Value.ToString();
            
        }

        private void Category_update_button_Click(object sender, EventArgs e)
        {
            string msg_dial = " ";
            sql.query("SELECT * FROM Category WHERE (CategoryID='" + textBox_category_id.Text + "') OR (Name = '"+ textBox_category_name.Text+ "')");
            
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                if ((int)sql.dt.Rows.Count > 0)
                {
                    command.CommandText = "update Category set CategoryID=@categoryid, Name=@name,Aisle=@aisle, Books_Count=@count where (CategoryID=@categoryid) or (Name =@name)";
                    command.Parameters.AddWithValue("@categoryid", textBox_category_id.Text);
                    command.Parameters.AddWithValue("@name", textBox_category_name.Text);
                    command.Parameters.AddWithValue("@aisle", textBox_category_aisle.Text);
                    command.Parameters.AddWithValue("@count", textBox_category_count.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    msg_dial = "Updated Successfully!";
                }
                else
                {
                    sql.Param("@categoryid", textBox_category_id.Text);
                    sql.Param("@name", textBox_category_name.Text);
                    sql.Param("@aisle", textBox_category_aisle.Text);
                    sql.Param("@count", textBox_category_count.Text);
                    sql.query("insert into Category (CategoryID,Name, Aisle, Books_Count) values(@categoryid,@name,@aisle,@count)");
                    if (sql.Check4error(true))
                    {
                        msg_dial = "Entered Data is Unique! Updated Successfully";
                        return;
                    }
                }
                MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Categories_Load(sender, e);
            }
        }

        private void Category_Delete_Button_Click(object sender, EventArgs e)
        {
            string msg_dial_del = " ";
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                command.CommandText = "delete Category where CategoryID = @categoryid";
                command.Parameters.AddWithValue("@categoryid", textBox_category_id.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                msg_dial_del = "Deleted Successfully!";
            }
            MessageBox.Show(msg_dial_del, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Categories_Load(sender, e);

        }

       
    }
}
