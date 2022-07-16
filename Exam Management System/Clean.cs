using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using System.Windows.Forms;
namespace Exam_Management_System
{
    internal class Clean
    {

        public static void CleanAll(Guna2TextBox id, Guna2TextBox name, Guna2TextBox age, Guna2TextBox addres,
            KryptonComboBox semes, KryptonComboBox classid, XanderUI.XUIRadio male, XanderUI.XUIRadio female, PictureBox img)
        {
            id.Text = "";
            name.Text = "";
            semes.Text = "";
            classid.Text = "";

            if (male.Checked) male.Checked = false; else female.Checked = false;
            age.Text = "";
            addres.Text = "";
            img.Image = null;
        }


    }
}
