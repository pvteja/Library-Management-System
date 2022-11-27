using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Books_Catalog : Form
    {
        public Books_Catalog()
        {
            InitializeComponent();
        }

        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        DataBaseControl sql = new DataBaseControl();

        public void Books_Catalog_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection_string))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Books", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView_Books.DataSource = dtbl;

            }
        }

        private void Books_insert_Button_Click(object sender, EventArgs e)
        {
            sql.Param("@isbn", textBox_ISBN.Text);
            sql.Param("@author", textBox_Author.Text);
            sql.Param("@publisher", textBox_Publisher.Text);
            sql.Param("@pub_year", textBox_publ_year.Text);
            sql.Param("@category", textBox_books_category.Text);
            sql.Param("@bookname", textBox_bookname.Text);
            sql.query("insert into Books (ISBN,Name, Author, Publisher, [Published Year], CategoryID) values(@isbn,@bookname,@author,@publisher,@pub_year,@category)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("New Data Entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Books_Catalog_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int indexRow;
        private void Books_update_button_Click(object sender, EventArgs e)
        {
            string msg_dial = " ";
            sql.query("SELECT * FROM Books WHERE ISBN = '" + textBox_ISBN.Text + "'");
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand()) 
            {

                if ((int)sql.dt.Rows.Count > 0)
                {
                    command.CommandText = "update Books set Name=@bookname, Author=@author,Publisher=@publisher,[Published Year]=@pub_year, CategoryID=@category where ISBN = @isbn";
                    command.Parameters.AddWithValue("@isbn", textBox_ISBN.Text);
                    command.Parameters.AddWithValue("@author", textBox_Author.Text);
                    command.Parameters.AddWithValue("@publisher", textBox_Publisher.Text);
                    command.Parameters.AddWithValue("@pub_year", textBox_publ_year.Text);
                    command.Parameters.AddWithValue("@category", textBox_books_category.Text);
                    command.Parameters.AddWithValue("@bookname", textBox_bookname.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    msg_dial = "Updated Successfully!";
                }
                else
                {
                    sql.Param("@isbn", textBox_ISBN.Text);
                    sql.Param("@author", textBox_Author.Text);
                    sql.Param("@publisher", textBox_Publisher.Text);
                    sql.Param("@pub_year", textBox_publ_year.Text);
                    sql.Param("@category", textBox_books_category.Text);
                    sql.Param("@bookname", textBox_bookname.Text);
                    sql.query("insert into Books (ISBN,Name, Author, Publisher, [Published Year], CategoryID) values(@isbn,@bookname,@author,@publisher,@pub_year,@category)");
                    if (sql.Check4error(true))
                    {
                        msg_dial = "Entered Data is Unique! Updated Successfully";
                        return;
                    }
                }

                /* sql.query("update Books set Name='" + textBox_bookname.Text + "', Author='" + textBox_Author.Text + "',Publisher='" + textBox_Publisher.Text + "',[Published Year]='" + textBox_publ_year.Text + "', Category='" + textBox_books_category.Text + "' where ISBN = '" + textBox_ISBN.Text + "'");
                 //sql.query("update Books set Name='@bookname', Author='@author',Publisher='@publisher',[Published Year]='@pub_year', Category='@category' where ISBN = '@isbn'");
                 sql.Param("@isbn", textBox_ISBN.Text);
                 sql.Param("@author", textBox_Author.Text);
                 sql.Param("@publisher", textBox_Publisher.Text);
                 sql.Param("@pub_year", textBox_publ_year.Text);
                 sql.Param("@category", textBox_books_category.Text);
                 sql.Param("@bookname", textBox_bookname.Text);

                 //  sql.query("update Books(Name, Author, Publisher, [Published Year],Category) values(@bookname,@author,@publisher,@pub_year,@category) where ISBN='@isbn'");
                 if (sql.Check4error(true))
                 {
                     msg_dial = "Updated Successfully!";
                     return;

                 }*/
            }
            
            MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Books_Catalog_Load(sender, e);

        }

        private void Books_Delete_Button_Click(object sender, EventArgs e)
        {
            string msg_dial_del = " ";
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                command.CommandText = "delete Books where [ISBN] = @isbn";
                command.Parameters.AddWithValue("@isbn", textBox_ISBN.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                msg_dial_del = "Deleted Successfully!";
            }
            MessageBox.Show(msg_dial_del, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Books_Catalog_Load(sender, e);

        }

        private void dataGridView_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView_Books.Rows[indexRow];
            textBox_ISBN.Text = row.Cells[0].Value.ToString();
            textBox_bookname.Text = row.Cells[1].Value.ToString();
            textBox_Author.Text = row.Cells[2].Value.ToString();
            textBox_Publisher.Text = row.Cells[3].Value.ToString();
            textBox_publ_year.Text = row.Cells[4].Value.ToString();
            textBox_books_category.Text = row.Cells[5].Value.ToString();
        }
    }
}
