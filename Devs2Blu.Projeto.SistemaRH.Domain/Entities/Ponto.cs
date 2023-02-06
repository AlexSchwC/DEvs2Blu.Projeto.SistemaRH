using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class Ponto
    {
        public int Id { get; set; }
        public int ColaboradorId { get; set; }
        public string? Local { get; set; }
        public DateTime DataPonto { get; set; }
    }
}
