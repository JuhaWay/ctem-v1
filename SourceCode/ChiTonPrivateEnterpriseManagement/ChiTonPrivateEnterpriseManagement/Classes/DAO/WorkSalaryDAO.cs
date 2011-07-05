using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.Classes.DAO
{
    class WorkSalaryDAO
    {
        public WorkSalaryDAO()
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
        public List<WorkerSalaryDTO> LoadAllWks()
        {
            var cmd = new SqlCommand("[dbo].[WorkerSalary_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkerSalaryDTO> listcons = new List<WorkerSalaryDTO>();
                while (reader.Read())
                {
                    WorkerSalaryDTO dto = new WorkerSalaryDTO
                    {
                        WorkersSalaryID = Convert.ToInt64(reader["WorkersSalaryID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Name = Convert.ToString(reader["Name"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        FromDate = Convert.ToDateTime(reader["FromDate"]),
                        ToDate = Convert.ToDateTime(reader["ToDate"]),
                        TotalSalary = Convert.ToInt64(reader["TotalSalary"]),
                        CreatedBy = reader["CreatedBy"] != DBNull.Value ? Convert.ToString(reader["CreatedBy"]) : "",
                        CreateDate = reader["CreateDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreateDate"]) : new DateTime(),
                        UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? Convert.ToString(reader["UpdatedBy"]) : "",
                        LastUpdate = reader["LastUpdate"] != DBNull.Value ? Convert.ToDateTime(reader["LastUpdate"]) : new DateTime()
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


        public bool CreateWks(WorkerSalaryDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[WorkerSalary_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@fromDate", dto.FromDate));
                cmd.Parameters.Add(new SqlParameter("@toDate", dto.ToDate));
                cmd.Parameters.Add(new SqlParameter("@totalSalary", dto.TotalSalary));
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

        public bool UpdateWks(WorkerSalaryDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[WorkerSalary_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@workersSalaryID", dto.WorkersSalaryID));
                cmd.Parameters.Add(new SqlParameter("@constructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@fromDate", dto.FromDate));
                cmd.Parameters.Add(new SqlParameter("@toDate", dto.ToDate));
                cmd.Parameters.Add(new SqlParameter("@totalSalary", dto.TotalSalary));
                cmd.Parameters.Add(new SqlParameter("@updatedBy", Global.Global.CurrentUser.Username));
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
        public bool UpdateTotalSalary(long id)
        {
            var cmd = new SqlCommand("[dbo].[WorkerSalary_UpdateTotalSalary]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@workersSalaryID", id));
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
            var cmd = new SqlCommand("[dbo].[WorkersSalary_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@workersSalaryID", id));
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

    }
}
