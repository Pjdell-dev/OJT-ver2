﻿namespace OJT_MT
{
    partial class TimeLogs
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
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            labelContactNumber = new Label();
            labelStudentID = new Label();
            labelContactNumberIndicator = new Label();
            labelStudentIDIndicator = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(103, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(594, 282);
            dataGridView1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.FromArgb(44, 95, 52);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 2, 0);
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(100, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(600, 120);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(370, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 108);
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
            panel2.Size = new Size(220, 108);
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
            // TimeLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimeLogs";
            Text = "TimeLogs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Panel panel2;
        private Label labelContactNumber;
        private Label labelStudentID;
        private Label labelContactNumberIndicator;
        private Label labelStudentIDIndicator;
        private Label labelName;
        private PictureBox pictureBox1;
    }
}