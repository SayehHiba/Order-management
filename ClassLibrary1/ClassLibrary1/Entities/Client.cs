using System;
using System.Collections.Generic;
using System.Text;

namespace DAOGestionCommande.Entities
{
    public class Client
    {

        #region ATTRIBUTS
        private string _codeClt;
        private string _nom;
        private string _prenom;
        private Int32 _tel;

       public Client(string codeClt, string nom, string prenom, int tel)
        {
            _codeClt = codeClt;
            _nom = nom;
            _prenom = prenom;
            _tel = tel;
        }
        public Client()
        {
            _codeClt = null;
            _nom = null;
            _prenom = null;
            _tel = 0;
        }
        #endregion
        #region PROPRIETES


        public string CodeClt {  get { return _codeClt; }
            set { 
                if ((value == null)||(value ==""))
                { _codeClt = "vide"; }
                else
                _codeClt = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public int Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        #endregion
    }
}
