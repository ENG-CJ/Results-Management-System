namespace Exam_Management_System.UI_Controller
{
    partial class ResultsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsPanel));
            SaaUI.Properties.Radius radius4 = new SaaUI.Properties.Radius();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.currentSemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grade = new System.Windows.Forms.Label();
            this.calcBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mysql = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.python = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cSharp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sql = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.totalMarks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.php = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.java = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kryptonTaskDialog1 = new ComponentFactory.Krypton.Toolkit.KryptonTaskDialog();
            this.saaToast1 = new SaaUI.SaaToast();
            this.saaToolTip1 = new SaaUI.SaaToolTip();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide Student Results";
            this.saaToolTip1.SetToolTip(this.label1, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Student Results";
            this.saaToolTip1.SetToolTip(this.label2, "");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idComboBox);
            this.groupBox1.Controls.Add(this.currentSemester);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.studentClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.studentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            this.saaToolTip1.SetToolTip(this.groupBox1, "");
            // 
            // idComboBox
            // 
            this.idComboBox.BackColor = System.Drawing.Color.Transparent;
            this.idComboBox.BorderRadius = 2;
            this.idComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.idComboBox.ItemHeight = 30;
            this.idComboBox.Items.AddRange(new object[] {
            "Select"});
            this.idComboBox.Location = new System.Drawing.Point(19, 85);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(176, 36);
            this.idComboBox.StartIndex = 0;
            this.idComboBox.TabIndex = 2;
            this.saaToolTip1.SetToolTip(this.idComboBox, "");
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // currentSemester
            // 
            this.currentSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentSemester.DefaultText = "";
            this.currentSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentSemester.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentSemester.Location = new System.Drawing.Point(247, 178);
            this.currentSemester.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.currentSemester.Name = "currentSemester";
            this.currentSemester.PasswordChar = '\0';
            this.currentSemester.PlaceholderText = "";
            this.currentSemester.ReadOnly = true;
            this.currentSemester.SelectedText = "";
            this.currentSemester.Size = new System.Drawing.Size(247, 41);
            this.currentSemester.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.currentSemester, "");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Semester";
            this.saaToolTip1.SetToolTip(this.label6, "");
            // 
            // studentClass
            // 
            this.studentClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentClass.DefaultText = "";
            this.studentClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentClass.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentClass.Location = new System.Drawing.Point(19, 178);
            this.studentClass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentClass.Name = "studentClass";
            this.studentClass.PasswordChar = '\0';
            this.studentClass.PlaceholderText = "";
            this.studentClass.ReadOnly = true;
            this.studentClass.SelectedText = "";
            this.studentClass.Size = new System.Drawing.Size(176, 41);
            this.studentClass.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.studentClass, "");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class";
            this.saaToolTip1.SetToolTip(this.label5, "");
            // 
            // studentName
            // 
            this.studentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentName.DefaultText = "";
            this.studentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentName.Location = new System.Drawing.Point(247, 80);
            this.studentName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentName.Name = "studentName";
            this.studentName.PasswordChar = '\0';
            this.studentName.PlaceholderText = "";
            this.studentName.ReadOnly = true;
            this.studentName.SelectedText = "";
            this.studentName.Size = new System.Drawing.Size(247, 41);
            this.studentName.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.studentName, "");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            this.saaToolTip1.SetToolTip(this.label4, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student ID";
            this.saaToolTip1.SetToolTip(this.label3, "");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grade);
            this.groupBox2.Controls.Add(this.calcBtn);
            this.groupBox2.Controls.Add(this.mysql);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.python);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cSharp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sql);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.average);
            this.groupBox2.Controls.Add(this.totalMarks);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.php);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.java);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(543, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 568);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provide Student Marks";
            this.saaToolTip1.SetToolTip(this.groupBox2, "");
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(111, 406);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(0, 27);
            this.grade.TabIndex = 0;
            this.saaToolTip1.SetToolTip(this.grade, "");
            // 
            // calcBtn
            // 
            this.calcBtn.Animated = true;
            this.calcBtn.BorderRadius = 3;
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calcBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calcBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calcBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calcBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calcBtn.FillColor = System.Drawing.Color.Silver;
            this.calcBtn.FillColor2 = System.Drawing.Color.Silver;
            this.calcBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.calcBtn.ForeColor = System.Drawing.Color.White;
            this.calcBtn.Location = new System.Drawing.Point(22, 455);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.PressedDepth = 40;
            this.calcBtn.Size = new System.Drawing.Size(489, 45);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.saaToolTip1.SetToolTip(this.calcBtn, "saas tooltio");
            this.calcBtn.Click += new System.EventHandler(this.Calculate_Marks);
            // 
            // mysql
            // 
            this.mysql.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mysql.DefaultText = "";
            this.mysql.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mysql.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mysql.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mysql.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mysql.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mysql.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysql.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mysql.Location = new System.Drawing.Point(247, 272);
            this.mysql.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mysql.Name = "mysql";
            this.mysql.PasswordChar = '\0';
            this.mysql.PlaceholderText = "";
            this.mysql.SelectedText = "";
            this.mysql.Size = new System.Drawing.Size(247, 41);
            this.mysql.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.mysql, "");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "MYSQL";
            this.saaToolTip1.SetToolTip(this.label12, "");
            // 
            // python
            // 
            this.python.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.python.DefaultText = "";
            this.python.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.python.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.python.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.python.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.python.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.python.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.python.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.python.Location = new System.Drawing.Point(247, 178);
            this.python.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.python.Name = "python";
            this.python.PasswordChar = '\0';
            this.python.PlaceholderText = "";
            this.python.SelectedText = "";
            this.python.Size = new System.Drawing.Size(247, 41);
            this.python.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.python, "");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Python";
            this.saaToolTip1.SetToolTip(this.label7, "");
            // 
            // cSharp
            // 
            this.cSharp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cSharp.DefaultText = "";
            this.cSharp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cSharp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cSharp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cSharp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cSharp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSharp.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSharp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSharp.Location = new System.Drawing.Point(19, 80);
            this.cSharp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cSharp.Name = "cSharp";
            this.cSharp.PasswordChar = '\0';
            this.cSharp.PlaceholderText = "";
            this.cSharp.SelectedText = "";
            this.cSharp.Size = new System.Drawing.Size(176, 41);
            this.cSharp.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.cSharp, "");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "C#";
            this.saaToolTip1.SetToolTip(this.label10, "");
            // 
            // sql
            // 
            this.sql.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sql.DefaultText = "";
            this.sql.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sql.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sql.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sql.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sql.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sql.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sql.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sql.Location = new System.Drawing.Point(19, 272);
            this.sql.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sql.Name = "sql";
            this.sql.PasswordChar = '\0';
            this.sql.PlaceholderText = "";
            this.sql.SelectedText = "";
            this.sql.Size = new System.Drawing.Size(176, 41);
            this.sql.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.sql, "");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Grade : ";
            this.saaToolTip1.SetToolTip(this.label15, "");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "Avg : ";
            this.saaToolTip1.SetToolTip(this.label14, "");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "TOTAL : ";
            this.saaToolTip1.SetToolTip(this.label13, "");
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average.Location = new System.Drawing.Point(109, 368);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(0, 27);
            this.average.TabIndex = 0;
            this.saaToolTip1.SetToolTip(this.average, "");
            // 
            // totalMarks
            // 
            this.totalMarks.AutoSize = true;
            this.totalMarks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMarks.Location = new System.Drawing.Point(109, 333);
            this.totalMarks.Name = "totalMarks";
            this.totalMarks.Size = new System.Drawing.Size(0, 27);
            this.totalMarks.TabIndex = 0;
            this.saaToolTip1.SetToolTip(this.totalMarks, "");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "SQL SERVER";
            this.saaToolTip1.SetToolTip(this.label11, "");
            // 
            // php
            // 
            this.php.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.php.DefaultText = "";
            this.php.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.php.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.php.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.php.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.php.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.php.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.php.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.php.Location = new System.Drawing.Point(19, 178);
            this.php.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.php.Name = "php";
            this.php.PasswordChar = '\0';
            this.php.PlaceholderText = "";
            this.php.SelectedText = "";
            this.php.Size = new System.Drawing.Size(176, 41);
            this.php.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.php, "");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "PHP";
            this.saaToolTip1.SetToolTip(this.label8, "");
            // 
            // java
            // 
            this.java.AcceptsReturn = true;
            this.java.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.java.DefaultText = "";
            this.java.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.java.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.java.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.java.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.java.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.java.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.java.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.java.Location = new System.Drawing.Point(247, 80);
            this.java.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.java.Name = "java";
            this.java.PasswordChar = '\0';
            this.java.PlaceholderText = "";
            this.java.SelectedText = "";
            this.java.Size = new System.Drawing.Size(247, 41);
            this.java.TabIndex = 1;
            this.saaToolTip1.SetToolTip(this.java, "");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Java";
            this.saaToolTip1.SetToolTip(this.label9, "");
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BorderRadius = 21;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.Enabled = false;
            this.saveBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.saveBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(11, 376);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedDepth = 40;
            this.saveBtn.Size = new System.Drawing.Size(516, 45);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save Data";
            this.saaToolTip1.SetToolTip(this.saveBtn, "Save Data");
            this.saveBtn.Click += new System.EventHandler(this.SaveData);
            // 
            // kryptonTaskDialog1
            // 
            this.kryptonTaskDialog1.CheckboxText = null;
            this.kryptonTaskDialog1.Content = null;
            this.kryptonTaskDialog1.DefaultRadioButton = null;
            this.kryptonTaskDialog1.FooterHyperlink = null;
            this.kryptonTaskDialog1.FooterText = null;
            this.kryptonTaskDialog1.MainInstruction = null;
            this.kryptonTaskDialog1.WindowTitle = null;
            // 
            // saaToast1
            // 
            this.saaToast1.AutoClose = true;
            this.saaToast1.AutoSize = true;
            this.saaToast1.BackColor = System.Drawing.Color.Green;
            this.saaToast1.BackColor2 = System.Drawing.Color.Green;
            this.saaToast1.BackColorAngle = 90F;
            this.saaToast1.BodyBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.BodyPadding = new System.Windows.Forms.Padding(0);
            this.saaToast1.BodyTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saaToast1.BodyTextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaToast1.CloseActiveImage = ((System.Drawing.Image)(resources.GetObject("saaToast1.CloseActiveImage")));
            this.saaToast1.CloseBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.CloseImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saaToast1.CloseInActiveImage = ((System.Drawing.Image)(resources.GetObject("saaToast1.CloseInActiveImage")));
            this.saaToast1.ClosePadding = new System.Windows.Forms.Padding(5);
            this.saaToast1.ClosePosition = SaaUI.RightLeftPositions.Right;
            this.saaToast1.ClosePreviousTaost = false;
            this.saaToast1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.HeaderBackColor2 = System.Drawing.Color.Transparent;
            this.saaToast1.HeaderBackColorAngle = 90F;
            this.saaToast1.HeaderPadding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.saaToast1.Icon = ((System.Drawing.Image)(resources.GetObject("saaToast1.Icon")));
            this.saaToast1.IconImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.saaToast1.IconPadding = new System.Windows.Forms.Padding(0);
            this.saaToast1.IconPosition = SaaUI.RightLeftPositions.Left;
            this.saaToast1.IntervalInMilliseconds = 15;
            this.saaToast1.LoaderBackColor = System.Drawing.Color.White;
            this.saaToast1.LoaderHeight = 3;
            this.saaToast1.LoaderPosition = SaaUI.RightLeftPositions.Left;
            this.saaToast1.LoaderVisible = true;
            this.saaToast1.MinSize = new System.Drawing.Size(10, 10);
            this.saaToast1.Movable = true;
            this.saaToast1.OffHeight = 20;
            this.saaToast1.OffsetX = 0;
            this.saaToast1.OffsetY = 0;
            this.saaToast1.OffWidth = 0;
            this.saaToast1.Padding = new System.Windows.Forms.Padding(0);
            this.saaToast1.Position = SaaUI.ToastPosition.TopRight;
            this.saaToast1.Radius.BottomLeft = 9;
            this.saaToast1.Radius.BottomRight = 9;
            this.saaToast1.Radius.TopLeft = 9;
            this.saaToast1.Radius.TopRight = 9;
            this.saaToast1.ShowBody = true;
            this.saaToast1.ShowBodyIcon = true;
            this.saaToast1.ShowCloseIcon = true;
            this.saaToast1.ShowHeader = true;
            this.saaToast1.ShowTitle = true;
            this.saaToast1.Size = new System.Drawing.Size(270, 80);
            this.saaToast1.StopOnHover = true;
            this.saaToast1.Text = "Removed Once Never Remined.";
            this.saaToast1.TitleBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.TitlePadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.saaToast1.TitleText = "User Reminder";
            this.saaToast1.TitleTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaToast1.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // saaToolTip1
            // 
            this.saaToolTip1.Active = true;
            this.saaToolTip1.ArrowHeight = 10;
            this.saaToolTip1.ArrowStart = null;
            this.saaToolTip1.ArrowWidth = 20;
            this.saaToolTip1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaToolTip1.Delay = 500;
            this.saaToolTip1.Duration = 15000;
            this.saaToolTip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saaToolTip1.OffsetX = 0;
            this.saaToolTip1.OffsetY = 0;
            this.saaToolTip1.OffSize = new System.Drawing.Size(0, 0);
            this.saaToolTip1.Position = SaaUI.SidePositions.Bottom;
            radius4.BottomLeft = 10;
            radius4.BottomRight = 10;
            radius4.TopLeft = 10;
            radius4.TopRight = 10;
            this.saaToolTip1.Radius = radius4;
            this.saaToolTip1.ShowAlways = false;
            this.saaToolTip1.ShowArrow = true;
            this.saaToolTip1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.saaToolTip1.TextOffsetX = 0;
            this.saaToolTip1.TextOffsetY = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(205, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 27);
            this.label16.TabIndex = 0;
            this.label16.Text = "VIEW DATA";
            this.saaToolTip1.SetToolTip(this.label16, "");
            // 
            // ResultsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ResultsPanel";
            this.Size = new System.Drawing.Size(1435, 742);
            this.saaToolTip1.SetToolTip(this, "");
            this.Load += new System.EventHandler(this.ResultsPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox idComboBox;
        private Guna.UI2.WinForms.Guna2TextBox currentSemester;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox studentClass;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox studentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label grade;
        private Guna.UI2.WinForms.Guna2GradientButton calcBtn;
        private Guna.UI2.WinForms.Guna2TextBox mysql;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox python;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox cSharp;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox sql;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label totalMarks;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox php;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox java;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GradientButton saveBtn;
        private SaaUI.SaaToolTip saaToolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonTaskDialog kryptonTaskDialog1;
        private SaaUI.SaaToast saaToast1;
        private System.Windows.Forms.Label label16;
    }
}
