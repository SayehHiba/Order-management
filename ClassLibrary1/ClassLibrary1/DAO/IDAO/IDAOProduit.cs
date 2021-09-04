using DAOGestionCommande.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.DAO.IDAO
{
    public interface IDAOProduit
    {


        void ajouterProduit(Produit prod);
        Produit rechercherProduit(String CodeProd);

        List<Produit> Liste_produit();
       
    }
}
