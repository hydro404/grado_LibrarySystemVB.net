using System;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CollegeInformationSystem
{
    internal class DatabaseConnection
    {
        private readonly string host;
        private readonly string user;
        private readonly string password;
        private readonly string database;
        private readonly MySqlConnection connection;

        public DatabaseConnection()
        {
            // Assign constant values to host, user, password, and database
            host = "127.0.0.1";
            user = "root";
            password = "@Hydrogn10";
            database = "college";

            // Construct the connection string using the constant values
            string connectionString = $"Server={host};Database={database};User ID={user};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public void InsertData(string tableName, string[] columnNames, string[] values)
        {
            try
            {
                Open();
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (columnNames[i].ToLower() == "password")
                    {
                        values[i] = HashPassword(values[i]);
                    }
                }
                // Construct the SQL command for insertion
                string columns = string.Join(", ", columnNames);
                string placeholders = string.Join(", ", values.Select(_ => "?"));
                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders})";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    for (int i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@param{i + 1}", values[i]);
                    }

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email already exists. Please try again.");
            }
            finally
            {
                Close();
            }
        }

        public bool CheckLoginCredentials(string email, string password)
        {
            bool isAuthenticated = false;

            try
            {
                Open();

                // Hash the provided password
                string hashedPassword = HashPassword(password);

                // Construct the SQL command for checking login credentials
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    // Execute the query
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // If there is a matching user, set isAuthenticated to true
                    isAuthenticated = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking login credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return isAuthenticated;
        }
    }
}