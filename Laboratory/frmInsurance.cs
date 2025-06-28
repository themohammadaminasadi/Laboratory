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
    public partial class frmInsurance: Form
    {
        private int InsuranceID = 0;
        InsuranceRepository repo = new InsuranceRepository();
        public void BindGrid()
        {
            dataGridViewInsurance.DataSource = null;
            dataGridViewInsurance.AutoGenerateColumns = false;
            dataGridViewInsurance.DataSource = repo.GetAll();
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
        public frmInsurance()
        {
            InitializeComponent();
        }
        private void dataGridViewInsurance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                InsuranceID = Convert.ToInt32(dataGridViewInsurance.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("آیا مطمئن هستید میخواهید حذف کنید این بیمه را ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.hasInsuranceInTableTemp(InsuranceID))
                        {
                            MessageBox.Show("این بیمه دارای سابقه می باشد در جدول آزمایش نمیتوانید آن را حذف کنید");
                            return;
                        }
                        if (repo.hasInsuranceTableInsuranceType(this.InsuranceID))
                        {
                            MessageBox.Show("این بیمه دارای سابقه می باشد");
                            return;
                        }
                        else
                        {
                            repo.Delete(this.InsuranceID);
                            BindGrid();
                            GoToAddMode();
                            err.Clear();
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
                    Insurance Insurance = repo.Get(InsuranceID);
                    txtInsuranceTypeName.Text = Insurance.InsuranceTypeName;
                    txtDescription.Text = Insurance.Description;
                    GoToEditMode();
                    err.Clear();
                }
            }
            catch (Exception)
            {

                throw new Exception("ارور در گرید : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void frmInsurance_Load(object sender, EventArgs e)
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

                throw new Exception("ارور در لود صفحه : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtInsuranceTypeName.Text))
                {
                    err.SetError(txtInsuranceTypeName, " بیمه را وارد کنید");
                    return;
                }
                Insurance Insurance = new Insurance { InsuranceTypeName = txtInsuranceTypeName.Text, Description = txtDescription.Text };
                if (repo.HasInuranceTypeNameInTableInsurance(Insurance.InsuranceTypeName))
                {
                    MessageBox.Show("بیمه وارد شده تکراری است");
                    return;
                }
                repo.Add(Insurance);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه اضافه کردن : خواهشمند است با مدیر سیستم تماس بگیرید");
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

                throw new Exception("ارور در دکمه انصراف کردن : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInsuranceTypeName.Text))
                {
                    err.SetError(txtInsuranceTypeName, "بیمه نمیتواند خالی باشد");
                    return;
                }
                Insurance insurance = new Insurance { InsuranceID = this.InsuranceID, Description=txtDescription.Text, InsuranceTypeName=txtInsuranceTypeName.Text };
                if (repo.HasInuranceTypeNameInTableInsurance(insurance.InsuranceTypeName))
                {
                    MessageBox.Show("بیمه وارد شده تکراری است");
                    return;
                }
                repo.Update(insurance);
                BindGrid();
                CleanForm();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه ویرایش کردن : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
        }
    }
}
