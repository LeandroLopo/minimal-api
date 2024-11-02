using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace minimal_api.Dominio.Entidades
{
    public class Administrador
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required]
        [StringLength(255)]
        public required string Email { get; set; } = default!;
        [Required]
        [StringLength(50)]
        public required string Senha { get; set; } = default!;
        [Required]
        [StringLength(20)]
        public required string Perfil { get; set; } = default!;

    }
}