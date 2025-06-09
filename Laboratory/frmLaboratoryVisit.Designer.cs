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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddPatientTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNationalCodePatient = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientTestHederID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDetailsVisit = new System.Windows.Forms.Panel();
            this.btnCancleTest = new System.Windows.Forms.Button();
            this.lblErrorPriceWithDiscount = new System.Windows.Forms.Label();
            this.lblErrorDiscountTest = new System.Windows.Forms.Label();
            this.lblErrorPriceTest = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.txtPriceWithDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPriceTest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceTests = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorMobile = new System.Windows.Forms.Label();
            this.lblErrorNationalCode = new System.Windows.Forms.Label();
            this.lblErrorAge = new System.Windows.Forms.Label();
            this.lblErrorDrName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.btnClearFormForAddVisit = new System.Windows.Forms.Button();
            this.lblPanleTest = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlDetailsVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblNationalCodePatient);
            this.panel2.Controls.Add(this.lblPatientName);
            this.panel2.Controls.Add(this.lblPatientTestHederID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1321, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 160);
            this.panel2.TabIndex = 2;
            // 
            // lblNationalCodePatient
            // 
            this.lblNationalCodePatient.AutoSize = true;
            this.lblNationalCodePatient.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNationalCodePatient.ForeColor = System.Drawing.Color.Red;
            this.lblNationalCodePatient.Location = new System.Drawing.Point(48, 111);
            this.lblNationalCodePatient.Name = "lblNationalCodePatient";
            this.lblNationalCodePatient.Size = new System.Drawing.Size(0, 29);
            this.lblNationalCodePatient.TabIndex = 10;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Red;
            this.lblPatientName.Location = new System.Drawing.Point(48, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 29);
            this.lblPatientName.TabIndex = 9;
            // 
            // lblPatientTestHederID
            // 
            this.lblPatientTestHederID.AutoSize = true;
            this.lblPatientTestHederID.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatientTestHederID.ForeColor = System.Drawing.Color.Red;
            this.lblPatientTestHederID.Location = new System.Drawing.Point(48, 13);
            this.lblPatientTestHederID.Name = "lblPatientTestHederID";
            this.lblPatientTestHederID.Size = new System.Drawing.Size(0, 29);
            this.lblPatientTestHederID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(145, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "کد ملی ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(142, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "نام بیمار";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(112, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "شماره پذیرش";
            // 
            // pnlDetailsVisit
            // 
            this.pnlDetailsVisit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetailsVisit.Controls.Add(this.btnCancleTest);
            this.pnlDetailsVisit.Controls.Add(this.lblErrorPriceWithDiscount);
            this.pnlDetailsVisit.Controls.Add(this.lblErrorDiscountTest);
            this.pnlDetailsVisit.Controls.Add(this.lblErrorPriceTest);
            this.pnlDetailsVisit.Controls.Add(this.btnEdit);
            this.pnlDetailsVisit.Controls.Add(this.btnAddTest);
            this.pnlDetailsVisit.Controls.Add(this.txtPriceWithDiscount);
            this.pnlDetailsVisit.Controls.Add(this.label14);
            this.pnlDetailsVisit.Controls.Add(this.txtDiscount);
            this.pnlDetailsVisit.Controls.Add(this.label13);
            this.pnlDetailsVisit.Controls.Add(this.txtPriceTest);
            this.pnlDetailsVisit.Controls.Add(this.label12);
            this.pnlDetailsVisit.Controls.Add(this.lstTest);
            this.pnlDetailsVisit.Controls.Add(this.txtTestName);
            this.pnlDetailsVisit.Controls.Add(this.label11);
            this.pnlDetailsVisit.Location = new System.Drawing.Point(37, 364);
            this.pnlDetailsVisit.Name = "pnlDetailsVisit";
            this.pnlDetailsVisit.Size = new System.Drawing.Size(1164, 133);
            this.pnlDetailsVisit.TabIndex = 3;
            this.pnlDetailsVisit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCancleTest
            // 
            this.btnCancleTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancleTest.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancleTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancleTest.Location = new System.Drawing.Point(28, 80);
            this.btnCancleTest.Name = "btnCancleTest";
            this.btnCancleTest.Size = new System.Drawing.Size(105, 42);
            this.btnCancleTest.TabIndex = 54;
            this.btnCancleTest.Text = "انصراف";
            this.btnCancleTest.UseVisualStyleBackColor = false;
            this.btnCancleTest.Click += new System.EventHandler(this.btnCancleTest_Click);
            // 
            // lblErrorPriceWithDiscount
            // 
            this.lblErrorPriceWithDiscount.AutoSize = true;
            this.lblErrorPriceWithDiscount.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorPriceWithDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPriceWithDiscount.Location = new System.Drawing.Point(310, 70);
            this.lblErrorPriceWithDiscount.Name = "lblErrorPriceWithDiscount";
            this.lblErrorPriceWithDiscount.Size = new System.Drawing.Size(0, 19);
            this.lblErrorPriceWithDiscount.TabIndex = 53;
            // 
            // lblErrorDiscountTest
            // 
            this.lblErrorDiscountTest.AutoSize = true;
            this.lblErrorDiscountTest.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorDiscountTest.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDiscountTest.Location = new System.Drawing.Point(516, 70);
            this.lblErrorDiscountTest.Name = "lblErrorDiscountTest";
            this.lblErrorDiscountTest.Size = new System.Drawing.Size(0, 19);
            this.lblErrorDiscountTest.TabIndex = 52;
            // 
            // lblErrorPriceTest
            // 
            this.lblErrorPriceTest.AutoSize = true;
            this.lblErrorPriceTest.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorPriceTest.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPriceTest.Location = new System.Drawing.Point(792, 78);
            this.lblErrorPriceTest.Name = "lblErrorPriceTest";
            this.lblErrorPriceTest.Size = new System.Drawing.Size(0, 19);
            this.lblErrorPriceTest.TabIndex = 51;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(28, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 42);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "ثبت ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // txtPriceWithDiscount
            // 
            this.txtPriceWithDiscount.Location = new System.Drawing.Point(206, 38);
            this.txtPriceWithDiscount.Name = "txtPriceWithDiscount";
            this.txtPriceWithDiscount.Size = new System.Drawing.Size(109, 31);
            this.txtPriceWithDiscount.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(321, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "قیمت با بیمه";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(406, 38);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(109, 31);
            this.txtDiscount.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(521, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "درصد بیمه";
            // 
            // txtPriceTest
            // 
            this.txtPriceTest.Location = new System.Drawing.Point(612, 35);
            this.txtPriceTest.Name = "txtPriceTest";
            this.txtPriceTest.Size = new System.Drawing.Size(176, 31);
            this.txtPriceTest.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(794, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "قیمت";
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
            // DGVTestDetails
            // 
            this.DGVTestDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTestDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.DGVTestDetails.Location = new System.Drawing.Point(480, 526);
            this.DGVTestDetails.Name = "DGVTestDetails";
            this.DGVTestDetails.RowTemplate.Height = 25;
            this.DGVTestDetails.Size = new System.Drawing.Size(717, 184);
            this.DGVTestDetails.TabIndex = 4;
            this.DGVTestDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTestDetails_CellContentClick);
            // 
            // ClmnPatientTestHederID
            // 
            this.ClmnPatientTestHederID.DataPropertyName = "PatientTestHederID";
            this.ClmnPatientTestHederID.HeaderText = "شناسه ";
            this.ClmnPatientTestHederID.Name = "ClmnPatientTestHederID";
            this.ClmnPatientTestHederID.Visible = false;
            this.ClmnPatientTestHederID.Width = 160;
            // 
            // ClmnPatientTestDetailsID
            // 
            this.ClmnPatientTestDetailsID.DataPropertyName = "PatientTestDetailsID";
            this.ClmnPatientTestDetailsID.HeaderText = "شناسه هر قلم آزمایش";
            this.ClmnPatientTestDetailsID.Name = "ClmnPatientTestDetailsID";
            this.ClmnPatientTestDetailsID.Width = 160;
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
            this.ClmnDiscount.Width = 120;
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
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1237, 408);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(122, 29);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "جمع کل آزمایشات ";
            // 
            // lblTotalPriceTests
            // 
            this.lblTotalPriceTests.AutoSize = true;
            this.lblTotalPriceTests.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPriceTests.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalPriceTests.Location = new System.Drawing.Point(1407, 407);
            this.lblTotalPriceTests.Name = "lblTotalPriceTests";
            this.lblTotalPriceTests.Size = new System.Drawing.Size(20, 29);
            this.lblTotalPriceTests.TabIndex = 12;
            this.lblTotalPriceTests.Text = "0";
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobile.Location = new System.Drawing.Point(424, 235);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMobile.TabIndex = 50;
            // 
            // lblErrorNationalCode
            // 
            this.lblErrorNationalCode.AutoSize = true;
            this.lblErrorNationalCode.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorNationalCode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNationalCode.Location = new System.Drawing.Point(425, 159);
            this.lblErrorNationalCode.Name = "lblErrorNationalCode";
            this.lblErrorNationalCode.Size = new System.Drawing.Size(0, 19);
            this.lblErrorNationalCode.TabIndex = 49;
            // 
            // lblErrorAge
            // 
            this.lblErrorAge.AutoSize = true;
            this.lblErrorAge.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorAge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAge.Location = new System.Drawing.Point(1096, 85);
            this.lblErrorAge.Name = "lblErrorAge";
            this.lblErrorAge.Size = new System.Drawing.Size(0, 19);
            this.lblErrorAge.TabIndex = 48;
            // 
            // lblErrorDrName
            // 
            this.lblErrorDrName.AutoSize = true;
            this.lblErrorDrName.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorDrName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDrName.Location = new System.Drawing.Point(809, 89);
            this.lblErrorDrName.Name = "lblErrorDrName";
            this.lblErrorDrName.Size = new System.Drawing.Size(0, 19);
            this.lblErrorDrName.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(732, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 29);
            this.label10.TabIndex = 46;
            this.label10.Text = "بیمه بیمار";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(420, 194);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(200, 31);
            this.txtMobileNumber.TabIndex = 44;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.txtMobileNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(347, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "موبایل";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPatient.Location = new System.Drawing.Point(938, 226);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(263, 36);
            this.btnAddPatient.TabIndex = 42;
            this.btnAddPatient.Text = "ثبت بیمار جدید / ویرایش اطلاعات بیمار";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1042, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "سن";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(420, 118);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(200, 31);
            this.txtNationalCode.TabIndex = 39;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(347, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "کد ملی ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(732, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "نام دکتر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(347, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "بیمار";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(79, 44);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(200, 31);
            this.txtPatient.TabIndex = 54;
            this.txtPatient.TextChanged += new System.EventHandler(this.txtPatient_TextChanged);
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 24;
            this.lstPatient.Location = new System.Drawing.Point(79, 74);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(200, 172);
            this.lstPatient.TabIndex = 55;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(420, 55);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(200, 20);
            this.faDatePicker1.TabIndex = 56;
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(805, 51);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(173, 31);
            this.txtDrName.TabIndex = 57;
            this.txtDrName.TextChanged += new System.EventHandler(this.txtDrName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(1091, 48);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 31);
            this.txtAge.TabIndex = 58;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(807, 122);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(122, 32);
            this.cmbInsurance.TabIndex = 59;
            // 
            // btnClearFormForAddVisit
            // 
            this.btnClearFormForAddVisit.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClearFormForAddVisit.Location = new System.Drawing.Point(1290, 289);
            this.btnClearFormForAddVisit.Name = "btnClearFormForAddVisit";
            this.btnClearFormForAddVisit.Size = new System.Drawing.Size(137, 57);
            this.btnClearFormForAddVisit.TabIndex = 61;
            this.btnClearFormForAddVisit.Text = "ثبت ویزیت جدید";
            this.btnClearFormForAddVisit.UseVisualStyleBackColor = true;
            this.btnClearFormForAddVisit.Click += new System.EventHandler(this.btnClearFormForAddVisit_Click);
            // 
            // lblPanleTest
            // 
            this.lblPanleTest.AutoSize = true;
            this.lblPanleTest.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPanleTest.Location = new System.Drawing.Point(49, 346);
            this.lblPanleTest.Name = "lblPanleTest";
            this.lblPanleTest.Size = new System.Drawing.Size(82, 29);
            this.lblPanleTest.TabIndex = 62;
            this.lblPanleTest.Text = "پنل آزمایش";
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancle.Location = new System.Drawing.Point(1446, 289);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(137, 57);
            this.btnCancle.TabIndex = 63;
            this.btnCancle.Text = "لغو پذیرش";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmLaboratoryVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1595, 710);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.lblPanleTest);
            this.Controls.Add(this.btnClearFormForAddVisit);
            this.Controls.Add(this.cmbInsurance);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDrName);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorNationalCode);
            this.Controls.Add(this.lblErrorAge);
            this.Controls.Add(this.lblErrorDrName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPriceTests);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.DGVTestDetails);
            this.Controls.Add(this.pnlDetailsVisit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddPatientTest);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmLaboratoryVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویزیت آزمایشگاه";
            this.Load += new System.EventHandler(this.frmLaboratoryVisit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDetailsVisit.ResumeLayout(false);
            this.pnlDetailsVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatientTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatientTestHederID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNationalCodePatient;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Panel pnlDetailsVisit;
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
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceTests;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMobile;
        private System.Windows.Forms.Label lblErrorNationalCode;
        private System.Windows.Forms.Label lblErrorAge;
        private System.Windows.Forms.Label lblErrorDrName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDrName;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.Button btnClearFormForAddVisit;
        private System.Windows.Forms.Label lblPanleTest;
        private System.Windows.Forms.Label lblErrorPriceWithDiscount;
        private System.Windows.Forms.Label lblErrorDiscountTest;
        private System.Windows.Forms.Label lblErrorPriceTest;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestHederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnInsuranceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
        private System.Windows.Forms.Button btnCancleTest;
    }
}
