using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Venda
    {
        public Venda() => CriadoEm = DateTime.Now;
        public int VendaId { get; set; }
        public int ItensVendaId { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}