using Exam_Management_System.Animators;
using Exam_Management_System.MessageControlers;
using System;
using System.Windows.Forms;
namespace Exam_Management_System
{
    public partial class MainDashboard : Form
    {


        public MainDashboard()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {

            DialogResult result = Messages.Show.AskQuestion("Are you Sure to Exit?", "Confirm");
            if (result != DialogResult.Yes)
                return;
            else
                this.Close();
        }

        private void Manageclass(object sender, EventArgs e)
        {
            Animate.HideControl(dashboardController1, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.HideControl(studentUI, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.ShowControl(classUserControl, BunifuAnimatorNS.AnimationType.HorizSlide);

        }

        private void BackToTheDashBoard(object sender, EventArgs e)
        {
            Animate.HideControl(classUserControl, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.HideControl(studentUI, BunifuAnimatorNS.AnimationType.HorizSlide);

            Animate.ShowControl(dashboardController1, BunifuAnimatorNS.AnimationType.HorizSlide);
        }

        private void ViewStudents(object sender, EventArgs e)
        {
            Animate.HideControl(classUserControl, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.HideControl(dashboardController1, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.ShowControl(studentUI, BunifuAnimatorNS.AnimationType.HorizSlide);
        }

        private void ShowMeResults(object sender, EventArgs e)
        {
            Animate.HideControl(classUserControl, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.HideControl(dashboardController1, BunifuAnimatorNS.AnimationType.HorizSlide);
            Animate.HideControl(studentUI, BunifuAnimatorNS.AnimationType.HorizSlide);

            //Animate.ShowControl(resultsPanel, BunifuAnimatorNS.AnimationType.HorizSlide);
        }
    }
}
