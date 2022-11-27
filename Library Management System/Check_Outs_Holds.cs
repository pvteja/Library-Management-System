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
using System.Globalization;

namespace Library_Management_System
{
    public partial class Check_Outs_Holds : Form
    {

        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        DataBaseControl sql = new DataBaseControl();
        int indexRow;

        public Check_Outs_Holds()
        {
            InitializeComponent();
        }

        private void Check_Outs_Holds_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connection_string))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Check_Outs_Holds", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView_Check_Holds.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patrons_update_button_Click(object sender, EventArgs e)
        {
            string msg_dial = " ";
            sql.query("SELECT * FROM Check_Outs_Holds WHERE [Patron Account ID] = '" + textBox_patron_acc_id.Text + "' AND ISBN='" + textBox_checkout_isbn.Text + "'");
            DateTime st_date = dateTimePicker_start_coh.Value;
            int sdays = st_date.Day;
            int smnth = st_date.Month;
            int syear = st_date.Year;
            int shrs = st_date.Hour;
            int smin = st_date.Minute;
            int ssec = st_date.Second;

            string start_date = syear + "-" + smnth + "-" + sdays + " " + shrs + ":" + smin + ":" + ssec;
            //MessageBox.Show(start_date, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DateTime ed_date = dateTimePicker_end_coh.Value;
            int days = ed_date.Day;
            int mnth = ed_date.Month;
            int year = ed_date.Year;
            int hrs = ed_date.Hour;
            int min = ed_date.Minute;
            int sec = ed_date.Second;

            string end_date = year + "-" + mnth + "-" + days + " " + hrs + ":" + min + ":" + sec;

            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                if ((int)sql.dt.Rows.Count > 0)
                {
                    command.CommandText = "update Check_Outs_Holds set [Start Date_Time]=@startdate,[End Date_Time]=@enddate, IsReturned=@isreturn where [Patron Account ID] = @accountId and ISBN=@isbn";
                    command.Parameters.AddWithValue("@accountId", textBox_patron_acc_id.Text);
                    command.Parameters.AddWithValue("@startdate", start_date);
                    command.Parameters.AddWithValue("@enddate", end_date);
                    command.Parameters.AddWithValue("@isbn", textBox_checkout_isbn.Text);
                    command.Parameters.AddWithValue("@isreturn", radioButton_retrun_yes.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    msg_dial = "Updated Successfully!";
                }
                else
                {
                    sql.Param("@accountId", textBox_patron_acc_id.Text);
                    sql.Param("@startdate", start_date);
                    sql.Param("@enddate", end_date);
                    sql.Param("@isbn", textBox_checkout_isbn.Text);
                    sql.Param("@isreturn", radioButton_retrun_yes.Text);
                    sql.query("insert into Check_Outs_Holds ([Patron Account ID],[ISBN], [Start Date_Time], [End Date_Time], IsReturned) values(@accountId,@isbn,@startdate,@enddate,@isreturn)");
                    if (sql.Check4error(true))
                    {
                        msg_dial = "Entered Data is Unique! Updated Successfully";
                        return;
                    }
                }
                MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Check_Outs_Holds_Load(sender, e);
                
            }
        }

        private void CheckOut_Create_Button_Click(object sender, EventArgs e)
        {
            DateTime st_date = dateTimePicker_start_coh.Value;
            int sdays = st_date.Day;
            int smnth = st_date.Month;
            int syear = st_date.Year;
            int shrs = st_date.Hour;
            int smin = st_date.Minute;
            int ssec = st_date.Second;

            string start_date = syear + "-" + smnth + "-" + sdays + " " + shrs + ":" + smin + ":" + ssec;
            //MessageBox.Show(start_date, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DateTime ed_date = dateTimePicker_end_coh.Value;
            int days = ed_date.Day;
            int mnth = ed_date.Month;
            int year = ed_date.Year;
            int hrs = ed_date.Hour;
            int min = ed_date.Minute;
            int sec = ed_date.Second;

            string end_date = year + "-" + mnth + "-" + days + " " + hrs + ":" + min + ":" + sec;
           // MessageBox.Show(end_date, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sql.Param("@accountId", textBox_patron_acc_id.Text);
            sql.Param("@startdate", start_date);
            sql.Param("@enddate", end_date);
            sql.Param("@isbn", textBox_checkout_isbn.Text);
            sql.Param("@isreturn", radioButton_retrun_yes.Text);
            sql.query("insert into Check_Outs_Holds ([Patron Account ID],[ISBN], [Start Date_Time], [End Date_Time], IsReturned) values(@accountId,@isbn,@startdate,@enddate,@isreturn)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("New Data Entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Check_Outs_Holds_Load(sender, e);


        }

        private void dataGridView_Check_Holds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView_Check_Holds.Rows[indexRow];
            textBox_patron_acc_id.Text = row.Cells[0].Value.ToString();
            dateTimePicker_start_coh.Text = row.Cells[2].Value.ToString();
            dateTimePicker_end_coh.Text = row.Cells[3].Value.ToString();
            textBox_checkout_isbn.Text = row.Cells[1].Value.ToString();
            radioButton_retrun_yes.Text = row.Cells[4].Value.ToString();
           

        }

        private void CheckOut_Delete_Button_Click(object sender, EventArgs e)
        {
            string msg_dial_del = " ";
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                command.CommandText = "delete Check_Outs_Holds where [Patron Account ID] = @accountId AND ISBN=@isbn";
                command.Parameters.AddWithValue("@accountId", textBox_patron_acc_id.Text);
                command.Parameters.AddWithValue("@isbn", textBox_checkout_isbn.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                msg_dial_del = "Deleted Successfully!";
            }
            MessageBox.Show(msg_dial_del, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Check_Outs_Holds_Load(sender, e);

        }
    }
}
