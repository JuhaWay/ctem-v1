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
    class RoleDAO
    {
        public RoleDAO()
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

        public List<RoleDTO> GetAllRole()
        {
            var cmd = new SqlCommand("[dbo].[Role_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
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
                        IsActive = Convert.ToBoolean(reader["IsActive"])
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

        public bool DeleteRole(long RoleID)
        {
            var cmd = new SqlCommand("[dbo].[Role_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@roleID", RoleID));

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

        public bool CreateRole(string RoleName, string description, long rightsValue, bool isActive)
        {
            var cmd = new SqlCommand("[dbo].[Role_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@roleName", RoleName));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@rightsValue", rightsValue));
                cmd.Parameters.Add(new SqlParameter("@isActive", isActive));
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

        public bool UpdateRole(long RoleID, string RoleName, string description, long rightsValue, bool isActive)
        {
            var cmd = new SqlCommand("[dbo].[Role_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@roleID", RoleID));
                cmd.Parameters.Add(new SqlParameter("@roleName", RoleName));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@rightsValue", rightsValue));
                cmd.Parameters.Add(new SqlParameter("@isActive", isActive));

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

        public List<RoleDTO> GetWithoutAdmin()
        {
            var cmd = new SqlCommand("[dbo].[Role_GetWithoutAdmin]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<RoleDTO> listRoles = new List<RoleDTO>();
                while (reader.Read())
                {
                    RoleDTO role = new RoleDTO
                    {
                        RoleID = Convert.ToInt64(reader["RoleID"]),
                        RoleName = Convert.ToString(reader["RoleName"]),
                        Description = Convert.ToString(reader["Description"]),
                        RightsValue = Convert.ToInt64(reader["RightsValue"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                    };
                    listRoles.Add(role);
                }
                return listRoles;
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
