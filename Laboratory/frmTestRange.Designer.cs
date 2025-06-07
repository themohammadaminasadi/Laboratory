namespace Laboratory
{
    partial class frmTestRange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbBothGender = new System.Windows.Forms.RadioButton();
            this.rdbFamle = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.CKBHazard = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchToMaximum = new System.Windows.Forms.TextBox();
            this.txtSearchToAge = new System.Windows.Forms.TextBox();
            this.txtSearchFromMinum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CKBSearchHazard = new System.Windows.Forms.CheckBox();
            this.txtSearchTest = new System.Windows.Forms.TextBox();
            this.txtSearchFromAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVTestRange = new System.Windows.Forms.DataGridView();
            this.ClmnRangeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnMinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnMaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFromAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnToAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnHazard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfoTest = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGender.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestRange)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(490, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "آزمایش";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(555, 24);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(230, 31);
            this.txtTest.TabIndex = 1;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 24;
            this.lstTest.Location = new System.Drawing.Point(555, 54);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(230, 100);
            this.lstTest.TabIndex = 2;
            this.lstTest.DoubleClick += new System.EventHandler(this.lstTest_DoubleClick);
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(87, 28);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(100, 31);
            this.txtMinValue.TabIndex = 3;
            this.txtMinValue.TextChanged += new System.EventHandler(this.txtMinValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "از رنج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(221, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "تا رنج";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(279, 28);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 31);
            this.txtMaxValue.TabIndex = 5;
            this.txtMaxValue.TextChanged += new System.EventHandler(this.txtMaxValue_TextChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbBothGender);
            this.grpGender.Controls.Add(this.rdbFamle);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpGender.Location = new System.Drawing.Point(28, 65);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(351, 67);
            this.grpGender.TabIndex = 7;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "جنسیت";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(221, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "تا سن";
            // 
            // txtToAge
            // 
            this.txtToAge.Location = new System.Drawing.Point(279, 150);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(100, 31);
            this.txtToAge.TabIndex = 10;
            this.txtToAge.TextChanged += new System.EventHandler(this.txtToAge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(22, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "از سن";
            // 
            // txtFromAge
            // 
            this.txtFromAge.Location = new System.Drawing.Point(87, 150);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(100, 31);
            this.txtFromAge.TabIndex = 8;
            this.txtFromAge.TextChanged += new System.EventHandler(this.txtFromAge_TextChanged);
            // 
            // CKBHazard
            // 
            this.CKBHazard.AutoSize = true;
            this.CKBHazard.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKBHazard.Location = new System.Drawing.Point(612, 207);
            this.CKBHazard.Name = "CKBHazard";
            this.CKBHazard.Size = new System.Drawing.Size(82, 33);
            this.CKBHazard.TabIndex = 12;
            this.CKBHazard.Text = "خطرناک";
            this.CKBHazard.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(22, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "توضیحات";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 197);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 86);
            this.txtDescription.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSearchToMaximum);
            this.panel1.Controls.Add(this.txtSearchToAge);
            this.panel1.Controls.Add(this.txtSearchFromMinum);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CKBSearchHazard);
            this.panel1.Controls.Add(this.txtSearchTest);
            this.panel1.Controls.Add(this.txtSearchFromAge);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(27, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 158);
            this.panel1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(439, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "تا رنج";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(701, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "از رنج";
            // 
            // txtSearchToMaximum
            // 
            this.txtSearchToMaximum.Location = new System.Drawing.Point(333, 93);
            this.txtSearchToMaximum.Name = "txtSearchToMaximum";
            this.txtSearchToMaximum.Size = new System.Drawing.Size(100, 31);
            this.txtSearchToMaximum.TabIndex = 17;
            this.txtSearchToMaximum.TextChanged += new System.EventHandler(this.txtSearchToMaximum_TextChanged);
            this.txtSearchToMaximum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchToMaximum_KeyPress);
            // 
            // txtSearchToAge
            // 
            this.txtSearchToAge.Location = new System.Drawing.Point(37, 23);
            this.txtSearchToAge.Name = "txtSearchToAge";
            this.txtSearchToAge.Size = new System.Drawing.Size(100, 31);
            this.txtSearchToAge.TabIndex = 19;
            this.txtSearchToAge.TextChanged += new System.EventHandler(this.txtSearchToAge_TextChanged);
            // 
            // txtSearchFromMinum
            // 
            this.txtSearchFromMinum.Location = new System.Drawing.Point(593, 93);
            this.txtSearchFromMinum.Name = "txtSearchFromMinum";
            this.txtSearchFromMinum.Size = new System.Drawing.Size(100, 31);
            this.txtSearchFromMinum.TabIndex = 17;
            this.txtSearchFromMinum.TextChanged += new System.EventHandler(this.txtSearchFromMinum_TextChanged);
            this.txtSearchFromMinum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchFromMinum_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(150, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "تا سن";
            // 
            // CKBSearchHazard
            // 
            this.CKBSearchHazard.AutoSize = true;
            this.CKBSearchHazard.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKBSearchHazard.Location = new System.Drawing.Point(107, 93);
            this.CKBSearchHazard.Name = "CKBSearchHazard";
            this.CKBSearchHazard.Size = new System.Drawing.Size(82, 33);
            this.CKBSearchHazard.TabIndex = 19;
            this.CKBSearchHazard.Text = "خطرناک";
            this.CKBSearchHazard.UseVisualStyleBackColor = true;
            this.CKBSearchHazard.Click += new System.EventHandler(this.CKBSearchHazard_Click);
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.Location = new System.Drawing.Point(463, 25);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(230, 31);
            this.txtSearchTest.TabIndex = 18;
            this.txtSearchTest.TextChanged += new System.EventHandler(this.txtSearchTest_TextChanged);
            // 
            // txtSearchFromAge
            // 
            this.txtSearchFromAge.Location = new System.Drawing.Point(249, 25);
            this.txtSearchFromAge.Name = "txtSearchFromAge";
            this.txtSearchFromAge.Size = new System.Drawing.Size(100, 31);
            this.txtSearchFromAge.TabIndex = 17;
            this.txtSearchFromAge.TextChanged += new System.EventHandler(this.txtSearchFromAge_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(355, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "از سن";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(691, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "آزمایش";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(50, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "پنل جست و جو";
            // 
            // DGVTestRange
            // 
            this.DGVTestRange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTestRange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVTestRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTestRange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnRangeID,
            this.ClmnTestID,
            this.ClmnTestName,
            this.ClmnMinValue,
            this.ClmnMaxValue,
            this.ClmnGender,
            this.ClmnFromAge,
            this.ClmnToAge,
            this.ClmnHazard,
            this.ClmnEdit,
            this.ClmnDelete});
            this.DGVTestRange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVTestRange.Location = new System.Drawing.Point(0, 526);
            this.DGVTestRange.Name = "DGVTestRange";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTestRange.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVTestRange.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVTestRange.RowTemplate.Height = 25;
            this.DGVTestRange.Size = new System.Drawing.Size(1081, 227);
            this.DGVTestRange.TabIndex = 17;
            this.DGVTestRange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTestRange_CellContentClick);
            // 
            // ClmnRangeID
            // 
            this.ClmnRangeID.DataPropertyName = "RangeID";
            this.ClmnRangeID.HeaderText = "شناسه رنج";
            this.ClmnRangeID.Name = "ClmnRangeID";
            // 
            // ClmnTestID
            // 
            this.ClmnTestID.DataPropertyName = "TestID";
            this.ClmnTestID.HeaderText = "شناسه آزمایش";
            this.ClmnTestID.Name = "ClmnTestID";
            this.ClmnTestID.Visible = false;
            // 
            // ClmnTestName
            // 
            this.ClmnTestName.DataPropertyName = "TestName";
            this.ClmnTestName.HeaderText = "آزمایش";
            this.ClmnTestName.Name = "ClmnTestName";
            // 
            // ClmnMinValue
            // 
            this.ClmnMinValue.DataPropertyName = "MinValue";
            this.ClmnMinValue.HeaderText = "کمترین مقدار";
            this.ClmnMinValue.Name = "ClmnMinValue";
            this.ClmnMinValue.Width = 120;
            // 
            // ClmnMaxValue
            // 
            this.ClmnMaxValue.DataPropertyName = "MaxValue";
            this.ClmnMaxValue.HeaderText = "بیشترین مقدار";
            this.ClmnMaxValue.Name = "ClmnMaxValue";
            this.ClmnMaxValue.Width = 120;
            // 
            // ClmnGender
            // 
            this.ClmnGender.DataPropertyName = "Gender";
            this.ClmnGender.HeaderText = "جنسیت";
            this.ClmnGender.Name = "ClmnGender";
            // 
            // ClmnFromAge
            // 
            this.ClmnFromAge.DataPropertyName = "FromAge";
            this.ClmnFromAge.HeaderText = "از سن";
            this.ClmnFromAge.Name = "ClmnFromAge";
            // 
            // ClmnToAge
            // 
            this.ClmnToAge.DataPropertyName = "ToAge";
            this.ClmnToAge.HeaderText = "تا سن";
            this.ClmnToAge.Name = "ClmnToAge";
            // 
            // ClmnHazard
            // 
            this.ClmnHazard.DataPropertyName = "Hazard";
            this.ClmnHazard.HeaderText = "خطرناک";
            this.ClmnHazard.Name = "ClmnHazard";
            this.ClmnHazard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnHazard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.panel3.Location = new System.Drawing.Point(869, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 18;
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
            // lblInfoTest
            // 
            this.lblInfoTest.AutoSize = true;
            this.lblInfoTest.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInfoTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInfoTest.Location = new System.Drawing.Point(296, 292);
            this.lblInfoTest.Name = "lblInfoTest";
            this.lblInfoTest.Size = new System.Drawing.Size(0, 26);
            this.lblInfoTest.TabIndex = 19;
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // frmTestRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1081, 753);
            this.Controls.Add(this.lblInfoTest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVTestRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.CKBHazard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFromAge);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmTestRange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت رنج های آزمایش";
            this.Load += new System.EventHandler(this.frmTestRange_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestRange)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbFamle;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.CheckBox CKBHazard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchToMaximum;
        private System.Windows.Forms.TextBox txtSearchToAge;
        private System.Windows.Forms.TextBox txtSearchFromMinum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CKBSearchHazard;
        private System.Windows.Forms.TextBox txtSearchTest;
        private System.Windows.Forms.TextBox txtSearchFromAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVTestRange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbBothGender;
        private System.Windows.Forms.Label lblInfoTest;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnRangeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnMinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnMaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFromAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnToAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnHazard;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
    }
}