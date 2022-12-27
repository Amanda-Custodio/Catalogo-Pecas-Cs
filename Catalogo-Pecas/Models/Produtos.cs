using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo_Pecas.Models
{
    public partial class Produtos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        [Required]
        [StringLength(200)]
        public string Descrição { get; set; }
        public double Preço { get; set; }
    }
}