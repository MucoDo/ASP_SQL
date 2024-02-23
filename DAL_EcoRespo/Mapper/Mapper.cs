using DAL_EcoResp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_EcoResp.Mapper
{
    internal static class Mapper
    {
        #region Produit
        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                NomProduit = (string)record["NomProduit"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                EcoScore = (string)record["EcoScore"],
                Cat = (string)record["Cat"]
            };
        }

        public static Produit ToProduit_Fav(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                NomProduit = (string)record["NomProduit"]
            };
        }
        #endregion
        #region Media

        public static Media ToMedia(this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Id_Media = (int)record["Id_Media"],
                Id_Produit = (int)record["Id_Produit"],
                lienMedia = (string)record["lienMedia"],
            };
        }
        #endregion


    }
}
