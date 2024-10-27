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
    public partial class AccountSettingsOLD : Form
    {
        MainForm mainForm;
        private string _userID;
        private string _accountType;
        public AccountSettingsOLD(MainForm mainForm, string userID, string accountType)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _userID = userID;
            _accountType = accountType;
            LoadAccountDetails();
            OurCustomUtils.CreatePasswordEye(textBoxNewPassword);
            OurCustomUtils.CreatePasswordEye(textBoxOldPassword);
        }

        private async void LoadAccountDetails()
        {
            var dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");
            string query = null;
            switch(_accountType){
                case "student":
                    query = @"SELECT student_number AS idNumber, last_name, first_name, contact_number FROM students WHERE user_id = @user_id";
                    break;
                case "supervisor":
                    query = @"
                            SELECT 
                                s.supervisor_id AS idNumber,
                                s.last_name, s.first_name,
                                s.contact_number, 
                                u.user_email
                            FROM 
                                supervisors s
                            JOIN 
                                users u ON s.user_id = u.user_id
                            WHERE
                                s.user_id = @user_id";
                    break;
            }
            using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", _userID));
            if (reader.Read())
            {
                labelAccountType.Text = char.ToUpper(_accountType[0]) + _accountType[1..];
                labelIDNumber.Text = reader["idNumber"].ToString();
                labelName.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                labelContactNumber.Text = reader["contact_number"].ToString();
                labelEmail.Text = reader["user_email"].ToString();
            }
        }
    }
}
