using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuarios? TipoUsuario { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Senha { get; set; }

        [Required]
        public string? Status { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
