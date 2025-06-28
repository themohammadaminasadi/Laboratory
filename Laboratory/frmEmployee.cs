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
    public partial class frmEmployee : Form
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
                if (txtNationalCode.Text.Length != 10)
                {
                    err.SetError(txtNationalCode, "کد ملی باید 10 رقم باشد");
                    return;
                }
                if (txtPhoneNumber.Text.Length != 11)
                {
                    err.SetError(txtPhoneNumber, "شماره تلفن باید 11 رقم باشد");
                    return;
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
                if (txtNationalCode.Text.Length != 10)
                {
                    err.SetError(txtNationalCode, "کد ملی باید 10 رقم باشد");
                    return;
                }
                if (txtPhoneNumber.Text.Length != 11)
                {
                    err.SetError(txtPhoneNumber, "شماره تلفن باید 11 رقم باشد");
                    return;
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
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                return;
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
            if (!txtFirstName.Text.Trim().Skip(1).All(c => char.IsLetter(c) || c == ' '))
            {
                err.SetError(txtFirstName, "نام باید رشته باشد");
                txtFirstName.Text = "";
                return;
            }
            else
            {
                err.Clear();

            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            err.Clear();

            string lastName = txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                return;
            }
            if (txtFirstName.Text.Length == 0)
            {
                return;
            }
            if (!char.IsLetter(txtLastName.Text.Trim()[0]))
            {
                MessageBox.Show("نام خانوادگی باید شامل حروف باشد");
                txtLastName.Text = "";
                return;
            }
            if (!txtLastName.Text.Trim().Skip(1).All(c => char.IsLetter(c) || c == ' '))
            {
                err.SetError(txtLastName, "نام خانوادگی می‌تواند از کاراکتر دوم به بعد شامل فاصله باشد ولی فقط حروف و فاصله مجاز است");
                txtLastName.Text = "";
                return;
            }
            else
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
            if (string.IsNullOrEmpty(txtUserName.Text))
            {

                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                err.Clear();
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {

                return;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            err.Clear();
            if (string.IsNullOrEmpty(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length == 0)
            {
                return;
            }
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                err.Clear();
            }
            if (!txtPhoneNumber.Text.Trim().All(c=>char.IsDigit(c)))
            {
                err.SetError(txtPhoneNumber, "تلفن باید عدد باشد");
                txtPhoneNumber.Text = "";
                return;
            }
            else
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

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtNationalCode.Text) || txtNationalCode.Text.Length == 0)
            {
                return;
            }
            if (!txtNationalCode.Text.All(c=>char.IsDigit(c)))
            {
                err.SetError(txtNationalCode, "کد ملی باید عدد باشد");
                txtNationalCode.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)

        {
            err.Clear();
            if (string.IsNullOrEmpty(txtTitle.Text) || txtTitle.Text.Length == 0)
            {
                return;
            }
            if (!char.IsLetter(txtTitle.Text.Trim()[0]))
            {
                MessageBox.Show("عنوان باید شامل حروف باشد");
                return;
            }
            if (!txtTitle.Text.Trim().Skip(1).All(c=>char.IsLetter(c) || c == ' '))
            {
                err.SetError(txtTitle, "عنوان باید رشته باشد");
                txtTitle.Text = "";
                return;
            }
            else
            {
                err.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
