using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class DetailCommande
    {
        public int Id_detailCommande { get; set; }

        public int Id_Produit { get; set; }

        public int Id_Commande { get; set; }

        public int Quantite { get; set; }

    }
}
