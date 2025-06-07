using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Patient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PatientRepository : IBaseRepository<Patient, int>,IPatientRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(Patient Model)
        {
            try
            {
                db.Patients.Add(Model);
                db.SaveChanges();
                return Model.PatientID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن با شکست رو به رو شد با پشتیبانی تماس بگیرید");
            }
        }

        public bool Delete(int Key)
        {
            try
            {
                db.Patients.Remove(db.Patients.FirstOrDefault(x => x.PatientID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با شکست رو به رو شد با پشتیبانی تماس بگیرید");
            }
        }

        public Patient Get(int Key)
        {
            return db.Patients.FirstOrDefault(x => x.PatientID == Key);
        }

        public List<Patient> GetAll()
        {
            return db.Patients.ToList();
        }

        public bool HasExsistInPatientHear(int PatientID)
        {
            return db.PaitentTestHeders.Any(x => x.PaitentID == PatientID);
        }

        public List<Patient> SearchWtihItem(PatientSearchItemForPanelSearch sm)
        {
            var q = from P in db.Patients select P;
            if (!string.IsNullOrEmpty(sm.FirstName))
            {
                q = q.Where(x => x.FirstName.StartsWith(sm.FirstName));
            }
            if (!string.IsNullOrEmpty(sm.LastName))
            {
                q = q.Where(x => x.LastName.StartsWith(sm.LastName));
            }
            if (!string.IsNullOrEmpty(sm.NationalCode))
            {
                q = q.Where(x => x.NationalCode.StartsWith(sm.NationalCode));
            }
            if (!string.IsNullOrEmpty(sm.PhoneNumber))
            {
                q = q.Where(x => x.PhoneNumber.StartsWith(sm.PhoneNumber));
            }
            return q.ToList();
        }

        public bool Update(Patient NewModel)
        {
            try
            {
                var OldPatient = db.Patients.FirstOrDefault(x => x.PatientID == NewModel.PatientID);
                OldPatient.FirstName = NewModel.FirstName;
                OldPatient.LastName = NewModel.LastName;
                OldPatient.PhoneNumber = NewModel.PhoneNumber;
                OldPatient.NationalCode = NewModel.NationalCode;
                OldPatient.Address = NewModel.Address;
                OldPatient.Gender = NewModel.Gender;
                OldPatient.Age = NewModel.Age;
                OldPatient.Description = NewModel.Description;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("ویرایش انجام نشد با پشتیبانی تماس بگیرید");
            }
        }
    }
}
