using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class ProduitListItemViewModel
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }

        [DisplayName("Produit")]
        public string Nom {  get; set; }

        public decimal Prix { get; set; }

        public char Ecoscore { get; set; }

        public string Categorie { get; set; }
    }
}
