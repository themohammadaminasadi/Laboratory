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

            btnEditResult.Visible = true;
            btnCancle.Visible = true;
        }
        private void BindCombo()
        {
            var listCombo = new DataAccess.InsuranceRepository().GetAll();
            listCombo.Insert(0, new DoaminModel.Models.Insurance { InsuranceID = -1, InsuranceTypeName = "انتخاب کنید" });
            cmbInsurance.DataSource = null;
            
            cmbInsurance.ValueMember = "InsuranceID";
            cmbInsurance.DisplayMember = "InsuranceTypeName";
            cmbInsurance.DataSource = listCombo;
        }
        private void DGVTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientTestHederID = Convert.ToInt32(DGVTestHeader.Rows[e.RowIndex].Cells[0].Value);
            PatientID = repoHeader.Get(PatientTestHederID).PaitentID;
            if (e.ColumnIndex == 7)
            {
                DGVDetails.DataSource  = new ResultTestRepository().GetDetails(PatientTestHederID);

            }
            //Bind With Data ListItemResultTestHeader
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
            PatientTestDetailsID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnPatientTestDetailsID"].Value);
            TestID = Convert.ToInt32(DGVDetails.Rows[e.RowIndex].Cells["ClmnTestID"].Value);

           
            if (DGVDetails.Columns[e.ColumnIndex].Name == "ClmnEditDetailsTest")
            {
                PatientTestDetail patientTestDetail = repoHeader.GetPatientDetails(PatientTestDetailsID);
                if (patientTestDetail.Result.HasValue)
                {
                    GoToEditMode();
                    txtResult.Text = patientTestDetail.Result.ToString();
                    txtTestName.Text = patientTestDetail.Test.TestName;
                    txtTestName.Enabled = false;
                }
                else if (!patientTestDetail.Result.HasValue)
                {
                    MessageBox.Show("این آزمایش نتیجه ندارد ");
                    return;
                }


            }
        }
        private void CleanGridDetails()
        {
            DGVDetails.AutoGenerateColumns = false;
            DGVDetails.DataSource = null;
        }
        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            //BindGridTestHeader();
            BindCombo();
            GoToAddMode();
            CleanGridDetails();

            //تنظیم فرمت تاریخ :  
            DGVTestHeader.Columns["ClmnHederDate"].DefaultCellStyle.Format = "yyyy/MM/dd";

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                ls.FullName = txtFullName.Text;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNationalCode.Text))
            {
                ls.NationalCode = txtNationalCode.Text;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                ls.MobileNumer = txtPhoneNumber.Text;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDrName.Text))
            {
                ls.DrName = txtDrName.Text;
                CleanGridDetails();
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();

            }
        }

        private void txtSearchFromAge_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchFromAge.Text))
            {
                ls.FromAge = Convert.ToInt32(txtSearchFromAge.Text);
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void txtSearchToAge_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchToAge.Text))
            {
                ls.ToAge = Convert.ToInt32(txtSearchToAge.Text);
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    decimal total = repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);
                    lblTotalPrice.Text = total.ToString();
                }
            }
        }

        private void faDatePickerFrom_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            if (faDatePickerFrom.SelectedDateTime != null )
            {
                ls.FromHederDate = faDatePickerFrom.SelectedDateTime;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);
                    
                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void faDatePickerToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            if (faDatePickerToDate.SelectedDateTime != null )
            {
                ls.ToHederDate = faDatePickerToDate.SelectedDateTime;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void cmbInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInsurance.SelectedIndex >= 0)
            {
                int InsuranceID = Convert.ToInt32(cmbInsurance.SelectedValue);
                ls.InsuranceID = InsuranceID;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void txtPatientTestHederID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatientHeaderID.Text))
            {
                PatientTestHederID = Convert.ToInt32(txtPatientHeaderID.Text);
                ls.PatientTestHederID = PatientTestHederID;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void grpGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                ls.Gender = true;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void rdbFamle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFamle.Checked)
            {
                ls.Gender = false;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void rdbBothGender_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBothGender.Checked)
            {
                ls.Gender = null;
                var lst = DoSearch(ls);
                CleanGridDetails();
                foreach (var item in lst)
                {
                    total += repo.TotalPriceForComprehensiveOrderReport(item.PatientTestHederID);

                }
                lblTotalPrice.Text = total.ToString();
            }
        }

        private void btnEditResult_Click(object sender, EventArgs e)
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
        }
        private void CleanForm()
        {
            txtResult.Text = "";
            txtTestName.Text = "";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
            DGVDetails.AutoGenerateColumns = false;
            DGVDetails.DataSource = null;
        }

        private void GoToAddMode()
        {
            btnEditResult.Visible = false;
            btnCancle.Visible = false;
        }
    }
}
