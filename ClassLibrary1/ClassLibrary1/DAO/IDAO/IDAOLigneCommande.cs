using DAOGestionCommande.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.DAO.IDAO
{
    public interface IDAOLigneCommande
    {

        void ajouterLigneCommande(LigneCommande lngCmd);
        bool rechercherLigneCommande(String CodeProd,string CodeCmd);
        void modiferLigneCommande(LigneCommande lngCmd);
        List<LigneCommande> Liste_Ligne_Commande(string CodeCmd);
        void del();
    }
}
