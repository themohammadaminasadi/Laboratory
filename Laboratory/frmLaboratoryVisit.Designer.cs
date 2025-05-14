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
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddPatientTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPatientTestHederID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblNationalCodePatient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel1.Size = new System.Drawing.Size(1164, 245);
            this.panel1.TabIndex = 0;
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 24;
            this.lstPatient.Location = new System.Drawing.Point(871, 59);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(209, 172);
            this.lstPatient.TabIndex = 2;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(871, 29);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(209, 31);
            this.txtPatient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1095, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "بیمار";
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(640, 37);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(117, 20);
            this.faDatePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(763, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(383, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام دکتر";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(135, 32);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(233, 31);
            this.txtDrName.TabIndex = 5;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(504, 107);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(233, 31);
            this.txtNationalCode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(752, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "کد ملی ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(135, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(233, 31);
            this.txtAge.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(412, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "سن";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPatient.Location = new System.Drawing.Point(12, 202);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(116, 36);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "ثبت بیمار جدید";
            this.btnAddPatient.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(171, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "کد ملی ";
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
            // frmLaboratoryVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1490, 710);
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
            this.ResumeLayout(false);

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
    }
}
