using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }
        DataBaseControl db = new DataBaseControl();

        void Register()
        {
            db.Param("@firstname",textBox_fname.Text +" "+ textBox_lname.Text);
            db.Param("@lastname", textBox_lname.Text);
            db.Param("@userId", textBox_userid.Text);
            db.Param("@password", textBox_pwd.Text);
            db.query("insert into Users (UserID, Password, Name) values(@userId,@password,@firstname)");
            if (db.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login_Form lf = new Login_Form();
            lf.Show();
        }

        

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Login_Form)
                {
                    frm.Show();
                }
            }

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
