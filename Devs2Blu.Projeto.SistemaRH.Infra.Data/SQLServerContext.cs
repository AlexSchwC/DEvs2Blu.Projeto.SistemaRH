using Devs2Blu.Projeto.SistemaRH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Infra.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }

        #region DbSets

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<MovimentacaoFinanceira> MovimentacaoFinanceira { get; set; }
        public DbSet<TipoMovimentacao> NaturezaMovimentacao { get; set; }
        public DbSet<Ponto> Ponto { get; set; }

        #endregion
    }
}
