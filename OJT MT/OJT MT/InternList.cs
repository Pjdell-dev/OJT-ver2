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
    public partial class InternList : Form
    {
        private MainForm mainForm;
        public InternList(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadInternList(mainForm.accountID);
        }
        private async void LoadInternList(string userID)
        {
            //Load Intern List into Datagridview
            var dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");
            string query = @"
                SELECT 
                    s.student_number AS 'Student Number',
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
            DataGridViewButtonColumn timeLogButtonColumn = new DataGridViewButtonColumn();
            timeLogButtonColumn.HeaderText = "Time Log";
            timeLogButtonColumn.Text = "View"; // Button text
            timeLogButtonColumn.UseColumnTextForButtonValue = true; //Make text as button text
            dataGridView1.Columns.Add(timeLogButtonColumn); //Add column (button) to datagrid

            //Add Button To datagridview (View Accomplishment Reports)
            DataGridViewButtonColumn accRepButtonColumn = new DataGridViewButtonColumn();
            accRepButtonColumn.HeaderText = "Accomplishment Reports";
            accRepButtonColumn.Text = "View"; // Button text
            accRepButtonColumn.UseColumnTextForButtonValue = true; //Make text as button text
            dataGridView1.Columns.Add(accRepButtonColumn); //Add column (button) to datagrid
            timeLogButtonColumn.Width = 100;
            accRepButtonColumn.Width = 150;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String columnName = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (columnName == "Time Log")
            {
                // Get student number
                var student_number = dataGridView1.Rows[e.RowIndex].Cells["Student Number"].Value;

                //Show timelogs for the student
                TimeLogs timeLogs = new TimeLogs(mainForm);
                mainForm.LoadForm(timeLogs);
                timeLogs.DisplayLogs(Convert.ToInt32(student_number));
            }
            if (columnName == "Accomplishment Reports")
            {
                MessageBox.Show("NICE");
            }
        }
    }
}
