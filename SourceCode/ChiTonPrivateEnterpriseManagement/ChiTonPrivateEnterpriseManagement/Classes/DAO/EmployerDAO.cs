using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.DAO
{
    class EmployerDAO
    {
        public EmployerDAO()
        {
            Transaction = null;
        }

        public SqlTransaction Transaction { get; set; }
        private SqlConnection _con;

        SqlConnection Connection
        {
            get
            {
                if (_con == null)
                    _con = new SqlConnection(DatabaseInfo.ConnectionString);
                if (_con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }
                return _con;
            }
            set
            {
                _con = value;
            }
        }

        public EmployerDTO GetEmployerByUsername(string username)
        {
            var cmd = new SqlCommand("[dbo].[Employer_GetByUsername]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                EmployerDTO employer = null;
                if (reader.Read())
                {
                    employer = new EmployerDTO
                    {
                        Username = Convert.ToString(reader["Username"]),
                        Password = Convert.ToString(reader["Password"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Address = Convert.ToString(reader["Address"]),
                        Email = Convert.ToString(reader["Email"]),
                        Note = Convert.ToString(reader["Note"]),
                        RoleID = Convert.ToInt64(reader["RoleID"]),
                        Position = Convert.ToString(reader["RoleName"]),
                        RightsValue = Convert.ToInt64(reader["RightsValue"]),
                        CMND = Convert.ToString(reader["CMND"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        //totalDebt = Convert.ToInt64(reader["TotalDebt"])
                    };
                    try
                    {
                        employer.Display = employer.Fullname + " (" + employer.Username + ")";
                        employer.DOB = DateTime.ParseExact(Convert.ToString(reader["DOB"]), "dd/MM/yyyy", null);
                    }
                    catch (Exception)
                    {
                    }
                }
                return employer;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public List<EmployerDTO> GetAll()
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetAll]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployerDTO> listEmployer = new List<EmployerDTO>();
                while (reader.Read())
                {
                    EmployerDTO employer = new EmployerDTO
                    {
                        employeeID = Convert.ToInt64(reader["EmployeeID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Password = Convert.ToString(reader["Password"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Address = Convert.ToString(reader["Address"]),
                        Email = Convert.ToString(reader["Email"]),
                        Note = Convert.ToString(reader["Note"]),
                        RoleID = Convert.ToInt64(reader["RoleID"]),
                        Position = Convert.ToString(reader["RoleName"]),
                        RightsValue = Convert.ToInt64(reader["RightsValue"]),
                        CMND = Convert.ToString(reader["CMND"]),                        
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        totalDebt = Convert.ToInt64(reader["TotalDebt"])
                    };
                    try
                    {
                        employer.Display = employer.Fullname + " (" + employer.Username + ")";
                        employer.DOB = DateTime.ParseExact(Convert.ToString(reader["DOB"]), "dd/MM/yyyy", null);
                    }
                    catch (Exception)
                    {
                    }
                    listEmployer.Add(employer);
                }
                return listEmployer;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public bool CreateEmployee(string username, string password, string fullname, string address, string email, string CMND, string DOB, long roleID, long rightsValue, int isActive, string notes, string phonenumber, long totalDebt)
        {
            var cmd = new SqlCommand("[dbo].[Employee_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Username", username));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@FullName", fullname));
                cmd.Parameters.Add(new SqlParameter("@Address", address));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Note", notes));
                cmd.Parameters.Add(new SqlParameter("@RoleID", roleID));
                cmd.Parameters.Add(new SqlParameter("@RightsValue", rightsValue));
                cmd.Parameters.Add(new SqlParameter("@CMND", CMND));
                cmd.Parameters.Add(new SqlParameter("@DOB", DOB));
                cmd.Parameters.Add(new SqlParameter("@IsActive", isActive));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", phonenumber));
                cmd.Parameters.Add(new SqlParameter("@TotalDebt", totalDebt));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }      
        }

        public bool UpdateEmployee(long employeeID, string username, string password, string fullname, string address, string email, string CMND, string DOB, long roleID, long rightsValue, int isActive, string notes, string phonenumber, long totalDebt)
        {
            var cmd = new SqlCommand("[dbo].[Employee_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                cmd.Parameters.Add(new SqlParameter("@Username", username));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@FullName", fullname));
                cmd.Parameters.Add(new SqlParameter("@Address", address));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Note", notes));
                cmd.Parameters.Add(new SqlParameter("@RoleID", roleID));
                cmd.Parameters.Add(new SqlParameter("@RightsValue", rightsValue));
                cmd.Parameters.Add(new SqlParameter("@CMND", CMND));
                cmd.Parameters.Add(new SqlParameter("@DOB", DOB));
                cmd.Parameters.Add(new SqlParameter("@IsActive", isActive));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", phonenumber));
                cmd.Parameters.Add(new SqlParameter("@TotalDebt", totalDebt));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }

        public List<EmployeeSalaryDTO> GetSalary(long empId, string fromTime, string toTime, string sortBy, string direction, long salary, long allowance, long phonecost, long payDebt, long actualIncome)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetSalary]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@empId", empId));
                cmd.Parameters.Add(new SqlParameter("@fromTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@toTime", toTime));
                cmd.Parameters.Add(new SqlParameter("@sortBy", sortBy));
                cmd.Parameters.Add(new SqlParameter("@direction", direction));
                cmd.Parameters.Add(new SqlParameter("@salary", salary));
                cmd.Parameters.Add(new SqlParameter("@allowance", allowance));
                cmd.Parameters.Add(new SqlParameter("@phonecost", phonecost));
                cmd.Parameters.Add(new SqlParameter("@payDebt", payDebt));
                cmd.Parameters.Add(new SqlParameter("@actualIncome", actualIncome));
                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployeeSalaryDTO> listSalary = new List<EmployeeSalaryDTO>();
                while (reader.Read())
                {
                    EmployeeSalaryDTO employersalary = new EmployeeSalaryDTO
                    {
                        EmployeeSalaryID = Convert.ToInt64(reader["EmployeeSalaryID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Month = Convert.ToString(reader["Month"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        Allowance = Convert.ToInt64(reader["Allowance"]),
                        PhoneCost = Convert.ToInt64(reader["PhoneCost"]),
                        DebtPay = Convert.ToInt64(reader["DebtPay"]),
                        ActualIncome = Convert.ToInt64(reader["ActualIncome"]),                        
                        CreatedDate = DateTime.Parse(Convert.ToString(reader["CreatedDate"])),
                        LastUpdate = DateTime.Parse(Convert.ToString(reader["LastUpdate"]))                        
                    };
                    bool isPay = Convert.ToBoolean(reader["IsPay"]);
                    if (isPay)
                    {
                        employersalary.IsPay = 1;
                    }
                    else
                    {
                        employersalary.IsPay = 0;
                    }
                    listSalary.Add(employersalary);
                }
                return listSalary;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public bool CreateEmployeeSalary(EmployeeSalaryDTO salary)
        {
            var cmd = new SqlCommand("[dbo].[Employee_CreateSalary]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", salary.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@Month", salary.Month));
                cmd.Parameters.Add(new SqlParameter("@Salary", salary.Salary));
                cmd.Parameters.Add(new SqlParameter("@Allowance", salary.Allowance));
                cmd.Parameters.Add(new SqlParameter("@PhoneCost", salary.PhoneCost));
                cmd.Parameters.Add(new SqlParameter("@DebtPay", salary.DebtPay));
                cmd.Parameters.Add(new SqlParameter("@ActualIncome", salary.ActualIncome));
                cmd.Parameters.Add(new SqlParameter("@isPay", salary.IsPay));
                cmd.Parameters.Add(new SqlParameter("@Note", salary.Note));                
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }      
        }

        public bool CreateEmployeeAdvance(EmployeeAdvanceDTO advanceObj)
        {
            var cmd = new SqlCommand("[dbo].[Employee_CreateAdvance]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", advanceObj.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@TotalAdvance", advanceObj.TotalAdvance));
                cmd.Parameters.Add(new SqlParameter("@Reason", advanceObj.Reason));
                cmd.Parameters.Add(new SqlParameter("@Note", advanceObj.Note));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }  
        }

        public List<EmployeeAdvanceDTO> GetAllAdvance()
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetAdvance]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                var listAdvance = new List<EmployeeAdvanceDTO>();
                while (reader.Read())
                {
                    var advance = new EmployeeAdvanceDTO
                    {
                        AdvanceID = Convert.ToInt64(reader["AdvanceID"]),
                        EmployeeID = Convert.ToInt64(reader["EmployeeID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        TotalAdvance = Convert.ToInt64(reader["TotalAdvance"]),
                        Reason = Convert.ToString(reader["Reason"]),
                        Note = Convert.ToString(reader["Note"]),
                    };
                    try
                    {
                        advance.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                        advance.LastUpdate = Convert.ToDateTime(reader["LastUpdate"]);
                    }
                    catch (Exception)
                    {
                    }
                    listAdvance.Add(advance);
                }
                return listAdvance;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public List<EmployeeSalaryDTO> GetAllSalary()
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetAllSalary]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {                
                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployeeSalaryDTO> listSalary = new List<EmployeeSalaryDTO>();
                while (reader.Read())
                {
                    EmployeeSalaryDTO employersalary = new EmployeeSalaryDTO
                    {
                        EmployeeSalaryID = Convert.ToInt64(reader["EmployeeSalaryID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Month = Convert.ToString(reader["Month"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        Allowance = Convert.ToInt64(reader["Allowance"]),
                        PhoneCost = Convert.ToInt64(reader["PhoneCost"]),
                        DebtPay = Convert.ToInt64(reader["DebtPay"]),
                        ActualIncome = Convert.ToInt64(reader["ActualIncome"]),
                        CreatedDate = DateTime.Parse(Convert.ToString(reader["CreatedDate"])),
                        LastUpdate = DateTime.Parse(Convert.ToString(reader["LastUpdate"]))
                    };
                    bool isPay = Convert.ToBoolean(reader["IsPay"]);
                    if (isPay)
                    {
                        employersalary.IsPay = 1;
                    }
                    else
                    {
                        employersalary.IsPay = 0;
                    }
                    listSalary.Add(employersalary);
                }
                return listSalary;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }
    }
}
