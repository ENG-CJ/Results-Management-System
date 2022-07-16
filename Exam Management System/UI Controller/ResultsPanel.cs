using Exam_Management_System.MessageControlers;
using Exam_Management_System.Result_Controler;
using Exam_Management_System.validations;
using System.Windows.Forms;
namespace Exam_Management_System.UI_Controller
{
    public partial class ResultsPanel : UserControl
    {

        #region All Properties
        public float csharp { get; set; }
        public float javaSubject { get; set; }
        public float phpSubject { get; set; }
        public float pyhonSubject { get; set; }
        public float sqlServerSubject { get; set; }
        public float MySqlSubject { get; set; }
        public float Total { get; set; }
        public string avg { get; set; }
        public char Grade { get; set; }

        #endregion
        public ResultsPanel()
        {
            InitializeComponent();
        }

        private void Calculate_Marks(object sender, System.EventArgs e)
        {
            saaToast1.Show();
            if (
                 Validation.IsConverted(cSharp.Text)
                 && Validation.IsConverted(java.Text) && Validation.IsConverted(php.Text)
                 && Validation.IsConverted(python.Text) && Validation.IsConverted(sql.Text)
                 && Validation.IsConverted(mysql.Text)
              )
            {
                csharp = float.Parse(cSharp.Text);
                javaSubject = float.Parse(java.Text);
                phpSubject = float.Parse(php.Text);
                pyhonSubject = float.Parse(python.Text);
                sqlServerSubject = float.Parse(sql.Text);
                MySqlSubject = float.Parse(mysql.Text);

                // checking values
                if (Results.CheckTheValues(csharp, javaSubject, phpSubject, pyhonSubject, sqlServerSubject, MySqlSubject))
                {
                    // appednids
                    Total = Results.GetTotal(csharp, javaSubject, phpSubject, pyhonSubject, sqlServerSubject, MySqlSubject);
                    totalMarks.Text = Total.ToString();
                    average.Text = Results.GetAverage(Total).ToString("0.##") + "%";
                    grade.Text = Results.GetGrade(Results.GetAverage(Total)).ToString();

                    saveBtn.Enabled = true;
                }
                else
                    MessageBox.Show("Provide Valid Marks! Subject marks Must Greater Or Equal 0 and Less Then oR eQUAL 100");
            }
            else
                Messages.Show.Error("Only Numeric Values are allowed. Make You Sure The Values You provide.", "Error | Marks");




        }

        private void ResultsPanel_Load(object sender, System.EventArgs e)
        {
            Results.ReadStudentsID(idComboBox);
        }

        private void idComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (idComboBox.SelectedIndex == 0)
            {
                studentClass.Text = "";
                studentName.Text = "";
                currentSemester.Text = "";
            }
            else
                Results.SearchStudentData(idComboBox.Text, studentName, studentClass, currentSemester); ;

        }

        private void SaveData(object sender, System.EventArgs e)
        {
            if (idComboBox.SelectedIndex == 0)
                Messages.Show.Error("Select The Student You Want To Mark this Result", "Error");
            else
            {
                // checking empty selection
                if (Validation.IsBlank(cSharp.Text, php.Text, python.Text, sql.Text, mysql.Text, java.Text))
                    Messages.Show.Error("Plz Fill The Student Marks", "Error");
                else
                {
                    // checking the values
                    if (IsValidData() && isCheckedValues())
                    {
                        // valid data
                        csharp = float.Parse(cSharp.Text);
                        javaSubject = float.Parse(java.Text);
                        phpSubject = float.Parse(php.Text);
                        pyhonSubject = float.Parse(python.Text);
                        sqlServerSubject = float.Parse(sql.Text);
                        MySqlSubject = float.Parse(mysql.Text);
                        Total = Results.GetTotal(csharp, javaSubject, phpSubject, pyhonSubject, sqlServerSubject, MySqlSubject);
                        avg = Results.GetAverage(Total).ToString("0.##");
                        Grade = Results.GetGrade(Results.GetAverage(Total));

                        Results.AddResult(
                            idComboBox.Text, studentName.Text, studentClass.Text,
                            currentSemester.Text, csharp, javaSubject, phpSubject, pyhonSubject,
                            sqlServerSubject, MySqlSubject, Total, avg, Grade);
                        if (Results.HasError)
                            return;
                        else
                            Messages.Show.Info("Sucessfully Saved.....", "Commits");
                    }
                    else
                        Messages.Show.Error("Error Detected. Make Sure The Data You Provide Before Submision.", "Error"); ;
                }
            }
        }


        private bool IsValidData()
        {
            bool checkedValue;
            if (
                Validation.IsConverted(cSharp.Text)
                && Validation.IsConverted(java.Text) && Validation.IsConverted(php.Text)
                && Validation.IsConverted(python.Text) && Validation.IsConverted(sql.Text)
                && Validation.IsConverted(mysql.Text)
             )
            {
                checkedValue = true;
                // checking vaues

            }
            else
                checkedValue = false;
            return checkedValue;
        }
        private bool isCheckedValues()
        {
            bool ischecked;
            if (Results.CheckTheValues(
                double.Parse(cSharp.Text), double.Parse(java.Text),
                double.Parse(python.Text), double.Parse(php.Text),
                double.Parse(sql.Text), double.Parse(mysql.Text)
                ))
            {
                ischecked = true;
            }
            else
                ischecked = false;
            return ischecked;
        }
    }
}
