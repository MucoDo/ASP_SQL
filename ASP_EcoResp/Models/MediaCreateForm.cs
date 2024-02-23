using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class MediaCreateForm
    {
        [DisplayName("Images")]
        [Required(ErrorMessage = "Une image du produit est obligatoire.")]
        public IFormFile lienMedia { get; set; }
        [DisplayName("Indiquez le produit")]

        public int Id_Produit { get; set; }
    }
}
