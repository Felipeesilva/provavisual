using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pagamento")]
    public class PagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public PagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/pagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Pagamentos.AddRange(new Pagamento[]
                {
                    new Pagamento { PagamentoId = 7, FormaPagamento = "pix", Moeda = "Real"},

                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Forma de pagamento cadastrada com sucesso!" });
        }


    }
}