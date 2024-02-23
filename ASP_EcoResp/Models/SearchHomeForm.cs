using BLL_EcoResp.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_EcoResp.Models
{
    public class SearchHomeForm
    {
        [DisplayName("Produits souhaités")]
        public string Search {  get; set; }
 
    }
}
