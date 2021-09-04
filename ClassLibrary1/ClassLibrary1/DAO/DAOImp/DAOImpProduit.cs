using DAOGestionCommande.Connexion;
using DAOGestionCommande.DAO.IDAO;
using DAOGestionCommande.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.DAO.DAOImp
{
    public class DAOImpProduit : IDAOProduit
    {
        MySqlCommand cmd = null;
        ConnexionBD connexion;
        MySqlConnection conn;
        public DAOImpProduit(String chaineConnexion)
        {
            connexion = ConnexionBD.getDbInstance();
            conn = connexion.GetDBConnection(chaineConnexion);
            cmd = new MySqlCommand();
        }

        public void ajouterProduit(Produit prod)
        {

            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into produit (CodeProd,LibelleProd,PrixUnitaire,QteStock) values(?,?,?,?)";
            cmd.Parameters.Add("CodeProd", MySqlDbType.VarChar).Value = prod.CodeProd;
            cmd.Parameters.Add("LibelleProd", MySqlDbType.VarChar).Value = prod.LibelleProd;
            cmd.Parameters.Add("PrixUnitaire", MySqlDbType.Double).Value = prod.PrixUnitaire;
            cmd.Parameters.Add("QteStock", MySqlDbType.Int32).Value = prod.QteStock;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void modifProduit(Produit prod)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE produit SET qtStock=" + prod.QteStock + " where codeprod='" + prod.CodeProd + "';";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Produit> Liste_produit()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from produit";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            List<Produit> Liste_Produit = new List<Produit>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Produit wProd = new Produit(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToDouble(dr.GetValue(2)), Convert.ToInt32(dr.GetValue(3)));
                    Liste_Produit.Add(wProd);
                }

            }

            dr.Close();
            conn.Close();

            return Liste_Produit;
        }

        public Produit rechercherProduit(string l)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from produit where 	libelle ='" + l + "';";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            Produit wProd = null;

            if (dr.Read())
                wProd = new Produit(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToDouble(dr.GetValue(2)), Convert.ToInt32(dr.GetValue(3)));

            dr.Close();
            conn.Close();

            return wProd;
        }

       
    }
}
