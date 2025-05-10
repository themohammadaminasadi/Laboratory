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
                lblErrorDiscount.Text = "";
                lblErrorYear.Text = "";
               
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
            PersianCalendar pc = new PersianCalendar();
            txtYear.Text = pc.GetYear(DateTime.Now).ToString();
            txtYear.Enabled = false;
            err.Clear();
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
            repo.Add(insuranceTest);
            BindGrid();
            CleanForm();
            GoToAddMode();
            err.Clear();


        }

        private void dataGridViewInsuraceTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InsuranceTestID = Convert.ToInt32(dataGridViewInsuraceTest.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 5)
            {
                InsuranceTest insuranceTest = repo.Get(InsuranceTestID);
                txtDiscount.Text = insuranceTest.Discount.ToString();
                txtYear.Text = insuranceTest.Year.ToString();
                txtTest.Text = repoTest.Get(insuranceTest.TestID).TestName;
                cmbInsurance.SelectedValue = insuranceTest.InsuraneID;
                GoToEditMode();
                lstTest.Visible = false;    
            }
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا مطمئن هستید که میخواهید این رکورد را حذف کنید؟","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    //if relation in Other Table that Create Method For This Subject
                    repo.Delete(InsuranceTestID);
                    CleanForm();
                    BindGrid();
                    GoToAddMode();
                    err.Clear();
                }
                else
                {
                    CleanForm();
                    GoToAddMode();
                    err.Clear();

                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
            err.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                Discount = Convert.ToInt32(txtDiscount.Text),
                Year = Convert.ToInt32(txtYear.Text),
                TestID = Convert.ToInt32(lstTest.SelectedValue),
                InsuranceTestID = this.InsuranceTestID
            };
            repo.Update(insuranceTest);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
        }
    }
}
