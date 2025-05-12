using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmTestRange: Form
    {
        int RangeID = 0;
        DataAccess.TestRangeRepository repo = new DataAccess.TestRangeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();
        public void BindGrid()
        {
            DGVTestRange.DataSource = null;
            DGVTestRange.AutoGenerateColumns = false;
            DGVTestRange.DataSource = repo.GetAllFormTestRange();
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    var txt = (System.Windows.Forms.TextBox)control;
                    txt.Text = "";
                }
                if (control is System.Windows.Forms.CheckBox)
                {
                    var cb = (System.Windows.Forms.CheckBox)control;
                    cb.Checked = false;
                }
                rdbMale.Checked = true;
                txtSearchFromAge.Text = "";
                txtSearchFromMinum.Text = "";
                txtSearchTest.Text = "";
                txtSearchToAge.Text = "";
                txtSearchToMaximum.Text = "";
                CKBSearchHazard.Checked = false;
                lstTest.Visible = false;    
                
            }
        }
        #region 
        void GoToAddMode()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancle.Visible = false;
        }
        void GoToEditMode()
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancle.Visible = true;
        }
        #endregion ManagmentButtons
        public frmTestRange()
        {
            InitializeComponent();
        }

        private void frmTestRange_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
            err.Clear();
            BindGrid();
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTest.Text))
            {
                lstTest.Visible = true;
                lstTest.DataSource = repoTest.GetAllTestForListBoxFormTestRange(txtTest.Text);
                lstTest.ValueMember = "TestID";
                lstTest.DisplayMember = "FullInfoTest";
            }
            else
            {
                lstTest.Visible = false;
            }
        }

        private void lstTest_DoubleClick(object sender, EventArgs e)
        {
            int TestID = Convert.ToInt32(lstTest.SelectedValue);
            Test Test = repoTest.Get(TestID);
            txtTest.Text = Test.TestName;
            if (Test.GenderHasEfect == null)
            {
                rdbBothGender.Checked = true;
                lblInfoTest.Text = "";
            }
            else if (Test.GenderHasEfect == false)
            {
                lblInfoTest.Text = "با توجه به تاثیر جنسیت بر آزمایشی که انتخاب کرده اید خواهشمند است برای رنچ این آزمایش جنسیت بین زن و مرد را انتخاب کنید ";
                rdbBothGender.Enabled = true;
            }
            else if (Test.GenderHasEfect == true)
            {
                lblInfoTest.Text = "با توجه به تاثیر جنسیت بر آزمایشی که انتخاب کرده اید خواهشمند است برای رنچ این آزمایش جنسیت بین زن و مرد را انتخاب کنید";
                rdbBothGender.Enabled = true;
            }
            lstTest.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstTest.SelectedItems == null)
            {
                err.SetError(lstTest, "یک آزمایش را از لیست انتخاب کنید");
                return;
            }
            TestRange testRange = new TestRange();
            testRange.TestID = Convert.ToInt32(lstTest.SelectedValue);
            testRange.MinValue = Convert.ToDouble(txtMinValue.Text);
            testRange.MaxValue = Convert.ToDouble(txtMaxValue.Text);
            testRange.FromAge = Convert.ToInt32(txtFromAge.Text);
            testRange.ToAge = Convert.ToInt32(txtToAge.Text);
            testRange.Description = txtDescription.Text;
            if (CKBHazard.Checked == true)
            {
                testRange.Hazard = true;
            }
            else if(CKBHazard.Checked == false)
            {
                testRange.Hazard = false;
            }
            if (rdbMale.Checked == true)
            {
                testRange.Gender = 1;
            }
            else if (rdbFamle.Checked == true)
            {
                testRange.Gender = 0;
            }
            else if (rdbBothGender.Checked == true)
            {
                testRange.Gender = 3;
            }
            repo.Add(testRange);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
            err.Clear();

        }

        private void DGVTestRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RangeID = Convert.ToInt32(DGVTestRange.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {
                
                TestRange testRange = repo.Get(RangeID);
                txtFromAge.Text = testRange.FromAge.ToString();
                txtToAge.Text = testRange.ToAge.ToString();
                txtMinValue.Text = testRange.MinValue.ToString();
                txtMaxValue.Text = testRange.MaxValue.ToString();
                txtDescription.Text = testRange.Description;
                txtTest.Text = repoTest.Get(testRange.TestID).TestName;
                bool? GenderEffect = repoTest.Get(testRange.TestID).GenderHasEfect;
                if (GenderEffect == null)
                {
                    rdbBothGender.Enabled = false;
                    rdbBothGender.Checked = false;
                }
                if (testRange.Hazard == true)
                {
                    CKBHazard.Checked = true;
                }
                else if (testRange.Hazard == false)
                {
                    CKBHazard.Checked = false;
                }
                if (testRange.Gender == 1)
                {
                    rdbMale.Checked = true;
                }
                else if(testRange.Gender == 0)
                {
                    rdbFamle.Checked = true;   
                }
                else if(testRange.Gender == 3)
                {
                    rdbBothGender.Checked = true;
                }
                GoToEditMode();
                err.Clear();
            }
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا مطمئن هستید میخواهید این رنچ را حذف کنید ؟","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    repo.Delete(RangeID);
                    CleanForm();
                    GoToAddMode();
                    BindGrid();
                    err.Clear();
                }
                else
                {
                    GoToAddMode();
                    CleanForm();
                    err.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TestRange testRange = new TestRange();
            if (txtTest.Text == repoTest.Get(Convert.ToInt32(lstTest.SelectedValue)).TestName)
            {
                testRange.TestID = repoTest.Get(Convert.ToInt32(lstTest.SelectedValue)).TestID;
            }
            if (rdbBothGender.Enabled == false)
            {

                if (!rdbMale.Checked && !rdbFamle.Checked)
                {
                    err.SetError(grpGender, "لطفاً یکی از گزینه‌های مرد یا زن را انتخاب کنید.");
                    return;
                }
            }
            if (rdbBothGender.Checked)
            {
                testRange.Gender = 3;
            }
            else if (rdbMale.Checked == true)
            {
                testRange.Gender = 1;
            }
            else if (rdbFamle.Checked == true)
            {
                testRange.Gender =0;
            }
            if (CKBHazard.Checked == true)
            {
                testRange.Hazard = true;
            }
            else if(CKBHazard.Checked == false)
            {
                testRange.Hazard = false;   
            }
            testRange.MinValue = Convert.ToDouble(txtMinValue.Text);
            testRange.MaxValue = Convert.ToDouble(txtMaxValue.Text);
            testRange.FromAge = Convert.ToInt32(txtFromAge.Text);
            testRange.ToAge = Convert.ToInt32(txtToAge.Text);
            testRange.Description = txtDescription.Text;
            testRange.RangeID = this.RangeID;
            repo.Update(testRange);
            GoToAddMode();
            CleanForm();
            BindGrid();
            err.Clear();
        }
    }
}
