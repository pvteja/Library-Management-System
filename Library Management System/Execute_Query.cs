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
    public partial class Execute_Query : Form
    {

        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        
        public Execute_Query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Execute_Query_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sqlQuery = richTextBox_query.Text;
            MessageBox.Show(sqlQuery, "Query", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = sqlQuery;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                sda.Fill(dt);
                dataGridView_execute_query.DataSource = dt;
                connection.Close();
            }

        }

        private void button_query1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sqlQuery = "SELECT Patron_Account.Name, Patron_Account.[Account ID] FROM Patron_Account WHERE EXISTS (SELECT Check_Outs_Holds.[Patron Account ID] FROM Check_Outs_Holds WHERE Check_Outs_Holds.[Patron Account ID] = Patron_Account.[Account ID])";
            richTextBox_query.Text = sqlQuery;
            //MessageBox.Show(sqlQuery, "Query", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = sqlQuery;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                sda.Fill(dt);
                dataGridView_execute_query.DataSource = dt;
                connection.Close();
            }
            //richTextBox_query.Text = " ";
        }

        private void button_query2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sqlQuery = "SELECT Category.Name, Books.ISBN FROM Category, Books WHERE Category.CategoryID = Books.CategoryID";
            richTextBox_query.Text = sqlQuery;
            //MessageBox.Show(sqlQuery, "Query", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = sqlQuery;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                sda.Fill(dt);
                dataGridView_execute_query.DataSource = dt;
                connection.Close();
            }
            //richTextBox_query.Text = " ";
        }

        private void button_query3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sqlQuery = "SELECT Books.Name, Books.Author FROM Books, Category Where Books.[Published Year] > '2020-01-01' AND Category.[CategoryID] = 'CATE002'";
            richTextBox_query.Text = sqlQuery;
            //MessageBox.Show(sqlQuery, "Query", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand cmd = connection.CreateCommand())
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                cmd.CommandText = sqlQuery;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                sda.Fill(dt);
                dataGridView_execute_query.DataSource = dt;
                connection.Close();
            }
        }
    }
}
