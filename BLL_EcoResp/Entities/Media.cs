using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_EcoResp.Entities
{
    public class Media
    {
        public Media(int id_Media, string lienMedia, int id_Produit)
        {
            Id_Media = id_Media;
            lienMedia = lienMedia;
            Id_Produit = id_Produit;
        }

        public int Id_Media { get; set; }
        public string lienMedia { get; set; }
        public int Id_Produit { get; set; }

    }
}
