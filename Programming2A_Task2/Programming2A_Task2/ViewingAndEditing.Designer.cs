namespace Programming2A_Task2
{
    partial class btnClearData
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rtf_Report = new System.Windows.Forms.RichTextBox();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPrecipitation = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPrecipitation = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.btnViewEdited = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grbEdit.SuspendLayout();
            this.btnEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(8, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 40);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(459, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Clear";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rtf_Report
            // 
            this.rtf_Report.Location = new System.Drawing.Point(8, 58);
            this.rtf_Report.Name = "rtf_Report";
            this.rtf_Report.Size = new System.Drawing.Size(571, 419);
            this.rtf_Report.TabIndex = 2;
            this.rtf_Report.Text = "";
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.lblCity);
            this.grbEdit.Controls.Add(this.btnSearch);
            this.grbEdit.Controls.Add(this.cmbCities);
            this.grbEdit.Location = new System.Drawing.Point(671, 58);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(341, 99);
            this.grbEdit.TabIndex = 3;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Select City using position:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(83, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City Position";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(109, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search City";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(169, 28);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(145, 21);
            this.cmbCities.TabIndex = 5;
            // 
            // btnEditor
            // 
            this.btnEditor.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditor.Location = new System.Drawing.Point(671, 418);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(110, 40);
            this.btnEditor.TabIndex = 4;
            this.btnEditor.Text = "Edit Data";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnEditData
            // 
            this.btnEditData.Controls.Add(this.dtpDate);
            this.btnEditData.Controls.Add(this.txtWind);
            this.btnEditData.Controls.Add(this.txtMax);
            this.btnEditData.Controls.Add(this.txtMin);
            this.btnEditData.Controls.Add(this.txtCity);
            this.btnEditData.Controls.Add(this.txtPrecipitation);
            this.btnEditData.Controls.Add(this.txtHumidity);
            this.btnEditData.Controls.Add(this.lblWind);
            this.btnEditData.Controls.Add(this.lblHumidity);
            this.btnEditData.Controls.Add(this.lblPrecipitation);
            this.btnEditData.Controls.Add(this.lblMax);
            this.btnEditData.Controls.Add(this.lblMin);
            this.btnEditData.Controls.Add(this.lblDate);
            this.btnEditData.Controls.Add(this.lblCityName);
            this.btnEditData.Location = new System.Drawing.Point(671, 163);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(341, 240);
            this.btnEditData.TabIndex = 5;
            this.btnEditData.TabStop = false;
            this.btnEditData.Text = "Edit Below:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(169, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(145, 20);
            this.dtpDate.TabIndex = 13;
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(169, 209);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(145, 20);
            this.txtWind.TabIndex = 12;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(169, 125);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(145, 20);
            this.txtMax.TabIndex = 11;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(169, 97);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(145, 20);
            this.txtMin.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(169, 31);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(145, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtPrecipitation
            // 
            this.txtPrecipitation.Location = new System.Drawing.Point(169, 158);
            this.txtPrecipitation.Name = "txtPrecipitation";
            this.txtPrecipitation.Size = new System.Drawing.Size(145, 20);
            this.txtPrecipitation.TabIndex = 8;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(169, 184);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(145, 20);
            this.txtHumidity.TabIndex = 7;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(55, 209);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(69, 13);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind Speed ";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(55, 184);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblPrecipitation
            // 
            this.lblPrecipitation.AutoSize = true;
            this.lblPrecipitation.Location = new System.Drawing.Point(55, 158);
            this.lblPrecipitation.Name = "lblPrecipitation";
            this.lblPrecipitation.Size = new System.Drawing.Size(65, 13);
            this.lblPrecipitation.TabIndex = 4;
            this.lblPrecipitation.Text = "Precipitation";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(55, 125);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(117, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Maximum Temperature ";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(55, 97);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(114, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimum Temperature ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(55, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(55, 31);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(24, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City";
            // 
            // btnViewEdited
            // 
            this.btnViewEdited.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEdited.Location = new System.Drawing.Point(874, 418);
            this.btnViewEdited.Name = "btnViewEdited";
            this.btnViewEdited.Size = new System.Drawing.Size(111, 40);
            this.btnViewEdited.TabIndex = 6;
            this.btnViewEdited.Text = "Clear Data";
            this.btnViewEdited.UseVisualStyleBackColor = true;
            this.btnViewEdited.Click += new System.EventHandler(this.btnViewEdited_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(924, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 40);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClearData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 483);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewEdited);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.rtf_Report);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Name = "btnClearData";
            this.Text = "ViewingAndEditing";
            this.Load += new System.EventHandler(this.ViewingAndEditing_Load);
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.btnEditData.ResumeLayout(false);
            this.btnEditData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RichTextBox rtf_Report;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.GroupBox btnEditData;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPrecipitation;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPrecipitation;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnViewEdited;
        private System.Windows.Forms.Button btnLogOut;
    }
}