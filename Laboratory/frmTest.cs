using DataAccess;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void BindCombo()
        {
            cmbCategory.DataSource = null;
            var lst = new CategoryRepository().GetAll();
            lst.Insert(0, new DoaminModel.Models.TestCategory { CategoryID = -1, CategoryName = "......انتخاب کنید........." });
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = lst;
        }
        private void BindCheckListBox()
        {
            checklistCategoryTest.Items.Clear();
            var lstCategoryListItem = repoCategoryTest.GetAllForComboFormTest();
            foreach (var item in lstCategoryListItem)
            {
                checklistCategoryTest.Items.Add(item.CategoryName);
            }
        }
        public void BindGrid()
        {
            DataGridViewTest.DataSource = null;
            DataGridViewTest.AutoGenerateColumns = false;
            DataGridViewTest.DataSource = repo.GetAll();
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
                cmbCategory.SelectedValue =-1;
                txtFromUnitPrice.Text = "";
                txtSearchToUnitPrice.Text = "";
                txtSearchTest.Text = "";
                rdbHasAge.Checked = true;
                rdbHasGender.Checked = true;
                txtSearchUnit.Text = "";
                for (int i = 0; i < checklistCategoryTest.Items.Count; i++)
                {
                    checklistCategoryTest.SetItemChecked(i, false);
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
            BindCheckListBox();
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
                err.SetError(txtUnit, "خواهشمند است واحد را از لیست انتخاب کنید");
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
            else if (!rdbNotAge.Checked)
            {
                test.AgeHasEfect = false;
            }
            if (rdbHasGender.Checked)
            {
                test.GenderHasEfect = true;
            }
            else if (!rdbNotHasGender.Checked)
            {
                test.GenderHasEfect = false;    
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
            }
        }
    }
    }

