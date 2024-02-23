using ASP_EcoResp.Models;
using BLL_EcoResp.Entities;
using System.Net.Http.Headers;

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
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore.ToString()
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
                EcoScore = entity.EcoScore.ToString(),
                Cat = entity.Cat
            };
        }
        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(0,entity.NomProduit, entity.Description, entity.Prix, entity.EcoScore, entity.Cat);
        }

        public static ProduitEditForm ToEditForm(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitEditForm()
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Cat = entity.Cat
            };

        }

        public static Produit ToBLL(this ProduitEditForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.NomProduit,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.Cat);

        }
        public static ProduitDeleteForm ToDelete(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteForm()
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore.ToString(),
                Cat = entity.Cat
            };
        }
        #endregion

        #region Media

        public static Media ToBLL(this MediaCreateForm entity)
        {
            if (entity is null) return null;
            return new Media
            (
                0,
                entity.lienMedia,
                entity.Id_Produit
          
            );
        }
        #endregion
    }
}
