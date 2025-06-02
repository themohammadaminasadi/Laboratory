using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessServices.Services
{
    public interface IEmployeeRepository
    {
        bool Login(string UserName, string Password);
        Employee GetEmployeeWithUserName(string UserName);
        bool ExsistDuplicateUserName(string UserName);
        bool ExsistLogInTablePatientTestHeader(int EmployeeID);
    }
}
