﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_EcoResp.Models
{
    public class ProduitDeleteForm
    {
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }
        [DisplayName("Nom du produit")]
        public string NomProduit { get; set; }
        [DisplayName("Description du produit")]

        public string Description { get; set; }
        [DisplayName("Prix")]

        public decimal Prix { get; set; }
        [DisplayName("EcoScore")]

        public string EcoScore { get; set; }
        [DisplayName("Categorie")]

        public string Cat { get; set; }
    }
}
