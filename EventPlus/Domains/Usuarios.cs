using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{

    
    public class Usuarios
    {
        [Key]
        public Guid IdUsuario { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome usuario é obrigatorio")]
        public string? NomeUsuario {get; set;}

        [Required(ErrorMessage = "O tipoUsuario é obeigatorio")]
        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TiposUsuarios? TipoUsuario { get; set; }
        
        [Column(TypeName = "VARCHAR(255)")]
        [Required(ErrorMessage = "Email obrigatorio")]
        public string? Email {  get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "A senha é obrigatorio")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Asenha deve conter entre 5 a 30 caracteres")]
        public string? Senha { get; set; }
    }
}
