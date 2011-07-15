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

        public bool CreateFinalAccountDetail(FinalAccountDetailDTO finalaccountdetail)
        {
            var cmd = new SqlCommand("[dbo].[FinalAccount_CreateDetail]", Connection) { CommandType = CommandType.StoredProcedure };
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

        public List<FinalAccountDTO> GetFinalAccount(long id, string name, string consName, string debtName, DateTime fromdate, DateTime todate)
        {
            var cmd = new SqlCommand("[dbo].[FinalAccount_GetFinalAccount]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                cmd.Parameters.Add(new SqlParameter("@Name", name));
                cmd.Parameters.Add(new SqlParameter("@ConsName", consName));
                cmd.Parameters.Add(new SqlParameter("@DebtName", debtName));
                cmd.Parameters.Add(new SqlParameter("@FromDate", fromdate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", todate.AddDays(1)));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                var listFinalAccount = new List<FinalAccountDTO>();
                while (reader.Read())
                {
                    var finalAccount = new FinalAccountDTO
                    {
                        FinalAccountID = Convert.ToInt64(reader["FinalAccountID"]),
                        FinalAccountName = Convert.ToString(reader["FinalAccountName"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        DateAccount = DateTime.Parse(Convert.ToString(reader["DateAccount"])),
                        DebtID = Convert.ToInt64(reader["DebtID"]),
                        DebtName = Convert.ToString(reader["DebtName"]),
                        TransportationCost = Convert.ToInt64(reader["TransportationCost"]),
                        TotalCost = Convert.ToInt64(reader["TotalCost"]),
                        PersonAccount = Convert.ToString(reader["PersonAccount"]),
                        Note = Convert.ToString(reader["Note"]),
                        CreatedDate = DateTime.Parse(Convert.ToString(reader["CreatedDate"])),
                        LastUpdated = DateTime.Parse(Convert.ToString(reader["LastUpdate"])),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                    };
                    try
                    {
                        finalAccount.DateAccountFormated =
                            finalAccount.DateAccount.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                        finalAccount.TransportationCostFormated =
                            Global.Global.ConvertLongToMoney(finalAccount.TransportationCost, ".");
                        finalAccount.TotalCostFormated = Global.Global.ConvertLongToMoney(finalAccount.TotalCost, ".");
                        var ispay = Convert.ToBoolean(reader["IsPay"]);
                        finalAccount.IsPay = ispay ? 1 : 0;
                        finalAccount.ComparationDebtID = Convert.ToInt64(reader["ComparationDebtID"]);
                        finalAccount.WarehouseID = Convert.ToInt64(reader["WarehouseID"]);
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

        public bool DeleteFinalAccount(long id)
        {
            var cmd = new SqlCommand("[dbo].[FinalAccount_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@FinalAccountID", id));
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
            var cmd = new SqlCommand("[dbo].[FinalAccount_DeleteAll]", Connection) { CommandType = CommandType.StoredProcedure };
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
    }
}
