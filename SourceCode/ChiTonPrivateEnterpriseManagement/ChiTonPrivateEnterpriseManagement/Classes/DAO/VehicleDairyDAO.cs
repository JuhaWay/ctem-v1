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
    class VehicleDairyDAO
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
        public List<VehicleDairyDTO> searchVehicleDairy(VehicleDairyDTO param)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairy_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }


            cmd.CommandType = CommandType.StoredProcedure;
            if (param.VehicleID > 0)
                cmd.Parameters.Add(new SqlParameter("@VehicleID", param.VehicleID));
            else
                cmd.Parameters.Add(new SqlParameter("@VehicleID", DBNull.Value));
            if (param.ConstructionID > 0)
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", param.ConstructionID));
            else
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", DBNull.Value));
            if (param.DriverID > 0)
                cmd.Parameters.Add(new SqlParameter("@DriverID", param.DriverID));
            else
                cmd.Parameters.Add(new SqlParameter("@DriverID", DBNull.Value));
            if (param.isPaid!=null)
                cmd.Parameters.Add(new SqlParameter("@isPaid", param.isPaid));
            else
                cmd.Parameters.Add(new SqlParameter("@isPaid", DBNull.Value));
            //-------------------------------------------------------------------------------------
            if (param.FromDate!=null)
                cmd.Parameters.Add(new SqlParameter("@FromDate",param.FromDate));
            else
                cmd.Parameters.Add(new SqlParameter("@FromDate", DBNull.Value));
            if (param.ToDate != null)
                cmd.Parameters.Add(new SqlParameter("@ToDate", param.ToDate));
            else
                cmd.Parameters.Add(new SqlParameter("@ToDate", DBNull.Value));
            if (!param.Category.Trim().Equals("") && !param.Category.Trim().Equals("Tất cả"))
                cmd.Parameters.Add(new SqlParameter("@Category", param.Category.Trim()));
            else
                cmd.Parameters.Add(new SqlParameter("@Category", DBNull.Value));
            cmd.Parameters.Add(new SqlParameter("@ManagerID", param.ManagerID));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<VehicleDairyDTO> listcons = new List<VehicleDairyDTO>();
                while (reader.Read())
                {
                    VehicleDairyDTO dto = new VehicleDairyDTO
                    {
                        VehicleDairyID = Convert.ToInt64(reader["VehicleDairyID"]),
                        VehicleID = Convert.ToInt64(reader["VehicleID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        RoadMap = Convert.ToString(reader["RoadMap"]),
                        DriverID = Convert.ToInt64(reader["DriverID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        VehicleName = Convert.ToString(reader["Name"]),
                        DriverName = Convert.ToString(reader["Username"]),
                        VehicleNumber = Convert.ToString(reader["Number"]),
                        Date = Convert.ToDateTime(reader["Date"]),
                        Taker = Convert.ToString(reader["Taker"]),
                        isPaid = Convert.ToBoolean(reader["isPaid"]),
                        Category = Convert.ToString(reader["Category"]),
                        Task = Convert.ToString(reader["Task"]),
                        Totalcost = Convert.ToInt64(reader["TotalCost"]),
                        DebtID = reader["DebtID"] == DBNull.Value ? 0 :
                        Convert.ToInt64(reader["DebtID"]),
                        WarehouseID = reader["WareHouseID"] == DBNull.Value ? 0 :
                        Convert.ToInt64(reader["WareHouseID"])


                    };
                  
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.TotalcostFormated = Global.Global.ConvertLongToMoney(dto.Totalcost, Global.Global.SEP);
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


        public VehicleDairyDTO getByID(long ID)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairy_GetByID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", ID));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    VehicleDairyDTO dto = new VehicleDairyDTO
                    {
                        VehicleDairyID = Convert.ToInt64(reader["VehicleDairyID"]),
                        VehicleID = Convert.ToInt64(reader["VehicleID"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        RoadMap = Convert.ToString(reader["RoadMap"]),
                        DriverID = Convert.ToInt64(reader["DriverID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        VehicleName = Convert.ToString(reader["Name"]),
                        DriverName = Convert.ToString(reader["Username"]),
                        VehicleNumber = Convert.ToString(reader["Number"]),
                        Date = Convert.ToDateTime(reader["Date"]),
                        isPaid = Convert.ToBoolean(reader["isPaid"]),
                        Category = Convert.ToString(reader["Category"]),
                        Task = Convert.ToString(reader["Task"]),
                        FualCost = reader["FualCost"]==DBNull.Value?0:
                        Convert.ToInt64(reader["FualCost"]),
                        DamagedCost = reader["DamagedCost"] == DBNull.Value ? 0 :
                        Convert.ToInt64(reader["DamagedCost"]),
                        Taker = Convert.ToString(reader["Taker"]),
                        Totalcost = reader["TotalCost"]==null?0:
                        Convert.ToInt64(reader["TotalCost"]),
                        DebtID = reader["DebtID"] == DBNull.Value ? 0 :
                        Convert.ToInt64(reader["DebtID"]),
                        WarehouseID = reader["WareHouseID"] == DBNull.Value ? 0 :
                        Convert.ToInt64(reader["WareHouseID"])


                    };
              
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    dto.FualCostFormated = Global.Global.ConvertLongToMoney(dto.FualCost, Global.Global.SEP);
                    dto.DamagedCostFormated = Global.Global.ConvertLongToMoney(dto.DamagedCost, Global.Global.SEP);
                    dto.TotalcostFormated = Global.Global.ConvertLongToMoney(dto.Totalcost, Global.Global.SEP);
                    return dto;

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
        public long CreateVehicleDairy(VehicleDairyDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairy_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleID", dto.VehicleID));
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@DriverID", dto.DriverID));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@isPaid", dto.isPaid));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", dto.Totalcost));
                cmd.Parameters.Add(new SqlParameter("@Task", dto.Task));
                cmd.Parameters.Add(new SqlParameter("@FualCost", dto.FualCost));
                cmd.Parameters.Add(new SqlParameter("@Taker", dto.Taker));
                cmd.Parameters.Add(new SqlParameter("@DebtID", dto.DebtID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", dto.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@DamagedCost", dto.DamagedCost));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return Convert.ToInt64(reader[0]);
                return 0;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return 0;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }

        public bool UpdateVehicleDairy(VehicleDairyDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairy_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", dto.VehicleDairyID));
                cmd.Parameters.Add(new SqlParameter("@VehicleID", dto.VehicleID));
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@DriverID", dto.DriverID));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@isPaid", dto.isPaid));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", dto.Totalcost));
                cmd.Parameters.Add(new SqlParameter("@Task", dto.Task));
                cmd.Parameters.Add(new SqlParameter("@FualCost", dto.FualCost));
                cmd.Parameters.Add(new SqlParameter("@Taker", dto.Taker));
                cmd.Parameters.Add(new SqlParameter("@DebtID", dto.DebtID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseID", dto.WarehouseID));
                cmd.Parameters.Add(new SqlParameter("@DamagedCost", dto.DamagedCost));


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
            var cmd = new SqlCommand("[dbo].[VehicleDairy_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", id));
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
        public List<RoadMapDTO> getRoads(long ID)
        {
            var cmd = new SqlCommand("[dbo].[RoadMap_getall]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", ID));
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<RoadMapDTO> listcons = new List<RoadMapDTO>();
                while (reader.Read())
                {
                    RoadMapDTO dto = new RoadMapDTO
                    {
                        VehicleDairyID = Convert.ToInt64(reader["VehicleDairyID"]),
                        RoadMapID = Convert.ToInt64(reader["RoadMapID"]),
                        From = Convert.ToString(reader["FromPlace"]),
                        To = Convert.ToString(reader["ToPlace"]),
                        Km = Convert.ToString(reader["Kilomet"])

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


        public bool CreateRoadMap(RoadMapDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[RoadMap_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", dto.VehicleDairyID));
                cmd.Parameters.Add(new SqlParameter("@From", dto.From));
                cmd.Parameters.Add(new SqlParameter("@To", dto.To));
                cmd.Parameters.Add(new SqlParameter("@Km", dto.Km));
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

        public bool UpdateRoadMap(RoadMapDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[RoadMap_UPDATE]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@RoadMapID", dto.RoadMapID));
                cmd.Parameters.Add(new SqlParameter("@From", dto.From));
                cmd.Parameters.Add(new SqlParameter("@To", dto.To));
                cmd.Parameters.Add(new SqlParameter("@Km", dto.Km));
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

        public bool deleteRoadMap(long ID)
        {
            var cmd = new SqlCommand("[dbo].[RoadMap_delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@RoadMapID", ID));
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
        //--------------------------------------------------------------------------------------
        public long CreateVehicleDairyCost(VehicleDairyCostDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairyCost_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleID", dto.VehicleID));
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", dto.VehicleDairyID));
                cmd.Parameters.Add(new SqlParameter("@Quantity", dto.Quantity));
                cmd.Parameters.Add(new SqlParameter("@Price", dto.Price));
                cmd.Parameters.Add(new SqlParameter("@TotalCost", dto.TotalCost));
                cmd.Parameters.Add(new SqlParameter("@Unit", dto.Unit));
                cmd.Parameters.Add(new SqlParameter("@Name", dto.Name));
                cmd.Parameters.Add(new SqlParameter("@Type", dto.Type));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@Taker", dto.Taker));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return Convert.ToInt64(reader[0]);
                return 0;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return 0;
            }
            finally
            {
                if (Transaction == null)
                    Connection.Close();
            }
        }
        public bool deleteVehicleDairyCost(long ID)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairyCost_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", ID));
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

        public List<VehicleDairyCostDTO> searchVehicleDairyCost(VehicleDairyCostDTO param)
        {
            var cmd = new SqlCommand("[dbo].[VehicleDairyCost_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }


            cmd.CommandType = CommandType.StoredProcedure;
            if (param.VehicleID > 0)
                cmd.Parameters.Add(new SqlParameter("@VehicleID", param.VehicleID));
            else
                cmd.Parameters.Add(new SqlParameter("@VehicleID", DBNull.Value));
            if (param.VehicleDairyID > 0)
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", param.VehicleDairyID));
            else
                cmd.Parameters.Add(new SqlParameter("@VehicleDairyID", DBNull.Value));
            //-------------------------------------------------------------------------------------
            if (param.FromDate != null)
                cmd.Parameters.Add(new SqlParameter("@FromDate", param.FromDate));
            else
                cmd.Parameters.Add(new SqlParameter("@FromDate", DBNull.Value));
            if (param.ToDate != null)
                cmd.Parameters.Add(new SqlParameter("@ToDate", param.ToDate));
            else
                cmd.Parameters.Add(new SqlParameter("@ToDate", DBNull.Value));
            //-------------------------------------------------------------------------------------
            if (!param.Type.Trim().Equals("") && !param.Type.Trim().Equals("Tất cả"))
                cmd.Parameters.Add(new SqlParameter("@Type", param.Type.Trim()));
            else
                cmd.Parameters.Add(new SqlParameter("@Type", DBNull.Value));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<VehicleDairyCostDTO> listcons = new List<VehicleDairyCostDTO>();
                while (reader.Read())
                {
                    VehicleDairyCostDTO dto = new VehicleDairyCostDTO
                    {
                        VehicleDairyCostID = Convert.ToInt64(reader["VehicleDairyCostID"]),
                        VehicleDairyID = Convert.ToInt64(reader["VehicleDairyID"]),
                        VehicleID = Convert.ToInt64(reader["VehicleID"]),
                        Quantity = Convert.ToDouble(reader["Quantity"]),
                        Price = Convert.ToDouble(reader["Price"]),
                        TotalCost = Convert.ToDouble(reader["TotalCost"]),
                        Unit = Convert.ToString(reader["Unit"]),
                        Taker = Convert.ToString(reader["Taker"]),
                        Name = Convert.ToString(reader["Name"]),
                        Date = Convert.ToDateTime(reader["Date"]),
                        Type = Convert.ToString(reader["Type"])


                    };
                    dto.PriceFormated = Global.Global.ConvertDoubleToMoney(dto.Price, Global.Global.SEP);
                    dto.TotalCostFormated = Global.Global.ConvertDoubleToMoney(dto.TotalCost, Global.Global.SEP);
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
    }
}
