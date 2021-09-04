using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.Entities
{
   public class LigneCommande
    {
        #region Attributs 
        private string _codeCmd;
        private string _codeProd;
        private Int32 _qteCommande;
        #endregion
        public LigneCommande(string codeProd, string codeCmd, Int32 qteCommande)
        {
            CodeCmd = codeCmd;
            CodeProd = codeProd;
            QteCommande = qteCommande;
        }

        #region Proprietes 
        public string CodeCmd {  get { return _codeCmd; }
            set { _codeCmd = value; }}
        public string CodeProd
        {
            get { return _codeProd; }
            set { _codeProd = value; }
        }
        public Int32 QteCommande
        {
            get { return _qteCommande; }
            set { _qteCommande = value; }
        }
        #endregion
    }
}
