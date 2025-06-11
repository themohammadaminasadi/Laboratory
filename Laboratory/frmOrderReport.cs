using DataAccess;
using DoaminModel.Models;
using DoaminModel.ViewModel.Order;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmOrderReport: Form
    {
        private int PatientTestHederID = 0;
        private int PatientTestDetailsID = 0;
        private int TestID = 0;
        private bool HasStar;
        private int PatientID = 0;
        private decimal total = 0;
        private ComprehensiveOrderRepository repo = new ComprehensiveOrderRepository();
        PatientHeaderRepository repoHeader = new PatientHeaderRepository();
        TestRangeRepository repoTestRange = new TestRangeRepository();
        ItemsSearchOrderReport ls = new ItemsSearchOrderReport();
        public frmOrderReport()
        {
            InitializeComponent();
        }
        private void GoToEditMode()
        {
            try
            {
                btnEditResult.Visible = true;
                btnCancle.Visible = true;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در رفتن فرم به مد ویرایش : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }
        private void BindComboEmployee()
        {
            try
            {
                var listCombo = new DataAccess.EmployeeRepository().GetAll();
                listCombo.Insert(0, new DoaminModel.Models.Employee { EmployeeID = -1, LastName = "... انتخاب کنید ...." });

                cmbEmployee.DataSource = null;
                cmbEmployee.ValueMember = "EmployeeID";
                cmbEmployee.DisplayMember = "LastName";
                cmbEmployee.DataSource = listCombo;


            }
            catch (Exception ex)
            {

                throw new Exception("ارور در Combo Box بیمه : خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
        }
        private void BindCombo()
        {
            try
            {
                var listCombo = new DataAccess.InsuranceRepository().GetAll();
                listCombo.Insert(0, new DoaminModel.Models.Insurance { InsuranceID = -1, InsuranceTypeName  = "انتخاب کنید" });

                cmbInsurance.SelectedIndexChanged -= cmbInsurance_SelectedIndexChanged; // ❌ غیرفعال‌سازی

                cmbInsurance.DataSource = null;
                cmbInsurance.ValueMember = "InsuranceID";
                cmbInsurance.DisplayMember = "InsuranceTypeName";
                cmbInsurance.DataSource = listCombo;

                cmbInsurance.SelectedIndex = 0;

                cmbInsurance.SelectedIndexChanged += cmbInsurance_SelectedIndexChanged;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در Combo Box بیمه : خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
        }
        private void DGVTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientTestHederID = Convert.ToInt32(DGVTestHeader.Rows[e.RowIndex].Cells[0].Value);
                PatientID = repoHeader.Get(PatientTestHederID).PaitentID;
                if (e.ColumnIndex == 7)
                {
                    DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHederID);

                }
                //Bind With Data ListItemResultTestHeader
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در گرید سر برگ : خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
        }
        //private void BindGridTestHeader()
        //{
        //    DGVTestHeader.AutoGenerateColumns = false;
        //    DGVTestHeader.DataSource = new PatientHeaderRepository().GetAll();
        //}
        private List<ListItemResultTestHeader> DoSearch(ItemsSearchOrderReport ls)
        {
            DGVTestHeader.AutoGenerateColumns = false;
            var filter= repo.SearchComprehensiveOrderForPushDataGridTestHeader(ls);
            DGVTestHeader.DataSource = filter;
            return filter;
        }
        private void DGVDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientTestDetailsID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnPatientTestDetailsID"].Value);
                TestID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnTestID"].Value);


                if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnEditDetailsTest")
                {
                    PatientTestDetail patientTestDetail = repoHeader.GetPatientDetails(PatientTestDetailsID);
                    if (patientTestDetail.Result.HasValue)
                    {
                        GoToEditMode();
                        lblTestName.Visible = true;
                        lblResult.Visible = true;
                        txtTestName.Visible = true;
                        txtResult.Visible = true;
                        txtResult.Text = patientTestDetail.Result.ToString();
                        txtTestName.Text = patientTestDetail.Test.TestName;
                        txtTestName.Enabled = false;
                    }
                    else if (!patientTestDetail.Result.HasValue)
                    {
                        MessageBox.Show("این آزمایش نتیجه ندارد ");
                        CleanEditTest();
                        btnCancle.Visible = false;
                        btnEditResult.Visible = false;  
                        return;
                    }


                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در گرید جزئیات : خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
        }
        private void CleanGridDetails()
        {
            DGVDetails.AutoGenerateColumns = false;
            DGVDetails.DataSource = null;
        }
        private void CleanGridHeader()
        {
            DGVTestHeader.AutoGenerateColumns = false;
            DGVTestHeader.DataSource = null;
        }
        private void ApplySearchAndTotal()
        {
            total = 0;
            CleanGridDetails();
            CleanGridHeader();

            ls = BuildSearchFilters(); // ساختن فیلتر از نو

            bool isAnyFilterApplied =
           !string.IsNullOrWhiteSpace(ls.FullName) ||
           !string.IsNullOrWhiteSpace(ls.NationalCode) ||
           !string.IsNullOrWhiteSpace(ls.MobileNumer) ||
           !string.IsNullOrWhiteSpace(ls.DrName) ||
           (ls.EmployeeID != 0) ||
           ls.FromAge.HasValue ||
           ls.ToAge.HasValue ||
           ls.FromHederDate.HasValue ||
           ls.ToHederDate.HasValue ||
           (ls.InsuranceID != 0) ||
           ls.Gender.HasValue ||
           ls.PatientTestHederID != 0;


            if (!isAnyFilterApplied)
            {
                CleanGridDetails();
                CleanGridHeader();
                lblTotalPrice.Text = "0";
                return;
            }

            var lst = DoSearch(ls);

            foreach (var item in lst)
            {
                total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);
            }

            lblTotalPrice.Text = total.ToString();
        }
        private ItemsSearchOrderReport BuildSearchFilters()
        {
            var filter = new ItemsSearchOrderReport();

            if (!string.IsNullOrWhiteSpace(txtFullName.Text))
                filter.FullName = txtFullName.Text;

            if (!string.IsNullOrWhiteSpace(txtNationalCode.Text))
                filter.NationalCode = txtNationalCode.Text;

            if (!string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                filter.MobileNumer = txtPhoneNumber.Text;

            if (!string.IsNullOrWhiteSpace(txtDrName.Text))
                filter.DrName = txtDrName.Text;

            if (cmbEmployee.SelectedIndex > 0)
                filter.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);

            if (!string.IsNullOrWhiteSpace(txtSearchFromAge.Text))
                filter.FromAge = Convert.ToInt32(txtSearchFromAge.Text);

            if (!string.IsNullOrWhiteSpace(txtSearchToAge.Text))
                filter.ToAge = Convert.ToInt32(txtSearchToAge.Text);

            if (faDatePickerFrom.SelectedDateTime != null)
                filter.FromHederDate = faDatePickerFrom.SelectedDateTime;

            if (faDatePickerToDate.SelectedDateTime != null)
                filter.ToHederDate = faDatePickerToDate.SelectedDateTime;

            if (cmbInsurance.SelectedIndex > 0)
                filter.InsuranceID = Convert.ToInt32(cmbInsurance.SelectedValue);

            if (rdbMale.Checked)
                filter.Gender = true;
            else if (rdbFamle.Checked)
                filter.Gender = false;
            else
                filter.Gender = null;

            if (!string.IsNullOrWhiteSpace(txtPatientHeaderID.Text))
                filter.PatientTestHederID = Convert.ToInt32(txtPatientHeaderID.Text);

            return filter;
        }
        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindCombo();
                BindComboEmployee();
                GoToAddMode();
                CleanGridHeader();
                CleanGridDetails();
                CleanEditTest();
                lblTotalPrice.Text = "0";

                //تنظیم فرمت تاریخ :  
                DGVTestHeader.Columns["ClmnHederDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در لود صفحه : خواهشمند است با پشتیبانی تماس بگیرید" + ex);
            }
           

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

            try
            {
                
                if (txtFullName.Text.Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!char.IsLetter(txtFullName.Text.Trim()[0]))
                {
                    MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                    txtFullName.Text = "";
                    return;
                }
                if (!txtFullName.Text.Skip(1).All(x=>char.IsLetter(x) || x == ' '))
                {
                    MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                    txtFullName.Text = "";
                    return;
                }
                else
                {
                    ApplySearchAndTotal();
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtNationalCode.Text.Trim().Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!txtNationalCode.Text.Trim().All(x=>char.IsDigit(x)))
                {
                    MessageBox.Show("کد ملی باید حروف باشد");
                    txtNationalCode.Text = "";
                    return;
                }
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtPhoneNumber.Text.Trim().Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!txtPhoneNumber.Text.Trim().All(x => char.IsDigit(x)))
                {
                    MessageBox.Show("کد ملی باید حروف باشد");
                    txtPhoneNumber.Text = "";
                    return;
                }
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtDrName.Text.Trim().Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!char.IsLetter(txtDrName.Text.Trim()[0]))
                {
                    MessageBox.Show("نام دکتر باید شامل حروف باشد");
                    txtDrName.Text = "";
                    return;
                }
                if (!txtDrName.Text.Trim().Skip(1).All(x=> char.IsLetter(x) || x== ' '))
                {
                    MessageBox.Show("نام دکتر باید شامل حروف باشد");
                    txtDrName.Text = "";
                    return;
                }
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtSearchFromAge_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtSearchFromAge.Text.Trim().Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!txtSearchFromAge.Text.Trim().All(x=>char.IsDigit(x)))
                {
                    MessageBox.Show("سن باید عدد باشد");
                    txtSearchFromAge.Text = "";
                    return;
                }
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtSearchToAge_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtSearchToAge.Text.Trim().Length == 0)
                {
                    ApplySearchAndTotal();
                    return;
                }
                if (!txtSearchToAge.Text.Trim().All(x=>char.IsDigit(x)))
                {
                    MessageBox.Show("سن باید عدد باشد");
                    txtSearchToAge.Text = "";
                    return;
                }
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void faDatePickerFrom_SelectedDateTimeChanged(object sender, EventArgs e)
        {

            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void faDatePickerToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {

            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void cmbInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtPatientTestHederID_TextChanged(object sender, EventArgs e)
        {

            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void grpGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {


            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void rdbFamle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        private void rdbBothGender_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        private void btnEditResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResult.Text))
                {
                    MessageBox.Show("نتیجه نمیتواند خالی باشد");
                    return;
                }
                PatientTestDetail NewPatientTestDetail = new PatientTestDetail();
                var OldPatientTestDetails = repoHeader.GetPatientDetails(this.PatientTestDetailsID);
                double Result = Convert.ToDouble(txtResult.Text);
                var ListTestRange = repoTestRange.GetTestWithTestID(TestID);
                int Age = repoHeader.Get(PatientTestHederID).Age;
                var patient = new PatientRepository().Get(PatientID); // patient یک شیء از کلاس Patient هست
                int genderInt = patient.Gender ? 1 : 0; // ✅ درست: استفاده از شیء patient
                foreach (var item in ListTestRange)
                {
                    bool genderMatches = item.Gender == genderInt;
                    if (Result > item.MinValue && Result < item.MaxValue && Age > item.FromAge && Age < item.ToAge && genderMatches)
                    {
                        HasStar = item.Hazard;
                    }
                }
                NewPatientTestDetail.TestID = OldPatientTestDetails.TestID;
                NewPatientTestDetail.Result = Result;
                NewPatientTestDetail.PatientTestHederID = OldPatientTestDetails.PatientTestHederID;
                NewPatientTestDetail.PatientTestDetailsID = OldPatientTestDetails.PatientTestDetailsID;
                NewPatientTestDetail.Price = OldPatientTestDetails.Price;
                NewPatientTestDetail.HasStar = this.HasStar;
                repoHeader.UpdatePatientDetails(NewPatientTestDetail);
                //Bind Grid Test Details ; 
                DGVDetails.AutoGenerateColumns = false;
                DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHederID);
                CleanForm();
                GoToAddMode();
                CleanEditTest();
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ویرایش نتیجه : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }
        private void CleanForm()
        {
            try
            {

                txtResult.Text = "";
                txtTestName.Text = "";
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در متد پاکسازی فرم : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                DGVDetails.AutoGenerateColumns = false;
                DGVDetails.DataSource = null;
                CleanEditTest();
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه انصراف : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }
        private void CleanEditTest()
        {
            lblResult.Visible = false;
            lblTestName.Visible = false;
            txtResult.Visible = false;
            txtTestName.Visible = false;
        }

        private void GoToAddMode()
        {
            try
            {
                btnEditResult.Visible = false;
                btnCancle.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در متد gotoAddMode : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }

   

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ApplySearchAndTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtPatientHeaderID_TextChanged(object sender, EventArgs e)
        {

            if (txtPatientHeaderID.Text.Trim().Length == 0)
            {
                ApplySearchAndTotal();
                return;
            }
            if (!txtPatientHeaderID.Text.Trim().All(x => char.IsDigit(x)))
            {
                MessageBox.Show("کد آزمایش باید عدد باشد");
                txtPatientHeaderID.Text = "";
                return;
            }
            ApplySearchAndTotal();
        }
    }
}
