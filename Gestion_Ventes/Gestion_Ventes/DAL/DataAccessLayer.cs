using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Ventes.DAL
{
    class DataAccessLayer
    {
        SqlConnection ocon;

        //Constructor Initialize Connection Object
        public DataAccessLayer()
        {
            ocon = new SqlConnection("Server = DESKTOP-2DUERQC; Database = Gestion_Vente_DB; Integrated Security = true");
        }

        //Methode Open Connection
        public void Open()
        {
            if(ocon.State != ConnectionState.Open)
            {
                ocon.Open();
            }
        }

        //Methode Close Connection
        public void Close()
        {
            if (ocon.State == ConnectionState.Open)
            {
                ocon.Close();
            }
        }

        //Methode Read Data From Database
        
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = ocon;

            if (param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method Insert, Update, Delete Data From Database
        public void ExecutCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = ocon;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
