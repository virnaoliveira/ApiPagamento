using ApiPagamentos.Model;
using DesafioApiCompras.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiPagamento.Controller
{
    [ApiController]
    [Route("api/[controller]/compras")]
    public class pagamentoController : ControllerBase
    {
        private PagamentoContexto _context;
        public pagamentoController(PagamentoContexto context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Compra compra)
        {
            try
            {
                var retorno = new Pagamento();
                retorno.valor = compra.valor;

                if (statusCompra(compra.valor))
                {
                    retorno.estado = "APROVADO";
                }
                else
                {
                    retorno.estado = "REJEITADO";
                }
                _context.Add(compra);
                _context.SaveChanges();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }

        private bool statusCompra(decimal valor)
        {
            if (valor <= 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
