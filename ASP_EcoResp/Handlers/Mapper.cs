using ASP_EcoResp.Models;
using BLL_EcoResp.Entities;

namespace ASP_EcoResp.Handlers
{
    public static class Mapper
    {
        #region Produit
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

        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel()
            {
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Cat = entity.Cat
            };
        }
        #endregion
    }
}
