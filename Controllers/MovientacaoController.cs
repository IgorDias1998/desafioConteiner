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
    public class MovientacaoController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MovientacaoController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("ListarMovimentacoes")]
        public IActionResult ListaMovimentacoes()
        {
            var movimentacaoListar = _context.Movimentacaos.ToList();
            return Ok(movimentacaoListar);
        }

        [HttpGet("BuscarPorId")]
        public IActionResult BuscarPorId(int id)
        {
            var movimentacaoId = _context.Movimentacaos.Find(id);
            if(movimentacaoId == null)
            {
                return NotFound();
            }
            return Ok(movimentacaoId);
        }

        [HttpPost("CriarMovimentacoes")]
        public IActionResult CriarMovimentacao(Movimentacao movimentacao)
        {
            _context.Movimentacaos.Add(movimentacao);
            _context.SaveChanges();

            return Ok(movimentacao);
        }

        [HttpPut("AtualizarMovimentacao")]
        public IActionResult AtualizarMovimentacao(int id, Movimentacao movimentacao)
        {
            var atualizarMovimentacao = _context.Movimentacaos.Find(id);
            if(atualizarMovimentacao == null)
            {
                return NotFound();
            }

            atualizarMovimentacao.IdMovimentacao = movimentacao.IdMovimentacao;
            atualizarMovimentacao.DataHoraInicio = movimentacao.DataHoraInicio;
            atualizarMovimentacao.DataHoraFim = movimentacao.DataHoraFim;
            atualizarMovimentacao.TipoMovimentacao = movimentacao.TipoMovimentacao;
            atualizarMovimentacao.IdConteiner = movimentacao.IdConteiner;

            _context.Movimentacaos.Update(atualizarMovimentacao);
            _context.SaveChanges();

            return Ok(atualizarMovimentacao);
        }

        [HttpDelete("DeletarMovimentacao")]
        public IActionResult DeletarMovimentacao(int id)
        {
            var movimentacaoDeletar = _context.Movimentacaos.Find(id);
            if(movimentacaoDeletar == null)
            {
                return NotFound();
            }

            _context.Movimentacaos.Remove(movimentacaoDeletar);
            _context.SaveChanges();

            return NoContent();
        }

    }
}