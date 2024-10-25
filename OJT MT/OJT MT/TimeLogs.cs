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
    public partial class TimeLogs : Form
    {
        private MainForm mainForm;
        public TimeLogs(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public async void DisplayLogs(int student_number)
        {
            var dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");

            string query = $"SELECT date as 'Date', time_in as 'Time In', time_out as 'Time Out', status as 'Remarks' FROM time_logs WHERE student_number ={student_number};";
            using var reader = await dbHelper.ExecuteReaderAsync(query);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            //Get contact number and student number
            query = $"SELECT first_name, last_name, student_number, contact_number FROM students WHERE student_number ={student_number};";
            using var reader2 = await dbHelper.ExecuteReaderAsync(query);
            if (await reader2.ReadAsync())
            {
                labelStudentID.Text = reader2["student_number"].ToString();
                labelContactNumber.Text = reader2["contact_number"].ToString();
                labelName.Text = reader2["first_name"].ToString() + " " +  reader2["last_name"].ToString();
            }

        }
        
    }
}
