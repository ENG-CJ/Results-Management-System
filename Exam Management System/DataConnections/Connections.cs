using System.Data.OleDb;
using System.Data.SqlClient;

namespace Exam_Management_System.DataConnections
{
    internal class Connections
    {
        public static string GetPath { private get; set; }
        /// <summary>
        /// Gets And Returns Sql Server Connection
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=JUST_RESULTS;Integrated Security=True");
            return conn;
        }
        /// <summary>
        /// Gets And Returns Excel DB Connection
        /// </summary>
        /// <returns></returns>
        public OleDbConnection GetExcelConnection()
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + GetPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(connString);
            return conn;
        }
    }
}
