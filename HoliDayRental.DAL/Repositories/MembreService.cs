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
    public class MembreService : ServiceBase, IMembreRepository<Membre>
    {
        public void Delete(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Membre] WHERE [IdMembre] = @IdMembre";
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "IdMembre", Value = idMembre };
                    command.Parameters.Add(p_idMembre);
                    command.ExecuteNonQuery();
                }
            }
        }

         public IEnumerable<Membre> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre], [Nom], [Prenom],[Email], [Pays], [Telephone], [Login],[Password] FROM [Membre]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }

            }
        }
        public Membre Get(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre], [Nom], [Prenom],[Email], [Pays], [Telephone], [Login],[Password] FROM [Membre] WHERE [IdMembre] = @idMembre";
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = idMembre };
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }
               
        public IEnumerable<Membre> GetByMembreBienEchange(int id_bienEchange)
        {
                using (SqlConnection connection = new SqlConnection(_connString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email], [Pays], [Telephone], [Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [MembreBienEchange].[Membre_Id] WHERE [MembreBienEchange].[BienEchange_Id] = @id_bienEchange";
                        SqlParameter p_id_membre = new SqlParameter() { ParameterName = "id_membre", Value = id_bienEchange };
                        command.Parameters.Add(p_id_membre);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read()) yield return Mapper.ToMembre(reader);
                    }
                }
        }

        public Membre GetByMembreBienEchangeId(int MembreBienEchangeId)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email], [Pays], [Telephone], [Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [Membre_id] WHERE [MembreBienEchange].[IdMembre] = @idMembre";
                    SqlParameter p_id_MembreBienEchange = new SqlParameter() { ParameterName = "id_Membre", Value = MembreBienEchangeId};
                    command.Parameters.Add(p_id_MembreBienEchange);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Membre> GetByBienEchange(int id_bienEchange)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email], [Pays], [Telephone], [Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [MembreBienEchange].[Membre_Id] WHERE [MembreBienEchange].[BienEchange_Id] = @id_bienEchange";
                    SqlParameter p_id_bienEchange = new SqlParameter() { ParameterName = "id_bienEchange", Value = id_bienEchange };
                    command.Parameters.Add(p_id_bienEchange);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public int Insert(Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Membre]([Nom],[Prenom],[Email], [Pays], [Telephone], [Login],[Password] OUTPUT [inserted].[IdMembre] VALUES (@nom, @prenom, @email, @pays, @telephone, @login, @password)";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "password", Value = entity.Password };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int idMembre, Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Membre] SET [Nom] = @nom, [Prenom] = @prenom,[Email] = @email, [Pays] = @pays, [Telephone] = @telephone, [Login] = @login,[Password] = @password  WHERE [IdMembre] = @idMembre";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "password", Value = entity.Password };
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = idMembre };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Membre GetByMembreBienEnchange(int bienEchangeId)
        {
            throw new NotImplementedException();
        }
    }
}
