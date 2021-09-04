using DAOGestionCommande.Connexion;
using DAOGestionCommande.DAO.IDAO;
using DAOGestionCommande.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace DAOGestionCommande.DAO.DAOImp
{
    public class DAOImpCommand : IDAOCommande
    {


        MySqlCommand cmd = null;
        ConnexionBD connexion;
        MySqlConnection conn;



        public DAOImpCommand(String chaineConnexion)
        {
            connexion = ConnexionBD.getDbInstance();
            conn = connexion.GetDBConnection(chaineConnexion);
            cmd = new MySqlCommand();



        }
        public void AjouterCommande(Commande Command)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into commande (CodeCmd,DateCmd,CodeClt) values(?,?,?)";
            cmd.Parameters.Add("CodeCmd", MySqlDbType.VarChar).Value = Command.CodeCmd;
            cmd.Parameters.Add("DateCmd", MySqlDbType.VarChar).Value = Command.DateCmd;
            cmd.Parameters.Add("CodeClt", MySqlDbType.VarChar).Value = Command.CodeClt;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ModiferCommande(string CodeCmd)
        {
            throw new NotImplementedException();
        }

        public Commande RechercherCommande(string CodeCmd)
        {
            throw new NotImplementedException();
        }

        public bool supprimerCommmande(string CodeCmd)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Delete from commande where CodeCmd='"+CodeCmd+"';";
            int i=cmd.ExecuteNonQuery();
            conn.Close();
            if (i!=-1)
            return true;

            return false;
        }

        public List<Commande> Liste_Commande()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from commande";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            List<Commande> Liste_Commande = new List<Commande>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Commande wcommande = new Commande(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToString(dr.GetValue(2)));
                    Liste_Commande.Add(wcommande);
                }
               
            }
              dr.Close();
              conn.Close();
             
            return Liste_Commande;
        }
    }
}
