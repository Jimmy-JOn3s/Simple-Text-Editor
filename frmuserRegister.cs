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
    public partial class frmuserRegister : Form
    {
        textfileDSTableAdapters.USERSTableAdapter uds = new textfileDSTableAdapters.USERSTableAdapter();

        public frmuserRegister()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = uds.GetData();
            if (dt.Rows.Count == 0)
            {
                lblID.Text = "U_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));
                if (newid >= 1 && newid <= 9)
                {
                    lblID.Text = "U_00" + (newid + 1);
                }
            }
        }
        public void ClearData()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";


        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmuserRegister_Load(object sender, EventArgs e)
        {
            AutoID();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CLSuserRGISTER us = new CLSuserRGISTER();
            us.userid = lblID.Text;
            us.username = txtusername.Text;
            us.email = txtemail.Text;
            us.password = txtpassword.Text;
             if (txtemail.Text == "" && txtpassword.Text == "" && txtusername.Text == "")
	            {
                    MessageBox .Show ("Invaild Login", "User Register", MessageBoxButtons .OK,MessageBoxIcon .Error );
	            }
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter UserName", "User Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Enter Email", "User Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter PassWord", "User Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
            }
                 
            else
            {
               int total =  uds.InsertUserData(us.userid, us.username, us.email, us.password);
                if (total >0)
                {
                    MessageBox.Show("User Save Successfully", "User Register", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    ClearData();
                    AutoID();
                    txtusername.Focus();
                }
              
            }
           

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
