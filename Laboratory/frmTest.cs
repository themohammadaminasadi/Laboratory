using DataAccess;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratory
{
    public partial class frmTest: Form
    {
        private int TestID = 0;
        private int UnitID = 0;
        private TestRepository repo = new TestRepository();
        private CategoryRepository repoCategoryTest = new CategoryRepository();
        private UnitRepository repoUnit = new UnitRepository();
        DoaminModel.ViewModel.Test.TestListItemSearchForFormTest sm = new DoaminModel.ViewModel.Test.TestListItemSearchForFormTest();
        private void BindCombo()
        {
            cmbCategory.DataSource = null;
            var lst = new CategoryRepository().GetAll();
            lst.Insert(0, new DoaminModel.Models.TestCategory { CategoryID = -1, CategoryName = "......انتخاب کنید........." });
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = lst;
        }
        //private void BindCheckListBox()
        //{
        //    checklistCategoryTest.Items.Clear();
        //    var lstCategoryListItem = repoCategoryTest.GetAllForComboFormTest();
        //    foreach (var item in lstCategoryListItem)
        //    {
        //        checklistCategoryTest.Items.Add(item.CategoryName);
        //    }
        //}
        public void BindGrid()
        {
            DataGridViewTest.DataSource = null;
            DataGridViewTest.AutoGenerateColumns = false;
            DataGridViewTest.DataSource = repo.GetAllTestListForGrid();
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    var txt = (System.Windows.Forms.TextBox)control;
                    txt.Text = "";
                }
                cmbCategory.SelectedValue =-1;
                txtFromUnitPrice.Text = "";
                txtSearchToUnitPrice.Text = "";
                txtSearchTest.Text = "";
                rdbHasAge.Checked = true;
                rdbHasGender.Checked = true;
                txtSearchUnit.Text = "";
                //for (int i = 0; i < checklistCategoryTest.Items.Count; i++)
                //{
                //    checklistCategoryTest.SetItemChecked(i, false);
                //}
                lstUnit.Visible =false; 

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
        public frmTest()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            CleanForm();
            BindCombo();
            //BindCheckListBox();
            BindGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTest.Text))
            {
                lblErrorTest.Text = "خواهشمند است آزمایش را وارد کنید";
                return;
            }
            if (cmbCategory.SelectedIndex <= 0)
            {
                err.SetError(cmbCategory, "خواهشمند است گروه را انتخاب کنید");
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lblErrorPrice.Text = "خواهشمند است قیمت آزمایش را وارد کنید";
                return;
            }
            if (lstUnit.SelectedItem == null)
            {
                err.SetError(lstUnit, "خواهشمند است روی واحدهای دو بار کلیک کنید تا در text box وارد شود.");
                return;
            }
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                err.SetError(txtUnit, "خواهشمند است ابتدا سرچ بکنید نام واحد را و سپس واحد را از لیست انتخاب کنید");
                return;
            }
            Test test = new Test
            {
                Description = txtDescription.Text,
                Price = Convert.ToInt32(txtPrice.Text),
                TestName = txtTest.Text,
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                UnitID = Convert.ToInt32(lstUnit.SelectedValue)
            };
            if (rdbHasAge.Checked)
            {
                test.AgeHasEfect = true;
            }
            else if (rdbNotAge.Checked)
            {
                test.AgeHasEfect = false;
            }
            else if(rdbUnKnownAge.Checked)
            {
                test.AgeHasEfect = null;
            }
            if (rdbHasGender.Checked)
            {
                test.GenderHasEfect = true;
            }
            else if (rdbNotHasGender.Checked)
            {
                test.GenderHasEfect = false;
            }
            else if(rdbUnknownGender.Checked)
            {
                test.GenderHasEfect = null;
            }
                repo.Add(test);

            CleanForm();
            BindGrid();
            GoToAddMode();
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnit.Text))
            {
                lstUnit.Visible = true;
                lstUnit.DisplayMember = "UnitName";
                lstUnit.ValueMember = "UnitID";
                lstUnit.DataSource = repoUnit.SearchUnitForFormTest(txtUnit.Text);
            }
            else
            {
                lstUnit.Visible = false;    
            }
        }

        private void lstUnit_DoubleClick(object sender, EventArgs e)
        {
            UnitID = Convert.ToInt32(lstUnit.SelectedValue);
            string UnitName = repoUnit.Get(UnitID).UnitName;
            if (UnitName != null)
            {
                txtUnit.Text = UnitName;
                lstUnit.Visible = false;    
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
            err.Clear();
        }

        private void DataGridViewTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestID = Convert.ToInt32(DataGridViewTest.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 9)
            {
                Test Test = repo.Get(TestID);
                txtPrice.Text = Test.Price.ToString();
                txtDescription.Text = Test.Description;
                txtUnit.Text =repoUnit.Get(Test.UnitID).UnitName;
                cmbCategory.SelectedValue = Test.CategoryID;
                txtTest.Text = Test.TestName;
                if (Test.AgeHasEfect==true)
                {
                    rdbHasAge.Checked = true;
                }
                else if (Test.AgeHasEfect == false)
                {
                    rdbNotAge.Checked = true;
                }
                else if(Test.AgeHasEfect == null)
                {
                    rdbUnKnownAge.Checked = true;
                }
                if (Test.GenderHasEfect == true)
                {
                    rdbHasGender.Checked = true;
                }
                else if(Test.GenderHasEfect == false)
                {
                    rdbNotHasGender.Checked = true;
                }
                else if(Test.GenderHasEfect == null)
                {
                    rdbUnknownGender.Checked = true;   
                }
                GoToEditMode();

            }
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("آیا میخواهید این آزمایش را حفظ کنید ؟","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    if (repo.ExsistTestInTableTestRange(TestID))
                    {
                        MessageBox.Show("این آزمایش دارای سابقه می باشد امکان حذف آن وجود ندارد");
                        return;
                    }
                    else
                    {
                        repo.Delete(TestID);
                        BindGrid();
                        CleanForm();
                        GoToAddMode();
                        err.Clear();
                    }
                }
                else
                {
                    GoToAddMode();
                    CleanForm();
                    err.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTest.Text))
            {
                lblErrorTest.Text = "خواهشمند است آزمایش را وارد کنید";
                return;
            }
            if (cmbCategory.SelectedIndex <= 0)
            {
                err.SetError(cmbCategory, "خواهشمند است گروه را انتخاب کنید");
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lblErrorPrice.Text = "خواهشمند است قیمت آزمایش را وارد کنید";
                return;
            }
            if (lstUnit.SelectedItem == null)
            {
                err.SetError(lstUnit, "خواهشمند است روی واحدهای دو بار کلیک کنید تا در text box وارد شود.");
                return;
            }
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                err.SetError(txtUnit, "خواهشمند است ابتدا سرچ بکنید نام واحد را و سپس واحد را از لیست انتخاب کنید");
                return;
            }
            if (txtUnit.Text.Length >= 2)
            {
                lstUnit.Visible = true;
            }
            Test test = new Test
            {
                TestID = this.TestID,
                Description = txtDescription.Text,
                Price = Convert.ToInt32(txtPrice.Text),
                TestName = txtTest.Text,
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                UnitID = Convert.ToInt32(lstUnit.SelectedValue)
            };
            if (rdbHasAge.Checked)
            {
                test.AgeHasEfect = true;
            }
            else if (rdbNotAge.Checked)
            {
                test.AgeHasEfect = false;
            }
            else if (rdbUnKnownAge.Checked)
            {
                test.AgeHasEfect = null;
            }
            if (rdbHasGender.Checked)
            {
                test.GenderHasEfect = true;
            }
            else if (rdbNotHasGender.Checked)
            {
                test.GenderHasEfect = false;
            }
            else if (rdbUnknownGender.Checked)
            {
                test.GenderHasEfect = null;
            }
            repo.Update(test);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
            BindCombo();
            //BindCheckListBox();
        }

        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtSearchTest.Text) && txtSearchTest.Text.Length >= 2)
            {
                sm.TestName = txtSearchTest.Text;
                BindGridForSearch(sm);
            }
            else
            {
                sm.TestName = null;
                BindGrid();
            }
            
        }
        private void BindGridForSearch(DoaminModel.ViewModel.Test.TestListItemSearchForFormTest sm)
        {
            DataGridViewTest.DataSource = null;
            DataGridViewTest.DataSource = repo.SearchFormTest(sm);
        }

        private void txtSearchUnit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchUnit.Text))
            {
                sm.UnitName = txtSearchUnit.Text;
                BindGridForSearch(sm);
            }
            else
            {
                sm.UnitName = null;
                BindGrid();
            }

        }

        private void txtFromUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFromUnitPrice.Text))
            {
                sm.FromPrice = Convert.ToInt32(txtFromUnitPrice.Text);
                BindGridForSearch(sm);

            }
            else
            {
                sm.FromPrice = null;
                BindGrid();
            }
        }

        private void txtSearchToUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchToUnitPrice.Text))
            {
                sm.ToPrice = Convert.ToInt32(txtSearchToUnitPrice.Text);
                BindGridForSearch(sm);

            }
            else
            {
                sm.ToPrice = null;
                BindGrid();
            }
        }
    }
    }

