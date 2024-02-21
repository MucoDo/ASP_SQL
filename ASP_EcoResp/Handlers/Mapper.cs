using ASP_EcoResp.Models;
using BLL_EcoResp.Entities;

namespace ASP_EcoResp.Handlers
{
    public static class Mapper
    {
        public static ProduitListItemViewModel ToListItem(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitListItemViewModel()
            {
                NomProduit = entity.NomProduit,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
            };
        }
    }
}
