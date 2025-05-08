namespace Laboratory
{
    partial class frmPatient
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
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.ClmnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFamle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchNationalCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPatientID,
            this.ClmnFirstName,
            this.ClmnLastName,
            this.ClmnNationalCode,
            this.ClmnPhoneNumber,
            this.ClmnAge,
            this.ClmnGender,
            this.ClmnEdit,
            this.ClmnDelete});
            this.dataGridViewPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPatient.Location = new System.Drawing.Point(0, 688);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.Size = new System.Drawing.Size(1056, 224);
            this.dataGridViewPatient.TabIndex = 0;
            this.dataGridViewPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellContentClick);
            // 
            // ClmnPatientID
            // 
            this.ClmnPatientID.DataPropertyName = "PatientID";
            this.ClmnPatientID.HeaderText = "شناسه ";
            this.ClmnPatientID.Name = "ClmnPatientID";
            // 
            // ClmnFirstName
            // 
            this.ClmnFirstName.DataPropertyName = "FirstName";
            this.ClmnFirstName.HeaderText = "نام ";
            this.ClmnFirstName.Name = "ClmnFirstName";
            // 
            // ClmnLastName
            // 
            this.ClmnLastName.DataPropertyName = "LastName";
            this.ClmnLastName.HeaderText = "نام خانوادگی";
            this.ClmnLastName.Name = "ClmnLastName";
            // 
            // ClmnNationalCode
            // 
            this.ClmnNationalCode.DataPropertyName = "NationalCode";
            this.ClmnNationalCode.HeaderText = "کد ملی";
            this.ClmnNationalCode.Name = "ClmnNationalCode";
            // 
            // ClmnPhoneNumber
            // 
            this.ClmnPhoneNumber.DataPropertyName = "PhoneNumber";
            this.ClmnPhoneNumber.HeaderText = "تلفن";
            this.ClmnPhoneNumber.Name = "ClmnPhoneNumber";
            // 
            // ClmnAge
            // 
            this.ClmnAge.DataPropertyName = "Age";
            this.ClmnAge.HeaderText = "سن";
            this.ClmnAge.Name = "ClmnAge";
            // 
            // ClmnGender
            // 
            this.ClmnGender.DataPropertyName = "Gender";
            this.ClmnGender.HeaderText = "جنسیت";
            this.ClmnGender.Name = "ClmnGender";
            // 
            // ClmnEdit
            // 
            this.ClmnEdit.HeaderText = "ویرایش";
            this.ClmnEdit.Name = "ClmnEdit";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNationalCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Location = new System.Drawing.Point(36, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 410);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(281, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "توضیحات";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(17, 144);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 116);
            this.txtDescription.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFamle);
            this.groupBox1.Font = new System.Drawing.Font("Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(420, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جنسیت";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbMale.Location = new System.Drawing.Point(183, 23);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(42, 25);
            this.rdbMale.TabIndex = 3;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "آقا";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFamle
            // 
            this.rdbFamle.AutoSize = true;
            this.rdbFamle.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbFamle.Location = new System.Drawing.Point(54, 23);
            this.rdbFamle.Name = "rdbFamle";
            this.rdbFamle.Size = new System.Drawing.Size(48, 25);
            this.rdbFamle.TabIndex = 4;
            this.rdbFamle.TabStop = true;
            this.rdbFamle.Text = "خانم";
            this.rdbFamle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(690, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "سن";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(420, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(205, 31);
            this.txtAge.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(309, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "تلفن";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(17, 90);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(240, 31);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(294, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "کدملی";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(17, 33);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(240, 31);
            this.txtNationalCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(631, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(420, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 31);
            this.txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(693, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(420, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 31);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "اطلاعات بیمار";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(832, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 9;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSearchPhoneNumber);
            this.panel2.Controls.Add(this.txtSearchFirstName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtSearchLastName);
            this.panel2.Controls.Add(this.txtSearchNationalCode);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(36, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 174);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(291, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "تلفن";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(631, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "نام خانوادگی";
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(27, 92);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(240, 31);
            this.txtSearchPhoneNumber.TabIndex = 16;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(420, 35);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(205, 31);
            this.txtSearchFirstName.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(291, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "کدملی";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(420, 92);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(205, 31);
            this.txtSearchLastName.TabIndex = 16;
            // 
            // txtSearchNationalCode
            // 
            this.txtSearchNationalCode.Location = new System.Drawing.Point(27, 35);
            this.txtSearchNationalCode.Name = "txtSearchNationalCode";
            this.txtSearchNationalCode.Size = new System.Drawing.Size(240, 31);
            this.txtSearchNationalCode.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(693, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "نام";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(45, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "پنل جست و جو";
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(671, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 30);
            this.label13.TabIndex = 15;
            this.label13.Text = "آدرس";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 278);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(608, 116);
            this.txtAddress.TabIndex = 14;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 912);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPatient);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmPatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت بیمار";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnGender;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFamle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchNationalCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
    }
}