using DataAccessServices.Services;
using DateAccessServices.Services;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository : IBaseRepository<Employee, int>, IEmployeeRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(Employee Model)
        {
            try
            {
                db.Employees.Add(Model);
                db.SaveChanges();
                return Model.EmployeeID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن به درستی اضافه نشده با پشتیبانی تماس بگیرید");
            }
            
        }

        public bool Delete(int Key)
        {
            try
            {
                db.Employees.Remove(db.Employees.FirstOrDefault(x => x.EmployeeID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با موفقیت انجام نشد با پشتیبانی تماس بگیرید");
            }
            
        }

        public Employee Get(int Key)
        {
            return db.Employees.FirstOrDefault(x => x.EmployeeID == Key);
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public bool Login(string UserName, string Password)
        {
            return db.Employees.Any(x => x.UserName == UserName && x.Password == Password && x.Active == true);
        }
        public bool Update(Employee NewModel)
        {
            try
            {
                var OldEmployee = db.Employees.FirstOrDefault(x => x.EmployeeID == NewModel.EmployeeID);
                OldEmployee.Active = NewModel.Active;
                OldEmployee.Title = NewModel.Title;
                OldEmployee.UserName = NewModel.UserName;
                OldEmployee.Password = NewModel.Password;
                OldEmployee.NationalCode = NewModel.NationalCode;
                OldEmployee.FirstName = NewModel.FirstName;
                OldEmployee.LastName = NewModel.LastName;
                OldEmployee.PhoneNumber = NewModel.PhoneNumber;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات ویرایش با شکست رو به رو شد با پشتیبانی تماس بگیرید");
            }
           
        }

        public Employee GetEmployeeWithUserName(string UserName)
        {
            return db.Employees.FirstOrDefault(x => x.UserName == UserName);
        }

        //Employee IEmployeeRepository.GetEmployeeWithUserName(string UserName)
        //{
        //    return GetEmployeeWithUserName(UserName);
        //}
    }
}
