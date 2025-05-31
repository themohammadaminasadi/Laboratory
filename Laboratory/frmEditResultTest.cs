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
    public partial class frmEditResultTest: Form
    {
        EditResultTestRepository repo = new EditResultTestRepository();
        PatientRepository repoPatient = new PatientRepository();
        private int PatientID = 0;
        public frmEditResultTest()
        {
            InitializeComponent();
        }
        private void ConfigeDataGridViewPatientTestHeader()
        {
            DGVPatientTestHeader.AutoGenerateColumns = false;
            DGVPatientTestHeader.DataSource = null;
        }
        private void frmEditResultTest_Load(object sender, EventArgs e)
        {
            lstPatient.Visible = false;
        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatient.Text))
            {
                ConfigeDataGridViewPatientTestHeader();
                lstPatient.Visible = true;
                lstPatient.DisplayMember = "FullInfoPatient";
                lstPatient.ValueMember = "PatientID";
                if (txtPatient.Text.All(c=>char.IsLetter(c)))
                {
                    
                    lstPatient.DataSource = repo.SearchPatientTestHeaderForFrmEditResultTest(txtPatient.Text);
                }
                else if (txtPatient.Text.StartsWith("09"))
                {
                    lstPatient.DataSource = repo.SearchPatientWithMobileNmuberTestHeaderForFrmEditResultTest(txtPatient.Text);
                }
                else if(txtPatient.Text.All(c=>char.IsDigit(c)))
                {
                    lstPatient.DataSource = repo.SearchPatientWithNationalCodeTestHeaderForFrmEditResultTest(txtPatient.Text);
                }
            }
            else
            {
                lstPatient.Visible = false;
                ConfigeDataGridViewPatientTestHeader();
            }
        }

        private void faDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            if (faDatePicker.SelectedDateTime != null)
            {
                ConfigeDataGridViewPatientTestHeader();
                DGVPatientTestHeader.DataSource = repo.SearchPatientWithDateTimeTestHeaderForFrmEditResultTest(Convert.ToDateTime(faDatePicker.SelectedDateTime));
            }
            else
            {
                ConfigeDataGridViewPatientTestHeader();
            }
        }

        private void lstPatient_DoubleClick(object sender, EventArgs e)
        {
            if (lstPatient.SelectedIndex >= 0 )
            {
                ConfigeDataGridViewPatientTestHeader();
                PatientID = Convert.ToInt32(lstPatient.SelectedValue);
                Patient patient = repoPatient.Get(PatientID);
                txtPatient.Text = patient.FirstName + " " + patient.LastName + " " + patient.NationalCode + " " + patient.PhoneNumber;
                DGVPatientTestHeader.DataSource = repo.GetPatientTestByPatientID(PatientID);
            }
            else
            {
                ConfigeDataGridViewPatientTestHeader();
            }
        }
    }
}
