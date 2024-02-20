using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }

        public string Nom {  get; set; }

        public string Description { get; set; }

        public int Prix { get; set; }

        public char Ecoscore { get; set; }

        public string Categorie { get; set; }


    }
}
