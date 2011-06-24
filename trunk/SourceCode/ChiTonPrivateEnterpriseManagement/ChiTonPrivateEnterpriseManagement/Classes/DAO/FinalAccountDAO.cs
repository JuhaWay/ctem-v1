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
    class FinalAccountDAO
    {
        public FinalAccountDAO()
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

        public List<FinalAccountDTO> GetAll()
        {
            var cmd = new SqlCommand("[dbo].[FinalAccount_GetAll]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<FinalAccountDTO> listFinalAccount = new List<FinalAccountDTO>();
                while (reader.Read())
                {
                    FinalAccountDTO finalAccount = new FinalAccountDTO
                    {
                        FinalAccountID = Convert.ToInt64(reader["FinalAccountID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        DateAccount = DateTime.Parse(Convert.ToString(reader["DateAccount"])),
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        TransportationCost = Convert.ToInt64(reader["TransportationCost"]),
                        TotalCost = Convert.ToInt64(reader["TotalCost"]),
                        //ComparationDebtID = Convert.ToInt64(reader["ComparationDebtID"]),
                        PersonAccount = Convert.ToString(reader["PersonAccount"]),
                        //CreatedDate = DateTime.Parse(Convert.ToString(reader["CreatedDate"])),
                        //LastUpdated = DateTime.Parse(Convert.ToString(reader["LastUpdated"])),
                        //CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        //UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                    };
                    try
                    {
                        bool ispay = Convert.ToBoolean(reader["IsPay"]);
                        if (ispay)
                        {
                            finalAccount.IsPay = 1;
                        }
                        else
                        {
                            finalAccount.IsPay = 0;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    listFinalAccount.Add(finalAccount);
                }
                return listFinalAccount;
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

        public bool CreateFinalAccount(FinalAccountDTO finalAccount)
        {
            var cmd = new SqlCommand("[dbo].[FinalAccount_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@FinalAccountID", finalAccount.FinalAccountID));
                cmd.Parameters.Add(new SqlParameter("@FinalAccountName", finalAccount.FinalAccountName));
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", finalAccount.ConstructionID));                
                cmd.Parameters.Add(new SqlParameter("@DateAccount", finalAccount.DateAccount));
                cmd.Parameters.Add(new SqlParameter("@DebtID", finalAccount.DebtID));
                cmd.Parameters.Add(new SqlParameter("@TransportationCost", finalAccount.TransportationCost));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", finalAccount.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@PersonAccount", finalAccount.PersonAccount));
                cmd.Parameters.Add(new SqlParameter("@CreatedBy", finalAccount.CreatedBy));
                cmd.Parameters.Add(new SqlParameter("@IsPay", finalAccount.IsPay));
                cmd.Parameters.Add(new SqlParameter("@Note", finalAccount.Note));
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

        public bool CreateFinalAccountDetail(FinalAccountDetailDTO finalaccountdetail)
        {
            var cmd = new SqlCommand("[dbo].[FinalAccountDetail_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@FinalAccountID", finalaccountdetail.FinalAccountID));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", finalaccountdetail.MaterialID));
                cmd.Parameters.Add(new SqlParameter("@Quantity", finalaccountdetail.Quantity));
                cmd.Parameters.Add(new SqlParameter("@UnitCost", finalaccountdetail.UnitCost));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", finalaccountdetail.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@Note", finalaccountdetail.Note));
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
