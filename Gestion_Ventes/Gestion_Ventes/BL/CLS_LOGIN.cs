using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Ventes.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string USERNAME, string PSW)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            param[0].Value = USERNAME;

            param[1] = new SqlParameter("@PSW", SqlDbType.VarChar, 50);
            param[1].Value = PSW;

            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_LOGIN", param);
            dal.Close();
            return dt;
        }

        public void ADD_USER(string USERNAME, string NAME, string PSW, string USERTYPE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            param[0].Value = USERNAME;

            param[1] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[1].Value = NAME;

            param[2] = new SqlParameter("@PSW", SqlDbType.VarChar, 50);
            param[2].Value = PSW;

            param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[3].Value = USERTYPE;

            dal.ExecutCommand("ADD_USER", param);
            dal.Close();


        }

        public void UPDATE_USER(string USERNAME, string NAME, string PSW, string USERTYPE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            param[0].Value = USERNAME;

            param[1] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[1].Value = NAME;

            param[2] = new SqlParameter("@PSW", SqlDbType.VarChar, 50);
            param[2].Value = PSW;

            param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[3].Value = USERTYPE;

            dal.ExecutCommand("UPDATE_USER", param);
            dal.Close();


        }


        public DataTable SEARCH_USER(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dt = dal.SelectData("SEARCH_USER", param);
            return dt;
        }

        public DataTable ALL_USER()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ALL_USER", null);
            return dt;
        }

        public DataTable DELETE_USER(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dt = dal.SelectData("DELETE_USER", param);
            return dt;
        }


    }
}
