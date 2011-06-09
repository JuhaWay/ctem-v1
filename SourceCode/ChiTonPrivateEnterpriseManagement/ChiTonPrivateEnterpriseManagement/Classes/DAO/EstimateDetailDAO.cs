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
                        EstimateDetailID = Convert.ToInt64(reader["EstimateDetailID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        EstimateID = Convert.ToInt64(reader["EstimateID"]),
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        QuantityEstimate = Convert.ToInt32(reader["QuantityEstimate"]), 
                        UnitCostEstimate = Convert.ToInt32(reader["UnitCostEstimate"]),
                        TotalCostEstimate = Convert.ToInt64(reader["TotalCostEstimate"])
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


        public bool CreateEstimateDetail(long estimateID, long materialID, long quantityEstimate,
                                       long unitCostEstimate, long totalCostEstimate)
        {
            var cmd = new SqlCommand("[dbo].[EstimateDetail_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@estimateID", estimateID));
                cmd.Parameters.Add(new SqlParameter("@materialID", materialID));
                cmd.Parameters.Add(new SqlParameter("@quantityEstimate", quantityEstimate));
                cmd.Parameters.Add(new SqlParameter("@unitCostEstimate", unitCostEstimate));
                cmd.Parameters.Add(new SqlParameter("@totalCostEstimate", totalCostEstimate));
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
