using HoliDayRental.BLL.Entities;
using HoliDayRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Handlers
{
    public static class Mapper
    {
        public static MembreListItem ToListItem(this Membre entity)
        {
            if (entity == null) return null;
            return new MembreListItem
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
        public static MembreDetails ToDetails(this Membre entity)
        {
            if (entity == null) return null;
            return new MembreDetails
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
        public static BienEchangeDetails ToDetails(this BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEchangeDetails
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
        public static BienEchangeListItem ToListItem(this BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEchangeListItem
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
        public static BienEchangeEditForm ToEditForm(this BienEchange entity)
        {
            if (entity is null) return null;
            return new BienEchangeEditForm
            {

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
        public static BienEchangeDeleteForm ToDeleteForm(this BienEchange entity)
            {
                if (entity is null) return null;
                return new BienEchangeDeleteForm
                {
                    titre = entity.Titre,
                    DescCourte = entity.DescCourte,
                    Pays = entity.Pays,
                    Ville = entity.Ville,
                    Validate = false
                };

            }
    }
}
