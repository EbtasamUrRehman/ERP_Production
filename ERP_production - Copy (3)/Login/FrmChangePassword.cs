using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Production.Login
{
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        private int id;

        public string UsrPSWd { get; private set; }

        public FrmChangePassword()
        {
            InitializeComponent();
        }

       

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void ChangePassword()
        {
            if (txtPassword.Text.Length > 0)
            {
                UsrPSWd = this.tbl_User_LoginsTableAdapter.GetUserPswd(frmLogin.UserID);
                if (UsrPSWd == this.txtPassword.Text && this.txtConfirmPassword.Text == this.txtConfirmPassword1.Text)
                {
                    if (ValidPassword(txtConfirmPassword.Text))
                    {
                        this.tbl_User_LoginsTableAdapter.UpdateUserPswd(null, DateTime.Now, this.txtConfirmPassword.Text, false, frmLogin.UserID);
                        MessageBox.Show("Password has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtPassword.Text = null;
                        this.txtConfirmPassword.Text = null;
                        this.txtConfirmPassword1.Text = null;
                        this.txtPassword.Focus();
                        //FrmMain.Logout();
                    }
                    else
                    {
                        MessageBox.Show("Please use a combination of capital letters, numbers, and special characters", "Please use a complicated password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPassword.Text = null;
                        this.txtConfirmPassword.Text = null;
                        this.txtConfirmPassword1.Text = null;
                        this.txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("New and Confirm Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Text = null;
                    this.txtConfirmPassword.Text = null;
                    this.txtConfirmPassword1.Text = null;
                    this.txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Text = null;
                this.txtConfirmPassword.Text = null;
                this.txtConfirmPassword1.Text = null;
                this.txtPassword.Focus();
            }
        }

        private bool ValidPassword(string myPassword)
        {
            if (myPassword.Length < 8) return false;
            if (!myPassword.Any(char.IsDigit)) return false;
            if (!myPassword.Any(char.IsLower)) return false;
            if (!myPassword.Any(char.IsUpper)) return false;
            return true;
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(frmLogin.UserID);
            try
            {
                // Attempt to fill the data
                this.tbl_User_LoginsTableAdapter.FillBy(this.newDS.tbl_User_Logins, id);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                //MessageBox.Show($"Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string Username = frmLogin.UserName;
            string Password = frmLogin.UserPwdd;
            //txtPassword.Text = Password;
            txtUserName.Text = Username;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
