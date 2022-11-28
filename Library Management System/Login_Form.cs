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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        //User_Icon.Image = Image.FromFile("../../IMAGES/User.png");
        //Password_Icon.Image = Image.FromFile("../../IMAGES/Password.png");
        DataBaseControl sql = new DataBaseControl();
        bool Login()
        {
            sql.Param("@user", Login_User_ID.Text);
            sql.Param("@pwd", Login_Password.Text);
            sql.query("select count(*) from Users where UserID=@user and Password=@pwd");
            if ((int)sql.dt.Rows[0][0] == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid UserID or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void UserLogin_Click(object sender, EventArgs e)
        {
            
            if (Login() == true) {

                Dashboard_Form df = new Dashboard_Form();
                df.Show();
                
            }


        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }


        private void New_User_Click(object sender, EventArgs e)
        {
            Register_Form rf = new Register_Form();
            rf.Show();

        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Register_Form)
                {
                    frm.Show();
                }
            }

        }

        private void Login_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
