using DataAccess;
using DoaminModel.Models;
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
    public partial class frmEditResultTest: Form
    {
        EditResultTestRepository repo = new EditResultTestRepository();
        PatientRepository repoPatient = new PatientRepository();
        ResultTestRepository repoResult = new ResultTestRepository();
        PatientHeaderRepository repoHeader = new PatientHeaderRepository();
        TestRangeRepository repoTestRange = new TestRangeRepository();
        private bool HasStar;
        private int PatientTestHeaderID = 0;
        private int TestID = 0;
        private int PatientTestDetailsID = 0;
        private int PatientID = 0;
        public frmEditResultTest()
        {
            InitializeComponent();
        }
        private void ConfigeDataGridViewPatientTestHeader()
        {
            DGVPatientTestHeader.AutoGenerateColumns = false;
            DGVPatientTestHeader.DataSource = null;
        }
        private void ConfigeDataGridViewPatientDetails()
        {
            DGVDetails.AutoGenerateColumns = false;
            DGVDetails.DataSource = null;
        }
        private void GoToEditMode()
        {
            btnAddResult.Visible = false;
            btnEditResult.Visible = true;
            btnCancle.Visible = true;
            lblResult.Visible = true;
            lblTestName.Visible = true;
            txtTestName.Visible = true;
            txtResult.Visible = true;
        }
        private void GoToAddMode()
        {
            btnAddResult.Visible = true;
            btnEditResult.Visible = false;
            btnCancle.Visible = false;
            lblResult.Visible = true;
            lblTestName.Visible = true;
            txtTestName.Visible = true;
            txtResult.Visible = true;
        }
        private void CleanForm()
        {
            txtResult.Text = "";
            txtTestName.Text = "";
        }
        private void VisibleControlers()
        {
            lblResult.Visible = false;
            lblTestName.Visible = false;
            txtTestName.Visible = false;
            txtResult.Visible = false;
        }
        private void frmEditResultTest_Load(object sender, EventArgs e)
        {
            try
            {

                lstPatient.Visible = false;
                VisibleControlers();
                btnAddResult.Visible = false;
                btnEditResult.Visible = false;
                btnCancle.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("در در لود فرم : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPatient.Text))
                {
                    ConfigeDataGridViewPatientTestHeader();
                    lstPatient.Visible = true;
                    lstPatient.DisplayMember = "FullInfoPatient";
                    lstPatient.ValueMember = "PatientID";
                    if (txtPatient.Text.All(c => char.IsLetter(c)))
                    {

                        lstPatient.DataSource = repo.SearchPatientTestHeaderForFrmEditResultTest(txtPatient.Text);
                    }
                    else if (txtPatient.Text.StartsWith("09"))
                    {
                        lstPatient.DataSource = repo.SearchPatientWithMobileNmuberTestHeaderForFrmEditResultTest(txtPatient.Text);
                    }
                    else if (txtPatient.Text.All(c => char.IsDigit(c)))
                    {
                        lstPatient.DataSource = repo.SearchPatientWithNationalCodeTestHeaderForFrmEditResultTest(txtPatient.Text);
                    }
                }
                else
                {
                    lstPatient.Visible = false;
                    ConfigeDataGridViewPatientTestHeader();
                    ConfigeDataGridViewPatientDetails();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در جست و جو : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message); 
            }
        }

        private void faDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                if (faDatePicker.SelectedDateTime != null)
                {
                    ConfigeDataGridViewPatientTestHeader();
                    DGVPatientTestHeader.DataSource = repo.SearchPatientWithDateTimeTestHeaderForFrmEditResultTest(Convert.ToDateTime(faDatePicker.SelectedDateTime));
                }
                else
                {
                    ConfigeDataGridViewPatientTestHeader();
                    ConfigeDataGridViewPatientDetails();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در تقویم : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }

        private void lstPatient_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstPatient.SelectedIndex >= 0)
                {
                    ConfigeDataGridViewPatientTestHeader();
                    PatientID = Convert.ToInt32(lstPatient.SelectedValue);
                    Patient patient = repoPatient.Get(PatientID);
                    txtPatient.Text = patient.FirstName + " " + patient.LastName + " " + patient.NationalCode + " " + patient.PhoneNumber;
                    DGVPatientTestHeader.DataSource = repo.GetPatientTestByPatientID(PatientID);
                    lstPatient.Visible = false;
                }
                else
                {
                    ConfigeDataGridViewPatientTestHeader();
                    DGVDetails.AutoGenerateColumns = false;
                    DGVDetails.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در کلیک روی لیست : خواهمشند است با پشتیبانی تماس بگیرید" + ex.Message ); 
            }
        }

        private void DGVPatientTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientTestHeaderID = Convert.ToInt32(DGVPatientTestHeader.Rows[e.RowIndex].Cells[0].Value);
                PatientID = Convert.ToInt32(DGVPatientTestHeader.Rows[e.RowIndex].Cells["ClmnPaitentID"].Value);
                if (e.ColumnIndex == 7)
                {
                    DGVDetails.DataSource = repoResult.GetDetails(PatientTestHeaderID);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در کلیک روی گرید سربرگ : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
            }
        }

        private void DGVDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientTestDetailsID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnPatientTestDetailsID"].Value);
                var PatientTestDetails = repoHeader.GetPatientDetails(PatientTestDetailsID);
                TestID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnTestID"].Value);
                if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnEditDetailsTest")
                {
                    if (PatientTestDetails.Result.HasValue)
                    {
                        GoToEditMode();
                        txtTestName.Enabled = false;
                        txtTestName.Text = PatientTestDetails.Test.TestName;
                        txtResult.Text = PatientTestDetails.Result.ToString();
                    }
                    else if (!PatientTestDetails.Result.HasValue)
                    {
                        MessageBox.Show("آزمایش نتیجه ندارد");
                        return;
                    }
                }
                if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnAddDetailsTest")
                {
                    if (PatientTestDetails.Result.HasValue)
                    {
                        MessageBox.Show("این آزمایش دارای نتیجه است");
                        return;
                    }
                    GoToAddMode();
                    CleanForm();
                    txtTestName.Text = PatientTestDetails.Test.TestName;
                    txtTestName.Enabled = false;
                }
                if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnDeletePatientTestDetails")
                {
                    if (MessageBox.Show("این مطمئن هستید میخواهید این رکورد را حذف کنید ؟","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        CleanForm();
                        VisibleControlers();
                        repoHeader.DeleteDetails(PatientTestDetailsID);
                        DGVDetails.DataSource = repoResult.GetDetails(PatientTestHeaderID);
                    }
                    else
                    {
                        btnAddResult.Visible = false;
                        btnEditResult.Visible = false;
                        btnCancle.Visible = false;
                        lblResult.Visible = false;
                        lblTestName.Visible = false;
                        txtTestName.Visible = false;
                        txtResult.Visible = false;
                        CleanForm();

                    }
                   
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در کلیک روی گرید جزئیات : خواهشمند است با پشتیبانی تماس بگیرید" + ex.Message);
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
                PatientRepository PatientRepository = new PatientRepository();
                var OldPatientTestDetails = repoHeader.GetPatientDetails(this.PatientTestDetailsID);
                double Result = Convert.ToDouble(txtResult.Text);
                var ListTestRange = repoTestRange.GetTestWithTestID(TestID);
                int Age = PatientRepository.Get(PatientID).Age;
                var patient = PatientRepository.Get(PatientID); // patient یک شیء از کلاس Patient هست
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
                DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHeaderID);
                CleanForm();
                btnAddResult.Visible = false;
                btnEditResult.Visible = false;
                btnCancle.Visible = false;
                lblResult.Visible = false;
                lblTestName.Visible = false;
                txtTestName.Visible = false;
                txtResult.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ویرایش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddResult.Visible = false;
                btnEditResult.Visible = false;
                btnCancle.Visible = false;
                lblResult.Visible = false;
                lblTestName.Visible = false;
                txtTestName.Visible = false;
                txtResult.Visible = false;
                CleanForm();
                 
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه انصراف : خواهمشند است با مدیر سیستم تماس بگیرید" + ex.Message);
            }
           
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResult.Text))
                {
                    MessageBox.Show("نتیجه نمیتواند خالی باشد");
                    return;
                }
                double Result = Convert.ToDouble(txtResult.Text);

                var ListTestRange = repoTestRange.GetTestWithTestID(TestID);
                int Age = new PatientRepository().Get(PatientID).Age;
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
                repoResult.setResult(PatientTestDetailsID, Result, HasStar);
                //DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHeaderID);
                CleanForm();
                var details = new ResultTestRepository().GetDetails(PatientTestHeaderID);
                ConfigeDataGridViewPatientDetails();
                DGVDetails.DataSource = details;
                btnAddResult.Visible = false;
                btnEditResult.Visible = false;
                btnCancle.Visible = false;
                lblResult.Visible = false;
                lblTestName.Visible = false;
                txtTestName.Visible = false;
                txtResult.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه اضافه کردن : خواهمشند است با مدیر سیستم تماس بگیرید" + ex.Message);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (txtResult.Text.Length == 0 || string.IsNullOrEmpty(txtResult.Text))
            {
                return;
            }
            if (!txtResult.Text.All(c=>char.IsDigit(c)))
            {
                MessageBox.Show("فقط میتوانید عدد وارد کنید");
                return;
            }
        }
    }
}
