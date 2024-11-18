using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZBANK
{
    public class ConnectDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=quizbank";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static int getMaxID()
        {
            int maxID = 0;
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(`Question_id`) AS maxID FROM `tbl_questions`", conn);
                    object result = cmd.ExecuteScalar();

                    maxID = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return maxID;
        }

        public static void saveUpdateDeleteData(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        cmd.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        string key = "@command";

                        if (parameters.ContainsKey(key))
                        {
                            object value = parameters[key];
                            displayInsertUpdateDelete(value); // Use correct method name
                        }

                        // Close the connection
                        conn.Close();
                    }
                }
            }
        }

        public static void displayData(DataGridView dataGridView)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM personal_info", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void displayInsertUpdateDelete(object value)
        {
            if (value is string command)
            {
                string message = null;

                // StringComparison.OrdinalIgnoreCase will execute for "insert", "INSERT", "Insert", etc.
                if (command.Equals("insert", StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Inserted!";
                }
                else if (command.Equals("update", StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Updated!";
                }
                else if (command.Equals("delete", StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Deleted!";
                }

                if (message != null)
                {
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static DataTable GetData(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        da.SelectCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
