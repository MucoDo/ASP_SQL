using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class MediaCreateForm
    {
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Le media est obligatoire.")]
        public string lienMedia { get; set; }
        [DisplayName("Choisissez le produit")]
        public int Id_Produit { get; set; }
    }
}
