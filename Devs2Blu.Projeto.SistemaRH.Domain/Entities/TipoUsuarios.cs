using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class TipoUsuarios
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }
    }
}
