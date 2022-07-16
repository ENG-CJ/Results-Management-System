using Exam_Management_System.Class_Controler;
using Exam_Management_System.MessageControlers;
using Exam_Management_System.validations;
using System.Windows.Forms;
namespace Exam_Management_System.UI_Controller
{
    public partial class UpdateClass : Form
    {
        public UpdateClass()
        {
            InitializeComponent();
        }

        public UpdateClass(int id, string name)
        {
            InitializeComponent();
            cuid.Text = id.ToString();
            cuiname.Text = name.ToString();
        }

        private void EditChanges(object sender, System.EventArgs e)
        {
            if (Validation.IsBlank(cuid.Text, cuiname.Text))
                Messages.Show.Error("All Fileds Are REquired", "Error");
            else
            {
                int id = int.Parse(cuid.Text);
                Class.UpdateClass(id, cuiname.Text, Classes.iNumber);

                Class.GetClassData(Classes.ClassData);
                cuid.Text = "";
                cuiname.Text = "";
                this.Hide();
            }
        }
    }
}
