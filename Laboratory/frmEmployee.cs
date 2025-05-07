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
        bool VariableShow = false;
        DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
        public void BindGrid()
        {
            dataGridViewEmployee.DataSource = null;
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.DataSource = repo.GetAll();
        }
        /// <summary>
        /// به ازای تکس باکس هایی که در فرم است میاید همه را پاک میکند
        /// </summary>
        public void CleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox )
                {
                    var txt = (TextBox)control;
                    txt.Text = "";
                }
                else if (control is RadioButton)
                {
                    var rdb = (RadioButton)control;
                    rdbActive.Checked = true;
                }
                txtPassword.Text = "";
                txtUserName.Text = "";
                rdbActive.Checked = true;
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNationalCode.Text = "";
                txtPhoneNumber.Text = "";
                txtTitle.Text = "";
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
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
            txtPassword.PasswordChar = '*';
        
            btnShow.BringToFront();

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (MessageBox.Show("آیا مطمئن هستید که میخواهید این کاربر را حذف کنید ؟","هشدار",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    //if any in Other Table ??? 
                    repo.Delete(EmployeeID);
                    BindGrid();
                    CleanForm();
                    err.Clear();
                    GoToAddMode();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            CleanForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            Employee NewEmployee = new Employee
            {
                EmployeeID = this.EmployeeID,
                FirstName = txtFirstName.Text,
                LastName=txtLastName.Text
                                                 ,
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
            repo.Update(NewEmployee);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            Employee NewEmployee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName=txtLastName.Text
                                                ,
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
            repo.Add(NewEmployee);
            CleanForm();
            BindGrid();
            GoToAddMode();
            err.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblSee_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            if (VariableShow)
            {
                txtPassword.PasswordChar = '*';
            }
            if (!VariableShow)
            {
                txtPassword.PasswordChar = '\0';
                VariableShow = true;
            }
        }
    }
}
