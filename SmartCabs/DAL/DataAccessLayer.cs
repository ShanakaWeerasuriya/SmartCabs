using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartCabs.DAL
{
    public class DataAccessLayer
    {
        #region Properties & Variable Declarations
        private string connection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;



        public string Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        #endregion



        //public bool spExecuteWithReturnValue(string spName, List<SqlParameter> spParameters)
        //{
        //    try
        //    {
        //        using (con = new SqlConnection(connection))
        //        {
        //            cmd = new SqlCommand(spName, con);
        //            cmd.CommandType = CommandType.StoredProcedure;


        //            foreach (SqlParameter parameter in spParameters)
        //            {
        //                cmd.Parameters.Add(parameter);
        //            }

        //            con.Open();

        //            return (Convert.ToBoolean(cmd.ExecuteScalar()));
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}


        public DataTable PopulateDropDown(string command)
        {
            DataTable dt = new DataTable();

            try
            {
                using (con = new SqlConnection(connection))
                {

                    da = new SqlDataAdapter(command, con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int ReturnCurrentReferance()
        {
            try
            {
                using (con = new SqlConnection(Connection))
                {
                    string sql = "Select Count(ReservationReferance) from [dbo].[Reservation] ";

                    cmd = new SqlCommand(sql, con);
                    return (Convert.ToInt16(cmd.ExecuteScalar()));
                }


            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }


        public void DriverDetails(string Name, out string VehicleNumber, out string MobileNumber)
        {
            try
            {
                using (con = new SqlConnection(Connection))
                {
                    cmd = new SqlCommand("Select Mobile,VehicleNumber from Driver where DriverName=@Name", con);
                    cmd.Parameters.AddWithValue("@Name", Name);

                    con.Open();

                    dr = cmd.ExecuteReader();

                    string VehicleNum = "";
                    string MobileNUm="";

                    while (dr.Read())
                    {
                        VehicleNum = dr["VehicleNumber"].ToString();
                        MobileNUm = dr["Mobile"].ToString();
                    }


                    VehicleNumber = VehicleNum;
                    MobileNumber = MobileNUm;
                }
                


            }
            catch (Exception)
            {

                throw;
            }


        }

        public string TravelerDetails(string Name)
        {
            try
            {
                using (con = new SqlConnection(Connection))
                {
                    cmd = new SqlCommand("Select Mobile from Traveller where CustomerName=@Name", con);
                    cmd.Parameters.AddWithValue("@Name", Name);

                    con.Open();
                    return cmd.ExecuteScalar().ToString();


                 
                }



            }
            catch (Exception)
            {

                throw;
            }


        }


        public bool spExecuteWithReturnValue(string spName, List<SqlParameter> spParameters)
        {
            try
            {
                using (con = new SqlConnection(connection))
                {
                    cmd = new SqlCommand(spName, con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    foreach (SqlParameter parameter in spParameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    con.Open();

                    return (Convert.ToBoolean(cmd.ExecuteNonQuery()));
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        public int spLogin(string spName, List<SqlParameter> spParameters)
        {
            try
            {
                using (con = new SqlConnection(connection))
                {
                    cmd = new SqlCommand(spName, con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    foreach (SqlParameter parameter in spParameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    con.Open();
                    return (cmd.ExecuteNonQuery());

                    
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable spExecuteWithReturnDataTable(string spName, List<SqlParameter> spParameters)
        {
            DataTable dt = new DataTable();

            try
            {
                using (con = new SqlConnection(connection))
                {

                    da = new SqlDataAdapter(spName, con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }


        public DataTable executeCommandWithReturnDataTable(string command)
        {

            DataTable dt = new DataTable();

            try
            {
                using (con = new SqlConnection(connection))
                {

                    da = new SqlDataAdapter(command, con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

