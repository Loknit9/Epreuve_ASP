using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class ProduitDetailViewModel
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]

        public int Id_Produit {  get; set; }

        public string Nom {  get; set; }

        public string Description { get; set; }

        public decimal Prix { get; set; }

        public char Ecoscore { get; set; }

        public string Categorie { get; set; }
    }
}
