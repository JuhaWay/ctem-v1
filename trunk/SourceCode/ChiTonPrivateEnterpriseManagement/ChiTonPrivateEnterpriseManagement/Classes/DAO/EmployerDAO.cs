using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
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
            try
            {
                var cmd = new SqlCommand("[dbo].[Employer_GetByUsername]", Connection);

                if (Transaction != null)
                {
                    cmd.Transaction = Transaction;
                }
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.CommandType = CommandType.StoredProcedure;
            
                SqlDataReader reader = cmd.ExecuteReader();
                EmployerDTO employer = null;
                if (reader.Read())
                {
                    employer = new EmployerDTO
                    {
                        employeeID = Convert.ToInt64(reader["EmployeeID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Password = Convert.ToString(reader["Password"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        RoleID = Convert.ToInt64(reader["RoleID"]),
                        Position = Convert.ToString(reader["RoleName"]),
                        RightsValue = Convert.ToInt64(reader["RightsValue"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        totalDebt = Convert.ToInt64(reader["TotalDebt"])
                    };
                    try
                    {
                        employer.CMND = Convert.ToString(reader["CMND"]);
                        employer.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                        employer.Address = Convert.ToString(reader["Address"]);
                        employer.Email = Convert.ToString(reader["Email"]);
                        employer.Note = Convert.ToString(reader["Note"]);
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
                cmd.Parameters.Add(new SqlParameter("@SalaryPC", salary.Salarypc));
                cmd.Parameters.Add(new SqlParameter("@TotalAllowance", salary.TotalAllowance));
                cmd.Parameters.Add(new SqlParameter("@DebtPay", salary.DebtPay));
                cmd.Parameters.Add(new SqlParameter("@Debt1", salary.Debt1));
                cmd.Parameters.Add(new SqlParameter("@Debt2", salary.Debt2));
                cmd.Parameters.Add(new SqlParameter("@TotalAdvanceSalary", salary.Debt2));
                cmd.Parameters.Add(new SqlParameter("@ActualIncome", salary.ActualIncome));
                cmd.Parameters.Add(new SqlParameter("@GenDebt", salary.GenDebt));
                cmd.Parameters.Add(new SqlParameter("@DateReceive", salary.DateReceive));
                cmd.Parameters.Add(new SqlParameter("@isPay", salary.IsPay));
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
                cmd.Parameters.Add(new SqlParameter("@DateAdvance", advanceObj.DateAdvance));
                cmd.Parameters.Add(new SqlParameter("@TotalAdvance", advanceObj.TotalAdvance));
                cmd.Parameters.Add(new SqlParameter("@Reason", advanceObj.Reason));
                cmd.Parameters.Add(new SqlParameter("@Note", advanceObj.Note));
                cmd.Parameters.Add(new SqlParameter("@Type", advanceObj.Type));
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

        public List<EmployeeAdvanceDTO> GetAdvance(string name, DateTime fromdate, DateTime todate, string type)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetAdvance]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Name", name));
                cmd.Parameters.Add(new SqlParameter("@FromDate", fromdate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", todate.AddDays(1)));
                cmd.Parameters.Add(new SqlParameter("@Type", type));
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
                        advance.TotalAdvanceFormated = Global.Global.ConvertLongToMoney(advance.TotalAdvance, Constants.SPLIP_MONEY);
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

        public List<EmployeeSalaryDTO> GetSalary(string name, string from, string to)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetSalary]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@from", from));
                cmd.Parameters.Add(new SqlParameter("@to", to));
                SqlDataReader reader = cmd.ExecuteReader();
                var listSalary = new List<EmployeeSalaryDTO>();
                while (reader.Read())
                {
                    var employersalary = new EmployeeSalaryDTO
                    {
                        EmployeeSalaryID = Convert.ToInt64(reader["EmployeeSalaryID"]),
                        EmployeeID = Convert.ToInt64(reader["EmployeeID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Month = Convert.ToString(reader["Month"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        Salarypc = Convert.ToInt64(reader["SalaryPC"]),
                        TotalAllowance = Convert.ToInt64(reader["TotalAllowance"]),
                        DebtPay = reader["DebtPay"] != DBNull.Value ? Convert.ToInt64(reader["DebtPay"]) : 0,
                        Debt1 = reader["Debt1"] != DBNull.Value ? Convert.ToInt64(reader["Debt1"]) : 0,
                        Debt2 = reader["Debt2"] != DBNull.Value ? Convert.ToInt64(reader["Debt2"]) : 0,
                        TotalAdvanceSalary = reader["TotalAdvanceSalary"] != DBNull.Value ? Convert.ToInt64(reader["TotalAdvanceSalary"]) : 0,
                        ActualIncome = Convert.ToInt64(reader["ActualIncome"]),
                        GenDebt = reader["GenerateDebt"] != DBNull.Value ? Convert.ToInt64(reader["GenerateDebt"]) : 0,
                        DateReceive = reader["DateReceive"] != DBNull.Value ? Convert.ToDateTime(reader["DateReceive"]) : DateTime.Today,
                        IsPay = Convert.ToBoolean(reader["IsPay"])
                    };
                    DateTime month = DateTime.ParseExact(employersalary.Month + "01 00:00:00", "yyyyMMdd hh:mm:ss", null);
                    employersalary.MonthFormat = month.ToString("MM/yyyy");
                    employersalary.SalaryFormat = Global.Global.ConvertLongToMoney(employersalary.Salary, Constants.SPLIP_MONEY);
                    employersalary.SalarypcFormat = Global.Global.ConvertLongToMoney(employersalary.Salarypc, Constants.SPLIP_MONEY);
                    employersalary.TotalAllowanceFormat = Global.Global.ConvertLongToMoney(employersalary.TotalAllowance, Constants.SPLIP_MONEY);
                    employersalary.DebtPayFormat = Global.Global.ConvertLongToMoney(employersalary.DebtPay, Constants.SPLIP_MONEY);
                    employersalary.Debt1Format = Global.Global.ConvertLongToMoney(employersalary.Debt1, Constants.SPLIP_MONEY);
                    employersalary.Debt2Format = Global.Global.ConvertLongToMoney(employersalary.Debt2, Constants.SPLIP_MONEY);
                    employersalary.TotalAdvanceSalaryFormat = Global.Global.ConvertLongToMoney(employersalary.TotalAdvanceSalary, Constants.SPLIP_MONEY);
                    employersalary.ActualIncomeFormat = Global.Global.ConvertLongToMoney(employersalary.ActualIncome, Constants.SPLIP_MONEY);
                    employersalary.GenDebtFormat = Global.Global.ConvertLongToMoney(employersalary.GenDebt, Constants.SPLIP_MONEY);
                    employersalary.DateReceiveFormat = employersalary.DateReceive.ToString("dd/MM/yyyy");
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

        public List<EmployerDTO> GetAllEmp()
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetAllWithoutAdmin]", Connection);
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

        public bool UpdateAdvance(EmployeeAdvanceDTO advanceObj)
        {
            var cmd = new SqlCommand("[dbo].[Employee_UpdateAdvance]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@AdvanceId", advanceObj.AdvanceID));
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", advanceObj.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@TotalAdvance", advanceObj.TotalAdvance));
                cmd.Parameters.Add(new SqlParameter("@DateAdvance", advanceObj.DateAdvance));
                cmd.Parameters.Add(new SqlParameter("@Reason", advanceObj.Reason));
                cmd.Parameters.Add(new SqlParameter("@Note", advanceObj.Note));
                cmd.Parameters.Add(new SqlParameter("@Type", advanceObj.Type));
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

        public bool DeleteAdvance(long id)
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteAdvance]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@AdvanceId", id));
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

        public bool DeleteAllAdvance()
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteAllAdvance]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
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

        public List<EmployerDTO> LoadEmployee(string username, string fullname, string roleName, int status)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetEmployee]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@fullname", fullname));
                cmd.Parameters.Add(new SqlParameter("@roleName", roleName));
                cmd.Parameters.Add(new SqlParameter("@status", status));
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

        public bool DeleteEmp(string username)
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteEmp]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Username", username));
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

        public bool DeleteAllEmp()
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteAllEmp]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
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

        public bool UpdateRightEmp(long Id, long roleId, long rightValue)
        {
            var cmd = new SqlCommand("[dbo].[Employee_UpdateRight]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", Id));
                cmd.Parameters.Add(new SqlParameter("@RoleID", roleId));
                cmd.Parameters.Add(new SqlParameter("@RightsValue", rightValue));
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

        public bool DeleteAllSalary()
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteAllAdvance]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
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

        public bool DeleteSalary(long salaryId)
        {
            var cmd = new SqlCommand("[dbo].[Employee_DeleteSalary]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@SalaryId", salaryId));
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

        public bool UpdateSalary(EmployeeSalaryDTO salary)
        {
            var cmd = new SqlCommand("[dbo].[Employee_UpdateSalary]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@SalaryID", salary.EmployeeSalaryID));
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", salary.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@Month", salary.Month));
                cmd.Parameters.Add(new SqlParameter("@Salary", salary.Salary));
                cmd.Parameters.Add(new SqlParameter("@SalaryPC", salary.Salarypc));
                cmd.Parameters.Add(new SqlParameter("@TotalAllowance", salary.TotalAllowance));
                cmd.Parameters.Add(new SqlParameter("@DebtPay", salary.DebtPay));
                cmd.Parameters.Add(new SqlParameter("@Debt1", salary.Debt1));
                cmd.Parameters.Add(new SqlParameter("@Debt2", salary.Debt2));
                cmd.Parameters.Add(new SqlParameter("@TotalAdvanceSalary", salary.Debt2));
                cmd.Parameters.Add(new SqlParameter("@ActualIncome", salary.ActualIncome));
                cmd.Parameters.Add(new SqlParameter("@GenDebt", salary.GenDebt));
                cmd.Parameters.Add(new SqlParameter("@DateReceive", salary.DateReceive));
                cmd.Parameters.Add(new SqlParameter("@isPay", salary.IsPay));
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

        public bool ResetPassword(long empid, string pass)
        {
            var cmd = new SqlCommand("[dbo].[Employee_ResetPass]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", empid));
                cmd.Parameters.Add(new SqlParameter("@Password", pass));
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

        public long GetTotalAllowance(string emp, DateTime from, DateTime to, string type)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetTotal]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Name", emp));
                cmd.Parameters.Add(new SqlParameter("@FromDate", from));
                cmd.Parameters.Add(new SqlParameter("@ToDate", to));
                cmd.Parameters.Add(new SqlParameter("@Type", type));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["Total"] != DBNull.Value ? Convert.ToInt64(reader["Total"]) : 0;
                }
                return 0;
            }
            catch (SqlException sql)
            {
                return 0;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }      
        }

        public EmployeeSalaryDTO GetSalaryById(long salaryId)
        {
            var cmd = new SqlCommand("[dbo].[Employee_GetSalaryById]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Id", salaryId));
                SqlDataReader reader = cmd.ExecuteReader();                
                if (reader.Read())
                {
                    var employersalary = new EmployeeSalaryDTO
                    {
                        EmployeeSalaryID = Convert.ToInt64(reader["EmployeeSalaryID"]),
                        EmployeeID = Convert.ToInt64(reader["EmployeeID"]),
                        Username = Convert.ToString(reader["Username"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        Month = Convert.ToString(reader["Month"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        Salarypc = Convert.ToInt64(reader["SalaryPC"]),
                        TotalAllowance = Convert.ToInt64(reader["TotalAllowance"]),
                        DebtPay = reader["DebtPay"] != DBNull.Value ? Convert.ToInt64(reader["DebtPay"]) : 0,
                        Debt1 = reader["Debt1"] != DBNull.Value ? Convert.ToInt64(reader["Debt1"]) : 0,
                        Debt2 = reader["Debt2"] != DBNull.Value ? Convert.ToInt64(reader["Debt2"]) : 0,
                        TotalAdvanceSalary = reader["TotalAdvanceSalary"] != DBNull.Value ? Convert.ToInt64(reader["TotalAdvanceSalary"]) : 0,
                        ActualIncome = Convert.ToInt64(reader["ActualIncome"]),
                        GenDebt = reader["GenerateDebt"] != DBNull.Value ? Convert.ToInt64(reader["GenerateDebt"]) : 0,
                        DateReceive = reader["DateReceive"] != DBNull.Value ? Convert.ToDateTime(reader["DateReceive"]) : DateTime.Today,
                        IsPay = Convert.ToBoolean(reader["IsPay"])
                    };
                    DateTime month = DateTime.ParseExact(employersalary.Month + "01 00:00:00", "yyyyMMdd hh:mm:ss", null);
                    employersalary.MonthFormat = month.ToString("MM/yyyy");
                    employersalary.SalaryFormat = Global.Global.ConvertLongToMoney(employersalary.Salary, Constants.SPLIP_MONEY);
                    employersalary.SalarypcFormat = Global.Global.ConvertLongToMoney(employersalary.Salarypc, Constants.SPLIP_MONEY);
                    employersalary.TotalAdvanceSalaryFormat = Global.Global.ConvertLongToMoney(employersalary.TotalAllowance, Constants.SPLIP_MONEY);
                    employersalary.DebtPayFormat = Global.Global.ConvertLongToMoney(employersalary.DebtPay, Constants.SPLIP_MONEY);
                    employersalary.Debt1Format = Global.Global.ConvertLongToMoney(employersalary.Debt1, Constants.SPLIP_MONEY);
                    employersalary.Debt2Format = Global.Global.ConvertLongToMoney(employersalary.Debt2, Constants.SPLIP_MONEY);
                    employersalary.TotalAdvanceSalaryFormat = Global.Global.ConvertLongToMoney(employersalary.TotalAdvanceSalary, Constants.SPLIP_MONEY);
                    employersalary.ActualIncomeFormat = Global.Global.ConvertLongToMoney(employersalary.ActualIncome, Constants.SPLIP_MONEY);
                    employersalary.GenDebtFormat = Global.Global.ConvertLongToMoney(employersalary.GenDebt, Constants.SPLIP_MONEY);
                    employersalary.DateReceiveFormat = employersalary.DateReceive.ToString("dd/MM/yyyy");
                    return employersalary;
                }
                return null;
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
