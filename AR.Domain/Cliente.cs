using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.Domain
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } 

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Idade { get; set; }

    }
}
