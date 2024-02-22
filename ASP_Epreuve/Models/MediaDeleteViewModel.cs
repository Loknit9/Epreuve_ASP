using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class MediaDeleteViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_Media { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [HiddenInput]
        [Required]
        public int Id_Produit { get; set; }
    }
}
