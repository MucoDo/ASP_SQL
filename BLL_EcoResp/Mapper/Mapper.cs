﻿using BLL=BLL_EcoResp.Entities;
using DAL = DAL_EcoResp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BLL_EcoResp.Mapper
{
    internal static class Mapper
    {
        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.NomProduit,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.Cat
                );
        }
    }
}
