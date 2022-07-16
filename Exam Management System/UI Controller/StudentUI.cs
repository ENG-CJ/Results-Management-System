using ComponentFactory.Krypton.Toolkit;
using Exam_Management_System.Animators;
using Exam_Management_System.Data_Visulaization_Controler;
using Exam_Management_System.MessageControlers;
using Exam_Management_System.Student_Controler;
using Exam_Management_System.validations;
using System;
using System.Windows.Forms;
namespace Exam_Management_System.UI_Controller
{
    public partial class StudentUI : UserControl
    {
        public static KryptonComboBox classes { get; set; }
        // properties
        public static string gender { get; set; }
        public static string id { get; set; }
        public static string Currentid { get; set; }
        public static string name { get; set; }
        public static string addr { get; set; }
        public static int ageStd { get; set; }
        public static int classnumber { get; set; }
        public static string clasName { get; set; }
        public static string semes { get; set; }


        public StudentUI()
        {
            InitializeComponent();
            classes = classNAMES;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Animate.HideControl(this, BunifuAnimatorNS.AnimationType.HorizSlide);
        }

        private void OpenImage(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                studentPhoto.Image = System.Drawing.Image.FromFile(openImage.FileName);
                studentPhoto.BringToFront();
            }
        }

        private void AddStudent(object sender, EventArgs e)
        {
            if (Validation.IsBlank(stdid.Text, stdname.Text, age.Text, address.Text, classNAMES.Text, semester.Text))
                Messages.Show.Error("All Fields Are Required", "Error");
            else if (Validation.IsSelected(female, male))
            {
                if (Validation.IsNull(studentPhoto.Image))
                    Messages.Show.Error("Student Image Can't Be Null", "Error");
                else
                {
                    if (Validation.IsValidID(stdid.Text.ToUpper()))
                    {
                        if (Validation.IsConverted(age.Text))
                        {
                            if (Validation.IsValidAge(int.Parse(age.Text)))
                            {
                                // valid data will procceed here 
                                try
                                {
                                    if (male.Checked) gender = "Male"; else gender = "Female";
                                    Student.AddStudent(
                                        stdid.Text,
                                        stdname.Text,
                                        gender,
                                        int.Parse(age.Text),
                                        address.Text,
                                        classNAMES.Text,
                                        // update 
                                        semester.Text,
                                        studentPhoto.Image
                                        );
                                    Messages.Show.Info("Sucessfully Saved...", "Commits");
                                    Student.GetStudents(studentsData);
                                    Clean.CleanAll(stdid, stdname, age, address, semester, classNAMES, male, female, studentPhoto);
                                    studentPhoto.SendToBack();

                                    MonoChart.DrawChart(DashboardController.chart);
                                    DashboardController.chart.Update();
                                }
                                catch (System.Data.SqlClient.SqlException ex)
                                {
                                    Messages.Show.Error("Error Occured Plz Fix Out This Error\n\n___________________" + ex.Message, "Error");
                                }


                            }
                            else
                                Messages.Show.Error("The Student Age Must be Graeter Than 18 and Less then 40", "Error");
                        }
                        else
                            Messages.Show.Error("Age Must Be Numeric Value", "Error");
                    }
                    else
                        Messages.Show.Error("This ID Is Not Belongs Our Rules", "Error");
                }
            }
            else
                Messages.Show.Error("Select Your Gender", "Eror");

        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentUI_Load(object sender, EventArgs e)
        {
            Student.GetStudents(studentsData);
            UI_Controller.StudentUI.classes.Items.Clear();
            Class_Controler.Class.ReadClassNames(classNAMES);
        }

        private void GetStudentInfo(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // searching student image 
                id = studentsData.SelectedRows[0].Cells[0].Value.ToString();
                Currentid = studentsData.SelectedRows[0].Cells[0].Value.ToString();
                name = studentsData.SelectedRows[0].Cells[1].Value.ToString();
                gender = studentsData.SelectedRows[0].Cells[2].Value.ToString();
                ageStd = (int)studentsData.SelectedRows[0].Cells[3].Value;
                addr = studentsData.SelectedRows[0].Cells[4].Value.ToString();

                clasName = studentsData.SelectedRows[0].Cells[5].Value.ToString();
                semes = studentsData.SelectedRows[0].Cells[6].Value.ToString();


                // appending 
                studentPhoto.Image = Student.SearchStudentPhoto(id);
                studentPhoto.BringToFront();
                stdid.Text = id;
                stdname.Text = name;
                age.Text = ageStd.ToString();
                address.Text = addr;

                classNAMES.Text = semes;
                classNAMES.Text = clasName;

                //classname.Text = clasName;

                semester.Text = semes;
                if (gender == "Male")
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                else
                {
                    female.Checked = true;
                    male.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Messages.Show.Error("Error Occured Due To\n\n_____________________\n" + ex.Message, "Error");
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            if (id != null)
            {
                DialogResult dialog = Messages.Show.AskQuestion("Are you Sure To delete This Student?", "Cofnirm");

                if (dialog == DialogResult.No)
                    return;
                else
                {

                    Student.DeletStudent(id);
                    Messages.Show.Info("Sucessfully Delete....", "Commits");
                    Student.GetStudents(studentsData);
                    Clean.CleanAll(stdid, stdname, age, address, semester, classNAMES, male, female, studentPhoto);
                    studentPhoto.SendToBack();

                    MonoChart.DrawChart(DashboardController.chart);

                }
            }
            else
                Messages.Show.Error("Before Deletion Select the Record....", "Error");

        }

        private void UpdateStudent(object sender, EventArgs e)
        {
            if (id != null)
            {
                if (male.Checked) gender = "Male"; else gender = "Female";
                Student.UpdateStudent(
                                       stdid.Text,
                                       stdname.Text,
                                       gender,
                                       int.Parse(age.Text),
                                       address.Text,
                                       classNAMES.Text,
                                       //classname.Text,
                                       semester.Text,
                                       studentPhoto.Image,
                                       Currentid
                                       );
                Messages.Show.Info("Successfuly Updated....", "Commits");
                Student.GetStudents(studentsData);
                Clean.CleanAll(stdid, stdname, age, address, semester, classNAMES, male, female, studentPhoto);
                studentPhoto.SendToBack();
                DashboardController.chart.Series.Clear();
                MonoChart.DrawChart(DashboardController.chart);
            }
            else
                Messages.Show.Error("Before Updating Select the Record....", "Error");

        }

        private void ExitApp(object sender, EventArgs e)
        {
            DialogResult result = Messages.Show.AskQuestion("You Gonna Exit Entire System. Do You Want To Continue?", "Confirm");
            if (result == DialogResult.No)
                return;
            else
                Application.Exit();
        }

        private void ExitWindow(object sender, EventArgs e)
        {
            Animate.HideControl(this, BunifuAnimatorNS.AnimationType.HorizSlide);
        }

        private void classID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void byClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bySemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void male_Click(object sender, EventArgs e)
        {

        }

        private void female_Click(object sender, EventArgs e)
        {

        }

        private void stdname_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void studentPhoto_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
