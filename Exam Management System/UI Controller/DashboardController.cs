using Exam_Management_System.Data_Visulaization_Controler;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Exam_Management_System.UI_Controller
{
    public partial class DashboardController : UserControl
    {
        public static Chart chart = new Chart();
        public DashboardController()
        {
            InitializeComponent();
            chart = chart1;
        }

        private void DashboardController_Load(object sender, EventArgs e)
        {
            MonoChart.DrawChart(chart1);
        }
    }
}
