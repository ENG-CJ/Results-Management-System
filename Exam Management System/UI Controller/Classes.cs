using Exam_Management_System.Animators;
using Exam_Management_System.Class_Controler;
using Exam_Management_System.DataConnections;
using Exam_Management_System.Excel_UIs;
using Exam_Management_System.MessageControlers;
using Guna.UI2.WinForms;
using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Exam_Management_System.UI_Controller
{
    public partial class Classes : UserControl
    {
        public static int iNumber;
        public static int temp;
        public static string cName;
        public static string PathURL;
        public static string sheet;
        public static OleDbConnection conn;
        public static Guna2TextBox getText = new Guna2TextBox();
        public static Guna2DataGridView ClassData = new Guna2DataGridView();
        public Classes()
        {
            InitializeComponent();
            ClassData = getclassdata;

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            Class.GetClassData(getclassdata);
        }

        private void AddClassButton(object sender, EventArgs e)
        {
            Animate.ShowControl(addClassUI, BunifuAnimatorNS.AnimationType.HorizSlide);

            AddClassUI.saveBtn.BringToFront();
        }

        private void DeleteBtn(object sender, EventArgs e)
        {

            if (iNumber != 0)
            {
                DialogResult result = Messages.Show.AskQuestion("Are you Sure To Delete This record?", "Confirm");
                if (result == DialogResult.No)
                    return;
                else
                {
                    Class_Controler.Class.DeleteClass(iNumber);
                    Class_Controler.Class.GetClassData(getclassdata);
                }
            }

            else
            {
                Messages.Show.Error("Select The Class You Wanat To delete", "Error");
            }
        }

        private void UploadFromExcel(object sender, EventArgs e)
        {
            allsheets.Show();
            if (openExcelFile.ShowDialog() == DialogResult.OK)
            {
                PathURL = openExcelFile.FileName;
            }
        }

        private void UploadJust(object sender, EventArgs e)
        {
            if (PathURL == null || allsheets.Text == "Select Sheet" || allsheets.Visible == false)
                MessageBox.Show("Path URL or Sheet Is Not Provided");
            else
            {

                Connections connections = new Connections();
                Connections.GetPath = PathURL;
                conn = connections.GetExcelConnection();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select *from [" + allsheets.Text + "$]", conn);
                OleDbDataAdapter reader = new OleDbDataAdapter(cmd);
                System.Data.DataTable table = new System.Data.DataTable();
                reader.Fill(table);
                cmd.ExecuteNonQuery();
                conn.Close();
                new Excel_Data_Center(table).ShowDialog();

            }
        }

        private void Hide(object sender, EventArgs e)
        {
            allsheets.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (iNumber != 0)
                new UpdateClass(iNumber, cName).ShowDialog();

            else
                Messages.Show.Error("Select Record You Want to Update", "Error | update");
        }

        private void getItems(object sender, DataGridViewCellEventArgs e)
        {
            iNumber = (int)getclassdata.SelectedRows[0].Cells[0].Value;
            temp = (int)getclassdata.SelectedRows[0].Cells[0].Value;
            cName = (string)getclassdata.SelectedRows[0].Cells[1].Value;
        }

        private void ViewOptions(object sender, EventArgs e)
        {
            optionPanel.Show();
        }

        private void Hidecontent(object sender, EventArgs e)
        {
            optionPanel.Hide();
        }

        private void DropData(object sender, EventArgs e)
        {
            DialogResult result = Messages.Show.Warning("You Dropping All Data! Do you Want to continue?", "Warning");
            if (result == DialogResult.No)
                return;
            else
            {
                Filters.DropAll();
                Messages.Show.Info("Sucessfully Dropped....", "Commits");
                Class.GetClassData(getclassdata);
            }
        }

        private void ShowUp(object sender, EventArgs e)
        {
            if (shows.Text == "All")
                Class.GetClassData(getclassdata);
            else
                Filters.ShowUp(int.Parse(shows.Text), getclassdata);
        }

        private void searching_TextChanged(object sender, EventArgs e)
        {
            if (searching.Text == "")
            {
                setError.Text = "";
                Class.GetClassData(getclassdata);
            }
            else
            {
                Filters.SearchClass(searching.Text, getclassdata);
                if (!Filters.HasRows)
                {
                    Class.GetClassData(getclassdata);
                    setError.Text = "Not found This Context!.";
                }
                else
                    setError.Text = "";
            }
        }

        private void saerchingclass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
