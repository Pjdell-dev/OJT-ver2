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

        public async Task DisplayLogs(int studentID)
        {
            using var dbHelper = new DatabaseHelper();

            string query = "SELECT date AS 'Date', time_in AS 'Time In', time_out AS 'Time Out', status AS 'Remarks' FROM time_logs WHERE student_id = @student_id;";
            using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", studentID));
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            //Get contact number and student number
            query = "SELECT first_name, last_name, student_id, contact_number FROM students WHERE student_id = @student_id;";
            using var reader2 = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", studentID));
            if (await reader2.ReadAsync())
            {
                labelStudentID.Text = reader2["student_id"].ToString();
                labelContactNumber.Text = reader2["contact_number"].ToString();
                labelName.Text = reader2["first_name"].ToString() + " " +  reader2["last_name"].ToString();
            }

        }
        
    }
}
