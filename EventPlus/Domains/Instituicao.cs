using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventPlus.Domains
{
    [Table("Instituicao")]
    [Index(nameof(CNPJ), IsUnique = true)]

    public class Instituicao
    {
        [Key]
        public Guid IdInstutuicao { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome Fantasia eh obrigatorio!")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Eh obrigatorio informar um endereco!")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ eh obrigatorio!")]
        [StringLength(14)]
        public string? CNPJ { get; set; }


    }
}
