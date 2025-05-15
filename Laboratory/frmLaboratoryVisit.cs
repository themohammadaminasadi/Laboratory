using DataAccess;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        private void GoToEditMode()
        {
            btnEdit.Visible = true;
            btnAddTest.Visible = false;
        }
        #endregion
        private void BindGrid()
        {
            DGVTestDetails.DataSource = null;
            DGVTestDetails.AutoGenerateColumns = false;
            DGVTestDetails.DataSource = repo.GetAllForGirdFormVisit(this.PaitentHeaderID);
        }
        public void CleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    var txt = (TextBox)control;
                    txt.Text = "";
                }
                else if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    cmb.SelectedIndex = 0;
                }
                lblNationalCodePatient.Text = "";
                lblPatientName.Text = "";
                lblPatientTestHederID.Text = "";
                txtNationalCode.Text = "";
                txtPatient.Text = "";
                txtMobileNumber.Text = "";
                txtDrName.Text = "";
                txtAge.Text = "";
                lstPatient.DataSource = null;
                cmbInsurance.SelectedIndex = -1;
                faDatePicker1.SelectedDateTime = null;

            }
        }
        private void frmLaboratoryVisit_Load(object sender, EventArgs e)
        {
            lstPatient.Visible = false;
            BindCombo();
            txtPriceTest.Visible = false;
            txtPriceWithDiscount.Visible = false;
            txtDiscount.Visible = false;
            txtPriceTest.Enabled = false;
            txtDiscount.Enabled = false;
            txtPriceWithDiscount.Enabled = false;
            GoToAddMode();
            
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
                else if (txtPatient.Text.All(c=>char.IsDigit(c)))
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

        private void lstPatient_DoubleClick(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPatientTest_Click(object sender, EventArgs e)
        {
            //validation Form
            PaitentTestHeder paitentHeader = new PaitentTestHeder();
            paitentHeader.HederDate = faDatePicker1.SelectedDateTime;
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
            //CleanForm();
            //ADD Panel Details
            //err.clear
            
            
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient();
            frmPatient.Show();
            
        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {
            lstTest.ValueMember = "TestID";
            lstTest.DisplayMember = "TestName";
            if (!string.IsNullOrEmpty(txtTestName.Text))
            {
                lstTest.Visible = true;
                
                lstTest.DataSource = repoTest.GetAllTestForListViewFormInsuranceTest(txtTestName.Text);
            }
            else
            {
                lstTest.Visible = false;
            }
        }

        private void lstTest_DoubleClick(object sender, EventArgs e)
        {
            TestID = Convert.ToInt32(lstTest.SelectedValue);
            Test test = repoTest.Get(TestID);
            txtTestName.Text = test.TestName;
            lstTest.Visible = false;
            txtPriceWithDiscount.Visible = true;
            txtDiscount.Visible = true;
            txtPriceTest.Visible = true;
            txtPriceTest.Text = test.Price.ToString();
            
            InsuranceTest insuranceTest = insuranceTestRepository.Get(InsuranceID, TestID);
            txtDiscount.Text = insuranceTest.Discount.ToString();
            txtPriceWithDiscount.Text = (Convert.ToInt32(txtPriceTest.Text) * Convert.ToInt32(txtDiscount.Text)).ToString();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            PatientTestDetail patientTestDetail = new PatientTestDetail();
            patientTestDetail.TestID = this.TestID;
            patientTestDetail.PatientTestHederID = this.PaitentHeaderID;
            patientTestDetail.Price = Convert.ToInt64(txtPriceWithDiscount.Text);
            patientTestDetail.Result = null;
            patientTestDetail.Result = null;
            int PatientTestDetailID = repo.Add(patientTestDetail);
            //cleanPanel 2
            BindGrid();
            lblTotalPriceTests.Text = repo.GetTotalPrice(this.PaitentHeaderID).ToString();
            //Clean Form

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVTestDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientTestDetailsID = Convert.ToInt32(DGVTestDetails.Rows[e.RowIndex].Cells[1].Value);
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا میخواهید این آزمایش را حذف کنید ؟ ","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    repo.DeleteDetails(PatientTestDetailsID);
                    BindGrid();
                    
                }
                else
                {
                    //CleanForm
                    //GoToAddMode
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PatientTestDetail patientTestDetail = new PatientTestDetail();
            patientTestDetail.TestID = Convert.ToInt32(lstTest.SelectedValue);
            patientTestDetail.PatientTestDetailsID = this.PatientTestDetailsID;
            patientTestDetail.PatientTestHederID = this.PaitentHeaderID;
            patientTestDetail.Result = null;
            patientTestDetail.HasStar = null;
            patientTestDetail.Price = Convert.ToInt64(txtPriceTest.Text);
            repo.UpdatePatientDetails(patientTestDetail);
            GoToAddMode();
            BindGrid();
            //cleanForm
            //Clean Error

        }
    }
}
