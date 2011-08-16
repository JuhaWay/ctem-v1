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
    class VehicleDAO
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
        public List<VehicleDTO> LoadAllVehicles()
        {
            var cmd = new SqlCommand("[dbo].[Vehicle_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<VehicleDTO> listcons = new List<VehicleDTO>();
                while (reader.Read())
                {
                    VehicleDTO dto = new VehicleDTO
                    {
                        VehicleID = Convert.ToInt64(reader["VehicleID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ManagerID = Convert.ToInt64(reader["ManagerID"]),
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        ManagerName = Convert.ToString(reader["Username"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        Status = Convert.ToString(reader["Status"]),
                        Name = Convert.ToString(reader["Name"]),
                        Number = Convert.ToString(reader["Number"])

                        
                    };
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


        public int Check(string num,long id)
        {
            var cmd = new SqlCommand("[dbo].[Vehicle_Check]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@VehicleID", id));
            cmd.Parameters.Add(new SqlParameter("@Number", num));
           
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                if (reader.Read())
                    count = Convert.ToInt32(reader[0]);
                return count;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public List<VehicleDTO> searchVehicle(VehicleDTO param)
        {
            var cmd = new SqlCommand("[dbo].[Vehicle_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if (!param.Name.Equals(""))
                cmd.Parameters.Add(new SqlParameter("@Name","%"+param.Name+"%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
            if (!param.Number.Equals(""))
                cmd.Parameters.Add(new SqlParameter("@Number", "%" + param.Number + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Number", DBNull.Value));
            if (!param.Category.Equals("") && !param.Category.Equals("Tất cả"))
                cmd.Parameters.Add(new SqlParameter("@Category", "%" + param.Category + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Category", DBNull.Value));
            if (param.ConstructionID>0) 
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", param.ConstructionID));
            else
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", DBNull.Value));
            if (param.ManagerID > 0)
                cmd.Parameters.Add(new SqlParameter("@ManagerID", param.ManagerID));
            else
                cmd.Parameters.Add(new SqlParameter("@ManagerID", DBNull.Value));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<VehicleDTO> listcons = new List<VehicleDTO>();
                while (reader.Read())
                {
                    VehicleDTO dto = new VehicleDTO
                    {
                        VehicleID = Convert.ToInt64(reader["VehicleID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ManagerID = Convert.ToInt64(reader["ManagerID"]),
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        ManagerName = Convert.ToString(reader["Username"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        Status = Convert.ToString(reader["Status"]),
                        Name = Convert.ToString(reader["Name"]),
                        Number = Convert.ToString(reader["Number"]),
                        Date = reader["Date"]==DBNull.Value?DateTime.MinValue.Date:
                        Convert.ToDateTime(reader["Date"]),
                        Category = Convert.ToString(reader["Category"])


                    };
                    dto.DateFormated =dto.Date==DateTime.MinValue.Date?"":
                        dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
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
        public bool CreateVehicle(VehicleDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Vehicle_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", dto.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@ManagerID", dto.ManagerID));
                cmd.Parameters.Add(new SqlParameter("@Name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@Number", dto.Number));
                cmd.Parameters.Add(new SqlParameter("@Status", dto.Status));
                cmd.Parameters.Add(new SqlParameter("@Category", dto.Category));
                if (dto.Date!=DateTime.MinValue.Date)
                    cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                else
                    cmd.Parameters.Add(new SqlParameter("@Date", DBNull.Value));
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
        public bool UpdateVehicle(VehicleDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Vehicle_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleID", dto.VehicleID));
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", dto.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@ManagerID", dto.ManagerID));
                cmd.Parameters.Add(new SqlParameter("@Name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@Number", dto.Number));
                cmd.Parameters.Add(new SqlParameter("@Status", dto.Status));
                if (dto.Date != DateTime.MinValue.Date)
                    cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                else
                    cmd.Parameters.Add(new SqlParameter("@Date", DBNull.Value));

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
            var cmd = new SqlCommand("[dbo].[Vehicle_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleID", id));
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
