using AutoMapper;
using CrudEntity;
using Infraestrutura;
using Infraestrutura.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeRepository _repository;
        private readonly IMapper _mapper;

        public CidadeController(ICidadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Adicionar(Cidade cidade)
        {
            try
            {
                _repository.Adicionar(cidade);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

       
        [HttpGet]
        public ActionResult<List<Cidade>> List()
        {
            try
            {
                List<ReadCidadeDTO> cidadeDTO = _mapper.Map<List<ReadCidadeDTO>>(_repository.Listar());
                return Ok(cidadeDTO);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public  ActionResult<List<Cidade>> Editar(Cidade p)
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
