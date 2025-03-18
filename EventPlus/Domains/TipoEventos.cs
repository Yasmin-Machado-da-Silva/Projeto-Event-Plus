using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{

    [Table ("TipoEventos")]
    public class TipoEventos
    {
        [Key]
        public Guid TipoEventosId { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O nome do evento eh obrigatorio")]

        public string? TituloTipoEvento { get; set; }

    }
}
