using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_EcoResp.Models
{
    public class MediaListViewModel
    {
        
        [HiddenInput]
        [Required]
        public int Id_Media { get; set; }

        [DisplayName("Lien image")]
        [DataType(DataType.ImageUrl)]
        public string lienMedia { get; set; }

        [HiddenInput]
        public int Id_Produit { get; set; }

    }
}
