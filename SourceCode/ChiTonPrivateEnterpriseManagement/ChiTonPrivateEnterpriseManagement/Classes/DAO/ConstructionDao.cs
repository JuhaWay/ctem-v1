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
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        TotalEstimateCost = Convert.ToInt64(reader["TotalEstimateCost"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"])
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
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
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
        public bool CreateConstruction(ConstructionDTO dto)
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
                cmd.Parameters.Add(new SqlParameter("@totalEstimateCost", dto.TotalEstimateCost));
                cmd.Parameters.Add(new SqlParameter("@status", dto.Status));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", dto.HasEstimate));
                cmd.Parameters.Add(new SqlParameter("@parentID", dto.ParentID));
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
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        SubconstractorID = Convert.ToInt64(reader["SubconstractorID"])
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
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"]),
                        TotalEstimateCost = Convert.ToInt64(reader["TotalEstimateCost"]),
                        HasEstimate = Convert.ToBoolean(reader["HasEstimate"]),
                        ParentID = Convert.ToInt64(reader["ParentID"])
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



        public ConstructionDTO LoadConstructionByName(string name)
        {
            var cmd = new SqlCommand("[dbo].[Construction_GetByName]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@constructionName", name));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ConstructionDTO consDto = new ConstructionDTO
                    {
                        ConstructionID = Convert.ToInt64(reader["ConstructionID"]),
                        ConstructionName = Convert.ToString(reader["ConstructionName"]),
                        Description = Convert.ToString(reader["Description"]),
                        ConstructionAddress = Convert.ToString(reader["ConstructionAddress"]),
                        CommencementDate = Convert.ToDateTime(reader["CommencementDate"]),
                        CompletionDate = Convert.ToDateTime(reader["CompletionDate"])
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
                cmd.Parameters.Add(new SqlParameter("@totalEstimateCost", dto.TotalEstimateCost));
                cmd.Parameters.Add(new SqlParameter("@status", dto.Status));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", dto.HasEstimate));

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
    }


}
