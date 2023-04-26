using System.ComponentModel.DataAnnotations;

namespace ImageGallery.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string? UserName { get; set; }

        public bool RemeberMe { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
