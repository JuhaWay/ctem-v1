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


        public List<WarehouseDTO> LoadWarehouses(string name, string type, int status)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_Get]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@Type", type));
                cmd.Parameters.Add(new SqlParameter("@Name", name));
                cmd.Parameters.Add(new SqlParameter("@Status", status));
                SqlDataReader reader = cmd.ExecuteReader();
                var listwarehouse = new List<WarehouseDTO>();
                while (reader.Read())
                {
                    var warehouse = new WarehouseDTO
                    {
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        Address = Convert.ToString(reader["Address"]),
                        ManagerName = Convert.ToString(reader["ManagerName"]),
                        Type = Convert.ToString(reader["Type"])                        
                    };
                    try
                    {
                        warehouse.ConstructionID = Convert.ToInt64(reader["ConstructionID"]);
                    }
                    catch (Exception)
                    {
                    }
                    bool isactive = Convert.ToBoolean(reader["IsActive"]);
                    warehouse.IsActive = isactive ? 1 : 0;
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
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", warehouse.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@ManagerName", warehouse.ManagerName));
                cmd.Parameters.Add(new SqlParameter("@Description", warehouse.Description));
                cmd.Parameters.Add(new SqlParameter("@Type", warehouse.Type));
                cmd.Parameters.Add(new SqlParameter("@Address", warehouse.Address));
                cmd.Parameters.Add(new SqlParameter("@IsActive", warehouse.IsActive));
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
        
        public bool DeleteWarehouse(long id)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", id));
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

        public bool DeleteAllWarehouse()
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_DeleteAll]", Connection) { CommandType = CommandType.StoredProcedure };
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

        public WarehouseMaterialDTO FinMaterial(long warehouseID, long materialId)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_Material]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", warehouseID));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", materialId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var warehousematerial = new WarehouseMaterialDTO
                    {
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        Quantity = Convert.ToDouble(reader["Quantity"]),
                        UnitCal = Convert.ToString(reader["RealCalUnit"]),
                        Ratio = Convert.ToDouble(reader["Ratio"]),
                        AveragePrice = Convert.ToInt64(reader["AveragePrice"]),
                        TotalCost = Convert.ToInt64(reader["TotalCost"]),
                    };
                    warehousematerial.AveragePriceFormated = Global.Global.ConvertLongToMoney(warehousematerial.AveragePrice, Constants.SPLIP_MONEY);
                    warehousematerial.TotalCostFormated = Global.Global.ConvertLongToMoney(warehousematerial.TotalCost, Constants.SPLIP_MONEY);
                    return warehousematerial;
                }
                return null;
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

        public bool UpdateWarehouseItem(WarehouseMaterialDTO materialWH)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_UpdateItem]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", materialWH.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", materialWH.MaterialID));
                cmd.Parameters.Add(new SqlParameter("@Quantity", materialWH.Quantity));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", materialWH.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@AveragePrice", materialWH.AveragePrice));
                SqlDataReader reader = cmd.ExecuteReader();            
                return true;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public bool CreateWarehouseItem(WarehouseMaterialDTO materialWH)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_CreateItem]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", materialWH.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", materialWH.MaterialID));
                cmd.Parameters.Add(new SqlParameter("@Quantity", materialWH.Quantity));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", materialWH.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@AveragePrice", materialWH.AveragePrice));
                SqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (Transaction == null) Connection.Close();
            }
        }

        public bool UpdateWarehouse(WarehouseDTO warehouse)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", warehouse.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseName", warehouse.WarehouseName));
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", warehouse.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@ManagerName", warehouse.ManagerName));
                cmd.Parameters.Add(new SqlParameter("@Description", warehouse.Description));
                cmd.Parameters.Add(new SqlParameter("@Type", warehouse.Type));
                cmd.Parameters.Add(new SqlParameter("@Address", warehouse.Address));
                cmd.Parameters.Add(new SqlParameter("@IsActive", warehouse.IsActive));
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

        public List<WarehouseMaterialDTO> GetWarehouseDetail(string whname, string materialname)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_GetWarehouseMaterial]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseName", whname));
                cmd.Parameters.Add(new SqlParameter("@MaterialName", materialname));
                SqlDataReader reader = cmd.ExecuteReader();
                List<WarehouseMaterialDTO> listItem = new List<WarehouseMaterialDTO>();
                while (reader.Read())
                {
                    var warehousematerial = new WarehouseMaterialDTO
                    {
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),
                        WarehouseName = Convert.ToString(reader["WarehouseName"]),
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        Quantity = Convert.ToDouble(reader["Quantity"]),
                        UnitCal = Convert.ToString(reader["RealCalUnit"]),
                        AveragePrice = Convert.ToInt64(reader["AveragePrice"]),
                        TotalCost = Convert.ToInt64(reader["TotalCost"]),
                    };
                    warehousematerial.AveragePriceFormated = Global.Global.ConvertLongToMoney(warehousematerial.AveragePrice, Constants.SPLIP_MONEY);
                    warehousematerial.TotalCostFormated = Global.Global.ConvertLongToMoney(warehousematerial.TotalCost, Constants.SPLIP_MONEY);
                    listItem.Add(warehousematerial);
                }
                return listItem;
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

        public bool CreateStockOut(StockOutDTO stockout)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_CreateStockOut]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@StockOutID", stockout.StockOutId));
                cmd.Parameters.Add(new SqlParameter("@DateStockOut", stockout.DateStockOut));
                cmd.Parameters.Add(new SqlParameter("@StockOutFrom", stockout.StockOutFrom));
                cmd.Parameters.Add(new SqlParameter("@StockOutTo", stockout.StockOutTo));
                cmd.Parameters.Add(new SqlParameter("@Driver", stockout.DriverName));
                cmd.Parameters.Add(new SqlParameter("@TransportationCost", stockout.TransportationCost));
                cmd.Parameters.Add(new SqlParameter("@NoVehicle", stockout.NoVehicle));
                cmd.Parameters.Add(new SqlParameter("@Note", stockout.Note));
                cmd.Parameters.Add(new SqlParameter("@CreatedBy", Global.Global.CurrentUser.Username));
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

        public bool CreateStockOutDetail(StockOutDetailDTO stockoutDetailDto)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_CreateStockOutDetail]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseFromID", stockoutDetailDto.WarehouseFromId));
                cmd.Parameters.Add(new SqlParameter("@WarehouseToID", stockoutDetailDto.WarehouseToId));
                cmd.Parameters.Add(new SqlParameter("@StockOutID", stockoutDetailDto.StockOutId));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", stockoutDetailDto.MaterialId));
                cmd.Parameters.Add(new SqlParameter("@Quantity", stockoutDetailDto.Quantity));
                cmd.Parameters.Add(new SqlParameter("@Price", stockoutDetailDto.Price));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", stockoutDetailDto.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@Note", stockoutDetailDto.Note));
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

        public List<StockOutDTO> LoadStockout(string whname, DateTime from, DateTime to)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_GetStockOut]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseName", whname));
                cmd.Parameters.Add(new SqlParameter("@from", from));
                cmd.Parameters.Add(new SqlParameter("@to", to));
                SqlDataReader reader = cmd.ExecuteReader();
                var liststockout = new List<StockOutDTO>();
                while (reader.Read())
                {
                    var stockout = new StockOutDTO()
                    {
                        StockOutId = Convert.ToString(reader["StockOutId"]),
                        StockOutFrom = Convert.ToString(reader["StockOutFrom"]),
                        StockOutTo = Convert.ToString(reader["StockOutTo"]),
                        TransportationCost = Convert.ToInt64(reader["TransportationCost"]),
                        DriverName = Convert.ToString(reader["Driver"]),
                        NoVehicle = Convert.ToInt64(reader["NoVehicle"]),
                        VehicleName = Convert.ToString(reader["VehicleName"]),
                        Note = Convert.ToString(reader["Note"])
                    };
                    try
                    {
                        stockout.CreatedBy = Convert.ToString(reader["CreatedBy"]);
                        stockout.UpdatedBy = Convert.ToString(reader["UpdatedBy"]);
                        stockout.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                        stockout.LastUpdate = Convert.ToDateTime(reader["LastUpdate"]);
                    }
                    catch (Exception)
                    {
                    }
                    liststockout.Add(stockout);
                }
                return liststockout;
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

        public bool DeleteStockout(long id)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_DeleteStockOut]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@StockoutId", id));
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

        public bool DeleteAllStockout()
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_DeleteAllStock]", Connection) { CommandType = CommandType.StoredProcedure };
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

        public bool UpdateStockOut(StockOutDTO stockout)
        {
            var cmd = new SqlCommand("[dbo].[Warehouse_UpdateStockOut]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@StockOutID", stockout.StockOutId));
                cmd.Parameters.Add(new SqlParameter("@DateStockOut", stockout.DateStockOut));
                cmd.Parameters.Add(new SqlParameter("@StockOutFrom", stockout.StockOutFrom));
                cmd.Parameters.Add(new SqlParameter("@StockOutTo", stockout.StockOutTo));
                cmd.Parameters.Add(new SqlParameter("@Driver", stockout.DriverName));
                cmd.Parameters.Add(new SqlParameter("@TransportationCost", stockout.TransportationCost));
                cmd.Parameters.Add(new SqlParameter("@NoVehicle", stockout.NoVehicle));
                cmd.Parameters.Add(new SqlParameter("@Note", stockout.Note));
                cmd.Parameters.Add(new SqlParameter("@CreatedBy", Global.Global.CurrentUser.Username));
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

        public StockOutDetailDTO FindStockOutItem(string stockid, long materialid)
        {
            return null;
        }
    }
}
