using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.DXperience.Demos;
using ERP_Production.Purchase_Order;
using ERP_Production.Login;
using DevExpress.XtraSplashScreen;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_Production.Dashboard;
using ERP_Production.Planning;
using ERP_Production.PackingList;
using ERP_Production.ProPlanReports;
using ERP_Production.Reports;
using ERP_Production.Packing_Mateial_Requisition;
using Erp_Production_Label;

namespace ERP_Production
{
    public partial class FrmMain : FluentDesignForm
    {
        public static FrmMain MainFormInstance { get; private set; }
        private Control _currentControl = null;
        private IOverlaySplashScreenHandle splashScreenHandle;

        public bool IsLoggedIn { get; private set; }

        public FrmMain()
        {
            InitializeComponent();
            MainFormInstance = this;
            UpdateLoginStatus();
        }
        //Here Can be handle show an hide according to login or Status
        private void UpdateLoginStatus()
        {
            if (!IsLoggedIn)
            {
                foreach (Form form in Application.OpenForms)
                {
                    // Hide all forms except the main form
                    if (form != this)
                    {
                        form.Hide();
                    }
                }
            }
            accordionControlElement2.Visible = IsLoggedIn;
            accordionControlElement7.Visible = !IsLoggedIn;
            accordionControlElement8.Visible = IsLoggedIn;
            accordionControlElement1.Visible = IsLoggedIn;
            accordionControlChangePassword.Visible = IsLoggedIn;
            accordionControlPlanning.Visible = IsLoggedIn;

        }

        public void SetLoginStatus(bool isLoggedIn)
        {
            IsLoggedIn = isLoggedIn;

            if (!isLoggedIn)
            {
                // Close and dispose all forms embedded in the fluentDesignFormContainer
                foreach (Control control in fluentDesignFormContainer.Controls)
                {
                    if (control is Form form)
                    {
                        form.Close();
                        control.Dispose();
                    }
                }
                fluentDesignFormContainer.Controls.Clear();
            }

            UpdateLoginStatus();
            //IsLoggedIn = isLoggedIn;
            //UpdateLoginStatus();
        }

        public static FrmMain GetInstance()
        {
            if (MainFormInstance == null || MainFormInstance.IsDisposed)
            {
                MainFormInstance = new FrmMain();
            }
            return MainFormInstance;
        }

       

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateLoginStatus();
            if (!IsLoggedIn)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();

                if (IsLoggedIn)
                {
                    IsLoggedIn = true;
                    UpdateLoginStatus();
                    await LoadDefaultFormAsync();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                await LoadDefaultFormAsync();
            }
        }

