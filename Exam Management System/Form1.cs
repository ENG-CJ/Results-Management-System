using Exam_Management_System.DataConnections;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Exam_Management_System
{
    public partial class Form1 : Form
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

        public static void DrawChart(LiveCharts.WinForms.PieChart chart1)
        {

            Connections connections = new Connections();
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("triProc", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader adapter = cmd.ExecuteReader();
            chart1.Series = GetSeries(adapter);
            connect.Close();
        }

        public static void DrawChart(LiveCharts.WinForms.CartesianChart chart1)
        {

            Connections connections = new Connections();
            connect = connections.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("triProc", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader adapter = cmd.ExecuteReader();
            chart1.Series = GetSeries2(adapter);
            connect.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawChart(chart1);
            DrawChart(cartesianChart1);
        }

        static LiveCharts.SeriesCollection GetSeries(SqlDataReader reader)
        {
            Func<ChartPoint, string> labelPoints = ChartPoint => string.Format("{0} ({1:P})", ChartPoint.Y, ChartPoint.Participation);
            LiveCharts.SeriesCollection sr = new LiveCharts.SeriesCollection();

            while (reader.Read())
            {
                if (reader.HasRows)
                    sr.Add(new PieSeries() { Title = reader[0].ToString(), Values = new ChartValues<int> { Convert.ToInt32(reader[1]) }, DataLabels = true, LabelPoint = labelPoints });
            }
            return sr;
        }

        static LiveCharts.SeriesCollection GetSeries2(SqlDataReader reader)
        {
            Func<ChartPoint, string> labelPoints = ChartPoint => string.Format("{0} ({1:P})", ChartPoint.Y, ChartPoint.Participation);
            LiveCharts.SeriesCollection sr = new LiveCharts.SeriesCollection();

            while (reader.Read())
            {
                if (reader.HasRows)
                    sr.Add(new LineSeries() { Title = reader[0].ToString(), Values = new ChartValues<int> { Convert.ToInt32(reader[1]) }, DataLabels = true, LabelPoint = labelPoints });
            }
            return sr;
        }

    }
}
