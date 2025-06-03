namespace Laboratory
{
    partial class frmInsuranceTest
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
            this.dataGridViewInsuraceTest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorDiscount = new System.Windows.Forms.Label();
            this.lblErrorYear = new System.Windows.Forms.Label();
            this.ClmnInsuranceTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnInsuranceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnInsuranceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsuraceTest)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInsuraceTest
            // 
            this.dataGridViewInsuraceTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInsuraceTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInsuraceTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInsuraceTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnInsuranceTestID,
            this.ClmnTestID,
            this.ClmnTestName,
            this.ClmnInsuranceID,
            this.ClmnInsuranceType,
            this.ClmnYear,
            this.ClmnDiscount,
            this.ClmnEdit,
            this.ClmnDelete});
            this.dataGridViewInsuraceTest.Location = new System.Drawing.Point(3, 441);
            this.dataGridViewInsuraceTest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewInsuraceTest.Name = "dataGridViewInsuraceTest";
            this.dataGridViewInsuraceTest.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewInsuraceTest.RowTemplate.Height = 25;
            this.dataGridViewInsuraceTest.Size = new System.Drawing.Size(1340, 706);
            this.dataGridViewInsuraceTest.TabIndex = 0;
            this.dataGridViewInsuraceTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInsuraceTest_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "بیمه";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(77, 34);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(187, 32);
            this.cmbInsurance.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(516, 183);
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
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(77, 109);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(187, 31);
            this.txtTest.TabIndex = 10;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 24;
            this.lstTest.Location = new System.Drawing.Point(77, 139);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(187, 172);
            this.lstTest.TabIndex = 11;
            this.lstTest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTest_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "آزمایش";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(461, 34);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(187, 31);
            this.txtDiscount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(405, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "فرانشیز";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(405, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "سال";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(461, 106);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(187, 31);
            this.txtYear.TabIndex = 15;
            // 
            // err
            // 
            this.err.BlinkRate = 500;
            this.err.ContainerControl = this;
            // 
            // lblErrorDiscount
            // 
            this.lblErrorDiscount.AutoSize = true;
            this.lblErrorDiscount.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDiscount.Location = new System.Drawing.Point(462, 72);
            this.lblErrorDiscount.Name = "lblErrorDiscount";
            this.lblErrorDiscount.Size = new System.Drawing.Size(0, 19);
            this.lblErrorDiscount.TabIndex = 17;
            // 
            // lblErrorYear
            // 
            this.lblErrorYear.AutoSize = true;
            this.lblErrorYear.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorYear.ForeColor = System.Drawing.Color.Red;
            this.lblErrorYear.Location = new System.Drawing.Point(462, 140);
            this.lblErrorYear.Name = "lblErrorYear";
            this.lblErrorYear.Size = new System.Drawing.Size(0, 19);
            this.lblErrorYear.TabIndex = 18;
            // 
            // ClmnInsuranceTestID
            // 
            this.ClmnInsuranceTestID.DataPropertyName = "InsuranceTestID";
            this.ClmnInsuranceTestID.HeaderText = "شناسه";
            this.ClmnInsuranceTestID.Name = "ClmnInsuranceTestID";
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
            this.ClmnTestName.HeaderText = "نام آزمایش";
            this.ClmnTestName.Name = "ClmnTestName";
            // 
            // ClmnInsuranceID
            // 
            this.ClmnInsuranceID.DataPropertyName = "InsuranceID";
            this.ClmnInsuranceID.HeaderText = "شناسه بیمه";
            this.ClmnInsuranceID.Name = "ClmnInsuranceID";
            this.ClmnInsuranceID.Visible = false;
            // 
            // ClmnInsuranceType
            // 
            this.ClmnInsuranceType.DataPropertyName = "InsuranceType";
            this.ClmnInsuranceType.HeaderText = "نام بیمه";
            this.ClmnInsuranceType.Name = "ClmnInsuranceType";
            // 
            // ClmnYear
            // 
            this.ClmnYear.DataPropertyName = "Year";
            this.ClmnYear.HeaderText = "سال";
            this.ClmnYear.Name = "ClmnYear";
            // 
            // ClmnDiscount
            // 
            this.ClmnDiscount.DataPropertyName = "Discount";
            this.ClmnDiscount.HeaderText = "فرانشیز";
            this.ClmnDiscount.Name = "ClmnDiscount";
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
            // frmInsuranceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(747, 651);
            this.Controls.Add(this.lblErrorYear);
            this.Controls.Add(this.lblErrorDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbInsurance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInsuraceTest);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmInsuranceTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmInsuranceTest";
            this.Load += new System.EventHandler(this.frmInsuranceTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsuraceTest)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInsuraceTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lblErrorYear;
        private System.Windows.Forms.Label lblErrorDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnInsuranceTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnInsuranceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnInsuranceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnDelete;
    }
}