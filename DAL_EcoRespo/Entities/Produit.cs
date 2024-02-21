using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_EcoResp.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string NomProduit { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string EcoScore { get; set; }
        public string Cat { get; set; }

    }
}
