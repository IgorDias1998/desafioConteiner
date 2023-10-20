using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioConteiner.Context;
using DesafioConteiner.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioConteiner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConteinerController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ConteinerController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("ListarConteiner")]
        public IActionResult ListarMovimentacao()
        {
            var listaConteiner = _context.Conteiners.ToList();
            return Ok(listaConteiner);
        }

        [HttpGet("BuscarId")]
        public IActionResult ObterId(int id)
        {
            var conteinerId = _context.Conteiners.Find(id);
            if(conteinerId == null)
            {
                return NotFound();
            }

            return Ok(conteinerId);
        }

        [HttpPost("CriarConteiner")]
        public IActionResult CriarConteiner(Conteiner conteiner)
        {
            _context.Conteiners.Add(conteiner);
            _context.SaveChanges();

            return Ok(conteiner);
        }

        [HttpPut("AtualizarConteiner")]
        public IActionResult AtualizarConteiner(int id, Conteiner conteiner)
        {
            var atualizarConteiner = _context.Conteiners.Find(id);
            if(atualizarConteiner == null)
            {
                return NotFound();
            }

            atualizarConteiner.Cliente = conteiner.Cliente;
            atualizarConteiner.TipoConteiner = conteiner.TipoConteiner;
            atualizarConteiner.TipoCategoria = conteiner.TipoCategoria;
            atualizarConteiner.TipoStatus = conteiner.TipoStatus;
            atualizarConteiner.NumeroConteiner = conteiner.NumeroConteiner;

            _context.Conteiners.Update(atualizarConteiner);
            _context.SaveChanges();

            return Ok(atualizarConteiner);
        }

        [HttpDelete("DeletarConteiner")]
        public IActionResult DeletarConteiner(int id)
        {
            var conteinerDeletar = _context.Conteiners.Find(id);
            if(conteinerDeletar == null)
            {
                return NotFound();
            }

            _context.Conteiners.Remove(conteinerDeletar);
            _context.SaveChanges();

            return NoContent();

        }

    }
}