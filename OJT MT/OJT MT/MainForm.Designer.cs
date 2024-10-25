namespace OJT_MT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            menuButton = new PictureBox();
            buttonHome = new Button();
            buttonInternList = new Button();
            buttonAccomplishmentReports = new Button();
            buttonAttendance = new Button();
            buttonSettings = new Button();
            buttonLogOut = new Button();
            mainPanel = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(buttonHome);
            sidebar.Controls.Add(buttonInternList);
            sidebar.Controls.Add(buttonAccomplishmentReports);
            sidebar.Controls.Add(buttonAttendance);
            sidebar.Controls.Add(buttonSettings);
            sidebar.Controls.Add(buttonLogOut);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(255, 1080);
            sidebar.MinimumSize = new Size(64, 200);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(255, 900);
            sidebar.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 45);
            panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.Image = Properties.Resources.menu_burger1;
            menuButton.Location = new Point(12, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(32, 36);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // buttonHome
            // 
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ButtonHighlight;
            buttonHome.Image = Properties.Resources.home1;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(3, 54);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(15, 0, 0, 0);
            buttonHome.Size = new Size(253, 41);
            buttonHome.TabIndex = 4;
            buttonHome.Text = "            Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonInternList
            // 
            buttonInternList.FlatAppearance.BorderSize = 0;
            buttonInternList.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonInternList.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonInternList.FlatStyle = FlatStyle.Flat;
            buttonInternList.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInternList.ForeColor = SystemColors.ButtonHighlight;
            buttonInternList.Image = Properties.Resources.member_list;
            buttonInternList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInternList.Location = new Point(3, 101);
            buttonInternList.Name = "buttonInternList";
            buttonInternList.Padding = new Padding(15, 0, 0, 0);
            buttonInternList.Size = new Size(252, 41);
            buttonInternList.TabIndex = 4;
            buttonInternList.Text = "            List of Interns";
            buttonInternList.TextAlign = ContentAlignment.MiddleLeft;
            buttonInternList.UseVisualStyleBackColor = true;
            buttonInternList.Click += buttonInternList_Click;
            // 
            // buttonAccomplishmentReports
            // 
            buttonAccomplishmentReports.FlatAppearance.BorderSize = 0;
            buttonAccomplishmentReports.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAccomplishmentReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAccomplishmentReports.FlatStyle = FlatStyle.Flat;
            buttonAccomplishmentReports.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccomplishmentReports.ForeColor = SystemColors.ButtonHighlight;
            buttonAccomplishmentReports.Location = new Point(3, 148);
            buttonAccomplishmentReports.Name = "buttonAccomplishmentReports";
            buttonAccomplishmentReports.Padding = new Padding(15, 0, 0, 0);
            buttonAccomplishmentReports.Size = new Size(252, 41);
            buttonAccomplishmentReports.TabIndex = 4;
            buttonAccomplishmentReports.Text = "            Accomplishment Reports";
            buttonAccomplishmentReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccomplishmentReports.UseVisualStyleBackColor = true;
            buttonAccomplishmentReports.Click += buttonAccomplishmentReports_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAttendance.ForeColor = SystemColors.ButtonHighlight;
            buttonAttendance.Location = new Point(3, 195);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Padding = new Padding(15, 0, 0, 0);
            buttonAttendance.Size = new Size(252, 41);
            buttonAttendance.TabIndex = 4;
            buttonAttendance.Text = "            Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = SystemColors.ButtonHighlight;
            buttonSettings.Image = Properties.Resources.user_gear;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(3, 242);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(15, 0, 0, 0);
            buttonSettings.Size = new Size(252, 41);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "            Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Roboto Cn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = SystemColors.ButtonHighlight;
            buttonLogOut.Image = Properties.Resources.sign_out_alt1;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(3, 289);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Padding = new Padding(15, 0, 0, 0);
            buttonLogOut.Size = new Size(252, 41);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "            Logout";
            buttonLogOut.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(255, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1345, 900);
            mainPanel.TabIndex = 5;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(mainPanel);
            Controls.Add(sidebar);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OJT Management System";
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private PictureBox menuButton;
        private Button buttonHome;
        private Button buttonInternList;
        private Button buttonAttendance;
        private Button buttonSettings;
        private Button buttonLogOut;
        private Panel mainPanel;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button buttonAccomplishmentReports;
    }
}