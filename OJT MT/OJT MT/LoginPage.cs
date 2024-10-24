using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace OJT_MT
{

    public partial class LoginPage : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper("localhost", "root", "", "ojt");
        private MainForm mainForm;
        public LoginPage(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        //Login Button Click
        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text; //Get username (email)
            string password = textBoxPassword.Text; //Get password
            var userInfo = await ValidateUserAsync(username, password); //Retrieve userid and account type if login details match
            if (userInfo.HasValue)
            {
                string accountType = userInfo.Value.Item1; // Get account type
                string userId = userInfo.Value.Item2; // Get user ID
                mainForm.LoginUser(accountType, userId);
                return;
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private async Task<(string, string)?> ValidateUserAsync(string username, string password)
        {
            string query = "SELECT user_id, account_type FROM users WHERE user_email=@username AND password=@password";

            var parameters = new[]
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password)
            };
            using var reader = await dbHelper.ExecuteReaderAsync(query, parameters);


            if (reader.Read())
            {
                string accountType = reader["account_type"].ToString();
                string userId = reader["user_id"].ToString();
                return (accountType, userId);
            }
            else           

            return null; //Return null if no valid result is found
        }
    }
}
