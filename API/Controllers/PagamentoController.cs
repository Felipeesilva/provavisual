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
        public IActionResult Create([FromBody] Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
            return Created("", pagamento);
        }

    //     //GET: api/formaPagamento/list
    //     [HttpPost]
    //     [Route("list")]
    //    // public IActionResult List()
       // {
          //  return Ok(_context.Pagamentos.ToList());
        //}

    }
}