using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }

        public string Nom {  get; set; }

        public string Description { get; set; }

        public decimal Prix { get; set; }   

        public char Ecoscore { get; set; }

        public string Categorie { get; set; }


        public Produit(int id_produit, string nom, string description, decimal prix, char ecoscore, string categorie)
        {
            Id_Produit = id_produit;
            Nom = nom;
            Description = description;
            Prix = prix;
            Ecoscore = ecoscore;
            Categorie = categorie;

        }

       
    }
}
