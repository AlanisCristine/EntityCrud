using AutoMapper;
using CrudEntity;
using Infraestrutura;
using Infraestrutura.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;
        public PessoaController(IPessoaRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Adicionar(Pessoa pessoa)
        {
            try
            {
                List<ReadPessoaDTO> pessoaDTO = _mapper.Map<List<ReadPessoaDTO>>(_repository.Listar());
                return Ok(pessoaDTO);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Pessoa>> List()
        {
            try
            {
                List<ReadPessoaDTO> pessoaDTO = _mapper.Map<List<ReadPessoaDTO>>(_repository.Listar());
                return Ok(pessoaDTO);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public  ActionResult<List<Pessoa>> Editar(Pessoa p)
        {
            try
            {
                _repository.Editar(p);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            try
            {
                _repository.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
