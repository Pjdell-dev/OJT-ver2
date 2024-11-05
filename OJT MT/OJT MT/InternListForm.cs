using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{
    public partial class InternListForm : Form
    {
        private MainForm mainForm;
        private string _accountId;
        public InternListForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _accountId = mainForm.accountID;            
        }

        private async void InternListForm_Load(object sender, EventArgs e)
        {
            await LoadInternList(_accountId); //On Form load, load yung internlist for the signed in supervisor
        }

        private async Task LoadInternList(string userID)
        {            
            try
            {
                //Load Intern List into Datagridview
                using var dbHelper = new DatabaseHelper();
                string query = @"
                SELECT 
                    s.student_id AS 'Student Number',
                    s.first_name AS 'First Name',
                    s.last_name AS 'Last Name'
                FROM 
                    students s
                WHERE 
                    s.supervisor_id = (
                        SELECT supervisor_id 
                        FROM supervisors 
                        WHERE user_id = @UserID
                    );";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@UserID", userID));

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;

                //Add Button To datagridview (View time log)
                DataGridViewButtonColumn timeLogButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Time Log",
                    Text = "View", // Button text
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(timeLogButtonColumn); //Add column (button) to datagrid

                //Add Button To datagridview (View Accomplishment Reports)
                DataGridViewButtonColumn accRepButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Accomplishment Reports",
                    Text = "View", //Button text
                    UseColumnTextForButtonValue = true //Make text as button text
                };
                dataGridView1.Columns.Add(accRepButtonColumn); //Add column (button) to datagrid
                timeLogButtonColumn.Width = 100;
                accRepButtonColumn.Width = 150;
            }
            catch (Exception ex)
            {

            }
        }

        //Add margin to buttons
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                cell.Style.Padding = new Padding(20, 10, 20, 10);

            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var columnName = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            var studentNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Student Number"].Value);

            switch (columnName)
            {
                case "Time Log": //Time Log button function
                    await ShowTimeLogs(studentNumber);
                    break;

                case "Accomplishment Reports": //accomplishment reports button function
                    MessageBox.Show("NICE");
                    break;
            }
        }

        private async Task ShowTimeLogs(int studentNumber)
        {
            var timeLogs = new TimeLogsForm(mainForm);
            mainForm.LoadForm(timeLogs);
            await timeLogs.DisplayLogs(studentNumber);
        }

        
    }
}
