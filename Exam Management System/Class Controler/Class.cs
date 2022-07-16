
using ComponentFactory.Krypton.Toolkit;
using Exam_Management_System.DataConnections;
using Exam_Management_System.MessageControlers;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Exam_Management_System.Class_Controler
{

    /// <summary>
    /// Provides All Operation To Perform Classes
    /// </summary>
    internal class Class
    {
        public static SqlConnection connect;
        public static Connections connections = new Connections();
        public static void GetClassData(Guna2DataGridView data)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("ReadClassData", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            data.DataSource = table;
            cmd.ExecuteNonQuery();
            connect.Close();
        }


        public static void ReadClassNames(KryptonComboBox displayer)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("ReadClassNames", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader adapter = cmd.ExecuteReader();
            while (adapter.Read())
            {
                if (adapter.HasRows)
                    displayer.Items.Add(adapter[0]);


            }
            connect.Close();
        }
        public static void AddClass(int id, string name)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand command = new SqlCommand("AddClass", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();

            connect.Close();

        }


        public static void AddClass(Guna2DataGridView excelData)
        {
            for (int i = 0; i < excelData.Rows.Count; i++)
            {
                int id = Convert.ToInt32(excelData.Rows[i].Cells[0].Value);
                AddClass(id, excelData.Rows[i].Cells[1].Value.ToString());
            }
        }


        public static void UpdateClass(int id, string name, int updateID)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateClass", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@updateID", updateID);
            command.ExecuteNonQuery();

            connect.Close();
            Messages.Show.Info("Sucessfully Updated...", "Commits");
        }


        public static void DeleteClass(int id)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand command = new SqlCommand("DeleteClass", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            connect.Close();
            Messages.Show.Info("Sucessfully Deleted...", "Commits");
        }



    }
}
