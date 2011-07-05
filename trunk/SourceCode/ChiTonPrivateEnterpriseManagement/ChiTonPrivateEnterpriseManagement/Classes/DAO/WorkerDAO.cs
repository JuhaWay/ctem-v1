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
                        ManDate = Convert.ToInt32(reader["ManDate"]),
                        Salary = Convert.ToInt64(reader["Salary"]),
                        TotalSalary = Convert.ToInt64(reader["TotalSalary"]),
                        Position = Convert.ToString(reader["Position"]),
                         CreatedBy = reader["CreatedBy"] != DBNull.Value ? Convert.ToString(reader["CreatedBy"]) : "",
                        CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : new DateTime(),
                        UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? Convert.ToString(reader["UpdatedBy"]) : "",
                        LastUpdated = reader["LastUpdated"] != DBNull.Value ? Convert.ToDateTime(reader["LastUpdated"]) : new DateTime()
                    };
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

        public bool CreateWks(WorkerTempDTO dto)
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
