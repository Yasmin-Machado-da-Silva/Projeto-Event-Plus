using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventPlus.Domains
{
    public class Eventos
    {
        [Key]
        public Guid IdTipoEvento { get; set; }
        [Column(TypeName = "Date")]
        [Required]

        [ForeignKey("IdTipoEvento")]
        public TipoEvento? TipoEvento { get; set; }

        public Guid IdInstituicao { get; set; }
        [ForeignKey("IdInstituicao")]

        public Instituicao Instituicao { get; set; }

        public PresencaEventos? PresencaEventos { get; set; }
    }
}
