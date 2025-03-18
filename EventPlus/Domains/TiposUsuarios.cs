using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace EventPlus.Domains
{
    [Table("TiposUsuarios")]
    public class TiposUsuarios
    {
        [Key]
        public Guid IdTipoUsuario { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo eh obrigatorio")]

        public string? TituloTipoUsuario { get; set; }
    }
}
