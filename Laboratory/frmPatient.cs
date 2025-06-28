using DoaminModel.Models;
using DoaminModel.ViewModel.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmPatient: Form
    {
        private int PatientID = 0;
        DataAccess.PatientRepository repo = new DataAccess.PatientRepository();
        public void BindGrid()
        {
            dataGridViewPatient.DataSource = null;
            dataGridViewPatient.AutoGenerateColumns = false;
            dataGridViewPatient.DataSource = repo.GetAll();
        }
        /// <summary>
        /// پاک کردن کل فرم از دیتا
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
                else if (control is RadioButton)
                {
                    var rdb = (RadioButton)control;
                    rdbMale.Checked = true;
                }
                txtDescription.Text = "";
                txtAge.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNationalCode.Text = "";
                txtPhoneNumber.Text = "";
                txtSearchFirstName.Text = "";
                txtSearchLastName.Text = "";
                txtSearchNationalCode.Text = "";
                txtSearchPhoneNumber.Text = "";
                rdbMale.Checked = true;
                txtAddress.Text = "";
                txtDescription.Text = "";
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
        public frmPatient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    err.SetError(txtFirstName, "اسم نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    err.SetError(txtLastName, "نام خانوادگی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtNationalCode.Text))
                {
                    err.SetError(txtNationalCode, "کد ملی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    err.SetError(txtPhoneNumber, "تلفن نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtAge.Text))
                {
                    err.SetError(txtAge, "سن بیمار نمیتواند خالی باشد");
                    return;
                }
                if (!rdbMale.Checked && !rdbFamle.Checked)
                {
                    err.SetError(groupBox1, " خواهشمند است یکی از گزینه ها را انتخاب کنید");
                    return;
                }
                Patient patient = new Patient
                {
                    Address = txtAddress.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    NationalCode = txtNationalCode.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Description =txtDescription.Text
                };
                if (rdbMale.Checked)
                {
                    patient.Gender = true;
                }
                else if (!rdbFamle.Checked)
                {
                    patient.Gender = false;
                }
                if (patient.NationalCode.Length != 10)
                {
                    MessageBox.Show("کد ملی باید 10 رقم باشد");
                    return;
                }
                if (patient.PhoneNumber.Length != 11)
                {
                    MessageBox.Show("موبایل باید 11 رقم باشد");
                    return;
                }
                repo.Add(patient);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("با پشتیبانی تماس بگیرید");
            }
           

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
                err.Clear();
                BindGrid();
            }
            catch (Exception)
            {

                throw new Exception("خواهشمند است به مدیر سیستم اطلاغ بدهید");
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    err.SetError(txtFirstName, "اسم نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    err.SetError(txtLastName, "نام خانوادگی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtNationalCode.Text))
                {
                    err.SetError(txtNationalCode, "کد ملی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    err.SetError(txtPhoneNumber, "تلفن نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtAge.Text))
                {
                    err.SetError(txtAge, "سن بیمار نمیتواند خالی باشد");
                    return;
                }
                if (!rdbMale.Checked && !rdbFamle.Checked)
                {
                    err.SetError(groupBox1, " خواهشمند است یکی از گزینه ها را انتخاب کنید");
                    return;
                }
                Patient patient = new Patient
                {
                    PatientID = this.PatientID,
                    Address = txtAddress.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    NationalCode = txtNationalCode.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Description =txtDescription.Text
                };
                if (patient.NationalCode.Length != 10)
                {
                    MessageBox.Show("کد ملی باید 10 رقم باشد");
                    return;
                }
                if (patient.PhoneNumber.Length != 11)
                {
                    MessageBox.Show("موبایل باید 11 رقم باشد");
                    return;
                }
                if (rdbMale.Checked)
                {
                    patient.Gender = true;
                }
                else if (!rdbFamle.Checked)
                {
                    patient.Gender = false;
                }
                repo.Update(patient);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("با مدیر سیستم تماس بگیرید");
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

                throw new Exception("خواهشمند است با مدیر سیستم تماس بگیرید");
            }
          
        }

        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatientID = Convert.ToInt32(dataGridViewPatient.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("آیا مطمئن هستید که میخواهید این بیمار را حذف کنید ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.HasExsistInPatientHear(PatientID))
                        {
                            MessageBox.Show("این بیمار دارای سابقه بوده است و امکان حذف آن وجود ندارد");
                            return;
                        }
                        else
                        {
                            repo.Delete(PatientID);
                            CleanForm();
                            err.Clear();
                            GoToAddMode();
                            BindGrid();
                        }
                    }
                }
                else
                {
                    GoToAddMode();
                    CleanForm();
                }
                if (e.ColumnIndex == 7)
                {
                    Patient patient = repo.Get(PatientID);
                    txtFirstName.Text = patient.FirstName;
                    txtLastName.Text = patient.LastName;
                    txtDescription.Text = patient.Description;
                    txtNationalCode.Text = patient.NationalCode;
                    txtAddress.Text = patient.Address;
                    txtAge.Text = patient.Age.ToString();
                    txtPhoneNumber.Text = patient.PhoneNumber;
                    if (patient.Gender)
                    {
                        rdbMale.Checked = true;
                    }
                    else if (!patient.Gender)
                    {
                        rdbFamle.Checked = true;
                    }
                    GoToEditMode();
                    err.Clear();

                }
            }
            catch (Exception)
            {

                throw new Exception("خواهشمند است با مدیر سیستم تماس بگیرید");
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                err.Clear();
            }
            if (txtFirstName.Text.Length == 0)
            {
                return;
            }
            if (!char.IsLetter(txtFirstName.Text.Trim()[0]))
            {
                MessageBox.Show("نام باید شامل حروف باشد");
                txtFirstName.Text = "";
                return;
            }
            if (!txtFirstName.Text.Skip(1).All(x => char.IsLetter(x) || x == ' '))
            {
                MessageBox.Show("نام باید شامل حروف باشد");
                txtFirstName.Text = "";
                return;
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNationalCode.Text))
            {
                err.Clear();
            }
            if (txtNationalCode.Text.Length == 0)
            {
                return;
            }
            if (!txtNationalCode.Text.Trim().All(c=>char.IsDigit(c)))
            {
                MessageBox.Show("کد ملی باید عدد باشد");
                txtNationalCode.Text = "";
                return;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                err.Clear();
            }
            if (txtLastName.Text.Length == 0)
            {
                return;
            }
            if (!char.IsLetter(txtLastName.Text.Trim()[0]))
            {
                MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                txtLastName.Text = "";
                return;
            }
            if (!txtLastName.Text.Skip(1).All(x => char.IsLetter(x) || x == ' '))
            {
                MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                txtLastName.Text = "";
                return;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                err.Clear();
            }
            if (txtPhoneNumber.Text.Length == 0)
            {
                return;
            }
            if (!txtPhoneNumber.Text.Trim().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("کد ملی باید عدد باشد");
                txtPhoneNumber.Text = "";
                return;
            }

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text.Length == 0)
            {
                return;
            }
            if (!txtAge.Text.Trim().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("سن باید عدد باشد");
                txtAge.Text = "";
                return;
            }
            if (!string.IsNullOrEmpty(txtAge.Text))
            {
                err.Clear();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                err.Clear();
            }

        }

        private void txtSearchNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchNationalCode.Text.Length == 0)
            {
                BindGrid();
                return;
            }
            if (!txtSearchNationalCode.Text.Trim().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("کد ملی باید عدد باشد");
                txtSearchNationalCode.Text = "";
                return;
            }
            if (!string.IsNullOrEmpty(txtSearchNationalCode.Text))
            {
                DoSearch();
            }
            else
            {
                BindGrid();
            }
        }

        private void txtSearchPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPhoneNumber.Text.Length == 0)
            {
                BindGrid();
                return;
            }
            if (!txtSearchPhoneNumber.Text.Trim().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("موبایل باید عدد باشد");
                txtSearchPhoneNumber.Text = "";
                return;
            }
            if (!string.IsNullOrEmpty(txtSearchPhoneNumber.Text))
            {
                DoSearch();
            }
            else
            {
                BindGrid();
            }
        }

        private void txtSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFirstName.Text.Length == 0)
            {
                BindGrid();
                return;
            }
            else if (!char.IsLetter(txtSearchFirstName.Text.Trim()[0]))
            {
                MessageBox.Show("نام  باید شامل حروف باشد");
                txtSearchFirstName.Text = "";
                return;
            }
            else if (!txtSearchFirstName.Text.Skip(1).All(x => char.IsLetter(x) || x == ' '))
            {
                MessageBox.Show("نام  باید شامل حروف باشد");
                txtSearchFirstName.Text = "";
                return;
            }
            else if (!string.IsNullOrEmpty(txtSearchFirstName.Text))
            {
                DoSearch();
            }
            else
            {
                BindGrid();
            }
        }

        private void DoSearch()
        {    
            PatientSearchItemForPanelSearch sm = new PatientSearchItemForPanelSearch();
            if (!string.IsNullOrEmpty(txtSearchFirstName.Text))
            {
                sm.FirstName = txtSearchFirstName.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchLastName.Text))
            {
                sm.LastName = txtSearchLastName.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchNationalCode.Text))
            {
                sm.NationalCode = txtSearchNationalCode.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchPhoneNumber.Text))
            {
                sm.PhoneNumber = txtSearchPhoneNumber.Text;
            }
            dataGridViewPatient.DataSource = repo.SearchWtihItem(sm);
        }

        private void txtSearchLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchLastName.Text.Length == 0)
            {
                BindGrid();
                return;
            }
            else if (!char.IsLetter(txtSearchLastName.Text.Trim()[0]))
            {
                MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                txtSearchLastName.Text = "";
                return;
            }
            else if (!txtSearchLastName.Text.Skip(1).All(x => char.IsLetter(x) || x == ' '))
            {
                MessageBox.Show("نام خانوادگی  باید شامل حروف باشد");
                txtSearchLastName.Text = "";
                return;
            }
            else if (!string.IsNullOrEmpty(txtSearchLastName.Text))
            {
                DoSearch();
            }
            else
            {
                BindGrid();
            }
        }
    }
}
