namespace Exam_Management_System.UI_Controller
{
    partial class StudentUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updatebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.male = new XanderUI.XUIRadio();
            this.female = new XanderUI.XUIRadio();
            this.stdname = new Guna.UI2.WinForms.Guna2TextBox();
            this.address = new Guna.UI2.WinForms.Guna2TextBox();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stdid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.studentPhoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.studentsData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.classNAMES = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.semester = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNAMES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semester)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Exam_Management_System.Properties.Resources.icons8_view_more_48px;
            this.pictureBox1.Location = new System.Drawing.Point(994, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "View More");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 144);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byClassToolStripMenuItem,
            this.bySemesterToolStripMenuItem,
            this.byNumberToolStripMenuItem,
            this.byIDToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::Exam_Management_System.Properties.Resources.icons8_filter_edit_48px;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 28);
            this.toolStripMenuItem1.Text = "Filters";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // byClassToolStripMenuItem
            // 
            this.byClassToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.byClassToolStripMenuItem.Name = "byClassToolStripMenuItem";
            this.byClassToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.byClassToolStripMenuItem.Text = "By Class";
            this.byClassToolStripMenuItem.Click += new System.EventHandler(this.byClassToolStripMenuItem_Click);
            // 
            // bySemesterToolStripMenuItem
            // 
            this.bySemesterToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.bySemesterToolStripMenuItem.Name = "bySemesterToolStripMenuItem";
            this.bySemesterToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.bySemesterToolStripMenuItem.Text = "By Semester";
            this.bySemesterToolStripMenuItem.Click += new System.EventHandler(this.bySemesterToolStripMenuItem_Click);
            // 
            // byNumberToolStripMenuItem
            // 
            this.byNumberToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.byNumberToolStripMenuItem.Name = "byNumberToolStripMenuItem";
            this.byNumberToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.byNumberToolStripMenuItem.Text = "By Number";
            this.byNumberToolStripMenuItem.Click += new System.EventHandler(this.byNumberToolStripMenuItem_Click);
            // 
            // byIDToolStripMenuItem
            // 
            this.byIDToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byIDToolStripMenuItem.Name = "byIDToolStripMenuItem";
            this.byIDToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.byIDToolStripMenuItem.Text = "By ID";
            this.byIDToolStripMenuItem.Click += new System.EventHandler(this.byIDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Image = global::Exam_Management_System.Properties.Resources.icons8_search_more_48px;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 28);
            this.toolStripMenuItem2.Text = "Search";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoToolTip = true;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem3.Image = global::Exam_Management_System.Properties.Resources.icons8_Remove_48px;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 28);
            this.toolStripMenuItem3.Text = "Drop Data";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(114, 28);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.Image = global::Exam_Management_System.Properties.Resources.icons8_print_48px;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 28);
            this.toolStripMenuItem4.Text = "Print Data";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem5.Image = global::Exam_Management_System.Properties.Resources.icons8_external_48px;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(162, 28);
            this.toolStripMenuItem5.Text = "Exit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(192, 28);
            this.toolStripMenuItem6.Text = "Application";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ExitApp);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(192, 28);
            this.toolStripMenuItem7.Text = "This Window";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ExitWindow);
            // 
            // close
            // 
            this.close.Image = global::Exam_Management_System.Properties.Resources.icons8_Close_48px;
            this.close.Location = new System.Drawing.Point(1054, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 49);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Student Section Period";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Students Period";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.semester);
            this.guna2GroupBox1.Controls.Add(this.classNAMES);
            this.guna2GroupBox1.Controls.Add(this.guna2GradientButton5);
            this.guna2GroupBox1.Controls.Add(this.updatebtn);
            this.guna2GroupBox1.Controls.Add(this.guna2GradientButton3);
            this.guna2GroupBox1.Controls.Add(this.male);
            this.guna2GroupBox1.Controls.Add(this.female);
            this.guna2GroupBox1.Controls.Add(this.stdname);
            this.guna2GroupBox1.Controls.Add(this.address);
            this.guna2GroupBox1.Controls.Add(this.age);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.stdid);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 84);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(807, 328);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Student Information";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Animated = true;
            this.guna2GradientButton5.BorderRadius = 6;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.Location = new System.Drawing.Point(291, 273);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(132, 45);
            this.guna2GradientButton5.TabIndex = 4;
            this.guna2GradientButton5.Text = "DELETE";
            this.guna2GradientButton5.Click += new System.EventHandler(this.Delete);
            // 
            // updatebtn
            // 
            this.updatebtn.Animated = true;
            this.updatebtn.BorderRadius = 6;
            this.updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updatebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updatebtn.FillColor = System.Drawing.Color.Blue;
            this.updatebtn.FillColor2 = System.Drawing.Color.Blue;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(133, 273);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(140, 45);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.Click += new System.EventHandler(this.UpdateStudent);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderRadius = 6;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Green;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(10, 273);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(112, 45);
            this.guna2GradientButton3.TabIndex = 6;
            this.guna2GradientButton3.Text = "ADD";
            this.guna2GradientButton3.Click += new System.EventHandler(this.AddStudent);
            // 
            // male
            // 
            this.male.Checked = false;
            this.male.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.DimGray;
            this.male.Location = new System.Drawing.Point(114, 196);
            this.male.Name = "male";
            this.male.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.male.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.male.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.male.Size = new System.Drawing.Size(106, 22);
            this.male.TabIndex = 2;
            this.male.Text = "Male";
            this.male.Click += new System.EventHandler(this.male_Click);
            // 
            // female
            // 
            this.female.Checked = false;
            this.female.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.DimGray;
            this.female.Location = new System.Drawing.Point(19, 197);
            this.female.Name = "female";
            this.female.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.female.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.female.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.female.Size = new System.Drawing.Size(106, 22);
            this.female.TabIndex = 2;
            this.female.Text = "Female";
            this.female.Click += new System.EventHandler(this.female_Click);
            // 
            // stdname
            // 
            this.stdname.Animated = true;
            this.stdname.BorderColor = System.Drawing.Color.DarkGray;
            this.stdname.BorderRadius = 2;
            this.stdname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdname.DefaultText = "";
            this.stdname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stdname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stdname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.stdname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdname.Location = new System.Drawing.Point(188, 83);
            this.stdname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stdname.Name = "stdname";
            this.stdname.PasswordChar = '\0';
            this.stdname.PlaceholderText = "Student Name";
            this.stdname.SelectedText = "";
            this.stdname.Size = new System.Drawing.Size(206, 35);
            this.stdname.TabIndex = 1;
            this.stdname.TextChanged += new System.EventHandler(this.stdname_TextChanged);
            // 
            // address
            // 
            this.address.Animated = true;
            this.address.BorderColor = System.Drawing.Color.DarkGray;
            this.address.BorderRadius = 2;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.DefaultText = "";
            this.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.Location = new System.Drawing.Point(596, 83);
            this.address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.PlaceholderText = "Student ID";
            this.address.SelectedText = "";
            this.address.Size = new System.Drawing.Size(157, 35);
            this.address.TabIndex = 1;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // age
            // 
            this.age.Animated = true;
            this.age.BorderColor = System.Drawing.Color.DarkGray;
            this.age.BorderRadius = 2;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.Location = new System.Drawing.Point(418, 83);
            this.age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderText = "Student ID";
            this.age.SelectedText = "";
            this.age.Size = new System.Drawing.Size(143, 35);
            this.age.TabIndex = 1;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(592, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // stdid
            // 
            this.stdid.Animated = true;
            this.stdid.BorderColor = System.Drawing.Color.DarkGray;
            this.stdid.BorderRadius = 2;
            this.stdid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdid.DefaultText = "";
            this.stdid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stdid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stdid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.stdid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdid.Location = new System.Drawing.Point(18, 83);
            this.stdid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stdid.Name = "stdid";
            this.stdid.PasswordChar = '\0';
            this.stdid.PlaceholderText = "Student ID";
            this.stdid.SelectedText = "";
            this.stdid.Size = new System.Drawing.Size(126, 35);
            this.stdid.TabIndex = 1;
            this.stdid.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(414, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(417, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Semester";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(217, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(16, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(184, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label11);
            this.guna2ShadowPanel1.Controls.Add(this.studentPhoto);
            this.guna2ShadowPanel1.Controls.Add(this.panel2);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(823, 84);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(231, 269);
            this.guna2ShadowPanel1.TabIndex = 2;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "PHOTO";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // studentPhoto
            // 
            this.studentPhoto.Location = new System.Drawing.Point(1, 3);
            this.studentPhoto.Name = "studentPhoto";
            this.studentPhoto.Size = new System.Drawing.Size(227, 263);
            this.studentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPhoto.TabIndex = 1;
            this.studentPhoto.TabStop = false;
            this.studentPhoto.Click += new System.EventHandler(this.studentPhoto_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 338);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 3;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Gray;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(824, 359);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(230, 45);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "BROWSE";
            this.guna2GradientButton1.Click += new System.EventHandler(this.OpenImage);
            // 
            // openImage
            // 
            this.openImage.Filter = "JPG|*.JPG|PNG|*.PNG|ICON|*.ICO";
            this.openImage.InitialDirectory = "C:\\Users\\PC\\Pictures\\Camera Roll";
            this.openImage.Title = "Open Your Photo";
            this.openImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openImage_FileOk);
            // 
            // studentsData
            // 
            this.studentsData.AllowUserToAddRows = false;
            this.studentsData.AllowUserToDeleteRows = false;
            this.studentsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsData.Location = new System.Drawing.Point(0, 439);
            this.studentsData.Name = "studentsData";
            this.studentsData.ReadOnly = true;
            this.studentsData.RowHeadersWidth = 51;
            this.studentsData.RowTemplate.Height = 24;
            this.studentsData.Size = new System.Drawing.Size(1168, 347);
            this.studentsData.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.studentsData.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.studentsData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.studentsData.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.studentsData.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.studentsData.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.studentsData.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.studentsData.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Blue;
            this.studentsData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Blue;
            this.studentsData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.studentsData.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.studentsData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsData.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Green;
            this.studentsData.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Green;
            this.studentsData.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.studentsData.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.studentsData.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Green;
            this.studentsData.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Green;
            this.studentsData.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.studentsData.StateSelected.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.studentsData.TabIndex = 5;
            this.studentsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetStudentInfo);
            this.studentsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetStudentInfo);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // classNAMES
            // 
            this.classNAMES.DropDownWidth = 191;
            this.classNAMES.Items.AddRange(new object[] {
            "JHelo"});
            this.classNAMES.Location = new System.Drawing.Point(218, 197);
            this.classNAMES.MaxDropDownItems = 100;
            this.classNAMES.Name = "classNAMES";
            this.classNAMES.Size = new System.Drawing.Size(191, 25);
            this.classNAMES.TabIndex = 8;
            this.classNAMES.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // semester
            // 
            this.semester.DropDownWidth = 191;
            this.semester.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 2",
            "Semester 3",
            "Semester 4",
            "Semester 5",
            "Semester 6",
            "Semester 7",
            "Semester 8"});
            this.semester.Location = new System.Drawing.Point(422, 195);
            this.semester.MaxDropDownItems = 100;
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(191, 25);
            this.semester.TabIndex = 8;
            this.semester.Text = "Select";
            this.semester.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentsData);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentUI";
            this.Size = new System.Drawing.Size(1168, 786);
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNAMES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox stdname;
        private Guna.UI2.WinForms.Guna2TextBox address;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox stdid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIRadio male;
        private XanderUI.XUIRadio female;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton updatebtn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox studentPhoto;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.OpenFileDialog openImage;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView studentsData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox classNAMES;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox semester;
    }
}
