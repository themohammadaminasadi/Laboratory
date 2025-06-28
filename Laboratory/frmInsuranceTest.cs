using DataAccess;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmInsuranceTest: Form
    {
        private int InsuranceTestID = 0;
        private int TestID = 0;
        private int InsuranceID = 0;
        private InsuranceTestRepository repo = new InsuranceTestRepository();
        private TestRepository repoTest = new TestRepository();
        private void BindCombo()
        {
            var listCombo = new DataAccess.InsuranceRepository().GetAll();
            listCombo.Insert(0, new DoaminModel.Models.Insurance { InsuranceID = -1, InsuranceTypeName = "انتخاب کنید" });
            cmbInsurance.DataSource = null;
            cmbInsurance.DataSource = listCombo;
            cmbInsurance.ValueMember = "InsuranceID";
            cmbInsurance.DisplayMember = "InsuranceTypeName";
        }
        public void BindGrid()
        {
            dataGridViewInsuraceTest.DataSource = null;
            dataGridViewInsuraceTest.AutoGenerateColumns = false;
            dataGridViewInsuraceTest.DataSource = repo.GetAllFromViewModel();
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            txtDiscount.Text = "";
            txtTest.Text = "";
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    cmb.SelectedIndex = 0;
                }
            }
            lblErrorDiscount.Text = "";
            lblErrorYear.Text = "";
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
        public frmInsuranceTest()
        {
            InitializeComponent();
        }

        private void frmInsuranceTest_Load(object sender, EventArgs e)
        {
            try
            {
                BindCombo();
                CleanForm();
                BindGrid();
                GoToAddMode();
                lstTest.Visible = false;
                PersianCalendar pc = new PersianCalendar();
                txtYear.Text = pc.GetYear(DateTime.Now).ToString();
                txtYear.Enabled = false;
                err.Clear();
                dataGridViewInsuraceTest.ScrollBars = ScrollBars.Both;
                dataGridViewInsuraceTest.Height = 300;
            }
            catch (Exception)
            {

                throw new Exception("ارور در لود صفحه : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTest.Text))
            {
              lstTest.DisplayMember = "TestName";
              lstTest.ValueMember = "TestID";
              lstTest.Visible = true;
              lstTest.DataSource = repoTest.GetAllTestForListViewFormInsuranceTest(txtTest.Text);
            }
            else
            {
                lstTest.DataSource =null;
            }
        }

        private void lstTest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                TestID = Convert.ToInt32(lstTest.SelectedValue);
                Test Test = repoTest.Get(TestID);
                txtTest.Text = Test.TestName;
                lstTest.Visible = false;
            }
            catch (Exception)
            {

                throw new Exception("ارور در موس کلیک : خواهمشند است با مدیر سیستم تماس بگیرید");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInsurance.SelectedIndex <= 0)
                {
                    err.SetError(cmbInsurance, "بیمه را باید انتخاب کنید");
                    return;
                }
                if (lstTest.SelectedIndex < 0)
                {
                    MessageBox.Show("خواهشمند است از روی لیست ازمایشات یک آزمایش را انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    lblErrorDiscount.Text = "خواهشمند درصد فرانشیز را انتخاب کنید ";
                    return;
                }
                if (string.IsNullOrEmpty(txtYear.Text))
                {

                    lblErrorYear.Text = "سال به صورت اتوماتیک انتخاب نشده است خواهشمند است با مدیر سامانه تماس بگیرید";
                    return;
                }
                InsuranceTest insuranceTest = new InsuranceTest
                {
                    InsuraneID = Convert.ToInt32(cmbInsurance.SelectedValue),
                    TestID = Convert.ToInt32(lstTest.SelectedValue),
                    Year = Convert.ToInt32(txtYear.Text),
                    Discount = Convert.ToInt32(txtDiscount.Text)
                };
                if (insuranceTest.Discount > 100)
                {
                    MessageBox.Show("فرانشیز نمیتواند بیشتر از 100 درصد باشد");
                    return;
                }
                if (repo.InsertDuplicateInsurance(insuranceTest.TestID , insuranceTest.InsuraneID))
                {
                    MessageBox.Show("این رکورد قبلاً وارد شده است ");
                    return;
                }
                repo.Add(insuranceTest);
                BindGrid();
                CleanForm();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در اضافه کردن : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
          


        }

        private void dataGridViewInsuraceTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                InsuranceTestID = Convert.ToInt32(dataGridViewInsuraceTest.Rows[e.RowIndex].Cells[0].Value);
                InsuranceID = Convert.ToInt32(dataGridViewInsuraceTest.Rows[e.RowIndex].Cells["ClmnInsuranceID"].Value);
                TestID = Convert.ToInt32(dataGridViewInsuraceTest.Rows[e.RowIndex].Cells["ClmnTestID"].Value);
                if (e.ColumnIndex == 7)
                {
                    InsuranceTest insuranceTest = repo.Get(InsuranceTestID);
                    txtDiscount.Text = insuranceTest.Discount.ToString();
                    txtYear.Text = insuranceTest.Year.ToString();
                    txtTest.Text = repoTest.Get(insuranceTest.TestID).TestName;
                    cmbInsurance.SelectedValue = insuranceTest.InsuraneID;
                    GoToEditMode();
                    lstTest.Visible = false;
                }
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("آیا مطمئن هستید که میخواهید این رکورد را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.ExsistInsuranceTestInOtherTable(InsuranceID,TestID))
                        {
                            MessageBox.Show("این رکورد دارای سابقه می باشد امکان حذف آن وجود ندارد");
                            return;
                        }
                        else
                        {
                            repo.Delete(InsuranceTestID);
                            CleanForm();
                            BindGrid();
                            GoToAddMode();
                            err.Clear();
                        }
                    }
                    else
                    {
                        CleanForm();
                        GoToAddMode();
                        err.Clear();

                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("ارور در گرید : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه انصراف : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInsurance.SelectedIndex <= 0)
                {
                    err.SetError(cmbInsurance, "بیمه را باید انتخاب کنید");
                    return;
                }
                if (!txtDiscount.Text.All(c=>char.IsDigit(c)))
                {
                    err.SetError(txtDiscount, "فرانشیز نمیتواند به غیر از عدد باشد");
                    return;
                }
                
                if (lstTest.SelectedIndex < 0)
                {
                    MessageBox.Show("خواهشمند است از روی لیست ازمایشات یک آزمایش را انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    lblErrorDiscount.Text = "خواهشمند درصد فرانشیز را انتخاب کنید ";
                    return;
                }
                if (string.IsNullOrEmpty(txtYear.Text))
                {

                    lblErrorYear.Text = "سال به صورت اتوماتیک انتخاب نشده است خواهشمند است با مدیر سامانه تماس بگیرید";
                    return;
                }
                InsuranceTest insuranceTest = new InsuranceTest
                {
                    InsuraneID = Convert.ToInt32(cmbInsurance.SelectedValue),
                    Discount = Convert.ToInt32(txtDiscount.Text),
                    Year = Convert.ToInt32(txtYear.Text),
                    TestID = Convert.ToInt32(lstTest.SelectedValue),
                    InsuranceTestID = this.InsuranceTestID
                };
                //if (repo.InsertDuplicateInsurance(insuranceTest.TestID, insuranceTest.InsuraneID))
                //{
                //    MessageBox.Show("این رکورد قبلاً وارد شده است ");
                //    return;
                //}
                if (insuranceTest.Discount > 100)
                {
                    MessageBox.Show("فرانشیز نمیتواند بیشتر از 100 درصد باشد");
                    return;
                }
                repo.Update(insuranceTest);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه ویرایش : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Trim().Length == 0)
            {
                return;
            }
            if (!txtDiscount.Text.Trim().All(c=>char.IsDigit(c)))
            {
                txtDiscount.Text = "";
                return;

            }
        }
    }
}
