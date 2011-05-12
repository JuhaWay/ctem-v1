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
            var cmd = new SqlCommand("[dbo].[GetEmployerByUsername]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                EmployerDTO employer = null;
                if (reader.Read())
                {
                    employer = new EmployerDTO
                    {
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
                        Passport = Convert.ToString(reader["Passport"]),
                        MobilePhone = Convert.ToString(reader["MobilePhone"]),
                        HomePhone = Convert.ToString(reader["HomePhone"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"]),
                        Status = Convert.ToString(reader["Status"])
                    };
                    try
                    {
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
    }
}
