using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Pekara
{
    public class Pekara
    {
        SqlConnection conn = new SqlConnection();
        string webConfig = ConfigurationManager.ConnectionStrings["Pekara"].ConnectionString;
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public int Unos_Pecivo(string naziv, string cena, string ukus, string kolicina)
        {
            conn.ConnectionString = webConfig;
            int rezultat;
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "dbo.Pecivo_Insert";
            // kolekcija Parameters
            comm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, naziv));
            comm.Parameters.Add(new SqlParameter("@cena", SqlDbType.Int, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cena));
            comm.Parameters.Add(new SqlParameter("@ukus", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, ukus));
            comm.Parameters.Add(new SqlParameter("@kolicina", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, kolicina));
            comm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 40, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            int Ret;
            Ret = (int)comm.Parameters["@RETURN_VALUE"].Value;
            if (Ret == 0)
            {
                rezultat = 0;
            }

            else
            {
                rezultat = 1;
            }
            return rezultat;
        }

        public DataSet Pecivo()
        {
            conn.ConnectionString = webConfig;
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "Peciva_svi";
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            da.SelectCommand = comm;
            da.Fill(ds);


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return (ds);
        }

        public int Bacanje_Pecivo(string naziv)
        {

            conn.ConnectionString = webConfig;
            int rezultat;

            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "dbo.Pecivo_delete";
            // kolekcija Parameters
            comm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, naziv));
            comm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();


            int Ret;
            Ret = (int)comm.Parameters["@RETURN_VALUE"].Value;
            if (Ret == 0)
            {
                rezultat = 0;
            }

            else
            {
                rezultat = 1;
            }
            return rezultat;
        }

        public int Izmena_Pecivo(int id_pecivo, string naziv, int cena, string ukus, int kolicina)
        {

            conn.ConnectionString = webConfig;
            //int rezultat;

            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "dbo.Pecivo_update";
            // kolekcija Parameters
            comm.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, id_pecivo));
            comm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, naziv));
            comm.Parameters.Add(new SqlParameter("@cena", SqlDbType.Int, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cena));
            comm.Parameters.Add(new SqlParameter("@ukus", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, ukus));
            comm.Parameters.Add(new SqlParameter("@kolicina", SqlDbType.Int, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, kolicina));
            comm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();


            int Ret;
            Ret = (int)comm.Parameters["@RETURN_VALUE"].Value;
            /*if (Ret == 0)
            {
                rezultat = 0;
            }
            else
            {
                rezultat = 1;
            }*/
            return Ret;
        }
    }
}