using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class ProduitEditForm
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le nom ne peut dépasser 64 caractères.")]
        [MinLength(2, ErrorMessage = "Le nom doit avoir au minimum 2 caractères.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La description est obligatoire.")]
        [MinLength(80, ErrorMessage = "La description doit avoir au minimum 80 caractères.")]
        [MaxLength(8000, ErrorMessage = "La description ne peut dépasser 8000 caractères.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le prix est obligatoire.")]
        
        public decimal Prix { get; set; }

        [Required(ErrorMessage = "L'ecoscore est obligatoire.")]
        public char Ecoscore { get; set; }

        [Required(ErrorMessage = "La categorie est obligatoire.")]
        [MaxLength(64, ErrorMessage = "La categoriee ne peut dépasser 64 caractères.")]
        [MinLength(4, ErrorMessage = "La categorie doit avoir au minimum 4 caractères.")]
        public string Categorie { get; set; }
    }
}
