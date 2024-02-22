using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class MediaListViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_Media {  get; set; }

        [DisplayName("Lien image")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [HiddenInput]
        public int Id_Produit { get; set; }

    }
}
