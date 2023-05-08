using Attornatus.Core.Entities;
using Attornatus.Services.DTOs.PessoaDTOs;
using Attornatus.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Attornatus.Application.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class PessoaController : Controller
    {
        private readonly IPessoaService _services;
        private readonly IMapper _mapper;

        public PessoaController(IPessoaService services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPessoaDTO dto)
        {
            try
            {
                _services.Cadastrar(dto);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(Guid id, AlterarPessoaDTO dto)
        {
            try
            {
                _services.Alterar(id, dto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }        

        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id) 
        {
            try
            {
                _services.Deletar(id);
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
                var pessoas = _services.Consultar();
                return Ok(pessoas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult ConsultarPorId(Guid id)
        {
            try
            {
                var pessoa = _services.ConsultarPorId(id);
                return Ok(pessoa);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("Enderecos/{idPessoa}")]
        public IActionResult ConsultarComEnderecos(Guid idPessoa)
        {
            try
            {
                var pessoa = _services.ConsultarComEnderecos(idPessoa);
                return Ok(pessoa);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
