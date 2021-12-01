using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

        //POST: api/venda/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Venda venda)
        {
            //criação da venda
            venda.Pagamento = _context.Pagamentos.Find(venda.PagamentoId);
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return Created("", venda);
        }
        //GET: api/venda/list
        //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
        [HttpPost]
        [Route("list")]
        public IActionResult List()
        {
            var venda = new ObjectResult(new {
                vendas = _context.Vendas.ToList()});

            return venda;
        }
    }
}