using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{
    public partial class SupervisorARPage : Form
    {
        private MainForm mainForm;
        public SupervisorARPage(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadAccomplishmentReports();
        }

        public async void LoadAccomplishmentReports()
        {
            //Load Intern List into Datagridview
            var dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");
            string query = @"WITH LatestReports AS (
                    SELECT 
                        student_number, 
                        MAX(report_date) AS latest_report_date
                    FROM 
                        accomplishment_reports
                    GROUP BY 
                        student_number
                )
                SELECT 
                s.student_number,
                s.first_name as 'Last Name',
                s.last_name as 'First Name',
                ar.submission_status as 'Status'
                FROM 
                    students s
                LEFT JOIN 
                    LatestReports lr ON s.student_number = lr.student_number
                LEFT JOIN 
                accomplishment_reports ar ON lr.student_number = ar.student_number AND lr.latest_report_date = ar.report_date;";
            using var reader = await dbHelper.ExecuteReaderAsync(query);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["student_number"].Visible = false; //Hide Student ID
            //Add Button To datagridview (View accomplishment report)
            DataGridViewButtonColumn arColumn = new DataGridViewButtonColumn();
            arColumn.HeaderText = "Accomplishment Report";
            arColumn.Text = "View"; // Button text
            arColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(2, arColumn);
            //Add button to datagridview (evaluate)
            DataGridViewButtonColumn feedbackColumn = new DataGridViewButtonColumn();
            feedbackColumn.HeaderText = "Feedback";
            feedbackColumn.Text = "Evaluate"; // Button text
            feedbackColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(feedbackColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columnName = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            // Check if button column
            if (e.RowIndex >= 0 && columnName == "Accomplishment Report")
            {
                MessageBox.Show("AR");
            }
            else if (e.RowIndex >= 0 && columnName == "Feedback")
            {
                StudentEvaluationForm studentEvaluationForm = new StudentEvaluationForm(mainForm);
                mainForm.LoadForm(studentEvaluationForm);
            }
        }


    }
}
