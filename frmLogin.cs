using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace ERP_Production
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm

    {
        public static bool IsLoggedIn = false;
        public static string UserName;
        public static int UserID;
        public static int DeptID;
        public static string LoginName = "";
        public static int ModID;
        public static int USerLogiD;
        public static string UserPwdd;
        public static string SysIP = null;

        private string IpAddress;
        private string HostName = Dns.GetHostName();
        private IPHostEntry ipEntry;
        private IPAddress[] IpAddr;
        private DialogResult dgResult;
        private int Counter;
        public string UserPwd;
        public frmLogin()
        {
            InitializeComponent();
            ipEntry = Dns.GetHostEntry(HostName);
            IpAddr = ipEntry.AddressList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool ChildWindowOpen(string childWindow)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == childWindow)
                {
                    f.Focus();
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserPwd = string.Empty; // Initialize UserPwd
            DateTime PSWDate;
            int DateDiff1;
            int LogStatus = 0;
            string SysIpAdd = null;
            SysIpAdd = Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
            string pass;

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter username and Password", "Fields Are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Counter = 0;
            }
            else
            {
                try
                {
                    // Assuming Tbl_User_LoginsTableAdapter is your table adapter and NewDS is your dataset
                    if (this.tbl_User_LoginsTableAdapter.Fill(this.newDS.tbl_User_Logins, txtUsername.Text, txtPassword.Text) > 0)
                    {
                        UserID = Convert.ToInt32(this.newDS.tbl_User_Logins.Rows[0]["UserID"]);
                        UserPwd = this.newDS.tbl_User_Logins.Rows[0]["Password"].ToString();
                    }
                    else
                    {
                        UserID = 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }

                if (this.tbl_Lock_UserTableAdapter.Fill(this.newDS.Tbl_Lock_User, UserID) > 100)
                {
                    this.Close();
                    MessageBox.Show("Your Account has Been Locked Due to Entering Wrong Password Multiple times. Contact To ERP Administrator", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (UserPwd == txtPassword.Text)
                    {
                        SysIP = SysIpAdd;
                        LoginName = txtUsername.Text;
                        UserID = Convert.ToInt32(this.newDS.tbl_User_Logins.Rows[0]["UserID"]);
                        DeptID = Convert.ToInt32(this.newDS.tbl_User_Logins.Rows[0]["DeptID"]);
                        //ModID = Convert.ToInt32(this.newDS.tbl_User_Logins.Rows[0]["ModID"]);
                        UserName = this.newDS.tbl_User_Logins.Rows[0]["LoginName"].ToString();
                        UserPwd = this.newDS.tbl_User_Logins.Rows[0]["Password"].ToString();
                        //UserPwd = Class_Utility.Decrypt(this.newDS.tbl_User_Logins.Rows[0]["EncryptPSWD"].ToString(), 100);

                        PSWDate = Convert.ToDateTime(this.newDS.tbl_User_Logins.Rows[0]["PSWDChngDate"]);

                        if (!Convert.ToBoolean(this.newDS.tbl_User_Logins.Rows[0]["SpStatus"]))
                        {
                            if (DateTime.Now.Subtract(PSWDate).Days >= 60)
                            {
                                LogStatus = 2;
                                MessageBox.Show("Your ERP Password has been Expired", "Password Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        // Set the login status to true

                        frmLogin.IsLoggedIn = true; // Update static login status

                        // Get existing FrmMain instance or create a new one
                        FrmMain frmMain = FrmMain.GetInstance();
                        frmMain.SetLoginStatus(frmLogin.IsLoggedIn); // Update visibility based on login status
                        frmMain.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

       
    }

