using AutoMapper;
using CrudEntity;
using Infraestrutura;
using Infraestrutura.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Adicionar(Produto produto)
        {
            try
            {
                _repository.Adicionar(produto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Produto>> List()
        {
            try
            {
                List<ReadProdutoDTO> pessoaDTO = _mapper.Map<List<ReadProdutoDTO>>(_repository.Listar());
                return Ok(pessoaDTO);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public  ActionResult<List<Produto>> Editar(Produto p)
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
