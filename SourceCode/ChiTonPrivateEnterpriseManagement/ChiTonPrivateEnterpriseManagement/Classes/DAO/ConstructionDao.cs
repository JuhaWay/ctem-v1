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


        public bool CreateConstruction(string constructionName, string description,String constructionAddress ,
                                       DateTime commencementDate, DateTime completionDate, long totalEstimateCost,
                                        string status)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionName", constructionName));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@constructionAddress", constructionAddress));
                cmd.Parameters.Add(new SqlParameter("@commencementDate", commencementDate));
                cmd.Parameters.Add(new SqlParameter("@completionDate", completionDate));
                cmd.Parameters.Add(new SqlParameter("@totalEstimateCost", totalEstimateCost));
                cmd.Parameters.Add(new SqlParameter("@status", status));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", true));
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



        internal bool UpdateConstrction(long constructionID,string constructionName, string description, String constructionAddress,
                                       DateTime commencementDate, DateTime completionDate, long totalEstimateCost,
                                        string status)
        {
            var cmd = new SqlCommand("[dbo].[Construction_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@constructionID", constructionID));
                cmd.Parameters.Add(new SqlParameter("@constructionName", constructionName));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@constructionAddress", constructionAddress));
                cmd.Parameters.Add(new SqlParameter("@commencementDate", commencementDate));
                cmd.Parameters.Add(new SqlParameter("@completionDate", completionDate));
                cmd.Parameters.Add(new SqlParameter("@totalEstimateCost", totalEstimateCost));
                cmd.Parameters.Add(new SqlParameter("@status", status));
                cmd.Parameters.Add(new SqlParameter("@hasEstimate", true));

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
