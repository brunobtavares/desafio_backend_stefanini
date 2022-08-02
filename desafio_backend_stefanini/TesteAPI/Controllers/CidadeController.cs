using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.Application.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace desafio_backend_stefanini.API.Controllers
{
    [EnableCors("OpenPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;

        public CidadeController(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService ?? throw new ArgumentNullException(nameof(cidadeService));
        }

        /// <summary>
        /// Inclui uma nova cidade
        /// </summary>
        [HttpPost("Inlcuir")]
        public async Task<IActionResult> InlcuirAsync([FromBody] IncluirCidadeDTO dto)
        {
            try
            {
                return Ok(await _cidadeService.IncluirAsync(dto));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        /// <summary>
        /// Altera dados da cidade
        /// </summary>
        [HttpPut("Alterar")]
        public async Task<IActionResult> AlterarAsync([FromBody] AlterarCidadeDTO dto)
        {
            try
            {
                return Ok(await _cidadeService.AlterarAsync(dto));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Remove cidade por ID
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverAsync(Guid id)
        {
            try
            {
                return Ok(await _cidadeService.RemoverAsync(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Busca cidade por ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                return Ok(await _cidadeService.GetByIdAsync(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Busca todas as cidades
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _cidadeService.GetAllAsync());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
