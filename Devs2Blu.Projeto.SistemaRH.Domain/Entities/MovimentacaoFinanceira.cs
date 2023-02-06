using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.Entities
{
    public class MovimentacaoFinanceira
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public int TipoMovimentacaoId { get; set; }
        public virtual TipoMovimentacao? TipoMovimentacao { get; set; }
        public int? ProdutoId { get; set; }
        public virtual Produto? Produto { get; set; }
        public int? Quantidade { get; set; }
        public string? Descricao { get; set; }
        public double ValorMovimentacao { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}
