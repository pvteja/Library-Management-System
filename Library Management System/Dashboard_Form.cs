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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }
        
        
        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Hide();
        }

        private void Dashboard_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Books_Button_Click(object sender, EventArgs e)
        {
            Books_Catalog bc = new Books_Catalog();
            bc.Show();
        }

        private void Patrons_Button_Click(object sender, EventArgs e)
        {
            Patrons_Accounts pa = new Patrons_Accounts();       
            pa.Show();
        }

        private void Check_out_Button_Click(object sender, EventArgs e)
        {
            Check_Outs_Holds coh = new Check_Outs_Holds();
            coh.Show();
        }

        private void Notification_Button_Click(object sender, EventArgs e)
        {
            Notifications notify = new Notifications();
            notify.Show();
        }

        private void Category_Button_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.Show();
        }

        private void Query_Button_Click(object sender, EventArgs e)
        {
            Execute_Query equ = new Execute_Query();
            equ.Show();
        }
    }
}
