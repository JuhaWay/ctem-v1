﻿using System;
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
    class EstimateDAO
    {

        public EstimateDAO()
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


        public List<EstimateDTO> LoadAllEstimates()
        {
            var cmd = new SqlCommand("[dbo].[Estimate_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<EstimateDTO> listcons = new List<EstimateDTO>();
                while (reader.Read())
                {
                    EstimateDTO consDto = new EstimateDTO
                    {
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        EstimateName = Convert.ToString(reader["EstimateName"]),
                        TotalCostEstimate = Convert.ToInt64(reader["TotalCostEstimate"]),
                        TotalCostReal = Convert.ToInt64(reader["TotalCostReal"]),
                        CreatedBy = reader["CreatedBy"]!= DBNull.Value ? Convert.ToString(reader["CreatedBy"]) : "",
                        CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : new DateTime(),
                        UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? Convert.ToString(reader["UpdatedBy"]) : "",
                        UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedDate"]) : new DateTime()
                    };
                    listcons.Add(consDto);
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


         public List<EstimateDTO> LoadEstimateByConstruction(long id)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_GetByConstruction]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ConstructionID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<EstimateDTO> listcons = new List<EstimateDTO>();
                while (reader.Read())
                {
                    EstimateDTO consDto = new EstimateDTO
                    {
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        EstimateName = Convert.ToString(reader["EstimateName"]),
                        TotalCostEstimate = Convert.ToInt64(reader["TotalCostEstimate"]),
                        TotalCostReal = Convert.ToInt64(reader["TotalCostReal"]),
                        CreatedBy = reader["CreatedBy"] != DBNull.Value ? Convert.ToString(reader["CreatedBy"]) : "",
                        CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : new DateTime(),
                        UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? Convert.ToString(reader["UpdatedBy"]) : "",
                        UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedDate"]) : new DateTime()
                    };
                    listcons.Add(consDto);
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


        public bool CreateEstimate(long ConstructionID, string EstimateName, long TotalCostEstimate,
                                       long TotalCostReal, DateTime CreatedDate, DateTime UpdatedDate,
                                       string CreatedBy, string UpdatedBy)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@estimateName", EstimateName));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", TotalCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@totalCostReal", TotalCostReal));
                cmd.Parameters.Add(new SqlParameter("@createdBy", Global.Global.CurrentUser.Username));
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

        public bool UpdateEstimate(long EstimateID, long TotalCostEstimate)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_UpdateTotalCost]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", EstimateID));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", TotalCostEstimate));

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

        public bool UpdateNameEstimate(long EstimateID,string name)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", EstimateID));
                cmd.Parameters.Add(new SqlParameter("@estimateName", name));
                cmd.Parameters.Add(new SqlParameter("@updatedBy", Global.Global.CurrentUser.Username));

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
        internal bool DeleteEstimate(long estimateID)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", estimateID));
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

        public long GetEstIDByConsID(long consID)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_GetEstimateIDByConstructionID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", consID));
                SqlDataReader reader = cmd.ExecuteReader();
                long EstID = 0;
                while (reader.Read())
                {
                    EstID = Convert.ToInt64(reader["EstimateID"]);
                }
                return EstID;
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

        public bool UpdateEstimateDetail(long estimateId, FinalAccountDetailDTO item)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_UpdateEstimateDetailAccount]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", estimateId));
                cmd.Parameters.Add(new SqlParameter("@MaterialID", item.MaterialID));
                cmd.Parameters.Add(new SqlParameter("@QuantityReal", item.QuantityEst));
                cmd.Parameters.Add(new SqlParameter("@UnitCostReal", item.UnitCost));
                cmd.Parameters.Add(new SqlParameter("@TotalCostReal", item.TotalCost));
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

        public bool UpdateEstimateTotalRealCost(long estimateId)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_UpdateTotalRealCost]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", estimateId));
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
