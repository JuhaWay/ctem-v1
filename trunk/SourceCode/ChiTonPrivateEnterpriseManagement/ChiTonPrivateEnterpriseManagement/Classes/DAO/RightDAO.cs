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
    class RightDAO
    {
        public RightDAO()
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

        public List<RightDTO> LoadAllRights()
        {
            var cmd = new SqlCommand("[dbo].[Rights_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<RightDTO> listRights = new List<RightDTO>();
                while (reader.Read())
                {
                    RightDTO right = new RightDTO
                    {
                        RightID = Convert.ToInt64(reader["RightID"]),
                        RightName = Convert.ToString(reader["RightName"]),
                        Description = Convert.ToString(reader["Description"]),
                        Value = Convert.ToInt64(reader["Value"]),
                        isActive = Convert.ToBoolean(reader["isActive"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                    };
                    try
                    {
                        right.CreatedDate = DateTime.ParseExact(Convert.ToString(reader["CreateDate"]), "dd/MM/yyyy", null);
                        right.LastUpdated = DateTime.ParseExact(Convert.ToString(reader["LastUpdated"]), "dd/MM/yyyy", null);
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    listRights.Add(right);
                }
                return listRights;
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

        public List<RoleDTO> GetRoleByMenuID(int menuID)
        {
            var cmd = new SqlCommand("[dbo].[Role_GetByMenuID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@menuID", menuID));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<RoleDTO> listMenus = new List<RoleDTO>();
                while (reader.Read())
                {
                    RoleDTO menu = new RoleDTO
                    {
                        RoleID = Convert.ToInt64(reader["RoleID"]),
                        RoleName = Convert.ToString(reader["RoleName"]),
                        Description = Convert.ToString(reader["Description"]),
                        RightsValue = Convert.ToInt64(reader["RightsValue"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                    };
                    listMenus.Add(menu);
                }
                return listMenus;
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

        public bool CreateRight(long RightID, string rightName, string description, long value, bool isActive, string CreateBy)
        {
            var cmd = new SqlCommand("[dbo].[Rights_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@rightID", RightID));
                cmd.Parameters.Add(new SqlParameter("@rightName", rightName));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@value", value));
                cmd.Parameters.Add(new SqlParameter("@isActive", isActive));
                cmd.Parameters.Add(new SqlParameter("@createdBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@updatedBy", CreateBy));

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