using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.Classes.DAO
{
    class ConstructionDao
    {


        public ConstructionDao()
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


        public List<ConstructionDTO> LoadAllConstructions()
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ConstructionDTO> listcons = new List<ConstructionDTO>();
                while (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"]),
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




        public List<ConstructionDTO> SearchConstructions(ConstructionDTO param)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if (!param.ConstructionName.Trim().Equals(""))
                cmd.Parameters.Add(new SqlParameter("@Name", "%" +param.ConstructionName + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
            if (!param.Status.Trim().Equals("") && !param.Status.Trim().Equals("Tất cả"))
                cmd.Parameters.Add(new SqlParameter("@Status", "%" + param.Status + "%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Status", DBNull.Value));
            if (param.SubconstractorID>0)
                cmd.Parameters.Add(new SqlParameter("@SubcontractorID", param.SubconstractorID));
            else
                cmd.Parameters.Add(new SqlParameter("@SubcontractorID", DBNull.Value));

            if (param.ManagerID > 0)
                cmd.Parameters.Add(new SqlParameter("@ManagerID", param.ManagerID));
            else
                cmd.Parameters.Add(new SqlParameter("@ManagerID", DBNull.Value));

            cmd.Parameters.Add(new SqlParameter("@FromDate", param.FromDate));
            cmd.Parameters.Add(new SqlParameter("@ToDate", param.ToDate));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ConstructionDTO> listcons = new List<ConstructionDTO>();
                while (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        type = Convert.ToString(reader["Type"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                         ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"]),
                        TotalEstimateCost = reader["TotalCostEstimate"] != DBNull.Value ? 
                        Convert.ToInt64(reader["TotalCostEstimate"]) : 0,
                        TotalRealCost = reader["TotalCostReal"] != DBNull.Value ? 
                        Convert.ToInt64(reader["TotalCostReal"]) : 0,
                        ManagerName = Convert.ToString(reader["Username"]),
                        ManagerID = Convert.ToInt64(reader["ManagerID"]),
                        CreatedBy =  Convert.ToString(reader["CreatedBy"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                        
                    };

                    try
                    {
                        consDto.LastUpdated = Convert.ToDateTime(reader["LastUpdated"]);
                        consDto.LastUpdatedFormated = consDto.LastUpdated.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    }
                    catch (Exception e)
                    {
                        consDto.LastUpdatedFormated = "";
                    }

                    consDto.CreateDateFormated = consDto.CreatedDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.CommencementDateFormated = consDto.CommencementDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.CompletionDateFormated = consDto.CompletionDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.TotalEstimateCostFormated = Global.Global.ConvertLongToMoney(consDto.TotalEstimateCost,Constants.SPLIP_MONEY);
                    consDto.TotalRealCostFormated = Global.Global.ConvertLongToMoney(consDto.TotalRealCost, Constants.SPLIP_MONEY);
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

        public List<ConstructionDTO> LoadAllConstructionsHaveWarehouse()
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetHaveWarehouse]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ConstructionDTO> listcons = new List<ConstructionDTO>();
                while (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        WarehouseID = Convert.ToInt64(reader["WarehouseID"]),                        
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"])
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
      
        public ConstructionDTO LoadConstructionById(long id)
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetByID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@constructionID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        type = Convert.ToString(reader["Type"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        SubconstractorID = Convert.ToInt64(reader["SubcontractorID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"]),
                        ManagerName = Convert.ToString(reader["Username"]),
                        ManagerID = Convert.ToInt64(reader["ManagerID"]),
                        TotalEstimateCost = reader["TotalCostEstimate"] != DBNull.Value ? Convert.ToInt64(reader["TotalCostEstimate"]) : 0,
                        TotalRealCost = reader["TotalCostReal"] != DBNull.Value ? Convert.ToInt64(reader["TotalCostReal"]) : 0,
                        CreatedBy = reader["CreatedBy"] != DBNull.Value ? Convert.ToString(reader["CreatedBy"]) : "",
                        CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : new DateTime(),
                        UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? Convert.ToString(reader["UpdatedBy"]) : "",
                        LastUpdated = reader["LastUpdated"] != DBNull.Value ? Convert.ToDateTime(reader["LastUpdated"]) : new DateTime()

                    };
                    return consDto;
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

        public List<ConstructionDTO> LoadChildenById(long id)
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetChildren]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            List<ConstructionDTO> listcons = new List<ConstructionDTO>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@constructionID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        type = Convert.ToString(reader["Type"]),
                        SubcontractorName = reader["SubcontractorName"] != DBNull.Value ? 
                        Convert.ToString(reader["SubcontractorName"]) : Constants.EMPTY_TEXT,
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"]),
                        TotalEstimateCost = reader["TotalCostEstimate"] != DBNull.Value ?
                        Convert.ToInt64(reader["TotalCostEstimate"]) : 0,
                        TotalRealCost = reader["TotalCostReal"] != DBNull.Value ?
                        Convert.ToInt64(reader["TotalCostReal"]) : 0,
                        ManagerName = reader["Username"] != DBNull.Value ?
                        Convert.ToString(reader["Username"]) : Constants.EMPTY_TEXT,
                        ManagerID = reader["ManagerID"] != DBNull.Value?
                        Convert.ToInt64(reader["ManagerID"]) : 0,
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"])
                    };

                    try
                    {
                        consDto.LastUpdated = Convert.ToDateTime(reader["LastUpdated"]);
                        consDto.LastUpdatedFormated = consDto.LastUpdated.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    }
                    catch (Exception e)
                    {
                        consDto.LastUpdatedFormated = "";
                    }

                    consDto.CreateDateFormated = consDto.CreatedDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.CommencementDateFormated = consDto.CommencementDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.CompletionDateFormated = consDto.CompletionDate.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                    consDto.TotalEstimateCostFormated = Global.Global.ConvertLongToMoney(consDto.TotalEstimateCost, Constants.SPLIP_MONEY);
                    consDto.TotalRealCostFormated = Global.Global.ConvertLongToMoney(consDto.TotalRealCost, Constants.SPLIP_MONEY);
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

        public long CreateConstruction(ConstructionDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionName", dto.ConstructionName));
                cmd.Parameters.Add(new SqlParameter("@subconstractorID", dto.SubconstractorID));
                cmd.Parameters.Add(new SqlParameter("@description", dto.Description));
                cmd.Parameters.Add(new SqlParameter("@constructionAddress", dto.ConstructionAddress));
                cmd.Parameters.Add(new SqlParameter("@commencementDate", dto.CommencementDate));
                cmd.Parameters.Add(new SqlParameter("@completionDate", dto.CompletionDate));
                cmd.Parameters.Add(new SqlParameter("@status", dto.Status));
                cmd.Parameters.Add(new SqlParameter("@type", dto.type));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", dto.HasEstimate));
                cmd.Parameters.Add(new SqlParameter("@managerID", dto.ManagerID));
                cmd.Parameters.Add(new SqlParameter("@parentID", dto.ParentID));
                cmd.Parameters.Add(new SqlParameter("@createdBy", Global.Global.CurrentUser.Username));
                cmd.Parameters.Add(new SqlParameter("@progressRate", dto.ProgressRate));
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


        internal bool UpdateConstruction(ConstructionDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", dto.ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@subconstractorID", dto.SubconstractorID));
                cmd.Parameters.Add(new SqlParameter("@constructionName", dto.ConstructionName));
                cmd.Parameters.Add(new SqlParameter("@description", dto.Description));
                cmd.Parameters.Add(new SqlParameter("@constructionAddress", dto.ConstructionAddress));
                cmd.Parameters.Add(new SqlParameter("@commencementDate", dto.CommencementDate));
                cmd.Parameters.Add(new SqlParameter("@completionDate", dto.CompletionDate));
                cmd.Parameters.Add(new SqlParameter("@status", dto.Status));
                cmd.Parameters.Add(new SqlParameter("@managerID", dto.ManagerID));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", dto.HasEstimate));
                cmd.Parameters.Add(new SqlParameter("@progressRate", dto.ProgressRate));
                cmd.Parameters.Add(new SqlParameter("@updatedBy",Global.Global.CurrentUser.Username));
                

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
        internal bool UpdateConstructionTotalEstimateCost(long ConstructionID, long TotalEstimateCost)
        {
            var cmd = new SqlCommand("[dbo].[Construction_UpdateTotalEstimateCost]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID",ConstructionID));
                cmd.Parameters.Add(new SqlParameter("@totalEstimateCost",TotalEstimateCost));

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

        public bool UpdateConstructionTotal(long ConstructionID)
        {
            var cmd = new SqlCommand("[dbo].[Construction_UpdateTotal]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", ConstructionID));
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



        internal bool DeleteConstruction(long ConstructionID)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", ConstructionID));
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

        public List<ConstructionDTO> GetAllConstructionParentandChildren()
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetAllParentandChildren]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ConstructionDTO> listcons = new List<ConstructionDTO>();
                while (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"]),
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

        public ConstructionDTO LoadConstructionReportByName(string consName)
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetReportByName]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionName", consName));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        Status = Convert.ToString(reader["Status"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        ProgressRate = Convert.ToInt64(reader["ProgressRate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"])                        
                    };
                    try
                    {
                        consDto.TotalMachineCost = Convert.ToInt64(reader["TotalMachineCost"]);
                        consDto.TotalWorkerCost = Convert.ToInt64(reader["TotalWorkerCost"]);
                        consDto.TotalMaterialCost = Convert.ToInt64(reader["TotalMaterialCost"]);
                        consDto.TotalCostsIncurred = Convert.ToInt64(reader["TotalCostsIncurred"]);
                    }
                    catch
                    {
                    }
                    return consDto;
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
    }


}
