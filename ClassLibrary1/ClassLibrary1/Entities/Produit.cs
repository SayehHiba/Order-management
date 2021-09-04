using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.Entities
{
   public  class Produit
    {

        #region Attributs 
        private string _codeProd;
        private string _libelleProd;
        private double _prixUnitaire;
        private int _qteStock;




        #endregion

        public Produit(string codeProd, string libelleProd, double prixUnitaire, Int32 qteStock)
        {
            _codeProd = codeProd;
            _libelleProd = libelleProd;
            _prixUnitaire = prixUnitaire;
            _qteStock = qteStock;
        }


        #region Proprietes
        public string CodeProd { get { return _codeProd; }
            set { _codeProd = value; } }
        public string LibelleProd {get { return _libelleProd; }
            set { _libelleProd = value; }
        }
        public double PrixUnitaire { get { return _prixUnitaire; }
            set { _prixUnitaire = value; }
        }
        public int QteStock
        {
            get { return _qteStock; }
            set { _qteStock = value; }
        }
        #endregion
    }
}
