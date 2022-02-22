using HolidayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class BienEchangeService : ServiceBase, IBienEchangeRepository<BienEchange>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [BienEchange] WHERE [IdBien] = @id";
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    
                }
            }
        }
                    
        public IEnumerable<BienEchange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdBien], [Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisableDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange]";
                    
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }

        }

        public BienEchange Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdBien], Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisableDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange] WHERE [IdBien] = @id";
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToBienEchange(reader);
                    return null;
                }
                    
                    
            }
        }

        public BienEchange GetByMembreBienEchangeId(int MembreBienEchangeId)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [BienEchange].[IdBien], [Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisableDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange] JOIN [MembreBienEchange] ON [BienEchange].[IdBien] = [BienEchange_id] WHERE [MembreBienEchange].[IdBien] = @id";
                    //Parameters...
                    SqlParameter p_id = new SqlParameter("id", MembreBienEchangeId);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToBienEchange(reader);
                    return null;
                }
            }
        }


        public IEnumerable<BienEchange> GetByPays(int pays_id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdBien], [Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisableDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchanger] WHERE ([Pays]) = @pays ";
                    
                    SqlParameter p_pays = new SqlParameter("pays", pays_id);
                    command.Parameters.Add(p_pays);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                    
                }
            }
        }

        public int Insert(BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_BienEchange_Insert";
                    SqlParameter p_titre = new SqlParameter("titre", entity.titre);
                    SqlParameter p_DescCourte = new SqlParameter("DescCourte", entity.DescCourte);
                    SqlParameter p_DescLong = new SqlParameter("DescLong", entity.DescLong);
                    SqlParameter p_NombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
                    SqlParameter p_Pays = new SqlParameter("Pays", entity.Pays);
                    SqlParameter p_Ville = new SqlParameter("Ville", entity.Ville);
                    SqlParameter p_Rue = new SqlParameter("Rue", entity.Rue);
                    SqlParameter p_Numero = new SqlParameter("Numero", entity.Numero);
                    SqlParameter p_CodePostal = new SqlParameter("CodePostal", entity.CodePostal);
                    SqlParameter p_Photo = new SqlParameter("Photo", entity.Photo);
                    SqlParameter p_AssuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
                    SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.isEnabled);
                    SqlParameter p_DisableDate = new SqlParameter("DisableDate", entity.DisabledDate);
                    SqlParameter p_Latitude = new SqlParameter("Latitude", entity.Latitude);
                    SqlParameter p_Longitude = new SqlParameter("Longitude", entity.Longitude);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", entity.idMembre);
                    SqlParameter p_DateCreation = new SqlParameter("DateCreation", entity.DateCreation);
                    command.Parameters.Add(p_titre);
                    command.Parameters.Add(p_DescCourte);
                    command.Parameters.Add(p_DescLong);
                    command.Parameters.Add(p_NombrePerson);
                    command.Parameters.Add(p_Rue);
                    command.Parameters.Add(p_Numero);
                    command.Parameters.Add(p_CodePostal);
                    command.Parameters.Add(p_Photo);
                    command.Parameters.Add(p_AssuranceObligatoire);
                    command.Parameters.Add(p_isEnabled);
                    command.Parameters.Add(p_DisableDate);
                    command.Parameters.Add(p_Latitude);
                    command.Parameters.Add(p_Longitude);
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_DateCreation);
                    connection.Open();
               
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [BienEchange] SET [Titre] = @titre, [DescCourte] = @DescCourte, [DescLong] = @DescLong, [NombrePerson] = @NombrePerson, [Pays] = @Pays, [Ville] = @Ville, [Rue] = @Rue, [Numero] = @Numero, [CodePostal] = @CodePostal, [Photo] = @Photo, [AssuranceObligatoire] = @AssuranceObligatoire, [isEnabled] = @isEnabled, [DisableDate] = @DisableDate, [Latitude] = @Latitude, [Longitude] = @Longitude, [idMembre] = @idMembre, [DateCreation] = @DateCreation WHERE [IdBien] = @id";
                    SqlParameter p_titre = new SqlParameter("titre", entity.titre);
                    SqlParameter p_DescCourte = new SqlParameter("DescCourte", entity.DescCourte);
                    SqlParameter p_DescLong = new SqlParameter("DescLong", entity.DescLong);
                    SqlParameter p_NombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
                    SqlParameter p_Pays = new SqlParameter("Pays", entity.Pays);
                    SqlParameter p_Ville = new SqlParameter("Ville", entity.Ville);
                    SqlParameter p_Rue = new SqlParameter("Rue", entity.Rue);
                    SqlParameter p_Numero = new SqlParameter("Numero", entity.Numero);
                    SqlParameter p_CodePostal = new SqlParameter("CodePostal", entity.CodePostal);
                    SqlParameter p_Photo = new SqlParameter("Photo", entity.Photo);
                    SqlParameter p_AssuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
                    SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.isEnabled);
                    SqlParameter p_DisableDate = new SqlParameter("DisableDate", entity.DisabledDate);
                    SqlParameter p_Latitude = new SqlParameter("Latitude", entity.Latitude);
                    SqlParameter p_Longitude = new SqlParameter("Longitude", entity.Longitude);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", entity.idMembre);
                    SqlParameter p_DateCreation = new SqlParameter("DateCreation", entity.DateCreation);
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_titre);
                    command.Parameters.Add(p_DescCourte);
                    command.Parameters.Add(p_DescLong);
                    command.Parameters.Add(p_NombrePerson);
                    command.Parameters.Add(p_Rue);
                    command.Parameters.Add(p_Numero);
                    command.Parameters.Add(p_CodePostal);
                    command.Parameters.Add(p_Photo);
                    command.Parameters.Add(p_AssuranceObligatoire);
                    command.Parameters.Add(p_isEnabled);
                    command.Parameters.Add(p_DisableDate);
                    command.Parameters.Add(p_Latitude);
                    command.Parameters.Add(p_Longitude);
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_DateCreation);
                    command.Parameters.Add(p_id);                   
                    connection.Open();
                    command.ExecuteNonQuery();
                    
                    
                }
            }
        }
    }
}
