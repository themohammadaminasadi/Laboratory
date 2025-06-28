namespace Laboratory
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfoUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbDiActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlInfoUser = new System.Windows.Forms.Panel();
            this.cmbEmployeeAction = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.ClmnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInfoUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(1024, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 8;
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
            // lblInfoUser
            // 
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInfoUser.Location = new System.Drawing.Point(64, 253);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(107, 29);
            this.lblInfoUser.TabIndex = 4;
            this.lblInfoUser.Text = "اطلاعات کاربری";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(415, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "رمز";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(781, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "نام کاربری ";
            // 
            // rdbDiActive
            // 
            this.rdbDiActive.AutoSize = true;
            this.rdbDiActive.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbDiActive.Location = new System.Drawing.Point(134, 35);
            this.rdbDiActive.Name = "rdbDiActive";
            this.rdbDiActive.Size = new System.Drawing.Size(65, 27);
            this.rdbDiActive.TabIndex = 1;
            this.rdbDiActive.TabStop = true;
            this.rdbDiActive.Text = "غیرفعال";
            this.rdbDiActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbActive.Location = new System.Drawing.Point(360, 35);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(49, 27);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "فعال";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(291, 31);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(490, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(291, 31);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDiActive);
            this.groupBox1.Controls.Add(this.rdbActive);
            this.groupBox1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(322, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت کاربری";
            // 
            // pnlInfoUser
            // 
            this.pnlInfoUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfoUser.Controls.Add(this.label2);
            this.pnlInfoUser.Controls.Add(this.cmbEmployeeAction);
            this.pnlInfoUser.Controls.Add(this.txtPassword);
            this.pnlInfoUser.Controls.Add(this.btnShow);
            this.pnlInfoUser.Controls.Add(this.txtUserName);
            this.pnlInfoUser.Controls.Add(this.groupBox1);
            this.pnlInfoUser.Controls.Add(this.label7);
            this.pnlInfoUser.Controls.Add(this.label8);
            this.pnlInfoUser.Location = new System.Drawing.Point(45, 272);
            this.pnlInfoUser.Name = "pnlInfoUser";
            this.pnlInfoUser.Size = new System.Drawing.Size(887, 222);
            this.pnlInfoUser.TabIndex = 7;
            // 
            // cmbEmployeeAction
            // 
            this.cmbEmployeeAction.FormattingEnabled = true;
            this.cmbEmployeeAction.Location = new System.Drawing.Point(53, 123);
            this.cmbEmployeeAction.Name = "cmbEmployeeAction";
            this.cmbEmployeeAction.Size = new System.Drawing.Size(180, 32);
            this.cmbEmployeeAction.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.Font = new System.Drawing.Font("B Nazanin", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.Location = new System.Drawing.Point(111, 35);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(45, 30);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(399, 142);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(291, 31);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(723, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "عنوان";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(19, 85);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(291, 31);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(19, 34);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(291, 31);
            this.txtNationalCode.TabIndex = 6;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(399, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 31);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(399, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 31);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(324, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "تلفن ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(309, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "کد ملی ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(700, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(749, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "اطلاعات هویتی";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtNationalCode);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(45, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 197);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnEmployeeID,
            this.ClmnTitle,
            this.ClmnFirstName,
            this.ClmnLastName,
            this.ClmnUserName,
            this.ClmnPassword,
            this.ClmnNationalCode,
            this.ClmnPhoneNumber,
            this.ClmnEdit,
            this.ClmnDelete});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(1, 541);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewEmployee.RowTemplate.Height = 25;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1301, 212);
            this.dataGridViewEmployee.TabIndex = 9;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // ClmnEmployeeID
            // 
            this.ClmnEmployeeID.DataPropertyName = "EmployeeID";
            this.ClmnEmployeeID.HeaderText = "شناسه کارمند";
            this.ClmnEmployeeID.MinimumWidth = 6;
            this.ClmnEmployeeID.Name = "ClmnEmployeeID";
            this.ClmnEmployeeID.Width = 120;
            // 
            // ClmnTitle
            // 
            this.ClmnTitle.DataPropertyName = "Title";
            this.ClmnTitle.HeaderText = "عنوان";
            this.ClmnTitle.MinimumWidth = 6;
            this.ClmnTitle.Name = "ClmnTitle";
            this.ClmnTitle.Width = 125;
            // 
            // ClmnFirstName
            // 
            this.ClmnFirstName.DataPropertyName = "FirstName";
            this.ClmnFirstName.HeaderText = "نام";
            this.ClmnFirstName.MinimumWidth = 6;
            this.ClmnFirstName.Name = "ClmnFirstName";
            this.ClmnFirstName.Width = 125;
            // 
            // ClmnLastName
            // 
            this.ClmnLastName.DataPropertyName = "LastName";
            this.ClmnLastName.HeaderText = "نام خانوادگی";
            this.ClmnLastName.MinimumWidth = 6;
            this.ClmnLastName.Name = "ClmnLastName";
            this.ClmnLastName.Width = 125;
            // 
            // ClmnUserName
            // 
            this.ClmnUserName.DataPropertyName = "UserName";
            this.ClmnUserName.HeaderText = "نام کاربری";
            this.ClmnUserName.MinimumWidth = 6;
            this.ClmnUserName.Name = "ClmnUserName";
            this.ClmnUserName.Width = 125;
            // 
            // ClmnPassword
            // 
            this.ClmnPassword.DataPropertyName = "Password";
            this.ClmnPassword.HeaderText = "رمز عبور";
            this.ClmnPassword.MinimumWidth = 6;
            this.ClmnPassword.Name = "ClmnPassword";
            this.ClmnPassword.Width = 125;
            // 
            // ClmnNationalCode
            // 
            this.ClmnNationalCode.DataPropertyName = "NationalCode";
            this.ClmnNationalCode.HeaderText = "کد ملی";
            this.ClmnNationalCode.MinimumWidth = 6;
            this.ClmnNationalCode.Name = "ClmnNationalCode";
            this.ClmnNationalCode.Width = 125;
            // 
            // ClmnPhoneNumber
            // 
            this.ClmnPhoneNumber.DataPropertyName = "PhoneNumber";
            this.ClmnPhoneNumber.HeaderText = "تلفن";
            this.ClmnPhoneNumber.MinimumWidth = 6;
            this.ClmnPhoneNumber.Name = "ClmnPhoneNumber";
            this.ClmnPhoneNumber.Width = 125;
            // 
            // ClmnEdit
            // 
            this.ClmnEdit.HeaderText = "ویرایش";
            this.ClmnEdit.MinimumWidth = 6;
            this.ClmnEdit.Name = "ClmnEdit";
            this.ClmnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnEdit.Text = "ویرایش";
            this.ClmnEdit.UseColumnTextForButtonValue = true;
            this.ClmnEdit.Width = 125;
            // 
            // ClmnDelete
            // 
            this.ClmnDelete.HeaderText = "حذف";
            this.ClmnDelete.MinimumWidth = 6;
            this.ClmnDelete.Name = "ClmnDelete";
            this.ClmnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnDelete.Text = "حذف";
            this.ClmnDelete.UseColumnTextForButtonValue = true;
            this.ClmnDelete.Width = 125;
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(239, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "دسترسی";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1304, 753);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblInfoUser);
            this.Controls.Add(this.pnlInfoUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت کارمندان";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInfoUser.ResumeLayout(false);
            this.pnlInfoUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInfoUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbDiActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlInfoUser;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPhoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
        private System.Windows.Forms.ComboBox cmbEmployeeAction;
        private System.Windows.Forms.Label label2;
    }
}