using Exam_Management_System.MessageControlers;
using Exam_Management_System.validations;
using System;
using System.Data;
using System.Windows.Forms;
namespace Exam_Management_System.Excel_UIs
{
    public partial class Excel_Data_Center : Form
    {
        public Excel_Data_Center()
        {
            InitializeComponent();
        }

        public Excel_Data_Center(DataTable data)
        {
            InitializeComponent();
            fromExcel.DataSource = data;
        }

        private void Excel_Data_Center_Load(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {

            DialogResult result = Messages.Show.AskQuestion("Are you Sure To Save This Data From Excel File", "Confirm");
            if (result == DialogResult.No)
                return;
            else
                AnalysTimer.Start();

        }

        private void AnalysTimer_Tick(object sender, EventArgs e)
        {
            analysProgress.ForeColor = System.Drawing.Color.Black;
            ManageTimers(analysProgress, displayAnalys);
            analysProgress.Value += 10;
            if (analysProgress.Value > 50)
                analysProgress.ForeColor = System.Drawing.Color.White;
            if (analysProgress.Value == 100)
            {
                AnalysTimer.Stop();
                try
                {

                    if (Validation.HasDuplicateData(fromExcel))
                    {

                        ManageTimers(analysProgress, displayAnalys, "", false);
                        Messages.Show.Error("This Data Has Duplicate Data Plz Fix Out.", "Commits");
                    }
                    else
                    {
                        Class_Controler.Class.AddClass(fromExcel);
                        Messages.Show.Info("Sucessfully Saved...", "Commits");
                        Class_Controler.Class.GetClassData(UI_Controller.Classes.ClassData);
                        UI_Controller.StudentUI.classes.Items.Clear();
                        Class_Controler.Class.ReadClassNames(UI_Controller.StudentUI.classes);
                        this.Hide();
                    }

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Messages.Show.Error("Faild Analys\nError Occured During Analys. May Be This data Conatins The Data That Has Already Exist\n\n________________________________\n" +
                        "Error: " + ex.Message, "Commits");
                    analysProgress.Value = 0;
                    ManageTimers(analysProgress, displayAnalys, "", false);
                }
            }

        }

        static void ManageTimers(Guna.UI2.WinForms.Guna2ProgressBar progressBar, Label label, string labeText = "Analysing....", bool type = true)
        {
            progressBar.ShowText = type;
            label.Text = labeText;
        }


    }
}
