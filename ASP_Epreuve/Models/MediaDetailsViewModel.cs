using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class MediaDetailsViewModel
    {
        [HiddenInput]
        public int Id_Media {  get; set;}

        [DataType(DataType.ImageUrl)]
        [DisplayName("image")]
        public string ImageUrl { get; set;}

        [HiddenInput]
        public int Id_Produit { get; set;}
    }
}
