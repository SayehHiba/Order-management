using DAOGestionCommande.Connexion;
using DAOGestionCommande.DAO.IDAO;
using DAOGestionCommande.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAOGestionCommande.DAO.DAOImp
{
   public class DAOImpLigneCommande : IDAOLigneCommande
    {

        MySqlCommand cmd = null;
        ConnexionBD connexion;
        MySqlConnection conn;


        public DAOImpLigneCommande(String chaineConnexion)
        {
            connexion = ConnexionBD.getDbInstance();
            conn = connexion.GetDBConnection(chaineConnexion);
            cmd = new MySqlCommand();



        }
       public void del()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM ligcommande;";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void ajouterLigneCommande(LigneCommande lngCmd)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO ligcommande VALUES ('" + lngCmd.CodeProd + "','" + lngCmd.CodeCmd + "'," + lngCmd.QteCommande + ");" ;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void modiferLigneCommande(LigneCommande lngCmd)
        {
            cmd = conn.CreateCommand();
            string query = "UPDATE lignecommande SET QteCommande="+ lngCmd.QteCommande+" WHERE CodeProd ='"+lngCmd.CodeProd+"' and CodeCmd = '"+lngCmd.CodeCmd+"';";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public bool rechercherLigneCommande(string CodeProd,string CodeCmd)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from lignecommande where CodeProd ='" + CodeProd + "' and CodeCmd ='"+CodeCmd+"' ;";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            LigneCommande wLngCmd = null;

            if (dr.Read())
                wLngCmd = new LigneCommande(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)),Convert.ToInt32(dr.GetValue(2)));

            dr.Close();
            conn.Close();
            if (wLngCmd!=null)
                 return true;
            return false;
        }

        public List<LigneCommande> Liste_Ligne_Commande(string CodeCmd)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from lignecommande where CodeCmd='"+CodeCmd+"';";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            List<LigneCommande> Liste_lng_Commande = new List<LigneCommande>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    LigneCommande wlngcommande = new LigneCommande(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)));
                    Liste_lng_Commande.Add(wlngcommande);
                }

            }
            dr.Close();
            conn.Close();

            return Liste_lng_Commande;
        }



    }
}
