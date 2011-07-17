using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    public class EmployeeBUS
    {
        public EmployerDTO employerDTO = new EmployerDTO();
        private EmployerDAO employerDAO = new EmployerDAO();

        public EmployerDTO CheckLogin(string username, string password)
        {
            password = DataProvider.Encrypt(password);
            employerDTO = employerDAO.GetEmployerByUsername(username);
            if (employerDTO != null)
            {
                if (password.Equals(employerDTO.Password))
                {
                    return employerDTO;
                }
            }
            return null;               
        }

        public List<EmployerDTO> LoadAllEmployee()
        {
            return employerDAO.GetAllEmp();
        }

        public bool CreateEmployee(string username, string password, string fullname, string address, string email, string CMND, string DOB, long roleID, long rightsValue, int isActive, string notes, string phonenumber, long totalDebt)
        {
            return employerDAO.CreateEmployee(username, password, fullname, address, email, CMND, DOB, roleID,
                                              rightsValue, isActive, notes, phonenumber, totalDebt);
        }

        public bool UpdateEmployee(long employeeID, string username, string password, string fullname, string address, string email, string CMND, string DOB, long roleID, long rightsValue, int isActive, string notes, string phonenumber, long totalDebt)
        {
            return employerDAO.UpdateEmployee(employeeID, username, password, fullname, address, email, CMND, DOB, roleID,
                                       rightsValue, isActive, notes, phonenumber, totalDebt);
        }

        public bool CreateEmployeeSalary(EmployeeSalaryDTO salary)
        {
            return employerDAO.CreateEmployeeSalary(salary);
        }

        public bool CreateEmployeeAdvance(EmployeeAdvanceDTO advanceObj)
        {
            return employerDAO.CreateEmployeeAdvance(advanceObj);
        }

        public object LoadAllUser()
        {
            return employerDAO.GetAll();
        }

        public List<EmployeeAdvanceDTO> LoadAdvance(string name, DateTime fromdate, DateTime todate)
        {
            return employerDAO.GetAdvance(name, fromdate, todate);
        }

        public bool UpdateEmployeeAdvance(EmployeeAdvanceDTO advanceObj)
        {
            return employerDAO.UpdateAdvance(advanceObj);
        }

        public bool DeleteAdvance(long id)
        {
            return employerDAO.DeleteAdvance(id);
        }

        public List<EmployerDTO> LoadEmployee(string username, string fullname, string roleName, int status)
        {
            return employerDAO.LoadEmployee(username, fullname, roleName, status);
        }

        public bool DeleteEmp(string username)
        {
            return employerDAO.DeleteEmp(username);
        }

        public bool DeleteAllEmp()
        {
            return employerDAO.DeleteAllEmp();
        }

        public bool UpdateEmployeeRight(long Id, long roleId, long rightValue)
        {
            return employerDAO.UpdateRightEmp(Id, roleId, rightValue);
        }

        public bool DeleteSalary(long salaryId)
        {
            return employerDAO.DeleteSalary(salaryId);
        }

        public bool DeleteAllSalary()
        {
            return employerDAO.DeleteAllSalary();
        }

        public bool UpdateEmployeeSalary(EmployeeSalaryDTO salaryDTO)
        {
            return employerDAO.UpdateSalary(salaryDTO);
        }

        public List<EmployeeSalaryDTO> LoadSalary(string name, string from, string to)
        {
            return employerDAO.GetSalary(name, from, to);
        }

        public bool DeleteAllAdvance()
        {
            return employerDAO.DeleteAllAdvance();
        }
    }
}
