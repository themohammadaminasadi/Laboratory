using DataAccess;
using DoaminModel.Models;
using DoaminModel.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laboratory
{
    public partial class frmLaboratoryVisit: Form
    {
        private int PaitentID = 0;
        private string UserName;
        private int PaitentHeaderID = 0;
        private int PatientTestDetailsID = 0;
        private int TestID = 0;
        private int EmployeeID = 0;
        private int InsuranceID = 0;
        
        private PatientHeaderRepository repo = new PatientHeaderRepository();
        private PatientRepository repoPatient = new PatientRepository();
        InsuranceTestRepository insuranceTestRepository = new InsuranceTestRepository();
        TestRepository repoTest = new TestRepository();
        public frmLaboratoryVisit(string userName)
        {
            InitializeComponent();
            this.UserName = userName;
            
        }
        private void BindCombo()
        {
            cmbInsurance.DataSource = null;
            cmbInsurance.ValueMember = "InsuranceID";
            cmbInsurance.DisplayMember = "InsuranceTypeName";
            var lstInsurance = new InsuranceRepository().GetAll();
            lstInsurance.Insert(0, new Insurance { InsuranceID = -1, InsuranceTypeName = ".......انتخاب کنید....." });
            cmbInsurance.DataSource = lstInsurance;
        }
        #region
        private void GoToAddMode()
        {
            btnAddTest.Visible = true;
            btnEdit.Visible = false;
            btnCancleTest.Visible = false;

        }
        private void GoToEditMode()
        {
            btnEdit.Visible = true;
            btnAddTest.Visible = false;
            btnCancleTest.Visible = true;
        }
      
        public void CleanForm()
        {
            lstPatient.Visible = false;
            lstPatient.DataSource = null;
            txtPatient.Text = "";
            lblTotalPrice.Visible = false;
            faDatePicker1.SelectedDateTime = DateTime.Now;
            txtDrName.Text = "";
            txtAge.Text = "";
            txtNationalCode.Text = "";
            cmbInsurance.SelectedIndex = 0;
            lblPatientTestHederID.Text = "";
            lblPatientName.Text = "";
            lblNationalCodePatient.Text = "";
            lblTotalPriceTests.Text = "";
            txtPriceWithDiscount.Text = "";
            txtDiscount.Text = "";
            txtPriceTest.Text = "";
            txtTestName.Text = "";
            lstTest.Visible = false;
            lstTest.DataSource = null;
            pnlDetailsVisit.Visible = false;
            lblErrorAge.Text = "";
            lblErrorDrName.Text = "";
            lblErrorMobile.Text = "";
            lblPanleTest.Visible = false;
            lblErrorNationalCode.Text = "";
            btnCancle.Visible = false;
            err.Clear();
        }
        public void CleanError()
        {
            lblErrorAge.Text = "";
            lblErrorDrName.Text = "";
            lblErrorMobile.Text = "";
            lblErrorNationalCode.Text = "";
        }
        #endregion
        private void BindGrid()
        {
            DGVTestDetails.DataSource = null;
            DGVTestDetails.AutoGenerateColumns = false;
            DGVTestDetails.DataSource = repo.GetAllForGirdFormVisit(this.PaitentHeaderID);
        }
        public void CleanFormDetails()
        {
            txtTestName.Text = "";
            txtPriceTest.Text = "";
            txtPriceWithDiscount.Text = "";
            txtDiscount.Text = "";
            lstTest.Visible = false;
            lstTest.DataSource = null;
        }
        public void ShowDetailsTest()
        {
            pnlDetailsVisit.Visible = true;
            lblPanleTest.Visible = true;
            lblTotalPrice.Visible = true;
            lblTotalPriceTests.Visible = true;
        }
        public void EnableHeaderVisit()
        {
            txtPatient.Enabled = false;
            lstPatient.Visible = false;
            cmbInsurance.Enabled = false;
            faDatePicker1.Enabled = false;
            txtDrName.Enabled = false;  
        }
        private void ActiveHeaderVisit()
        {
            txtPatient.Enabled = true;
            lstPatient.Visible = true;
            cmbInsurance.Enabled = true;
            faDatePicker1.Enabled = true;
            txtDrName.Enabled = true;
            btnAddPatientTest.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtAge.Enabled = true;
            txtNationalCode.Enabled = true;
        }
        private void frmLaboratoryVisit_Load(object sender, EventArgs e)
        {
            try
            {
                btnClearFormForAddVisit.Visible = false;
                lstPatient.Visible = false;
                BindCombo();
                pnlDetailsVisit.Visible = false;
                txtPriceTest.Visible = false;
                txtPriceWithDiscount.Visible = false;
                txtDiscount.Visible = false;
                txtPriceTest.Enabled = false;
                txtDiscount.Enabled = false;
                txtPriceWithDiscount.Enabled = false;
                GoToAddMode();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                lblPanleTest.Visible = false;
                lblTotalPrice.Visible = false;
                lstTest.Visible = false;
                lblTotalPriceTests.Visible = false;
                btnCancle.Visible = false;
                faDatePicker1.SelectedDateTime = DateTime.Now;


                DGVTestDetails.EnableHeadersVisualStyles = false;

                // رنگ پس‌زمینه کلی گرید
                DGVTestDetails.BackgroundColor = Color.FromArgb(235, 247, 240);

                // رنگ ردیف‌های معمولی
                DGVTestDetails.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250); // خیلی نزدیک به فرم

                // رنگ ردیف‌های یکی در میون برای خوانایی بیشتر
                DGVTestDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // رنگ متن سلول‌ها
                DGVTestDetails.RowsDefaultCellStyle.ForeColor = Color.Black;

                // رنگ انتخاب‌شده (برای اینکه زیادی تیره یا زننده نباشه)
                DGVTestDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 220); // سبز ملایم
                DGVTestDetails.DefaultCellStyle.SelectionForeColor = Color.Black;

                // رنگ هدر جدول
                DGVTestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 240, 230);
                DGVTestDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                // رنگ خطوط جدول
                DGVTestDetails.GridColor = Color.LightGray;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در لود صفحه : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnAddPatientTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPatient.Text))
                {
                    err.SetError(txtPatient, "خواهشمند است ابتدا بیمار را سرچ کرده و سپس از لیست روی بیمار دو بار کلیک کنید");
                    return;
                }
                if (lstPatient.SelectedValue == null)
                {
                    err.SetError(lstPatient, "آزمایش را از لیست انتخاب نکرده اید");
                    return;
                }

                if (string.IsNullOrEmpty(txtDrName.Text))
                {
                    lblErrorDrName.Text = "خواهشمند است نام دکتر را وارد کنید";
                    return;
                }

                if (cmbInsurance.SelectedIndex <= 0)
                {
                    err.SetError(cmbInsurance, "خواهشمند است یکی از گزینه ها را انتخاب کنید");
                    return;
                }

                if (string.IsNullOrEmpty(txtAge.Text))
                {
                    lblErrorAge.Text = "خواهشمند است از فرم ثبت بیمار سن را وارد کنید";
                    return;
                }
                if (string.IsNullOrEmpty(txtNationalCode.Text))
                {
                    lblErrorNationalCode.Text = "کد ملی نمیتواند خالی باشد";
                    return;
                }
                if (string.IsNullOrEmpty(txtMobileNumber.Text))
                {
                    lblErrorMobile.Text = "موبایل نمیتواند خالی باشد";
                    return;
                }
                PaitentTestHeder paitentHeader = new PaitentTestHeder();
                if (faDatePicker1.SelectedDateTime == null)
                {
                    paitentHeader.HederDate = DateTime.Now;
                }
                if (faDatePicker1.SelectedDateTime != null)
                {
                    paitentHeader.HederDate = faDatePicker1.SelectedDateTime;
                }

                InsuranceID = Convert.ToInt32(cmbInsurance.SelectedValue);
                paitentHeader.InsuranceID = this.InsuranceID;
                paitentHeader.PaitentID = this.PaitentID;
                EmployeeID = new EmployeeRepository().GetEmployeeWithUserName(this.UserName).EmployeeID;
                paitentHeader.EmployeeID = this.EmployeeID;
                paitentHeader.DrName = txtDrName.Text;
                paitentHeader.NationalCode = txtNationalCode.Text;
                paitentHeader.Age = Convert.ToInt32(txtAge.Text);
                PaitentHeaderID = repo.Add(paitentHeader);
                DoaminModel.Models.Patient P = repoPatient.Get(PaitentID);
                lblNationalCodePatient.Text = P.NationalCode;
                lblPatientName.Text = P.FirstName + "  " + P.LastName;
                lblPatientTestHederID.Text = this.PaitentHeaderID.ToString();
                CleanError();
                ShowDetailsTest();
                err.Clear();
                btnAddPatientTest.Enabled = false;
                EnableHeaderVisit();
                btnCancle.Visible = true;
                btnClearFormForAddVisit.Visible = true;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ثبت پذیرش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                frmPatient frmPatient = new frmPatient();
                frmPatient.Show();
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ثبت بیمار جدید : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
            
        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {
            
            lstTest.ValueMember = "TestID";
            lstTest.DisplayMember = "TestName";
            if (!string.IsNullOrEmpty(txtTestName.Text))
            {
                lstTest.Visible = true;
                err.Clear();
                lstTest.DataSource = repoTest.GetAllTestForListViewFormInsuranceTest(txtTestName.Text);
            }
            else
            {
                lstTest.Visible = false;
                txtPriceTest.Text = "";
                txtDiscount.Text = "";
                txtPriceWithDiscount.Text = "";
            }
        }

        private void lstTest_DoubleClick(object sender, EventArgs e)
        {
            TestID = Convert.ToInt32(lstTest.SelectedValue);
            if (!repo.ExsistTestInInsuranceTest(InsuranceID, TestID))
            {
                MessageBox.Show("برای این آزمایش فرانشیز یا نوع بیمه مشخص نشده است ");
                return;
            }
            Test test = repoTest.Get(TestID);
            txtTestName.Text = test.TestName;
            lstTest.Visible = false;
            txtPriceWithDiscount.Visible = true;
            txtDiscount.Visible = true;
            txtPriceTest.Visible = true;

            txtPriceTest.Text = test.Price.ToString();
            
            InsuranceTest insuranceTest = insuranceTestRepository.Get(InsuranceID, TestID);
            txtDiscount.Text = insuranceTest.Discount.ToString();
            txtPriceWithDiscount.Text =(Convert.ToInt32(txtPriceTest.Text) * (100 - Convert.ToInt32(txtDiscount.Text)) / 100.0).ToString();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTest.SelectedValue == null)
                {
                    err.SetError(txtTestName, "لطفاً نام آزمایش را سرچ کنید و سپس از لیست انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtTestName.Text))
                {
                    err.SetError(txtTestName, "لطفاً نام آزمایش را سرچ کنید و سپس از لیست انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtPriceTest.Text))
                {
                    lblErrorPriceTest.Text = "قیمت نمیتواند خالی باشد ";
                    return;
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    lblErrorDiscountTest.Text = "فرانشیز وارد نشده است ";
                    return;
                }
                if (string.IsNullOrEmpty(txtPriceWithDiscount.Text))
                {
                    lblErrorPriceWithDiscount.Text = "سهم بیمار نمیتواند خالی باشد";
                    return;
                }
                PatientTestDetail patientTestDetail = new PatientTestDetail();
                patientTestDetail.TestID = this.TestID;
                patientTestDetail.PatientTestHederID = this.PaitentHeaderID;
                patientTestDetail.Price = Convert.ToInt64(txtPriceWithDiscount.Text);
                patientTestDetail.Result = null;
                
                if (!repo.ExsistTestInInsuranceTest(InsuranceID,TestID))
                {
                    MessageBox.Show("برای این آزمایش فرانشیز یا نوع بیمه مشخص نشده است ");
                    return;
                }
                if (repo.ExsistTestInPatientTestDetails(this.TestID , this.PaitentHeaderID))
                {
                    MessageBox.Show("این آزمایش قبلاً وارد شده است");
                    return;
                }
                int PatientTestDetailID = repo.Add(patientTestDetail);

                BindGrid();
                lblTotalPriceTests.Text = repo.GetTotalPrice(this.PaitentHeaderID).ToString();
                CleanFormDetails();
                err.Clear();
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ثبت آزمایش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVTestDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientTestDetailsID = Convert.ToInt32(DGVTestDetails.Rows[e.RowIndex].Cells[1].Value);
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("آیا میخواهید این آزمایش را حذف کنید ؟ ", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.DeleteDetails(PatientTestDetailsID)
    )
                        {
                            BindGrid();
                            lblTotalPriceTests.Text = repo.GetTotalPrice(this.PaitentHeaderID).ToString();
                        }


                    }
                    else
                    {
                        CleanFormDetails();
                        CleanError();
                        GoToAddMode();
                    }
                }
                if (e.ColumnIndex == 7)
                {
                    PatientTestDetail patientTestDetail = repo.GetPatientDetails(PatientTestDetailsID);
                    Test test = repoTest.Get(patientTestDetail.TestID);
                    txtTestName.Text = test.TestName;
                    txtPriceTest.Text = test.Price.ToString();
                    txtDiscount.Text = (insuranceTestRepository.Get(this.InsuranceID, test.TestID).Discount).ToString();
                    txtPriceWithDiscount.Text = (Convert.ToInt32(txtPriceTest.Text) * Convert.ToInt32(txtDiscount.Text)).ToString();
                    GoToEditMode();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در گرید : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTest.SelectedValue == null)
                {
                    err.SetError(txtTestName, "لطفاً نام آزمایش را سرچ کنید و سپس از لیست انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtTestName.Text))
                {
                    err.SetError(txtTestName, "لطفاً نام آزمایش را سرچ کنید و سپس از لیست انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtPriceTest.Text))
                {
                    lblErrorPriceTest.Text = "قیمت نمیتواند خالی باشد ";
                    return;
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    lblErrorDiscountTest.Text = "فرانشیز وارد نشده است ";
                    return;
                }
                if (string.IsNullOrEmpty(txtPriceWithDiscount.Text))
                {
                    lblErrorPriceWithDiscount.Text = "سهم بیمار نمیتواند خالی باشد";
                    return;
                }
                PatientTestDetail patientTestDetail = new PatientTestDetail();
                patientTestDetail.TestID = Convert.ToInt32(lstTest.SelectedValue);
                patientTestDetail.PatientTestDetailsID = this.PatientTestDetailsID;
                patientTestDetail.PatientTestHederID = this.PaitentHeaderID;
                patientTestDetail.Result = null;
                patientTestDetail.HasStar = null;
                patientTestDetail.Price = Convert.ToInt64(txtPriceTest.Text);
                if (repo.ExsistTestInPatientTestDetails(this.TestID , this.PaitentHeaderID))
                {
                    MessageBox.Show("این آزمایش قبلاً وارد شده است");
                    return;
                }
                repo.UpdatePatientDetails(patientTestDetail);
                GoToAddMode();
                BindGrid();
                CleanFormDetails();
                //Clean Error
                lblTotalPriceTests.Text = repo.GetTotalPrice(this.PaitentHeaderID).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ویرایش آزمایش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }

        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            lstPatient.ValueMember = "PatientID";
            lstPatient.DisplayMember = "FullInfo";
            if (!string.IsNullOrEmpty(txtPatient.Text))
            {
                lstPatient.Visible = true;
                if (txtPatient.Text.StartsWith("09"))
                {
                    lstPatient.DataSource = repo.SearchByMobile(txtPatient.Text);
                }
                else if (txtPatient.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    lstPatient.DataSource = repo.SearchByPatientName(txtPatient.Text);
                }
                else if (txtPatient.Text.All(c => char.IsDigit(c)))
                {
                    lstPatient.DataSource = repo.SearchByNationalCode(txtPatient.Text);
                }
            }
            else
            {
                lstPatient.DataSource = null;
                lstPatient.Visible = false;
            }
        }

        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PaitentID = Convert.ToInt32(lstPatient.SelectedValue);
            Patient patient = repoPatient.Get(PaitentID);
            txtPatient.Text = patient.FirstName + " " + patient.LastName;
            txtNationalCode.Text = patient.NationalCode;
            txtAge.Text = patient.Age.ToString();
            txtMobileNumber.Text = patient.PhoneNumber;
            txtNationalCode.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtAge.Enabled = false;
            lstPatient.Visible = false;
        }

        private void btnClearFormForAddVisit_Click(object sender, EventArgs e)
        {
            try
            {
                CleanForm();
                btnAddPatientTest.Enabled = true;
                ActiveHeaderVisit();
                lstPatient.Visible = false;
                btnClearFormForAddVisit.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ثبت ویزیت جدید : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }

        }

        private void btnAddPatient_Click_1(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient();
            frmPatient.Show();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //اگر وجود دارد یک آزمایش آنگاه بیا 
            //اگر وجود دارد خود آزمایش بدون جزیئات : 
            try
            {
                if (repo.ExsistHeader(PaitentHeaderID))
                {

                    if (repo.ExsistDetailsForTestHeader(PaitentHeaderID))
                    {
                        MessageBox.Show("خواهشمند است ابتدا آزمایشات را حذف کنید و سپس پذیریش را حذف کنید");
                        return;
                    }
                    else
                    {
                        repo.Delete(PaitentHeaderID);
                        CleanForm();
                        CleanError();
                        ActiveHeaderVisit();
                        btnClearFormForAddVisit.Visible = false;
                        lstPatient.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه لفو پذیرش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
            
        }

        private void btnCancleTest_Click(object sender, EventArgs e)
        {
            try
            {
                CleanFormDetails();
                GoToAddMode();
                lblTotalPriceTests.Text = repo.GetTotalPrice(this.PaitentHeaderID).ToString();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه کنسل آزمایش : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtNationalCode.Text))
            {
                return;
            }
            if (!string.IsNullOrEmpty(txtNationalCode.Text))
            {
                err.Clear();
            }
            if (!txtNationalCode.Text.Trim().All(c => char.IsDigit(c)))
            {
                err.SetError(txtNationalCode, "کد ملی باید عدد باشد");
                txtNationalCode.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                return;
            }
            if (!string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                err.Clear();
            }
            if (!txtMobileNumber.Text.Trim().All(c => char.IsDigit(c)))
            {
                err.SetError(txtMobileNumber, "موبایل باید عدد باشد");
                txtMobileNumber.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtDrName.Text))
            {
                return;
            }
            if (!char.IsLetter(txtDrName.Text.Trim()[0]))
            {
                MessageBox.Show("نام دکتر باید شامل حروف باشد");
                return;
            }
            if (!txtDrName.Text.Trim().Skip(1).All(c => char.IsLetter(c) || c == ' '))
            {
                err.SetError(txtDrName, "نام دکتر باید رشته باشد");
                txtDrName.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                return;
            }
            if (!string.IsNullOrEmpty(txtAge.Text))
            {
                err.Clear();
            }
            if (!txtAge.Text.Trim().All(c => char.IsDigit(c)))
            {
                err.SetError(txtAge, "موبایل باید عدد باشد");
                txtAge.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }
    }
}
