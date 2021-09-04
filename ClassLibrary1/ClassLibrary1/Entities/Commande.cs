using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.Entities
{
   public class Commande
    {
        #region Attributs 
        private String _codeCmd;
        private string _dateCmd;
        private String _codeClt;

        #endregion
        public Commande(string codeCmd, string dateCmd, String codeClt)
        {
            _codeCmd = codeCmd;
            _dateCmd = dateCmd;
            _codeClt = codeClt;
        }
       
        #region Proprietes 
        public string CodeCmd {
            get { return _codeCmd; }
            set { _codeCmd = value; }
        }
        public string DateCmd {
            get { return _dateCmd; }
            set { _dateCmd = value; }
        }
        public String CodeClt
        {
            get { return _codeClt; }
            set { _codeClt = value; }
        }

       
        #endregion
    }
}
