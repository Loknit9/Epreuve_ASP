using DAL_Epreuve.Entities;
using Microsoft.Extensions.Configuration;
using Shared_epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Epreuve.Mappers;

namespace DAL_Epreuve.Services
{
    public class MediaService : BaseService, IMediaRepository<Media>
    {
        public MediaService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }

        

        public IEnumerable<Media> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMedia();
                        }
                    }
                }
            }
        }

        public Media Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Media data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("ImageUrl", data.ImageUrl);
                    command.Parameters.AddWithValue("Id_Produit", data.Id_Produit);
                    
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Media entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Media", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la DB.");
                }
            }
        }
    }
}
