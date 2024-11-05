namespace OJT_MT
{
    partial class LoginPageForm
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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Bottom;
            buttonLogin.BackColor = Color.FromArgb(21, 115, 74);
            buttonLogin.FlatAppearance.BorderColor = Color.Black;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.FromArgb(244, 244, 239);
            buttonLogin.Location = new Point(403, 768);
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
            textBoxUser.BackColor = Color.FromArgb(254, 255, 250);
            textBoxUser.Font = new Font("Roboto", 9F);
            textBoxUser.Location = new Point(327, 678);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Enter Email";
            textBoxUser.Size = new Size(227, 22);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom;
            textBoxPassword.BackColor = Color.FromArgb(254, 255, 250);
            textBoxPassword.Font = new Font("Roboto", 9F);
            textBoxPassword.Location = new Point(327, 718);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter Password";
            textBoxPassword.Size = new Size(227, 22);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(12, 64, 41);
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
            tableLayoutPanel1.Size = new Size(1000, 1000);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 255, 250);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(60, 60);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 880);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.ojt_2_logo;
            pictureBox1.Location = new Point(240, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 1000);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
