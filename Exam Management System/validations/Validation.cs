using Exam_Management_System.MessageControlers;
using Guna.UI2.WinForms;
namespace Exam_Management_System.validations
{
    /// <summary>
    /// Provides All Validation
    /// </summary>
    internal class Validation
    {
        public static int GetDuplicateValue { get; private set; }
        public static bool IsBlank(string ip1, string ip2, string ip3)
        {
            return ip1 == "" || ip2 == "" || ip3 == "";
        }

        public static bool IsBlank(string ip1, string ip2)
        {
            return ip1 == "" || ip2 == "";
        }

        public static bool IsBlank(string ip1, string ip2, string ip3, string ip4, string ip5, string ip6)
        {
            return ip1 == "" || ip2 == "" || ip3 == "" || ip4 == "" || ip5 == "" || ip6 == "";
        }

        public static bool IsBlank(string ip1, string ip2, string ip3, string ip4)
        {
            return ip1 == "" || ip2 == "" || ip3 == "" || ip4 == "";
        }

        public static bool IsBlank(string ip1, string ip2, string ip3, string ip4, string ip5)
        {
            return ip1 == "" || ip2 == "" || ip3 == "" || ip4 == "" || ip5 == "";
        }

        public static bool IsBlank(string ip1, string ip2, string ip3, string ip4, string ip5, string ip6, string ip7)
        {
            return ip1 == "" || ip2 == "" || ip3 == "" || ip4 == "" || ip5 == "" || ip6 == "" || ip7 == "";
        }

        public static bool IsBlank(string ip1, string ip2, string ip3, string ip4, string ip5, Guna2ComboBox comboBox1, Guna2ComboBox comboBox2)
        {
            return ip1 == "" || ip2 == "" || ip3 == "" || ip4 == "" || ip5 == "" || comboBox1.Text == "" || comboBox2.Text == "";
        }

        // end blank checker

        // email
        public static bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com") && !email.StartsWith("@gmail.com");
        }
        public static bool IsEqualEmails(string email1, string email2)
        {
            bool IsEqual = false;
            if (IsValidEmail(email1) && IsValidEmail(email2))
            {
                if (email2.Equals(email1))
                    IsEqual = true;

            }
            else

                Messages.Show.Error("First Email or Second Email Was not a Correct Format", "Error | Email Format");


            return IsEqual;


        }

        // mobiles
        public static bool IsValidMobile(string mobile)
        {
            return mobile.StartsWith("61") || mobile.StartsWith("061");
        }
        public static bool ValidMobileLength(string mobile)
        {
            return mobile.Length == 10 || mobile.Length == 9;
        }

        // datagrid view 
        public static bool ConatinsEqualData(Guna2DataGridView dataOne, Guna2DataGridView dataTwo)
        {
            bool isEqual = false;
            for (int i = 0; i < dataOne.Rows.Count; i++)
            {
                for (int j = 0; j < dataTwo.Rows.Count; j++)
                    if (dataOne.Rows[i].Equals(dataTwo.Rows[j]))
                        isEqual = true;
            }
            return isEqual;
        }

        public static bool HasDuplicateData(Guna2DataGridView data)
        {
            bool HasDuplicate = false;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = i + 1; j < data.Rows.Count; j++)
                {

                    if (System.Convert.ToInt32(data.Rows[i].Cells[0].Value) == System.Convert.ToInt32(data.Rows[j].Cells[0].Value))
                    {
                        HasDuplicate = true;


                    }
                }
            }

            return HasDuplicate;
        }


        // image
        public static bool IsNull(System.Drawing.Image image)
        {
            return image == null;
        }

        // radiobutton
        public static bool IsSelected(XanderUI.XUIRadio radiobtn1, XanderUI.XUIRadio radiobtn2)
        {
            return (radiobtn1.Checked || radiobtn2.Checked);
        }

        public static bool IsValidID(string id)
        {
            return id[0] == 'C' && id[1] == '1' && id[2] == '2' && id[3] == '0';
        }

        public static bool IsValidAge(int age)
        {
            return age >= 18 && age <= 40;
        }

        public static bool IsConverted(string convertionType)
        {
            int tempNumber;
            bool isConvert = false;

            if (int.TryParse(convertionType, out tempNumber))
                isConvert = true;
            return isConvert;
        }
    }
}
