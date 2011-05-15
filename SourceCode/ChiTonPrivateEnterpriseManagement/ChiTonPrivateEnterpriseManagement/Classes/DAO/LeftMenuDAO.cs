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
    class LeftMenuDAO
    {
        public LeftMenuDAO()
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

        public List<LeftMenuDTO> GetMenuByRoleID(long roleID)
        {
            var cmd = new SqlCommand("[dbo].[Menu_GetByRoleID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.Parameters.Add(new SqlParameter("@roleID", roleID));
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<LeftMenuDTO> listMenus = new List<LeftMenuDTO>();
                while (reader.Read())
                {
                    LeftMenuDTO menu = new LeftMenuDTO
                    {
                        MenuID = Convert.ToInt32(reader["MenuID"]),
                        MenuName = Convert.ToString(reader["MenuName"]),
                        MenuParent = Convert.ToInt32(reader["Parent"]),
                        Description = Convert.ToString(reader["Description"])
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

        public List<LeftMenuDTO> GetAllMenu()
        {
            var cmd = new SqlCommand("[dbo].[Menu_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<LeftMenuDTO> listMenus = new List<LeftMenuDTO>();
                while (reader.Read())
                {
                    LeftMenuDTO menu = new LeftMenuDTO
                    {
                        MenuID = Convert.ToInt32(reader["MenuID"]),
                        MenuName = Convert.ToString(reader["MenuName"]),
                        MenuParent = Convert.ToInt32(reader["Parent"]),
                        Description = Convert.ToString(reader["Description"])
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

        public bool CreateMenu(int menuID, string menuName, int menuParent, string description)
        {
            var cmd = new SqlCommand("[dbo].[Menu_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@menuID", menuID));
                cmd.Parameters.Add(new SqlParameter("@menuName", menuName));
                cmd.Parameters.Add(new SqlParameter("@parent", menuParent));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                
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

        public bool CreateMenuRole(int menuID, long roleID)
        {
            var cmd = new SqlCommand("[dbo].[MenuRole_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@MenuID", menuID));
                cmd.Parameters.Add(new SqlParameter("@RoleID", roleID));

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

        public bool DeleteMenu(int menuID)
        {
            var cmd = new SqlCommand("[dbo].[Menu_Delete]", Connection);
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.Add(new SqlParameter("@menuID", menuID));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sql)
            {
                return false;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }
    }
}
