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

        public List<DebtDTO> GetAllDebt()
        {
            var cmd = new SqlCommand("[dbo].[Debt_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<DebtDTO> listDebts = new List<DebtDTO>();
                while (reader.Read())
                {
                    DebtDTO debt = new DebtDTO
                    {
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        Address = Convert.ToString(reader["Description"]),
                        PhoneNumber = Convert.ToString(reader["Description"]),
                        TotalOwe = Convert.ToInt64(reader["RightsValue"]),
                    };
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
        
        //public bool DeleteDebt(long DebtID)
        //{
        //    var cmd = new SqlCommand("[dbo].[Debt_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    try
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@DebtID", DebtID));

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
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", debt.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@Note", debt.Note));
                cmd.Parameters.Add(new SqlParameter("@Address", debt.Address));
                cmd.Parameters.Add(new SqlParameter("@IsActive", debt.IsActive));
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

        //public bool UpdateDebt(long DebtID, string DebtName, string description, long rightsValue, bool isActive)
        //{
        //    var cmd = new SqlCommand("[dbo].[Debt_Update]", Connection) { CommandType = CommandType.StoredProcedure };
        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    try
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@DebtID", DebtID));
        //        cmd.Parameters.Add(new SqlParameter("@DebtName", DebtName));
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
