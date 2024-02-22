using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class MediaCreateForm
    {
   
        [DisplayName("Image")]
        [Required(ErrorMessage = "Une image est obligatoire.")]
        public string ImageUrl { get; set; }

        [DisplayName("Produit")]
        [Required(ErrorMessage = "Un produit doit être choisie.")]
        public int Id_Produit { get; set; }
    }
}
