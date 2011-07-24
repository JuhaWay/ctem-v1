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
    class EstimateDetailDAO
    {
         public EstimateDetailDAO()
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


        public List<EstimateDetailDTO> LoadAllEstimateDetails(long estimateId)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_GetByEstimateId]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@estimateID", estimateId));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<EstimateDetailDTO> listcons = new List<EstimateDetailDTO>();
                while (reader.Read())
                {
                    EstimateDetailDTO edDto = new EstimateDetailDTO
                    {
                        No = Convert.ToString(reader["No"]),
                        EstimateDetailID = Convert.ToInt64(reader["EstimateDetailID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        QuantityEstimate = Convert.ToInt32(reader["QuantityEstimate"]), 
                        UnitCostEstimate = Convert.ToDouble(reader["UnitCostEstimate"]),
                        TotalCostEstimate = Convert.ToDouble(reader["TotalCostEstimate"])
                    };
                    listcons.Add(edDto);
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


        public bool check(long mID,long eID)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetal_Check]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaterialID", mID));
            cmd.Parameters.Add(new SqlParameter("@EstimateID", eID));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                return false;
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

        public List<EstimateDetailDTO> search(long estimateId,long materialId)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            // set param------------------------------------------------------
            cmd.Parameters.Add(new SqlParameter("@estimateID", estimateId));
            if (materialId>0)
                cmd.Parameters.Add(new SqlParameter("@materialID", materialId));
            else
                cmd.Parameters.Add(new SqlParameter("@materialID", DBNull.Value));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<EstimateDetailDTO> listcons = new List<EstimateDetailDTO>();
                while (reader.Read())
                {
                    EstimateDetailDTO edDto = new EstimateDetailDTO
                    {
                        No = Convert.ToString(reader["No"]),
                        EstimateDetailID = Convert.ToInt64(reader["EstimateDetailID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        Name = Convert.ToString(reader["Name"]),
                        MaterialID = reader["MaterialID"]!=DBNull.Value?Convert.ToInt64(reader["MaterialID"]):0,
                        QuantityEstimate = Convert.ToDouble(reader["QuantityEstimate"]),
                        MaterialEstCal = Convert.ToString(reader["EstimateCalUnit"]),
                        UnitCostEstimate = Convert.ToDouble(reader["UnitCostEstimate"]),
                        TotalCostEstimate = Convert.ToDouble(reader["TotalCostEstimate"])
                    };
                    edDto.UnitCostEstimateFormated = Global.Global.ConvertDoubleToMoney(edDto.UnitCostEstimate,Constants.SPLIP_MONEY);
                    edDto.TotalCostEstimateFormated = Global.Global.ConvertDoubleToMoney(edDto.TotalCostEstimate, Constants.SPLIP_MONEY);
                    listcons.Add(edDto);
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

        public bool CreateEstimateDetail(EstimateDetailDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@no", dto.No));
                cmd.Parameters.Add(new SqlParameter("@estimateID", dto.EstimateID));
                if (dto.MaterialID>0)
                    cmd.Parameters.Add(new SqlParameter("@materialID", dto.MaterialID));
                else 
                    cmd.Parameters.Add(new SqlParameter("@materialID",DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@quantityEstimate", dto.QuantityEstimate));
                cmd.Parameters.Add(new SqlParameter("@unitCostEstimate", dto.UnitCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", dto.TotalCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@name", dto.Name));
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

        public bool UpdateEstimateDetail(EstimateDetailDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@no", dto.No));
                cmd.Parameters.Add(new SqlParameter("@estimateDetailID", dto.EstimateDetailID));
                if (dto.MaterialID > 0)
                    cmd.Parameters.Add(new SqlParameter("@materialID", dto.MaterialID));
                else
                    cmd.Parameters.Add(new SqlParameter("@materialID", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@quantityEstimate", dto.QuantityEstimate));
                cmd.Parameters.Add(new SqlParameter("@unitCostEstimate", dto.UnitCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", dto.TotalCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@name", dto.Name));
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

        internal bool DeleteEstimateDetail(long estimateDetailID)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateDetailID", estimateDetailID));
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
