using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_EcoResp.Entities
{
    public class Produit
    {
        public Produit(int id_Produit, string nomProduit, string description, decimal prix, string ecoScore, string cat)
        {
            Id_Produit = id_Produit;
            NomProduit = nomProduit;
            Description = description;
            Prix = prix;
            EcoScore = ecoScore;
            Cat = cat;
        }

        public int Id_Produit { get; set; }
        public string NomProduit { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string EcoScore { get; set; }
        public string Cat { get; set; }
    }
}
