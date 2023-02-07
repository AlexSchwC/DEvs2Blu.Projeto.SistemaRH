using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? RazaoSocial { get; set; }

        [Required]
        public string? CNPJ { get; set; }

        [Required]
        public string? CEO { get; set; }

        public virtual List<Colaborador>? Colaboradores { get; set; }
    }
}
