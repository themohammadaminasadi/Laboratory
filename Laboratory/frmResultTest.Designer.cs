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
            this.ClmnEditResult = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnAddDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnEditDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTestHeader
            // 
            this.DGVTestHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTestHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestHederID,
            this.ClmnHederDate,
            this.ClmnFullNamePaitent,
            this.ClmnPaitentID,
            this.ClmnDrName,
            this.ClmnNationalCode,
            this.ClmnAge,
            this.ClmnAddResult,
            this.ClmnEditResult});
            this.DGVTestHeader.Location = new System.Drawing.Point(404, 2);
            this.DGVTestHeader.Name = "DGVTestHeader";
            this.DGVTestHeader.RowHeadersWidth = 51;
            this.DGVTestHeader.Size = new System.Drawing.Size(925, 218);
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
            // ClmnEditResult
            // 
            this.ClmnEditResult.DataPropertyName = "EditResult";
            this.ClmnEditResult.HeaderText = "ویرایش نتیجه آزمایش";
            this.ClmnEditResult.MinimumWidth = 6;
            this.ClmnEditResult.Name = "ClmnEditResult";
            this.ClmnEditResult.Text = "ویرایش نتیجه آزمایش";
            this.ClmnEditResult.UseColumnTextForButtonValue = true;
            this.ClmnEditResult.Width = 130;
            // 
            // DGVDetails
            // 
            this.DGVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestDetailsID,
            this.ClmnTestID,
            this.ClmnTestName,
            this.ClmnResult,
            this.ClmnHasStar,
            this.ClmnAddDetailsTest,
            this.ClmnEditDetailsTest});
            this.DGVDetails.Location = new System.Drawing.Point(624, 220);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.RowHeadersWidth = 51;
            this.DGVDetails.Size = new System.Drawing.Size(692, 191);
            this.DGVDetails.TabIndex = 1;
            this.DGVDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetails_CellContentClick);
            // 
            // ClmnPatientTestDetailsID
            // 
            this.ClmnPatientTestDetailsID.DataPropertyName = "PatientTestDetailsID";
            this.ClmnPatientTestDetailsID.HeaderText = "شناسه جزیئات آزمایش";
            this.ClmnPatientTestDetailsID.MinimumWidth = 6;
            this.ClmnPatientTestDetailsID.Name = "ClmnPatientTestDetailsID";
            this.ClmnPatientTestDetailsID.Width = 150;
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
            // ClmnTestName
            // 
            this.ClmnTestName.DataPropertyName = "TestName";
            this.ClmnTestName.HeaderText = "آزمایش";
            this.ClmnTestName.MinimumWidth = 6;
            this.ClmnTestName.Name = "ClmnTestName";
            this.ClmnTestName.Width = 125;
            // 
            // ClmnResult
            // 
            this.ClmnResult.DataPropertyName = "Result";
            this.ClmnResult.HeaderText = "ثبت نتیجه";
            this.ClmnResult.MinimumWidth = 6;
            this.ClmnResult.Name = "ClmnResult";
            this.ClmnResult.Width = 125;
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
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(326, 286);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(183, 37);
            this.txtResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(272, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "نتبجه";
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(109, 377);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(220, 46);
            this.btnAddResult.TabIndex = 5;
            this.btnAddResult.Text = "ثبت نتیجه";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(16, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "آزمایش";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(103, 284);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(146, 37);
            this.txtTestName.TabIndex = 6;
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 29;
            this.lstPatient.Location = new System.Drawing.Point(117, 64);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(236, 178);
            this.lstPatient.TabIndex = 8;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "بیمار";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(117, 28);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(236, 37);
            this.txtSearchPatient.TabIndex = 10;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // frmResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1328, 601);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnHederDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFullNamePaitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPaitentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAddResult;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditResult;
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAddDetailsTest;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditDetailsTest;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchPatient;
    }
}