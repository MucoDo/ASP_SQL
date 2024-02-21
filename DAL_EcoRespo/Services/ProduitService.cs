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
                    command.CommandText = "SP_Produit_GetALL_favoris";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit_Fav();
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
                    command.Parameters.AddWithValue("id_produit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }
        public int Insert(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("nomProduit", data.NomProduit);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("ecoScore", data.EcoScore);
                    command.Parameters.AddWithValue("cat", data.Cat);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("nomProduit", data.NomProduit);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("ecoscore", data.EcoScore);
                    command.Parameters.AddWithValue("cat", data.Cat);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Produit), $"L'identifiant {data.Id_Produit} n'est pas das la base de données");
                }
            }
        }
        void ICRUDRepository<Produit, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

      

    }
}
