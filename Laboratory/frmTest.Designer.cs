namespace Laboratory
{
    partial class frmTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewTest = new System.Windows.Forms.DataGridView();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAgeHasEfect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnGenderHasEfect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstUnit = new System.Windows.Forms.ListBox();
            this.grpGenderHasEfect = new System.Windows.Forms.GroupBox();
            this.rdbUnknownGender = new System.Windows.Forms.RadioButton();
            this.rdbNotHasGender = new System.Windows.Forms.RadioButton();
            this.rdbHasGender = new System.Windows.Forms.RadioButton();
            this.grpAgeHasEfect = new System.Windows.Forms.GroupBox();
            this.rdbUnKnownAge = new System.Windows.Forms.RadioButton();
            this.rdbNotAge = new System.Windows.Forms.RadioButton();
            this.rdbHasAge = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchToUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFromUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblErrorTest = new System.Windows.Forms.Label();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTest)).BeginInit();
            this.panel3.SuspendLayout();
            this.grpGenderHasEfect.SuspendLayout();
            this.grpAgeHasEfect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewTest
            // 
            this.DataGridViewTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnTestID,
            this.ClmnTestName,
            this.ClmnUnitID,
            this.ClmnUnitName,
            this.ClmnCategoryID,
            this.ClmnCategoryName,
            this.ClmnAgeHasEfect,
            this.ClmnGenderHasEfect,
            this.ClmnPrice,
            this.ClmnEdit,
            this.ClmnDelete});
            this.DataGridViewTest.Location = new System.Drawing.Point(249, 573);
            this.DataGridViewTest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DataGridViewTest.Name = "DataGridViewTest";
            this.DataGridViewTest.RowTemplate.Height = 25;
            this.DataGridViewTest.Size = new System.Drawing.Size(952, 252);
            this.DataGridViewTest.TabIndex = 0;
            this.DataGridViewTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTest_CellContentClick);
            // 
            // ClmnTestID
            // 
            this.ClmnTestID.DataPropertyName = "TestID";
            this.ClmnTestID.HeaderText = "شناسه آزمایش";
            this.ClmnTestID.Name = "ClmnTestID";
            this.ClmnTestID.Width = 110;
            // 
            // ClmnTestName
            // 
            this.ClmnTestName.DataPropertyName = "TestName";
            this.ClmnTestName.HeaderText = "آزمایش";
            this.ClmnTestName.Name = "ClmnTestName";
            // 
            // ClmnUnitID
            // 
            this.ClmnUnitID.DataPropertyName = "UnitID";
            this.ClmnUnitID.HeaderText = "شناسه واحد";
            this.ClmnUnitID.Name = "ClmnUnitID";
            this.ClmnUnitID.Visible = false;
            // 
            // ClmnUnitName
            // 
            this.ClmnUnitName.DataPropertyName = "UnitName";
            this.ClmnUnitName.HeaderText = "واحد";
            this.ClmnUnitName.Name = "ClmnUnitName";
            // 
            // ClmnCategoryID
            // 
            this.ClmnCategoryID.DataPropertyName = "CategoryID";
            this.ClmnCategoryID.HeaderText = "شناسه گروه";
            this.ClmnCategoryID.Name = "ClmnCategoryID";
            this.ClmnCategoryID.Visible = false;
            // 
            // ClmnCategoryName
            // 
            this.ClmnCategoryName.DataPropertyName = "CategoryName";
            this.ClmnCategoryName.HeaderText = "گروه";
            this.ClmnCategoryName.Name = "ClmnCategoryName";
            // 
            // ClmnAgeHasEfect
            // 
            this.ClmnAgeHasEfect.DataPropertyName = "AgeHasEfect";
            this.ClmnAgeHasEfect.HeaderText = "تاثیر سن";
            this.ClmnAgeHasEfect.Name = "ClmnAgeHasEfect";
            // 
            // ClmnGenderHasEfect
            // 
            this.ClmnGenderHasEfect.DataPropertyName = "GenderHasEfect";
            this.ClmnGenderHasEfect.HeaderText = "تاثیر جنسیت";
            this.ClmnGenderHasEfect.Name = "ClmnGenderHasEfect";
            // 
            // ClmnPrice
            // 
            this.ClmnPrice.DataPropertyName = "Price";
            this.ClmnPrice.HeaderText = "قیمت";
            this.ClmnPrice.Name = "ClmnPrice";
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
            this.ClmnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnDelete.Text = "حذف";
            this.ClmnDelete.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(1215, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 10;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancle.Location = new System.Drawing.Point(18, 125);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(155, 39);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "انصراف";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Location = new System.Drawing.Point(18, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Location = new System.Drawing.Point(18, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "آزمایش";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(109, 33);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(320, 31);
            this.txtTest.TabIndex = 12;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(109, 111);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(320, 32);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "گروه";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(673, 33);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(320, 31);
            this.txtUnit.TabIndex = 16;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(597, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "واحد";
            // 
            // lstUnit
            // 
            this.lstUnit.FormattingEnabled = true;
            this.lstUnit.ItemHeight = 24;
            this.lstUnit.Location = new System.Drawing.Point(673, 63);
            this.lstUnit.Name = "lstUnit";
            this.lstUnit.Size = new System.Drawing.Size(320, 124);
            this.lstUnit.TabIndex = 17;
            this.lstUnit.DoubleClick += new System.EventHandler(this.lstUnit_DoubleClick);
            // 
            // grpGenderHasEfect
            // 
            this.grpGenderHasEfect.Controls.Add(this.rdbUnknownGender);
            this.grpGenderHasEfect.Controls.Add(this.rdbNotHasGender);
            this.grpGenderHasEfect.Controls.Add(this.rdbHasGender);
            this.grpGenderHasEfect.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpGenderHasEfect.Location = new System.Drawing.Point(38, 191);
            this.grpGenderHasEfect.Name = "grpGenderHasEfect";
            this.grpGenderHasEfect.Size = new System.Drawing.Size(391, 72);
            this.grpGenderHasEfect.TabIndex = 18;
            this.grpGenderHasEfect.TabStop = false;
            this.grpGenderHasEfect.Text = "تاثیر جنسیت";
            // 
            // rdbUnknownGender
            // 
            this.rdbUnknownGender.AutoSize = true;
            this.rdbUnknownGender.Location = new System.Drawing.Point(45, 29);
            this.rdbUnknownGender.Name = "rdbUnknownGender";
            this.rdbUnknownGender.Size = new System.Drawing.Size(90, 27);
            this.rdbUnknownGender.TabIndex = 2;
            this.rdbUnknownGender.TabStop = true;
            this.rdbUnknownGender.Text = "مشخص نیست";
            this.rdbUnknownGender.UseVisualStyleBackColor = true;
            // 
            // rdbNotHasGender
            // 
            this.rdbNotHasGender.AutoSize = true;
            this.rdbNotHasGender.Location = new System.Drawing.Point(177, 30);
            this.rdbNotHasGender.Name = "rdbNotHasGender";
            this.rdbNotHasGender.Size = new System.Drawing.Size(54, 27);
            this.rdbNotHasGender.TabIndex = 1;
            this.rdbNotHasGender.TabStop = true;
            this.rdbNotHasGender.Text = "ندارد";
            this.rdbNotHasGender.UseVisualStyleBackColor = true;
            // 
            // rdbHasGender
            // 
            this.rdbHasGender.AutoSize = true;
            this.rdbHasGender.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbHasGender.Location = new System.Drawing.Point(281, 29);
            this.rdbHasGender.Name = "rdbHasGender";
            this.rdbHasGender.Size = new System.Drawing.Size(49, 27);
            this.rdbHasGender.TabIndex = 0;
            this.rdbHasGender.TabStop = true;
            this.rdbHasGender.Text = "دارد";
            this.rdbHasGender.UseVisualStyleBackColor = true;
            this.rdbHasGender.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpAgeHasEfect
            // 
            this.grpAgeHasEfect.Controls.Add(this.rdbUnKnownAge);
            this.grpAgeHasEfect.Controls.Add(this.rdbNotAge);
            this.grpAgeHasEfect.Controls.Add(this.rdbHasAge);
            this.grpAgeHasEfect.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpAgeHasEfect.Location = new System.Drawing.Point(602, 191);
            this.grpAgeHasEfect.Name = "grpAgeHasEfect";
            this.grpAgeHasEfect.Size = new System.Drawing.Size(435, 72);
            this.grpAgeHasEfect.TabIndex = 19;
            this.grpAgeHasEfect.TabStop = false;
            this.grpAgeHasEfect.Text = "تاثیر سن";
            // 
            // rdbUnKnownAge
            // 
            this.rdbUnKnownAge.AutoSize = true;
            this.rdbUnKnownAge.Location = new System.Drawing.Point(26, 30);
            this.rdbUnKnownAge.Name = "rdbUnKnownAge";
            this.rdbUnKnownAge.Size = new System.Drawing.Size(90, 27);
            this.rdbUnKnownAge.TabIndex = 3;
            this.rdbUnKnownAge.TabStop = true;
            this.rdbUnKnownAge.Text = "مشخص نیست";
            this.rdbUnKnownAge.UseVisualStyleBackColor = true;
            // 
            // rdbNotAge
            // 
            this.rdbNotAge.AutoSize = true;
            this.rdbNotAge.Location = new System.Drawing.Point(168, 29);
            this.rdbNotAge.Name = "rdbNotAge";
            this.rdbNotAge.Size = new System.Drawing.Size(54, 27);
            this.rdbNotAge.TabIndex = 2;
            this.rdbNotAge.TabStop = true;
            this.rdbNotAge.Text = "ندارد";
            this.rdbNotAge.UseVisualStyleBackColor = true;
            // 
            // rdbHasAge
            // 
            this.rdbHasAge.AutoSize = true;
            this.rdbHasAge.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbHasAge.Location = new System.Drawing.Point(274, 29);
            this.rdbHasAge.Name = "rdbHasAge";
            this.rdbHasAge.Size = new System.Drawing.Size(49, 27);
            this.rdbHasAge.TabIndex = 2;
            this.rdbHasAge.TabStop = true;
            this.rdbHasAge.Text = "دارد";
            this.rdbHasAge.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 284);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(320, 31);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(33, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "قیمت";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSearchToUnitPrice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFromUnitPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSearchUnit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSearchTest);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(38, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 180);
            this.panel1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(1246, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 30);
            this.label10.TabIndex = 29;
            this.label10.Text = "از قیمت";
            // 
            // txtSearchToUnitPrice
            // 
            this.txtSearchToUnitPrice.Location = new System.Drawing.Point(335, 94);
            this.txtSearchToUnitPrice.Name = "txtSearchToUnitPrice";
            this.txtSearchToUnitPrice.Size = new System.Drawing.Size(393, 31);
            this.txtSearchToUnitPrice.TabIndex = 27;
            this.txtSearchToUnitPrice.TextChanged += new System.EventHandler(this.txtSearchToUnitPrice_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(734, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "تا قیمت";
            // 
            // txtFromUnitPrice
            // 
            this.txtFromUnitPrice.Location = new System.Drawing.Point(812, 94);
            this.txtFromUnitPrice.Name = "txtFromUnitPrice";
            this.txtFromUnitPrice.Size = new System.Drawing.Size(411, 31);
            this.txtFromUnitPrice.TabIndex = 28;
            this.txtFromUnitPrice.TextChanged += new System.EventHandler(this.txtFromUnitPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(287, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "گروه";
            // 
            // txtSearchUnit
            // 
            this.txtSearchUnit.Location = new System.Drawing.Point(568, 18);
            this.txtSearchUnit.Name = "txtSearchUnit";
            this.txtSearchUnit.Size = new System.Drawing.Size(290, 31);
            this.txtSearchUnit.TabIndex = 25;
            this.txtSearchUnit.TextChanged += new System.EventHandler(this.txtSearchUnit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(864, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "واحد";
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.Location = new System.Drawing.Point(957, 18);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(284, 31);
            this.txtSearchTest.TabIndex = 25;
            this.txtSearchTest.TextChanged += new System.EventHandler(this.txtSearchTest_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(1247, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "آزمایش";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(50, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "پنل جست و جو";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(673, 284);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(320, 71);
            this.txtDescription.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(597, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "توضیحات";
            // 
            // lblErrorTest
            // 
            this.lblErrorTest.AutoSize = true;
            this.lblErrorTest.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorTest.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTest.Location = new System.Drawing.Point(112, 69);
            this.lblErrorTest.Name = "lblErrorTest";
            this.lblErrorTest.Size = new System.Drawing.Size(0, 19);
            this.lblErrorTest.TabIndex = 26;
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrice.Location = new System.Drawing.Point(111, 321);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(0, 19);
            this.lblErrorPrice.TabIndex = 27;
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1443, 826);
            this.Controls.Add(this.lblErrorPrice);
            this.Controls.Add(this.lblErrorTest);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpAgeHasEfect);
            this.Controls.Add(this.grpGenderHasEfect);
            this.Controls.Add(this.lstUnit);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DataGridViewTest);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت آزمایش";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.grpGenderHasEfect.ResumeLayout(false);
            this.grpGenderHasEfect.PerformLayout();
            this.grpAgeHasEfect.ResumeLayout(false);
            this.grpAgeHasEfect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstUnit;
        private System.Windows.Forms.GroupBox grpGenderHasEfect;
        private System.Windows.Forms.GroupBox grpAgeHasEfect;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchToUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFromUnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbNotHasGender;
        private System.Windows.Forms.RadioButton rdbHasGender;
        private System.Windows.Forms.RadioButton rdbNotAge;
        private System.Windows.Forms.RadioButton rdbHasAge;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblErrorTest;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.RadioButton rdbUnknownGender;
        private System.Windows.Forms.RadioButton rdbUnKnownAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAgeHasEfect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnGenderHasEfect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
    }
}