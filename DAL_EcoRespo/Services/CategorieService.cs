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
    public class CategorieService : BaseService, ICategorieRepository<string>
    {
        public CategorieService(IConfiguration configuration) : base(configuration, "ProduitEcoresp")
        {
        }

        public IEnumerable<string> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_GetALL";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToString();
                        }
                    }
                }
            }
        }






        void ICRUDRepository<string, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        string ICRUDRepository<string, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        int ICRUDRepository<string, int>.Insert(string data)
        {
            throw new NotImplementedException();
        }

        void ICRUDRepository<string, int>.Update(string data)
        {
            throw new NotImplementedException();
        }
    }
}
