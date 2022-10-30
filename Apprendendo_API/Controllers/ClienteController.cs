using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apprendendo_API.Data;
using Apprendendo_API.Models;

namespace Apprendendo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly ApprendendoContext _context;
        public ClienteController(ApprendendoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Cliente>> GetAll()
        {
            return _context.Cliente.ToList();
        }
        [HttpGet("{ClienteId}")]                
        public ActionResult<List<Cliente>> Get(int ClienteId)
        {
            try
            {
                var result = _context.Cliente.Find(ClienteId);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }
        }

        [HttpPost]
       public async Task<ActionResult> post(Cliente model)
        {

            try
            {
                _context.Cliente.Add(model);
                if (await _context.SaveChangesAsync() == 1)
                {                    
                    return Created($"/api/cliente/{model.Id}", model);
                }
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }
            
            // retorna BadRequest se não conseguiu incluir
            return BadRequest();
        }
        [HttpPut("{ClienteId}")]
        public async Task<IActionResult> put(int ClienteId, Cliente dadosCliente)
        {
            try
            {                
                //verifica se existe cliente a ser alterado
                var result = await _context.Cliente.FindAsync(ClienteId);
                if (ClienteId != result.Id)
                {
                    return BadRequest();
                }
                result.Username = dadosCliente.Username;
                result.Senha = dadosCliente.Senha;                
                await _context.SaveChangesAsync();
                return Created($"/api/cliente/{dadosCliente.Id}", dadosCliente);
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }
        }
        [HttpDelete("{ClienteId}")]
       public async Task<ActionResult> delete(int ClienteId)
        {
            try
            {
                //verifica se existe cliente a ser excluído
                var cliente = await _context.Cliente.FindAsync(ClienteId);
                if (cliente == null)
                {                    
                    return NotFound();
                }
                _context.Remove(cliente);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }
            // retorna BadRequest se não conseguiu deletar            
        }
    }
}