﻿namespace OJT_MT
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBoxPasswordEyeIcon = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordEyeIcon).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Bottom;
            buttonLogin.BackColor = Color.Green;
            buttonLogin.FlatAppearance.BorderColor = Color.Black;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(303, 218);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 28);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Bottom;
            textBoxUser.Location = new Point(227, 128);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Enter Email";
            textBoxUser.Size = new Size(227, 23);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom;
            textBoxPassword.Location = new Point(227, 168);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter Password";
            textBoxPassword.Size = new Size(227, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(44, 95, 52);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBoxPasswordEyeIcon);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(60, 60);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBoxPasswordEyeIcon
            // 
            pictureBoxPasswordEyeIcon.Anchor = AnchorStyles.Bottom;
            pictureBoxPasswordEyeIcon.BackColor = Color.White;
            pictureBoxPasswordEyeIcon.Image = Properties.Resources.eye_crossed;
            pictureBoxPasswordEyeIcon.Location = new Point(432, 169);
            pictureBoxPasswordEyeIcon.Margin = new Padding(0);
            pictureBoxPasswordEyeIcon.Name = "pictureBoxPasswordEyeIcon";
            pictureBoxPasswordEyeIcon.Padding = new Padding(2);
            pictureBoxPasswordEyeIcon.Size = new Size(20, 20);
            pictureBoxPasswordEyeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPasswordEyeIcon.TabIndex = 10;
            pictureBoxPasswordEyeIcon.TabStop = false;
            pictureBoxPasswordEyeIcon.Visible = false;
            pictureBoxPasswordEyeIcon.Click += pictureBoxPasswordEyeIcon_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordEyeIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBoxPasswordEyeIcon;
    }
}
