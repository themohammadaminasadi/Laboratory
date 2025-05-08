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
    public partial class frmInsuranceTest: Form
    {
        private int InsuranceTestID = 0;
        private int TestID = 0; 
        private InsuranceTestRepository repo = new InsuranceTestRepository();
        private TestRepository repoTest = new TestRepository();
        private void BindCombo()
        {
            cmbInsurance.DataSource = null;
            cmbInsurance.ValueMember = "InsuranceID";
            cmbInsurance.DisplayMember = "InsuranceTypeName";
            var listCombo = new DataAccess.InsuranceRepository().GetAll();
            listCombo.Insert(0, new DoaminModel.Models.Insurance { InsuranceID = -1, InsuranceTypeName = "انتخاب کنید" });
            cmbInsurance.DataSource = listCombo;
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
        public frmInsuranceTest()
        {
            InitializeComponent();
        }

        private void frmInsuranceTest_Load(object sender, EventArgs e)
        {
            BindCombo();
            CleanForm();
            BindGrid();
            GoToAddMode();
            lstTest.Visible = false;
            txtYear.Text = DateTime.Now.Year.ToString();
            txtYear.Enabled = false;
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
            TestID = Convert.ToInt32(lstTest.SelectedValue);
            Test Test = repoTest.Get(TestID);
            txtTest.Text = Test.TestName;
            lstTest.Visible = false;    

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
