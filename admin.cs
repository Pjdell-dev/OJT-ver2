using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OjtCoordinator
{
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data.Common;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class admin : Form
    {
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "ojt(1)";

        MySqlConnection dbConn = new MySqlConnection(
            "server=" + server + ";" +
            "port=" + port + ";" +
            "username=" + username + ";" +
            "password=" + password + ";" +
            "database=" + database + ";");
        private object lvRows;

        public admin()
        {
            InitializeComponent();
          
    }
        private List<ListViewItem> originalItems = new List<ListViewItem>(); //pangtemporary placeholder ng items for filtering
        private void Form1_Load(object sender, EventArgs e)
        {
            dbConn.Open();
            string dbQuery = "SELECT users.user_id, students.last_name AS students_lastname, supervisors.last_name AS supervisors_lastname, users.account_type  FROM users LEFT JOIN students ON users.user_id = students.user_id  LEFT JOIN supervisors ON users.user_id = supervisors.user_id ";
           // string dbQuery = "SELECT user_id, last_name, account_type FROM `users` ";
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn);

            MySqlDataReader dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {;
               
                ListViewItem lvRows = new ListViewItem(dbReader.GetInt32("user_id").ToString(), 0);
                // lvRows.SubItems.Add(dbReader.GetString("last_name"));
                string combinedLastNames = $"{dbReader["students_lastname"].ToString()}  {dbReader["supervisors_lastname"].ToString()}";
                lvRows.SubItems.Add(combinedLastNames);
                lvRows.SubItems.Add(dbReader.GetString("account_type"));

                lvUsers.Items.Add(lvRows);
                originalItems.Add((ListViewItem)lvRows.Clone());//lagay yung lvRows sa originalItems
            }
            dbReader.Close();
            dbConn.Close();

        }
        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //filtering by, hinahiglight yung intended item
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbFilter.Text.ToLower(); 
            lvUsers.Items.Clear();

            foreach (ListViewItem item in originalItems)
            {       
                if (item.Text.ToLower().Contains(filterText) || item.SubItems[1].Text.ToLower().Contains(filterText) || item.SubItems[2].Text.ToLower().Contains(filterText)) 
                {
                    item.BackColor = SystemColors.GrayText;
                    item.ForeColor = SystemColors.Window;
                    lvUsers.Items.Add((ListViewItem)item.Clone());//need para mashow yung filtered item sa listview
                }
                else
                {
                    item.BackColor = SystemColors.Control;
                }
            }
        }
    }
}
