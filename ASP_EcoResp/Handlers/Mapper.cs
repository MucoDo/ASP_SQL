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
                Id_Produit=entity.Id_Produit,
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
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Cat = entity.Cat
            };
        }
        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(0,entity.NomProduit, entity.Description, entity.Prix, entity.EcoScore, entity.Cat);
        }
        #endregion
    }
}
