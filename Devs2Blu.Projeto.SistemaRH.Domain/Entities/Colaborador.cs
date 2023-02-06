using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class Colaborador
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Cargo { get; set; }

        [Required]
        public string? CPF { get; set; }
        public double Remuneracao { get; set; }

        [Required]
        public string? Status { get; set; }
        public DateTime DateAdmissao { get; set; }
        public DateTime? DateDemissao { get; set; }
        public List<int>? PontosId { get; set; }
        public virtual List<Ponto>? Pontos { get; set; }
    }
}
