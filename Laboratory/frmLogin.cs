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
    public partial class frmLogin: Form
    {
        EmployeeRepository repo = new EmployeeRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

      


        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {

                throw new Exception("با پشتیبانی تماس بگیرید" + ex);
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (repo.Login(txtUserName.Text, txtPassword.Text))
                {
                    this.Hide();
                    Employee employee = repo.GetEmployeeWithUserName(txtUserName.Text);
                    frmSwichBoard frmSwichBoard = new frmSwichBoard(txtUserName.Text, employee.FirstName + " " + employee.LastName);
                    frmSwichBoard.Show();
                    frmSwichBoard.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("رمز عبور یا نام کاربری اشتباه است");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("با پشتیبانی تماس بگیرید روی دکمه ورود ارور به وجود آمده است " + "       " + ex);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
