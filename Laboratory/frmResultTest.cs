using DataAccess;
using DoaminModel.Models;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Infrastructure.Design;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmResultTest: Form
    {
        private int PatientTestHederID = 0;
        private int PatientTestDetailsID;
        private int PatientID = 0;
        private bool HasStar;
        private int TestID = 0;
        private TestRangeRepository repoTestRange = new TestRangeRepository();
        private ResultTestRepository repo = new ResultTestRepository();
        private PatientHeaderRepository repoHeader = new PatientHeaderRepository();
        public frmResultTest()
        {
            InitializeComponent();
        }
        private void GoToAddMode()
        {
            btnAddResult.Visible = true;
            btnEditResult.Visible = false;
            btnCancle.Visible = false;  
        }
        private void GoToEditMode()
        {

            btnAddResult.Visible = false;
            btnEditResult.Visible = true;
            btnCancle.Visible = true;
        }
        private void BindGridTestHeader()
        {
            DGVTestHeader.DataSource = null;
            DGVTestHeader.AutoGenerateColumns = false;
            DGVTestHeader.DataSource = repo.GetAllPendingTests();
        }
        private void CleanForm()
        {
            txtResult.Text = "";
            txtTestName.Text = "";
        }
        private void frmResultTest_Load(object sender, EventArgs e)
        {
            BindGridTestHeader();
            lstPatient.Visible = false;
            GoToAddMode();
            lblTestTitle.Visible = false;
            lblResultTitle.Visible = false;
            btnAddResult.Visible = false;
            txtTestName.Visible = false;
            txtResult.Visible = false;
            DGVDetails.EnableHeadersVisualStyles = false;

            // رنگ پس‌زمینه کلی گرید
            DGVDetails.BackgroundColor = Color.FromArgb(235, 247, 240);

            // رنگ ردیف‌های معمولی
            DGVDetails.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250); // خیلی نزدیک به فرم

            // رنگ ردیف‌های یکی در میون برای خوانایی بیشتر
            DGVDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // رنگ متن سلول‌ها
            DGVDetails.RowsDefaultCellStyle.ForeColor = Color.Black;

            // رنگ انتخاب‌شده (برای اینکه زیادی تیره یا زننده نباشه)
            DGVDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 220); // سبز ملایم
            DGVDetails.DefaultCellStyle.SelectionForeColor = Color.Black;

            // رنگ هدر جدول
            DGVDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 240, 230);
            DGVDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // رنگ خطوط جدول
            DGVDetails.GridColor = Color.LightGray;

            DGVTestHeader.EnableHeadersVisualStyles = false;

            // رنگ پس‌زمینه کلی گرید
            DGVTestHeader.BackgroundColor = Color.FromArgb(235, 247, 240);

            // رنگ ردیف‌های معمولی
            DGVTestHeader.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250); // خیلی نزدیک به فرم

            // رنگ ردیف‌های یکی در میون برای خوانایی بیشتر
            DGVTestHeader.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // رنگ متن سلول‌ها
            DGVTestHeader.RowsDefaultCellStyle.ForeColor = Color.Black;

            // رنگ انتخاب‌شده (برای اینکه زیادی تیره یا زننده نباشه)
            DGVTestHeader.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 220); // سبز ملایم
            DGVTestHeader.DefaultCellStyle.SelectionForeColor = Color.Black;

            // رنگ هدر جدول
            DGVTestHeader.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 240, 230);
            DGVTestHeader.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // رنگ خطوط جدول
            DGVTestHeader.GridColor = Color.LightGray;
        }

        private void DGVTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientTestHederID = Convert.ToInt32(DGVTestHeader.Rows[e.RowIndex].Cells[0].Value);
            PatientID = repoHeader.Get(PatientTestHederID).PaitentID;
            
            if (e.ColumnIndex == 7)
            {
                DGVDetails.DataSource  = new ResultTestRepository().GetDetails(PatientTestHederID);
               

            }
            txtTestName.Enabled = false;
            lblTestTitle.Visible = false;
            lblResultTitle.Visible = false;
            btnAddResult.Visible = false;
            txtResult.Visible = false;
            txtTestName.Visible = false;
        }

        private void DGVDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            PatientTestDetailsID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnPatientTestDetailsID"].Value);
            TestID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnTestID"].Value);
            
            if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnAddDetailsTest")
            {
                PatientTestDetail patientTestDetail = repoHeader.GetPatientDetails(PatientTestDetailsID);
                if (patientTestDetail.Result == null)
                {
                    txtResult.Text = "";
                }
                if (patientTestDetail.Result != null)
                {
                    MessageBox.Show("این آزمایش دارای نتیجه است");
                    return;
                }
                txtTestName.Text = patientTestDetail.Test.TestName;
                txtTestName.Enabled = false;
                lblTestTitle.Visible = true;
                lblResultTitle.Visible = true;
                btnAddResult.Visible = true;
                txtResult.Visible = true;
                txtTestName.Visible = true;
                GoToAddMode();
            }
            if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnEditDetailsTest")
            {
                PatientTestDetail patientTestDetail = repoHeader.GetPatientDetails(PatientTestDetailsID);
                
                if (patientTestDetail.Result.HasValue)
                {
                    GoToEditMode();
                    txtResult.Text = patientTestDetail.Result.ToString();
                    txtTestName.Text = patientTestDetail.Test.TestName;
                    txtTestName.Enabled = false;
                    lblTestTitle.Visible = true;
                    lblResultTitle.Visible = true;
                    txtResult.Visible = true;
                    txtTestName.Visible = true;
                }
                else if(!patientTestDetail.Result.HasValue)
                {
                    MessageBox.Show("این آزمایش نتیجه ندارد و آزمایشی که نتیجه نداشته است را نمیتوانید ویرایش کنید");
                    return;
                }
                
                 
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
                repo.setResult(PatientTestDetailsID, Result, HasStar);
                DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHederID);
                CleanForm();
                txtTestName.Enabled = false;
                lblTestTitle.Visible = false;
                lblResultTitle.Visible = false;
                txtResult.Visible = false;
                txtTestName.Visible = false;
                GoToAddMode();
                btnAddResult.Visible = false;
                //BindGridTestHeader();
                var details = new ResultTestRepository().GetDetails(PatientTestHederID);

                // اگر همه جواب دارند (هیچ Result ای null نیست)

                // چک می‌کنیم آیا هنوز ردیفی وجود دارد که نتیجه نداشته باشد؟
                bool allResultsEntered = details.All(d => d.Result.HasValue);

                if (allResultsEntered)
                {
                    DGVDetails.AutoGenerateColumns = false;
                    // فقط در صورتی که همه‌ی جواب‌ها ثبت شده باشند، گریدها را ریست می‌کنیم
                    DGVDetails.DataSource = null;
                    BindGridTestHeader(); // گرید بالا را دوباره پر کن تا رکورد حذف شده نشان داده نشود
                }
                else
                {
                    DGVDetails.AutoGenerateColumns = false;
                    DGVDetails.DataSource = null;
                    DGVDetails.DataSource = details;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ثبت نتیجه : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            lstPatient.ValueMember = "PatientID";
            lstPatient.DisplayMember = "FullInfoPatient";
            if (!string.IsNullOrEmpty(txtSearchPatient.Text))
            {
                lstPatient.Visible = true;
                if (txtSearchPatient.Text.StartsWith("0"))
                {
                    lstPatient.DataSource = repo.SearchPaitentByNationalCode(txtSearchPatient.Text);
                }
                else if (txtSearchPatient.Text.All(c => char.IsDigit(c)))
                {
                    lstPatient.DataSource = repo.SearchPaitentByPatientHeaderTestID(Convert.ToInt32(txtSearchPatient.Text));
                }
                else if(txtSearchPatient.Text.All(c => char.IsLetter(c)))
                {
                    lstPatient.DataSource = repo.SearchPatientByPatientName(txtSearchPatient.Text);
                }
                
            }
            else
            {
                lstPatient.Visible = false;
                BindGridTestHeader();

            }
        }

        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstPatient.SelectedIndex < 0)
                {
                    MessageBox.Show("خواهشمند است یکی را انتخاب کنید ");
                    return;
                }
                else
                {
                    PatientID = Convert.ToInt32(lstPatient.SelectedValue);
                    var TestHeader = repoHeader.GetPendingTestByPatientID(PatientID);
                    if (TestHeader == null)
                    {
                        DGVDetails.AutoGenerateColumns = false;
                        DGVTestHeader.AutoGenerateColumns = false;
                        DGVTestHeader.DataSource = null;
                        DGVDetails.DataSource = null;
                    }
                    else
                    {

                        DGVDetails.AutoGenerateColumns = false;
                        DGVTestHeader.AutoGenerateColumns = false;
                        DGVTestHeader.DataSource =TestHeader;
                        DGVDetails.DataSource = null;
                        PatientRepository repoPatient = new PatientRepository();
                        txtSearchPatient.Text = repoPatient.Get(PatientID).FirstName + "   " + repoPatient.Get(PatientID).LastName + "   " + repoPatient.Get(PatientID).NationalCode;
                        lstPatient.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در کلیک روی بیمار : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
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
                NewPatientTestDetail.TestID = OldPatientTestDetails.TestID;
                NewPatientTestDetail.Result = Result;
                NewPatientTestDetail.PatientTestHederID = OldPatientTestDetails.PatientTestHederID;
                NewPatientTestDetail.PatientTestDetailsID = OldPatientTestDetails.PatientTestDetailsID;
                NewPatientTestDetail.Price = OldPatientTestDetails.Price;
                NewPatientTestDetail.HasStar = this.HasStar;
                repoHeader.UpdatePatientDetails(NewPatientTestDetail);
                //Bind Grid Test Details ; 
                DGVDetails.DataSource = new ResultTestRepository().GetDetails(PatientTestHederID);
                CleanForm();

                txtTestName.Enabled = false;
                lblTestTitle.Visible = false;
                lblResultTitle.Visible = false;
                txtResult.Visible = false;
                txtTestName.Visible = false;
                GoToAddMode();
                btnAddResult.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه ویرایش : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                BindGridTestHeader();
                //DGVDetails.AutoGenerateColumns = false; 
                //DGVDetails.DataSource = null;
                btnAddResult.Visible = false;
                txtTestName.Enabled = false;
                lblTestTitle.Visible = false;
                lblResultTitle.Visible = false;
                txtResult.Visible = false;
                txtTestName.Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception("ارور در دکمه انصراف : خواهشمند است با مدیر سیستم تماس بگیرید" + ex);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (!txtResult.Text.All(c=>char.IsDigit(c)))
            {
                MessageBox.Show("نتیجه فقط میتواند عدد باشد");
                return;
            }
        }
    }
}
