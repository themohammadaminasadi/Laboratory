namespace Laboratory
{
    partial class frmEditResultTest
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
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMobile = new System.Windows.Forms.Label();
            this.lblErrorNationalCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVPatientTestHeader = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestHederID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHederDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFullNamePaitent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPaitentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEditResult = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientTestHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(107, 315);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.Size = new System.Drawing.Size(200, 20);
            this.faDatePicker.TabIndex = 67;
            this.faDatePicker.SelectedDateTimeChanged += new System.EventHandler(this.faDatePicker_SelectedDateTimeChanged);
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 24;
            this.lstPatient.Location = new System.Drawing.Point(94, 85);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstPatient.Size = new System.Drawing.Size(200, 172);
            this.lstPatient.TabIndex = 66;
            this.lstPatient.DoubleClick += new System.EventHandler(this.lstPatient_DoubleClick);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(94, 55);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatient.Size = new System.Drawing.Size(200, 31);
            this.txtPatient.TabIndex = 65;
            this.txtPatient.TextChanged += new System.EventHandler(this.txtPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "بیمار";
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobile.Location = new System.Drawing.Point(764, 393);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMobile.TabIndex = 63;
            // 
            // lblErrorNationalCode
            // 
            this.lblErrorNationalCode.AutoSize = true;
            this.lblErrorNationalCode.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorNationalCode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNationalCode.Location = new System.Drawing.Point(765, 317);
            this.lblErrorNationalCode.Name = "lblErrorNationalCode";
            this.lblErrorNationalCode.Size = new System.Drawing.Size(0, 19);
            this.lblErrorNationalCode.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(34, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "تاریخ";
            // 
            // DGVPatientTestHeader
            // 
            this.DGVPatientTestHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatientTestHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestHederID,
            this.ClmnHederDate,
            this.ClmnFullNamePaitent,
            this.ClmnPaitentID,
            this.ClmnDrName,
            this.ClmnNationalCode,
            this.ClmnAge,
            this.ClmnEditResult});
            this.DGVPatientTestHeader.Location = new System.Drawing.Point(406, 39);
            this.DGVPatientTestHeader.Name = "DGVPatientTestHeader";
            this.DGVPatientTestHeader.RowHeadersWidth = 51;
            this.DGVPatientTestHeader.Size = new System.Drawing.Size(920, 218);
            this.DGVPatientTestHeader.TabIndex = 69;
            // 
            // ClmnPatientTestHederID
            // 
            this.ClmnPatientTestHederID.DataPropertyName = "PatientTestHederID";
            this.ClmnPatientTestHederID.HeaderText = "شناسه آزمایش";
            this.ClmnPatientTestHederID.MinimumWidth = 6;
            this.ClmnPatientTestHederID.Name = "ClmnPatientTestHederID";
            this.ClmnPatientTestHederID.Width = 120;
            // 
            // ClmnHederDate
            // 
            this.ClmnHederDate.DataPropertyName = "HederDate";
            this.ClmnHederDate.HeaderText = "تاریخ آزمایش";
            this.ClmnHederDate.MinimumWidth = 6;
            this.ClmnHederDate.Name = "ClmnHederDate";
            this.ClmnHederDate.Width = 120;
            // 
            // ClmnFullNamePaitent
            // 
            this.ClmnFullNamePaitent.DataPropertyName = "FullNamePaitent";
            this.ClmnFullNamePaitent.HeaderText = "بیمار";
            this.ClmnFullNamePaitent.MinimumWidth = 6;
            this.ClmnFullNamePaitent.Name = "ClmnFullNamePaitent";
            this.ClmnFullNamePaitent.Width = 125;
            // 
            // ClmnPaitentID
            // 
            this.ClmnPaitentID.DataPropertyName = "PaitentID";
            this.ClmnPaitentID.HeaderText = "شناسه بیمار";
            this.ClmnPaitentID.MinimumWidth = 6;
            this.ClmnPaitentID.Name = "ClmnPaitentID";
            this.ClmnPaitentID.Visible = false;
            this.ClmnPaitentID.Width = 125;
            // 
            // ClmnDrName
            // 
            this.ClmnDrName.DataPropertyName = "DrName";
            this.ClmnDrName.HeaderText = "نام دکتر";
            this.ClmnDrName.MinimumWidth = 6;
            this.ClmnDrName.Name = "ClmnDrName";
            this.ClmnDrName.Width = 125;
            // 
            // ClmnNationalCode
            // 
            this.ClmnNationalCode.DataPropertyName = "NationalCode";
            this.ClmnNationalCode.HeaderText = "کد ملی بیمار";
            this.ClmnNationalCode.MinimumWidth = 6;
            this.ClmnNationalCode.Name = "ClmnNationalCode";
            this.ClmnNationalCode.Width = 125;
            // 
            // ClmnAge
            // 
            this.ClmnAge.DataPropertyName = "Age";
            this.ClmnAge.HeaderText = "سن بیمار";
            this.ClmnAge.MinimumWidth = 6;
            this.ClmnAge.Name = "ClmnAge";
            this.ClmnAge.Width = 125;
            // 
            // ClmnEditResult
            // 
            this.ClmnEditResult.DataPropertyName = "EditResult";
            this.ClmnEditResult.HeaderText = "ویرایش جواب";
            this.ClmnEditResult.MinimumWidth = 6;
            this.ClmnEditResult.Name = "ClmnEditResult";
            this.ClmnEditResult.Text = "ویرایش جواب";
            this.ClmnEditResult.UseColumnTextForButtonValue = true;
            this.ClmnEditResult.Width = 125;
            // 
            // frmEditResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1326, 690);
            this.Controls.Add(this.DGVPatientTestHeader);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorNationalCode);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEditResultTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "EditResultTest";
            this.Load += new System.EventHandler(this.frmEditResultTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientTestHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMobile;
        private System.Windows.Forms.Label lblErrorNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVPatientTestHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnHederDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFullNamePaitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPaitentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditResult;
    }
}