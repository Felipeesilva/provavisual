using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Pagamentos.AddRange(new Pagamento[]
                {
                    new Pagamento { PagamentoId = 9, FormaPagamento = "pix", Moeda = "Real"},

                }
            );
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 2, Nome = "Alimentos" },

                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Alface", Preco = 5, Quantidade = 2, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Arroz", Preco = 10, Quantidade = 3, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "Carne", Preco = 15, Quantidade = 4, CategoriaId = 1 },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}