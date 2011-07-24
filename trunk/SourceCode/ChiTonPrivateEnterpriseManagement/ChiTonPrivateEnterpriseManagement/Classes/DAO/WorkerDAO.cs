using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.DAO
{
    class WorkerDAO
    {
     
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
        public List<WorkerTempDTO> LoadAllWks(long id)
        {
            var cmd = new SqlCommand("[dbo].[Worker_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@workersSalaryID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkerTempDTO> listcons = new List<WorkerTempDTO>();
                while (reader.Read())
                {
                    WorkerTempDTO dto = new WorkerTempDTO
                    {
                        WorkerID = Convert.ToInt64(reader["WorkerID"]),
                        WorkersSalaryID = Convert.ToInt64(reader["WorkersSalaryID"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        ManDate = Convert.ToDouble(reader["ManDate"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        TotalSalary = Convert.ToInt64(reader["TotalSalary"]),
                        Position = Convert.ToString(reader["Position"]),
                        CreatedBy =Convert.ToString(reader["CreatedBy"]),
                        CreatedDate =Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedBy =  Convert.ToString(reader["UpdatedBy"]) ,
                       
                    };
                    try
                    {
                        dto.LastUpdated = Convert.ToDateTime(reader["LastUpdated"]);
                        dto.LastUpdatedFormated = dto.LastUpdated.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    }
                    catch
                    {
                        dto.LastUpdatedFormated = "";
                    }
                    dto.CreatedDateFormated = dto.CreatedDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.SalaryFormated = Global.Global.ConvertLongToMoney(dto.Salary, Global.Global.SEP);
                    dto.TotalSalaryFormated = Global.Global.ConvertLongToMoney(dto.TotalSalary, Global.Global.SEP); 
                    listcons.Add(dto);
                }
                return listcons;
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

        public List<DayWorkingDTO> LoadAllDaysWorking(long id)
        {
            var cmd = new SqlCommand("[dbo].[DayWorking_getall]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@WorkerID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<DayWorkingDTO> listcons = new List<DayWorkingDTO>();
                while (reader.Read())
                {
                    DayWorkingDTO dto = new DayWorkingDTO
                    {
                        WorkerID = Convert.ToInt64(reader["WorkerID"]),
                        Date = Convert.ToDateTime(reader["Date"]),
                        Value = Convert.ToDouble(reader["Value"]),

                    };
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    listcons.Add(dto);
                }
                return listcons;
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

        public WorkerTempDTO LoadWorkerByID(long id)
        {
            var cmd = new SqlCommand("[dbo].[Worker_GetByID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@WorkerID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    WorkerTempDTO dto = new WorkerTempDTO
                    {
                        WorkerID = Convert.ToInt64(reader["WorkerID"]),
                        WorkersSalaryID = Convert.ToInt64(reader["WorkersSalaryID"]),
                        Fullname = Convert.ToString(reader["FullName"]),
                        ManDate = Convert.ToDouble(reader["ManDate"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        TotalSalary = Convert.ToInt64(reader["TotalSalary"]),
                        Position = Convert.ToString(reader["Position"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"]),

                    };
                    try
                    {
                        dto.LastUpdated = Convert.ToDateTime(reader["LastUpdated"]);
                        dto.LastUpdatedFormated = dto.LastUpdated.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    }
                    catch
                    {
                        dto.LastUpdatedFormated = "";
                    }
                    dto.CreatedDateFormated = dto.CreatedDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.SalaryFormated = Global.Global.ConvertLongToMoney(dto.Salary, Global.Global.SEP);
                    dto.TotalSalaryFormated = Global.Global.ConvertLongToMoney(dto.TotalSalary, Global.Global.SEP);
                   return dto;
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

        public long CreateWks(WorkerTempDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Worker_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@workersSalaryID", dto.WorkersSalaryID));
                cmd.Parameters.Add(new SqlParameter("@fullName", dto.Fullname));
                cmd.Parameters.Add(new SqlParameter("@ManDate", dto.ManDate));
                cmd.Parameters.Add(new SqlParameter("@salary", dto.Salary));
                cmd.Parameters.Add(new SqlParameter("@totalSalary", dto.TotalSalary));
                cmd.Parameters.Add(new SqlParameter("@position", dto.Position));
                cmd.Parameters.Add(new SqlParameter("@createdBy", Global.Global.CurrentUser.Username));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return Convert.ToInt64(reader[0]);
                return 0;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return 0;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }


        public bool CreateDayWorking(DayWorkingDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[DayWorking_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WorkerID", dto.WorkerID));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@Value", dto.Value));
               
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }

        public bool updateWks(WorkerTempDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Worker_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {

                cmd.Parameters.Add(new SqlParameter("@WorkerID", dto.WorkerID));
                cmd.Parameters.Add(new SqlParameter("@FullName", dto.Fullname));
                cmd.Parameters.Add(new SqlParameter("@ManDate", dto.ManDate));
                cmd.Parameters.Add(new SqlParameter("@Salary", dto.Salary));
                cmd.Parameters.Add(new SqlParameter("@TotalSalary", dto.TotalSalary));
                cmd.Parameters.Add(new SqlParameter("@Position", dto.Position));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", Global.Global.CurrentUser.Username));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }
        public bool delete(long id)
        {
            var cmd = new SqlCommand("[dbo].[Worker_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WorkerID", id));
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

    }
}
