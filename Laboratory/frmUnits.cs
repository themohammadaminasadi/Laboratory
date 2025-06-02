using DoaminModel.Models;
using DoaminModel;
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
    public partial class frmUnits: Form
    {
        private int UnitID = 0;
        DataAccess.UnitRepository repo = new DataAccess.UnitRepository();
        public void BindGrid()
        {
            dataGridViewUnits.DataSource = null;
            dataGridViewUnits.AutoGenerateColumns = false;
            dataGridViewUnits.DataSource = repo.GetAll();
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
        public frmUnits()
        {
            InitializeComponent();
          
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
                GoToAddMode();
                CleanForm();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در لود صفحه : خواهشمند است با پشتیبانی تماس بگیرید");
            }
       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUnitName.Text))
                {
                    err.SetError(txtUnitName, "واحد را وارد کنید");
                    return;
                }
                Unit Units = new Unit { UnitName = txtUnitName.Text };
                repo.Add(Units);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در اضافه کردن : خواهشمند است با پشتیبانی تماس بگیرید");
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUnitName.Text))
                {
                    err.SetError(txtUnitName, "واحد نمیتواند خالی باشد");
                    return;
                }
                Unit NewUnits = new Unit { UnitName = txtUnitName.Text, UnitID = this.UnitID };
                repo.Update(NewUnits);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در آپدیت : خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه انصراف : خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }
        //Delete And Update Unit:
        private void dataGridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnitID = Convert.ToInt32(dataGridViewUnits.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("آیا مطمئن هستید میخواهید حذف کنید این واحد را ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.HasUnitInTest(UnitID))
                        {
                            MessageBox.Show("این واحد دارای سابقه می باشد در جدول آزمایش نمیتوانید آن را حذف کنید");
                            return;
                        }
                        else
                        {
                            repo.Delete(UnitID);
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
                    Unit unit = repo.Get(UnitID);
                    txtUnitName.Text = unit.UnitName;
                    GoToEditMode();
                }
            }
            catch (Exception)
            {

                throw new Exception("ارور در گرید : خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }
    }
}
