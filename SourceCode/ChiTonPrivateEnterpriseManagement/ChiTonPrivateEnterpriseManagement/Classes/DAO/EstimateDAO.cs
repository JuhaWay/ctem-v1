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

        // load toan bo du toan --------------------------------------------------------------
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


        // load toan bo du toan --------------------------------------------------------------
        public List<EstimateDTO> search(EstimateDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if (!dto.EstimateName.Equals(""))
                cmd.Parameters.Add(new SqlParameter("@Name", "%" + dto.EstimateName + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));

            if (dto.ConstructionID > 0)
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
            else
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", DBNull.Value));
            List<EstimateDTO> listcons = new List<EstimateDTO>();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                
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

        // load du toán theo công trình --------------------------------------------------------------
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

        //Tạo dự toán--------------------------------------------------------------
        public bool CreateEstimate(EstimateDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@estimateName", dto.EstimateName));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", dto.TotalCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@totalCostReal", dto.TotalCostReal));
                cmd.Parameters.Add(new SqlParameter("@type", dto.Type));
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
        //sửa dự toán--------------------------------------------------------------
        public bool UpdateEstimate(long EstimateID)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_UpdateTotalCost]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", EstimateID));
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
        //sửa tên dự toán--------------------------------------------------------------
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
        //sửa tên dự toán--------------------------------------------------------------
        public bool UpdateNameForSub(EstimateDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Estimate_UpdateForSub]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ConstructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@TotalCostEstimate",dto.TotalCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@TotalCostReal",dto.TotalCostReal));

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
        //xóa dự toán--------------------------------------------------------------
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
    }
}
