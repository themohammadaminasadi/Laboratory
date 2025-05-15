namespace Laboratory
{
    partial class frmLaboratoryVisit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPatientTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNationalCodePatient = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientTestHederID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPriceTest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPriceWithDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.DGVTestDetails = new System.Windows.Forms.DataGridView();
            this.ClmnPatientTestHederID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnInsuranceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotalPriceTests = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbInsurance);
            this.panel1.Controls.Add(this.txtMobileNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNationalCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDrName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.faDatePicker1);
            this.panel1.Controls.Add(this.lstPatient);
            this.panel1.Controls.Add(this.txtPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 250);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(472, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "بیمه بیمار";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(270, 100);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(194, 32);
            this.cmbInsurance.TabIndex = 13;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(573, 166);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(233, 31);
            this.txtMobileNumber.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(821, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "موبایل";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPatient.Location = new System.Drawing.Point(12, 196);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(263, 36);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "ثبت بیمار جدید / ویرایش اطلاعات بیمار";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(91, 32);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(167, 31);
            this.txtAge.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(264, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "سن";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(573, 101);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(233, 31);
            this.txtNationalCode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(821, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "کد ملی ";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(350, 32);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(176, 31);
            this.txtDrName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(532, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام دکتر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(831, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ";
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(708, 37);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(117, 20);
            this.faDatePicker1.TabIndex = 2;
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 24;
            this.lstPatient.Location = new System.Drawing.Point(889, 53);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(209, 172);
            this.lstPatient.TabIndex = 2;
            this.lstPatient.DoubleClick += new System.EventHandler(this.lstPatient_DoubleClick);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(889, 23);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(209, 31);
            this.txtPatient.TabIndex = 1;
            this.txtPatient.TextChanged += new System.EventHandler(this.txtPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1113, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "بیمار";
            // 
            // btnAddPatientTest
            // 
            this.btnAddPatientTest.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPatientTest.Location = new System.Drawing.Point(37, 293);
            this.btnAddPatientTest.Name = "btnAddPatientTest";
            this.btnAddPatientTest.Size = new System.Drawing.Size(1164, 46);
            this.btnAddPatientTest.TabIndex = 1;
            this.btnAddPatientTest.Text = "پذیریش بیمار";
            this.btnAddPatientTest.UseVisualStyleBackColor = true;
            this.btnAddPatientTest.Click += new System.EventHandler(this.btnAddPatientTest_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNationalCodePatient);
            this.panel2.Controls.Add(this.lblPatientName);
            this.panel2.Controls.Add(this.lblPatientTestHederID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1228, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 188);
            this.panel2.TabIndex = 2;
            // 
            // lblNationalCodePatient
            // 
            this.lblNationalCodePatient.AutoSize = true;
            this.lblNationalCodePatient.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNationalCodePatient.ForeColor = System.Drawing.Color.Red;
            this.lblNationalCodePatient.Location = new System.Drawing.Point(56, 111);
            this.lblNationalCodePatient.Name = "lblNationalCodePatient";
            this.lblNationalCodePatient.Size = new System.Drawing.Size(0, 29);
            this.lblNationalCodePatient.TabIndex = 10;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Red;
            this.lblPatientName.Location = new System.Drawing.Point(56, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 29);
            this.lblPatientName.TabIndex = 9;
            // 
            // lblPatientTestHederID
            // 
            this.lblPatientTestHederID.AutoSize = true;
            this.lblPatientTestHederID.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatientTestHederID.ForeColor = System.Drawing.Color.Red;
            this.lblPatientTestHederID.Location = new System.Drawing.Point(56, 13);
            this.lblPatientTestHederID.Name = "lblPatientTestHederID";
            this.lblPatientTestHederID.Size = new System.Drawing.Size(0, 29);
            this.lblPatientTestHederID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(167, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "کد ملی ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(171, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "نام بیمار";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(144, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "شماره پذیرش";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAddTest);
            this.panel3.Controls.Add(this.txtPriceWithDiscount);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtPriceTest);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lstTest);
            this.panel3.Controls.Add(this.txtTestName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(37, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 133);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 24;
            this.lstTest.Location = new System.Drawing.Point(891, 63);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(209, 172);
            this.lstTest.TabIndex = 17;
            this.lstTest.DoubleClick += new System.EventHandler(this.lstTest_DoubleClick);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(891, 33);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(209, 31);
            this.txtTestName.TabIndex = 16;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(1102, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "آزمایش";
            // 
            // txtPriceTest
            // 
            this.txtPriceTest.Location = new System.Drawing.Point(616, 30);
            this.txtPriceTest.Name = "txtPriceTest";
            this.txtPriceTest.Size = new System.Drawing.Size(176, 31);
            this.txtPriceTest.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(798, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "قیمت";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(410, 33);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(109, 31);
            this.txtDiscount.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(525, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "درصد بیمه";
            // 
            // txtPriceWithDiscount
            // 
            this.txtPriceWithDiscount.Location = new System.Drawing.Point(203, 35);
            this.txtPriceWithDiscount.Name = "txtPriceWithDiscount";
            this.txtPriceWithDiscount.Size = new System.Drawing.Size(109, 31);
            this.txtPriceWithDiscount.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(318, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "قیمت با بیمه";
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddTest.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddTest.Location = new System.Drawing.Point(28, 30);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(105, 42);
            this.btnAddTest.TabIndex = 22;
            this.btnAddTest.Text = "اضافه کردن";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // DGVTestDetails
            // 
            this.DGVTestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTestDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientTestHederID,
            this.ClmnPatientTestDetailsID,
            this.ClmnTestID,
            this.ClmnInsuranceID,
            this.ClmnPrice,
            this.ClmnTestName,
            this.ClmnDiscount,
            this.ClmnEdit,
            this.ClmnDelete});
            this.DGVTestDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVTestDetails.Location = new System.Drawing.Point(0, 560);
            this.DGVTestDetails.Name = "DGVTestDetails";
            this.DGVTestDetails.Size = new System.Drawing.Size(1490, 150);
            this.DGVTestDetails.TabIndex = 4;
            this.DGVTestDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTestDetails_CellContentClick);
            // 
            // ClmnPatientTestHederID
            // 
            this.ClmnPatientTestHederID.DataPropertyName = "PatientTestHederID";
            this.ClmnPatientTestHederID.HeaderText = "شناسه ";
            this.ClmnPatientTestHederID.Name = "ClmnPatientTestHederID";
            this.ClmnPatientTestHederID.Visible = false;
            // 
            // ClmnPatientTestDetailsID
            // 
            this.ClmnPatientTestDetailsID.DataPropertyName = "PatientTestDetailsID";
            this.ClmnPatientTestDetailsID.HeaderText = "شناسه هر قلم آزمایش";
            this.ClmnPatientTestDetailsID.Name = "ClmnPatientTestDetailsID";
            // 
            // ClmnTestID
            // 
            this.ClmnTestID.DataPropertyName = "TestID";
            this.ClmnTestID.HeaderText = "شناسه آزمایش";
            this.ClmnTestID.Name = "ClmnTestID";
            this.ClmnTestID.Visible = false;
            // 
            // ClmnInsuranceID
            // 
            this.ClmnInsuranceID.HeaderText = "شناسه بیمه";
            this.ClmnInsuranceID.Name = "ClmnInsuranceID";
            this.ClmnInsuranceID.Visible = false;
            // 
            // ClmnPrice
            // 
            this.ClmnPrice.DataPropertyName = "Price";
            this.ClmnPrice.HeaderText = "قیمت";
            this.ClmnPrice.Name = "ClmnPrice";
            // 
            // ClmnTestName
            // 
            this.ClmnTestName.DataPropertyName = "TestName";
            this.ClmnTestName.HeaderText = "آزمایش";
            this.ClmnTestName.Name = "ClmnTestName";
            // 
            // ClmnDiscount
            // 
            this.ClmnDiscount.DataPropertyName = "Discount";
            this.ClmnDiscount.HeaderText = "فرانشیز آزمایش";
            this.ClmnDiscount.Name = "ClmnDiscount";
            // 
            // ClmnEdit
            // 
            this.ClmnEdit.HeaderText = "ویرایش";
            this.ClmnEdit.Name = "ClmnEdit";
            this.ClmnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnEdit.Text = "ویرایش";
            this.ClmnEdit.UseColumnTextForButtonValue = true;
            // 
            // ClmnDelete
            // 
            this.ClmnDelete.HeaderText = "حذف";
            this.ClmnDelete.Name = "ClmnDelete";
            this.ClmnDelete.Text = "حذف";
            this.ClmnDelete.UseColumnTextForButtonValue = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl.Location = new System.Drawing.Point(1223, 407);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(122, 29);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "جمع کل آزمایشات ";
            // 
            // lblTotalPriceTests
            // 
            this.lblTotalPriceTests.AutoSize = true;
            this.lblTotalPriceTests.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPriceTests.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalPriceTests.Location = new System.Drawing.Point(1351, 407);
            this.lblTotalPriceTests.Name = "lblTotalPriceTests";
            this.lblTotalPriceTests.Size = new System.Drawing.Size(0, 29);
            this.lblTotalPriceTests.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(28, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 42);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "ثبت ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmLaboratoryVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1490, 710);
            this.Controls.Add(this.lblTotalPriceTests);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.DGVTestDetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddPatientTest);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmLaboratoryVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویزیت آزمایشگاه";
            this.Load += new System.EventHandler(this.frmLaboratoryVisit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1; // اضافه شده
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddPatientTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatientTestHederID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNationalCodePatient;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPriceTest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPriceWithDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.DataGridView DGVTestDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnInsuranceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTotalPriceTests;
        private System.Windows.Forms.Button btnEdit;
    }
}
