using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Dominio.Entidades
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required]
        [StringLength(250)]
        public required string Nome { get; set; } = default!;

        [StringLength(100)]
        public required string Marca { get; set; } = default!;

        [StringLength(20)]
        public int Ano { get; set; } = default!;

    }
}