using Exam_Management_System.DataConnections;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Exam_Management_System.Data_Visulaization_Controler
{
    internal class MonoChart
    {
        public static SqlConnection connect;
        public static void DrawChart(Chart chart)
        {
            Connections connections = new Connections();
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("triProc", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                if (adapter.HasRows)
                    chart.Series["Classes Summary"].Points.AddXY(adapter[0], adapter[1]);
            }
            connect.Close();
        }
    }

}
