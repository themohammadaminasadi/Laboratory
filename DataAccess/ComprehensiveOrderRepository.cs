using DataAccessServices.services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Order;
using DoaminModel.ViewModel.PatientTest;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ComprehensiveOrderRepository : IComprehensiveOrderRepository
    {
        private LaboratoryContext db = new LaboratoryContext();

        public List<PatientTestDetail> GetPatientDetailsForCalcualteTotalPrice(int PatientTestHederID)
        {
            return db.PatientTestDetails.Where(x => x.PatientTestHederID == PatientTestHederID).ToList();
        }

        public List<ListItemResultTestHeader> SearchComprehensiveOrderForPushDataGridTestHeader(ItemsSearchOrderReport ls)
        {
            var q = from P in db.PaitentTestHeders select P;
            if (!string.IsNullOrEmpty(ls.FullName))
            {
                q = q.Where(x => (x.Patient.FirstName + " " + x.Patient.LastName).Contains(ls.FullName));
            }
            if (!string.IsNullOrEmpty(ls.Employee))
            {
                q = q.Where(x => (x.Employee.FirstName + " " + x.Employee.LastName).StartsWith(ls.Employee));
            }
            if (ls.InsuranceID > 0)
            {
                q = q.Where(x => x.InsuranceID == ls.InsuranceID);
            }
            if (!string.IsNullOrEmpty(ls.MobileNumer) && ls.MobileNumer.StartsWith("09"))
            {
                q = q.Where(x => x.Patient.PhoneNumber.StartsWith(ls.MobileNumer));
            }
            if (!string.IsNullOrEmpty(ls.NationalCode))
            {
                q = q.Where(x => x.NationalCode.StartsWith(ls.NationalCode));
            }
            if (!string.IsNullOrEmpty(ls.DrName))
            {
                q = q.Where(x => x.DrName.Contains(ls.DrName));
            }
            if (ls.PatientTestHederID > 0 )
            {
                q = q.Where(x => x.PatientTestHederID == ls.PatientTestHederID);
            }
            if (ls.FromAge != null)
            {
                q = q.Where(x => x.Age >= ls.FromAge);
            }
            if (ls.ToAge != null)
            {
                q = q.Where(x => x.Age <= ls.ToAge);
            }
            if (ls.FromHederDate != null)
            {
                q = q.Where(x => x.HederDate >= ls.FromHederDate);
            }
            if (ls.ToHederDate != null)
            {
                q = q.Where(x => x.HederDate <= ls.ToHederDate);
            }
            if (ls.Gender != null)
            {
                q = q.Where(x => x.Patient.Gender == ls.Gender);
            }
            var Result = from q1 in q
                         select new ListItemResultTestHeader
                         {
                             PatientTestHederID = q1.PatientTestHederID,
                             PaitentID = q1.PaitentID,
                             Age = q1.Age,
                             DrName = q1.DrName,
                             HederDate = q1.HederDate,
                             NationalCode = q1.NationalCode,
                             FullNamePaitent = q1.Patient.FirstName + q1.Patient.LastName,
                         };
            return Result.ToList();
        }

        public decimal TotalPriceForComprehensiveOrderReport(int PatientTestHederID)
        {
            return db.PatientTestDetails.Where(x => x.PatientTestHederID == PatientTestHederID).Sum(x => (decimal?)x.Price) ?? 0;
        }

        //public decimal TotalPriceInsuraceToWe(int PatientTestHederID)
        //{
        //    return db.PatientTestDetails.Where(x => x.PatientTestHederID == PatientTestHederID).Sum(x => (decimal?)x.Price **(x.PaitentTestHeder.Insurance.InsuranceTests.Select(x => x.Discount)) ;
        //}
    }
}
