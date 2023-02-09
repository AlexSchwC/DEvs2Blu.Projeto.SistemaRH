using Devs2Blu.Projeto.SistemaRH.Domain.DTO;
using Devs2Blu.Projeto.SistemaRH.Domain.Entities;
using Devs2Blu.Projeto.SistemaRH.Domain.IRepositories;
using Devs2Blu.Projeto.SistemaRH.Infra.Data;
using Devs2Blu.Projeto.SistemaRH.Infra.Data.Repositories;

namespace Devs2Blu.Projeto.SistemaRH.Web.Controllers
{
    public class TipoUsuariosRepository : Repository<TipoUsuarios>
        , ITipoUsuariosRepository
    {
        private readonly SQLServerContext _context;
        public TipoUsuariosRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}