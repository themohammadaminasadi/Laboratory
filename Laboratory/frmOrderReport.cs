using DataAccess;
using DoaminModel.ViewModel.Order;
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
    public partial class frmOrderReport: Form
    {
        private ComprehensiveOrderRepository repo = new ComprehensiveOrderRepository();
        ItemsSearchOrderReport ls = new ItemsSearchOrderReport();
        public frmOrderReport()
        {
            InitializeComponent();
        }

        private void DGVTestHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bind With Data ListItemResultTestHeader
        }
        //private void BindGridTestHeader()
        //{
        //    DGVTestHeader.AutoGenerateColumns = false;
        //    DGVTestHeader.DataSource = new PatientHeaderRepository().GetAll();
        //}
        private void DoSearch(ItemsSearchOrderReport ls)
        {
            DGVTestHeader.AutoGenerateColumns = false;
            DGVTestHeader.DataSource = repo.SearchComprehensiveOrderForPushDataGridTestHeader(ls);
        }
        private void DGVDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            //BindGridTestHeader();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                ls.FullName = txtFullName.Text;
                DoSearch(ls);
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNationalCode.Text))
            {
                ls.NationalCode = txtNationalCode.Text;
                DoSearch(ls);
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                ls.MobileNumer = txtPhoneNumber.Text;
                DoSearch(ls);
            }
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDrName.Text))
            {
                ls.DrName = txtDrName.Text;
                DoSearch(ls);
            }
        }
    }
}
