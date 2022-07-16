namespace Exam_Management_System
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ManageClasses = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.userPanel = new System.Windows.Forms.Panel();
            this.accessLevel = new System.Windows.Forms.Label();
            this.currentuser = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsPanel2 = new Exam_Management_System.UI_Controller.ResultsPanel();
            this.dashboardController1 = new Exam_Management_System.UI_Controller.DashboardController();
            this.classUserControl = new Exam_Management_System.UI_Controller.Classes();
            this.studentUI = new Exam_Management_System.UI_Controller.StudentUI();
            this.resultsPanel1 = new Exam_Management_System.UI_Controller.ResultsPanel();
            this.panel1.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.guna2GradientButton3);
            this.panel1.Controls.Add(this.ManageClasses);
            this.panel1.Controls.Add(this.guna2GradientButton2);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.userPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 916);
            this.panel1.TabIndex = 0;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderRadius = 1;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Image = global::Exam_Management_System.Properties.Resources.icons8_todo_list_48px;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.Location = new System.Drawing.Point(0, 438);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(227, 45);
            this.guna2GradientButton3.TabIndex = 1;
            this.guna2GradientButton3.Text = "Results";
            this.guna2GradientButton3.Click += new System.EventHandler(this.ShowMeResults);
            // 
            // ManageClasses
            // 
            this.ManageClasses.Animated = true;
            this.ManageClasses.BorderRadius = 1;
            this.ManageClasses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageClasses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageClasses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageClasses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageClasses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageClasses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ManageClasses.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ManageClasses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageClasses.ForeColor = System.Drawing.Color.White;
            this.ManageClasses.Image = global::Exam_Management_System.Properties.Resources.icons8_todo_list_48px;
            this.ManageClasses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ManageClasses.Location = new System.Drawing.Point(0, 297);
            this.ManageClasses.Name = "ManageClasses";
            this.ManageClasses.Size = new System.Drawing.Size(227, 45);
            this.ManageClasses.TabIndex = 1;
            this.ManageClasses.Text = "CLASSES";
            this.ManageClasses.Click += new System.EventHandler(this.Manageclass);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BorderRadius = 1;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Image = global::Exam_Management_System.Properties.Resources.icons8_todo_list_48px;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.Location = new System.Drawing.Point(0, 367);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(227, 45);
            this.guna2GradientButton2.TabIndex = 1;
            this.guna2GradientButton2.Text = "STUDENTS";
            this.guna2GradientButton2.Click += new System.EventHandler(this.ViewStudents);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Image = global::Exam_Management_System.Properties.Resources.icons8_todo_list_48px;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 222);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(227, 45);
            this.guna2GradientButton1.TabIndex = 1;
            this.guna2GradientButton1.Text = "DASHBOARD";
            this.guna2GradientButton1.Click += new System.EventHandler(this.BackToTheDashBoard);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.accessLevel);
            this.userPanel.Controls.Add(this.currentuser);
            this.userPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.userPanel.Location = new System.Drawing.Point(8, 9);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(212, 185);
            this.userPanel.TabIndex = 0;
            // 
            // accessLevel
            // 
            this.accessLevel.AutoSize = true;
            this.accessLevel.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLevel.ForeColor = System.Drawing.Color.Orange;
            this.accessLevel.Location = new System.Drawing.Point(49, 144);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(66, 24);
            this.accessLevel.TabIndex = 0;
            this.accessLevel.Text = "LEVEL";
            // 
            // currentuser
            // 
            this.currentuser.AutoSize = true;
            this.currentuser.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentuser.ForeColor = System.Drawing.Color.White;
            this.currentuser.Location = new System.Drawing.Point(48, 118);
            this.currentuser.Name = "currentuser";
            this.currentuser.Size = new System.Drawing.Size(123, 36);
            this.currentuser.TabIndex = 0;
            this.currentuser.Text = "USERNAME";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Exam_Management_System.Properties.Resources.user_male;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(45, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(112, 107);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.closeIcon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 74);
            this.panel2.TabIndex = 1;
            // 
            // closeIcon
            // 
            this.closeIcon.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = global::Exam_Management_System.Properties.Resources.icons8_Close_48px;
            this.closeIcon.Location = new System.Drawing.Point(1846, 4);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(84, 58);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeIcon.TabIndex = 1;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.Close);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(117, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "EXAM MANAGEMNT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "JAMHUURIYA UNIVERSITY OF SCEINCE AND TECHNOLOGY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Exam_Management_System.Properties.Resources.icons8_approval_48px;
            this.pictureBox1.Location = new System.Drawing.Point(19, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // resultsPanel2
            // 
            this.resultsPanel2.BackColor = System.Drawing.Color.White;
            this.resultsPanel2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.resultsPanel2.Location = new System.Drawing.Point(226, 73);
            this.resultsPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.resultsPanel2.Name = "resultsPanel2";
            this.resultsPanel2.Size = new System.Drawing.Size(1435, 742);
            this.resultsPanel2.TabIndex = 2;
            // 
            // dashboardController1
            // 
            this.dashboardController1.BackColor = System.Drawing.Color.White;
            this.dashboardController1.Location = new System.Drawing.Point(227, 74);
            this.dashboardController1.Name = "dashboardController1";
            this.dashboardController1.Size = new System.Drawing.Size(1168, 786);
            this.dashboardController1.TabIndex = 5;
            // 
            // classUserControl
            // 
            this.classUserControl.BackColor = System.Drawing.Color.White;
            this.classUserControl.Location = new System.Drawing.Point(227, 74);
            this.classUserControl.Name = "classUserControl";
            this.classUserControl.Size = new System.Drawing.Size(1244, 786);
            this.classUserControl.TabIndex = 3;
            this.classUserControl.Visible = false;
            // 
            // studentUI
            // 
            this.studentUI.BackColor = System.Drawing.Color.White;
            this.studentUI.Location = new System.Drawing.Point(227, 74);
            this.studentUI.Name = "studentUI";
            this.studentUI.Size = new System.Drawing.Size(1248, 786);
            this.studentUI.TabIndex = 4;
            this.studentUI.Visible = false;
            // 
            // resultsPanel1
            // 
            this.resultsPanel1.BackColor = System.Drawing.Color.White;
            this.resultsPanel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.resultsPanel1.Location = new System.Drawing.Point(228, 74);
            this.resultsPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.resultsPanel1.Name = "resultsPanel1";
            this.resultsPanel1.Size = new System.Drawing.Size(1172, 742);
            this.resultsPanel1.TabIndex = 6;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 990);
            this.Controls.Add(this.resultsPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label accessLevel;
        private System.Windows.Forms.Label currentuser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton ManageClasses;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private UI_Controller.Classes classUserControl;
        private UI_Controller.StudentUI studentUI;
        private UI_Controller.DashboardController dashboardController1;
        private UI_Controller.ResultsPanel resultsPanel1;
        private UI_Controller.ResultsPanel resultsPanel2;
    }
}

