namespace ReadXML
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdReadXML = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.txtPathSearch = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpLastLoginDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReadXML
            // 
            this.cmdReadXML.Location = new System.Drawing.Point(1106, 14);
            this.cmdReadXML.Name = "cmdReadXML";
            this.cmdReadXML.Size = new System.Drawing.Size(75, 23);
            this.cmdReadXML.TabIndex = 9;
            this.cmdReadXML.Text = "Read XML";
            this.cmdReadXML.UseVisualStyleBackColor = true;
            this.cmdReadXML.Click += new System.EventHandler(this.CmdReadXML_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(13, 77);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1177, 404);
            this.dgvReport.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(171, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(461, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "D:\\ftpUsers";
            // 
            // cmdStart
            // 
            this.cmdStart.BackgroundImage = global::ReadXML.Properties.Resources.Clean;
            this.cmdStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdStart.FlatAppearance.BorderSize = 0;
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Location = new System.Drawing.Point(675, 11);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(30, 23);
            this.cmdStart.TabIndex = 2;
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackgroundImage = global::ReadXML.Properties.Resources.Bworse;
            this.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSearch.FlatAppearance.BorderSize = 0;
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.Location = new System.Drawing.Point(638, 11);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(30, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCount
            // 
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(43, 17);
            this.tsslCount.Text = "Count:";
            // 
            // cmdExportExcel
            // 
            this.cmdExportExcel.Location = new System.Drawing.Point(1070, 500);
            this.cmdExportExcel.Name = "cmdExportExcel";
            this.cmdExportExcel.Size = new System.Drawing.Size(120, 23);
            this.cmdExportExcel.TabIndex = 10;
            this.cmdExportExcel.Text = "Export XLS All Items";
            this.cmdExportExcel.UseVisualStyleBackColor = true;
            this.cmdExportExcel.Click += new System.EventHandler(this.CmdExportExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "UserName";
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(543, 46);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(94, 21);
            this.cbUserName.TabIndex = 5;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.CbUserName_SelectedIndexChanged);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(1106, 46);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 8;
            this.cmdRefresh.Text = "Filter";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.CmdRefresh_Click);
            // 
            // txtPathSearch
            // 
            this.txtPathSearch.Location = new System.Drawing.Point(46, 46);
            this.txtPathSearch.Name = "txtPathSearch";
            this.txtPathSearch.Size = new System.Drawing.Size(255, 20);
            this.txtPathSearch.TabIndex = 3;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(342, 46);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(138, 20);
            this.txtAlias.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login Count";
            // 
            // txtLoginCount
            // 
            this.txtLoginCount.Location = new System.Drawing.Point(713, 46);
            this.txtLoginCount.Name = "txtLoginCount";
            this.txtLoginCount.Size = new System.Drawing.Size(50, 20);
            this.txtLoginCount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Login Date>";
            // 
            // dtpLastLoginDate
            // 
            this.dtpLastLoginDate.Location = new System.Drawing.Point(873, 46);
            this.dtpLastLoginDate.Name = "dtpLastLoginDate";
            this.dtpLastLoginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastLoginDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Folder of Users accounts";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 548);
            this.Controls.Add(this.dtpLastLoginDate);
            this.Controls.Add(this.txtLoginCount);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtPathSearch);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cbUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExportExcel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.cmdReadXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View WingFTP Users";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReadXML;
        public System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
        private System.Windows.Forms.Button cmdExportExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.TextBox txtPathSearch;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpLastLoginDate;
        private System.Windows.Forms.Label label6;
    }
}

