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

            cmbInsurance.SelectedIndexChanged -= cmbInsurance_SelectedIndexChanged; // ❌ غیرفعال‌سازی

            cmbInsurance.DataSource = null;
            cmbInsurance.ValueMember = "InsuranceID";
            cmbInsurance.DisplayMember = "InsuranceTypeName";
            cmbInsurance.DataSource = listCombo;

            cmbInsurance.SelectedIndex = 0;

            cmbInsurance.SelectedIndexChanged += cmbInsurance_SelectedIndexChanged;
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
            
            BindCombo();
            GoToAddMode();
            CleanGridDetails();

            //تنظیم فرمت تاریخ :  
            DGVTestHeader.Columns["ClmnHederDate"].DefaultCellStyle.Format = "yyyy/MM/dd";

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();

        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
          
            ApplySearchAndTotal();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {
          
            ApplySearchAndTotal();
        }

        private void txtSearchFromAge_TextChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
        }

        private void txtSearchToAge_TextChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
        }

        private void faDatePickerFrom_SelectedDateTimeChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
        }

        private void faDatePickerToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            
            ApplySearchAndTotal();
        }

        private void cmbInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
        }

        private void txtPatientTestHederID_TextChanged(object sender, EventArgs e)
        {
            
            ApplySearchAndTotal();
        }

        private void grpGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {

            
            ApplySearchAndTotal();
        }

        private void rdbFamle_CheckedChanged(object sender, EventArgs e)
        {
            ApplySearchAndTotal();
        }

        private void rdbBothGender_CheckedChanged(object sender, EventArgs e)
        {
           
            ApplySearchAndTotal();
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
