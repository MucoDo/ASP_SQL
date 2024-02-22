using BLL_EcoResp.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class SearchHomeForm
    {
        [DisplayName("Recherche par nom ou par catégorie")]
        public string Search {  get; set; }
 
    }
}
