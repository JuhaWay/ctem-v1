using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.DAO
{
    class DebtDAO
    {
        public DebtDAO()
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

        public bool DeleteDebt(long debtId)
        {
            var cmd = new SqlCommand("[dbo].[Debt_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtID", debtId));

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

        public bool CreateDebt(DebtDTO debt)
        {
            var cmd = new SqlCommand("[dbo].[Debt_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtName", debt.DebtName));
                cmd.Parameters.Add(new SqlParameter("@TotalOwe", debt.TotalOwe));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", debt.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@Note", debt.Note));
                cmd.Parameters.Add(new SqlParameter("@Address", debt.Address));
                cmd.Parameters.Add(new SqlParameter("@IsActive", debt.IsActive));
                cmd.Parameters.Add(new SqlParameter("@CreatedBy", Global.Global.CurrentUser.Username));
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

        public bool UpdateDebt(DebtDTO debt)
        {
            var cmd = new SqlCommand("[dbo].[Debt_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtID", debt.DebtID));
                cmd.Parameters.Add(new SqlParameter("@DebtName", debt.DebtName));
                cmd.Parameters.Add(new SqlParameter("@Address", debt.Address));
                cmd.Parameters.Add(new SqlParameter("@TotalOwe", debt.TotalOwe));
                cmd.Parameters.Add(new SqlParameter("@IsActive", debt.IsActive));
                cmd.Parameters.Add(new SqlParameter("@Note", debt.Note));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", debt.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", Global.Global.CurrentUser.Username));
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

        public bool DeleteAll()
        {
            var cmd = new SqlCommand("[dbo].[Debt_DeleteAll]", Connection) { CommandType = CommandType.StoredProcedure };
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

        public List<DebtDTO> GetDebt(long id, string name, int status)
        {
            var cmd = new SqlCommand("[dbo].[Debt_GetDebt]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtID", id));
                cmd.Parameters.Add(new SqlParameter("@DebtName", name));
                cmd.Parameters.Add(new SqlParameter("@Status", status));
                SqlDataReader reader = cmd.ExecuteReader();
                List<DebtDTO> listDebts = new List<DebtDTO>();
                while (reader.Read())
                {
                    DebtDTO debt = new DebtDTO
                    {
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        Address = Convert.ToString(reader["Address"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        TotalOwe = Convert.ToInt64(reader["TotalOwe"]),
                        Note = Convert.ToString(reader["Note"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"]),
                        LastUpdated = Convert.ToDateTime(reader["UpdatedDate"])
                    };
                    debt.TotalOweFomated = Global.Global.ConvertLongToMoney(debt.TotalOwe, ".");
                    if (Convert.ToBoolean(reader["IsActive"]))
                    {
                        debt.IsActive = 1;
                    }
                    else
                    {
                        debt.IsActive = 0;
                    }
                    listDebts.Add(debt);
                }
                return listDebts;
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

        public List<CompareDebtDTO> GetCompareDebt(string name, DateTime fromdate, DateTime todate)
        {
            var cmd = new SqlCommand("[dbo].[Debt_GetCompare]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtName", name));
                cmd.Parameters.Add(new SqlParameter("@FromDate", fromdate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", todate));
                SqlDataReader reader = cmd.ExecuteReader();
                var listComDebts = new List<CompareDebtDTO>();
                while (reader.Read())
                {                    
                    var debt = new CompareDebtDTO
                    {
                        ComparationDebtID = Convert.ToInt64(reader["ComparationDebtID"]),
                        RepresentationDebtName = Convert.ToString(reader["RepresentationDebtName"]),
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        TotalOwe = Convert.ToInt64(reader["TotalOwe"]),                        
                        DateCompare = Convert.ToDateTime(reader["DateCompare"]),
                        FromDate = Convert.ToDateTime(reader["FromDate"]),
                        ToDate = Convert.ToDateTime(reader["ToDate"]),
                        Note = Convert.ToString(reader["Note"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
                    };
                    debt.TotalOweFormat = Global.Global.ConvertLongToMoney(debt.TotalOwe, ".");
                    debt.DateCompareFormated = debt.DateCompare.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    debt.FromDateFormated = debt.FromDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    debt.ToDateFormated = debt.ToDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    listComDebts.Add(debt);
                }
                return listComDebts;
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

        public bool CreateCompareDebt(CompareDebtDTO CompareDebt)
        {
            var cmd = new SqlCommand("[dbo].[Debt_CreateCompare]", Connection)
                          {CommandType = CommandType.StoredProcedure};
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DebtID", CompareDebt.DebtID));
                cmd.Parameters.Add(new SqlParameter("@RepresentationDebtName", CompareDebt.RepresentationDebtName));
                cmd.Parameters.Add(new SqlParameter("@DateCompare", CompareDebt.DateCompare));
                cmd.Parameters.Add(new SqlParameter("@FromDate", CompareDebt.FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", CompareDebt.ToDate));
                cmd.Parameters.Add(new SqlParameter("@TotalOwe", CompareDebt.TotalOwe));
                cmd.Parameters.Add(new SqlParameter("@Note", CompareDebt.Note));
                cmd.Parameters.Add(new SqlParameter("@CreatedBy", Global.Global.CurrentUser.Username));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }

        public bool DeleteAllCompare()
        {
            var cmd = new SqlCommand("[dbo].[Debt_DeleteAllCompare]", Connection) { CommandType = CommandType.StoredProcedure };
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

        public bool UpdateCompare(CompareDebtDTO compareDebtDto)
        {
            var cmd = new SqlCommand("[dbo].[Debt_UpdateCompare]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@CompareDebtId", compareDebtDto.ComparationDebtID));
                cmd.Parameters.Add(new SqlParameter("@DebtID", compareDebtDto.DebtID));
                cmd.Parameters.Add(new SqlParameter("@RepresentationDebtName", compareDebtDto.RepresentationDebtName));
                cmd.Parameters.Add(new SqlParameter("@DateCompare", compareDebtDto.DateCompare));
                cmd.Parameters.Add(new SqlParameter("@FromDate", compareDebtDto.FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", compareDebtDto.ToDate));
                cmd.Parameters.Add(new SqlParameter("@TotalOwe", compareDebtDto.TotalOwe));
                cmd.Parameters.Add(new SqlParameter("@Note", compareDebtDto.Note));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", Global.Global.CurrentUser.Username));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }

        public bool DeleteCompare(long id)
        {
            var cmd = new SqlCommand("[dbo].[Debt_DeleteCompare]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Id", id));
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