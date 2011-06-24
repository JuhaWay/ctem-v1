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
            return employerDAO.GetAll();
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

        public List<EmployeeAdvanceDTO> LoadAllAdvance()
        {
            return employerDAO.GetAllAdvance();
        }

        public List<EmployeeSalaryDTO> LoadAllSalary()
        {
            return employerDAO.GetAllSalary();
        }
    }
}
