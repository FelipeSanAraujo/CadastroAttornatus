using Attornatus.Services.DTOs.EnderecoDTOs;
using Attornatus.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Attornatus.Application.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _services;

        public EnderecoController(IEnderecoService services)
        {
            _services = services;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarEnderecoDTO dto)
        {
            try
            {
                _services.Cadastrar(dto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar(AlterarEnderecoDTO dto)
        {
            try
            {
                _services.Alterar(dto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult Consultar()
        {
            try
            {
                var endereco = _services.Consultar();
                return Ok(endereco);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}