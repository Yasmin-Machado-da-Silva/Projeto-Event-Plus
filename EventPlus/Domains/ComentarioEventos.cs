using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventPlus.Domains
{
    [Table("ComentariosEventos")]
    public class ComentarioEventos
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Descricao do comentario obrigatoria")]

        public string Descricao { get; set; }
        [Column(TypeName = "BIT")]
        [Required]
        public bool Exibe { get; set; }

        [Required(ErrorMessage = "Usuario Obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]

        public Usuarios? Usuario { get; set; }
    
    }
}
