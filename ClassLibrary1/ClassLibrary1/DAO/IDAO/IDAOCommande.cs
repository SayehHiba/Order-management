using DAOGestionCommande.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAOGestionCommande.DAO.IDAO
{
    public interface IDAOCommande
    {
         void AjouterCommande(Commande command);
         Commande RechercherCommande(String CodeCmd);
         void ModiferCommande(String CodeCmd);
         bool supprimerCommmande(String CodeCmd);

          List<Commande> Liste_Commande();
         

    }
}
