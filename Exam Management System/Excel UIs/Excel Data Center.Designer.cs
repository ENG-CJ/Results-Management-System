namespace Exam_Management_System.Excel_UIs
{
    partial class Excel_Data_Center
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fromExcel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openexcelFile = new System.Windows.Forms.OpenFileDialog();
            this.analysProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.saaButton1 = new SaaUI.SaaButton();
            this.displayAnalys = new System.Windows.Forms.Label();
            this.AnalysTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fromExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // fromExcel
            // 
            this.fromExcel.AllowUserToAddRows = false;
            this.fromExcel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.fromExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.fromExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fromExcel.BackgroundColor = System.Drawing.Color.White;
            this.fromExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fromExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fromExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.fromExcel.ColumnHeadersHeight = 27;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fromExcel.DefaultCellStyle = dataGridViewCellStyle12;
            this.fromExcel.EnableHeadersVisualStyles = false;
            this.fromExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fromExcel.Location = new System.Drawing.Point(-2, -1);
            this.fromExcel.Name = "fromExcel";
            this.fromExcel.ReadOnly = true;
            this.fromExcel.RowHeadersVisible = false;
            this.fromExcel.RowHeadersWidth = 51;
            this.fromExcel.RowTemplate.Height = 24;
            this.fromExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fromExcel.Size = new System.Drawing.Size(571, 411);
            this.fromExcel.TabIndex = 0;
            this.fromExcel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.fromExcel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.fromExcel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.fromExcel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.fromExcel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.fromExcel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.fromExcel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fromExcel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fromExcel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fromExcel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fromExcel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.fromExcel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.fromExcel.ThemeStyle.HeaderStyle.Height = 27;
            this.fromExcel.ThemeStyle.ReadOnly = true;
            this.fromExcel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.fromExcel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fromExcel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fromExcel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.fromExcel.ThemeStyle.RowsStyle.Height = 24;
            this.fromExcel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fromExcel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // openexcelFile
            // 
            this.openexcelFile.Filter = "Excel Files|*.xslsx";
            this.openexcelFile.InitialDirectory = "E:\\CSharp Projects";
            this.openexcelFile.Title = "Open Excel Files";
            // 
            // analysProgress
            // 
            this.analysProgress.FillColor = System.Drawing.Color.White;
            this.analysProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysProgress.ForeColor = System.Drawing.Color.White;
            this.analysProgress.Location = new System.Drawing.Point(-2, 531);
            this.analysProgress.Name = "analysProgress";
            this.analysProgress.ProgressColor = System.Drawing.Color.ForestGreen;
            this.analysProgress.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.analysProgress.Size = new System.Drawing.Size(571, 28);
            this.analysProgress.TabIndex = 2;
            this.analysProgress.Text = "guna2ProgressBar1";
            this.analysProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // saaButton1
            // 
            this.saaButton1.BackColor = System.Drawing.Color.Green;
            this.saaButton1.BackColor2 = System.Drawing.Color.Green;
            this.saaButton1.BackColorAngle = 90F;
            this.saaButton1.Border = 1;
            this.saaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.BorderColorAngle = 0;
            this.saaButton1.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.EnableDoubleBuffering = true;
            this.saaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaButton1.ForeColor = System.Drawing.Color.White;
            this.saaButton1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton1.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.Icon = null;
            this.saaButton1.IconOffsetX = 5F;
            this.saaButton1.IconOffsetY = 5F;
            this.saaButton1.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton1.Location = new System.Drawing.Point(4, 439);
            this.saaButton1.Name = "saaButton1";
            this.saaButton1.Radius.BottomLeft = 2;
            this.saaButton1.Radius.BottomRight = 2;
            this.saaButton1.Radius.TopLeft = 2;
            this.saaButton1.Radius.TopRight = 2;
            this.saaButton1.Size = new System.Drawing.Size(122, 49);
            this.saaButton1.TabIndex = 3;
            this.saaButton1.TextOffsetX = 0F;
            this.saaButton1.TextOffsetY = 0F;
            this.saaButton1.Value = "Save";
            this.saaButton1.Click += new System.EventHandler(this.Save);
            // 
            // displayAnalys
            // 
            this.displayAnalys.AutoSize = true;
            this.displayAnalys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAnalys.ForeColor = System.Drawing.Color.DarkGray;
            this.displayAnalys.Location = new System.Drawing.Point(6, 492);
            this.displayAnalys.Name = "displayAnalys";
            this.displayAnalys.Size = new System.Drawing.Size(24, 20);
            this.displayAnalys.TabIndex = 4;
            this.displayAnalys.Text = "...";
            // 
            // AnalysTimer
            // 
            this.AnalysTimer.Tick += new System.EventHandler(this.AnalysTimer_Tick);
            // 
            // Excel_Data_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 559);
            this.Controls.Add(this.saaButton1);
            this.Controls.Add(this.analysProgress);
            this.Controls.Add(this.fromExcel);
            this.Controls.Add(this.displayAnalys);
            this.MaximizeBox = false;
            this.Name = "Excel_Data_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel_Data_Center";
            this.Load += new System.EventHandler(this.Excel_Data_Center_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView fromExcel;
        private System.Windows.Forms.OpenFileDialog openexcelFile;
        private Guna.UI2.WinForms.Guna2ProgressBar analysProgress;
        private SaaUI.SaaButton saaButton1;
        private System.Windows.Forms.Label displayAnalys;
        private System.Windows.Forms.Timer AnalysTimer;
    }
}