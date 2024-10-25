namespace OJT_MT
{
    partial class StudentEvalForm
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
            panel3 = new Panel();
            panel2 = new Panel();
            labelContactNumber = new Label();
            labelStudentID = new Label();
            labelContactNumberIndicator = new Label();
            labelStudentIDIndicator = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanelQuestions = new TableLayoutPanel();
            buttonSubmit = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(44, 95, 52);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelQuestions, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonSubmit, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(941, 601);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 2, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(100, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(741, 120);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(440, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 108);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelContactNumber);
            panel2.Controls.Add(labelStudentID);
            panel2.Controls.Add(labelContactNumberIndicator);
            panel2.Controls.Add(labelStudentIDIndicator);
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(130, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 108);
            panel2.TabIndex = 0;
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Roboto Cn", 9F);
            labelContactNumber.ForeColor = SystemColors.ButtonFace;
            labelContactNumber.Location = new Point(85, 63);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(62, 14);
            labelContactNumber.TabIndex = 4;
            labelContactNumber.Text = "placeholder";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Roboto Cn", 9F);
            labelStudentID.ForeColor = SystemColors.ButtonFace;
            labelStudentID.Location = new Point(85, 44);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(62, 14);
            labelStudentID.TabIndex = 3;
            labelStudentID.Text = "placeholder";
            // 
            // labelContactNumberIndicator
            // 
            labelContactNumberIndicator.AutoSize = true;
            labelContactNumberIndicator.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNumberIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelContactNumberIndicator.Location = new Point(3, 63);
            labelContactNumberIndicator.Name = "labelContactNumberIndicator";
            labelContactNumberIndicator.Size = new Size(76, 15);
            labelContactNumberIndicator.TabIndex = 2;
            labelContactNumberIndicator.Text = "Contact No.:";
            // 
            // labelStudentIDIndicator
            // 
            labelStudentIDIndicator.AutoSize = true;
            labelStudentIDIndicator.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentIDIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelStudentIDIndicator.Location = new Point(9, 44);
            labelStudentIDIndicator.Name = "labelStudentIDIndicator";
            labelStudentIDIndicator.Size = new Size(70, 15);
            labelStudentIDIndicator.TabIndex = 1;
            labelStudentIDIndicator.Text = "Student ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Roboto Cn", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(3, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(86, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aku;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanelQuestions
            // 
            tableLayoutPanelQuestions.AutoScroll = true;
            tableLayoutPanelQuestions.AutoSize = true;
            tableLayoutPanelQuestions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelQuestions.BackColor = Color.FromArgb(228, 230, 228);
            tableLayoutPanelQuestions.ColumnCount = 2;
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.Dock = DockStyle.Fill;
            tableLayoutPanelQuestions.Location = new Point(110, 130);
            tableLayoutPanelQuestions.Margin = new Padding(10);
            tableLayoutPanelQuestions.Name = "tableLayoutPanelQuestions";
            tableLayoutPanelQuestions.RowCount = 2;
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle());
            tableLayoutPanelQuestions.Size = new Size(721, 400);
            tableLayoutPanelQuestions.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSubmit.Location = new Point(746, 560);
            buttonSubmit.Margin = new Padding(20);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 21);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // StudentEvalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 601);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentEvalForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel2;
        private Label labelContactNumberIndicator;
        private Label labelStudentIDIndicator;
        private Label labelName;
        private TableLayoutPanel tableLayoutPanelQuestions;
        private Label labelStudentID;
        private Label labelContactNumber;
        private PictureBox pictureBox1;
        private Button buttonSubmit;
    }
}