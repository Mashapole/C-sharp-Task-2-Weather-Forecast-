namespace Programming2A_Task2
{
    partial class Report_For_Cities
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
            this.grpSpecifying = new System.Windows.Forms.GroupBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.lsbCities = new System.Windows.Forms.ListBox();
            this.grpViewReport = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.rtbFinalREport = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbSearchDate = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btndisplay = new System.Windows.Forms.Button();
            this.grpSpecifying.SuspendLayout();
            this.grpViewReport.SuspendLayout();
            this.grbSearchDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpecifying
            // 
            this.grpSpecifying.Controls.Add(this.lblCities);
            this.grpSpecifying.Controls.Add(this.lsbCities);
            this.grpSpecifying.Controls.Add(this.btnSave);
            this.grpSpecifying.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSpecifying.Location = new System.Drawing.Point(26, 34);
            this.grpSpecifying.Name = "grpSpecifying";
            this.grpSpecifying.Size = new System.Drawing.Size(422, 200);
            this.grpSpecifying.TabIndex = 0;
            this.grpSpecifying.TabStop = false;
            this.grpSpecifying.Text = "Specify cities that they regularly want to view weather forecasts for:";
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(44, 45);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(129, 15);
            this.lblCities.TabIndex = 1;
            this.lblCities.Text = "Choose Citie or Cities: ";
            // 
            // lsbCities
            // 
            this.lsbCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCities.FormattingEnabled = true;
            this.lsbCities.Location = new System.Drawing.Point(200, 45);
            this.lsbCities.Name = "lsbCities";
            this.lsbCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbCities.Size = new System.Drawing.Size(164, 95);
            this.lsbCities.TabIndex = 0;
            this.lsbCities.SelectedIndexChanged += new System.EventHandler(this.lsbCities_SelectedIndexChanged);
            // 
            // grpViewReport
            // 
            this.grpViewReport.Controls.Add(this.btnView);
            this.grpViewReport.Controls.Add(this.rtbFinalREport);
            this.grpViewReport.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewReport.Location = new System.Drawing.Point(467, 34);
            this.grpViewReport.Name = "grpViewReport";
            this.grpViewReport.Size = new System.Drawing.Size(503, 433);
            this.grpViewReport.TabIndex = 1;
            this.grpViewReport.TabStop = false;
            this.grpViewReport.Text = "View weather forecasts for the specified cities";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(55, 45);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(374, 43);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Report For Specified Cities";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // rtbFinalREport
            // 
            this.rtbFinalREport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFinalREport.Location = new System.Drawing.Point(6, 94);
            this.rtbFinalREport.Name = "rtbFinalREport";
            this.rtbFinalREport.Size = new System.Drawing.Size(491, 333);
            this.rtbFinalREport.TabIndex = 0;
            this.rtbFinalREport.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Specify  as favourite ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(28, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(522, 473);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(95, 36);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(804, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clera Field";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbSearchDate
            // 
            this.grbSearchDate.Controls.Add(this.btndisplay);
            this.grbSearchDate.Controls.Add(this.dtpEndDate);
            this.grbSearchDate.Controls.Add(this.dtpStartDate);
            this.grbSearchDate.Controls.Add(this.lblStart);
            this.grbSearchDate.Controls.Add(this.lblEndDate);
            this.grbSearchDate.Location = new System.Drawing.Point(26, 265);
            this.grbSearchDate.Name = "grbSearchDate";
            this.grbSearchDate.Size = new System.Drawing.Size(422, 182);
            this.grbSearchDate.TabIndex = 6;
            this.grbSearchDate.TabStop = false;
            this.grbSearchDate.Text = "Search by Date Range:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(105, 97);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(105, 58);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(200, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(164, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(200, 91);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(164, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(200, 130);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(164, 34);
            this.btndisplay.TabIndex = 4;
            this.btndisplay.Text = "Display by Date";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // Report_For_Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 517);
            this.Controls.Add(this.grbSearchDate);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpViewReport);
            this.Controls.Add(this.grpSpecifying);
            this.Name = "Report_For_Cities";
            this.Text = "Report_For_Cities";
            this.Load += new System.EventHandler(this.Report_For_Cities_Load);
            this.grpSpecifying.ResumeLayout(false);
            this.grpSpecifying.PerformLayout();
            this.grpViewReport.ResumeLayout(false);
            this.grbSearchDate.ResumeLayout(false);
            this.grbSearchDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSpecifying;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.ListBox lsbCities;
        private System.Windows.Forms.GroupBox grpViewReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RichTextBox rtbFinalREport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbSearchDate;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEndDate;
    }
}