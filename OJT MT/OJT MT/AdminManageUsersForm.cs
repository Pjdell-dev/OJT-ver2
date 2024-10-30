using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OJT_MT
{
    public partial class AdminManageUsersForm : Form
    {
        bool manageUsersPanelExpand = false;
        private MainForm _mainForm;
        private int currentUserId = -1;
        private string currentUserAccountType;
        private DataTable userTable;
        public AdminManageUsersForm(MainForm mainForm)
        {
            DoubleBuffered = true;
            this._mainForm = mainForm;
            InitializeComponent();
            comboBoxFilter.SelectedIndex = 0; //Para default value na yung --select--
            _ = LoadUsers();
        }
        private async Task LoadUsers()
        {
            using var dbHelper = new DatabaseHelper();
            string query = @"SELECT 
                                student_id AS 'ID', 
                                CONCAT(first_name, ' ', last_name) AS 'Full Name', 
                                'Student' AS 'Account Type'
                            FROM 
                                students

                            UNION ALL

                            SELECT 
                                supervisor_id AS 'ID', 
                                CONCAT(first_name, ' ', last_name) AS 'Full Name', 
                                'Supervisor' AS 'Account Type'
                            FROM 
                                supervisors
                            ORDER BY 
                                'Full Name';";


            using var reader = await dbHelper.ExecuteReaderAsync(query);
            if (reader.Read())
            {
                userTable = new DataTable();
                userTable.Load(reader);
                dataGridViewUsers.DataSource = userTable;
            }


        }

        //filtering by, hinahiglight yung intended item
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbFilter.Text.Trim();
            string selectedColumn = comboBoxFilter.SelectedItem.ToString(); //Get yung value ng combobox para alam kung ano ffilter
            if (selectedColumn == "-- Select --" || string.IsNullOrEmpty(filterText))
            {
                userTable.DefaultView.RowFilter = string.Empty;
                return;
            }
            switch (selectedColumn)  //switch kung incase dadagdag pa tayo filter types
            {
                case "Name":
                    userTable.DefaultView.RowFilter = $"[Full Name] LIKE '%{filterText}%'";
                    break;
                case "ID Number":
                    userTable.DefaultView.RowFilter = $"CONVERT(ID, System.String) LIKE '{filterText}%'";
                    userTable.DefaultView.Sort = "ID ASC";
                    break;
            }
        }

        private async void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                currentUserId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                currentUserAccountType = selectedRow.Cells["Account Type"].Value.ToString();
                Debug.WriteLine("User ID:" + currentUserId);
                Debug.WriteLine("Account Type: " + currentUserAccountType);
                await LoadUserInfo(currentUserId, currentUserAccountType);
            }
        }

        private async Task LoadUserInfo(int userID, string accountType)
        {
            using var dbHelper = new DatabaseHelper();
            Debug.WriteLine(accountType);
            try
            {
                if (accountType == "Student")
                {
                    string query = @"SELECT student_id, first_name, last_name, contact_number, supervisor_id FROM students WHERE student_id = @user_id;";

                    using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", userID));
                    if (reader.Read())
                    {
                        textBoxID.Text = reader["student_id"]?.ToString() ?? string.Empty;
                        textBoxFirstName.Text = reader["first_name"]?.ToString() ?? string.Empty;
                        textBoxLastName.Text = reader["last_name"]?.ToString() ?? string.Empty;
                        textBoxContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                        comboBoxSupervisorID.Text = reader["supervisor_id"]?.ToString() ?? string.Empty;
                        panelSupervisorID.Show();
                    }
                    else
                    {
                        Debug.WriteLine("No student found with the given user ID.");
                    }
                }
                else if (accountType == "Supervisor")
                {
                    string query = @"SELECT supervisor_id, first_name, last_name, contact_number FROM supervisors WHERE supervisor_id = @user_id;";

                    using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", userID));
                    if (reader.Read())
                    {
                        textBoxID.Text = reader["supervisor_id"]?.ToString() ?? string.Empty;
                        textBoxFirstName.Text = reader["first_name"]?.ToString() ?? string.Empty;
                        textBoxLastName.Text = reader["last_name"]?.ToString() ?? string.Empty;
                        textBoxContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                        panelSupervisorID.Hide();
                    }
                    else
                    {
                        Debug.WriteLine("No student found with the given user ID.");
                    }
                }
                else
                {
                    Debug.WriteLine("Invalid account type");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"error: {ex.Message}");
            }
        }

        private void manageUsersPanelTimer_Tick(object sender, EventArgs e)
        {
            if (manageUsersPanelExpand)
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width -= 50F;
                panelUpdateWindow.Width -= 50;
                if (tableLayoutPanelManageAccounts.ColumnStyles[1].Width <= 10F)
                {
                    manageUsersPanelExpand = false;
                    manageUsersPanelTimer.Stop();
                }
            }
            else
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width += 50F;
                if (tableLayoutPanelManageAccounts.ColumnStyles[1].Width >= 390F)
                {
                    manageUsersPanelExpand = true;
                    manageUsersPanelTimer.Stop();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            manageUsersPanelTimer.Start();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            int newId = Convert.ToInt32(textBoxID.Text);
            string newFirstName = textBoxFirstName.Text;
            string newLastName = textBoxLastName.Text;
            string newContactNumber = textBoxContactNumber.Text;
            int newSupervisorId = Convert.ToInt32(comboBoxSupervisorID.Text);
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query;
                var parameters = new List<MySqlParameter>();
                if (currentUserAccountType == "Student")
                {

                    query = @"UPDATE 
                                        students 
                                    SET 
                                        student_id = @newStudentId,
                                        first_name = @newFirstName,
                                        last_name = @newLastName,
                                        contact_number = @newContactNumber,
                                        supervisor_id = @newSupervisorId
                                    WHERE
                                        student_id = @oldId;";

                    parameters.AddRange(new[]
                    {
                        new MySqlParameter("@newStudentId", newId),
                        new MySqlParameter("@newFirstName", newFirstName),
                        new MySqlParameter("@newLastName", newLastName),
                        new MySqlParameter("@newContactNumber", newContactNumber),
                        new MySqlParameter("@newSupervisorId", newSupervisorId),
                        new MySqlParameter("@oldId", currentUserId)
                    });

                }
                else if (currentUserAccountType == "Supervisor")
                {
                    query = @"UPDATE 
                                        supervisors 
                                    SET 
                                        supervisor_id = @newSupervisorId,
                                        first_name = @newFirstName,
                                        last_name = @newLastName,
                                        contact_number = @newContactNumber
                                    WHERE
                                        supervisor_id = @oldId;";

                    parameters.AddRange(new[]
                    {
                        new MySqlParameter("@newSupervisorId", newId),
                        new MySqlParameter("@newFirstName", newFirstName),
                        new MySqlParameter("@newLastName", newLastName),
                        new MySqlParameter("@newContactNumber", newContactNumber),
                        new MySqlParameter("@oldId", currentUserId)
                    });
                }
                else
                {
                    return;
                }

                int rowsAffected = await dbHelper.ExecuteNonQueryAsync(query, parameters.ToArray());

                if (rowsAffected > 0)
                {
                    labelSuccessMessage.Text = "User information updated successfully";
                    labelSuccessMessage.Show();
                    labelErrorMessage.Hide();
                    Console.WriteLine("User information updated successfully");
                    await LoadUsers();
                }
                else
                {
                    labelErrorMessage.Text = "Update failed";
                    labelSuccessMessage.Hide();
                    labelErrorMessage.Show();
                    Console.WriteLine("Update failed");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                labelErrorMessage.Text = "Update failed, make sure all information are valid";
                labelSuccessMessage.Hide();
                labelErrorMessage.Show();
                Console.WriteLine("Update failed");
            }



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //pigilan if di control type or numbers
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Doing this will also delete related records, do you still want to continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Check the result
            if (result == DialogResult.Yes)
            {
                try
                {
                    using var dbHelper = new DatabaseHelper();
                    string query;
                    if (currentUserAccountType == "Student")
                    {
                        query = @"DELETE FROM students WHERE student_id = @currentId";
                    }
                    else if (currentUserAccountType == "Supervisor")
                    {
                        query = @"DELETE FROM supervisors WHERE supervisor_id = @currentId";
                    }
                    else
                    {
                        return;
                    }
                    int rowsAffected = await dbHelper.ExecuteNonQueryAsync(query, new MySqlParameter("@currentId", currentUserId));
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        await LoadUsers();
                    }
                    else
                    {
                        
                    }

                }
                catch
                {

                }
            }
        }
    }
}
