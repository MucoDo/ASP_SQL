using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_EcoResp.Entities
{
    public class ProduitCommande
    {
        public int Id_ProduitCommande {  get; set; }
        public int Quantité { get; set; }
        public int Id_Produit {  get; set; }
        public int Id_Commande { get; set; }
    }
}
