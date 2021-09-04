using System;
using System.Collections.Generic;
using System.Text;
using DAOGestionCommande.Entities;
namespace DAOGestionCommande.DAO.IDAO
{
    interface IDAOClient
    {

        void AjouterClient(Client clt);
        Client rechercherClient(String CodeClt);
         
        List<Client> List_Client();
    }
}
