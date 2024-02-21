using DAL_EcoResp.Entities;
using DAL_EcoResp.Mapper;
using Microsoft.Extensions.Configuration;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_EcoResp.Services
{
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration):base(configuration, "ProduitEcoresp")
        {
        }
        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetALL";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }
        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_produit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }
        void ICRUDRepository<Produit, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        int ICRUDRepository<Produit, int>.Insert(Produit data)
        {
            throw new NotImplementedException();
        }

        void ICRUDRepository<Produit, int>.Update(Produit data)
        {
            throw new NotImplementedException();
        }
    }
}
