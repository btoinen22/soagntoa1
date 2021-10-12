using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace soagntoa1.Models
{
    class Personne
    {
        #region attributs

        private int _id;
        private string _nom;
        private string _prenom;
        private DateTime _datenaissance;
        private int _numeroDeTelephone;
        private string _email;
        private string _motDePasse;

        #endregion

        #region getter/setter

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public DateTime Datenaissance { get => _datenaissance; set => _datenaissance = value; }
        public int NumeroDeTelephone { get => _numeroDeTelephone; set => _numeroDeTelephone = value; }
        public string Email { get => _email; set => _email = value; }
        public string MotDePasse { get => _motDePasse; set => _motDePasse = value; }

        #endregion

        #region constructeur

        public Personne()
        {
            
        }

        #endregion

        #region méthode
        #endregion
    }
}
