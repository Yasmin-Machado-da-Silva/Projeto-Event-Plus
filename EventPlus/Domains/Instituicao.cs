using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Domains
{
    [Table("Instituicao")]
    [Index(nameof(CNPJ), IsUnique = true)]

    public class Instituicao
    {
        [Key]
    }
}
