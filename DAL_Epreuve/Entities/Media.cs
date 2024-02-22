using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Media
    {
        public int Id_Media {get; set;}

        public string ImageUrl { get; set;}

        public int Id_Produit { get; set;}

    }
}
