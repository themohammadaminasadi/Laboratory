using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laboratory
{
    public partial class frmSwichBoard: Form
    {
        private string UserName;
        private string FullName;
        public frmSwichBoard()
        {
            InitializeComponent();
        }
        public frmSwichBoard(string userName , string fullName)
        {
            InitializeComponent();
            lblUserName.Text = fullName;
            this.FullName = fullName;
            this.UserName = userName;
        }

        private void frmSwichBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void آزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مدیریتبیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مدیریتبیمارToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool ExsistThisFromInSwitchBoard = false;
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmPatient)
                {
                    child.Activate();
                    ExsistThisFromInSwitchBoard = true;
                    this.StartPosition = FormStartPosition.CenterScreen;

                }
            }
            if (!ExsistThisFromInSwitchBoard)
            {
                frmPatient frmPatient = new frmPatient();
                frmPatient.MdiParent = this;
                frmPatient.Show();
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Framework.Utilities utilities = new Framework.Utilities();
            lblDateTime.Text = utilities.PersianDate(DateTime.Now);
        }

        private void مدیریتکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmEmployee)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
            }
        }

        private void مدیریتبیمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFromInSwitchBoard = false;
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmInsurance)
                {
                    child.Activate();
                    ExsistFromInSwitchBoard = true;
                }
            }
            if (!ExsistFromInSwitchBoard)
            {
                frmInsurance frmInsurance = new frmInsurance();
                frmInsurance.MdiParent = this;
                frmInsurance.Show();
            }
        }

        private void مدیریتفرانشیزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFromInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmInsuranceTest)
                {
                    Child.Activate();
                    ExsistFromInSwitchBoard = true;
                }
            }
            if (!ExsistFromInSwitchBoard)
            {
                frmInsuranceTest frmInsuranceTest = new frmInsuranceTest();
                frmInsuranceTest.MdiParent = this;
                frmInsuranceTest.Show();
            }
        }

        private void ثبتآزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFromInSwitchBoard = false;
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmTest)
                {
                    child.Activate();
                    ExsistFromInSwitchBoard = true;
                }
            }
            if (!ExsistFromInSwitchBoard)
            {
                frmTest frmTest = new frmTest();
                frmTest.MdiParent = this;
                frmTest.Show();
            }
        }

        private void رنجبندیآزمایشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmTestRange)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmTestRange frmTestRange = new frmTestRange();
                frmTestRange.MdiParent = this;
                frmTestRange.Show();
            }
        }

        private void گروهآزمایشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwtichBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmCategory)
                {
                    Child.Activate();
                    ExsistFormInSwtichBoard = true;
                }
            }
            if (!ExsistFormInSwtichBoard)
            {
                frmCategory frmCategory = new frmCategory();
                frmCategory.MdiParent = this;
                frmCategory.Show();
            }
        }

        private void واحدآزمایشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmUnits)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmUnits frmUnits = new frmUnits();
                frmUnits.MdiParent = this;
                frmUnits.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void ثبتآزمایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmLaboratoryVisit)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmLaboratoryVisit frmLaboratoryVisit = new frmLaboratoryVisit(UserName);
                frmLaboratoryVisit.MdiParent = this;
                frmLaboratoryVisit.Show();
            }
        }

        private void ثبتنتیجهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmResultTest)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmResultTest frmResultTest = new frmResultTest();
                frmResultTest.MdiParent = this;
                frmResultTest.Show();
            }
        }

        private void ویرایشنتیجهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmEditResultTest)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmEditResultTest frmEditResultTest = new frmEditResultTest();
                frmEditResultTest.MdiParent = this;
                frmEditResultTest.Show();
            }
        }

        private void گزارشجامعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExsistFormInSwitchBoard = false;
            foreach (Form Child in this.MdiChildren)
            {
                if (Child is frmOrderReport)
                {
                    Child.Activate();
                    ExsistFormInSwitchBoard = true;
                }
            }
            if (!ExsistFormInSwitchBoard)
            {
                frmOrderReport frmOrderReport = new frmOrderReport();
                frmOrderReport.MdiParent = this;
                frmOrderReport.Show();
            }
        }
    }
}
