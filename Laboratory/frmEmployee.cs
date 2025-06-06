using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmEmployee: Form
    {
        private int EmployeeID = 0;
        bool VariableShow = true;
        DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
        public void BindGrid()
        {
            dataGridViewEmployee.DataSource = null;
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.DataSource = repo.GetAll();
        }
        void BindComboEmployeeAction()
        {
            var listCombo = new DataAccess.EmployeeActionRepository().GetAll();
            listCombo.Insert(0, new DoaminModel.Models.EmployeeAction { EmployeeActionID = -1, EmployeeActionName = ".........انتخاب کنید ......." });
            cmbEmployeeAction.DataSource = null;
            cmbEmployeeAction.DataSource = listCombo;
            cmbEmployeeAction.ValueMember = "EmployeeActionID";
            cmbEmployeeAction.DisplayMember = "EmployeeActionName";
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            // پاک کردن تکست‌باکس‌ها و رادیوباتن‌ها
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = "";
                }
                else if (control is RadioButton)
                {
                    var rdb = (RadioButton)control;
                    rdbActive.Checked = true;
                }
            }

            
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNationalCode.Text = "";
            txtPhoneNumber.Text = "";
            txtTitle.Text = "";

            if (cmbEmployeeAction.Items.Count > 0)
                cmbEmployeeAction.SelectedIndex = 0;

            rdbActive.Checked = true;
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
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                CleanForm();
                BindGrid();
                BindComboEmployeeAction();
                GoToAddMode();
                err.Clear();
                txtPassword.PasswordChar = '*';
                btnShow.BringToFront();
            }
            catch (Exception)
            {

                throw new Exception("ارور در هنگام لود صفحه : خواهشمند است با راهبر سیستم تماس بگیرید");
            }
         

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmployeeID = Convert.ToInt32(dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 8)
                {
                    Employee Employees = repo.Get(EmployeeID);
                    txtFirstName.Text = Employees.FirstName;
                    txtLastName.Text = Employees.LastName;
                    txtPassword.Text = Employees.Password;
                    txtPhoneNumber.Text = Employees.PhoneNumber;
                    txtTitle.Text = Employees.Title;
                    txtNationalCode.Text = Employees.NationalCode;
                    txtUserName.Text = Employees.UserName;
                    cmbEmployeeAction.SelectedValue = Employees.EmployeeActionID;
                    if (Employees.Active)
                    {
                        rdbActive.Checked = true;
                        rdbDiActive.Checked = false;
                    }
                    if (!Employees.Active)
                    {
                        rdbDiActive.Checked = true;
                        rdbActive.Checked = false;
                    }
                    GoToEditMode();
                    err.Clear();
                }
                if (e.ColumnIndex == 9)
                {
                    if (MessageBox.Show("آیا مطمئن هستید که میخواهید این کاربر را حذف کنید ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        if (repo.ExsistLogInTablePatientTestHeader(EmployeeID))
                        {
                            MessageBox.Show("این کارمند ویزیت ثبت کرده است امکان حذف آن وجود ندارد");
                        }
                        else
                        {
                            repo.Delete(EmployeeID);
                            BindGrid();
                            CleanForm();
                            err.Clear();
                            GoToAddMode();
                        }
                          
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("ارور در فرم کارمندان : خواهشمند است با راهبر سیستم تماس بگیرید");
            }
       
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                GoToAddMode();
                CleanForm();
            }
            catch (Exception)
            {

                throw new Exception("خواهشمند است با مدیر سیستم تماس بگیرید");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    err.SetError(txtLastName, "نام خانواگی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    err.SetError(txtUserName, "نام کاربری نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    err.SetError(txtPassword, "رمز عبور نمیتواند خالی باشد");
                    return;
                }
                if (cmbEmployeeAction.SelectedIndex <= 0)
                {
                    err.SetError(cmbEmployeeAction, "خواهشمند است گروه کارمند در مشخص کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    err.SetError(txtPhoneNumber, "تلفن نمیتواند خالی باشد");
                    return;
                }
                Employee NewEmployee = new Employee
                {
                    EmployeeID = this.EmployeeID,
                    FirstName = txtFirstName.Text,
                    LastName=txtLastName.Text,
                    EmployeeActionID = Convert.ToInt32(cmbEmployeeAction.SelectedValue),
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    NationalCode = txtNationalCode.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Title = txtTitle.Text
                };
                if (rdbActive.Checked)
                {
                    NewEmployee.Active = true;
                }
                else if (rdbDiActive.Checked)
                {
                    NewEmployee.Active = false;
                }
                //if (repo.ExsistDuplicateUserName(NewEmployee.UserName))
                //{
                //    MessageBox.Show("نام کاربری وارد شده تکراری می باشد");
                //    return;
                //}
                repo.Update(NewEmployee);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه آپدیت : خواهمشند است با مدیر سیستم تماس بگیرید");
            }
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    err.SetError(txtLastName, "نام خانواگی نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    err.SetError(txtUserName, "نام کاربری نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    err.SetError(txtPassword, "رمز عبور نمیتواند خالی باشد");
                    return;
                }
                if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    err.SetError(txtPhoneNumber, "تلفن نمیتواند خالی باشد");
                    return;
                }
                if (cmbEmployeeAction.SelectedIndex <= 0)
                {
                    err.SetError(cmbEmployeeAction, "خواهشمند است گروه کارمند در مشخص کنید");
                    return;
                }
                Employee NewEmployee = new Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName=txtLastName.Text
                                                    ,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    NationalCode = txtNationalCode.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Title = txtTitle.Text,
                    EmployeeActionID = Convert.ToInt32(cmbEmployeeAction.SelectedValue)
                };
                if (rdbActive.Checked)
                {
                    NewEmployee.Active = true;
                }
                else if (rdbDiActive.Checked)
                {
                    NewEmployee.Active = false;
                }
                if (repo.ExsistDuplicateUserName(NewEmployee.UserName))
                {
                    MessageBox.Show("نام کاربری وارد شده تکراری می باشد");
                    return;
                }
                repo.Add(NewEmployee);
                CleanForm();
                BindGrid();
                GoToAddMode();
                err.Clear();
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه اضافه کردن : خواهشمند است با مدیر سیستم تماس  بگیرید");
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblSee_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (VariableShow)
                {
                    txtPassword.PasswordChar = '\0';  // نمایش رمز
                }
                else
                {
                    txtPassword.PasswordChar = '*';   // پنهان‌سازی رمز
                }

                VariableShow = !VariableShow; // تغییر وضعیت
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه show : خواهشمند است با مدیر سیستم تماس بگیرید");
            }
          
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                err.Clear();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                err.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                err.Clear();
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                err.Clear();
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (VariableShow)
                {
                    txtPassword.PasswordChar = '\0';  // نمایش رمز
                }
                else
                {
                    txtPassword.PasswordChar = '*';   // پنهان‌سازی رمز
                }

                VariableShow = !VariableShow; // تغییر وضعیت
            }
            catch (Exception)
            {

                throw new Exception("ارور در دکمه show : خواهشمند است با مدیر سیستم تماس بگیرید");
            }

        }
    }
}
