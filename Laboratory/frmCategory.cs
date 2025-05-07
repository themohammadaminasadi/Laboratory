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
    public partial class frmCategory: Form
    {

        private int CategoryID = 0;
        DataAccess.CategoryRepository repo = new DataAccess.CategoryRepository();
        public void BindGrid()
        {
            dataGridViewCategory.DataSource = null;
            dataGridViewCategory.AutoGenerateColumns = false;
            dataGridViewCategory.DataSource = repo.GetAll();
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
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
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
            CleanForm();
            err.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                err.SetError(txtCategoryName, "نام گروه را وارد کنید");
                return;
            }
            DoaminModel.Models.TestCategory Category = new TestCategory { CategoryName = txtCategoryName.Text };
            repo.Add(Category);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                err.SetError(txtCategoryName, "واحد نمیتواند خالی باشد");
                return;
            }
            TestCategory NewCategory = new TestCategory { CategoryName = txtCategoryName.Text, CategoryID = this.CategoryID };
            repo.Update(NewCategory);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryID = Convert.ToInt32(dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا مطمئن هستید میخواهید حذف کنید این گروه را ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    if (repo.HasCategoriesInTableTestCategories(CategoryID))
                    {
                        MessageBox.Show("این گروه دارای سابقه می باشد در جدول آزمایش نمیتوانید آن را حذف کنید");
                        return;
                    }
                    else
                    {
                        repo.Delete(CategoryID);
                        BindGrid();
                        GoToAddMode();
                    }
                }
                else
                {
                    GoToAddMode();
                    CleanForm();
                }
            }
            if (e.ColumnIndex == 2)
            {
                TestCategory Category = repo.Get(CategoryID);
                txtCategoryName.Text = Category.CategoryName;
                GoToEditMode();
            }
        }
    }
}
