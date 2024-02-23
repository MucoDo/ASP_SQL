using DAL_EcoResp.Entities;
using Microsoft.Extensions.Configuration;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_EcoResp.Services
{
    public class MediaService : BaseService, IMediaRepository<Media>
    {
        public MediaService(IConfiguration configuration) : base(configuration, "MediaEcoresp")
        {
        }

        public int Insert(Media data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("LienMedia", data.lienMedia);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        void ICRUDRepository<Media, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Media> ICRUDRepository<Media, int>.Get()
        {
            throw new NotImplementedException();
        }

        Media ICRUDRepository<Media, int>.Get(int id)
        {
            throw new NotImplementedException();
        }


        void ICRUDRepository<Media, int>.Update(Media data)
        {
            throw new NotImplementedException();
        }
    }
}
