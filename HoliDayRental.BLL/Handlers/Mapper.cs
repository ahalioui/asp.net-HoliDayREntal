using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = HoliDayRental.BLL.Entities;
using D = HoliDayRental.DAL.Entities;

namespace HoliDayRental.BLL.Handlers
{
    public static class Mapper
    {
        public static B.Membre ToBLL(this D.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre(
                entity.idMembre,
                entity.Nom,
                entity.Prenom,
                entity.Email,
                entity.Pays,
                entity.Telephone,
                entity.Login,
                entity.Password);

        }
        public static D.Membre ToDAL(this B.Membre entity)
        {
            if (entity == null) return null;
            return new D.Membre
            {
                idMembre = entity.idMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password
            };
        }
        public static B.BienEchange ToBLL(this D.BienEchange entity)
        {
            if (entity == null) return null;
            return new B.BienEchange(
                entity.idBien,
                entity.titre,
                entity.DescCourte,
                entity.DescLong,
                entity.NombrePerson,
                entity.Pays,
                entity.Ville,
                entity.Rue,
                entity.Numero,
                entity.CodePostal,
                entity.Photo,
                entity.AssuranceObligatoire,
                entity.isEnabled,
                entity.GetDisabledDate(),
                entity.Latitude,
                entity.Longitude,
                entity.idMembre,
                entity.DateCreation);
        }
        public static D.BienEchange ToDAL(this B.BienEchange entity)
        {
            if (entity == null) return null;
            return new D.BienEchange
            {
                idBien = entity.idBien,
                titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                Pays = entity.Pays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                isEnabled = entity.isEnabled,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre = entity.idMembre,
                DateCreation = entity.DateCreation
            };
        }
        public static B.MembreBienEchange ToBLL(this D.MembreBienEchange entity)
        {
            if (entity == null) return null;
            return new B.MembreBienEchange(
                entity.idMembre,
                entity.idBien,
                entity.DateDebEchange,
                entity.DateFinEchange,
                entity.Assurance,
                entity.Valide);
        }
        public static D.MembreBienEchange ToDAL(this B.MembreBienEchange entity)
        {
            if (entity == null) return null;
            return new D.MembreBienEchange
            {
                idBien = entity.idBien,
                idMembre = entity.idMembre,
                DateDebEchange = entity.DateDebEchange,
                DateFinEchange = entity.DateFinEchange,
                Assurance = (bool)entity.Assurance,
                Valide = entity.Valide
            };
        }
            
    }

}
