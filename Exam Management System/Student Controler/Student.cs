using ComponentFactory.Krypton.Toolkit;
using Exam_Management_System.DataConnections;
using Exam_Management_System.Image_controll;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
namespace Exam_Management_System.Student_Controler

{
    internal class Student
    {
        // operations
        public static SqlConnection connect;
        public static Connections connections = new Connections();

        public static void GetStudents(KryptonDataGridView data)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("ReadStudents", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            data.DataSource = table;
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public static void AddStudent(string id, string name, string gender, int age, string address,
           string classid, string semester, Image img)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand command = new SqlCommand("addStudent", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@age", age);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@class", classid);
            command.Parameters.AddWithValue("@semes", semester);
            MemoryStream stream = Images.SaveImageToStream(img);
            command.Parameters.AddWithValue("@img", stream.ToArray());
            command.ExecuteNonQuery();
            connect.Close();
        }

        public static void UpdateStudent(string id, string name, string gender, int age, string address,
           string classname, string semester, Image img, string updatableID)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand command = new SqlCommand("updateStudent", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@age", age);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@class", classname);

            command.Parameters.AddWithValue("@semes", semester);
            MemoryStream stream = Images.SaveImageToStream(img);
            command.Parameters.AddWithValue("@img", stream.ToArray());
            command.Parameters.AddWithValue("@updateID", updatableID);
            command.ExecuteNonQuery();
            connect.Close();
        }

        public static void DeletStudent(string id)
        {
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("deleteStudent", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        /// <summary>
        /// Searches Student Image From Database and converts To Normal Image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Image SearchStudentPhoto(string id)
        {
            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("SearchPhoto", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader adapter = cmd.ExecuteReader();
            if (adapter.HasRows)
            {
                adapter.Read();
                MemoryStream stream = new MemoryStream((byte[])adapter[0]);
                pictureBox.Image = Image.FromStream(stream);
            }
            connect.Close();

            return pictureBox.Image;
        }
    }
}
