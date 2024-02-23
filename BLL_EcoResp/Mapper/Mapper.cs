using BLL=BLL_EcoResp.Entities;
using DAL = DAL_EcoResp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using BLL_EcoResp.Entities;

namespace BLL_EcoResp.Mapper
{
    internal static class Mapper
    {
        #region Produit
        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.NomProduit,
                entity.Description,
                entity.Prix,
                Enum.Parse<BLL.EcoScore>(entity.EcoScore),
                entity.Cat
                );
        }
        public static DAL.Produit ToDAL(this BLL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
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

        public static DAL.Media ToDAL(this BLL.Media entity)
        {

            if (entity is null) return null;
            return new DAL.Media()
            {
                Id_Media = entity.Id_Media,
                lienMedia = entity.lienMedia,
                Id_Produit = entity.Id_Produit,

            };
        }
    }
}
