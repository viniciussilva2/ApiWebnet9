using ApiWEBNET9.Data;
using ApiWEBNET9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWEBNET9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ProdutoModel>> BuscarProdutos()
        {
            var produtos = _context.Produtos.ToList();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoModel> BuscarProdutosPorId(int id)
        {
            var idProduto = _context.Produtos.FirstOrDefault(x => x.Id == id);

            if (idProduto == null)
            {
                return NotFound($"Produto não encontrado.");
            }

            return Ok(idProduto);
        }

        [HttpPost]
        public ActionResult<ProdutoModel> CriarProduto(ProdutoModel produtoModel)
        {
            if (produtoModel == null)
            {
                return BadRequest("Ocorreu um erro ao criar um novo produto.");
            }

            _context.Produtos.Add(produtoModel);
            _context.SaveChangesAsync();

            return CreatedAtAction(nameof(BuscarProdutosPorId), new { id = produtoModel.Id }, produtoModel);
        }

                


    }
}
