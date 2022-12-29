using Catalogo_Pecas.Utilities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo_Pecas.Models
{
    public partial class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        [StringLength(60)]
        public string NomeH { get; set; }
        [Required]
        [StringLength(60)]
        public string Email { get; set; }
        [StringLength(60)]
        public string EmailH { get; set; }
        [Required]
        [StringLength(80)]
        public string Senha { get; set; }
        [Required]
        [Column("cPF")]
        [StringLength(14)]
        public string CPf { get; set; }
        [Required]
        [StringLength(12)]
        public string Telefone { get; set; }
        [Required]
        [StringLength(60)]
        public string Cidade { get; set; }
        [StringLength(150)]
        public string Mensagem { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}