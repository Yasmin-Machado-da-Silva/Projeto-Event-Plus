using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("PresencasEventos")]
    public class PresencaEventos
    {
        [Key]
        public Guid IdPresencaEvento { get; set; }
        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Situação obrigatótio")]

        public bool Situacao {  get; set; }

        [Required(ErrorMessage = "Usuario obrigatorio")]

        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios Usuario { get; set; }
        [Required(ErrorMessage = "Evento obrigatorio")]
        
        public Guid IdEvento { get; set; }
        
        [ForeignKey("IdEvento")]
        public Eventos? evento { get; set; }

    }
}
