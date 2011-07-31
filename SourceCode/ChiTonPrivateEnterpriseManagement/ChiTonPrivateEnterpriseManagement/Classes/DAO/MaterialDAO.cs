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
    class MaterialDAO
    {
        public MaterialDAO()
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


        public List<MaterialDTO> LoadAllMaterials()
        {
            var cmd = new SqlCommand("[dbo].[Material_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialDTO> listcons = new List<MaterialDTO>();
                while (reader.Read())
                {
                    MaterialDTO consDto = new MaterialDTO
                    {
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        MaterialParentID = Convert.ToInt64(reader["MaterialParentID"]),
                        EstimateCalUnit = Convert.ToString(reader["EstimateCalUnit"]),
                        RealCalUnit = Convert.ToString(reader["RealCalUnit"]),
                        Ratio = Convert.ToInt64(reader["Ratio"]),
       
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

        public List<MaterialDTO> search(string name)
        {
            var cmd = new SqlCommand("[dbo].[Material_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if(!name.Equals(""))
                cmd.Parameters.Add(new SqlParameter("@Name","%"+name+"%"));
            else
                cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialDTO> listcons = new List<MaterialDTO>();
                while (reader.Read())
                {
                    MaterialDTO consDto = new MaterialDTO
                    {
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        MaterialParentID = Convert.ToInt64(reader["MaterialParentID"]),
                        EstimateCalUnit = Convert.ToString(reader["EstimateCalUnit"]),
                        RealCalUnit = Convert.ToString(reader["RealCalUnit"]),
                        Ratio = Convert.ToInt64(reader["Ratio"]),

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

        public List<EstimateDetailDTO> LoadAllMaterialsEstimate(long consId)
        {
            var cmd = new SqlCommand("[dbo].[Material_GetMaterialEst]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ConsId", consId));
                SqlDataReader reader = cmd.ExecuteReader();
                List<EstimateDetailDTO> listcons = new List<EstimateDetailDTO>();
                while (reader.Read())
                {
                    EstimateDetailDTO consDto = new EstimateDetailDTO
                    {
                        EstimateDetailID = reader["EstimateDetailID"] != DBNull.Value ? Convert.ToInt64(reader["EstimateDetailID"]) : 0,
                        No = Convert.ToString(reader["No"]),
                        EstimateID = reader["EstimateID"] != DBNull.Value ? Convert.ToInt64(reader["EstimateID"]) : 0,
                        MaterialID = reader["MaterialID"] != DBNull.Value ? Convert.ToInt64(reader["MaterialID"]) : 0,
                        MaterialParentId = reader["MaterialParentID"] != DBNull.Value ? Convert.ToInt64(reader["MaterialParentID"]) : 0,
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        QuantityEstimate = reader["QuantityEstimate"] != DBNull.Value ? Convert.ToDouble(reader["QuantityEstimate"]) : 0,
                        UnitCostEstimate = reader["UnitCostEstimate"] != DBNull.Value ? Convert.ToDouble(reader["UnitCostEstimate"]) : 0,
                        TotalCostEstimate = reader["TotalCostEstimate"] != DBNull.Value ? Convert.ToDouble(reader["TotalCostEstimate"]) : 0,
                        QuantityReal = reader["QuantityReal"] != DBNull.Value ? Convert.ToDouble(reader["QuantityReal"]) : 0,
                        UnitCostReal = reader["UnitCostReal"] != DBNull.Value ? Convert.ToInt64(reader["UnitCostReal"]) : 0,
                        TotalCostReal = reader["TotalCostReal"] != DBNull.Value ? Convert.ToInt64(reader["TotalCostReal"]) : 0,
                        Note = Convert.ToString(reader["Note"]),
                        Status = Convert.ToString(reader["Status"]),
                        Name = Convert.ToString(reader["Name"]),
                        Type = Convert.ToString(reader["Type"])
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

        public bool CreateMaterials(MaterialDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Materital_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@MaterialName", dto.MaterialName));
                cmd.Parameters.Add(new SqlParameter("@MaterialParentID", dto.MaterialParentID));
                cmd.Parameters.Add(new SqlParameter("@EstimateCalUnit", dto.EstimateCalUnit));
                cmd.Parameters.Add(new SqlParameter("@RealCalUnit", dto.RealCalUnit));
                cmd.Parameters.Add(new SqlParameter("@Ratio", dto.Ratio));

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

        public bool UpdateMaterials(MaterialDTO dto)
        {
            var cmd = new SqlCommand("[dbo].[Material_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@MaterialID", dto.MaterialID));
                cmd.Parameters.Add(new SqlParameter("@MaterialName", dto.MaterialName));
                cmd.Parameters.Add(new SqlParameter("@MaterialParentID", dto.MaterialParentID));
                cmd.Parameters.Add(new SqlParameter("@EstimateCalUnit", dto.EstimateCalUnit));
                cmd.Parameters.Add(new SqlParameter("@RealCalUnit", dto.RealCalUnit));
                cmd.Parameters.Add(new SqlParameter("@Ratio", dto.Ratio));

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
        public bool deleteMaterials(long id)
        {
            var cmd = new SqlCommand("[dbo].[Material_Delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@MaterialID", id));
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

        public List<MaterialDTO> LoadMaterialbyWarehouseId(long warehousId)
        {
            var cmd = new SqlCommand("[dbo].[Material_GetByWarehouseId]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@WarehouseId", warehousId));
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialDTO> listcons = new List<MaterialDTO>();
                while (reader.Read())
                {
                    MaterialDTO consDto = new MaterialDTO
                    {
                        MaterialID = Convert.ToInt64(reader["MaterialID"]),
                        MaterialName = Convert.ToString(reader["MaterialName"]),
                        MaterialParentID = Convert.ToInt64(reader["MaterialParentID"]),
                        EstimateCalUnit = Convert.ToString(reader["EstimateCalUnit"]),
                        RealCalUnit = Convert.ToString(reader["RealCalUnit"]),
                        Ratio = Convert.ToInt64(reader["Ratio"]),

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
    }
}
