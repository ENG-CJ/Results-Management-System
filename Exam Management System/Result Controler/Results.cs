
using Exam_Management_System.DataConnections;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
namespace Exam_Management_System.Result_Controler
{
    internal class Results
    {
        #region Properties
        public static bool HasError { get; set; }

        #endregion
        public static SqlConnection connection;


        public static bool IsContainsDotSymbol(string traget)
        {
            return traget.Contains(".");
        }


        /// <summary>
        /// Gets Grade From The Average 
        /// </summary>
        /// <param name="avg">Average Number To Calculate The Grade</param>
        /// <returns></returns>
        public static char GetGrade(double avg)
        {
            char grade;
            if (avg >= 90 && avg <= 100)
                grade = 'A';
            else if (avg >= 80 && avg <= 89)
                grade = 'B';
            else if (avg >= 70 && avg <= 79)
                grade = 'C';
            else if (avg >= 60 && avg <= 69)
                grade = 'D';
            else if (avg >= 50 && avg <= 59)
                grade = 'E';
            else
                grade = 'F';
            return grade;

        }

        /// <summary>
        /// Calculates The Subjects and Returns the total 
        /// </summary>
        /// <param name="sub1"></param>
        /// <param name="sub2"></param>
        /// <param name="sub3"></param>
        /// <param name="sub4"></param>
        /// <param name="sub5"></param>
        /// <param name="sub6"></param>
        /// <returns></returns>
        public static float GetTotal(float sub1, float sub2, float sub3, float sub4, float sub5, float sub6)
        {
            return sub1 + sub2 + sub3 + sub4 + sub5 + sub6;
        }

        /// <summary>
        /// Gets The Average From The Total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetAverage(float total)
        {
            return total / 6;
        }

        public static bool CheckTheValues(double sub1, double sub2, double sub3, double sub4, double sub5, double sub6)
        {
            bool IsValid;
            if ((sub1 >= 0 && sub1 <= 100) && (sub2 >= 0 && sub2 <= 100) && (sub3 >= 0 && sub3 <= 100)
                && (sub4 >= 0 && sub4 <= 100) && (sub5 >= 0 && sub5 <= 100) && (sub6 >= 0 && sub6 <= 100))
                IsValid = true;
            else
                IsValid = false;
            return IsValid;
        }

        public static void ReadStudentsID(Guna2ComboBox idDisplayer)
        {
            Connections cn = new Connections();
            connection = cn.GetSqlConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("ReadStudentID", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                idDisplayer.Items.Add(reader[0].ToString());
            connection.Close();
        }


        // databases
        public static void SearchStudentData(string id, Guna2TextBox name, Guna2TextBox stdclass, Guna2TextBox semes)
        {
            Connections cn = new Connections();
            connection = cn.GetSqlConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("ReadStudentData", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader[0].ToString();
                stdclass.Text = reader[1].ToString();
                semes.Text = reader[2].ToString();
            }
            connection.Close();

        }

        public static void AddResult(
                string id, string name, string clas, string semes, float csharp, float java,
                float php, float python, float sql, float mysql, float total, string avg, char grade
            )
        {
            try
            {
                Connections cn = new Connections();
                connection = cn.GetSqlConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddResult", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@class", clas);
                cmd.Parameters.AddWithValue("@semes", semes);
                cmd.Parameters.AddWithValue("@csharp", csharp);
                cmd.Parameters.AddWithValue("@java", java);
                cmd.Parameters.AddWithValue("@php", php);
                cmd.Parameters.AddWithValue("@python", python);
                cmd.Parameters.AddWithValue("@sql", sql);
                cmd.Parameters.AddWithValue("@mysql", mysql);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@avg", avg);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
                HasError = false;
                connection.Close();

            }
            catch (SqlException ex)
            {
                HasError = true;
                MessageControlers.Messages.Show.Error(ex.Message, "Error");
            }
        }
    }
}
