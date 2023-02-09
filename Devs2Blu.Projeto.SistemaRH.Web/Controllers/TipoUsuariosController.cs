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
    [Route("/usuarios/tipos")]
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

        //[Route("/detalhes")]
        //public IActionResult Details()
        //{
        //    return View();
        //}

        [Route("/criar")]
        public IActionResult Create() 
        {
            return View();
        }

        [Route("/editar")]
        public IActionResult Edit()
        {
            return View();
        }

        [Route("/deletar")]
        public IActionResult Delete() 
        {
            return View();
        }

        #endregion

        [HttpPost, Route("/createTipo")]
        public async Task<IActionResult> CreateTipoUsuario([Bind("Nome")]TipoUsuarios obj)
        {
            await _repository.Save(obj);
            return RedirectToAction("Index");
        }

        [HttpPut, Route("/alteraTipo")]
        public async Task<IActionResult> UpdateTipoUsuario([Bind("Id", "Nome")]TipoUsuarios obj)
        {
            await _repository.Update(obj);
            return RedirectToAction("Index");
        }

        [HttpDelete, Route("/deleteTipo")]
        public async Task<IActionResult> DeleteTipoUsuario([Bind("Id", "Nome")]TipoUsuarios obj)
        {
            await _repository.Delete(obj);
            TempData["Message"] = $"Tipo de Usuário : {obj.Nome} excluído com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
