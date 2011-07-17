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
            //-------------------------------------------------------------------------------------
            if (param.FromDate!=null)
                cmd.Parameters.Add(new SqlParameter("@FromDate",param.FromDate));
            else
                cmd.Parameters.Add(new SqlParameter("@FromDate", DBNull.Value));
            if (param.ToDate != null)
                cmd.Parameters.Add(new SqlParameter("@ToDate", param.ToDate));
            else
                cmd.Parameters.Add(new SqlParameter("@ToDate", DBNull.Value));
            
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
                        FualCost = Convert.ToInt64(reader["FualCost"]),
                        DamagedCost = Convert.ToInt64(reader["DamagedCost"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        VehicleName = Convert.ToString(reader["Name"]),
                        DriverName = Convert.ToString(reader["Username"]),
                        Date = Convert.ToDateTime(reader["Date"])


                    };
                    dto.FualCostFormated = Global.Global.ConvertLongToMoney(dto.FualCost, Global.Global.SEP);
                    dto.DamagedCostFormated = Global.Global.ConvertLongToMoney(dto.DamagedCost, Global.Global.SEP);
                    dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
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
        public bool CreateVehicleDairy(VehicleDairyDTO dto)
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
                cmd.Parameters.Add(new SqlParameter("@RoadMap", dto.RoadMap));
                cmd.Parameters.Add(new SqlParameter("@FualCost", dto.FualCost));
                cmd.Parameters.Add(new SqlParameter("@DamagedCost", dto.DamagedCost));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@isPaid", dto.isPaid));


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
                cmd.Parameters.Add(new SqlParameter("@RoadMap", dto.RoadMap));
                cmd.Parameters.Add(new SqlParameter("@FualCost", dto.FualCost));
                cmd.Parameters.Add(new SqlParameter("@DamagedCost", dto.DamagedCost));
                cmd.Parameters.Add(new SqlParameter("@Date", dto.Date));
                cmd.Parameters.Add(new SqlParameter("@isPaid", dto.isPaid));


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
    }
}
