using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Devs2Blu.Projeto.SistemaRH.Domain.Entities;
using Devs2Blu.Projeto.SistemaRH.Infra.Data;
using Devs2Blu.Projeto.SistemaRH.Domain.IRepositories;
using Devs2Blu.Projeto.SistemaRH.Domain.DTO;

namespace Devs2Blu.Projeto.SistemaRH.Web.Controllers
{
    public class TipoUsuariosController : Controller
    {
        private readonly ITipoUsuariosRepository _repository;

        public TipoUsuariosController(ITipoUsuariosRepository repository)
        {
            _repository = repository;
        }

        #region RetornoDasViews

        public IActionResult Index()
        {
            var allTipoCategories = _repository
                .FindAll()
                .Select(tipoUsuario => new TipoUsuariosDTO()
                    {
                        Id= tipoUsuario.Id,
                        Nome = tipoUsuario.Nome,
                    })
                .ToList();
            return View(allTipoCategories);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete() 
        {
            return View();
        }

        #endregion


    }
}
