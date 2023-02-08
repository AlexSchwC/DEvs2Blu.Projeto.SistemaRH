using Devs2Blu.Projeto.SistemaRH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Domain.DTO
{
    public class TipoUsuariosDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public TipoUsuariosDTO MapToDTO(TipoUsuarios entity)
        {
            TipoUsuariosDTO usuario = new TipoUsuariosDTO();
            usuario.Id = entity.Id;
            usuario.Nome = entity.Nome;
            return usuario;
        }

        public TipoUsuarios MapToEntity(TipoUsuariosDTO entity)
        {
            TipoUsuarios usuario = new TipoUsuarios();
            usuario.Id = entity.Id;
            usuario.Nome = entity.Nome;
            return usuario;
        }
    }
}
