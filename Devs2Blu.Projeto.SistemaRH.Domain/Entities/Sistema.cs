using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class Sistema
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }

        public DateTime CriadoEm = DateTime.Now;

        public string Status = "Ativo";
    }
}
