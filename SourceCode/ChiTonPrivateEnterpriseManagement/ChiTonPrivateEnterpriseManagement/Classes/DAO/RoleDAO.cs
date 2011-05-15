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
    }
}
