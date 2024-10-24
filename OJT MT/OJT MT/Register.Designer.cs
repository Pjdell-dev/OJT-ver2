namespace OJT_MT
{
    partial class Register
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            buttonAddAccount = new Button();
            panel3 = new Panel();
            textBoxEmail = new TextBox();
            textBoxID = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(44, 95, 52);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(790, 459);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(228, 230, 228);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(121, 94);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 77.23577F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.7642269F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(547, 315);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            tableLayoutPanel2.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(buttonAddAccount);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 66);
            panel2.TabIndex = 1;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Anchor = AnchorStyles.Bottom;
            buttonAddAccount.AutoSize = true;
            buttonAddAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddAccount.Location = new Point(208, 17);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(87, 25);
            buttonAddAccount.TabIndex = 0;
            buttonAddAccount.Text = "Add Account";
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxEmail);
            panel3.Controls.Add(textBoxID);
            panel3.Controls.Add(textBoxFirstName);
            panel3.Controls.Add(textBoxLastName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 237);
            panel3.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Right;
            textBoxEmail.Location = new Point(81, 111);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Enter Email Address";
            textBoxEmail.Size = new Size(129, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Right;
            textBoxID.Location = new Point(81, 144);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "Enter ID#";
            textBoxID.Size = new Size(129, 23);
            textBoxID.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Right;
            textBoxFirstName.Location = new Point(81, 53);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Enter First Name";
            textBoxFirstName.Size = new Size(129, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Right;
            textBoxLastName.Location = new Point(81, 82);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Enter Last Name";
            textBoxLastName.Size = new Size(129, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(276, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 237);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student/Intern", "Supervisor" });
            comboBox1.Location = new Point(59, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(121, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 91);
            label1.TabIndex = 2;
            label1.Text = "Register Accounts";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 459);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAddAccount;
        private TextBox textBoxFirstName;
        private ComboBox comboBox1;
        private TextBox textBoxID;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
    }
}