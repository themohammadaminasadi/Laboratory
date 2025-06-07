namespace Laboratory
{
    partial class frmResultTest
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
            this.DGVTestHeader = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestHederID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHederDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFullNamePaitent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPaitentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAddResult = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.ClmnEditDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnAddDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.btnEditResult = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTestHeader
            // 
            this.DGVTestHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.DGVTestHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTestHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestHederID,
            this.ClmnHederDate,
            this.ClmnFullNamePaitent,
            this.ClmnPaitentID,
            this.ClmnDrName,
            this.ClmnNationalCode,
            this.ClmnAge,
            this.ClmnAddResult});
            this.DGVTestHeader.Location = new System.Drawing.Point(412, 2);
            this.DGVTestHeader.Name = "DGVTestHeader";
            this.DGVTestHeader.RowHeadersWidth = 51;
            this.DGVTestHeader.Size = new System.Drawing.Size(917, 218);
            this.DGVTestHeader.TabIndex = 0;
            this.DGVTestHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTestHeader_CellContentClick);
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
            // ClmnAddResult
            // 
            this.ClmnAddResult.DataPropertyName = "AddResult";
            this.ClmnAddResult.HeaderText = "ثبت جواب";
            this.ClmnAddResult.MinimumWidth = 6;
            this.ClmnAddResult.Name = "ClmnAddResult";
            this.ClmnAddResult.Text = "ثبت جواب";
            this.ClmnAddResult.UseColumnTextForButtonValue = true;
            this.ClmnAddResult.Width = 125;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(320, 428);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(183, 31);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResultTitle.Location = new System.Drawing.Point(266, 429);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(45, 30);
            this.lblResultTitle.TabIndex = 4;
            this.lblResultTitle.Text = "نتبجه";
            // 
            // btnAddResult
            // 
            this.btnAddResult.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddResult.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddResult.Location = new System.Drawing.Point(97, 520);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(173, 46);
            this.btnAddResult.TabIndex = 5;
            this.btnAddResult.Text = "ثبت نتیجه";
            this.btnAddResult.UseVisualStyleBackColor = false;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTestTitle.Location = new System.Drawing.Point(10, 424);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(61, 30);
            this.lblTestTitle.TabIndex = 7;
            this.lblTestTitle.Text = "آزمایش";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(97, 426);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(146, 31);
            this.txtTestName.TabIndex = 6;
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 24;
            this.lstPatient.Location = new System.Drawing.Point(117, 58);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(236, 172);
            this.lstPatient.TabIndex = 8;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "بیمار";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(117, 28);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(236, 31);
            this.txtSearchPatient.TabIndex = 10;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // ClmnEditDetailsTest
            // 
            this.ClmnEditDetailsTest.HeaderText = "ویرایش نتیجه";
            this.ClmnEditDetailsTest.MinimumWidth = 6;
            this.ClmnEditDetailsTest.Name = "ClmnEditDetailsTest";
            this.ClmnEditDetailsTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnEditDetailsTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnEditDetailsTest.Text = "ویرایش نتیجه";
            this.ClmnEditDetailsTest.UseColumnTextForButtonValue = true;
            this.ClmnEditDetailsTest.Width = 125;
            // 
            // ClmnAddDetailsTest
            // 
            this.ClmnAddDetailsTest.HeaderText = "ثبت جواب";
            this.ClmnAddDetailsTest.MinimumWidth = 6;
            this.ClmnAddDetailsTest.Name = "ClmnAddDetailsTest";
            this.ClmnAddDetailsTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnAddDetailsTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnAddDetailsTest.Text = "ثبت جواب";
            this.ClmnAddDetailsTest.UseColumnTextForButtonValue = true;
            this.ClmnAddDetailsTest.Width = 125;
            // 
            // ClmnHasStar
            // 
            this.ClmnHasStar.DataPropertyName = "HasStar";
            this.ClmnHasStar.HeaderText = "خطرناک";
            this.ClmnHasStar.MinimumWidth = 6;
            this.ClmnHasStar.Name = "ClmnHasStar";
            this.ClmnHasStar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnHasStar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnHasStar.Width = 125;
            // 
            // ClmnResult
            // 
            this.ClmnResult.DataPropertyName = "Result";
            this.ClmnResult.HeaderText = "ثبت نتیجه";
            this.ClmnResult.MinimumWidth = 6;
            this.ClmnResult.Name = "ClmnResult";
            this.ClmnResult.Width = 125;
            // 
            // ClmnTestName
            // 
            this.ClmnTestName.DataPropertyName = "TestName";
            this.ClmnTestName.HeaderText = "آزمایش";
            this.ClmnTestName.MinimumWidth = 6;
            this.ClmnTestName.Name = "ClmnTestName";
            this.ClmnTestName.Width = 125;
            // 
            // ClmnTestID
            // 
            this.ClmnTestID.DataPropertyName = "TestID";
            this.ClmnTestID.HeaderText = "شناسه آزمایش";
            this.ClmnTestID.MinimumWidth = 6;
            this.ClmnTestID.Name = "ClmnTestID";
            this.ClmnTestID.Visible = false;
            this.ClmnTestID.Width = 120;
            // 
            // ClmnPatientTestDetailsID
            // 
            this.ClmnPatientTestDetailsID.DataPropertyName = "PatientTestDetailsID";
            this.ClmnPatientTestDetailsID.HeaderText = "شناسه جزیئات آزمایش";
            this.ClmnPatientTestDetailsID.MinimumWidth = 6;
            this.ClmnPatientTestDetailsID.Name = "ClmnPatientTestDetailsID";
            this.ClmnPatientTestDetailsID.Width = 150;
            // 
            // DGVDetails
            // 
            this.DGVDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.DGVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestDetailsID,
            this.ClmnTestID,
            this.ClmnTestName,
            this.ClmnResult,
            this.ClmnHasStar,
            this.ClmnAddDetailsTest,
            this.ClmnEditDetailsTest});
            this.DGVDetails.Location = new System.Drawing.Point(515, 220);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.RowHeadersWidth = 51;
            this.DGVDetails.Size = new System.Drawing.Size(814, 191);
            this.DGVDetails.TabIndex = 1;
            this.DGVDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetails_CellContentClick);
            // 
            // btnEditResult
            // 
            this.btnEditResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditResult.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditResult.Location = new System.Drawing.Point(97, 520);
            this.btnEditResult.Name = "btnEditResult";
            this.btnEditResult.Size = new System.Drawing.Size(173, 46);
            this.btnEditResult.TabIndex = 11;
            this.btnEditResult.Text = "ویرایش نتیجه آزمایش";
            this.btnEditResult.UseVisualStyleBackColor = false;
            this.btnEditResult.Click += new System.EventHandler(this.btnEditResult_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancle.Location = new System.Drawing.Point(320, 520);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(144, 46);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "انصراف";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1328, 601);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEditResult);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.DGVDetails);
            this.Controls.Add(this.DGVTestHeader);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmResultTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت نتیجه ی آزمایشات";
            this.Load += new System.EventHandler(this.frmResultTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTestHeader;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnHederDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFullNamePaitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPaitentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAddResult;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditDetailsTest;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAddDetailsTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnHasStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.Button btnEditResult;
        private System.Windows.Forms.Button btnCancle;
    }
}