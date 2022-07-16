using Exam_Management_System.Animators;
using Exam_Management_System.Class_Controler;
using Exam_Management_System.MessageControlers;
using Exam_Management_System.validations;
using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Exam_Management_System.UI_Controller
{
    public partial class AddClassUI : UserControl
    {
        public static Guna2GradientButton UpdateBTN = new Guna2GradientButton();
        public static Guna2GradientButton saveBtn = new Guna2GradientButton();
        public static SqlConnection conn;

        public static int GetID { private get; set; }
        public static string GetName { private get; set; }
        public AddClassUI()
        {
            InitializeComponent();
            UpdateBTN = updateButton;
            saveBtn = saveButton;
            classid.Text = GetID.ToString();
            classname.Text = GetName;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Animate.HideControl(this, BunifuAnimatorNS.AnimationType.HorizSlide);
            //classid.Text = "";
            //classname.Text = "";
            Classes.getText.Enabled = true;
        }

        private void SaveData(object sender, EventArgs e)
        {
            if (Validation.IsBlank(classid.Text, classname.Text))
                Messages.Show.Error("All Fields Are Required..", "Error");
            else
            {
                Class.AddClass(int.Parse(classid.Text), classname.Text);
                Messages.Show.Info("Sucessfully Saved...", "Commits");
                Class.GetClassData(Classes.ClassData);
                Animate.HideControl(this, BunifuAnimatorNS.AnimationType.HorizSlide);
                classid.Text = "";
                classname.Text = "";
                Classes.getText.Enabled = true;
                UI_Controller.StudentUI.classes.Items.Clear();
                Class_Controler.Class.ReadClassNames(StudentUI.classes);

            }

        }

        private void Update(object sender, EventArgs e)
        {

        }

        private void AddClassUI_Load(object sender, EventArgs e)
        {

        }
    }
}