        private async Task LoadDefaultFormAsync()
        {
            SplashScreenManager.ShowForm(this, typeof(DevExpress.XtraWaitForm.AutoLayoutDemoWaitForm), true, true, false);

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(200);

                this.Invoke(new Action(() =>
                {
                    if (!fluentDesignFormContainer.Controls.ContainsKey("FrmDashboard"))
                    {
                        FrmDashboard dashboardForm = new FrmDashboard
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            Name = "FrmDashboard"
                        };

                        fluentDesignFormContainer.Controls.Add(dashboardForm);
                        dashboardForm.BringToFront();
                        dashboardForm.Show();
                    }
                }));
            });

            SplashScreenManager.CloseForm();
        }


        public async Task ShowReportAsync(Form formInstance)
        {
            foreach (Control control in fluentDesignFormContainer.Controls)
            {
                if (control == formInstance)
                {
                    // Toggle the form (remove and dispose if already shown)
                    fluentDesignFormContainer.Controls.Remove(formInstance);
                    formInstance.Close();
                    formInstance.Dispose();
                    return;
                }
            }

            // Add the form if it's not already displayed
            formInstance.TopLevel = false; // Adjust if needed
            formInstance.Dock = DockStyle.Fill; // Adjust as needed
            fluentDesignFormContainer.Controls.Add(formInstance);
            formInstance.Show();
        }


        public async Task ShowOrToggleFormAsync<T>() where T : Form, new()
        {
            foreach (Control control in fluentDesignFormContainer.Controls)
            {
                if (control is T existingForm)
                {
                    fluentDesignFormContainer.Controls.Remove(existingForm);
                    existingForm.Close();
                    existingForm.Dispose();
                    return;
                }
            }

            SplashScreenManager.ShowForm(this, typeof(DevExpress.XtraWaitForm.AutoLayoutDemoWaitForm), true, true, false);

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500);

                this.Invoke(new Action(() =>
                {
                    T formToEmbed = new T
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };

                    fluentDesignFormContainer.Controls.Add(formToEmbed);
                    formToEmbed.BringToFront();
                    formToEmbed.Show();
                }));
            });

            SplashScreenManager.CloseForm();
        }
        private async void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmPurchaseOrderNew>();
        }

        private async void accordionControlElement4_Click(object sender, EventArgs e)
        {
            await ShowOrToggleFormAsync<frmCustomer>();
        }

        private async void accordionControlElement1_Click(object sender, EventArgs e)
        {
            await ShowOrToggleFormAsync<FrmDashboard>();
        }

        private async void accordionControlChangePassword_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmChangePassword>();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                frmLogin form2 = new frmLogin();
                form2.FormClosed += (s, args) =>
                {
                    if (form2.DialogResult == DialogResult.OK)
                    {
                        SetLoginStatus(true);
                    }
                };
                form2.Show();
            }
        }
        //private void ShowOrCreateForm<T>() where T : Form, new()
        //{
        //    // Check if the form of type T is already in the container
        //    foreach (Control control in fluentDesignFormContainer.Controls)
        //    {
        //        if (control is T existingForm)
        //        {
        //            existingForm.BringToFront();
        //            return;
        //        }
        //    }

        //    // If not found, create and embed the form
        //    T formToEmbed = new T
        //    {
        //        TopLevel = false,
        //        FormBorderStyle = FormBorderStyle.None,
        //        Dock = DockStyle.Fill
        //    };
        //    fluentDesignFormContainer.Controls.Add(formToEmbed);
        //    formToEmbed.BringToFront();
        //    formToEmbed.Show();
        //}
        private void accordionControlElement2_Click(object sender, EventArgs e) { }
        private void accordionControlElement5_Click(object sender, EventArgs e) { }
        private void accordionControlElement6_Click(object sender, EventArgs e) { }

        private void fluentDesignFormContainer_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            SetLoginStatus(false);

            // Optional: Clear any user session or perform other logout-related tasks
            // ...

            // Update UI
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
       
        private async void accordionControlElement5_Click_1(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<frmPlanningM>();
        }

        private void accordionControlPlanning_Click(object sender, EventArgs e)
        {

        }

        private async Task accordionControlElement9_ClickAsync(object sender, EventArgs e)
        {
            await ShowOrToggleFormAsync<FrmAutoUpload>();
        }

        private async void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmAutoUpload>();
        }

        private async void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmPackingList>();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private async void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmProPlanReports>();
        }

        private async void accordionControlElement11_Click_1(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmProPlanReports>();
        }

        private async void accordionControlElement13_Click(object sender, EventArgs e)
        {
           
        }

        private async void accordionControlElement14_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmPlanningReports>();
        }

        private async void accordionControlElement15_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmOrderManagentReport>();
        }

        private async void accordionControlElement16_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmPlanningReports>();
        }

        private async void accordionControlElement14_Click_1(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<frmLabelPlanning>();
        }

        private async void accordionControlElement17_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmPackingRequisition>();
        }

        private async void accordionControlElement19_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await ShowOrToggleFormAsync<FrmLabelPlan>();
        }

        //private void accordionControlElement11_Click(object sender, EventArgs e)
        //{

        //}

        //private void accordionControlElement1_Click(object sender, EventArgs e)
        //{
        //    ToggleFormAsync<FrmDashboard>();
        //}

        //private void accordionControlChangePassword_Click(object sender, EventArgs e)
        //{

        //    {
        //        if (!IsLoggedIn)
        //        {
        //            MessageBox.Show("You must be logged in to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        foreach (Control control in fluentDesignFormContainer.Controls)
        //        {
        //            if (control is FrmChangePassword)
        //            {
        //                control.BringToFront();
        //                return;
        //            }
        //        }

        //        FrmChangePassword formToEmbed = new FrmChangePassword();
        //        formToEmbed.TopLevel = false;
        //        formToEmbed.FormBorderStyle = FormBorderStyle.None;
        //        formToEmbed.Dock = DockStyle.Fill;
        //        fluentDesignFormContainer.Controls.Add(formToEmbed);
        //        formToEmbed.Show();
        //    }
        //    //FrmChangePassword form = new FrmChangePassword();

        //    //// Show the form
        //    //form.Show();
        //}
    }
}
