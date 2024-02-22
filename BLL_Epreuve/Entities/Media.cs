using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }

        public string ImageUrl { get; set; }

        public int Id_Produit { get; set; }



        public Media(int id_media, string imageUrl, int id_produit)
        {
            Id_Media = id_media;
            ImageUrl = imageUrl;
            Id_Produit = id_produit;
        }

    }

}
