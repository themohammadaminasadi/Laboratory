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
            this.ClmnShowReslutDestailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnAddDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDeletePatientTestDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnEditDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEditResult = new System.Windows.Forms.Button();
            this.lblTestName = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientTestHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(107, 315);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.Size = new System.Drawing.Size(244, 20);
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
            this.lstPatient.Size = new System.Drawing.Size(257, 172);
            this.lstPatient.TabIndex = 66;
            this.lstPatient.DoubleClick += new System.EventHandler(this.lstPatient_DoubleClick);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(94, 55);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatient.Size = new System.Drawing.Size(257, 31);
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
            this.DGVPatientTestHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.DGVPatientTestHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatientTestHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestHederID,
            this.ClmnHederDate,
            this.ClmnFullNamePaitent,
            this.ClmnPaitentID,
            this.ClmnDrName,
            this.ClmnNationalCode,
            this.ClmnAge,
            this.ClmnShowReslutDestailsTest});
            this.DGVPatientTestHeader.Location = new System.Drawing.Point(403, 85);
            this.DGVPatientTestHeader.Name = "DGVPatientTestHeader";
            this.DGVPatientTestHeader.RowHeadersWidth = 51;
            this.DGVPatientTestHeader.Size = new System.Drawing.Size(920, 218);
            this.DGVPatientTestHeader.TabIndex = 69;
            this.DGVPatientTestHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatientTestHeader_CellContentClick);
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
            // ClmnShowReslutDestailsTest
            // 
            this.ClmnShowReslutDestailsTest.DataPropertyName = "ShowReslutDestailsTest";
            this.ClmnShowReslutDestailsTest.HeaderText = "مشاهده جزئیات";
            this.ClmnShowReslutDestailsTest.MinimumWidth = 6;
            this.ClmnShowReslutDestailsTest.Name = "ClmnShowReslutDestailsTest";
            this.ClmnShowReslutDestailsTest.Text = "مشاهده جزئیات";
            this.ClmnShowReslutDestailsTest.UseColumnTextForButtonValue = true;
            this.ClmnShowReslutDestailsTest.Width = 125;
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
            this.ClmnDeletePatientTestDetails,
            this.ClmnEditDetailsTest});
            this.DGVDetails.Location = new System.Drawing.Point(403, 303);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.RowHeadersWidth = 51;
            this.DGVDetails.Size = new System.Drawing.Size(920, 191);
            this.DGVDetails.TabIndex = 70;
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
            this.ClmnResult.HeaderText = "نتیجه";
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
            // ClmnDeletePatientTestDetails
            // 
            this.ClmnDeletePatientTestDetails.DataPropertyName = "DeletePatientTestDetails";
            this.ClmnDeletePatientTestDetails.HeaderText = "حذف";
            this.ClmnDeletePatientTestDetails.Name = "ClmnDeletePatientTestDetails";
            this.ClmnDeletePatientTestDetails.Text = "حذف";
            this.ClmnDeletePatientTestDetails.UseColumnTextForButtonValue = true;
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
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancle.Location = new System.Drawing.Point(226, 536);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(142, 46);
            this.btnCancle.TabIndex = 77;
            this.btnCancle.Text = "انصراف";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEditResult
            // 
            this.btnEditResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditResult.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditResult.Location = new System.Drawing.Point(39, 536);
            this.btnEditResult.Name = "btnEditResult";
            this.btnEditResult.Size = new System.Drawing.Size(151, 46);
            this.btnEditResult.TabIndex = 76;
            this.btnEditResult.Text = "ویرایش نتیجه آزمایش";
            this.btnEditResult.UseVisualStyleBackColor = false;
            this.btnEditResult.Click += new System.EventHandler(this.btnEditResult_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTestName.Location = new System.Drawing.Point(39, 409);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(61, 30);
            this.lblTestName.TabIndex = 75;
            this.lblTestName.Text = "آزمایش";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(126, 411);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(225, 31);
            this.txtTestName.TabIndex = 74;
            // 
            // btnAddResult
            // 
            this.btnAddResult.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddResult.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddResult.Location = new System.Drawing.Point(39, 536);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(151, 46);
            this.btnAddResult.TabIndex = 73;
            this.btnAddResult.Text = "ثبت نتیجه";
            this.btnAddResult.UseVisualStyleBackColor = false;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.Location = new System.Drawing.Point(40, 464);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 30);
            this.lblResult.TabIndex = 72;
            this.lblResult.Text = "نتبجه";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(124, 463);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(227, 31);
            this.txtResult.TabIndex = 71;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // frmEditResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1326, 690);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEditResult);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.DGVDetails);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).EndInit();
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
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnHederDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFullNamePaitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPaitentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnShowReslutDestailsTest;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEditResult;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAddDetailsTest;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDeletePatientTestDetails;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditDetailsTest;
    }
}