using BLL_EcoResp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_EcoResp.Models
{
    public class ProduitEditForm
    {
        [HiddenInput]
        public int Id_Produit {  get; set; }

        [DisplayName("Nom du produit")]
        [Required(ErrorMessage = "Le nom du produit est obligatoire.")]
        [MaxLength(100, ErrorMessage = "Le prénom ne peut dépasser 100 caractères.")]
        [MinLength(2, ErrorMessage = "Le prénom doit avoir au minimum 2 caractères.")]
        public string NomProduit { get; set; }
        [DisplayName("Description du produit")]
        [Required(ErrorMessage = "La description du produit est obligatoire.")]
        [MaxLength(100, ErrorMessage = "Le description ne peut dépasser 100 caractères.")]
        [MinLength(2, ErrorMessage = "La description doit avoir au minimum 2 caractères.")]

        public string Description { get; set; }
        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Le prix du produit est obligatoire.")]
        public decimal Prix { get; set; }
        [DisplayName("EcoScore")]
        [Required(ErrorMessage = "L'EcoScore du produit est obligatoire.")]

        public EcoScore EcoScore { get; set; }
        [DisplayName("Categorie")]
        [Required(ErrorMessage = "La catégorie du produit est obligatoire.")]

        public string Cat { get; set; }
    }
}
