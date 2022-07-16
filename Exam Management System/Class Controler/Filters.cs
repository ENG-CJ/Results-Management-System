using Exam_Management_System.DataConnections;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace Exam_Management_System.Class_Controler
{
    internal class Filters
    {
        public static bool HasRows { get; private set; }
        public static Connections con = new Connections();
        public static SqlConnection connection;
        /// <summary>
        /// Searches Range From Class To Class
        /// </summary>
        public static void SearchRange()
        {

        }

        /// <summary>
        /// Searches One Class By Name
        /// </summary>
        public static void SearchClass(string name, Guna2DataGridView data)
        {
            connection = con.GetSqlConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SearchClass", connection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@name", name);
            SqlDataAdapter reader = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            reader.Fill(table);
            if (table.Rows.Count > 0)
            {
                data.DataSource = table;
                HasRows = true;
            }
            else
                HasRows = false;

            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Show up Top Number
        /// </summary>
        public static void ShowUp(int topNumber, Guna2DataGridView data)
        {
            connection = con.GetSqlConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("ShowFilter", connection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@number", topNumber);
            SqlDataAdapter reader = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            reader.Fill(table);

            data.DataSource = table;



            sqlCommand.ExecuteNonQuery();
            connection.Close();

        }

        /// <summary>
        /// Removes All Class Data
        /// </summary>
        public static void DropAll()
        {
            connection = con.GetSqlConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DropAll", connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
