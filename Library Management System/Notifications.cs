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
    public partial class Notifications : Form
    {
        string connection_string = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14694\Downloads\DB Project1\Library Management System\Library Management System\Library Database.mdf; Integrated Security=True";
        DataBaseControl sql = new DataBaseControl();
        int indexRow;

        public Notifications()
        {
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection_string))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Notifications", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView_Notifications.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notify_Create_Button_Click(object sender, EventArgs e)
        {
            DateTime ed_date = dateTimePicker_sent_date.Value;
            int days = ed_date.Day;
            int mnth = ed_date.Month;
            int year = ed_date.Year;
            int hrs = ed_date.Hour;
            int min = ed_date.Minute;
            int sec = ed_date.Second;

            string sent_date = year + "-" + mnth + "-" + days + " " + hrs + ":" + min + ":" + sec;

            sql.Param("@accountId", textBox_notify_patron_id.Text);
            sql.Param("@sentdate", sent_date);
            sql.Param("@email", textBox_notification_email.Text);
            sql.Param("@isbn", textBox_notifications_isbn.Text);
            sql.Param("@message", richTextBox_notify_message.Text);
            sql.query("insert into Notifications ([Patron ID],[ISBN], [Notify Date], [NotifyID], Message) values(@accountId,@isbn,@sentdate,@email,@message)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("New Data Entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Notifications_Load(sender, e);

        }

        private void dataGridView_Notifications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView_Notifications.Rows[indexRow];
            textBox_notify_patron_id.Text = row.Cells[1].Value.ToString();
            textBox_notifications_isbn.Text = row.Cells[2].Value.ToString();
            dateTimePicker_sent_date.Text = row.Cells[3].Value.ToString();
            textBox_notification_email.Text = row.Cells[0].Value.ToString();
            richTextBox_notify_message.Text = row.Cells[4].Value.ToString();

        }

        private void Notify_update_button_Click(object sender, EventArgs e)
        {
            string msg_dial = " ";
            sql.query("SELECT * FROM Notifications WHERE [Patron Account ID] = '" + textBox_notify_patron_id.Text + "' AND ISBN='" + textBox_notifications_isbn.Text + "'");
            DateTime st_date = dateTimePicker_sent_date.Value;
            int sdays = st_date.Day;
            int smnth = st_date.Month;
            int syear = st_date.Year;
            int shrs = st_date.Hour;
            int smin = st_date.Minute;
            int ssec = st_date.Second;

            string start_date = syear + "-" + smnth + "-" + sdays + " " + shrs + ":" + smin + ":" + ssec;
            //MessageBox.Show(start_date, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                if ((int)sql.dt.Rows.Count > 0)
                {
                    command.CommandText = "update Notifications set [Notify Date]=@sentdate, [NotifyID]=@email, Message=@message where [Patron ID] = @accountId and ISBN=@isbn";
                    command.Parameters.AddWithValue("@accountId", textBox_notify_patron_id.Text);
                    command.Parameters.AddWithValue("@sentdate", start_date);
                    command.Parameters.AddWithValue("@email", textBox_notification_email);
                    command.Parameters.AddWithValue("@isbn", textBox_notifications_isbn.Text);
                    command.Parameters.AddWithValue("@message", richTextBox_notify_message.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    msg_dial = "Updated Successfully!";
                }
                else
                {
                    sql.Param("@accountId", textBox_notify_patron_id.Text);
                    sql.Param("@sentdate", start_date);
                    sql.Param("@email", textBox_notification_email.Text);
                    sql.Param("@isbn", textBox_notifications_isbn.Text);
                    sql.Param("@message", richTextBox_notify_message.Text);
                    sql.query("insert into Notifications ([Patron ID],[ISBN], [Notify Date], [NotifyID], Message) values(@accountId,@isbn,@sentdate,@email,@message)");
                    if (sql.Check4error(true))
                    {
                        msg_dial = "Entered Data is Unique! Updated Successfully";
                        return;
                    }
                }
                MessageBox.Show(msg_dial, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Notifications_Load(sender, e);
            }
        }

        private void Notify_Delete_Button_Click(object sender, EventArgs e)
        {
            string msg_dial_del = " ";
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = connection.CreateCommand())
            {

                command.CommandText = "delete Notifications where [Patron ID] = @accountId AND ISBN=@isbn";
                command.Parameters.AddWithValue("@accountId", textBox_notify_patron_id.Text);
                command.Parameters.AddWithValue("@isbn", textBox_notifications_isbn.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                msg_dial_del = "Deleted Successfully!";
            }
            MessageBox.Show(msg_dial_del, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Notifications_Load(sender, e);

        }

        private void dateTimePicker_sent_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
