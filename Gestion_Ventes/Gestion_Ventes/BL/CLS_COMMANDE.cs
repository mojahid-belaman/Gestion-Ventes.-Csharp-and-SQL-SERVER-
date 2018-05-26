using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Gestion_Ventes.DAL;

namespace Gestion_Ventes.BL
{
    class CLS_COMMANDE
    {
        public DataTable LASR_COMMANDE_ID()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("LASR_COMMANDE_ID", null);
            return dt;
        }

        public DataTable LASR_ORDER_FOR_PRINT()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("LASR_ORDER_FOR_PRINT", null);
            return dt;
        }


        public void ADD_CMMANDE(int ID_CMD, int ID_CLIENT, DateTime DATE_CMD, string DESCRIPTION_CMD, string NOM_VENDU)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_CMD", SqlDbType.Int);
            param[0].Value = ID_CMD;

            param[1] = new SqlParameter("@ID_CLIENT", SqlDbType.Int);
            param[1].Value = ID_CLIENT;

            param[2] = new SqlParameter("@DATE_CMD", SqlDbType.Date);
            param[2].Value = DATE_CMD;

            param[3] = new SqlParameter("@DESCRIPTION_CMD", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_CMD;

            param[4] = new SqlParameter("@NOM_VENDU", SqlDbType.VarChar, 75);
            param[4].Value = NOM_VENDU;

            dal.ExecutCommand("ADD_CMMANDE", param);
            dal.Close();


        }

        public void ADD_CMD_DETAIL(int ID_PRODUIT, int ID_CMD, int QUANTITE, decimal PRICE, double DISCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUIT", SqlDbType.Int);
            param[0].Value = ID_PRODUIT;

            param[1] = new SqlParameter("ID_CMD", SqlDbType.Int);
            param[1].Value = ID_CMD;

            param[2] = new SqlParameter("@QUANTITE", SqlDbType.Int);
            param[2].Value = QUANTITE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.Money);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = TOTAL_AMOUNT;

            dal.ExecutCommand("ADD_CMD_DETAIL", param);
            dal.Close();


        }

        public DataTable VERIFY_QTE(int ID_PRODUIT, int QTE_ENTRER)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_PRODUIT", SqlDbType.Int);
            param[0].Value = ID_PRODUIT;

            param[1] = new SqlParameter("@QTE_ENTRER", SqlDbType.Int);
            param[1].Value = QTE_ENTRER;

            dt = dal.SelectData("VERIFY_QTE", param);
            return dt;
        }

        public DataTable GETORDERDETAIL(int ID_CMD)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_CMD;

            dt = dal.SelectData("GETORDERDETAIL", param);
            return dt;
        }

        public DataTable ALL_COMMANDE()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ALL_COMMANDE", null);
            return dt;
        }


        public DataTable SEARCH_COMMANDE(String ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dt = dal.SelectData("SEARCH_COMMANDE", param);
            return dt;
        }

        public void DELETE_Commande(int ID_CMD)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID_CMD;

            dal.ExecutCommand("DELETE_Commande", param);
            dal.Close();


        }

    }
}
