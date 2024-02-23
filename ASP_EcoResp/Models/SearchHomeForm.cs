using BLL_EcoResp.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class SearchHomeForm
    {
        [DisplayName("Nom ou catégorie")]
        public string? Search {  get; set; }

        public EcoScore? EcoScore { get; set; }
     
    }
}
