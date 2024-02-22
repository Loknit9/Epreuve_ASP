using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class MediaCreateForm
    {
        [DisplayName("Image")]
        [Required(ErrorMessage = "Une image est obligatoire.")]
        public IFormFile ImageUrl { get; set; }
    }
}
