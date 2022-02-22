﻿using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Handlers
{
    public static class Mapper
    {
        public static Membre ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new Membre
            {
                idMembre = (int)record[nameof(Membre.idMembre)],
                Nom = (string)record[nameof(Membre.Nom)],
                Prenom = (string)record[nameof(Membre.Prenom)],
                Email = (string)record[nameof(Membre.Email)],
                Pays = (string)record[nameof(Membre.Pays)],
                Telephone = (int)record[nameof(Membre.Telephone)],
                Login = (string)record[nameof(Membre.Login)],
                Password = (string)record[nameof(Membre.Password)],
            };

        }
        
        public static BienEchange bienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new BienEchange
            {
                idBien = (int)record[nameof(BienEchange.idBien)],
                titre = (string)record[nameof(BienEchange.titre)],
                DesCourte = (string)record[nameof(BienEchange.DesCourte)],
                DesLong = (string)record[nameof(BienEchange.DesLong)],
                NombrePerson = (int)record[nameof(BienEchange.NombrePerson)],
                Pays = (string)record[nameof(BienEchange.Pays)],
                Ville = (string)record[nameof(BienEchange.Ville)],
                Rue = (string)record[nameof(BienEchange.Rue)],
                Numero = (int)record[nameof(BienEchange.Numero)],
                CodePostal = (int)record[nameof(BienEchange.CodePostal)],
                Photo = (string)record[nameof(BienEchange.Photo)],
                AssuranceObligatoire = (bool)record[nameof(BienEchange.AssuranceObligatoire)],
                isEnabled = (bool)record[nameof(BienEchange.isEnabled)],
                DisabledDate = (DateTime)record[nameof(BienEchange.DisabledDate)],
                Latitude = (string)record[nameof(BienEchange.Latitude)],
                Longitude = (string)record[nameof(BienEchange.Longitude)],
                idMembre = (int)record[nameof(BienEchange.idMembre)],
                DateCreation = (DateTime)record[nameof(BienEchange.DateCreation)],
            };
        }
        public static MembreBienEchange ToMembreBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new MembreBienEchange
            {
                idMembre = (int)record[nameof(MembreBienEchange.idMembre)],
                idBien = (int)record[nameof(MembreBienEchange.idBien)],
                DateDebEchange = (DateTime)record[nameof(MembreBienEchange.DateDebEchange)],
                DateFinEchange = (DateTime)record[nameof(MembreBienEchange.DateFinEchange)],
                Assurance = (bool)record[nameof(MembreBienEchange.Assurance)],
                Valide = (bool)record[nameof(MembreBienEchange.Valide)],
            };
        }
        public static AvisMembreBien ToAvisMembreBien(IDataRecord record)
        {
            if (record is null) return null;
            return new AvisMembreBien
            {
                idAvis = (int)record[nameof(AvisMembreBien.idAvis)],
                note = (int)record[nameof(AvisMembreBien.note)],
                message = (string)record[nameof(AvisMembreBien.message)],
                idMembre = (int)record[nameof(AvisMembreBien.idMembre)],
                idBien = (int)record[nameof(AvisMembreBien.idBien)],
                DateAvis = (DateTime)record[nameof(AvisMembreBien.DateAvis)],
                Approuve = (bool)record[nameof(AvisMembreBien.Approuve)],
            };
        }
        public static Options ToOptions(IDataRecord record)
        {
            if (record is null) return null;
            return new Options
            {
                idOption = (int)record[nameof(Options.idOption)],
                Libelle = (string)record[nameof(Options.Libelle)],
            };
        }
        public static Pays ToPays(IDataRecord record)
        {
            if (record is null) return null;
            return new Pays
            {
                idPays = (int)record[nameof(Pays.idPays)],
                Libelle = (string)record[nameof(Pays.Libelle)],
            };
        }
        public static OptionsBien ToOptionsBien(IDataRecord record)
        {
            if (record is null) return null;
            return new OptionsBien
            {
                idOption = (int)record[nameof(OptionsBien.idOption)],
                idBien = (int)record[nameof(OptionsBien.idBien)],
                Valeur = (string)record[nameof(OptionsBien.Valeur)],
            };
        }

    }
}