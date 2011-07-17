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
    class LedgerDAO
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
        public List<LedgerDTO> LoadLedgers()
        {
            var cmd = new SqlCommand("[dbo].[Ledger_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<LedgerDTO> listcons = new List<LedgerDTO>();
                while (reader.Read())
                {
                    LedgerDTO dto = new LedgerDTO
                    {
                        LedgerID = Convert.ToInt64(reader["LedgerID"]),
                        Name = Convert.ToString(reader["Name"]),
                        Type = Convert.ToString(reader["Type"]),
                        Number = Convert.ToInt64(reader["Number"]),
                        Person = Convert.ToString(reader["Person"]),
                        Reason = Convert.ToString(reader["Reason"]),
                        Method = Convert.ToString(reader["Method"]),
                        Date = Convert.ToDateTime(reader["Date"]),


                    };
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.NumberFormated = Global.Global.ConvertLongToMoney(dto.Number, Global.Global.SEP);
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
        public List<LedgerDTO> LedgerSearch(LedgerDTO param)
        {
            var cmd = new SqlCommand("[dbo].[Ledger_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if (param.Name.Trim().Equals("")==false)
                cmd.Parameters.Add(new SqlParameter("@Name", "%" + param.Name.Trim() + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
            if (param.Type.Trim().Equals("") == false && param.Type.Trim().Equals("Tất cả") == false)
                cmd.Parameters.Add(new SqlParameter("@Type",param.Type.Trim()));
            else
                cmd.Parameters.Add(new SqlParameter("@Type", DBNull.Value));
            if (param.Person.Trim().Equals("") == false)
                cmd.Parameters.Add(new SqlParameter("@Person", param.Person.Trim()));
            else
                cmd.Parameters.Add(new SqlParameter("@Person", DBNull.Value));

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<LedgerDTO> listcons = new List<LedgerDTO>();
                while (reader.Read())
                {
                    LedgerDTO dto = new LedgerDTO
                    {
                        LedgerID = Convert.ToInt64(reader["LedgerID"]),
                        Name = Convert.ToString(reader["Name"]),
                        Type = Convert.ToString(reader["Type"]),
                        Number = Convert.ToInt64(reader["Number"]),
                        Person = Convert.ToString(reader["Person"]),
                        Reason = Convert.ToString(reader["Reason"]),
                        Method = Convert.ToString(reader["Method"]),
                        Date = Convert.ToDateTime(reader["Date"]),


                    };
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.NumberFormated = Global.Global.ConvertLongToMoney(dto.Number, Global.Global.SEP);
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
        public bool CreateLedger(LedgerDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Ledger_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Name", dto.Name.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Type", dto.Type.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Number", dto.Number));
                cmd.Parameters.Add(new SqlParameter("@Person", dto.Person.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Reason", dto.Reason));
                cmd.Parameters.Add(new SqlParameter("@Method", dto.Method));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));


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
        public bool updateLedger(LedgerDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Ledger_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@LedgerID", dto.LedgerID));
                cmd.Parameters.Add(new SqlParameter("@Name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@Type", dto.Type));
                cmd.Parameters.Add(new SqlParameter("@Number", dto.Number));
                cmd.Parameters.Add(new SqlParameter("@Person", dto.Person));
                cmd.Parameters.Add(new SqlParameter("@Reason", dto.Reason));
                cmd.Parameters.Add(new SqlParameter("@Method", dto.Method));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));


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
            var cmd = new SqlCommand("[dbo].[Ledger_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@LedgerID", id));
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
