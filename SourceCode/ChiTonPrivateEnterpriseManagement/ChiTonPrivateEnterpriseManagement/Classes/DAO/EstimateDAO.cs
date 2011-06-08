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
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        EstimateName = Convert.ToString(reader["EstimateName"]),
                        TotalCostEstimate = Convert.ToInt64(reader["TotalCostEstimate"]),
                        TotalCostReal = Convert.ToInt64(reader["TotalCostReal"]),
                        CreatedBy = Convert.ToString(reader["CreatedBy"]),
                        UpdatedBy = Convert.ToString(reader["UpdatedBy"]),
                        CreatedDate= Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedDate= Convert.ToDateTime(reader["UpdatedDate"])
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
                cmd.Parameters.Add(new SqlParameter("@createdDate", new DateTime(2011,06,01)));
                cmd.Parameters.Add(new SqlParameter("@updatedDate", new DateTime(2011, 06, 01)));
                cmd.Parameters.Add(new SqlParameter("@createdBy", CreatedBy));
                cmd.Parameters.Add(new SqlParameter("@updatedBy", UpdatedBy));
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

    }
}
