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
    public class GuiaController : Controller
    {
        private readonly ApprendendoContext _context;
        public GuiaController(ApprendendoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Guia>> GetAll()
        {
            return _context.Guia.ToList();
        }
        [HttpGet]
        public ActionResult<List<Guia>> Get(int GuiaId)
        {
            try
            {
                var result = _context.Guia.Find(GuiaId);
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
       public async Task<ActionResult> post(Guia model)
        {

            try
            {
                _context.Guia.Add(model);
                if (await _context.SaveChangesAsync() == 1)
                {                    
                    return Created($"/api/Guia/{model.Id}", model);
                }
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }

            // retorna BadRequest se não conseguiu incluir
            return BadRequest();
        }
        [HttpPut("{GuiaId}")]
        public async Task<IActionResult> put(int GuiaId, Guia dadosGuia)
        {
            try
            {                
                //verifica se existe Guia a ser alterado
                var result = await _context.Guia.FindAsync(GuiaId);
                if (GuiaId != result.Id)
                {
                    return BadRequest();
                }
                result.NomeApp = dadosGuia.NomeApp;
                result.Link = dadosGuia.Link;                
                await _context.SaveChangesAsync();
                return Created($"/api/Guia/{dadosGuia.Id}", dadosGuia);
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
            }
        }
        [HttpDelete("{GuiaId}")]
       public async Task<ActionResult> delete(int GuiaId)
        {
            try
            {
                //verifica se existe Guia a ser excluído
                var Guia = await _context.Guia.FindAsync(GuiaId);
                if (Guia == null)
                {                    
                    return NotFound();
                }
                _context.Remove(Guia);
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