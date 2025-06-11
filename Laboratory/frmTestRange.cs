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
using static System.Net.Mime.MediaTypeNames;

namespace Laboratory
{
    public partial class frmTestRange: Form
    {
        //کنترل اینکه در تکس باکس ها فقط عدد و رشته وارد شود . 
        int RangeID = 0;
        DataAccess.TestRangeRepository repo = new DataAccess.TestRangeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();
        int TestID = 0;
        public void Search(DoaminModel.ViewModel.TestRange.ListSearchItemForSearchPanelTestRange sm)
        {
            DGVTestRange.DataSource = repo.Search(sm);
        }
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
            try
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
            catch (Exception ex)
            {

                throw new Exception("با پشتیبانی تماس بگیرید " + ex);
            }
          
        }

        private void lstTest_DoubleClick(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                throw new Exception("روی listBox ارور به وجود آمده است با پشتیبانی تماس بگیرید" + ex);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTest.Text))
                {
                    MessageBox.Show("آزمایش را باید انتخاب کنید ");
                    return;
                }
                if (lstTest.SelectedIndex < 0)
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
                else if (CKBHazard.Checked == false)
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
                lblInfoTest.Text = "";
            }
            catch (Exception ex)
            {

                throw new Exception("عملیات اضافه کردن به مشکل خورد لطفاً با پشتیبانی تماس بگیرید"+ex);
            }
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                err.Clear();
                lblInfoTest.Text = "";
            }
            catch (Exception)
            {

                throw new Exception("Error In btn Cancle");
            }
           

        }

        private void DGVTestRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                RangeID = Convert.ToInt32(DGVTestRange.Rows[e.RowIndex].Cells[0].Value);
                TestID = Convert.ToInt32(DGVTestRange.Rows[e.RowIndex].Cells["ClmnTestID"].Value);
                
                if (e.ColumnIndex == 9)
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
                    else if (testRange.Gender == 0)
                    {
                        rdbFamle.Checked = true;
                    }
                    else if (testRange.Gender == 3)
                    {
                        rdbBothGender.Checked = true;
                    }
                    GoToEditMode();
                    err.Clear();
                }
                if (e.ColumnIndex == 10)
                {
                    if (MessageBox.Show("آیا مطمئن هستید میخواهید این رنچ را حذف کنید ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.ExsistLogInOtherTable(TestID))
                        {
                            MessageBox.Show("این رکورد دارای سابقه می باشد");
                            return;
                        }
                        else
                        {
                            repo.Delete(RangeID);
                            CleanForm();
                            GoToAddMode();
                            BindGrid();
                            err.Clear();
                        }
                           
                    }
                    else
                    {
                        GoToAddMode();
                        CleanForm();
                        err.Clear();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("در دکمه ویرایش یا حذف در گرید با مشکل رو به رو شده است با پشتیبانی تماس بگیرید" + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                else if (CKBHazard.Checked == false)
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
                lblInfoTest.Text = "";
            }
            catch (Exception ex)
            {

                throw new Exception("عملیات ویرایش با موفقیت انجام نشد با پشتیبانی تماس بگیرید"+ex);
            }
        }
        private void DoSearch()
        {
            try
            {
                DoaminModel.ViewModel.TestRange.ListSearchItemForSearchPanelTestRange sm = new DoaminModel.ViewModel.TestRange.ListSearchItemForSearchPanelTestRange();
                if (!string.IsNullOrEmpty(txtSearchTest.Text))
                {
                    sm.TestName = txtSearchTest.Text;
                }
                if (!string.IsNullOrEmpty(txtSearchFromMinum.Text))
                {
                    sm.MinValue = Convert.ToDouble(txtSearchFromMinum.Text);
                }
                if (!string.IsNullOrEmpty(txtSearchToMaximum.Text))
                {
                    sm.MaxValue = Convert.ToInt32(txtSearchToMaximum.Text);
                }
                if (!string.IsNullOrEmpty(txtSearchFromAge.Text))
                {
                    sm.FromAge = Convert.ToInt32(txtSearchFromAge.Text);
                }
                if (!string.IsNullOrEmpty(txtSearchToAge.Text))
                {
                    sm.ToAge = Convert.ToInt32(txtSearchToAge.Text);
                }

                DGVTestRange.DataSource = repo.Search(sm);
            }
            catch (Exception ex)
            {

                throw new Exception("در تابع search مشکل ایجاد شده است خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
           
        }
        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void txtSearchFromAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchFromAge.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtSearchFromAge.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("کمترین سن باید عدد باشد");
                    txtSearchFromAge.Text = "";
                    return;
                }
                DoSearch();
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }

        private void txtSearchToAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchToAge.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtSearchToAge.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("بیشترین سن باید عدد باشد");
                    txtSearchToAge.Text = "";
                    return;
                }
                DoSearch();
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }

        private void txtSearchFromMinum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchFromMinum.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtSearchFromMinum.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("کمترین رنج باید عدد باشد");
                    txtSearchFromMinum.Text = "";
                    return;
                }
                DoSearch();
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
            
        }

        private void txtSearchToMaximum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchToMaximum.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtSearchToMaximum.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("بیشترین رنج باید عدد باشد");
                    txtSearchToMaximum.Text = "";
                    return;
                }
                DoSearch();
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
            
        }

        private void CKBSearchHazard_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void txtSearchFromMinum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // فقط یک نقطه اعشاری اجازه بده
            if (e.KeyChar == '.' && txtSearchFromMinum.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtSearchToMaximum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMinValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMinValue.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtMinValue.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("کمترین رنج باید عدد باشد");
                    txtMinValue.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show( "خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }

        private void txtMaxValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMaxValue.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtMaxValue.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("بیشترین رنج باید عدد باشد");
                    txtMaxValue.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }

        private void txtFromAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFromAge.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtFromAge.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("کمترین سن باید عدد باشد");
                    txtFromAge.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }

        private void txtToAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtToAge.Text.Trim().Length == 0)
                {
                    return;
                }
                if (!txtToAge.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("بیشترین سن باید عدد باشد");
                    txtToAge.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("خواهشمند است با مدیر سیستم تماس بگیرید" +  ex.Message);
                return;
            }
        }
    }
}
