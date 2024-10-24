namespace OjtCoordinator
{
    partial class admin
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
            label1 = new Label();
            lvUsers = new ListView();
            lvID = new ColumnHeader();
            lvLastName = new ColumnHeader();
            lvAccountType = new ColumnHeader();
            tbFilter = new TextBox();
            label2 = new Label();
            btnRemove = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Manage Accounts";
            // 
            // lvUsers
            // 
            lvUsers.BackColor = SystemColors.Window;
            lvUsers.Columns.AddRange(new ColumnHeader[] { lvID, lvLastName, lvAccountType });
            lvUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvUsers.GridLines = true;
            lvUsers.Location = new Point(122, 153);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(597, 284);
            lvUsers.TabIndex = 1;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.SelectedIndexChanged += lvUsers_SelectedIndexChanged;
            // 
            // lvID
            // 
            lvID.Text = "ID#";
            lvID.Width = 100;
            // 
            // lvLastName
            // 
            lvLastName.Text = "Last Name";
            lvLastName.TextAlign = HorizontalAlignment.Center;
            lvLastName.Width = 150;
            // 
            // lvAccountType
            // 
            lvAccountType.Text = "Account Type";
            lvAccountType.TextAlign = HorizontalAlignment.Center;
            lvAccountType.Width = 150;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(208, 113);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(100, 23);
            tbFilter.TabIndex = 2;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(139, 114);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 3;
            label2.Text = "Filter by:";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(632, 113);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 33);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(527, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(831, 460);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(tbFilter);
            Controls.Add(lvUsers);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(44, 95, 52);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvUsers;
        private ColumnHeader lvID;
        private ColumnHeader lvLastName;
        private ColumnHeader lvAccountType;
        private TextBox tbFilter;
        private Label label2;
        private Button btnRemove;
        private Button btnUpdate;
    }
}
