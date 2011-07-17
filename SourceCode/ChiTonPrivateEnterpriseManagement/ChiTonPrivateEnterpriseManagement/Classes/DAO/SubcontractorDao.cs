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
    class SubcontractorDao
    {


        public SubcontractorDao()
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


        public long CreateSubcontractor(string subcontractorName, string subcontractorAddress, string phoneNumber)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_Create]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@subcontractorName", subcontractorName));
                cmd.Parameters.Add(new SqlParameter("@subcontractorAddress", subcontractorAddress));
                cmd.Parameters.Add(new SqlParameter("@phoneNumber", phoneNumber));
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

        public bool updateSubcontractor(SubcontractorDTO  dto)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_Update]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@subcontractorID", dto.SubcontractorID));
                cmd.Parameters.Add(new SqlParameter("@subcontractorName",dto.SubcontractorName));
                cmd.Parameters.Add(new SqlParameter("@subcontractorAddress",dto.SubcontractorAddress));
                cmd.Parameters.Add(new SqlParameter("@phoneNumber", dto.PhoneNumber));
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


        public bool deleteSubcontractor(long id)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_delete]", Connection) { CommandType = CommandType.StoredProcedure };
            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            try
            {
                cmd.Parameters.Add(new SqlParameter("@subcontractorID", id));
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

        public List<SubcontractorDTO> LoadAllSubcontractor()
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_GetAll]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<SubcontractorDTO> listSubcons = new List<SubcontractorDTO>();
                while (reader.Read())
                {
                    SubcontractorDTO sconsDto = new SubcontractorDTO
                    {
                        SubcontractorID = Convert.ToInt64(reader["SubcontractorID"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        SubcontractorAddress = Convert.ToString(reader["SubcontractorAddress"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"])
                    };
                    listSubcons.Add(sconsDto);
                }
                return listSubcons;
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



        public List<SubcontractorDTO> search(string name)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_search]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            if (!name.Equals(""))
                     cmd.Parameters.Add(new SqlParameter("@Name","%"+ name+"%"));
            else
                     cmd.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
                    
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<SubcontractorDTO> listSubcons = new List<SubcontractorDTO>();
                while (reader.Read())
                {
                    SubcontractorDTO sconsDto = new SubcontractorDTO
                    {
                        SubcontractorID = Convert.ToInt64(reader["SubcontractorID"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        SubcontractorAddress = Convert.ToString(reader["SubcontractorAddress"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"])
                    };
                    listSubcons.Add(sconsDto);
                }
                return listSubcons;
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


        public SubcontractorDTO LoadSubcontractorById(long id)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_GetByID]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@subcontractorID", id));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SubcontractorDTO sconsDto = new SubcontractorDTO
                    {
                        SubcontractorID = Convert.ToInt64(reader["SubcontractorID"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        SubcontractorAddress = Convert.ToString(reader["SubcontractorAddress"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"])
                    };
                    return sconsDto;
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

        public SubcontractorDTO LoadSubcontractorByName(String name)
        {
            var cmd = new SqlCommand("[dbo].[Subcontractor_GetByName]", Connection);

            if (Transaction != null)
            {
                cmd.Transaction = Transaction;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@subcontractorName", name));
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SubcontractorDTO sconsDto = new SubcontractorDTO
                    {
                        SubcontractorID = Convert.ToInt64(reader["SubcontractorID"]),
                        SubcontractorName = Convert.ToString(reader["SubcontractorName"]),
                        SubcontractorAddress = Convert.ToString(reader["SubcontractorAddress"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"])
                    };
                    return sconsDto;
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
