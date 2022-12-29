using System.ComponentModel.DataAnnotations;

namespace Catalogo_Pecas.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
