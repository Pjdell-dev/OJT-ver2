using System;
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
        private string _accountType;
        private string _accountID;

        public MainForm()
        {
            InitializeComponent();
            LogOut();
        }
        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }
        public void LoginUser(string account_type, string user_id)
        {
            _accountType = account_type;
            _accountID = user_id;
            switch (account_type)
            {
                case "admin":
                    buttonAccomplishmentReports.Hide();
                    buttonAttendance.Hide();
                    buttonInternList.Hide();
                    LoadForm(new Register(this));
                    break;
                case "supervisor":
                    buttonAccomplishmentReports.Show();
                    buttonAttendance.Show();
                    buttonInternList.Show();
                    LoadForm(new InternList(this));
                    break;
                case "student":
                    break;
            }
            sidebar.Show();
        }
        private void buttonInternList_Click(object sender, EventArgs e)
        {
            LoadForm(new InternList(this));
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void buttonAccomplishmentReports_Click(object sender, EventArgs e)
        {
            SupervisorARPage supervisorARPage = new SupervisorARPage(this);
            LoadForm(supervisorARPage);

        }
        private void LogOut()
        {
            LoginPage loginPage = new LoginPage(this);
            LoadForm(loginPage);
            sidebarExpand = true;
            sidebarTimer.Start();
            sidebar.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
