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
    class WarehouseDAO
    {
        public WarehouseDAO()
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


        public List<WarehouseDTO> LoadAllWarehouses()
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WarehouseDTO> listwarehouse = new List<WarehouseDTO>();
                while (reader.Read())
                {
                    WarehouseDTO warehouse = new WarehouseDTO
                    {
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        Address = Convert.ToString(reader["Address"]),
                        ManagerName = Convert.ToString(reader["ManagerName"]),
                        Type = Convert.ToString(reader["Type"])                        
                    };
                    bool isactive = Convert.ToBoolean(reader["IsActive"]);
                    if (isactive)
                    {
                        warehouse.IsActive = 1;
                    }
                    else
                    {
                        warehouse.IsActive = 0;
                    }
                    listwarehouse.Add(warehouse);
                }
                return listwarehouse;
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

        public List<WarehouseDTO> LoadAllMainWarehouses()
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_GetAllMainWarehouse]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WarehouseDTO> listwarehouse = new List<WarehouseDTO>();
                while (reader.Read())
                {
                    WarehouseDTO warehouse = new WarehouseDTO
                    {
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        Description = Convert.ToString(reader["Description"]),
                        Address = Convert.ToString(reader["Address"]),
                        ManagerName = Convert.ToString(reader["ManagerName"]),
                        Type = Convert.ToString(reader["Type"]) 
                    };
                    bool isactive = Convert.ToBoolean(reader["IsActive"]);
                    if (isactive)
                    {
                        warehouse.IsActive = 1;
                    }
                    else
                    {
                        warehouse.IsActive = 0;
                    }
                    listwarehouse.Add(warehouse);
                }
                return listwarehouse;
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


        public bool CreateWarehouse(WarehouseDTO warehouse)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseName", warehouse.WarehouseName));
                cmd.Parameters.Add(new SqlParameter("@description", warehouse.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", warehouse.ManagerName));
                cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", warehouse.Description));
                cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", warehouse.Type));
                cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", warehouse.Address));
                cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", warehouse.IsActive));
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
        
        //public WarehouseDTO LoadWarehouseById(long id)
        //{
        //    var cmd = new SqlCommand("[dbo].[Warehouse_GetByID]", Connection);

        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@WarehouseID", id));
        //    try
        //    {
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            WarehouseDTO consDto = new WarehouseDTO
        //            {
        //                WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
        //                WarehouseName = Convert.ToString(reader["WarehouseName"]),
        //                Description = Convert.ToString(reader["Description"]),
        //                WarehouseAddress = Convert.ToString(reader["WarehouseAddress"]),
        //                CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
        //                CompletionDate = Convert.ToDateTime(reader["CompletionDate"])
        //            };
        //            return consDto;
        //        }
        //        return null;

        //    }
        //    catch (SqlException sql)
        //    {
        //        MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return null;
        //    }
        //    finally
        //    {
        //        if (Transaction == null) Connection.Close();
        //    }
        //}


        //public WarehouseDTO LoadWarehouseByName(string name)
        //{
        //    var cmd = new SqlCommand("[dbo].[Warehouse_GetByName]", Connection);

        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@WarehouseName", name));
        //    try
        //    {
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            WarehouseDTO consDto = new WarehouseDTO
        //            {
        //                WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
        //                WarehouseName = Convert.ToString(reader["WarehouseName"]),
        //                Description = Convert.ToString(reader["Description"]),
        //                WarehouseAddress = Convert.ToString(reader["WarehouseAddress"]),
        //                CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
        //                CompletionDate = Convert.ToDateTime(reader["CompletionDate"])
        //            };
        //            return consDto;
        //        }
        //        return null;

        //    }
        //    catch (SqlException sql)
        //    {
        //        MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return null;
        //    }
        //    finally
        //    {
        //        if (Transaction == null) Connection.Close();
        //    }
        //}



        //internal bool UpdateConstrction(long WarehouseID,string WarehouseName, string description, String WarehouseAddress,
        //                               DateTime commencementDate, DateTime completionDate, long totalEstimateCost,
        //                                string status)
        //{
        //    var cmd = new SqlCommand("[dbo].[Warehouse_Update]", Connection) { CommandType = CommandType.StoredProcedure };
        //    if (Transaction != null)
        //    {
        //        cmd.Transaction = Transaction;
        //    }
        //    try
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@WarehouseID", WarehouseID));
        //        cmd.Parameters.Add(new SqlParameter("@WarehouseName", WarehouseName));
        //        cmd.Parameters.Add(new SqlParameter("@description", description));
        //        cmd.Parameters.Add(new SqlParameter("@WarehouseAddress", WarehouseAddress));
        //        cmd.Parameters.Add(new SqlParameter("@commencementDate", commencementDate));
        //        cmd.Parameters.Add(new SqlParameter("@completionDate", completionDate));
        //        cmd.Parameters.Add(new SqlParameter("@totalEstimateCost", totalEstimateCost));
        //        cmd.Parameters.Add(new SqlParameter("@status", status));
        //        cmd.Parameters.Add(new SqlParameter("@hasEstimate", true));

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
