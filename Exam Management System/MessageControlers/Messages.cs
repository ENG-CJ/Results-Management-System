using System.Windows.Forms;

namespace Exam_Management_System.MessageControlers
{
    /// <summary>
    /// Provides Alll Message Controlers
    /// </summary>
    public class Messages
    {
        public class Show
        {
            public static void Info(string message, string title)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public static void Error(string message, string title)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public static DialogResult AskQuestion(string message, string title)
            {
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return result;
            }

            public static DialogResult Warning(string message, string title)
            {
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return result;
            }
        }
    }
}
