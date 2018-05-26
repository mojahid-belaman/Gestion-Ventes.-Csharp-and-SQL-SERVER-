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
    class CLS_Product
    {
        public DataTable All_Categorie()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("All_Categorie", null);
            return dt;
        }

        public void Add_Product(int id_produit, int id_cat, string nom_produit, int qte_stock, string prix, byte[] image)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_PRODUIT", SqlDbType.Int);
            param[0].Value = id_produit;

            param[1] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[1].Value = id_cat;

            param[2] = new SqlParameter("@NOM_PRODUIT", SqlDbType.VarChar, 40);
            param[2].Value = nom_produit;

            param[3] = new SqlParameter("@QTE_STOCK", SqlDbType.Int);
            param[3].Value = qte_stock;

            param[4] = new SqlParameter("@PRIX", SqlDbType.VarChar, 25);
            param[4].Value = prix;

            param[5] = new SqlParameter("@IMG_PRODUIT", SqlDbType.Image);
            param[5].Value = image;

            dal.ExecutCommand("ADD_PRODUCT", param);
            dal.Close();


        }

        public DataTable VERIFYPRODUCTID(int id_produit)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id_produit;
            dt = dal.SelectData("VERIFYPRODUCTID", param);
            return dt;
        }

        public DataTable All_Product()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("All_Product", null);
            return dt;
        }

        public DataTable Search_Produit(string id_produit)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id_produit;
            dt = dal.SelectData("Search_Produit", param);
            return dt;
        }

        public DataTable Search_Categorie(string ID_CAT)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID_CAT;
            dt = dal.SelectData("Search_Categorie", param);
            return dt;
        }

        public void DELETE_PRODUIT(int id_produit)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id_produit;

            dal.ExecutCommand("DELETE_PRODUIT", param);
            dal.Close();


        }

        public DataTable GET_IMG_PRODUCT(int id_produit)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id_produit;
            dt = dal.SelectData("GET_IMG_PRODUCT", param);
            return dt;
        }

        public void UPDATE_PRODUIT(int id_produit, int id_cat, string nom_produit, int qte_stock, string prix, byte[] image)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_PRODUIT", SqlDbType.Int);
            param[0].Value = id_produit;

            param[1] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[1].Value = id_cat;

            param[2] = new SqlParameter("@NOM_PRODUIT", SqlDbType.VarChar, 40);
            param[2].Value = nom_produit;

            param[3] = new SqlParameter("@QTE_STOCK", SqlDbType.Int);
            param[3].Value = qte_stock;

            param[4] = new SqlParameter("@PRIX", SqlDbType.VarChar, 25);
            param[4].Value = prix;

            param[5] = new SqlParameter("@IMG_PRODUIT", SqlDbType.Image);
            param[5].Value = image;

            dal.ExecutCommand("UPDATE_PRODUIT", param);
            dal.Close();


        }

    }
}
