using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleTextEditiorL4DC
{
    public partial class frmloginForm : Form
    {

        textfileDSTableAdapters.USERSTableAdapter uds = new textfileDSTableAdapters.USERSTableAdapter();
        public static String userid, username;
        public frmloginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmuserRegister u = new frmuserRegister();
            u.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            String email = txtemail.Text;
            String password = txtPassWord.Text;
           dt =  uds.CheckUserLogin(email, password);
           if (txtemail.Text =="")
           {
               MessageBox.Show("Enter Email Address", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtemail.Focus();
           }
           else if (txtPassWord.Text  =="")
           {
               MessageBox.Show("Enter Password", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtPassWord.Focus();

           }
           
           else
           {
               if (dt.Rows.Count >= 0)
               {
                   userid = dt.Rows[0][0].ToString();
                   username = dt.Rows[0][1].ToString();
                   MessageBox.Show("Login Successfully", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show(" Invalid Login", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
           
        }

        private void frmloginForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
