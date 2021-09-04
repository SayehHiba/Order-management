using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace DAOGestionCommande.Connexion
{
    class ConnexionBD
    {
        
            //"Server=localhost;Database=gestion_compte_bancaire;Uid=root;Pwd="
            private static ConnexionBD dbInstance;
            private readonly MySqlConnection conn;

            private ConnexionBD()
            {
                conn = new MySqlConnection();
            }

            public static ConnexionBD getDbInstance()
            {
                if (dbInstance == null)
                {
                    dbInstance = new ConnexionBD();
                }
                return dbInstance;
            }

            public MySqlConnection GetDBConnection(String chaineConnexionBD)
            {
                try
                {
                    conn.ConnectionString = chaineConnexionBD;
                    conn.Open();
                    Console.WriteLine("Connected");
                }
                catch (MySqlException e)
                { Console.WriteLine("you are not connected "); }

                return conn;
            }

        }
    
}
