using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class ProduitListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Produit {  get; set; }
        [DisplayName("Nom du produit")]
        public string NomProduit {  get; set; } 
        [DisplayName("Prix")]
        public decimal Prix {  get; set; } 
        [DisplayName("EcoScore")]
        public string EcoScore {  get; set; } 
    }
}
