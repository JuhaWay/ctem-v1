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
    class CompareDebtDAO
    {
        public CompareDebtDAO()
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

        public List<CompareDebtDTO> GetAllCompareDebt()
        {
            var cmd = new SqlCommand("[dbo].[CompareDebt_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompareDebtDTO> listCompareDebts = new List<CompareDebtDTO>();
                while (reader.Read())
                {
                    CompareDebtDTO CompareDebt = new CompareDebtDTO
                    {
                        ComparationDebtID = Convert.ToInt64(reader["ComparationDebtID"]),
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        DateCompare = DateTime.Parse(Convert.ToString(reader["DateCompare"])),
                        FromDate = DateTime.Parse(Convert.ToString(reader["FromDate"])),
                        ToDate = DateTime.Parse(Convert.ToString(reader["ToDate"])),
                        TotalOwe = Convert.ToInt64(reader["TotalOwe"]),
                        Note = Convert.ToString(reader["Note"])
                    };                    
                    listCompareDebts.Add(CompareDebt);
                }
                return listCompareDebts;
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
        
        //public bool DeleteCompareDebt(long CompareDebtID)
        //{
        //    var cmd = new SqlCommand("[dbo].[CompareDebt_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    try
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@CompareDebtID", CompareDebtID));

        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (SqlException sql)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (Transaction == null)
        //            Connection.Close();
        //    }
        //}

        public bool CreateCompareDebt(CompareDebtDTO CompareDebt)
        {
            var cmd = new SqlCommand("[dbo].[CompareDebt_Create]", Connection) { CommandType = CommandType.StoredProcedure };
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

        //public bool UpdateCompareDebt(long CompareDebtID, string CompareDebtName, string description, long rightsValue, bool isActive)
        //{
        //    var cmd = new SqlCommand("[dbo].[CompareDebt_Update]", Connection) { CommandType = CommandType.StoredProcedure };
        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    try
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@CompareDebtID", CompareDebtID));
        //        cmd.Parameters.Add(new SqlParameter("@CompareDebtName", CompareDebtName));
        //        cmd.Parameters.Add(new SqlParameter("@description", description));
        //        cmd.Parameters.Add(new SqlParameter("@rightsValue", rightsValue));
        //        cmd.Parameters.Add(new SqlParameter("@isActive", isActive));

        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (SqlException sql)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (Transaction == null)
        //            Connection.Close();
        //    }
        //}
    }
}
