using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data;
using Gestion_Ventes.DAL;

namespace Gestion_Ventes.BL
{
    class CLS_CUSTOMERS
    {
        public DataTable All_CITY()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("All_CITY", null);
            return dt;
        }

        public DataTable ALL_CUSTOMERS()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ALL_CUSTOMERS", null);
            return dt;
        }


        public void ADD_COSTOMERS(string nom_client, string prn_client, int tele, string email, byte[] image, int city_id)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@NOM_CLIENT", SqlDbType.VarChar, 30);
            param[0].Value = nom_client;

            param[1] = new SqlParameter("@PRN_CLIENT", SqlDbType.VarChar, 30);
            param[1].Value = prn_client;

            param[2] = new SqlParameter("@TEL_CLIENT", SqlDbType.Int);
            param[2].Value = tele;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 50);
            param[3].Value = email;

            param[4] = new SqlParameter("@IMAGE_CLIENT", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@CITY_ID", SqlDbType.Int);
            param[5].Value = city_id;

            dal.ExecutCommand("ADD_COSTOMERS", param);
            dal.Close();


        }

        public void UPDATE_COSTOMERS(string nom_client, string prn_client, int tele, string email, byte[] image, int city_id, int id)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@NOM_CLIENT", SqlDbType.VarChar, 30);
            param[0].Value = nom_client;

            param[1] = new SqlParameter("@PRN_CLIENT", SqlDbType.VarChar, 30);
            param[1].Value = prn_client;

            param[2] = new SqlParameter("@TEL_CLIENT", SqlDbType.Int);
            param[2].Value = tele;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 50);
            param[3].Value = email;

            param[4] = new SqlParameter("@IMAGE_CLIENT", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@CITY_ID", SqlDbType.Int);
            param[5].Value = city_id;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = id;

            dal.ExecutCommand("UPDATE_COSTOMERS", param);
            dal.Close();


        }

        public void DELETE_CLIENT(int ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            dal.ExecutCommand("DELETE_CLIENT", param);
            dal.Close();


        }


        public DataTable GET_IMG_CLIENT(int id_client)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id_client;
            dt = dal.SelectData("GET_IMG_CLIENT", param);
            return dt;
        }

        public DataTable SEARCH_CLIENT(string ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData("SEARCH_CLIENT", param);
            return dt;
        }



    }
}
