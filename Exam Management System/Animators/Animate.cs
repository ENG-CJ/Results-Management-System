using BunifuAnimatorNS;
using System.Windows.Forms;
namespace Exam_Management_System.Animators
{

    /// <summary>
    /// Provides Animations From Bunifu UI
    /// </summary>
    internal class Animate
    {

        public static void ShowControl(UserControl control, AnimationType animation = AnimationType.HorizBlind)
        {
            if (control == null)
                return;
            else
            {
                BunifuTransition bunifu = new BunifuTransition();
                bunifu.AnimationType = animation;
                bunifu.ShowSync(control);
            }

        }


        public static void HideControl(UserControl control, AnimationType animation = AnimationType.HorizBlind)
        {
            if (control == null)
                return;
            else
            {
                BunifuTransition bunifu = new BunifuTransition();
                bunifu.AnimationType = animation;
                bunifu.HideSync(control);
            }

        }
    }
}
