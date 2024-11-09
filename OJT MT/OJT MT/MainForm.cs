﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{

    public partial class MainForm : Form
    {
        bool sidebarExpand;
        bool manageUsersExpand;
        public string accountType { get; private set; } = string.Empty;//Dito save yung account type para ma access globally
        public string accountID { get; private set; } = string.Empty;//Same sa account ID

        public MainForm()
        {
            accountID = "";
            accountType = "";
            InitializeComponent();
            DoubleBuffered = true;
            LogOut();
        }
        public void LoadForm(Form? newForm)
        {
            if (newForm == null) return;

            //Remove existing controls if any
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            //Add the new form to the panel and display it
            this.mainPanel.Controls.Add(newForm);
            this.mainPanel.Tag = newForm;
            newForm.Show();
        }
        public void LoginUser(string account_type, string user_id)
        {
            accountType = account_type; //Save account type
            accountID = user_id;  //Save account ID
            switch (account_type) //Switch case sa account type (admin, supervisor, student)
            {
                case "admin":
                    buttonAccomplishmentReports.Hide(); //Hide and show related menu buttons
                    buttonAttendance.Hide();
                    buttonInternList.Hide();
                    buttonInternList.Show();
                    buttonManageUsers.Show();
                    flowLayoutPanelManageUsers.Show();
                    LoadForm(new AdminManageUsersForm(this)); //Load Manage Users Form as default for now para sa admin
                    break;
                case "supervisor":
                    buttonAccomplishmentReports.Hide(); //Hide and show related menu buttons
                    buttonAttendance.Hide();
                    buttonInternList.Show();
                    buttonManageUsers.Hide();
                    flowLayoutPanelManageUsers.Hide();
                    LoadForm(new InternListForm(this)); //Load Intern List Form as default for now para sa admin
                    break;
                case "student":
                    break;
            }
            sidebar.Show();
        }
        private void buttonInternList_Click(object sender, EventArgs e) //Intern List Button -> 
        {
            
            LoadForm(new InternListForm(this));
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 25;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 25;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e) //Menu button (hamburger)
        {
            sidebarTimer.Start(); //Start yung timer to open or close sidebar
        }

        private void buttonAccomplishmentReports_Click(object sender, EventArgs e)
        {
            SupervisorARPageForm supervisorARPage = new SupervisorARPageForm(this);
            LoadForm(supervisorARPage);
        }
        private void LogOut() //Logout - Show loginpage tapos hide yung sidebar
        {
            LoginPageForm loginPage = new LoginPageForm(this);
            LoadForm(loginPage);
            sidebarExpand = true;
            sidebarTimer.Start();
            sidebar.Hide();
            manageUsersExpand = true;
            manageUsersButtonTimer.Start();
        }

        private void buttonLogOut_Click(object sender, EventArgs e) //Logout Button
        {
            LogOut();
        }

        private void buttonSettings_Click(object sender, EventArgs e) //Settings Button - Click - Load account settings form -> load yung account id and account type
        {
            AccountSettingsForm Form = new AccountSettingsForm(this);
            LoadForm(Form);
        }

        private void buttonManageUsers_Click(object sender, EventArgs e) //Manage users button - Click - Load manage users form
        {
            manageUsersButtonTimer.Start();
        }

        private void manageUsersButtonTimer_Tick(object sender, EventArgs e)
        {
            if (manageUsersExpand)
            {
                flowLayoutPanelManageUsers.Height -= 20;
                if (flowLayoutPanelManageUsers.Height == flowLayoutPanelManageUsers.MinimumSize.Height)
                {
                    manageUsersExpand = false;
                    manageUsersButtonTimer.Stop();
                }
            }
            else
            {
                flowLayoutPanelManageUsers.Height += 20;
                if (flowLayoutPanelManageUsers.Height == flowLayoutPanelManageUsers.MaximumSize.Height)
                {
                    manageUsersExpand = true;
                    manageUsersButtonTimer.Stop();
                }
            }
        }

        private void buttonUpdateUsers_Click(object sender, EventArgs e) //Update Users Button
        {
            AdminManageUsersForm adminManageUsersForm = new AdminManageUsersForm(this);
            LoadForm(adminManageUsersForm);
        }

        private void buttonAddUser_Click(object sender, EventArgs e) //Register Users Button
        {
            Register register = new Register(this);
            LoadForm(register);
        }
    }
}
