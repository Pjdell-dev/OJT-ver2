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
        }

        protected override async void OnLoad(EventArgs e)
        {
            LoadInternList();
        }
        private async void LoadInternList()
        {
            //Load Intern List into Datagridview
            var dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");

            string query = "SELECT student_number, last_name as 'Last Name', first_name as \"First Name\"FROM students";
            using var reader = await dbHelper.ExecuteReaderAsync(query);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["student_number"].Visible = false; //Hide Student ID
            //Add Button To datagridview (View time log)
            DataGridViewButtonColumn timeLogColumn = new DataGridViewButtonColumn();
            timeLogColumn.HeaderText = "Time Log";
            timeLogColumn.Text = "View"; // Button text
            timeLogColumn.UseColumnTextForButtonValue = true; // Makes all buttons display this text

            dataGridView1.Columns.Add(timeLogColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columnName = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            //if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns.Count - 1) // Check if button column
            if (e.RowIndex >= 0 && columnName == "Time Log")
            {
                // Get student number
                var student_number = dataGridView1.Rows[e.RowIndex].Cells["student_number"].Value;

                //Show timelogs for the student
                TimeLogs timeLogs = new TimeLogs(mainForm);
                mainForm.LoadForm(timeLogs);
                timeLogs.DisplayLogs(Convert.ToInt32(student_number));
            }
        }

    }
}
