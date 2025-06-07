namespace Laboratory
{
    partial class frmOrderReport
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbBothGender = new System.Windows.Forms.RadioButton();
            this.rdbFamle = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtSearchToAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchFromAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.faDatePickerFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faDatePickerToDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatientHeaderID = new System.Windows.Forms.TextBox();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnEditDetailsTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGVTestHeader = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestHederID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHederDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFullNamePaitent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPaitentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnShowResult = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInsuracePrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceTests = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEditResult = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestHeader)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(32, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "تلفن";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(165, 192);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(240, 31);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(32, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "کدملی";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(165, 115);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(240, 31);
            this.txtNationalCode.TabIndex = 14;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "نام و نام خانوادگی ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(165, 42);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(240, 31);
            this.txtFullName.TabIndex = 10;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbBothGender);
            this.grpGender.Controls.Add(this.rdbFamle);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpGender.Location = new System.Drawing.Point(37, 278);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(368, 67);
            this.grpGender.TabIndex = 18;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "جنسیت";
            this.grpGender.TextChanged += new System.EventHandler(this.grpGender_TextChanged);
            // 
            // rdbBothGender
            // 
            this.rdbBothGender.AutoSize = true;
            this.rdbBothGender.Location = new System.Drawing.Point(36, 29);
            this.rdbBothGender.Name = "rdbBothGender";
            this.rdbBothGender.Size = new System.Drawing.Size(46, 27);
            this.rdbBothGender.TabIndex = 2;
            this.rdbBothGender.TabStop = true;
            this.rdbBothGender.Text = "همه";
            this.rdbBothGender.UseVisualStyleBackColor = true;
            this.rdbBothGender.CheckedChanged += new System.EventHandler(this.rdbBothGender_CheckedChanged);
            // 
            // rdbFamle
            // 
            this.rdbFamle.AutoSize = true;
            this.rdbFamle.Location = new System.Drawing.Point(163, 29);
            this.rdbFamle.Name = "rdbFamle";
            this.rdbFamle.Size = new System.Drawing.Size(42, 27);
            this.rdbFamle.TabIndex = 1;
            this.rdbFamle.TabStop = true;
            this.rdbFamle.Text = "زن";
            this.rdbFamle.UseVisualStyleBackColor = true;
            this.rdbFamle.CheckedChanged += new System.EventHandler(this.rdbFamle_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(262, 29);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(45, 27);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "مرد";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // txtSearchToAge
            // 
            this.txtSearchToAge.Location = new System.Drawing.Point(698, 41);
            this.txtSearchToAge.Name = "txtSearchToAge";
            this.txtSearchToAge.Size = new System.Drawing.Size(100, 31);
            this.txtSearchToAge.TabIndex = 23;
            this.txtSearchToAge.TextChanged += new System.EventHandler(this.txtSearchToAge_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(648, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "تا سن";
            // 
            // txtSearchFromAge
            // 
            this.txtSearchFromAge.Location = new System.Drawing.Point(498, 40);
            this.txtSearchFromAge.Name = "txtSearchFromAge";
            this.txtSearchFromAge.Size = new System.Drawing.Size(100, 31);
            this.txtSearchFromAge.TabIndex = 21;
            this.txtSearchFromAge.TextChanged += new System.EventHandler(this.txtSearchFromAge_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(446, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "از سن";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(931, 40);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(173, 31);
            this.txtDrName.TabIndex = 62;
            this.txtDrName.TextChanged += new System.EventHandler(this.txtDrName_TextChanged);
            // 
            // faDatePickerFrom
            // 
            this.faDatePickerFrom.Location = new System.Drawing.Point(519, 126);
            this.faDatePickerFrom.Name = "faDatePickerFrom";
            this.faDatePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.faDatePickerFrom.TabIndex = 61;
            this.faDatePickerFrom.SelectedDateTimeChanged += new System.EventHandler(this.faDatePickerFrom_SelectedDateTimeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(864, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "نام دکتر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(446, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "از تاریخ";
            // 
            // faDatePickerToDate
            // 
            this.faDatePickerToDate.Location = new System.Drawing.Point(904, 126);
            this.faDatePickerToDate.Name = "faDatePickerToDate";
            this.faDatePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.faDatePickerToDate.TabIndex = 64;
            this.faDatePickerToDate.SelectedDateTimeChanged += new System.EventHandler(this.faDatePickerToDate_SelectedDateTimeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(831, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "تا تاریخ";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(519, 192);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(122, 32);
            this.cmbInsurance.TabIndex = 66;
            this.cmbInsurance.SelectedIndexChanged += new System.EventHandler(this.cmbInsurance_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(444, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "بیمه بیمار";
            // 
            // txtEmployeer
            // 
            this.txtEmployeer.Location = new System.Drawing.Point(631, 307);
            this.txtEmployeer.Name = "txtEmployeer";
            this.txtEmployeer.Size = new System.Drawing.Size(291, 31);
            this.txtEmployeer.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(443, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 67;
            this.label8.Text = "نام و نام خانوادگی کارمند";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(32, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 30);
            this.label11.TabIndex = 70;
            this.label11.Text = "کد آزمایش";
            // 
            // txtPatientHeaderID
            // 
            this.txtPatientHeaderID.Location = new System.Drawing.Point(165, 388);
            this.txtPatientHeaderID.Name = "txtPatientHeaderID";
            this.txtPatientHeaderID.Size = new System.Drawing.Size(240, 31);
            this.txtPatientHeaderID.TabIndex = 69;
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
            this.ClmnEditDetailsTest});
            this.DGVDetails.Location = new System.Drawing.Point(676, 731);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.RowHeadersWidth = 51;
            this.DGVDetails.Size = new System.Drawing.Size(700, 191);
            this.DGVDetails.TabIndex = 72;
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
            this.ClmnShowResult});
            this.DGVTestHeader.Location = new System.Drawing.Point(459, 513);
            this.DGVTestHeader.Name = "DGVTestHeader";
            this.DGVTestHeader.RowHeadersWidth = 51;
            this.DGVTestHeader.Size = new System.Drawing.Size(918, 218);
            this.DGVTestHeader.TabIndex = 71;
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
            // ClmnShowResult
            // 
            this.ClmnShowResult.DataPropertyName = "ShowResult";
            this.ClmnShowResult.HeaderText = "جزئیات";
            this.ClmnShowResult.MinimumWidth = 6;
            this.ClmnShowResult.Name = "ClmnShowResult";
            this.ClmnShowResult.Text = "جزئیات";
            this.ClmnShowResult.UseColumnTextForButtonValue = true;
            this.ClmnShowResult.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblInsuracePrice);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.lblTotalPriceTests);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(951, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 292);
            this.panel1.TabIndex = 73;
            // 
            // lblInsuracePrice
            // 
            this.lblInsuracePrice.AutoSize = true;
            this.lblInsuracePrice.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInsuracePrice.ForeColor = System.Drawing.Color.Magenta;
            this.lblInsuracePrice.Location = new System.Drawing.Point(25, 150);
            this.lblInsuracePrice.Name = "lblInsuracePrice";
            this.lblInsuracePrice.Size = new System.Drawing.Size(20, 29);
            this.lblInsuracePrice.TabIndex = 79;
            this.lblInsuracePrice.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalPrice.Location = new System.Drawing.Point(25, 247);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(20, 29);
            this.lblTotalPrice.TabIndex = 78;
            this.lblTotalPrice.Text = "0";
            // 
            // lblTotalPriceTests
            // 
            this.lblTotalPriceTests.AutoSize = true;
            this.lblTotalPriceTests.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPriceTests.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalPriceTests.Location = new System.Drawing.Point(25, 50);
            this.lblTotalPriceTests.Name = "lblTotalPriceTests";
            this.lblTotalPriceTests.Size = new System.Drawing.Size(20, 29);
            this.lblTotalPriceTests.TabIndex = 74;
            this.lblTotalPriceTests.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(84, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 30);
            this.label15.TabIndex = 77;
            this.label15.Text = "مبلغی که بیماران پرداخت کرده اند :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(103, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 30);
            this.label13.TabIndex = 75;
            this.label13.Text = "مبلغی که بیمه باید پرداخت کند : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(193, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 30);
            this.label12.TabIndex = 74;
            this.label12.Text = "مجموع آزمایشات";
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancle.Location = new System.Drawing.Point(262, 731);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(107, 46);
            this.btnCancle.TabIndex = 80;
            this.btnCancle.Text = "انصراف";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEditResult
            // 
            this.btnEditResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditResult.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditResult.Location = new System.Drawing.Point(110, 731);
            this.btnEditResult.Name = "btnEditResult";
            this.btnEditResult.Size = new System.Drawing.Size(117, 46);
            this.btnEditResult.TabIndex = 79;
            this.btnEditResult.Text = "ویرایش نتیجه آزمایش";
            this.btnEditResult.UseVisualStyleBackColor = false;
            this.btnEditResult.Click += new System.EventHandler(this.btnEditResult_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(38, 597);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 30);
            this.label14.TabIndex = 78;
            this.label14.Text = "آزمایش";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(128, 599);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(241, 31);
            this.txtTestName.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(53, 654);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 30);
            this.label16.TabIndex = 75;
            this.label16.Text = "نتبجه";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(128, 653);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(241, 31);
            this.txtResult.TabIndex = 74;
            // 
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1378, 922);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEditResult);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVDetails);
            this.Controls.Add(this.DGVTestHeader);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPatientHeaderID);
            this.Controls.Add(this.txtEmployeer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbInsurance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.faDatePickerToDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDrName);
            this.Controls.Add(this.faDatePickerFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchToAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchFromAge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmOrderReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "گزارش";
            this.Load += new System.EventHandler(this.frmOrderReport_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbBothGender;
        private System.Windows.Forms.RadioButton rdbFamle;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtSearchToAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchFromAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDrName;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientHeaderID;
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.DataGridView DGVTestHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblInsuracePrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnHederDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFullNamePaitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPaitentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnShowResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEditDetailsTest;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEditResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtResult;
    }
}