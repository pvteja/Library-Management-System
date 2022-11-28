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
    public partial class Patrons_Accounts : Form
    {

        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        DataBaseControl sql = new DataBaseControl();
        int indexRow;

        public Patrons_Accounts()
        {
            InitializeComponent();
        }

        private void Patrons_Accounts_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection_string))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Patron_Account", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView_Patrons.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patrons_insert_Button_Click(object sender, EventArgs e)
        {
            sql.Param("@accountId", textBox_pat_acc_id.Text);
            sql.Param("@studentId", textBox_patron_id.Text);
            sql.Param("@name", textBox_patron_name.Text);
            sql.Param("@email", textBox_pat_email.Text);
            sql.Param("@dob", textBox_pat_dob.Text);
            string acc_stat = radioButton_active.Text;
            string in_acc_stat = radioButton_inactive.Text;
            MessageBox.Show(in_acc_stat, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (acc_stat != "Active")
            {
                //acc_stat = "Inactive";
                sql.Param("@acc_status", radioButton_inactive.Text);
            }
            else {
                sql.Param("@acc_status", radioButton_active.Text);
            }
            
            sql.query("insert into Patron_Account ([Account ID],[Student ID], Name, Email, [Date of Birth], [Account Status]) values(@accountId,@studentId,@name,@email,@dob,@acc_status)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("New Data Entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Patrons_Accounts_Load(sender, e);


        }

        private void Patrons_update_button_Click(object sender, EventArgs e)
        {
            /*if (indexRow == 0 || indexRow >0) {
                DataGridViewRow row = dataGridView_Patrons.Rows[indexRow];
                row.Cells[0].Value = textBox_pat_acc_id.Text;
                row.Cells[1].Value = textBox_patron_id.Text;
                row.Cells[2].Value = textBox_patron_name.Text;
                row.Cells[3].Value = textBox_pat_email.Text;
                row.Cells[4].Value = textBox_pat_dob.Text;
                row.Cells[5].Value = radioButton_active.Text;
            }*/
            string msg_dial = " ";
            sql.query("SELECT * FROM Patron_Account WHERE [Account ID] = '" + textBox_pat_acc_id.Text + "'");
            if ((int)sql.dt.Rows.Count > 0)
            {
                string acc_stat = radioButton_active.Text;
                string in_acc_stat = radioButton_inactive.Text;
                //MessageBox.Show(in_acc_stat, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (acc_stat != "Active")
                {
                    acc_stat = radioButton_inactive.Text;
                }

                using (SqlConnection connection = new SqlConnection(connection_string))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Patron_Account set [Student ID]=@studentId, Name=@name,Email=@email,[Date of Birth]=@dob, [Account Status]=@acc_status where [Account ID] = @accountId";
                    command.Parameters.AddWithValue("@accountId", textBox_pat_acc_id.Text);
                    command.Parameters.AddWithValue("@studentId", textBox_patron_id.Text);
                    command.Parameters.AddWithValue("@name", textBox_patron_name.Text);
                    command.Parameters.AddWithValue("@email", textBox_pat_email.Text);
                    command.Parameters.AddWithValue("@dob", textBox_pat_dob.Text);
                    command.Parameters.AddWithValue("@acc_status", acc_stat);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    msg_dial = "Updated Successfully!";
                }
                MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Patrons_Accounts_Load(sender, e);
            }
            else
            {
                sql.Param("@accountId", textBox_pat_acc_id.Text);
                sql.Param("@studentId", textBox_patron_id.Text);
                sql.Param("@name", textBox_patron_name.Text);
                sql.Param("@email", textBox_pat_email.Text);
                sql.Param("@dob", textBox_pat_dob.Text);
                string acc_stat = radioButton_active.Text;
                string in_acc_stat = radioButton_inactive.Text;
                MessageBox.Show(in_acc_stat, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (acc_stat != "Active")
                {
                    acc_stat = "Inactive";
                }
                sql.Param("@acc_status", acc_stat);
                //sql.Param("@acc_status", radioButton_active.Text);


                sql.query("insert into Patron_Account ([Account ID],[Student ID], Name, Email, [Date of Birth], [Account Status]) values(@accountId,@studentId,@name,@email,@dob,@acc_status)");
                msg_dial = "Entered Data is Unique! Updated Successfully";
                if (sql.Check4error(true))
                {
                    msg_dial = "Entered Data is Unique! Updated Successfully";
                    return;
                }
                MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Patrons_Accounts_Load(sender, e);

            }

        }
       
        private void dataGridView_Patrons_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView_Patrons.Rows[indexRow];
            textBox_pat_acc_id.Text = row.Cells[0].Value.ToString();
            textBox_patron_id.Text = row.Cells[1].Value.ToString();
            textBox_patron_name.Text = row.Cells[2].Value.ToString();
            textBox_pat_email.Text = row.Cells[3].Value.ToString();
            textBox_pat_dob.Text = row.Cells[4].Value.ToString();
            radioButton_active.Text = row.Cells[5].Value.ToString();
        }

        private void Patrons_Delete_Button_Click(object sender, EventArgs e)
        {
            string msg_dial_del=" ";
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {
                
                command.CommandText = "delete Patron_Account where [Account ID] = @accountId";
                command.Parameters.AddWithValue("@accountId", textBox_pat_acc_id.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                msg_dial_del = "Deleted Successfully!";
            }
            MessageBox.Show(msg_dial_del, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Patrons_Accounts_Load(sender, e);
        }

        private void radioButton_inactive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
