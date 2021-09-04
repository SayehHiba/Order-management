using DAOGestionCommande.Connexion;
using DAOGestionCommande.DAO.IDAO;
using DAOGestionCommande.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.DAO.DAOImp
{
   public class DAOImpClient : IDAOClient
    {

        MySqlCommand cmd = null;
        ConnexionBD connexion;
        MySqlConnection conn;


        public DAOImpClient(String chaineConnexion)
        {
            connexion = ConnexionBD.getDbInstance();
            conn = connexion.GetDBConnection(chaineConnexion);
            cmd = new MySqlCommand();

        }
        public void AjouterClient(Client clt)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into client(codeClt,Nom,Prenom,Tel) values(?,?,?,?)";
            cmd.Parameters.Add("CodeClt", MySqlDbType.VarChar).Value = clt.CodeClt;
            cmd.Parameters.Add("Nom", MySqlDbType.VarChar).Value = clt.Nom;
            cmd.Parameters.Add("Prenom", MySqlDbType.VarChar).Value = clt.Prenom;
            cmd.Parameters.Add("Tel", MySqlDbType.VarChar).Value = clt.Tel;
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

       

        public Client rechercherClient(string CodeClt)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from clients where codeClt ='"+CodeClt+"';";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            Client wclt = null;
           
            if (dr.Read())
              wclt = new Client(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToString(dr.GetValue(2)), Convert.ToInt32(dr.GetValue(3)));

            dr.Close();
            conn.Close();
            
            return wclt;
        }

       


        public List<Client> List_Client()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from client";
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();
            List<Client> Liste_Client = new List<Client>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Client wclt= new Client(Convert.ToString(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToString(dr.GetValue(2)),  Convert.ToInt32(dr.GetValue(3)));
                    Liste_Client.Add(wclt);
                }

            }

            dr.Close();
            conn.Close();

            return Liste_Client;
        }

      
        
    }
}
