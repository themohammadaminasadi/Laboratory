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
        }

        private void DGVTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientTestHederID = Convert.ToInt32(DGVTestHeader.Rows[e.RowIndex].Cells[0].Value);
            PatientID = repoHeader.Get(PatientTestHederID).PaitentID;
            
            if (e.ColumnIndex == 7)
            {
                PatientHeaderRepository repoHeader = new PatientHeaderRepository();
                DGVDetails.DataSource  = new ResultTestRepository().GetDetails(PatientTestHederID);
                
            }
            if (e.ColumnIndex == 8)
            {

            }
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
                txtTestName.Text = patientTestDetail.Test.TestName;
                txtTestName.Enabled = false;
            }
            
            
        }

        private void btnAddResult_Click(object sender, EventArgs e)
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
            BindGridTestHeader();
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
    }
}
