using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DLL.Entities
{
    public class Membre
    {
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Pays { get; set; }
        public int Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Membre(int id, string nom, string prenom, string email, int pays, int telephone, string login, string password)
        {
            idMembre= id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Pays = pays;
            Telephone = telephone;
            Login = login;
            Password = password;
            
        }

        public void addMembreBienEchange(DateTime dateDebut, BienEchange bienEchange)

    }

}
