using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class Membre
    {
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Pays { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Membre(int IdMembre, string nom, string prenom, string email, int pays, string telephone, string login, string password)
        {
            idMembre = IdMembre;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Pays = pays;
            Telephone = telephone;
            Login = login;
            Password = password;

        }

        public void AddMembreBienEchange(DateTime dateDebut, BienEchange bienEchange)
        {
            throw new NotImplementedException();
        }

        public void CancelMembreBienEchange(MembreBienEchange membreBienEchange)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<MembreBienEchange> MembreBienEchanges { get; set; }
    }
}
